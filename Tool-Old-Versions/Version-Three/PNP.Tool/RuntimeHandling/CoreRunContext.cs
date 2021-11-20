using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PNP.Tool.Core.BaseObj;
using PNP.Tool.Core.Global;
using PNP.Tool.Databases.Base;
using PNP.Tool.Services;
using PNP.Tool.Services.Core.Logger;
using PNP.Tool.UI;
using PNP.Tool.Updating;
using PNP_UI.Core.Main;

namespace PNP.Tool.RuntimeHandling {
    public class CoreRunContext : ApplicationContext
    {
        #region Properties
        private bool AppStopped = false;
        private readonly Timer TimeOutCheckLoop = new();
        private readonly Timer KillRepeatLoop = new();
        #endregion

        public CoreRunContext()
        {
            //Prepare Context
            Application.Idle += IdleEvent;
            Application.ApplicationExit += OnExit;
            TimeOutCheckLoop.Tick += TimeOutCheck;
            TimeOutCheckLoop.Interval = 30000;
            KillRepeatLoop.Tick += KillEvent;
            KillRepeatLoop.Interval = 1000;

            //Check For Updates
            new UpdaterFactory().GetUpdater().Update(); ;

            //Create Global Seasion Token
            GlobalSeasionToken.CreateToken();

            //Build Global Service Provider
            List<IDPInjectionRegister> RegisterList = new();
            RegisterList.Add(new ServiceRegister());
            RegisterList.Add(new PresenterRegister());
            GlobalServiceProvider.RegisterServices(RegisterList);

            //Enable Logging for DBs
            DatabaseProvider.LogDatabaseError = LoggerFactory.DBLogging;
            //Migrate all DBs
            DatabaseProvider.MigrateAllDatabases();

            //Start Work
            var x = new FrmMain();
            List<ModuleInfo> infos = new() {
                new(Core.Enums.Modules.EnumModuleGrouping.None, Core.Enums.Modules.EnumModule.None, "TestTitle1", "TestDesc1"),
                new(Core.Enums.Modules.EnumModuleGrouping.None, Core.Enums.Modules.EnumModule.PokemonVerwaltung, "TestTitle2", "TestDesc2"),
                new(Core.Enums.Modules.EnumModuleGrouping.DSA4_1, Core.Enums.Modules.EnumModule.None, "TestTitle3", "TestDesc3"),
                new(Core.Enums.Modules.EnumModuleGrouping.Pokemon, Core.Enums.Modules.EnumModule.None, "TestTitle4", "TestDesc4"),
                new(Core.Enums.Modules.EnumModuleGrouping.SR4, Core.Enums.Modules.EnumModule.None, "TestTitle5", "TestDesc5"),
                new(Core.Enums.Modules.EnumModuleGrouping.Pokemon, Core.Enums.Modules.EnumModule.PokemonVerwaltung, "TestTitle6", "TestDesc6")
            };
            x.LoadModuleList(infos);
            x.Show();
        }

        #region Public-Functions

        public void StopAll()
        {
            AppStopped = true;
            KillApp();
        }

        #endregion

        #region Private-Functions

        private void OnExit(object sender, EventArgs e)
        {
            if (!KillRepeatLoop.Enabled)
            { KillApp(); }
        }

        private void IdleEvent(object sender, EventArgs e)
        {
            if (AppStopped)
            {
                KillApp();
                return;
            }
            if (Application.OpenForms.Count < 1)
            { TimeOutCheckLoop.Start(); }
        }

        private void TimeOutCheck(object sender, EventArgs e)
        {
            if (AppStopped)
            {
                KillApp();
                return;
            }
            TimeOutCheckLoop.Stop();
            if (Application.OpenForms.Count < 1)
            { KillApp(); }
        }

        private void KillEvent(object sender, EventArgs e)
        { Application.Exit(); }

        private void KillApp()
        {
            if (TimeOutCheckLoop.Enabled)
            { TimeOutCheckLoop.Stop(); }
            KillRepeatLoop.Start();
        }

        #endregion
    }
}

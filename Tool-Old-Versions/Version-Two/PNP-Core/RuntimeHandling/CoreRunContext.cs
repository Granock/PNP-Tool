using PNP_Core.Updating;
using PNP_Services;
using PNP_UI;
using PNP_UI.CoreFunctionalities.Main;
using System;
using System.Windows.Forms;

namespace PNP_Core.RuntimeHandling
{
    public class CoreRunContext : ApplicationContext
    {
        #region Properties
        private bool AppStopped = false;
        private readonly Timer testtimer = new();
        private readonly Timer killtimer = new();
        #endregion

        public CoreRunContext()
        {
            //Prepare Context
            Application.Idle += IdleEvent;
            Application.ApplicationExit += OnExit;
            testtimer.Tick += TimeOutCheck;
            testtimer.Interval = 30000;
            killtimer.Tick += KillEvent;
            killtimer.Interval = 1000;

            //Check For Updates
            new Updater().Update();

            //Create Seasion Token
            SeasionToken.CreateToken();

            //Build Service Provider
            GlobalServiceProvider.RegisterServices(new() { new PresenterRegister() });

            //Start Work
            MainPresenter mp = GlobalServiceProvider.GetRequiredService<MainPresenter>();
            mp.PresenterCloses += StopAll;
            mp.StartPresenter();
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
            if (!killtimer.Enabled)
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
            { testtimer.Start(); }
        }

        private void TimeOutCheck(object sender, EventArgs e)
        {
            if (AppStopped)
            {
                KillApp();
                return;
            }
            testtimer.Stop();
            if (Application.OpenForms.Count < 1)
            { KillApp(); }
        }

        private void KillEvent(object sender, EventArgs e)
        { Application.Exit(); }

        private void KillApp()
        {
            if (testtimer.Enabled)
            { testtimer.Stop(); }
            killtimer.Start();
        }

        #endregion
    }
}

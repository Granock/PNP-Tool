using PNP.Core.Core.Presenter.Main;
using System;
using System.IO;
using System.Windows.Forms;

namespace PNP.Core.Core
{
    public class CoreApplicationContext : ApplicationContext
    {
        private readonly Timer _timer = new Timer();

        public CoreApplicationContext()
        {
            Application.ApplicationExit += OnApplicationExit;
            Application.Idle += IdleEvent;
            _timer.Tick += TimeoutCheck;
            _timer.Interval = 30000;
            MainPresenter MP = new MainPresenter();
            MP.PresenterCloses += MainClose;
            MP.StartPresenter();
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            string LogMessage = $"Application stopped. Sender: {(sender != null ? sender.ToString() : "Null")} | EventArgs: {(e != null ? e.ToString() : "NULL")}\n";
            File.AppendAllText("CoreLog.log", LogMessage); 
        }

        private void MainClose()
        {
            if (Application.OpenForms.Count < 1)
            { Application.Exit(); }
            else
            { IdleEvent(null,null); }
        }

        private void IdleEvent(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count < 1)
            { _timer.Start(); }
            else
            { _timer.Stop(); }
        }

        private void TimeoutCheck(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count < 1)
            { Application.Exit(); }
            else
            { _timer.Stop(); }
        }
    }
}

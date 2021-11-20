using PNP.Core.Core.Forms.Settings;
using PNP.Services.Service.Enumerators.Settings;
using PNP.Services.Service.Services.GlobalSettings;
using System;
using System.Collections.Generic;

namespace PNP.Core.Core.Presenter.Settings
{
    public class SettingsPresenter : Presenter<ISettings>
    {
        public SettingsPresenter()
        {
            SetView();
        }
        public override void StartPresenter()
        {
            _view.ShowDialog();
        }

        public void SetView()
        {
            _view = new FrmSettings();
            _view.FrmClosed += SettingsFrmClosed;

            List<Tuple<SettingEnum, object>> Settings = new List<Tuple<SettingEnum, object>>();
            foreach (SettingEnum e in Enum.GetValues(typeof(SettingEnum)))
            { 
                if(GlobalProperties.CanSettingBeChanged(e))
                { 
                    Settings.Add(new Tuple<SettingEnum, object>(e, GlobalProperties.GetSetting(e)));
                }
            }

            _view.Settings = Settings;
        }

        public void SettingsFrmClosed()
        {
            if(_view.DialogResult == System.Windows.Forms.DialogResult.Yes)
            { _view.Settings.ForEach(t => GlobalProperties.SetSetting(t.Item1, t.Item2)); }
        }
    }
}

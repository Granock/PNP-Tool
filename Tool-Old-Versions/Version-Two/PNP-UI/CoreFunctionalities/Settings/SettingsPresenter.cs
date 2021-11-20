using PNP_Services.Services.Core.HistoryService;
using PNP_Services.Services.Core.SettingsService;
using System.Collections.Generic;

namespace PNP_UI.CoreFunctionalities.Settings
{
    public class SettingsPresenter : AbstactPresenter<ISettingsView>
    {
        
        private readonly ISettingsService _settingService;
        private readonly IHistoryService _historyService;

        public SettingsPresenter(ISettingsView view,ISettingsService settingService, IHistoryService historyService)
        {
            _view = view;
            _settingService = settingService;
            _historyService = historyService;
        }

        public override void StartPresenter()
        {
            SetSettings();
            if (_view.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            { SaveSettings(); }
        }

        private void SaveSettings()
        {
            Dictionary<string,object> Settings = _view.GetChangedSettings();
            foreach(string x in Settings.Keys)
            { _settingService.SetSetting(x, Settings[x]); }
            _historyService.WriteHistoryAsync($"Saved {Settings.Count} Setting-Changes.");
        }

        private void SetSettings()
        {
            //TODO
        }
    }
}

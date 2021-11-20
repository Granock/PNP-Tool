using System.Collections.Generic;

namespace PNP_UI.CoreFunctionalities.Settings
{
    public interface ISettingsView : IAbstractInterface
    {
        public void SetSettings(Dictionary<string, object> settings);
        public Dictionary<string, object> GetChangedSettings();
    }
}

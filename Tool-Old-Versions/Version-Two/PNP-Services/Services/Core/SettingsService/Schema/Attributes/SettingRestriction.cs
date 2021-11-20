using System;

namespace PNP_Services.Services.Core.SettingsService.Schema.Attributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
    public class SettingRestriction : Attribute
    {
        private readonly string _DisplayName;
        private readonly string _DisplayDescription;
        public object DefaultValue = null;

        public SettingRestriction(string DisplayName, string DisplayDescription)
        { 
            _DisplayName = DisplayName;
            _DisplayDescription = DisplayDescription;
        }

        public string GetName()
        { return _DisplayName; }

        public string GetDisplayString()
        { return _DisplayDescription; }
    }
}

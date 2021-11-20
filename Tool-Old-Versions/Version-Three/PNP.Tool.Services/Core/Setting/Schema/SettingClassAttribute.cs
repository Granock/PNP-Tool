using System;

namespace PNP.Tool.Services.Core.Setting.Schema
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class SettingClassAttribute : Attribute
    {
        private readonly string _DisplayName;
        private readonly string _DisplayDescription;

        public SettingClassAttribute(string DisplayName, string DisplayDescription)
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

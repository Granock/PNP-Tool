using System;

namespace PNP.Tool.Services.Core.Setting.Schema
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class SettingEntryAttribute : Attribute
    {
        private readonly string _DisplayName;
        private readonly string _DisplayDescription;
        private readonly bool _Editible;
        public object DefaultValue = null;

        public SettingEntryAttribute(string DisplayName, string DisplayDescription, bool Editible)
        { 
            _DisplayName = DisplayName;
            _DisplayDescription = DisplayDescription;
            _Editible = Editible;
        }

        public string GetName()
        { return _DisplayName; }

        public string GetDisplayString()
        { return _DisplayDescription; }

        public bool GetEditible()
        { return _Editible; }
    }
}

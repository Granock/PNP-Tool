using System;

namespace PNP_Services.Databases.Core.SettingDB.Model
{
    public class Setting
    {
        public Setting() { }
        public Setting(string SE, string value)
        { SettingName = SE; Value = value; }
        public Guid SettingGUID { get; set; }
        public string SettingName { get; set; }
        public string Value { get; set; }
    }
}

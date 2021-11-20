namespace PNP.Tool.Models.Core {
    public class SettingEntry : BaseEntity
    {

        #region Constructor

        public SettingEntry() { }
        public SettingEntry(string SE, string value) { SettingName = SE; Value = value; }

        #endregion

        #region Properties

        public string SettingName { get; set; }
        public string Value { get; set; }

        #endregion
    }
}

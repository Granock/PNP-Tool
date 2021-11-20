using PNP.Tool.Services.Core.Setting.Schema;

namespace PNP.Tool.Services.Core.Setting.Structure.Core {
    [SettingClass("Grundeinstellungen","Grundlegende Einstellungen des Tools")]
    public abstract class CoreSettings
    {
        [SettingEntry("CreatorEmail", " Email des Entwicklers", false, DefaultValue = "test.test@outlook.com")]
        public string CreatorEmail { get; }

        [SettingEntry("LogFilePath", "Pfad für die LogDateien", true, DefaultValue = @"Logs\")]
        public string LogFilePath { get; }
    }
}

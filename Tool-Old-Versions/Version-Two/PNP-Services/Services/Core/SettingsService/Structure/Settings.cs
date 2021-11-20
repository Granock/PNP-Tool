using PNP_Services.Services.Core.LanguageService;
using PNP_Services.Services.Core.SettingsService.Schema.Attributes;

namespace PNP_Services.Services.Core.SettingsService.Structure
{
    public abstract class Settings
    {
        [SettingRestriction("CreatorEmail", " Email des Entwicklers", DefaultValue = "test.test@outlook.com")]
        public string CreatorEmail { get; }

        [SettingRestriction("LogFilePath","Pfad für die LogDateien", DefaultValue = @"Logs\")]
        public string LogFilePath { get; }

        [SettingRestriction("LanguageFilePath","Pfad für die Übersetzungsdateien", DefaultValue = @"Languages\")]
        public string LanguageFilePath { get; }

        [SettingRestriction("Sprache","Die ausgewählte Sprache", DefaultValue = LanguageEnum.German)]
        public LanguageEnum CurrentLanguage { get; }
    }
}

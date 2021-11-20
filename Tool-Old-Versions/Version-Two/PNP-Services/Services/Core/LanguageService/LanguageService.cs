using PNP_Services.Services.Core.LanguageService.LanguageStructure;
using PNP_Services.Services.Core.SettingsService;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace PNP_Services.Services.Core.LanguageService
{
    public class LanguageService : ILanguageService
    {
        private readonly ISettingsService _settingService;
        public LanguageService(ISettingsService settingService)
        { _settingService = settingService; }

        public Dictionary<string, string> GetLanguageTranslation()
        {
            string Path = _settingService.GetSetting(x => x.LanguageFilePath);
            LanguageEnum LE = _settingService.GetSetting(x => x.CurrentLanguage);
            if(File.Exists(Path + LE.ToString()))
            {
                LanguageInstance LI = JsonSerializer.Deserialize<LanguageInstance>(Path + LE.ToString());
                return LI.LanguageEntries.ToDictionary(x => x.Key, x => x.Value);
            }else
            { return new Dictionary<string, string>(); }
        }

        public bool WriteTranslation(List<Tuple<string, string>> tuples, LanguageEnum language)
        {
            try
            {
                string Path = _settingService.GetSetting(x => x.LanguageFilePath);
                File.WriteAllText(Path + language.ToString(), 
                    JsonSerializer.Serialize(new LanguageInstance() { LanguageEntries = tuples.Select(x => new LanguageEntry() { Key = x.Item1, Value = x.Item2 }).ToList() }));
                return true;
            }
            catch
            { return false; }
        }
    }
}

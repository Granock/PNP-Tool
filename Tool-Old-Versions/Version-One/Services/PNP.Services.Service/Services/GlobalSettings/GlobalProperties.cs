using PNP.Services.Service.Databases;
using PNP.Services.Service.Enumerators.Settings;
using PNP.Services.Service.Services.GlobalSettings.SettingsFiles;

namespace PNP.Services.Service.Services.GlobalSettings
{
    public static class GlobalProperties
    {
        static GlobalProperties()
        {
            
        }

        public static string GetDatabaseConnectionString(DBEnum dB)
        {
            string dbConString = dB switch
            {
                DBEnum.HistoryDB => Database.Default.HistoryDB,
                DBEnum.PokemonDataDB => Database.Default.PokemonDataDB,
                DBEnum.PokemonMainDB => Database.Default.PokemonMainDB,
                DBEnum.TrainerDataDB => Database.Default.TrainerDataDB,
                DBEnum.TrainerMainDB => Database.Default.TrainerMainDB,
                _ => Database.Default.UnknownDB,
            };
            DBInitializer.EnsureFileExists(dbConString);
            return dbConString;
        }

        public static object GetSetting(SettingEnum setting)
        {
            return setting switch
            {
                SettingEnum.CurrentLanguageSelected => Settings.Default.CurrentLanguageSelected,
                SettingEnum.LanguageFilePath => Settings.Default.LanguageFilePath,
                SettingEnum.CreatorEmail => Settings.Default.CreatorEmail,
                _ => Settings.Default.CurrentLanguageSelected,
            };
        }

        public static void SetSetting(SettingEnum setting, object value)
        {
            switch(setting)
            {
                case SettingEnum.CurrentLanguageSelected: 
                    Settings.Default.CurrentLanguageSelected = int.Parse(value.ToString());
                    break;
            }
            Settings.Default.Save();
        }

        public static bool CanSettingBeChanged(SettingEnum setting)
        {
            return setting switch
            {
                SettingEnum.CurrentLanguageSelected => true,
                _ => false,
            };
        }
    }
}

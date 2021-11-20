using Microsoft.EntityFrameworkCore;
using System.IO;

namespace PNP_Services.Databases
{
    public static class DbInitializer
    {
        public static void Initialize(DbContext context)
        { context.Database.Migrate(); }

        public static bool CheckConnection(DbContext context)
        { return context.Database.CanConnect(); }

        public static void EnsureFileExists(string DBFilePath)
        {
            DBFilePath = DBFilePath.Split("Data Source=", System.StringSplitOptions.RemoveEmptyEntries)[0];
            if (!File.Exists(DBFilePath))
            {
                if (!Directory.Exists(Path.GetDirectoryName(DBFilePath)))
                { Directory.CreateDirectory(Path.GetDirectoryName(DBFilePath)); }
            }
        }

        public static string GetDBConnectionString(DBEnum dB)
        {
            string connection = dB switch
            {
                DBEnum.History => "CoreHistory.db",
                DBEnum.Setting => "CoreSetting.db",
                DBEnum.Icon => "CoreIcon.db",
                DBEnum.PkVerwaltungPokData => "PkPokData.db",
                DBEnum.PKVerwaltungPokMain => "PkPokMain.db",
                DBEnum.PKVerwaltungTrData => "PkTrData.db",
                DBEnum.PkVerwaltungTrMain => "PkTrMain.db",
                _ => @"Data Source=DB\Fallback.db",
            };
            connection = @"Data Source=DB\" + connection;
            EnsureFileExists(connection);
            return connection;
        }
    }
}

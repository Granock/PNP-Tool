using Microsoft.EntityFrameworkCore;
using System.IO;

namespace PNP.Services.Service.Databases
{
    public static class DBInitializer
    {
        public static void Initialize(DbContext context)
        { context.Database.Migrate(); }

        public static bool CheckConnection(DbContext context)
        { return context.Database.CanConnect(); }

        public static void EnsureFileExists(string DBFilePath)
        {
            DBFilePath = DBFilePath.Split("Data Source=", System.StringSplitOptions.RemoveEmptyEntries)[0];
            if(!File.Exists(DBFilePath))
            {
                if (!Directory.Exists(Path.GetDirectoryName(DBFilePath)))
                { Directory.CreateDirectory(Path.GetDirectoryName(DBFilePath)); }
            }
        }
    }
}

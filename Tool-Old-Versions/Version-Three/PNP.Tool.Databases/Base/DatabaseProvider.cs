using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace PNP.Tool.Databases.Base {
    public static class DatabaseProvider {

        #region Database-Providing

        private static readonly Dictionary<DbEnum, Type> _EnumToType = new();
        private static readonly IServiceCollection DatabaseServiceCollection = new ServiceCollection();
        private static IServiceProvider DatabaseServiceProvider { get { if(_DatabaseServiceProvider == null) { InitializeProvider(); } return _DatabaseServiceProvider; }}
        private static IServiceProvider _DatabaseServiceProvider = null;

        public static Action<string> LogDatabaseError { get; set; }
        public static void LogDbError(string message)
            => LogDatabaseError?.Invoke(message);

        private static void InitializeProvider() {
            DatabaseRegister.Register();
            DatabaseServiceCollection.AddTransient(x => GetDatabaseConnection());
            _DatabaseServiceProvider = DatabaseServiceCollection.BuildServiceProvider(new ServiceProviderOptions() { ValidateOnBuild = true });
        }

        public static BaseContext GetDatabase(DbEnum db) {
            return DatabaseServiceProvider.GetRequiredService(_EnumToType[db]) as BaseContext;
        }

        public static ConnectionInfo GetDatabaseConnection() {
            return new() { ConnectionString = "Data Source=Db.db", ConnectionType = DbConnectionType.SQLite };
        }

        public static ConnectionInfo GetDevelopDatabaseConnection() {
            return new() { ConnectionString = "Data Source=DevDb.db", ConnectionType = DbConnectionType.SQLite };
        }

        public static void RegisterDatabase<Context>(DbEnum db) where Context : BaseContext {
            _EnumToType.Add(db, typeof(Context));
        }

        public static void MigrateAllDatabases() {
            foreach(var entry in _EnumToType) {
                using var db = GetDatabase(entry.Key); 
                db.Database.Migrate();
            }
        }

        #endregion
    }
}

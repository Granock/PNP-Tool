using System;
using Microsoft.EntityFrameworkCore;

namespace PNP.Tool.Databases.Base {

    public class ConnectionInfo {

        public string ConnectionString { get; set; }
        public DbConnectionType ConnectionType { get; set; }
        public DbContextOptions Options { get => ConnectionType.ToOptions(ConnectionString); }
    }

    public enum DbConnectionType {
        SQL,
        SQLite,
        InMemoy
    }

    public static class DbEnumExtensions {
        public static DbContextOptions ToOptions(this DbConnectionType ConnectionType, string ConnectionString) {
            var options = new DbContextOptionsBuilder().LogTo(message => DatabaseProvider.LogDbError(message));
            return ConnectionType switch {
                DbConnectionType.SQL => options.UseSqlServer(ConnectionString, x => x.CommandTimeout(2000)).Options,
                DbConnectionType.SQLite => options.UseSqlite(ConnectionString).Options,
                DbConnectionType.InMemoy => options.UseInMemoryDatabase(ConnectionString).Options,
                _ => throw new InvalidConnectionException($"Diesen ConnectionType gibt es nicht: {ConnectionType}"),
            };
        }
    }

    public class InvalidConnectionException : Exception {

        public InvalidConnectionException(string message) : base(message) {
        }
    }

}

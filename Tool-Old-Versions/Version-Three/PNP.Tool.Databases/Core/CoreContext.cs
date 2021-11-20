using Microsoft.EntityFrameworkCore;
using PNP.Tool.Databases.Base;
using PNP.Tool.Models.Core;

namespace PNP.Tool.Databases.Core {
    public class CoreContext : BaseContext
    {
        public CoreContext() : base() { }

        public CoreContext(ConnectionInfo info) : base(info) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Objects of the Model
            modelBuilder.Entity<SettingEntry>();

            //Fluent API implementation  
        }
    }
}

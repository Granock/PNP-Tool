using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PNP.Tool.Core.Global;
using PNP.Tool.Models;
using PNP.Tool.Models.Base;
using PNP.Tool.Models.Interfaces;

namespace PNP.Tool.Databases.Base {
    public abstract class BaseContext : DbContext
    {
        public BaseContext(ConnectionInfo connectionInfo) : base(connectionInfo.Options) {
        }

        /// <summary>
        /// ONLY for DesignTime-Creation like Add-Migration
        /// </summary>
        public BaseContext() : base(DatabaseProvider.GetDevelopDatabaseConnection().Options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            //Objects of the Model
            modelBuilder.Ignore<BaseEntity>();
            modelBuilder.Entity<HistorieEntry>();
            //Fluent API implementation  
        }

        #region SaveChanges

        public override int SaveChanges(bool acceptAllChangesOnSuccess) {
            CheckInterfaces();
            try {
                ChangeTracker.AutoDetectChangesEnabled = false;
                return base.SaveChanges(acceptAllChangesOnSuccess);
            }
            finally {
                ChangeTracker.AutoDetectChangesEnabled = true;
            }
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default) {
            CheckInterfaces();
            try {
                ChangeTracker.AutoDetectChangesEnabled = false;
                return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
            }
            finally {
                ChangeTracker.AutoDetectChangesEnabled = true;
            }
        }

        public override int SaveChanges() {
            CheckInterfaces();
            try {
                ChangeTracker.AutoDetectChangesEnabled = false;
                return base.SaveChanges();
            }
            finally {
                ChangeTracker.AutoDetectChangesEnabled = true;
            }
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) {
            CheckInterfaces();
            try {
                ChangeTracker.AutoDetectChangesEnabled = false;
                return base.SaveChangesAsync(cancellationToken);
            } finally {
                ChangeTracker.AutoDetectChangesEnabled = true;
            }
        }

        public void CheckInterfaces() {
            foreach (var entityEntry in ChangeTracker.Entries()) {
                if (entityEntry.State == EntityState.Deleted && entityEntry.Entity is IUndeletable undeletableEntry) {
                    entityEntry.State = EntityState.Modified;
                    undeletableEntry.Deleted = true;
                }
            }
        }

        #endregion

        #region Query-Types

        public IQueryable<TEntity> Query<TEntity>(bool loadDeletedEntries = false) where TEntity : BaseEntity {
            IQueryable<TEntity> query = this.Set<TEntity>();
            if(typeof(TEntity).IsAssignableTo(typeof(IUndeletable)) && !loadDeletedEntries) {
                query = query.Cast<IUndeletable>().Where(x => !x.Deleted).Cast<TEntity>();
            }
            if(typeof(TEntity).IsAssignableTo(typeof(ISystemSpecific)) && GlobalSeasionToken.SystemGuid.HasValue && GlobalSeasionToken.SystemGuid.Value != Guid.Empty) {
                query = query.Cast<ISystemSpecific>().Where(x => x.SystemGuid == GlobalSeasionToken.SystemGuid.Value).Cast<TEntity>();
            }
            return query;
        }

        #endregion
    }
}

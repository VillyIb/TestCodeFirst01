using System.Data.Common;
using System.Data.Entity;

using DatabaseLayer.Configuration.Pickup;
using Model.Pickup;

namespace DatabaseLayer.Context
{
    public class ContextMainPickup : DbContext
    {
        public virtual DbSet<DispositionSettings> DispositionSettings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            EntityDispositionSettings.Configure(modelBuilder);
        }

        public  ContextMainPickup(DbConnectionStringBuilder dbConnectionStringBuilder)
            : base(dbConnectionStringBuilder.ConnectionString)
        { }

    }
}

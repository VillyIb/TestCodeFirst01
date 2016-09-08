using System.Data.Common;
using System.Data.Entity;

using DatabaseLayer.Configuration.Pickup;
using Model.Pickup;

namespace DatabaseLayer.Context
{

    public partial class ContextSharedPickup : DbContext
    {

        public virtual DbSet<ParcelDetail> ParcelDetail { get; set; }


        public virtual DbSet<Shipment> Shipment { get; set; }


        public virtual DbSet<CustomerPickup> CustomerPickup { get; set; }


        public virtual DbSet<ForwarderPickup> ForwarderPickup { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // "C:\\Users\\Villy-T400\\Documents\\TestCodeFirst01.mdf"
            //var type = modelBuilder.GetType().ToString();


            ComplexAddress.Configure(modelBuilder);

            EntityCustomerPickup.Configure(modelBuilder);
            EntityForwarderPickup.Configure(modelBuilder);
            EntityParcelDetail.Configure(modelBuilder);
            EntityShipment.Configure(modelBuilder);
        }


        // -- Instance

        public ContextSharedPickup()
            : base("name=Model2")
        { }


        public ContextSharedPickup(DbConnectionStringBuilder dbConnectionStringBuilder)
            : base(dbConnectionStringBuilder.ConnectionString)
        { }


    }
}

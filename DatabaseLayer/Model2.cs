using System.Data.Common;

namespace DatabaseLayer
{
    using System.Data.Entity;

    public partial class Model2 : DbContext
    {
        public virtual DbSet<Model.Person> Person { get; set; }

        public virtual DbSet<Model.Person2> Person2 { get; set; }

        public virtual DbSet<Model.Pickup.CustomerPickup> CustomerPickup{ get;set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //Model.Address.Configure(modelBuilder);
            //Model.Person.Configure(modelBuilder);
            //Model.Person2.Configure(modelBuilder);

            new DatabaseLayer.Pickup.PickupConfiguration(modelBuilder).Configure();

        }


        // -- Instance

        public Model2()
            : base("name=Model2")
        { }


        public Model2(DbConnectionStringBuilder dbConnectionStringBuilder)
            : base(dbConnectionStringBuilder.ConnectionString)
        { }


    }
}

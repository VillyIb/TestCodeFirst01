namespace DatabaseLayer
{
    using System.Data.Entity;

    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<Model.Person> Person { get; set; }

        public virtual DbSet<Model.Person2> Person2 { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            Model.Address.Configure(modelBuilder);
            Model.Person.Configure(modelBuilder);
            Model.Person2.Configure(modelBuilder);

        }
    }
}

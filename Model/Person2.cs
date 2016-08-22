using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace Model
{


    public class Person2
    {
        public int Id { get; set; }


        public string Name { get; set; }


        public string Surname { get; set; }


        public Address Address { get; set; }



        // Fluent Configuration 


        public static void Configure(DbModelBuilder modelBuilder)
        {
            var target = modelBuilder.Entity<Person2>();

            target.ToTable("Person2", "pickup");

            var order = 0;
            target.Property(t => t.Id).HasColumnOrder(order++);
            target.Property(t => t.Name).HasColumnOrder(order++).IsRequired().HasMaxLength(100);
            target.Property(p => p.Surname).HasColumnOrder(order++).IsRequired().HasMaxLength(100);

        }


    }
}

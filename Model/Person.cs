using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Model
{


    public class Person
    {
        public int Id { get; set; }


        [Required]
        public string Name { get; set; }


        [Required]
        public string Surname { get; set; }


        [Required]
        public Address Address { get; set; }


        // Fluent Configuration 

        public static void Configure(DbModelBuilder modelBuilder)
        {
            var target = modelBuilder.Entity<Person>();

            target.ToTable("Person", "pickup");

            var order = 0;
            target.Property(t => t.Id).HasColumnOrder(order++);
            target.Property(t => t.Name).HasColumnOrder(order++).IsRequired().HasMaxLength(100);
            target.Property(p => p.Surname).HasColumnOrder(order++).IsRequired().HasMaxLength(100);

        }
    }
}

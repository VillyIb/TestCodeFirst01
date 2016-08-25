using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace Model
{
  
    public class AddressXX
    {
        public int Id { get; set; }

        public string Attention { get; set; }


        //[Required]
        public string City { get; set; }


        //[Required]
        public string CountryCode { get; set; }


        public string Email { get; set; }


        //[Required]
        public string Name { get; set; }

        public string Phone { get; set; }


        public string State { get; set; }


        //[Required]
        public string Street1 { get; set; }


        public string Street2 { get; set; }


        //[Required]
        public string Zip { get; set; }


        // Fluent Configuration 

        public static void Configure(DbModelBuilder modelBuilder)
        {
            var target = modelBuilder.ComplexType<AddressXX>();

            var order = 1000; // Offsett in order not to mix with base tables.

            target.Property(t => t.CountryCode).HasColumnOrder(order++).IsRequired().HasMaxLength(2);
            target.Property(t => t.Zip).HasColumnOrder(order++).IsRequired().HasMaxLength(20);
            target.Property(t => t.City).HasColumnOrder(order++).IsRequired().HasMaxLength(50);
            target.Property(t => t.Street1).HasColumnOrder(order++).IsRequired().HasMaxLength(50);
            target.Property(t => t.Street2).HasColumnOrder(order++).IsRequired().HasMaxLength(50);
            target.Property(t => t.Name).HasColumnOrder(order++).IsRequired().HasMaxLength(50);
            target.Property(t => t.Attention).HasColumnOrder(order++).IsRequired().HasMaxLength(50);

            target.Property(t => t.State).HasColumnOrder(order++).IsRequired().HasMaxLength(2);

            target.Property(t => t.Phone).HasColumnOrder(order++).IsRequired().HasMaxLength(20);
            target.Property(t => t.Email).HasColumnOrder(order++).IsRequired().HasMaxLength(50);

        }
    }
    }

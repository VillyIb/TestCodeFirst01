
using Model.Pickup;

namespace DatabaseLayer.Configuration.Pickup
{
    /// <summary>
    /// Complex Type.
    /// </summary>
    public static class ComplexAddress
    {
        public static void Configure(System.Data.Entity.DbModelBuilder modelBuilder) 
        {
            var target = modelBuilder.ComplexType<Address>();

            target.Property(t => t.Attention).IsRequired().HasMaxLength(50);
            target.Property(t => t.City).IsRequired().HasMaxLength(50);
            target.Property(t => t.CountryCode).IsRequired().HasMaxLength(2);
            target.Property(t => t.Email).IsRequired().HasMaxLength(50);
            target.Property(t => t.Name).IsRequired().HasMaxLength(50);
            target.Property(t => t.Phone).IsRequired().HasMaxLength(20);
            target.Property(t => t.State).IsRequired().HasMaxLength(2);
            target.Property(t => t.Street1).IsRequired().HasMaxLength(50);
            target.Property(t => t.Street2).IsRequired().HasMaxLength(50);
            target.Property(t => t.Zip).IsRequired().HasMaxLength(20);
        }

    }
}

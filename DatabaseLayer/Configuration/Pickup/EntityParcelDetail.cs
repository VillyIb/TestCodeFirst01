
namespace DatabaseLayer.Configuration.Pickup
{
    public static class EntityParcelDetail
    {
        public static void Configure(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            var target = modelBuilder.Entity<Model.Pickup.ParcelDetail>();

            target.ToTable("ParcelDetail", "Pickup");

            // IsRequired and MaxLength
            target.Property(t => t.WaybillNumber).IsRequired().HasMaxLength(50);

            // Order
            var order = 0;

            target.Property(t => t.Id).HasColumnOrder(order++);
            target.Property(t => t.WaybillNumber).HasColumnOrder(order++);

            target.Property(t => t.DryiceWeight).HasColumnOrder(order++);
            target.Property(t => t.Length).HasColumnOrder(order++);
            target.Property(t => t.Width).HasColumnOrder(order++);
            target.Property(t => t.Height).HasColumnOrder(order++);
            target.Property(t => t.Weight).HasColumnOrder(order++);

            target.Property(t => t.ShipmentId).HasColumnOrder(order++);
            target.Property(t => t.WebsiteId).HasColumnOrder(order++);
            target.Property(t => t.WebsiteIdHash).HasColumnOrder(order++);

        }
    }
}

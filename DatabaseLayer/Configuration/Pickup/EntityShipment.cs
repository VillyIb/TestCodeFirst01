
namespace DatabaseLayer.Configuration.Pickup
{
    public static class EntityShipment
    {
        public static void Configure(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            var target = modelBuilder.Entity<Model.Pickup.Shipment>();

            target.ToTable("Shipment", "Pickup");

            // IsRequired and MaxLength
            target.Property(t => t.CarrierName).IsRequired().HasMaxLength(50);
            target.Property(t => t.ForwarderName).IsRequired().HasMaxLength(50);
            target.Property(t => t.WaybillNumber).IsRequired().HasMaxLength(20);

            // HasColumnName
            //target.Property(t => t.Cu)
            //target.HasRequired(t => t.)
            // Order
            var order = 0;

            target.Property(t => t.BranchId).HasColumnOrder(order++);
            target.Property(t => t.CarrierId).HasColumnOrder(order++);
            target.Property(t => t.CarrierName).HasColumnOrder(order++);
            target.Property(t => t.CustomerAccountId).HasColumnOrder(order++);
            target.Property(t => t.CustomerId).HasColumnOrder(order++);
            //target.Property(t => t.CustomerPickup).HasColumnOrder(order++);
            target.Property(t => t.DispositionSettingId).HasColumnOrder(order++);
            target.Property(t => t.DryiceWeight).HasColumnOrder(order++);
            target.Property(t => t.Forwarder1PickupId).HasColumnOrder(order++);
            target.Property(t => t.Forwarder2PickupId).HasColumnOrder(order++);
            target.Property(t => t.Forwarder2WebsiteId).HasColumnOrder(order++);
            target.Property(t => t.ForwarderName).HasColumnOrder(order++);
            target.Property(t => t.GroupIndex).HasColumnOrder(order++);
            target.Property(t => t.Id).HasColumnOrder(order++);
            target.Property(t => t.IsDeleted).HasColumnOrder(order++);
            target.Property(t => t.IsLocked).HasColumnOrder(order++);
            target.Property(t => t.SalesProductId).HasColumnOrder(order++);
            target.Property(t => t.ShipmentDate).HasColumnOrder(order++);
            target.Property(t => t.SourceShipmentId).HasColumnOrder(order++);
            target.Property(t => t.TansportProductId).HasColumnOrder(order++);
            target.Property(t => t.TimestampCreate).HasColumnOrder(order++);
            target.Property(t => t.TimestampUpdate).HasColumnOrder(order++);
            target.Property(t => t.UniqueSequence).HasColumnOrder(order++);
            target.Property(t => t.WaybillNumber).HasColumnOrder(order++);
            target.Property(t => t.WebsiteId).HasColumnOrder(order++);
            target.Property(t => t.WebsiteIdHash).HasColumnOrder(order++);
            target.Property(t => t.Weight).HasColumnOrder(order++);

            target.Property(t => t.Address.Name).HasColumnOrder(order++);
            target.Property(t => t.Address.Street1).HasColumnOrder(order++);
            target.Property(t => t.Address.Street2).HasColumnOrder(order++);
            target.Property(t => t.Address.Zip).HasColumnOrder(order++);
            target.Property(t => t.Address.City).HasColumnOrder(order++);
            target.Property(t => t.Address.CountryCode).HasColumnOrder(order++);
            target.Property(t => t.Address.Attention).HasColumnOrder(order++);
            target.Property(t => t.Address.Email).HasColumnOrder(order++);
            target.Property(t => t.Address.Phone).HasColumnOrder(order++);
            target.Property(t => t.Address.State).HasColumnOrder(order++);

        }
    }
}

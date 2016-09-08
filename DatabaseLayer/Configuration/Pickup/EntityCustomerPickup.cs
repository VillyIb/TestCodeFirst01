
using System.Diagnostics;

namespace DatabaseLayer.Configuration.Pickup
{
    public static class EntityCustomerPickup
    {
        public static void Configure(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            var target = modelBuilder.Entity<Model.Pickup.CustomerPickup>();

            target.ToTable("CustomerPickup", "Pickup");

            // Ignore
            target.Ignore(t => t.PickupOperator);
            target.Ignore(t => t.PickupStatus);

            // IsRequired and HasMaxLength
            target.Property(t => t.Note).IsRequired().HasMaxLength(50);
            target.Property(t => t.PickupOperatorString).IsRequired().HasMaxLength(20);
            target.Property(t => t.PickupStatusString).IsRequired().HasMaxLength(20);
            target.Property(t => t.SpecialTreatment).IsRequired().HasMaxLength(50);

            // HasColumnName
            target.Property(t => t.PickupOperatorString).HasColumnName("PickupOperator");
            target.Property(t => t.PickupStatusString).HasColumnName("PickupStatus");

            // Relation CustomerPickup (1, required) --> (N) Shipment
            target.HasMany(children => children.ShipmentList).WithRequired(parent => parent.CustomerPickup);

            // HasColumnOrder
            var order = 0;

            target.Property(t => t.Id).HasColumnOrder(order++);

            target.Property(t => t.PickupDate).HasColumnOrder(order++);
            target.Property(t => t.CustomerId).HasColumnOrder(order++);
            target.Property(t => t.PickupOperatorString).HasColumnOrder(order++);
            target.Property(t => t.PickupStatusString).HasColumnOrder(order++);
            target.Property(t => t.SpecialTreatment).HasColumnOrder(order++);
            target.Property(t => t.TimeClose).HasColumnOrder(order++);
            target.Property(t => t.TimeReady).HasColumnOrder(order++);
            target.Property(t => t.TimestampUpdate).HasColumnOrder(order++);
            target.Property(t => t.Note).HasColumnOrder(order++);
            target.Property(t => t.TotalWeight).HasColumnOrder(order++);

            target.Property(t => t.BranchId).HasColumnOrder(order++);

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

            target.Property(t => t.ForwarderPickpId).HasColumnOrder(order++);
            target.Property(t => t.ForwarderWebsiteId).HasColumnOrder(order++);
            target.Property(t => t.ForwarderWebsiteIdHash).HasColumnOrder(order++);

            target.Property(t => t.WebsiteId).HasColumnOrder(order++);
            target.Property(t => t.WebsiteIdHash).HasColumnOrder(order++);

            Debug.Assert(order == 27);

        }
    }
}

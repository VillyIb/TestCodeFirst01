
namespace DatabaseLayer.Configuration.Pickup
{
    public static class EntityForwarderPickup
    {
        public static void Configure(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            var target = modelBuilder.Entity<Model.Pickup.ForwarderPickup>();

            target.ToTable("ForwarderPickup", "Pickup");

            target.Ignore(t => t.PickupStatus);

            // IsRequired and HasMaxLength
            target.Property(t => t.AttentionLevel).IsRequired().HasMaxLength(50);
            target.Property(t => t.Note).IsRequired().HasMaxLength(50);
            target.Property(t => t.PickupOperator).IsRequired().HasMaxLength(20);
            target.Property(t => t.PickupStatusString).IsRequired().HasMaxLength(20);
            target.Property(t => t.SpecialTreatment).IsRequired().HasMaxLength(50);
            target.Property(T => T.Treatement).IsRequired().HasMaxLength(50);

            // HasColumnName
            target.Property(t => t.PickupStatusString).HasColumnName("PickupStatus");

            // HasColumnOrder
            var order = 0;

            target.Property(t => t.Id).HasColumnOrder(order++);

            target.Property(t => t.WebsiteIdHash).HasColumnOrder(order++);
            target.Property(t => t.PickupDate).HasColumnOrder(order++);
            target.Property(t => t.TimeClose).HasColumnOrder(order++);
            target.Property(t => t.TimeReady).HasColumnOrder(order++);
            target.Property(t => t.DateTimeForwarding).HasColumnOrder(order++);
            target.Property(t => t.PickupStatusString).HasColumnOrder(order++);
            target.Property(t => t.AttentionLevel).HasColumnOrder(order++);
            target.Property(t => t.IsLevel1).HasColumnOrder(order++);
            target.Property(t => t.SpecialTreatment).HasColumnOrder(order++);
            target.Property(t => t.IsMixed).HasColumnOrder(order++);
            target.Property(t => t.PickupHieracy).HasColumnOrder(order++);
            target.Property(t => t.PickupOperator).HasColumnOrder(order++);
            target.Property(t => t.SpecialTreatment).HasColumnOrder(order++);
            target.Property(t => t.Treatement).HasColumnOrder(order++);

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

            target.Property(t => t.Note).HasColumnOrder(order++);
            target.Property(t => t.TotalWeight).HasColumnOrder(order++);
            target.Property(t => t.UniqueSequence).HasColumnOrder(order++);
            target.Property(t => t.WebsiteId).HasColumnOrder(order++);

            target.Property(t => t.TimestampUpdate).HasColumnOrder(order++);

        }
    }
}

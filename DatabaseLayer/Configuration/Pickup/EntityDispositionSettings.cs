using System.Diagnostics;
using System.Security.Principal;

namespace DatabaseLayer.Configuration.Pickup
{
    public static class EntityDispositionSettings
    {
        public static void Configure(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            var target = modelBuilder.Entity<Model.Pickup.DispositionSettings>();

            target.ToTable("DispositionSettings", "Pickup");

            target.Ignore(t => t.PickupOperator); // Mapped to ...String
            target.Ignore(t => t.PickupStatus); // Mapped to ...String

            // IsRequired and HasMaxLength
            target.Property(t => t.AccountId).IsRequired().HasMaxLength(50);
            target.Property(t => t.CarrierId).IsRequired().HasMaxLength(50);
            target.Property(t => t.CustomerId).IsRequired().HasMaxLength(50);
            target.Property(t => t.DispositionCode).IsRequired().HasMaxLength(50);
            target.Property(t => t.PickupOperatorString).IsRequired().HasMaxLength(20);
            target.Property(t => t.PickupStatusString).IsRequired().HasMaxLength(20);
            target.Property(t => t.SalesProductId).IsRequired().HasMaxLength(50);
            target.Property(t => t.Text).IsRequired().HasMaxLength(50);

            // HasColumnName
            target.Property(t => t.PickupOperatorString).HasColumnName("PickupOperator");
            target.Property(t => t.PickupStatusString).HasColumnName("PickupStatus");

            // HasColumnOrder
            var order = 0;

            target.Property(t => t.Id).HasColumnOrder(order++);

            target.Property(t => t.CustomerId).HasColumnOrder(order++);
            target.Property(t => t.AccountId).HasColumnOrder(order++);
            target.Property(t => t.CarrierId).HasColumnOrder(order++);
            target.Property(t => t.SalesProductId).HasColumnOrder(order++);

            target.Property(t => t.PickupOperatorString).HasColumnOrder(order++);
            target.Property(t => t.PickupStatusString).HasColumnOrder(order++);
            target.Property(t => t.EnabledForPickup).HasColumnOrder(order++);
            target.Property(t => t.PreallocatePickup).HasColumnOrder(order++);
            target.Property(t => t.Priority).HasColumnOrder(order++);

            target.Property(t => t.DispositionCode).HasColumnOrder(order++);
            target.Property(t => t.LevelOfPrecision).HasColumnOrder(order++);
            target.Property(t => t.ForwarderWebsiteId).HasColumnOrder(order++);
            target.Property(t => t.TimeReady).HasColumnOrder(order++);
            target.Property(t => t.TimeClose).HasColumnOrder(order++);

            target.Property(t => t.Text).HasColumnOrder(order++);

            Debug.Assert(order == 16);
        }
    }
    }

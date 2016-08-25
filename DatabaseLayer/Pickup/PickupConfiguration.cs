using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

using Model.Pickup;
using System.Data.Entity.ModelConfiguration;

namespace DatabaseLayer.Pickup
{
    public class PickupConfiguration
    {
        private readonly DbModelBuilder ModelBuilder;

        private void ConfigureAddress()
        {
            var target = ModelBuilder.ComplexType<Address>();

            // Do NOT specify order on ComplexType 

            // IsRequired and MaxLength
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



        private void ConfigureCustomerPickup()
        {
            var target = ModelBuilder.Entity<CustomerPickup>();

            target.ToTable("CustomerPickup", "Pickup");

            target.Ignore(t => t.PickupStatus);

            // IsRequired and MaxLength
            target.Property(t => t.Note).IsRequired().HasMaxLength(50);
            target.Property(t => t.PickupStatusString).IsRequired().HasMaxLength(20);
            target.Property(t => t.SpecialTreatment).IsRequired().HasMaxLength(50);

            // Column Name
            target.Property(t => t.Address.Name).HasColumnName("Address_CompanyName");
            target.Property(t => t.PickupStatusString).HasColumnName("PickupStatus");

            // Order
            var order = 0;

            target.Property(t => t.Id).HasColumnOrder(order++);

            target.Property(t => t.BranchId).HasColumnOrder(order++);
            target.Property(t => t.CustomerId).HasColumnOrder(order++);
            target.Property(t => t.ForwarderPickpId).HasColumnOrder(order++);
            target.Property(t => t.ForwarderWebsiteId).HasColumnOrder(order++);
            target.Property(t => t.ForwarderWebsiteIdHash).HasColumnOrder(order++);
            target.Property(t => t.GroupIndex).HasColumnOrder(order++);

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
            target.Property(t => t.PickupDate).HasColumnOrder(order++);
            target.Property(t => t.PickupStatusString).HasColumnOrder(order++);
            target.Property(t => t.SpecialTreatment).HasColumnOrder(order++);
            target.Property(t => t.TimeClose).HasColumnOrder(order++);
            target.Property(t => t.TimeReady).HasColumnOrder(order++);
            target.Property(t => t.TimestampUpdate).HasColumnOrder(order++);
            target.Property(t => t.TotalWeight).HasColumnOrder(order++);
            target.Property(t => t.UniqueSequence).HasColumnOrder(order++);
            target.Property(t => t.WebsiteId).HasColumnOrder(order++);
            target.Property(t => t.WebsiteIdHash).HasColumnOrder(order++);
        }

        public void Configure()
        {
            // NOTE Complex Types must be configured prior to containing types.
            ConfigureAddress();

            ConfigureCustomerPickup();
            //ConfigureDispositionSetting();
            //ConfigureForwarderPickup();
            //ConfigureParcelDetail();
            //ConfigureShipment();
        }

        public PickupConfiguration(DbModelBuilder modelBuilder)
        {
            ModelBuilder = modelBuilder;
        }

    }
}

using System;
using System.Collections.Generic;
using Model.Pickup;

namespace Model.Pickup
{
    public class Shipment
    {
        public int Id { get; set; }


        public Address Address { get; set; } //


        public int BranchId { get; set; }


        public int CarrierId { get; set; }


        public string CarrierName { get; set; }


        public int CustomerAccountId { get; set; }


        public int CustomerId { get; set; }


        //public int CustomerPickupId { get; set; }
        /// <summary>
        /// Parent instance.
        /// </summary>
        public CustomerPickup CustomerPickup { get; set; }


        public int DispositionSettingId { get; set; }


        public decimal DryiceWeight { get; set; }


        public int Forwarder1PickupId { get; set; }


        public int Forwarder2PickupId { get; set; }


        public Guid Forwarder2WebsiteId { get; set; }


        public string ForwarderName { get; set; }


        public int GroupIndex { get; set; }


        public bool IsDeleted { get; set; }


        public bool IsLocked { get; set; }


        public List<ParcelDetail> ParcelDetailList { get; set; }


        public int SalesProductId { get; set; }


        public DateTime ShipmentDate { get; set; }


        public int SourceShipmentId { get; set; }


        public int TansportProductId { get; set; }


        public DateTime TimestampCreate { get; set; }


        public DateTime TimestampUpdate { get; set; }


        public int UniqueSequence { get; set; }


        public string WaybillNumber { get; set; }


        public Guid WebsiteId { get; set; }


        public int WebsiteIdHash { get; set; }


        public decimal Weight { get; set; }
    }
}

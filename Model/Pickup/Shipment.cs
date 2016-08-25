using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Pickup
{
public     class Shipment 
    {
    public int Id { get; set; }
    public Address Address { get; set; }
    public int BranchId { get; set; }
    public int CarrierId { get; }
    public string CarrierName { get; }
    public int CustomerAccountId { get; }
    public int CustomerId { get; set; }
    public int CustomerPickupId { get; set; }
    //public DispositionCode DispositionCode { get; set; }
    public int DispositionSettingId { get; set; }
    public decimal DryiceWeight { get; }
    public int Forwarder1PickupId { get; set; }
    public int Forwarder2PickupId { get; set; }
    public Guid Forwarder2WebsiteId { get; set; }
    public string ForwarderName { get; set; }
    public int GroupIndex { get; set; }
    public bool IsDeleted { get; }
    public bool IsLocked { get; }
    public int SalesProductId { get; }
    public DateTime ShipmentDate { get; }
    public int SourceShipmentId { get; }
    public string StatusForwarderPickup { get; }
    public int TansportProductId { get; }
    public DateTime TimestampCreate { get; }
    public DateTime TimestampUpdate { get; }
    public int UniqueSequence { get; set; }
    public string WaybillNumber { get; }
    public Guid WebsiteId { get; }
    public int WebsiteIdHash { get; }
    public decimal Weight { get; }
    }
}

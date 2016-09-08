using System;

namespace Model.Pickup
{
    public class ParcelDetail 
    {
        public int Id { get; set; }


        public decimal DryiceWeight { get; set; }


        public decimal Height { get; set; }


        public decimal Length { get; set; }


        public int ShipmentId { get; set; }


        public string WaybillNumber { get; set; }


        public Guid WebsiteId { get; set; }


        public int WebsiteIdHash { get; set; }


        public decimal Weight { get; set; }


        public decimal Width { get; set; }
    }
}

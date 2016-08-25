using System;

namespace nu.gtx.CodeFirst.Model.PickupDomain
{
    public class DispositionSetting 
    {
        public int Id { get; set; }
        public string Account { get; set; }
        public string CarrierId { get; set; }
        public string CustomerId { get; set; }
        public int LevelOfPrecision { get; set; }
        public int Priority { get; set; }
        public string SalesProductId { get; set; }
        //public DispositionCode DispositionCode { get; set; }
        public bool EnabledForPickup { get; set; }
        public Guid ForwarderWebsiteId { get; set; }
        public int GroupIndex { get; set; }
        public string PreferredPickupOperator { get; set; }
        public string Text { get; set; }
    }
}

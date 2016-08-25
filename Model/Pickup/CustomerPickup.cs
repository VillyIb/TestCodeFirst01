using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Pickup
{
    public class CustomerPickup
    {
        public int Id { get; set; }


        //[Column(Order = 10)]
        public Address Address { get; set; }


        public int BranchId { get; set; }


        public int CustomerId { get; set; }


        public int ForwarderPickpId { get; set; }


        public Guid ForwarderWebsiteId { get; set; }


        public int ForwarderWebsiteIdHash { get; set; }


        public int GroupIndex { get; set; }


        public string Note { get; set; }


        public DateTime PickupDate { get; set; }


        // not saved in db
        public PickupStatus PickupStatus { get; set; }


        // must be mapped to PickupStatus in db
        public string PickupStatusString
        {
            get { return PickupStatus.ToString("G"); }
            set
            {
                PickupStatus t1;
                PickupStatus = Enum.TryParse(value, out t1) ? t1 : PickupStatus.Undefined;
            }
        }


        public string SpecialTreatment { get; set; }


        public TimeSpan? TimeClose { get; set; }


        public TimeSpan? TimeReady { get; set; }


        public DateTime TimestampUpdate { get; set; }


        public decimal TotalWeight { get; set; }


        public int UniqueSequence { get; set; }


        public Guid WebsiteId { get; set; }


        public int WebsiteIdHash { get; set; }

    }
}

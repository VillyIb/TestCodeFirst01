using System;

namespace Model.Pickup
{
    public class ForwarderPickup 
    {
        public int Id { get; set; }



        
        public Address Address { get; set; }


        public string AttentionLevel { get; set; }


        public DateTime DateTimeForwarding { get; set; }


        public bool IsLevel1 { get; set; }


        public bool IsMixed { get; set; }


        public string Note { get; set; }


        public DateTime PickupDate { get; set; }


        public int PickupHieracy { get; set; }


        public string PickupOperator { get; set; }


        //public PickupType PickupType { get; set; }


        public string SpecialTreatment { get; set; }


        public string Status { get; set; }


        public TimeSpan? TimeClose { get; set; }


        public TimeSpan? TimeReady { get; set; }


        public DateTime TimestampUpdate { get; set; }


        public decimal TotalWeight { get; set; }


        public string Treatement { get; set; }


        public int UniqueSequence { get; set; }


        public Guid WebsiteId { get; set; }


    }
}

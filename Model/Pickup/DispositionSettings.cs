using System;
using System.Linq;

namespace Model.Pickup
{
    public class DispositionSettings
    {
        public string AccountId { get; set; }
        public string CarrierId { get; set; }
        public string CustomerId { get; set; }
        public string DispositionCode { get; set; }
        public bool EnabledForPickup { get; set; }
        public System.Guid ForwarderWebsiteId { get; set; }
        public int Id { get; set; }
        #region public int LevelOfPrecision { get; set; }
        public int LevelOfPrecision
        {
            get
            {
                var precision = (new[] { AccountId, CarrierId, CustomerId, SalesProductId }).Count(t => "*".Equals(t));
                return precision;
            }
            // ReSharper disable once ValueParameterNotUsed
            set { }
        }
        #endregion
        public PickupOperator PickupOperator { get; set; }
        #region string PickupOperatorString { get; set; }

        public string PickupOperatorString
        {
            get { return PickupOperator.ToString("G"); }
            set { PickupOperator t1; PickupOperator = Enum.TryParse(value, out t1) ? t1 : PickupOperator.Undefined; }
        }
        #endregion
        public PickupStatusCustomer PickupStatus { get; set; }
        #region public string PickupStatusString { get; set; }
        public string PickupStatusString
        {
            get { return PickupStatus.ToString("G"); }
            set { PickupStatusCustomer t1; PickupStatus = Enum.TryParse(value, out t1) ? t1 : PickupStatusCustomer.Undefined; }
        }
        #endregion
        public bool PreallocatePickup { get; set; }
        public int Priority { get; set; }
        public string SalesProductId { get; set; }
        public string Text { get; set; }
        public System.TimeSpan TimeClose { get; set; }
        public System.TimeSpan TimeReady { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using Model.Pickup;

namespace Model.Pickup
{
    public class CustomerPickup
    {
        public Address Address { get; set; }
        public int BranchId { get; set; }
        public int CustomerId { get; set; }
        public int ForwarderPickpId { get; set; }
        public System.Guid ForwarderWebsiteId { get; set; }
        public int ForwarderWebsiteIdHash { get; set; }
        public int Id { get; set; }
        public string Note { get; set; }
        public System.DateTime PickupDate { get; set; }
        public PickupOperator PickupOperator { get; set; }
        #region public string PickupOperatorString { get; set; }
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
        public List<Shipment> ShipmentList { get; set; }
        public string SpecialTreatment { get; set; }
        public System.TimeSpan TimeClose { get; set; }
        public System.TimeSpan TimeReady { get; set; }
        public System.DateTime TimestampUpdate { get; set; }
        public decimal TotalWeight { get; set; }
        public System.Guid WebsiteId { get; set; }
        public int WebsiteIdHash { get; set; }
    }
}

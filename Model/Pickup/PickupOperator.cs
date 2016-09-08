
// ReSharper disable InconsistentNaming
namespace Model.Pickup
{
    public enum PickupOperator
    {
        Undefined,


        GLS,


        DHL,


        HS,


        UPS,


        FedEx,


        /// <summary>
        /// Unspecified
        /// </summary>
        AA,


        /// <summary>
        /// The Forwarder must decide the PickupOperator
        /// </summary>
        Manual,


        /// <summary>
        /// The system decides the PickupOperator when requesting pickup.
        /// Rule #1
        /// </summary>
        Auto1,


        /// <summary>
        /// The system decides the PickupOperator when requesting pickup.
        /// Rule #2
        /// </summary>
        Auto2,


        /// <summary>
        /// No pickup.
        /// </summary>
        None,

    }
}
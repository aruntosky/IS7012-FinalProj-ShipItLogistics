using System.ComponentModel;

namespace HimalayanLogistics.Models
{
    public class Shipment
    {
        public int ShipmentId { get; set; }
        [DisplayName("Shipment Start Date")]

        public DateTime ShipmentStartDate { get; set; }
        [DisplayName("Shipment Type")]

        public string ShipmentType { get; set; }
        [DisplayName("Shipment Number")]

        public int ShipmentNumber { get; set; }
        [DisplayName("Pickup Location")]

        public string PickupLocation { get; set; }
        [DisplayName("Destination")]

        public string Destination { get; set; }
        public Customer? Customer { get; set; }
        [DisplayName("Customer Name")]

        public int CustomerId { get; set; }

        public Payment? Payment { get; set; }
        [DisplayName("Transaction Number")]

        public int? PaymentId { get; set; }

        public DeliveryTracking? DeliveryTracking { get; set; }
        [DisplayName("Tracking Number")]

        public int? DeliveryTrackingId { get; set; }
        public Employee? Employee { get; set; }
        [DisplayName("Employee Name")]

        public int EmployeeId { get; set; }
    }
}

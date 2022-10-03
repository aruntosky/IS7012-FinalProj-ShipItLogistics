using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace HimalayanLogistics.Models
{
    public class DeliveryTracking
    {
        public int DeliveryTrackingId { get; set; }
        [DisplayName("Expected Delivery Date")]

        public DateTime ExpectedDeliveryDate { get; set; }
        [DisplayName("Tracking Number")]

        public long TrackingNumber { get; set; }
        [DisplayName("Delivery Status")]

        public string DeliveryStatus { get; set; }
        [ForeignKey("ShipmentId")]
        public Shipment? Shipment { get; set; }
        [DisplayName("Shipment Number")]

        public int? ShipmentId { get; set; }
    }
}

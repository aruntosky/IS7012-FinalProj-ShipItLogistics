using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace HimalayanLogistics.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        [DisplayName("Transaction Number")]

        public long TransactionNumber { get; set; }
        [DisplayName("Charges")]


        public decimal Amount { get; set; }
        [DisplayName("Payment Date")]

        public DateTime PaymentDate { get; set; }
        [DisplayName("Payment Mode")]

        public string PaymentMode { get; set; }
        public Customer? Customer { get; set; }
        [DisplayName("Customer Name")]

        public int CustomerId { get; set; }
        [ForeignKey("ShipmentId")]
        public Shipment? Shipment { get; set; }
        [DisplayName("Transaction Number")]

        public int? ShipmentId { get; set; }
    }
}

using System.ComponentModel;

namespace HimalayanLogistics.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [DisplayName("Customer Name")]
        public string CustomerName { get; set; }
        [DisplayName("Contact Number")]

        public long PhoneNumber { get; set; }
        [DisplayName("Email ID")]

        public string Email { get; set; }
        public List<Shipment>? Shipments { get; set; }
        public List<Payment>? Payments { get; set; }
    }
}

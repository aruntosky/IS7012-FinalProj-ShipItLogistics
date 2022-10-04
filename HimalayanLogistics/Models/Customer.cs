using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace HimalayanLogistics.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [DisplayName("Customer Name")]
        [Required(ErrorMessage = "Customer Name required")]
        public string CustomerName { get; set; }
        [DisplayName("Contact Number")]
        [Required(ErrorMessage = "Phone Number required")]
        [Phone]
        public long PhoneNumber { get; set; }
        [DisplayName("Email ID")]
        [Required(ErrorMessage = "Email required")]
        [EmailAddress]
        public string Email { get; set; }
        public List<Shipment>? Shipments { get; set; }
        public List<Payment>? Payments { get; set; }
    }
}

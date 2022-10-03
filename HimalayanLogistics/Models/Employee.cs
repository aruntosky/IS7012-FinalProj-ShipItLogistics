using System.ComponentModel;

namespace HimalayanLogistics.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [DisplayName("Employee Name")]

        public string EmployeeName { get; set; }
        [DisplayName("Email ID")]

        public string Email { get; set; }
        [DisplayName("Contact Number")]

        public long Contact { get; set; }
        public List<Shipment>? Shipments { get; set; }
    }
}

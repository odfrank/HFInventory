using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HFInventApp.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        
        [Required(ErrorMessage = "*Customer Name is required")]
        public string CustomerName { get; set; }
        public string ContactTitle { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "*Facility is required for each customer")]
        public int FacilityId { get; set; }
        [ForeignKey("FacilityId")]
        public Facility? Facility { get; set; }
        

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace HFInventApp.Models
{
    public class Cylinder
    {
        public int CylinderId { get; set; }

        [Required]
        public Guid BatchNumber { get; set; } 

        [Required(ErrorMessage = "*Cylinder Name is required")]
        [DisplayName("Cylinder Name")]
        public string CylinderName { get; set; }
        public int? CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; }
    }
}

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HFInventApp.Models
{
    public class Facility
    {
        public int FacilityId { get; set; }
        [Required(ErrorMessage = "*Facility Name is required")]
        [DisplayName("Facility Name")]
        public string FacilityName { get; set; }
        [Required(ErrorMessage = "*Facility Location is required")]
        [DisplayName("Facility Location")]
        public string Location { get; set; }
    }
}

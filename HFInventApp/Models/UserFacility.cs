using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HFInventApp.Models
{
    public class UserFacility
    {
        [Key]
        [Column(Order = 0)]
        public string UserId { get; set; }
        [Key]
        [Column(Order = 1)]
        public int FacilityId { get; set; }
        
    }
}

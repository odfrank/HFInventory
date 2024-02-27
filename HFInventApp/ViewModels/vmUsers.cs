using HFInventApp.Models;
using System.ComponentModel;

namespace HFInventApp.ViewModels
{
    public class vmUsers
    {
        public ApplicationUser? UserInfo { get; set; }

        public int? FacilityId { get; set; }

        [DisplayName("Facility Name")]
        public string? FacilityName { get; set; }
        public string? RoleId { get; set; }
        public string? Role { get; set; }
    }
}

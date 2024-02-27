using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HFInventApp.Models
{
    public class ApplicationUser:IdentityUser{
        [Required]
        public string FullName { get; set; }

        public string? JobTitle { get; set; }

    }
}

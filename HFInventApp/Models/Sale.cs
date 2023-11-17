using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace HFInventApp.Models
{
    public class Sale
    {
        public int SaleId { get; set; }
        [Required]
        public int FacilityId { get; set; }        
        public string UserId { get; set; }        
        public int CustomerId { get; set; }        
        public DateTime SaleDate { get; set; }
        public decimal TotalPrice { get; set; }

    }
}

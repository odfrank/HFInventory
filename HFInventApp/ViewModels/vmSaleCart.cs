using HFInventApp.Models;
using System.ComponentModel.DataAnnotations;

namespace HFInventApp.ViewModels
{
    public class vmSaleCart
    {
        public List<vmSaleProduct> SaleProducts { get; set; }
        [Required(ErrorMessage = "*Facility Name is required")]
        public int? FacilityId { get; set; }
        [Required(ErrorMessage = "*Customer Name is required")]
        public int? CustomerId { get; set; }
        public ApplicationUser? SaleUser { get; set; }
        public DateTime SaleDate { get; set; }
        public double? TotalSalePrice { get; set; }
    }
}

using HFInventApp.Models;

namespace HFInventApp.ViewModels
{
    public class vmSaleDetails
    {
        public List<Sale>? Sales { get; set; }
        public List<Product>? Products { get; set; }
        public List<Customer>? Customers { get; set; }
        public List<Facility>? Facilities { get; set; }
        public List<ApplicationUser>? Users { get; set; }
    }
}

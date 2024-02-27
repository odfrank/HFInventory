using HFInventApp.Models;

namespace HFInventApp.ViewModels
{
    public class vmProductInventories
    {
        public List<ProductInventory>? ProductInventories { get; set; }
        public List<Facility>? Facilities { get; set; }
        public List<Product>? Products { get; set; }
        public List<BinLookup>? BinLookups { get; set; }
    }
}

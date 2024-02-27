using HFInventApp.Models;

namespace HFInventApp.ViewModels
{
    public class vmTotalSaleDetails
    {
        public List<vmProductSale>? TotalSales { get; set; }
        public Sale CurrentSale { get; set; }
        public decimal TotalPrice { get; set; }
    }
}

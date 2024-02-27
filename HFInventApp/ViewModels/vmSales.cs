using HFInventApp.Models;

namespace HFInventApp.ViewModels
{
    public class vmSales
    {
        public int SaleId { get; set; }
        public Facility SaleFacility { get; set; }
        public Customer SaleCustomer { get; set; }
        public string SaleUser { get; set; }
        public DateTime SaleDate { get; set; }
        public double TotalSalePrice { get; set; }
    }
}

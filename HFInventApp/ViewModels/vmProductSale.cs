using System.ComponentModel;

namespace HFInventApp.ViewModels
{
    public class vmProductSale
    {
        public int? ProductSaleId { get; set; }
        public int ProductId { get; set; }
        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [DisplayName("Product Description")]
        public string ProductDescription { get; set; }
        public int? QuantitySold { get; set; }
        public decimal? ProductPrice { get; set; }
        public decimal? SalePrice {get; set; }
    }
}

namespace HFApp.Models
{
    public class SaleDetails
    {
        public int SaleDetailsId { get; set; }
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public int QuantitySold { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal SalePrice => ProductPrice * QuantitySold;

    }
}

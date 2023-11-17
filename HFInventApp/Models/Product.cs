using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HFApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "*Product Name is required")]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [DisplayName("Product Description")]
        public string ProductDescription { get; set; }

        public decimal Price { get; set; }
    }
}

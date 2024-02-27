using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations.Schema;

namespace HFInventApp.Models
{
    public class SaleDetail
    {
        public int SaleDetailId { get; set; }
        public int SaleId { get; set; }        
        public int ProductId { get; set; }        
        public int? QuantitySold { get; set; }
        public decimal? ProductPrice { get; set; }
        public decimal? SalePrice => ProductPrice * QuantitySold;

    }
}

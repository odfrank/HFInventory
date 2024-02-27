using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HFInventApp.Models
{
    public class ProductInventory
    {
        //List of products for each facility and number/quantity of units available
        [Key]
        public int InventoryId { get; set; }
        public int FacilityId { get; set; }
        public int ProductId { get; set; }
        public int BinLookupId { get; set; }
        public int Quantity { get; set; }
        [DisplayName("Inventory SKU")]
        public string? InventorySKU { get; set; }
        public Guid InventoryBatch { get; set; } = Guid.NewGuid();
    }
}

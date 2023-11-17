using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HFApp.Models
{
    public class BinLookup
    {
        public int BinLookupId { get; set; }
        [Required(ErrorMessage = "*BIN Number is required and must be unique")]
        [DisplayName("BIN Number")]
        public string BinNumber { get; set; }

        [Required(ErrorMessage = "*Bin Description is required")]
        public string Description { get; set; }
        public string Location { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }
    }
}

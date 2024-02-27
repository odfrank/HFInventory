using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HFInventApp.Models
{
    public class CylinderRentHistory
    {
        public int CylinderRentHistoryId { get; set; }
        public string BatchNumber { get; set; }        
        public int CustomerId { get; set; }        
        public string Transaction { get; set; } //Borrow / Return
        public DateTime RentDate { get; set; } = DateTime.Now;
    }
}

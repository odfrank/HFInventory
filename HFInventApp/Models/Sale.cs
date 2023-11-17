﻿namespace HFApp.Models
{
    public class Sale
    {
        public int SaleId { get; set; }
        public int FacilityId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalPrice { get; set; }

    }
}

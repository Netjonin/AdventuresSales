using System;

namespace AdventureWorksSales.Web.Models.ViewModels
{
    public class HomeViewModel
    {
        public int TotalOrders { get; set; }
        public decimal HighestLineTotal { get; set; }
        public int FrontBrakesSalesTotal { get; set; }
    }
}
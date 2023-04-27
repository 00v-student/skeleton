using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        public bool Active { get; set; }
        public int OrderNumber { get; set; }
        public string OrderDescription { get; set; }
        public int OrderTotal { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerID { get; set; }
        public string StaffName { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
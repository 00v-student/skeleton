using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        public bool Active { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderID { get; set; }
        public string OrderDescription { get; set; }
        public int OrderTotal { get; set; }
        public int CustomerID { get; set; }
        public int StaffName { get; set; }
    }
}
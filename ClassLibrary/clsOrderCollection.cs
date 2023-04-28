using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        public List<clsOrders> OrderList { get; set; }
        public int Count { get; set; }
        public clsOrders ThisOrders { get; set; }
        public List<clsOrders> OrdersList { get; set; }
    }
}
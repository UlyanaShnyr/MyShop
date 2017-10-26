using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication19
{
    public class TicketModel
    {
        public string Cashier { get; set; }
        public List<SoldProduct> Products { get; set; }
        public int price { get; set; }
    }

    public class SoldProduct
    {
        public string Product { get; set; }
        public int price { get; set; }
        public int count { get; set; }
    }
}

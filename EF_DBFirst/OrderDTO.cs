using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DBFirst
{
    public class OrderDTO
    {
        public int OrderID { get; set; }
        public string OrderDate { get; set; }

        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string EmployeeName { get; set; }
        public string ShipCountry { get; set; }

        public string ShipCity { get; set; }

        public string ShipAdress { get; set; }

        public string ShipName { get; set; }

        public List<Order_Details> OrderDetails { get; set; }
        public List<Products>Products { get; set; }
    }
}

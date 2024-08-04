using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DBFirst
{
    public class ProductDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? Stock { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}

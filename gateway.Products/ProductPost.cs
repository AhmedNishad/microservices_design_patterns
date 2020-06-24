using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.Products
{
    public class ProductPost
    {
        public int ProductId { get; set; }
        public int QuantityAtHand { get; set; }
        public string Name { get; set; }
        public int Sales { get; set; }
        public decimal UnitPrice { get; set; }
        public string Provider { get; set; }
    }
}

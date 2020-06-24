using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.Customers
{
    public class OrderPost
    {
        public List<Product> Products { get; set; }
        public int CustomerId { get; set; }
    }

    public class Product
    {
        public int ProductId { get; set; }
        public int QuantityAtHand { get; set; }
        public string Name { get; set; }
        public int Sales { get; set; }
        public decimal UnitPrice { get; set; }
        public string Provider { get; set; }
    }
}

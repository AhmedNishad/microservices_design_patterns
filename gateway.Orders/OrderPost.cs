using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.Orders
{
    public class OrderPost
    {
        public List<ProductPost> Products { get; set; }
        public CustomerPost Customer { get; set; }
    }

    public class CustomerPost
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public decimal LifeTimeValue { get; set; }
        public int OrderCount { get; set; }
    }

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

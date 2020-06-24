using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.Orders
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<OrderItem> Items { get; set; }
        public DateTime PlacedOn { get; set; }
        public Customer Customer { get; set; }
        public decimal Total { get { return Items.Sum(oi => oi.UnitPriceInRupees * oi.Quantity); } }
    }

    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail{ get; set; }
    }

    public class OrderItem
    {
        public decimal UnitPriceInRupees { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public int ItemId { get; set; }

    }
}

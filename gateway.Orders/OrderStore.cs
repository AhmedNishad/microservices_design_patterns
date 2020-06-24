using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.Orders
{
    public class OrderStore
    {
        public List<Order> orders = new List<Order>
        {
            new Order{OrderId = 0, Customer=customers[0],
                Items=new List<OrderItem>{
                    new OrderItem { ItemId=3, ProductName = "Hair Brush", Quantity = 5, UnitPriceInRupees = 51.2m } ,
                    new OrderItem { ItemId=4, ProductName = "Tooth Brush", Quantity = 3, UnitPriceInRupees = 83.2m } }
            },
            new Order{OrderId = 1, Customer=customers[1],
                Items=new List<OrderItem>{
                    new OrderItem { ItemId=5, ProductName = "Hand Sanitizer", Quantity = 31, UnitPriceInRupees = 151.2m } ,
                    new OrderItem { ItemId=6, ProductName = "Face Mast", Quantity = 5, UnitPriceInRupees = 251.2m } }
            },
        }
        ;

        public static List<Customer> customers = new List<Customer>
        {
            new Customer{CustomerId = 0, CustomerEmail = "jerry@snail.mail", CustomerName="Jerry"},
            new Customer{CustomerId = 2, CustomerEmail = "tom@snail.mail", CustomerName="Tom"}
        };
    }
}

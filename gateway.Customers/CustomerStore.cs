using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.Customers
{
    public class CustomerStore
    {
        public List<Customer> customers = new List<Customer>
        {
            new Customer{CustomerId = 0, Address = "14 A, Go Home", Email="hulk@avengers.co", Name="Bruce", LifeTimeValue=512.5m, OrderCount=5},
            new Customer{CustomerId = 1, Address = "15 A, Go Home", Email="cappa@avengers.co", Name="America", LifeTimeValue=2112.2m, OrderCount=21}
        };
    }
}

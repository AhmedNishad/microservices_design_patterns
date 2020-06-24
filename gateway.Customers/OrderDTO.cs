using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.Customers
{
    public class OrderDTO
    {
        public Customer Customer { get; set; }
        public List<Product> Products{ get; set; }
    }
}

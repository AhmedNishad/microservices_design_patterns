using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.Products
{
    public class OrderDTO
    {
        public List<Product> products;
        public int CustomerId;
    }
}

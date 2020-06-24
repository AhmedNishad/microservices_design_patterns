using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.Products
{
    public class ProductStore
    {
        public List<Product> products = new List<Product>
        {
            new Product{ProductId = 0, Name="Mats", Provider="Alibaba", QuantityAtHand=61, UnitPrice=31.4m, Sales=23},
            new Product{ProductId = 1, Name="Gloves", Provider="Alibaba", QuantityAtHand=21, UnitPrice=71.4m, Sales=41},
            new Product{ProductId = 2, Name="Hand Bag", Provider="AliExpress", QuantityAtHand=861, UnitPrice=85.4m, Sales=51},
            new Product { ProductId=3, Name = "Hair Brush", QuantityAtHand = 58, UnitPrice = 51.2m },
            new Product { ProductId=4, Name = "Tooth Brush", QuantityAtHand = 39, UnitPrice = 83.2m }
        };
    }
}

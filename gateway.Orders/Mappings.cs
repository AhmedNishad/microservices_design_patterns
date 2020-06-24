using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.Orders
{
    public class Mappings
    {
        public static Dictionary<string, int> addresses = new Dictionary<string, int>()
        {
            { "orders", 44387 },
            { "customers", 44365},
            { "products", 44306 }
        };
    }
}

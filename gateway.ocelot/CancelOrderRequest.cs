using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.ocelot
{
    public class CancelOrderRequest
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public decimal OrderTotal { get; set; }
    }
}

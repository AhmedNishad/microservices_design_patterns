﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.ocelot
{
    public class OrderPost
    {
        public List<int> ProductIds { get; set; }
        public int CustomerId { get; set; }
    }
}

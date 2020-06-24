using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.Products
{
    public class TestDTO
    {
        public List<int> ProductIds { get; set; }
        public int CustomerId { get; set; }
        public int LiterallyAnything { get; set; }
    }
}

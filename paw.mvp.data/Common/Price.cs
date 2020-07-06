using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Common
{
    // Value Object
    public class Price
    {
        public decimal Value { get; set; }
        public Currency Currency { get; set; }
    }
}

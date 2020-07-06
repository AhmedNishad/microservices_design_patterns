using paw.mvp.data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Common
{
    // Value Object
    public class Price: ValueObject
    {
        public decimal Value { get; set; }
        public Currency Currency { get; set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
            yield return Currency;
        }
    }
}

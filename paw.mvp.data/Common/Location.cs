using paw.mvp.data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Common
{
    // Value Object
    public class Location: ValueObject
    {
        public double Latitude { get; set; }
        public double Longtitude { get; set; }
        public string Name { get; set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Latitude;
            yield return Longtitude;
            yield return Name;
        }
    }
}

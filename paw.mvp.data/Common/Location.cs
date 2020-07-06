using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Common
{
    // Value Object
    public class Location
    {
        public double Latitude { get; set; }
        public double Longtitude { get; set; }
        public string Name { get; set; }
    }
}

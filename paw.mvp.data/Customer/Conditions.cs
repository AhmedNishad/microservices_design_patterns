using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Customer
{
    public class Conditions
    {
        public string Name { get; set; }
        public string DocumentFile { get; set; }
        public string Notes { get; set; }
        public bool IsUnderWetCare { get; set; }
    }
}

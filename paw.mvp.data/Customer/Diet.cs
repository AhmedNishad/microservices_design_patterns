using paw.mvp.data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Customer
{
    public class Diet
    {
        public TimeDuration TimeSlot{ get; set; }
        
        // Composite Object?
        public string Food { get; set; }
        public int Quantity { get; set; }
        public bool FeedAlong { get; set; }
        public string Other { get; set; }

    }
}

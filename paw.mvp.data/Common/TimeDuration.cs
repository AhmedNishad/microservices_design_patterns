using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Common
{
    // Value Object
    public class TimeDuration
    {
        public DateTime StartDateTime { get; set; }
        public TimeSpan Duration { get { return TimeSpan.FromHours(1);  } }
        
    }
}

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
        public TimeSpan Duration { get { return _duration != null ? _duration :  TimeSpan.FromHours(1);  } }
        private TimeSpan _duration { get; private set; }
        public TimeDuration(DateTime startDate)
        {
            StartDateTime = startDate;   
        }

        public TimeDuration SetDuration(TimeSpan duration)
        {
            _duration = duration;
            return this;
        }
    }
}

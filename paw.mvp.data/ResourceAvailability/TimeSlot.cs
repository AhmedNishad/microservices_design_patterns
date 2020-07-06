using paw.mvp.data.Appointment;
using System;

namespace paw.mvp.data.ResourceAvailability
{
    public class TimeSlot
    {
        public DateTime StartTime{ get; private set; }
        public AppointmentEntity Appointment { get; set; }
        private TimeSlotStatus GetStatus()
        {
            if(DateTime.Compare(DateTime.Now ,StartTime) < 0)
            {
                return TimeSlotStatus.Completed;
            }

            return _status;
        }

        public TimeSlotStatus Status { get { return GetStatus(); } set { _status = value; } }

        private TimeSlotStatus _status;
        public TimeSlot(DateTime startTime)
        {
            StartTime = startTime;
            _status = TimeSlotStatus.Awaiting;
        }

        public TimeSlot Begin()
        {
            Status = TimeSlotStatus.InProgress;
            return this;
        }
        public TimeSlot End()
        {
            Status = TimeSlotStatus.Completed;
            return this;
        }

    }
}
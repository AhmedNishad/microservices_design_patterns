using paw.mvp.data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Appointment
{
    // Appointment for a certain day with resources assigned for a that day
    public class AppointmentInstance: Entity
    {
        public DateTime Date { get; set; }
        public AppointmentStatus AppointmentStatus { get; set; }

        public AppointmentInstance Confirm()
        {
            AppointmentStatus = AppointmentStatus.Confirmed;
            return this;
        }
        public AppointmentInstance SetInProgress()
        {
            AppointmentStatus = AppointmentStatus.InProgress;
            return this;
        }

        public AppointmentInstance Complete()
        {
            AppointmentStatus = AppointmentStatus.Completed;
            return this;
        }

        public AppointmentInstance Cancel()
        {
            AppointmentStatus = AppointmentStatus.Cancelled;
            return this;
        }

    }
}

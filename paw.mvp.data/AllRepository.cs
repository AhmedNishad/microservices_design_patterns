using paw.mvp.data.Appointment;
using paw.mvp.data.Common;
using paw.mvp.data.Customer;
using paw.mvp.data.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data
{
    public class AllRepository
    {
        private PawContext Database;
        public AllRepository(PawContext context)
        {
            Database = context;
        }

        public List<AppointmentEntity> GetAppointmentsOnlyFuture()
        {
            return Database.Appointments.Where(a => a.Durations.All(d => d.StartDateTime > DateTime.Now)).ToList();
        }

        public void CreateAppointment(CustomerEntity customer, List<Resource> resources, List<TimeDuration> durations,
            ServiceEntity service, List<Pet> pets)
        {
            // Check whether all the calendars of the resources don't have an appointment (Would be replaced by a call to the 
            // Availability Micro service

            foreach(var resource in resources)
            {
                foreach(var duration in durations)
                {
                    var schedule = resource.Calendar.Schedules.FirstOrDefault(s => s.Date == duration.StartDateTime);
                    if(schedule == null)
                    {
                        throw new Exception("This schedule doesn't exist!");
                    }
                    // Approximate the DateTime to Hour
                    var totalDurationHours = duration.Duration.TotalHours + duration.StartDateTime.Hour;
                    // Check that none of the time slots in the schedule have an assigned appointment
                    if (!schedule.TimeSlots.Where(ts => ts.StartTime.Hour > duration.StartDateTime.Hour && ts.StartTime.Hour < totalDurationHours)
                        .All(t => t.Appointment == null))
                    {
                        throw new Exception("Some time slots have been taken!");
                    }
                }
            }

            var appointment = new AppointmentEntity(durations, customer, pets).AddResources(resources).AddService(service);

            Database.Appointments.Add(appointment);
            Database.SaveChanges();
        }
    }
}

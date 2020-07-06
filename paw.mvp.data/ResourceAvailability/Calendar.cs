using paw.mvp.data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.ResourceAvailability
{
    // Generates Schedules Based on Holidays Daily Work Hours
    // These are available for every resource
    // Appointments fill these time slots
    public class Calendar: AuditableEntity
    {
        public WeeklyTemplate WeeklyTemplate { get; set; }
        public List<Schedule> Schedules { get; set; }

        public Calendar(WeeklyTemplate weeklyTemplate)
        {
            WeeklyTemplate = weeklyTemplate;
            Schedules = new List<Schedule>();
        }

        public void UpdateSchedule(DateTime date, int startHour, int slotDurationInHours, int numberOfSlots)
        {
            var schedule = Schedules.FirstOrDefault(s => s.Date == date);
            if (schedule == null)
                throw new Exception("Schedule doesn't exist for given date");

            schedule.UpdateSchedule(startHour, slotDurationInHours, numberOfSlots);
        }

        public void UpdateSchedule(DateTime date, List<TimeSlot> slots)
        {
            var schedule = Schedules.FirstOrDefault(s => s.Date == date);
            if (schedule == null)
                throw new Exception("Schedule doesn't exist for given date");

            schedule = new Schedule(slots);
        }
    }
}

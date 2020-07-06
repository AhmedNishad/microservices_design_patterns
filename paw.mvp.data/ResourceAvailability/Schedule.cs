using paw.mvp.data.Appointment;
using paw.mvp.data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.ResourceAvailability
{
    // For any given date on the calendar produces 
    public class Schedule
    {
        public int TenantId { get; set; }
        public int BranchId { get; set; }
        public DateTime Date { get; set; }
        public int StartingHour { get; set; }
        public int NumberOfSlots { get; set; }
        public List<TimeSlot> TimeSlots { get; private set; }
        public int SlotDurationInHours { get; set; }

        public Schedule(int tenantId, int branchId, DateTime date, int slotDurationInHours, int numberOfSlots)
        {
            if(slotDurationInHours > 6)
            {
                throw new InvalidEnumArgumentException("Slot Duration Length is Too High");
            }
            TenantId = tenantId;
            BranchId = branchId;
            Date = date;
            SlotDurationInHours = slotDurationInHours;
            StartingHour = date.Hour;
            if(numberOfSlots * slotDurationInHours > 24)
            {
                throw new InvalidEnumArgumentException("Cannot have more that 24 hours in a day");
            }
            GenerateTimeSlots();
        }

        public Schedule UpdateSchedule(int startingHour, int slotDurationInHours, int numberOfSlots)
        {
            SlotDurationInHours = slotDurationInHours;
            StartingHour = startingHour;
            NumberOfSlots = numberOfSlots;
            GenerateTimeSlots();
            return this;
        }

        public Schedule(List<TimeSlot> slots)
        {
            TimeSlots = slots;
        }

        private void GenerateTimeSlots()
        {
            // Generate a time slot for each time interval based on duration length
            this.TimeSlots = new List<TimeSlot>();
            int totalHours = StartingHour;
            for(int i = 0; i < NumberOfSlots; i++)
            {
                var slot = new TimeSlot(Date.AddHours(totalHours));
                totalHours += int.Parse(SlotDurationInHours.ToString());
                TimeSlots.Add(slot);
            }
        }

        public void HandleAppointment(AppointmentEntity appointment)
        {
            foreach(var duration in appointment.Durations.Where(a => a.StartDateTime.Date == Date.Date).ToList())
            {
                //if(duration.Duration.TotalHours > 
                //var slot = TimeSlots.FirstOrDefault(duration.StartDateTime;
            }
        }

        public void BookTimeSlot(int slotIndex, AppointmentEntity appointment)
        {
            TimeSlots[slotIndex].Appointment = appointment;
        }
    }
}

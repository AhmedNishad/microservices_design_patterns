using System;
using System.ComponentModel;

namespace paw.mvp.data.ResourceAvailability
{
    public class WeeklyTemplate
    {
        public DailyTemplate MondayTemplate { get; set; }
        public DailyTemplate TuesdayTemplate { get; set; }
        public DailyTemplate WednesdayTemplate { get; set; }
        public DailyTemplate ThursdayTemplate { get; set; }
        public DailyTemplate FridayTemplate { get; set; }
        public DailyTemplate SaturdayTemplate { get; set; }
        public DailyTemplate SundayTemplate { get; set; }

        public WeeklyTemplate(DailyTemplate monday, DailyTemplate tuesday, DailyTemplate wednesday, DailyTemplate thursday,
            DailyTemplate friday, DailyTemplate saturday, DailyTemplate sunday)
        {

            MondayTemplate = monday;
            TuesdayTemplate = tuesday;
            WednesdayTemplate = wednesday;
            ThursdayTemplate = thursday;
            FridayTemplate = friday;
            SaturdayTemplate = saturday;
            SundayTemplate = sunday;
        }

        // Update
        public WeeklyTemplate SetMonday(DailyTemplate monday)
        {
            MondayTemplate = monday;
            return this;
        }
        public WeeklyTemplate SetTuesday(DailyTemplate tuesday)
        {
            MondayTemplate = tuesday;
            return this;
        }
        public WeeklyTemplate SetWednesday(DailyTemplate wednesday)
        {
            MondayTemplate = wednesday;
            return this;
        }
        public WeeklyTemplate SetThursday(DailyTemplate thursday)
        {
            MondayTemplate = thursday;
            return this;
        }
        public WeeklyTemplate SetFriday(DailyTemplate friday)
        {
            MondayTemplate = friday;
            return this;
        }
        public WeeklyTemplate SetSaturday(DailyTemplate saturday)
        {
            MondayTemplate = saturday;
            return this;
        }
        public WeeklyTemplate SetSunday(DailyTemplate sunday)
        {
            MondayTemplate = sunday;
            return this;
        }
    }

    public class DailyTemplate
    {
        public string Day { get; set; }
        public int StartingTimeInHours { get; set; }
        public int SlotDurationInHours { get; set; }
        public int NumberOfSlots { get; set; }

        public DailyTemplate(string name, int startingTimeInHours, int slotDurationInHours, int numberOfSlots)
        {
            if (numberOfSlots * slotDurationInHours > 24)
                throw new Exception("Cannot Have more than 24 Hours in a day");

            Day = name;
            StartingTimeInHours = startingTimeInHours;
            SlotDurationInHours = slotDurationInHours;
            NumberOfSlots = numberOfSlots;
        }
    }
}
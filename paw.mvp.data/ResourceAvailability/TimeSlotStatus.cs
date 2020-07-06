using paw.mvp.data.Base;

namespace paw.mvp.data.ResourceAvailability
{
    public class TimeSlotStatus: Enumeration

    {
        public static TimeSlotStatus Awaiting = new TimeSlotStatus(1, "Awaiting");
        public static TimeSlotStatus InProgress = new TimeSlotStatus(2, "InProgress");
        public static TimeSlotStatus Completed = new TimeSlotStatus(3, "Completed");
        public TimeSlotStatus(int id, string name) : base(id, name)
        {

        }
    }
}
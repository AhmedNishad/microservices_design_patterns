using paw.mvp.data.Base;

namespace paw.mvp.data.Appointment
{
    public class AppointmentStatus: Enumeration
    {
        public static AppointmentStatus Awaiting = new AppointmentStatus(1, "Awaiting");
        public static AppointmentStatus InProgress = new AppointmentStatus(2, "InProgress");
        public static AppointmentStatus Completed = new AppointmentStatus(3, "Completed");
        public static AppointmentStatus Cancelled = new AppointmentStatus(4, "Cancelled");
        public static AppointmentStatus Confirmed = new AppointmentStatus(5, "Confirmed");
        public AppointmentStatus(int id, string name) : base(id, name)
        {

        }
    }
}
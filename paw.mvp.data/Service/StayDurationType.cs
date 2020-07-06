using paw.mvp.data.Base;

namespace paw.mvp.data.Service
{
    public class StayDurationType: Enumeration
    {
        public static StayDurationType CheckInOut = new StayDurationType(1, "CheckInOut");
        public static StayDurationType Duration = new StayDurationType(2, "Duration");
        public StayDurationType(int id, string name) : base(id, name)
        {

        }
    }
}
using paw.mvp.data.Base;

namespace paw.mvp.data.Service
{
    public class ResourceCategory: Enumeration
    {
        public static ResourceCategory Employee = new ResourceCategory(1, "Employee");
        public static ResourceCategory Room = new ResourceCategory(2, "Room");
        public static ResourceCategory Both = new ResourceCategory(3, "Both");
        public ResourceCategory(int id, string name) : base(id, name)
        {

        }
    }
}
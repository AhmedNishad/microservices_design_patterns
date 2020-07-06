using paw.mvp.data.Base;

namespace paw.mvp.data.Service
{
    public class ServiceCategory: Enumeration
    {
        public static ServiceCategory Grooming = new ServiceCategory(1, "Grooming");
        public static ServiceCategory Boarding = new ServiceCategory(2, "Boarding");
        public static ServiceCategory Daycare = new ServiceCategory(3, "Daycare");
        public ServiceCategory(int id, string name): base(id, name)
        {

        }
    }
}
using paw.mvp.data.Employee;
using paw.mvp.data.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Customer
{
    public class PetPreferences
    {
        public EmployeeEntity PrefferedGroomer { get; set; }
        public EmployeeEntity PreferredTrainer { get; set; }
        public SpaceType PreferredRoomType{ get; set; }
        public string PlayGroup { get; set; }
    }
}

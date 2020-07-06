using paw.mvp.data.Base;
using paw.mvp.data.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Customer
{
    public class FeedingHistory
    {
        public DateTime FeedingDate { get; set; }
        public Food Food { get; set; }
        public FoodConsumed FoodConsumed { get; set; }
        public EmployeeEntity Employee { get; set; }
        public string Warning { get; set; }

    }

    public class FoodConsumed: Enumeration
    {
        public static FoodConsumed All = new FoodConsumed(1, "All");
        public static FoodConsumed None = new FoodConsumed(2, "None");
        public static FoodConsumed Quarter = new FoodConsumed(2, "Quarter");
        public static FoodConsumed Half = new FoodConsumed(2, "Half");
        public FoodConsumed(int id, string name) : base(id, name)
        {

        }
    }
}

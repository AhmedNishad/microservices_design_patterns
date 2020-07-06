using paw.mvp.data.Base;
using paw.mvp.data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Customer
{
    public class Diet
    {
        public TimeDuration TimeSlot{ get; set; } // Irrelevant?
        // Composite Object?
        public List<Food> Food { get; set; }
    }

    public class Food
    {
        public FoodServing AMFeeding { get; set; }
        public FoodServing MidDayFeeding { get; set; }
        public FoodServing PMFeeding { get; set; }
        public bool FeedAlong { get; set; }
        public string Other { get; set; }
        public string FoodName { get; set; }
    }

    public class FoodServing
    {
        public int Quantity { get; set; }
        public ServingType ServingType { get; set; }
    }

    public class ServingType: Enumeration
    {
        public static ServingType Slice = new ServingType(1, "Slice");
        public static ServingType Bite = new ServingType(2, "Bite");
        public static ServingType Plate = new ServingType(3, "Plate");
        public static ServingType Pod = new ServingType(4, "Pod");
        public ServingType(int id, string name) : base(id, name)
        {

        }
    }
}

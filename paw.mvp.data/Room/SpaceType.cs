using paw.mvp.data.Base;

namespace paw.mvp.data.Room
{
    public class SpaceType: Enumeration
    {
        public static SpaceType Deluxe = new SpaceType(1, "Deluxe");
        public static SpaceType Luxury = new SpaceType(2, "Luxury");
        public SpaceType(int id, string name) : base(id, name)
        {

        }
    }
}
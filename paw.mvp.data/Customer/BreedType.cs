using paw.mvp.data.Base;

namespace paw.mvp.data.Customer
{
    public class BreedType: Enumeration
    {
        public static BreedType Dog = new BreedType(1, "Dog");
        public static BreedType Cat = new BreedType(2, "Cat");
        public BreedType(int id, string name): base(id, name)
        {

        }
    }
}
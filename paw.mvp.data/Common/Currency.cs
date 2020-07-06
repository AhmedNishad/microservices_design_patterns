using paw.mvp.data.Base;

namespace paw.mvp.data.Common
{
    public class Currency: Enumeration
    {
        public static Currency UsDollars = new Currency(1, "UsDollars");
        public static Currency SriLankanRupees = new Currency(2, "SriLankanRupees");
        public Currency(int id, string name) : base(id, name)
        {

        }
    }
}
using paw.mvp.data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Common
{
    // Value Object
    public class PhoneNumber: ValueObject
    {
        public int Number { get; set; }
        public int CountryCode { get; set; }

        public PhoneNumber(int number, int country)
        {
            if(number.ToString().Length != 10)
            {
                throw new Exception("Phone Number cannot be less that 10 characters");
            }

            if(country > 150 || country < 1)
            {
                throw new Exception("Please Enter valid country code");
            }
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Number;
            yield return CountryCode;
        }
    }
}

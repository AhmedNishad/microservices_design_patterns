using paw.mvp.data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Common
{
    // Value Object
    public class Address: ValueObject
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public Address(string street, string city, string state, string zip, string country)
        {
            Street = street;
            State = state;
            Zip = zip;
            Country = country;
            City = city;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Street;
            yield return City;
            yield return State;
            yield return Country;
            yield return Zip;
        }
    }
}

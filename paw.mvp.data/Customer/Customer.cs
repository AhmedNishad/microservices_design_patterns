using paw.mvp.data.Base;
using paw.mvp.data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Customer
{
    public class CustomerEntity: AuditableEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Address Address{ get; set; }
        public List<PhoneNumber> ContactNumbers { get; set; }

        public List<Pet> Pets { get; set; }
        public CustomerEntity(string firstName, string lastName, string email, Address address, List<PhoneNumber> contactNumbers)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
            ContactNumbers = contactNumbers;
            Pets = new List<Pet>();
        }

        public CustomerEntity AddPet(Pet pet)
        {
            Pets.Add(pet);
            return this;
        }

        
    }
}

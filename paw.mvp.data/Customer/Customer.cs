using paw.mvp.data.Appointment;
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
        public string CustomerImage { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Address Address{ get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool SignedWaiver { get; set; }
        public List<PhoneNumber> ContactNumbers { get; set; }
        public List<Payment> Payments{ get;private set; }
        public Price Debit { get; set; }
        public List<Pet> Pets { get; set; }
        public CustomerEntity(string firstName, string lastName, string email, Address address,
            List<PhoneNumber> contactNumbers, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
            ContactNumbers = contactNumbers;
            DateOfBirth = dateOfBirth;
            Pets = new List<Pet>();
            Payments = new List<Payment>();
            SignedWaiver = false;
        }

        public CustomerEntity AddPet(Pet pet)
        {
            Pets.Add(pet);
            return this;
        }

        public CustomerEntity AddPayment(Payment payment)
        {
            Payments.Add(payment);
            Debit = new Price { Currency = Currency.UsDollars, Value = 0 };
            return this;
        }
    }
}

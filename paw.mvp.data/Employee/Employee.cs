using paw.mvp.data.Common;
using paw.mvp.data.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Employee
{
    public class EmployeeEntity : Resource
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PhoneNumber ContactNumber { get; set; }
        public string Email { get; set; }
        public PayRoll Payroll { get; set; }
        private List<Grooming> ProficientServices { get; set; }
        public Gender Gender { get; set; }
        public EmployeeType EmployeeType { get; private set; }
        public bool IsActive { get; private set; }
        public EmployeeEntity(string firstName, string lastName, PhoneNumber number, string email, PayRoll payRoll, EmployeeType type)
        {
            FirstName = firstName;
            LastName = lastName;
            ContactNumber = number;
            Email = email;
            Payroll = payRoll;
            EmployeeType = type;
        }

        public void UpdateEmployeeType(EmployeeType type)
        {
            EmployeeType = type;
        }

        public List<Grooming> GetProficientServices()
        {
            if(EmployeeType != EmployeeType.GroomingSpecialist)
            {
                throw new InvalidOperationException("This employee is not a grooming specialist!");
            }

            return ProficientServices;
        }

        public void ToggleActivity()
        {
            IsActive = !IsActive;
        }
    }
}

using paw.mvp.data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Employee
{
    public class EmployeeType: Enumeration
    {
        public static EmployeeType GroomingSpecialist = new EmployeeType(1, "GroomingSpecialist");
        public static EmployeeType AdministrativeStaff = new EmployeeType(2, "AdministrativeStaff");
        public static EmployeeType MaintenanceStaff = new EmployeeType(3, "MaintenanceStaff");
        public static EmployeeType Vet = new EmployeeType(4, "Vet");
        public static EmployeeType Trainer = new EmployeeType(5, "Trainer");

        public EmployeeType(int id, string name) : base(id, name)
        {

        }
    }
}

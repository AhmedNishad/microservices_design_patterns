using paw.mvp.data.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Customer
{
    public class Medication
    {
        public string MedicationDate { get; set; }
        public string AMDosage { get; set; }
        public string MidDayDosage { get; set; }
        public string PMDosage { get; set; }
        public string Other { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class MedicationHistory
    {
        public DateTime MedicationDate { get; set; }
        public Medication Medication { get; set; }
        public string GivenDosage { get; set; }
        public EmployeeEntity Employee{ get; set; }
        public string Warning { get; set; }

    }
}

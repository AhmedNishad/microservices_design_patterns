using paw.mvp.data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Customer
{
    public class Vaccination
    {
        public VaccinationType VaccinationType { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string DocumentFile { get; set; }
    }

    public class VaccinationType: Enumeration
    {
        public static VaccinationType Rabies = new VaccinationType(1, "Rabies");
        public static VaccinationType Parvo = new VaccinationType(2, "Parvo");
        public static VaccinationType Distemper = new VaccinationType(3, "Distemper");
        public static VaccinationType K9Influenza = new VaccinationType(4, "K9Influenza");
        public static VaccinationType Fecal = new VaccinationType(5, "Fecal");

        public VaccinationType(int id, string name) : base(id, name)
        {

        }
    }
}

using paw.mvp.data.Base;
using paw.mvp.data.Common;
using paw.mvp.data.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Customer
{
    public class Pet: AuditableEntity
    {
        public string PetImage { get; set; }
        public string PetName { get; set; }
        public decimal WeightInPounds { get; set; }
        public DateTime BirthDate { get; set; }
        public PetGender Gender{ get; set; }
        public string Colour { get; set; }
        public Notes Notes { get; set; }
        public PetPreferences Preferences { get; set; }
        public Breed BelongsToBreed { get; set; }
        public Diet DietPlan { get; set; }
        public bool Deceased { get; private set; }
        public EmployeeEntity Vet { get; private set; }
        public List<Vaccination> Vaccinations { get; set; }
        public List<Medication> Medications { get; set; }
        public List<Conditions> Conditions { get; set; }
        public List<FeedingHistory> FeedingHistory{ get; set; }
        public List<MedicationHistory> MedicationHistory { get; set; }
        // Customer FK
        private int customerId { get; set; }
        public Pet(string name, decimal weightInPounds, DateTime birthDate, PetGender gender, Breed breed, string color)
        {
            PetName = name;
            WeightInPounds = weightInPounds;
            BirthDate = birthDate;
            Gender = gender;
            BelongsToBreed = breed;
            Colour = color;
            Deceased = false;
        }

        public Pet SetDietPlan(Diet plan)
        {
            DietPlan = plan;
            return this;
        }

        public Pet SetVaccinations(List<Vaccination> vaccinations)
        {
            Vaccinations = vaccinations;
            return this;
        }

        public Pet SetCondtions(List<Conditions> conditions)
        {
            Conditions = conditions;
            return this;
        }

        public Pet SetMedications(List<Medication> medications)
        {
            Medications = medications;
            return this;
        }

        public Pet AssignVet(EmployeeEntity vet)
        {
            if(vet.EmployeeType != EmployeeType.Vet)
            {
                throw new InvalidOperationException("Cannot assign non vet as a vet");
            }
            Vet = vet;
            return this;
        }

        public Pet AddNotes(Notes notes)
        {
            Notes = notes;
            return this;
        }

        public Pet AddFeedingHistory(FeedingHistory history)
        {
            var existing = FeedingHistory.FirstOrDefault(f => f.FeedingDate.Date == history.FeedingDate.Date);
            if(existing == null)
            {
                FeedingHistory.Add(history);
            }
            else
            {
                existing = history;
            }
            return this;
        }

        public Pet AddMedicationHistory(MedicationHistory history)
        {
            var existing = MedicationHistory.FirstOrDefault(f => f.MedicationDate.Date == history.MedicationDate.Date);
            if (existing == null)
            {
                MedicationHistory.Add(history);
            }
            else
            {
                existing = history;
            }
            return this;
        }

        public Pet AddPreferences(PetPreferences preferences)
        {
            Preferences = preferences;
            return this;
        }

        public Pet Kill()
        {
            Deceased = true;
            return this;
        }
    }
}

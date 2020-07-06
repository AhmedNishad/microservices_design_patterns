using paw.mvp.data.Base;
using paw.mvp.data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Customer
{
    public class Pet: AuditableEntity
    {
        public string PetName { get; set; }
        public decimal WeightInPounds { get; set; }
        public DateTime BirthDate { get; set; }
        public PetGender Gender{ get; set; }
        public Breed BelongsToBreed { get; set; }
        public DietPlan DietPlan { get; set; }
        public bool Deceased { get; private set; }

        public Pet(string name, decimal weightInPounds, DateTime birthDate, PetGender gender, Breed breed)
        {
            PetName = name;
            WeightInPounds = weightInPounds;
            BirthDate = birthDate;
            Gender = gender;
            BelongsToBreed = breed;
            Deceased = false;
        }

        public Pet AddDietPlan(DietPlan plan)
        {
            DietPlan = plan;
            return this;
        }
        public Pet Kill()
        {
            Deceased = true;
            return this;
        }
    }
}

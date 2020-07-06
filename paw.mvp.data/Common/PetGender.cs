using paw.mvp.data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Common
{
    public class PetGender: Enumeration
    {
        public static readonly PetGender MaleNotNuetered = new PetGender(1, "MaleNotNuetered");
        public static readonly PetGender MaleNuetered = new PetGender(2, "MaleNuetered");
        public static readonly PetGender FemaleNotSprayed = new PetGender(3, "FemaleNotSprayed");
        public static readonly PetGender FemaleSprayed = new PetGender(4, "FemaleSprayed");

        public PetGender(int id, string name) : base(id, name)
        {

        }
    }
}

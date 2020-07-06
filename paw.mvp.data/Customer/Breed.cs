using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Customer
{
    public class Breed
    {
        public int BreedId { get; set; }
        public string BreedName { get; set; }
        public BreedType Type { get; set; }
    }
}

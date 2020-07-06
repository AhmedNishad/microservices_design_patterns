using paw.mvp.data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Customer
{
    public class Breed: AuditableEntity
    {
        public string BreedName { get; set; }
        public string BreedImage { get; set; }
        public BreedType Type { get; set; }
    }
}

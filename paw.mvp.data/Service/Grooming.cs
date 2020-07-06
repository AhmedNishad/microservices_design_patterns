using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Service
{
    public class Grooming: ServiceEntity
    {
        public TimeSpan Duration { get; set; }

        public Grooming(int TenantId, int BranchId, ServiceCategory ServiceCategory,
            ResourceCategory ResourceCategory, TimeSpan duration) :
            base(TenantId, BranchId, ServiceCategory, ResourceCategory)
        {
            if (ServiceCategory != ServiceCategory.Grooming)
            {
                throw new InvalidEnumArgumentException("Cannot create non Grooming service");
            }

            Duration = duration;
        }
    }
}

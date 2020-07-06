using paw.mvp.data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Tenant
{
    public class TenantEntity: Entity
    {
        public string Name { get; set; }
        public List<Branch> Locations { get; set; }
    }
}

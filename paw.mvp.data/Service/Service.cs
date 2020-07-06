using paw.mvp.data.Base;
using paw.mvp.data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace paw.mvp.data.Service
{
    public class ServiceEntity: AuditableEntity
    {
        public int BranchId { get; set; }
        public ServiceCategory ServiceCategory { get; set; }
        public ResourceCategory ResourceCategory { get; set; }
        public bool IsAvailable { get; set; } // Derived?
        public Price Price { get; set; } // Derived?
        public ServiceEntity(int tenantId, int branchId, ServiceCategory serviceCategory, ResourceCategory resourceCategory) : base()
        {
            TenantId = tenantId;
            BranchId = branchId;
            ServiceCategory = serviceCategory;
            ResourceCategory = resourceCategory;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Base
{
    public class AuditableEntity: Entity
    {
        public int TenantId { get; set; }
        private DateTime DateCreated { get; set; }
        private DateTime DateModified { get; set; }
    }
}

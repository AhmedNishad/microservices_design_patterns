using paw.mvp.data.Base;
using paw.mvp.data.ResourceAvailability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Common
{
    public class Resource: AuditableEntity
    {
        public Calendar Calendar{ get; set; }

        public void AssignCalander(Calendar calandar)
        {
            Calendar = calandar;
        }
    }
}

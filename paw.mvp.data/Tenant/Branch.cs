using paw.mvp.data.Base;
using paw.mvp.data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Tenant
{
    public class Branch: Entity
    {
        public string Name { get; set; }
        public Location Location{ get; set; }
    }
}

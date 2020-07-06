using paw.mvp.data.Common;
using paw.mvp.data.ResourceAvailability;
using paw.mvp.data.Service;
using paw.mvp.data.Tenant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Room
{
    public class RoomEntity: Resource
    {
        public string UniqueName { get; set; } // Composite Primary Key with Id
        public int Capacity { get; set; }
        public int BranchId { get; set; }
        public SpaceType SpaceType { get; set; }
        public List<ServiceEntity> OfferedServices { get; set; } // Acheive Many to Many Mapping? Do we put a similar list on services
                                                                 // Like Offered By?
        
    }
}

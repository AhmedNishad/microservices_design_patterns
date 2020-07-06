using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Service
{
    public class DayCare: ServiceEntity
    {
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public TimeSpan Duration { get; set; }
        public StayDurationType StayDurationType { get; set; }

        public DayCare(int TenantId, int BranchId, ServiceCategory ServiceCategory,
            ResourceCategory ResourceCategory, StayDurationType stayDurationType) :
            base(TenantId, BranchId, ServiceCategory, ResourceCategory)
        {
            if (ServiceCategory != ServiceCategory.Boarding)
            {
                throw new InvalidEnumArgumentException("Cannot create non daycare service");
            }

            this.StayDurationType = stayDurationType;
        }

        public void AddDuration(TimeSpan duration)
        {
            if (StayDurationType != StayDurationType.Duration)
                throw new InvalidEnumArgumentException("Cannot add Duration");
            Duration = duration;
        }

        public void AddCheckOut(DateTime checkIn, DateTime checkOut)
        {
            if (StayDurationType != StayDurationType.Duration)
                throw new InvalidEnumArgumentException("Cannot add check in/ out");
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
    }
}

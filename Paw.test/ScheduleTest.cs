using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Newtonsoft.Json.Bson;
using paw.mvp.data.ResourceAvailability;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Paw.test
{
    public class ScheduleTest
    {
        [Fact]
        public void ScheduleCreatesSuccessfully()
        {
            var sut = new Schedule(1, 2, new DateTime(2020, 12, 30), 2, 5);
            var sut2 = new Schedule(1, 2, new DateTime(2020, 12, 30), 2, 5);
            var sut3 = new Schedule(1, 2, new DateTime(2020, 12, 30), 2, 5);

            Assert.Equal(8, sut.TimeSlots.Count);
            Assert.Equal(12, sut2.TimeSlots.Count);
            Assert.Equal(24, sut3.TimeSlots.Count);
        }
    }
}

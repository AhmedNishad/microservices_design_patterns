using paw.mvp.data.Base;
using paw.mvp.data.Common;
using paw.mvp.data.Customer;
using paw.mvp.data.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Versioning;
using System.Threading.Tasks;

namespace paw.mvp.data.Appointment
{
    public class AppointmentEntity: Entity
    {
        public ServiceEntity Service { get; set; }
        public List<Resource> Resources { get; set; }
        public List<TimeDuration> Durations { get; set; }
        public CustomerEntity Customer{ get; set; }
        public List<Pet> Pets { get; set; } // Should a pet have it's own set of appointment instances and resources?
        public List<AppointmentInstance> AppointmentInstances { get; set; }
        public Payment Payment { get; set; }

        public AppointmentEntity( List<TimeDuration> timeDurations
            , CustomerEntity customer, List<Pet> pets, PaymentMethod paymentMethod)
        {
            Durations = timeDurations;
            Customer = customer;
            Payment = new Payment(Service.Price, new Price { Currency = Currency.UsDollars, Value = (Service.Price.Value * .25m) },
                customer.Debit, paymentMethod);
            Customer.AddPayment(Payment);
            Pets = pets;
            AppointmentInstances = new List<AppointmentInstance>();
            foreach(var duration in Durations)
            {
                var instance = new AppointmentInstance { Date = duration.StartDateTime, AppointmentStatus = AppointmentStatus.Awaiting };
            }
        }

       

        public AppointmentEntity AddService(ServiceEntity service)
        {
            Service = service;
            return this;
        }

        public AppointmentEntity AddResources(List<Resource> resources)
        {
            Resources = resources;
            return this;
        }

        public void SetAppointmentStatus(AppointmentStatus status, DateTime date)
        {
            var instance = AppointmentInstances.FirstOrDefault(a => a.Date.Date == date.Date);
            if(instance == null)
            {
                throw new InvalidOperationException("Appointment instance doesn't exist for this date");
            }
            if(status.Name == AppointmentStatus.Confirmed.Name)
            {
                instance.Confirm();
            }else if (status == AppointmentStatus.InProgress)
            {
                instance.SetInProgress();
            }else if (status == AppointmentStatus.Completed)
            {
                instance.Complete();
            }else if (status == AppointmentStatus.Cancelled)
            {
                instance.Cancel();
            }

        }
    }
}

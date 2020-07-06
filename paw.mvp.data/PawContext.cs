using Microsoft.EntityFrameworkCore;
using paw.mvp.data.Appointment;
using paw.mvp.data.Customer;
using paw.mvp.data.Employee;
using paw.mvp.data.ResourceAvailability;
using paw.mvp.data.Room;
using paw.mvp.data.Service;
using paw.mvp.data.Tenant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data
{
    public class PawContext: DbContext
    {
        // Customer
        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<DietPlan> DietPlans { get; set; }
        public DbSet<Diet> Diets { get; set; }

        // Service
        public DbSet<ServiceEntity> Services { get; set; }

        // Room
        public DbSet<RoomEntity> Rooms { get; set; }

        // Tenant
        public DbSet<TenantEntity> Tenants { get; set; }
        public DbSet<Branch> Branches { get; set; }

        // Resource Availability
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }

        // Employee
        public DbSet<EmployeeEntity> Employees { get; set; }
        public DbSet<PayRoll> PayRolls { get; set; }

        // Appointment
        public DbSet<AppointmentEntity> Appointments { get; set; }
        public DbSet<AppointmentInstance> AppointmentInstances { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("Data Source=paw.db");
    }
}

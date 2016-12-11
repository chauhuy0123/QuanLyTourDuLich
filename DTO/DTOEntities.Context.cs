﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TourManagerEntities : DbContext
    {
        public TourManagerEntities()
            : base("name=TourManagerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeRole> EmployeeRoles { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<PassengerCategory> PassengerCategories { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<TourCategory> TourCategories { get; set; }
        public DbSet<TourGroup> TourGroups { get; set; }
        public DbSet<TourGroupDetail> TourGroupDetails { get; set; }
        public DbSet<TourPrice> TourPrices { get; set; }
        public DbSet<TourSite> TourSites { get; set; }
        public DbSet<Transport> Transports { get; set; }
    }
}
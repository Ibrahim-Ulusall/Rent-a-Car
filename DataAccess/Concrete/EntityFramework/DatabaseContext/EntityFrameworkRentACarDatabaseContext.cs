﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.DatabaseContext
{
    public class EntityFrameworkRentACarDatabaseContext : DbContext
    {
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CarProjectDatabase;Trusted_Connection=true;");
		}

        public DbSet<Vehicle> Vehicles { get; set; }
		public DbSet<Model> Models { get; set; }
		public DbSet<Brand> Brands { get; set; }
		public DbSet<Color> Colors { get; set; }
		public DbSet<RateOfEngine> RateOfEngines { get; set; }
		public DbSet<CarDetail> CarDetails { get; set; }
		public DbSet<Rental> Rentals { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<City> Cities { get; set; }
		public DbSet<District> Districts { get; set; }


	}
}

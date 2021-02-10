﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarRentalSystemContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-GBHNIIE; Database=CarRentalSystemDB; Trusted_Connection=true");
        }
        public DbSet<Car> tCars { get; set; }
        public DbSet<Color> tColors { get; set; }
        public DbSet<Brand> tBrands { get; set; }
    }
}

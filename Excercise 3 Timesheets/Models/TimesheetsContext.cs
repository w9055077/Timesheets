using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Excercise_3_Timesheets.Models
{
    class TimesheetsContext : DbContext
    {
        public DbSet<Location> Locations { get; set; }

        public DbSet<Staff> Staffs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Timesheets;");

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Location>().HasData(
                new Location { LocationId = 1, Name = "Office 1", Address = "20 Aldwin Close, Chilton"},
                new Location { LocationId = 2, Name = "Office 2", Address = "16 Atha Lane, Keswick" },
                new Location { LocationId = 3, Name = "Office 3", Address = "2 Deathvalley, Indiana" }
                );

            builder.Entity<Staff>().HasData(
                new Staff { StaffId = 1, Surname = "Dinsley", Forename = "Joe", Email = "Joedinsley31@gmail.com" },
                new Staff { StaffId = 2, Surname = "Smith", Forename = "Stefan", Email = "Stefansmith1@gmail.com" },
                new Staff { StaffId = 3, Surname = "Quaker", Forename = "Jamie", Email = "Jamiequaker4808@gmail.com" },
                new Staff { StaffId = 4, Surname = "Stevenson", Forename = "Skye", Email = "Skyestevenson0@gmail.com" },
                new Staff { StaffId = 5, Surname = "Atkinson", Forename = "David", Email = "Davidatkinson111@gmail.com" },
                new Staff { StaffId = 6, Surname = "Ridley", Forename = "Gary", Email = "Garyridley007@gmail.com" }
                );
        }


    }
}

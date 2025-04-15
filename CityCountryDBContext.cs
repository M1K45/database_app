using database_app;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("GUI"), InternalsVisibleTo("MauiApp1")]

namespace database_app
{
    public class CityCountryDBContext : DbContext
    {
            public DbSet<City> Cities { get; set; }
            public DbSet<Country> Countries { get; set; }
        public CityCountryDBContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=CityCountry.db");

        }
    }
}

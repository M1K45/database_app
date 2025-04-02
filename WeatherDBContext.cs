using database_app;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace database_app
{
    internal class WeatherDBContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public WeatherDBContext() { 
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Cities.db");

        }
        protected override async void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<string> citiesList = ["Wroclaw", "Praga", "Barcelona", "Dubrovnik", "Valetta"];
            foreach (var city in citiesList) {
                HttpClient client = new HttpClient();
                string key = "35191f5f03089db2dc2d68f960ec6bcb";
                string call = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={key}";
                string response = await client.GetStringAsync(call);
                City foo = JsonSerializer.Deserialize<City>(response);
                modelBuilder.Entity<City>().HasData(
                    new City() { name = foo.name, timezone = foo.timezone, weather = foo.weather, main = foo.main, sys = foo.sys });
            }
        }
    }
}

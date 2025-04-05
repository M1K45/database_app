using database_app;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("GUI")]

namespace database_app
{
    public class WeatherDBContext : DbContext
    {
        public DbSet<Weather> weathers { get; set; }

        public WeatherDBContext() { 
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Weather.db");

        }
        protected override async void OnModelCreating(ModelBuilder modelBuilder)
        {
            //List<string> citiesList = ["Wroclaw", "Cracow", "Warsaw"];
            //foreach (var city in citiesList) {

            //    // pobranie danych z api 
            //    HttpClient client = new HttpClient();
            //    string key = "35191f5f03089db2dc2d68f960ec6bcb";
            //    string call = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={key}";
            //    string response = await client.GetStringAsync(call);
            //    Weather foo = new Weather();
            //    foo = JsonSerializer.Deserialize<Weather>(response);

                // dodanie wiersza do bazy danych
            //    modelBuilder.Entity<Weather>().HasData(
            //        new Weather() { name = foo.name, timezone = foo.timezone, weather = foo.weather, main = foo.main});
            //}
        }
    }
}

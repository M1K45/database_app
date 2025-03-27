using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database_app
{
    public class Weather
    {
        public Coordinates coordinates;
        public List<Description> weatherDescription;
        public Temperature temperature;
        public Country country;
        public string city;
        public int timezone;

        public Weather(Coordinates coordinates, List<Description> weatherDescription, Temperature temperature, Country country, string city, int timezone)
        {
            this.coordinates = coordinates;
            this.weatherDescription = weatherDescription;
            this.temperature = temperature;
            this.country = country;
            this.city = city;
            this.timezone = timezone;
        }

        public Weather(string city)
        {
            this.city = city;
        }
    }
}

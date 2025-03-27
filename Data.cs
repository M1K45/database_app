using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database_app
{
    public class Coordinates
    {
        public double lon { get; set; }
        public double lat { get; set; }

        public Coordinates(double lon, double lat)
        {
            this.lon = lon;
            this.lat = lat;
        }

        public override string ToString()
        {
            return $"Latitude (szerokość geograficzna): {lat}\nLongitude (długość geograficzna): {lon}";
        }

    }

    public class Description
    {
        string description { get; set; }
        public Description(string description)
        {
            this.description = description;
        }

        public override string ToString()
        {
            return $"Weather description: {description}";
        }

    }

    public class Temperature
    {
        string temp{ get; set; }
        string feels_like { get; set; }
        public Temperature(string temperature, string temperatureFeelsLike)
        {
            this.temp = temperature;
            this.feels_like = temperatureFeelsLike;
        }
        public override string ToString()
        {
            return $"Temperature: {feels_like}\nTemperature feels like: {feels_like}";
        }
    }

    public class Country
    {
        string country { get; set; }
        public Country(string country)
        {
            this.country = country;
        }
        public override string ToString()
        {
            return $"Country: {country}";
        }
    }

}

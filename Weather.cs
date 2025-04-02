using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("GUI")]
namespace database_app
{
    public class Weather
    {
        //public List<Description> weatherDescription;
        //public Temperature temperature;
        //public sys country;

        //public override string ToString()
        //{
        //    return country.ToString();
        //}
        public string name { get; set; }
        
        public int timezone { get; set; }
        public List<Description> weather {  get; set; }

        public Temperature main {  get; set; }



        public override string ToString()
        {
            return "Strefa czasowa: " + (this.timezone / 3600).ToString() + "h"
                + "\tMiasto: " + this.name 
                + "\tOpis pogody: " + this.weather[0].description
                + "\tTemperatura odczuwalna: " + this.main.feels_like;
        }

        //public override string ToString()
        //{
        //    string output = this.weatherDescription.ToString() +
        //        this.temperature.ToString() +
        //        this.country.ToString() +
        //        this.name +
        //        this.timezone.ToString();
        //    return output;
        //}
        //public Weather(Coordinates coordinates, List<Description> weatherDescription, Temperature temperature, Country country, string name, int timezone)
        //{
        //    this.coordinates = coordinates;
        //    this.weatherDescription = weatherDescription;
        //    this.temperature = temperature;
        //    this.country = country;
        //    this.name = name;
        //    this.timezone = timezone;
        //}

        //public Weather(string name)
        //{
        //    this.name = name;
        //}
    }

}

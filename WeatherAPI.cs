using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("GUI"), InternalsVisibleTo("MauiApp1")]
namespace database_app
{
    //  państwo
    public class WeatherAPI
    {
       
        public string name { get; set; }
        
        public List<Description> weather {  get; set; }

        public Temperature main {  get; set; }
        public CountryAPI sys { get; set; }
        public int timezone { get; set; }

        public override string ToString()
        {
            return $"Miasto: {this.name}\t" +
                $"\tPaństwo: {this.sys.country}" +
                $"\tOpis pogody: {this.weather[0].description}" +
                $"\tTemperatura: {this.main.temp}" +
                $"\tStrefa czasowa: {this.timezone/3600}";
        }
    }

    public class Description
    {
        public string description { get; set; }
    }

    public class Temperature
    {
        public double temp { get; set; }
    }

    public class CountryAPI
    {
        public string country{ get; set; }
    }
}


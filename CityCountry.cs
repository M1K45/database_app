using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database_app
{
    public class City
    {
        [Key]
        public string name { get; set; }
        public double temperature { get; set; }


        public string CountryId { get; set; } // foreing key being country name 
        public Country Country { get; set; }

        public string weather { get; set; }

        public override string ToString()
        {
            // to poprawic (może wymagany update bazy danych idk i czemu temperatura wyświetla 0 
            return $"Nazwa miasta: {this.name}" +
                $"\t Państwo: {this.CountryId}" +
                $"\tTemperatura: {this.temperature}" +
                $"\tPogoda: {this.weather}";
        }

    }

    public class Country
    {
        [Key]
        public string country { get; set; }
        public int timezone { get; set; } // assuming that country has only one 

        public ICollection<City> Cities { get; set; }
        public override string ToString()
        {
            return $"Państwo: {this.country}" +
                $"Strefa czasowa: {this.timezone}";
        }
    }
}
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
        public int timezone { get; set; }
        public Temperature main { get; set; }

        public Country sys { get; set; }

        public List<Description> weather { get; set; }

        public override string ToString()
        {
            return $"Nazwa miasta: {this.name}\tstrefa czasowa: {(this.timezone/3600).ToString()} " +
                $"\tOpis pogody: {weather[0].description}\tTemperatura: {main.temperature}" +
                $"Państwo: {sys.country}";
        }

    }

    public class Country
    {
        [Key] 
        public string country { get; set; }
        public List <string> cities { get; set; }

        public override string ToString()
        {
            string output = string.Empty;
            output += $"Państwo: {this.country}";
            if (cities != null)
            {
                output += "\tMiasta: ";
                foreach (var city in cities)
                {
                    output += city + "\t";
                }
            }
            return output;
        }
    }
}

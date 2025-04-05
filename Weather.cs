using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("GUI")]
namespace database_app
{
    public class Weather
    {
       
       [Key]
        public string name { get; set; }
        
        public int timezone { get; set; }
        //public List<Description> weather {  get; set; }

        //public Temperature main {  get; set; }

        public int temperature { get; set; }

        public override string ToString()
        {
            return "Strefa czasowa: " + (this.timezone / 3600).ToString() + "h"
                + "\tMiasto: " + this.name 
                //+ "\tOpis pogody: " + this.weather[0].description
                //+ "\tTemperatura : " + (this.main.temperature - 273).ToString();
        }
    }
}

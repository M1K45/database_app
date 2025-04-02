using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database_app
{
    public class City
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string name { get; set; }
        public int timezone { get; set; }
        public List<Description> weather { get; set; }
        public Temperature main { get; set; }
        public Country sys { get; set; }

        public override string ToString()
        {
            return $"Nazwa miasta: {this.name}\tstrefa czasowa: {(this.timezone/3600).ToString()} " +
                $"\tOpis pogody: {weather[0].description}\tTemperatura: {main.temperature}" +
                $"Państwo: {sys.country}";
        }

    }
}

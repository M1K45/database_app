using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database_app
{

    public class Description
    {
        public string description { get; set; }
    }

    public class Temperature
    {
        public string temperature { get; set; }
        public double feels_like { get; set; }
 
    }

    public class Country
    {
        public string country { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database_app
{

    public class Description
    {
        public int Id {  get; set; }
        public string description { get; set; }
    }

    public class Temperature
    {
        public int Id { get; set; }
        public double temperature { get; set; }
        //public double feels_like { get; set; }
 
    }



}

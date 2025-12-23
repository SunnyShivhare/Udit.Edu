using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UditEdu.Core.Models
{
     
     

        public class NationalizeData
        {
            public int count { get; set; }
            public string name { get; set; }
            public Country[] country { get; set; }
        }

        public class Country
        {
            public string country_id { get; set; }
            public float probability { get; set; }
        }

}

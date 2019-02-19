using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site1
{
    public class IndexModel
    {
       
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public string Deportament_name { get; set; }
        public string Deportament_desc { get; set; }

    }
}
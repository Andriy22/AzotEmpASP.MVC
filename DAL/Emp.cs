using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Emp
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public string login { get; set; }
        public string password { get; set; }
        public virtual Deportament deportament { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Deportament
    {
        public Deportament()
        {
            Empl = new List<Emp>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        virtual public ICollection<Emp> Empl { get; set; }
    }
}

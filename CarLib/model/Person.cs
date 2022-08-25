using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLib.model
{
    public class Person
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }

        public override string ToString()
        {
            return $"Id={Id}, Name={Name}, Address={Address}";
        }


    }
}

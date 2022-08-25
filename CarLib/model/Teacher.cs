using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLib.model
{
    public class Teacher:Person
    {
        public List<String> Courses { get; set; }

        public Teacher()
        {
            Courses = new List<String>();
        }

        public override string ToString()
        {
            return base.ToString() + $", Courses=[{String.Join(",", Courses)}]" ;
        }

    }
}

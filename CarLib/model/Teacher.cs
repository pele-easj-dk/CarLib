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


        public void ValidateCourses()
        {
            if (Courses is null || Courses.Count == 0) throw new ArgumentNullException("courses must not be null nor empty");

            if (Courses.Count > 10) throw new ArgumentNullException("courses can not exceed 10 courses");

        }

        public override void Validate()
        {
            base.Validate();
            ValidateCourses();
        }

    }
}

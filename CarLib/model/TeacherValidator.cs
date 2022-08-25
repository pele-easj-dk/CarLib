using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLib.model
{
    public static class TeacherValidator
    {
        public static void ValidateCourses(List<String> courses)
        {
            if (courses is null || courses.Count == 0) throw new ArgumentNullException("courses must not be null nor empty");

            if (courses.Count > 10) throw new ArgumentNullException("courses can not exceed 10 courses");

        }

        public static void Validate(Teacher teacher)
        {
            PersonValidator.Validate(teacher);
            ValidateCourses(teacher.Courses);
        }
    }
}

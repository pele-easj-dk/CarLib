using CarLib.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestModel
{
    [TestClass]
    public class TestTeacher
    {

        [TestInitialize]
        public void beforeEachTest()
        {

        }

        [TestMethod]
        public void TestCourseNotOK()
        {
            List<String> list = new List<String>();

            Assert.ThrowsException<ArgumentNullException>(() => TeacherValidator.ValidateCourses(null));
            Assert.ThrowsException<ArgumentNullException>(() => TeacherValidator.ValidateCourses(list));

        }

        [TestMethod]
        [DataRow(11)]
        public void TestCourseNotOK2(int lgt)
        {
            List<String> list = new List<String>();
            for (int i = 0; i < lgt; i++)
            {
                list.Add("Course" + i);

            }
            Assert.ThrowsException<ArgumentNullException>(() => TeacherValidator.ValidateCourses(list));

        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(10)]
        public void TestIdNotOK(int lgt)
        {
            List<String> list = new List<String>();

            for (int i = 0; i < lgt; i++)
            {
                list.Add("Course" + i);

            }
            TeacherValidator.ValidateCourses(list);
        }

        [TestMethod]
        public void TestTeacherMethod()
        {
            Teacher t = new Teacher();
            t.Id = 1;
            t.Name = "123";
            t.Address = "1234567890";
            t.Courses.Add("TEK");

            TeacherValidator.Validate(t);
        }

        [TestMethod]
        public void TestPersonMethodFail()
        {
            Teacher t = new Teacher();
            t.Id = 1;
            t.Name = "12"; //error
            t.Address = "1234567890";
            t.Courses.Add("TEK");

            Assert.ThrowsException<ArgumentException>(() => TeacherValidator.Validate(t));
        }

        [TestMethod]
        public void TestPersonMethodFail2()
        {
            Teacher t = new Teacher();
            t.Id = 1;
            t.Name = "123"; 
            t.Address = "1234567890";
            //t.Courses; empty => error

            Assert.ThrowsException<ArgumentNullException>(() => TeacherValidator.Validate(t));
        }


    }
}

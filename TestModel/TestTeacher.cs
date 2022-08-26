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

        private Teacher t = null;

        [TestInitialize]
        public void beforeEachTest()
        {
            t = new Teacher() { Id = 1, Name = "123", Address = "1234567890", Courses = new List<string>() };
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
            // arrange
            List<String> list = new List<String>();

            for (int i = 0; i < lgt; i++)
            {
                list.Add("Course" + i);

            }




            // act
            t.Courses = list;
            t.ValidateCourses();


            //assert
            // if not exception test is passing (green)
        }

        [TestMethod]
        public void TestTeacherMethod()
        {
            Teacher t = new Teacher();
            t.Id = 1;
            t.Name = "123";
            t.Address = "1234567890";
            t.Courses.Add("TEK");

            t.Validate();


        }

        [TestMethod]
        public void TestPersonMethodFail()
        {
            Teacher t = new Teacher();
            t.Id = 1;
            t.Name = "12"; //error
            t.Address = "1234567890";
            t.Courses.Add("TEK");

            Assert.ThrowsException<ArgumentException>(() => t.Validate());
        }

        [TestMethod]
        public void TestPersonMethodFail2()
        {
            Teacher t = new Teacher();
            t.Id = 1;
            t.Name = "123"; 
            t.Address = "1234567890";
            //t.Courses; empty => error

            Assert.ThrowsException<ArgumentNullException>(() => t.Validate());
        }


    }
}

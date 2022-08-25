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
    public class TestPerson
    {
        

        [TestInitialize]
        public void beforeEachTest()
        {
            
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        public void TestIdOK(int id)
        {
            PersonValidator.ValidateId(id);
        }

        [TestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        public void TestIdNotOK(int id)
        {
            Assert.ThrowsException<ArgumentException>(()=>PersonValidator.ValidateId(id));
        }

        [TestMethod]
        public void TestPersonMethod()
        {
            Person p = new Person();
            p.Id = 1;
            p.Name = "123";
            p.Address = "1234567890";

            PersonValidator.Validate(p);
        }
        [TestMethod]
        public void TestPersonMethodFail()
        {
            Person p = new Person();
            p.Id = 1;
            p.Name = "12"; // error
            p.Address = "1234567890";

            Assert.ThrowsException<ArgumentException>(() => PersonValidator.Validate(p));
        }


    }
}

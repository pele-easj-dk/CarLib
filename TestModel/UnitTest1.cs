using System;
using CarLib.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestModel
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Car c = new Car("zzTop", 345678, "Blue Node");

            //c.RegNo = "123456789";

            
            //Assert.AreEqual("123456789", c.RegNo);
            Assert.ThrowsException<ArgumentException>(() => c.RegNo = "123456789");
            Assert.ThrowsException<ArgumentNullException>(() => c.RegNo = null);


        }
    }
}
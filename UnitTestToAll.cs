using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day24_assignments;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestingEmail
{
     public class UnitTestToAll
    {
        private readonly Day24_assignments.UnitTestToAll unit;

        public UnitTestToAll()
        {
            unit=new Day24_assignments.UnitTestToAll();
        }

        [TestMethod]

        public void TestMethodFirstName()
        {
            string name = "Mohit";
            bool expected = true;
            bool result=unit.ValidFirstName(name);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]

        public void TestMethodFirstName2()
        {
            string name = "xyz";
            bool expected = false;
            bool result = unit.ValidFirstName(name);
            Assert.AreEqual(expected, result);

        }
        [TestMethod]

        public void TestMethodLastName()
        {
            string name = "xyz";
            bool expected = false;
            bool result = unit.ValidLastName(name);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]

        public void TestMethodLastName2()
        {
            string name = "Tanwar";
            bool expected = true;
            bool result = unit.ValidLastName(name);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]

        public void TestMethodPhonenumber()
        {
            string name = "xvggv";
            bool expected = false;
            bool result = unit.Phonenumber(name);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]


        public void TestMethodPhonenumber2()
        {
            string name = "91 7437377456";
            bool expected = true;
            bool result = unit.Phonenumber(name);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]


        public void TestMethodpassword()
        {
            string name = "91 7437377456";
            bool expected = false;
            bool result = unit.PassWord(name);
            Assert.AreEqual(expected, result);

        }

       [TestMethod]


        public void TestMethodpassword2()
        {
            string name = "@agdhvshdbsvhd";
            bool expected = true;
            bool result = unit.PassWord(name);
            Assert.AreEqual(expected, result);

        }







    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day24_assignments;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestingEmail
{
    [TestClass]
    public class UnitTestingCustomException
    {
        private readonly Day24_assignments.TestClassCustomException unit_customException;

        public UnitTestingCustomException()
        {
            unit_customException = new Day24_assignments.TestClassCustomException();
        }

        [TestMethod]



        public void TestMethodFirstName()
        {
            try
            {
                string name = "46664";
                bool result = unit_customException.ValidFirstName(name);


            }
            catch (CustomExceptionToAll ex)
            {
                Assert.AreEqual("Not Match", ex.Message);
            }

        }


        [TestMethod]



        public void TestMethodLastName()
        {
            try
            {
                string name = "46664";
                bool result = unit_customException.ValidLastName(name);


            }
            catch (CustomExceptionToAll ex)
            {
                Assert.AreEqual("Not Match", ex.Message);
            }

        }

        [TestMethod]



        public void TestMethodPhone()
        {
            try
            {
                string name = "mohit";
                bool result = unit_customException.Phonenumber(name);


            }
            catch (CustomExceptionToAll ex)
            {
                Assert.AreEqual("Not Match", ex.Message);
            }



        }

        [TestMethod]



        public void TestMethodEmail()
        {
            try
            {
                string name = "@$%^^&&";
                bool result = unit_customException.EmailSample(name);
            }
            catch(Exception ex)
            {
                Assert.AreEqual("Not Match", ex.Message);
            }


        }
    }
}

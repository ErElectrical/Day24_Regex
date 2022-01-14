using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day24_assignments;

namespace UnitTestingEmail
{
    [TestClass]
    public class UnitTest1
    {

        private readonly Day24_assignments.UnitTestingEmail unit;

        public UnitTest1()
        {
            unit= new Day24_assignments.UnitTestingEmail();
        }

        [TestMethod]
        public void TestMethod1()
        {
            string mail = "mohittanwa@mail.com";
            var result=unit.EmailSample(mail);
            Assert.AreEqual(false, result);


        }
        [TestMethod]
        public void TestMethod2()
        {
            string mail = "1425@....com";
            var result = unit.EmailSample(mail);
            Assert.AreEqual(false, result);

        }

        [TestMethod]

        public void TestMethod3()
        {
            string mail = "xyz.abc.bl@co.in";
            var result = unit.EmailSample(mail);
            Assert.AreEqual(true, result);

        }
    }
}
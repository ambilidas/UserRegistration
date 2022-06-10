using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using System;
using UserRegistration;
namespace Junit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Ambili","Ambili")]
        public void FirstName(string a,string expected)
        {
            ValidateForMSTest validate = new ValidateForMSTest();
            string actual = validate.FirstName(a);
            Assert.AreEqual(a, actual);
        }

        [TestMethod]
        [DataRow("das", "das")]
        public void LastName(string a, string expected)
        {
            ValidateForMSTest validate = new ValidateForMSTest();
            string actual = validate.LastName(a);
            Assert.AreEqual(a, actual);
        }

        [TestMethod]
        [DataRow("Abc@gmail.com", "Abc@gmail.com")]
        public void MailId(string a, string expected)
        {
            ValidateForMSTest validate = new ValidateForMSTest();
            string actual = validate.MailId(a);
            Assert.AreEqual(a, actual);
        }

        [TestMethod]
        [DataRow("91 7856231441", "91 7856231441")]
        public void PhoneNumber(string a, string expected)
        {
            ValidateForMSTest validate = new ValidateForMSTest();
            string actual = validate.PhoneNumber(a);
            Assert.AreEqual(a, actual);
        }

        [TestMethod]
        [DataRow("Anbc@.k142", "Anbc@.k142")]
        public void PassWord(string a, string expected)
        {
            ValidateForMSTest validate = new ValidateForMSTest();
            string actual = validate.PassWord(a);
            Assert.AreEqual(a, actual);
        }
    }
}
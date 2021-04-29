using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UserRegistrationTest
{
    [TestClass]
    
    public class UserTest
    {
        [TestMethod]
        public void VerifyFirstName_StartsWith_CapitalOrNot()
        {
            UserTest user = new UserTest();
            var firstName = "Shivam";
            var result = user.ValidateFirstName(firstName); ;
            Assert.IsTrue((bool)result);
        }

        private object ValidateFirstName(string firstName)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void VerifyLastName_StartsWith_CapitalOrNot()
        {
            UserTest user = new UserTest();
            var lastName = "Mathur";
            var result = user.ValidateLastName(lastName); ;
            Assert.IsTrue((bool)result);
        }

        private object ValidateLastName(string lastName)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        [DataRow("jrm@gmail.com")]
        [DataRow("jrm.cg@gmail.co.in")]
        [DataRow("jrm@gmail.co.in")]
        [DataRow("jrm100@gmail.com")]
        [DataRow("jrm-nit@1mg.co.in")]
        public void TestEmailValidation_ValidEmails(string email)
        {
            //Arrange
            UserTest user = new UserTest();
            bool expected = true;

            //Act
            bool actual = user.ValidateEmail(email);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        private bool ValidateEmail(string email)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        [DataRow("91 6231230127")]
        public void TestPhNumberValidation_ValidNumbers(string phNum)
        {
            //Arrange
            UserTest user = new UserTest();
            bool expected = true;
            //Act
            bool actual = user.ValidateMobileNumber(phNum);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        private bool ValidateMobileNumber(string phNum)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        [DataRow("Had2Te#t")]
        [DataRow("had2T3stP@ss")]
        [DataRow("T3STP@SS")]
        public void Test_ValidPasswords(string pass)
        {
            //Arrange
            UserTest user = new UserTest();
            bool expected = true;
            //Act
            bool actual = user.ValidatePassword(pass);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        private bool ValidatePassword(string pass)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Test_InvalidPassword()
        {
            //Arrange
            string pass = "Hd2T#t";
            UserTest user = new UserTest();
            bool expected = true;
            //Act
            bool actual = user.ValidatePassword(pass);
            //Assert
            Assert.AreNotEqual(expected, actual);
        }
    }
}

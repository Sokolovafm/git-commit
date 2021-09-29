using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryPassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPassword.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {
        [TestMethod()]
        public void Check_8Symbols_ReturnsTrue()
        {
            string password = "ASqw12$$";
            bool expected = true;
            //Act
            bool actual = PasswordChecker.validatePassword(password);
                //Asset
                Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_20Symbols_ReturnsFalse()
        {
            string password = "HGiuwqlkhlkh";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.validatePassword(password);
            //Asset
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Check_NumSymbols_ReturnsTrue()
        {
            string password = "ASqw12$$";
            bool expected = true;
            //Act
            bool actual = PasswordChecker.validatePassword(password);
            //Asset
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_NumSymbols_ReturnsFalse()
        {
            string password = "ASqw$$";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.validatePassword(password);
            //Asset
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Check_SpecSymbols_ReturnsTrue()
        {
            string password = "AShfsjfskj%$_";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.validatePassword(password);
            //Asset
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_SpecSymbols_ReturnsFalse()
        {
            string password = "ASqw";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.validatePassword(password);
            //Asset
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Check_BigSymbols_ReturnsTrue()
        {
            string password = "AAAAAAASqw$$";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.validatePassword(password);
            //Asset
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_BigSymbols_ReturnsFalse()
        {
            string password = "asqw$$";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.validatePassword(password);
            //Asset
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Check_SmallSymbols_ReturnsTrue()
        {
            string password = "asqwfffffffff";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.validatePassword(password);
            //Asset
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_SmallSymbols_ReturnsFalse()
        {
            string password = "asqw$$";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.validatePassword(password);
            //Asset
            Assert.IsFalse(actual);
        }
















    }


}
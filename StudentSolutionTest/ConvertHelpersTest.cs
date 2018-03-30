using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static StudentSolution.Helpers.Enums;
using StudentSolution.Helpers;

namespace StudentSolutionTest
{
    [TestClass]
    public class ConvertHelpersTest
    {
        [TestMethod]
        public void ReturnCharFromGender()
        {
            Gender male = Gender.Male;
            char maleValue = ConvertHelpers.ConvertEnumGenderToChar(male);
            Assert.AreEqual('M', maleValue);
        }

        [TestMethod]
        public void ReturnGenderFromString()
        {
            string gender = "F";
            Gender female = ConvertHelpers.ConvertToGender(gender);
            Assert.AreEqual(female, Gender.Female);
        }

        [TestMethod]
        public void ReturnGenderFromFullString()
        {
            string gender = "Female";
            Gender female = ConvertHelpers.ConvertToGender(gender);
            Assert.AreEqual(female, Gender.Female);
        }

        [TestMethod]
        public void ReturnDateTimeFromStringTimeStamp()
        {
            string timeStamp = "20180329213205";
            DateTime date = ConvertHelpers.ConvertToDate(timeStamp);
            Assert.AreEqual(date.Year, 2018);
            Assert.AreEqual(date.Month, 03);
            Assert.AreEqual(date.Day, 29);
            Assert.AreEqual(date.Hour, 21);
            Assert.AreEqual(date.Minute, 32);
            Assert.AreEqual(date.Second, 05);
        }
    }
}

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
    }
}

using System;
using NUnit.Framework;

namespace Task1.Solution.Tests
{
    [TestFixture]
    public class PasswordTest
    {
        [Test]
        public void Test_Valid_Password()
        {
            var rep = new SqlRepository();
            string actual = PasswordCheckerService.VerifyPassword("fhjfkjh3", rep).ToString();

            string expected = "(True, Password is Ok. User was created)";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Not_Valid_Password()
        {
            var rep = new SqlRepository();
            string str = "fhjfkjh3";
            PasswordCheckerService.VerifyPassword("fhjfkjh", rep);
        }
    }
}

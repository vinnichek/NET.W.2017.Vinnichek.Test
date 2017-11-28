using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Task1.Solution.Tests
{
    [TestFixture]
    public class PasswordTest
    {
        IRepository rep = new SqlRepository();
        List<IRules> rules = new List<IRules>();

        [Test]
        public void Test_Valid_Password()
        {
            rules.Add(new ShortPassRule());
            rules.Add(new NullPassRule());
            rules.Add(new HasLetterPassRule());

            string actual = PasswordCheckerService.VerifyPassword("23265248g", rep, rules).ToString();

            string expected = "(True, Password is Ok. User was created)";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Has_Letter_Rule_Password()
        {
            rules.Add(new ShortPassRule());
            rules.Add(new NullPassRule());
            rules.Add(new HasLetterPassRule());

            string actual = PasswordCheckerService.VerifyPassword("23265248", rep, rules).ToString();

            string expected = "(False, 23265248 hasn't alphanumerical chars)";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Short_Rule_Password()
        {
            rules.Add(new ShortPassRule());
            rules.Add(new NullPassRule());
            rules.Add(new HasLetterPassRule());

            string actual = PasswordCheckerService.VerifyPassword("23", rep, rules).ToString();

            string expected = "(False, 23 length too short)";

            Assert.AreEqual(expected, actual);
        }
    }
}

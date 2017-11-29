using System;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;

namespace Task1.Solution.Tests
{
    [TestFixture]
    public class PasswordTest
    {
        IRepository rep = new SqlRepository();
        List<IRules> rules = new List<IRules>();

        [TestCase("12345678a", ExpectedResult = "(True, Password is Ok. User was created)")]
        [TestCase("12345678", ExpectedResult = "(False, 12345678 hasn't alphanumerical chars)")]
        [TestCase("qwertyui", ExpectedResult = "(False, qwertyui hasn't digits)")]
        [TestCase("qwer", ExpectedResult = "(False, qwer length too short)")]
        public string Test_Verify_Password(string password)
        {
            rules.Add(new ShortPassRule());
            rules.Add(new HasNumberPassRule());
            rules.Add(new HasLetterPassRule());

            return PasswordCheckerService.VerifyPassword(password, rep, rules).ToString();;
        }

        [TestCase("12345678a")]
        [TestCase("qwerty123")]
        public void Mock_Test_Repository(string password)
        {
            rules.Add(new ShortPassRule());
            rules.Add(new NullPassRule());
            rules.Add(new HasLetterPassRule());

            var repositoryMock = new Mock<IRepository>();

            PasswordCheckerService.VerifyPassword(password, repositoryMock.Object, rules).ToString();

            repositoryMock.Verify(repository => 
                                  repository.Create(It.Is<string>(str => string.Equals(str, password, StringComparison.Ordinal))), Times.AtMostOnce());
        }
    }
}

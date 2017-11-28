using System;
using System.Linq;

namespace Task1.Solution
{
    public class PasswordCheckerService
    {
        public static Tuple<bool, string> VerifyPassword(string password, IRepository repository)
        {
            ValidatePassword.Validate(password);
            repository.Create(password);

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1.Solution
{
    public class PasswordCheckerService
    {
        public static Tuple<bool, string> VerifyPassword(string password, IRepository repository, List<IRules> rules)
        {
            try
            {
                foreach (var item in rules)
                {
                    item.Validate(password);
                }
            }

            catch(ArgumentException e)
            {
                return Tuple.Create(false, e.Message);
            }

            repository.Create(password);
            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
}

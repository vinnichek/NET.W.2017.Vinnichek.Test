using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1.Solution
{
    public class PasswordCheckerService
    {
        public static Tuple<bool, string> VerifyPassword(string password, IRepository repository, List<IRules> rules)
        {
            foreach (var item in rules)
            {
                var flag = item.Validate(password);
                if (!flag.Item1)
                {
                    return flag;
                }
            }

            repository.Create(password);
            return Tuple.Create(true, "Password is Ok. User was created"); 
         }
    }
}

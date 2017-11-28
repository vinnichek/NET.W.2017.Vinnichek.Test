using System;
using System.Linq;

namespace Task1.Solution
{
    public class HasNumberPassRule : IRules
    {
        public Tuple<bool, string> Validate(string password)
        {
            if (!password.Any(char.IsNumber))
                return Tuple.Create(false, $"{password} hasn't digits");
            else
                return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
}

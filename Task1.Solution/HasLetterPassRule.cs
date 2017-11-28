using System;
using System.Linq;

namespace Task1.Solution
{
    public class HasLetterPassRule : IRules
    {
        public Tuple<bool, string> Validate(string password)
        {
            if (!password.Any(char.IsLetter))
                return Tuple.Create(false, $"{password} hasn't alphanumerical chars");
            else
                return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
}

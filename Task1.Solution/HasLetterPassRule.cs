using System;
using System.Linq;

namespace Task1.Solution
{
    public class HasLetterPassRule : IRules
    {
        public void Validate(string password)
        {
            if (!password.Any(char.IsLetter))
                throw new ArgumentException($"{password} hasn't alphanumerical chars");
        }
    }
}

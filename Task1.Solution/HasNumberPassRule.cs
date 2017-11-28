using System;
using System.Linq;

namespace Task1.Solution
{
    public class HasNumberPassRule
    {
        public void Validate(string password)
        {
            if (!password.Any(char.IsNumber))
                throw new ArgumentException($"{password} hasn't digits");
        }
    }
}

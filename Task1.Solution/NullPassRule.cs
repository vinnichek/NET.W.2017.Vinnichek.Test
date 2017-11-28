using System;
using System.Linq;

namespace Task1.Solution
{
    public class NullPassRule : IRules
    {
        public void Validate(string password)
        {
            if (password == null)
                throw new ArgumentException($"{password} is null arg");
        }
    }
}

using System;
using System.Linq;

namespace Task1.Solution
{
    public class NullPassRule : IRules
    {
        public Tuple<bool, string> Validate(string password)
        {
            if (password == null)
                throw new ArgumentException($"{password} is null arg");
            else
                return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
}

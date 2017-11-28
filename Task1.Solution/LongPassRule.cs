using System;
namespace Task1.Solution
{
    public class LongPassRule : IRules
    {
        public Tuple<bool, string> Validate(string password)
        {
            if (password.Length >= 15)
                return Tuple.Create(false, $"{password} length too long");
            else
                return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
}

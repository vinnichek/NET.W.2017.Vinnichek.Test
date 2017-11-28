using System;
namespace Task1.Solution
{
    public class LongPassRule : IRules
    {
        public void Validate(string password)
        {
            if (password.Length >= 15)
                throw new ArgumentException($"{password} length too long");
        }
    }
}

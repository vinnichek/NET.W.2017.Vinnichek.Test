using System;
namespace Task1.Solution
{
    public class ShortPassRule : IRules
    {
        public void Validate(string password)
        {
            if (password.Length <= 7)
                throw new ArgumentException($"{password} length too short");
        }
    }
}

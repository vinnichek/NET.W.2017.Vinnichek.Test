using System;
namespace Task1.Solution
{
    public class EmptyPassRule : IRules
    {
        public void Validate(string password)
        {
            if (password == string.Empty)
                throw new ArgumentException($"{password} is empty");
        }
    }
}

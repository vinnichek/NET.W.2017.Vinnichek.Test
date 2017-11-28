using System;
namespace Task1.Solution
{
    public class ShortPassRule : IRules
    {
        public Tuple<bool, string> Validate(string password)
        {
            if (password.Length <= 7)
                return Tuple.Create(false, $"{password} length too short");
            else
                return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
}

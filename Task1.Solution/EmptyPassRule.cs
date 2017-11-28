using System;
namespace Task1.Solution
{
    public class EmptyPassRule : IRules
    {
        public Tuple<bool, string> Validate(string password)
        {
            if (password == string.Empty)
                return Tuple.Create(false, $"{password} is empty ");
            else
                return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
}

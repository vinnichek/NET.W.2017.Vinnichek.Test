using System;
namespace Task1.Solution
{
    public interface IRules
    {
        Tuple<bool, string> Validate(string password); 
    }
}

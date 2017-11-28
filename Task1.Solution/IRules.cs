using System;
namespace Task1.Solution
{
    public interface IRule
    {
        Tuple<bool, string> Validate(string password);
    }
}

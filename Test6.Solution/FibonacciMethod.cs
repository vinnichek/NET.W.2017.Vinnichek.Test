using System;
namespace Test6.Solution
{
    public class FibonacciMethod : IMethod<int>
    {
        public int CalculateNextNumber(int current, int previous) => current + previous;
    }
}

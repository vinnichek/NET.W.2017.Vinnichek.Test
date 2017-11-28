using System;
namespace Test6.Solution
{
    public class FirstMethod : IMethod<int>
    {
        public int CalculateNextNumber(int current, int previous) => 6 * current - 8 * previous;
    }
}

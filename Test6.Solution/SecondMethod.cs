using System;
namespace Test6.Solution
{
    public class SecondMethod : IMethod<double>
    {
        public double CalculateNextNumber(double current, double previous) => current + previous / current;
    }
}

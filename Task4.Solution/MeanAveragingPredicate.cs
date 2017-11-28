using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4.Solution
{
    public class MeanAveragingPredicate : IPredicate
    {
        public double Calculate(List<double> values)
        {
            return values.Sum() / values.Count;
        }
    }
}

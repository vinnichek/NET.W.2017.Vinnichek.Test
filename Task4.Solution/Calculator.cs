using System;
using System.Collections.Generic;

namespace Task4.Solution
{
    public class Calculator
    {
        public double CalculateAverage(List<double> values, IPredicate predicate)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return predicate.Calculate(values);
        }
    }
}

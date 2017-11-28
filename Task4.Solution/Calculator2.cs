using System;
using System.Collections.Generic;

namespace Task4.Solution
{
    public class EmptyClass
    {
        public double CalculateAverage(List<double> values, Func<List<double>, double> criteria)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return criteria(values);
        }
    }
}

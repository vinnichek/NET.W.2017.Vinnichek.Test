using System;
using System.Collections.Generic;

namespace Task4.Solution
{
    public interface IPredicate
    {
        double Calculate(List<double> values);
    }
}

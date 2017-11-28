using System;
using System.Collections.Generic;
namespace Test6.Solution
{
    public class Generator
    {
        public static IEnumerable<T> GenerateSequence<T>(int count, T start, T next, IMethod<T> method)
        {
            if (ReferenceEquals(method, null))
                throw new ArgumentNullException(nameof(method));

            return Generate(count, start, next, method.CalculateNextNumber);
        }

        private static IEnumerable<T> Generate<T>(int count, T start, T next, Func<T, T, T> calc)
        {
            if (count == 0) 
                yield break;

            if (count >= 1) 
                yield return start;

            if (count >= 2) 
                yield return next;

            for (int i = 3; i < count; i++)
            {
                var temp = next;
                next = calc(next, start);
                yield return next;
                start = temp;
            }
        }
    }
}

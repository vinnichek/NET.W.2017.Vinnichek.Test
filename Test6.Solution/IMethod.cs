using System;
namespace Test6.Solution
{
    public interface IMethod<T>
    {
        T CalculateNextNumber(T current, T previous);
    }
}

using System;

namespace DateTimeIntervalsCalculations.Library
{
    public interface IInterval<T> where T : IComparable<T>
    {
        T Start { get; }
        T End { get; }

        bool Intersects(IInterval<T> other);
        bool Contains(IInterval<T> other);

        IInterval<T> Overlap(IInterval<T> other);
        IInterval<T>[] Substract(IInterval<T> other);
    }
}

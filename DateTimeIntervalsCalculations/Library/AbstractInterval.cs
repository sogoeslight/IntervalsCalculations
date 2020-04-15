using System;

namespace DateTimeIntervalsCalculations.Library
{
    public abstract class AbstractInterval<T> : IInterval<T> where T : IComparable<T>
    {
        public T Start { get; }

        public T End { get; }

        public AbstractInterval(T Start, T End)
        {
            this.Start = Start;
            this.End = End;
        }

        #region Operations

        public virtual bool Intersects(IInterval<T> other)
        {
            return Start.CompareTo(other.End) <= 0 && other.Start.CompareTo(End) <= 0;
        }

        public virtual bool Contains(IInterval<T> other)
        {
            return Start.CompareTo(other.Start) <= 0 && End.CompareTo(other.End) >= 0;
        }

        public virtual IInterval<T> Overlap(IInterval<T> other)
        {
            if (Intersects(other))
            {
                if (Start.CompareTo(other.Start) <= 0)
                {
                    if (End.CompareTo(other.End) <= 0)
                    {
                        return Construct(other.Start, End);
                    }
                    else
                    {
                        return Construct(other.Start, other.End);
                    }
                }
                else
                {
                    if (End.CompareTo(other.End) <= 0)
                    {
                        return Construct(Start, End);
                    }
                    else
                    {
                        return Construct(Start, other.End);
                    }
                }
            }
            else
            {
                return null;
            }
        }

        public virtual IInterval<T>[] Substract(IInterval<T> other)
        {
            if (Contains(other))
            {
                if (other.Start.CompareTo(other.End) == 0) // I assumed, that "no interval" still might be a valid input case
                {
                    return new IInterval<T>[] { this };
                }
                if (Start.CompareTo(other.Start) == 0 && End.CompareTo(other.End) == 0)
                {
                    return new IInterval<T>[0]; // if 2 intervals are same, then after substracting we got nothing
                }
                if (Start.CompareTo(other.Start) == 0)
                {
                    return new IInterval<T>[] { Construct(other.End, End) };
                }
                if (End.CompareTo(other.End) == 0)
                {
                    return new IInterval<T>[] { Construct(Start, other.Start) };
                }
                else
                {
                    return new IInterval<T>[]
                    {
                        Construct(Start, other.Start),
                        Construct(other.End, End)
                    };
                }
            }
            else if (other.Contains(this))
            {
                return new IInterval<T>[0]; // fully substracted by the "container"
            }
            else
            {
                if (this.Intersects(other))
                {
                    if (Start.CompareTo(other.Start) <= 0)
                    {
                        return new IInterval<T>[] { Construct(Start, other.Start) };
                    }
                    else
                    {
                        return new IInterval<T>[] { Construct(other.End, End) };
                    }
                }
                else
                {
                    return new IInterval<T>[] { this };
                }
            }
        }

        #endregion

        protected abstract IInterval<T> Construct(T start, T end);
    }
}

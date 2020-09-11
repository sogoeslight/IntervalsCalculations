using System;
using DateTimeIntervalsCalculations.Library;

namespace DateTimeIntervalsCalculations.Application
{
    public class DateTimeInterval : AbstractInterval<DateTime>
    {
        public DateTimeInterval(DateTime Start, DateTime End) : base(Start, End)
        {
        }

        protected override IInterval<DateTime> Construct(DateTime start, DateTime end)
        {
            return new DateTimeInterval(start, end);
        }

        public override bool Equals(Object obj) // No need in overriding Object.GetHashCode()
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) // Check for null and compare run-time types.
            {
                return false;
            }
            else
            {
                DateTimeInterval interval = (DateTimeInterval)obj;
                return (Start == interval.Start) && (End == interval.End);
            }
        }
    }

}
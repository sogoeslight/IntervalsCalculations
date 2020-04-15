using System.Collections;
using System.Collections.Generic;

namespace IntervalsCalculations.Tests
{
    class IntersectionTestData : DateTimeIntervalCreation, IEnumerable<object[]>
    {
        // All cases for interval 01.01.2015 01:01:01 - 01.01.2025 01:01:01
        public IEnumerator<object[]> GetEnumerator()
        {
            // Equal
            yield return new object[] { DateTimeInterval(2015, 2025), true };
            // No interval, outside of default
            yield return new object[] { DateTimeInterval(2010, 2010), false };
            // No interval, inside
            yield return new object[] { DateTimeInterval(2020, 2020), true };
            // Completely inside (contained by default one)
            yield return new object[] { DateTimeInterval(2017, 2023), true };
            // Default is contained by this one
            yield return new object[] { DateTimeInterval(2013, 2027), true };
            // Before default
            yield return new object[] { DateTimeInterval(2010, 2012), false };
            // After default
            yield return new object[] { DateTimeInterval(2028, 2030), false };
            // After start border default, inside, touch border
            yield return new object[] { DateTimeInterval(2015, 2017), true };
            // Before finish border, inside, touch border
            yield return new object[] { DateTimeInterval(2023, 2025), true };
            // Before default, touch border
            yield return new object[] { DateTimeInterval(2012, 2015), true };
            // After default touch border
            yield return new object[] { DateTimeInterval(2025, 2027), true };
            // Before and inside
            yield return new object[] { DateTimeInterval(2010, 2020), true };
            // After and inside
            yield return new object[] { DateTimeInterval(2020, 2030), true };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

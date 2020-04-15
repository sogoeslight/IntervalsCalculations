using System.Collections;
using System.Collections.Generic;

namespace IntervalsCalculations.Tests
{
    class OverlapTestData : DateTimeIntervalCreation, IEnumerable<object[]>
    {
        // All cases for interval 01.01.2015 01:01:01 - 01.01.2025 01:01:01
        public IEnumerator<object[]> GetEnumerator()
        {
            // Equal
            yield return new object[] { DateTimeInterval(2015, 2025), DateTimeInterval(2015, 2025) };
            // No interval, outside of default
            yield return new object[] { DateTimeInterval(2010, 2010), null };
            // No interval, inside
            yield return new object[] { DateTimeInterval(2020, 2020), DateTimeInterval(2020, 2020) };
            // Completely inside (contained by default one)
            yield return new object[] { DateTimeInterval(2017, 2023), DateTimeInterval(2017, 2023) };
            // Default is contained by this one
            yield return new object[] { DateTimeInterval(2013, 2027), DateTimeInterval(2015, 2025) };
            // Before default
            yield return new object[] { DateTimeInterval(2010, 2012), null };
            // After default
            yield return new object[] { DateTimeInterval(2028, 2030), null };
            // After start border default, inside, touch border
            yield return new object[] { DateTimeInterval(2015, 2017), DateTimeInterval(2015, 2017) };
            // Before finish border, inside, touch border
            yield return new object[] { DateTimeInterval(2023, 2025), DateTimeInterval(2023, 2025) };
            // Before default, touch border
            yield return new object[] { DateTimeInterval(2012, 2015), DateTimeInterval(2015, 2015) };
            // After default touch border
            yield return new object[] { DateTimeInterval(2025, 2027), DateTimeInterval(2025, 2025) };
            // Before and inside
            yield return new object[] { DateTimeInterval(2010, 2020), DateTimeInterval(2015, 2020) };
            // After and inside
            yield return new object[] { DateTimeInterval(2020, 2030), DateTimeInterval(2020, 2025) };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

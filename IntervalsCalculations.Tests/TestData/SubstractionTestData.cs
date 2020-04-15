using DateTimeIntervalsCalculations.Application;
using System.Collections;
using System.Collections.Generic;

namespace IntervalsCalculations.Tests
{
    class SubstractionTestData : DateTimeIntervalCreation, IEnumerable<object[]>
    {
        /// <summary>
        /// All cases for interval 01.01.2015 01:01:01 - 01.01.2025 01:01:01
        /// </summary>
        public IEnumerator<object[]> GetEnumerator()
        {
            // Equal
            yield return new object[] { DateTimeInterval(2015, 2025), new DateTimeInterval[0] };
            // No interval, outside of default
            yield return new object[] { DateTimeInterval(2010, 2010), new DateTimeInterval[] { DateTimeInterval(2015, 2025) } };
            // No interval, inside
            yield return new object[] { DateTimeInterval(2020, 2020), new DateTimeInterval[] { DateTimeInterval(2015, 2025) } };
            // Completely inside (contained by default one)
            yield return new object[] { DateTimeInterval(2017, 2023), new DateTimeInterval[] { DateTimeInterval(2015, 2017), DateTimeInterval(2023, 2025) } };
            // Default is contained by this one
            yield return new object[] { DateTimeInterval(2013, 2027), new DateTimeInterval[0] };
            // Before default
            yield return new object[] { DateTimeInterval(2010, 2012), new DateTimeInterval[] { DateTimeInterval(2015, 2025) } };
            // After default
            yield return new object[] { DateTimeInterval(2028, 2030), new DateTimeInterval[] { DateTimeInterval(2015, 2025) } };
            // After start border default, inside, touch border
            yield return new object[] { DateTimeInterval(2015, 2017), new DateTimeInterval[] { DateTimeInterval(2017, 2025) } };
            // Before finish border, inside, touch border
            yield return new object[] { DateTimeInterval(2023, 2025), new DateTimeInterval[] { DateTimeInterval(2015, 2023) } };
            // Before default, touch border
            yield return new object[] { DateTimeInterval(2012, 2015), new DateTimeInterval[] { DateTimeInterval(2015, 2025) } };
            // After default touch border
            yield return new object[] { DateTimeInterval(2025, 2027), new DateTimeInterval[] { DateTimeInterval(2015, 2025) } };
            // Before and inside
            yield return new object[] { DateTimeInterval(2010, 2020), new DateTimeInterval[] { DateTimeInterval(2020, 2025) } };
            // After and inside
            yield return new object[] { DateTimeInterval(2020, 2030), new DateTimeInterval[] { DateTimeInterval(2015, 2020) } };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

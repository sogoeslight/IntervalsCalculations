using System.Collections;
using System.Collections.Generic;

namespace IntervalsCalculations.Tests
{
    class IntegrationTestData : DateTimeIntervalCreation, IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "{}" };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
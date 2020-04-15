using DateTimeIntervalsCalculations.Application;
using System;
using System.Collections.Generic;
using Xunit;

namespace IntervalsCalculations.Tests
{
    public class DateTimeIntervalOperationsShould : DateTimeIntervalCreation
    {
        /// <summary>
        /// I had to implement this crutch, because when we return "object" it is always true,
        /// no matter what is inside, except for null, so we can test it like that
        /// </summary>
        public string boolStringTrue = "True";

        public List<object> boolObjectList = new List<object>() { true, true };

        public DateTimeInterval defaultInterval = DateTimeInterval(2015, 2025);

        private DateTimeIntervalService service = new DateTimeIntervalService();

        [Theory]
        [ClassData(typeof(IntersectionTestData))]
        public void Intersects(DateTimeInterval dti, bool expectedResult)
        {
            Assert.Equal(expectedResult, defaultInterval.Intersects(dti));
        }

        [Theory]
        [ClassData(typeof(ContainmentTestData))]
        public void Contains(DateTimeInterval dti, bool expectedResult)
        {
            Assert.Equal(expectedResult, defaultInterval.Contains(dti));
        }

        [Theory]
        [ClassData(typeof(OverlapTestData))]
        public void Overlaps(DateTimeInterval dti, DateTimeInterval expectedResult)
        {
            Assert.Equal(expectedResult, defaultInterval.Overlap(dti));
        }

        [Theory]
        [ClassData(typeof(SubstractionTestData))]
        public void Substracts(DateTimeInterval dti, DateTimeInterval[] expectedResult)
        {
            Assert.Equal(expectedResult, defaultInterval.Substract(dti));
        }
    }
}

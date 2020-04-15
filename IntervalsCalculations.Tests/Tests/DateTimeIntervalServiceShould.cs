using DateTimeIntervalsCalculations.Application;
using System.Collections.Generic;
using Xunit;

namespace IntervalsCalculations.Tests
{
    public class DateTimeIntervalServiceShould : DateTimeIntervalCreation
    {
        /// <summary>
        /// I had to implement this crutch, because when we return "object" it is always true,
        /// no matter what is inside, except for null, so we can test it like that
        /// </summary>
        public string isTrue = "True";

        public List<object> allTrue = new List<object>() { true, true };

        private DateTimeIntervalService service = new DateTimeIntervalService();

        [Fact]
        public void IntersectsCorrectly()
        {
            var first = DateTimeInterval(2010, 2020);
            var second = DateTimeInterval(2015, 2025);
            var operation = Operations.INTERSECTION;

            var result = service.PerformOperation(first, second, operation);

            Assert.Equal(isTrue, result.ToString());
        }

        [Fact]
        public void ContainsCorrectly()
        {
            var first = DateTimeInterval(2010, 2025);
            var second = DateTimeInterval(2015, 2020);
            var operation = Operations.CONTAINMENT;

            var result = service.PerformOperation(first, second, operation);

            Assert.Equal(isTrue, result.ToString());
        }

        [Fact]
        public void OverlapCorrectly()
        {
            var first = DateTimeInterval(2010, 2020);
            var second = DateTimeInterval(2015, 2025);
            var operation = Operations.OVERLAP;

            var result = service.PerformOperation(first, second, operation);

            var expectedResult = DateTimeInterval(2015, 2020);
            Assert.True(expectedResult.Equals(result));
        }

        [Fact]
        public void SubstractCorrectly()
        {
            var first = DateTimeInterval(2010, 2020);
            var second = DateTimeInterval(2015, 2025);
            var operation = Operations.SUBSTRACTION;

            var result = service.PerformOperation(first, second, operation);

            var expectedResult = new List<DateTimeInterval> { DateTimeInterval(2010, 2015) };
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ListIntersectsCorrectly()
        {
            var first = new List<DateTimeInterval>{ DateTimeInterval(2010, 2020), DateTimeInterval(2015, 2025) };
            var second = new List<DateTimeInterval>{ DateTimeInterval(2012, 2022), DateTimeInterval(2010, 2020) };
            var operation = Operations.INTERSECTION;

            var result = service.PerformListOperation(first, second, operation);

            Assert.Equal(allTrue, result);
        }

        [Fact]
        public void ListContainsCorrectly()
        {
            var first = new List<DateTimeInterval>{DateTimeInterval(2010, 2020), DateTimeInterval(2015, 2025) };
            var second = new List<DateTimeInterval>{ DateTimeInterval(2012, 2018), DateTimeInterval(2017, 2023) };
            var operation = Operations.CONTAINMENT;

            var result = service.PerformListOperation(first, second, operation);

            Assert.Equal(allTrue, result);
        }

        [Fact]
        public void ListOverlapsCorrectly()
        {
            var first = new List<DateTimeInterval>{ DateTimeInterval(2010, 2020), DateTimeInterval(2015, 2025) };
            var second = new List<DateTimeInterval>{DateTimeInterval(2012, 2022), DateTimeInterval(2017, 2025) };
            var operation = Operations.OVERLAP;

            var result = service.PerformListOperation(first, second, operation);
            var expectedResult = new List<DateTimeInterval> { DateTimeInterval(2012, 2020), DateTimeInterval(2017, 2025) };

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ListSubstractCorrectly()
        {
            var first = new List<DateTimeInterval> { DateTimeInterval(2010, 2020), DateTimeInterval(2015, 2025) };
            var second = new List<DateTimeInterval> { DateTimeInterval(2012, 2022), DateTimeInterval(2017, 2027) };
            var operation = Operations.SUBSTRACTION;

            var result = service.PerformListOperation(first, second, operation);

            var expectedResult = new List<DateTimeInterval[]>
            {
                new DateTimeInterval[] { DateTimeInterval(2010, 2012) },
                new DateTimeInterval[] { DateTimeInterval(2015, 2017) }
            };

            Assert.Equal(expectedResult, result);
        }

    }
}

using DateTimeIntervalsCalculations.Application;
using System;
using System.Collections.Generic;

namespace IntervalsCalculations.Tests
{
    public class DateTimeIntervalCreation
    {
        protected static DateTimeInterval DateTimeInterval(int startYear, int endYear)
        {
            return new DateTimeInterval(DateTime(startYear), DateTime(endYear));
        }

        protected static DateTime DateTime(int year)
        {
            return new DateTime(year, 1, 1, 1, 1, 1);
        }
    }
}

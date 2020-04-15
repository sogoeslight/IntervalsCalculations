using System;
using System.Collections.Generic;
using System.Linq;

namespace DateTimeIntervalsCalculations.Application
{
    public class DateTimeIntervalService
    {
        public object PerformOperation(DateTimeInterval first, DateTimeInterval second, Operations operation)
        {
            return operation switch
            {
                Operations.INTERSECTION => first.Intersects(second),
                Operations.CONTAINMENT => first.Contains(second),
                Operations.OVERLAP => first.Overlap(second),
                Operations.SUBSTRACTION => first.Substract(second),
                _ => null,
            };
        }

        /// <summary>
        /// For this operations due to lack of documentation, I assumed
        /// that we will compare/operate by pairs, taken from both lists
        /// </summary>
        public List<object> PerformListOperation(List<DateTimeInterval> first, List<DateTimeInterval> second, Operations operation)
        {
            return operation switch
            {
                Operations.INTERSECTION => OperateLists(first, second, (dti1, dti2) => dti1.Intersects(dti2)),
                Operations.CONTAINMENT => OperateLists(first, second, (dti1, dti2) => dti1.Contains(dti2)),
                Operations.OVERLAP => OperateLists(first, second, (dti1, dti2) => dti1.Overlap(dti2)),
                Operations.SUBSTRACTION => OperateLists(first, second, (dti1, dti2) => dti1.Substract(dti2)),
                _ => null,
            };
        }

        private List<object> OperateLists(List<DateTimeInterval> first, List<DateTimeInterval> second,
                                     Func<DateTimeInterval, DateTimeInterval, object> lambda)
        {
            var result = new List<object>();
            for (int i = 0; i < first.Count(); i++)
            {
                result.Add(lambda(first[i], second[i]));
            }
            return result;
        }
    }
}
using System.Collections.Generic;

namespace DateTimeIntervalsCalculations.Application
{
    public class OperationRequest
    {
        public DateTimeInterval first;
        public DateTimeInterval second;
        public Operations operation;

        public OperationRequest(DateTimeInterval first, DateTimeInterval second, Operations operation)
        {
            this.first = first;
            this.second = second;
            this.operation = operation;
        }
    }

    public class ListOperationRequest
    {
        public List<DateTimeInterval> first;
        public List<DateTimeInterval> second;
        public Operations operation;

        public ListOperationRequest(List<DateTimeInterval> first, List<DateTimeInterval> second, Operations operation)
        {
            this.first = first;
            this.second = second;
            this.operation = operation;
        }
    }
}
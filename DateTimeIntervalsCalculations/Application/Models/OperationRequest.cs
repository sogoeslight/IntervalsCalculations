using System.Collections.Generic;

namespace DateTimeIntervalsCalculations.Application
{
    public class OperationRequest
    {
        public DateTimeInterval First { get; }
        public DateTimeInterval Second { get; }
        public Operations Operation { get; }

        public OperationRequest(DateTimeInterval first, DateTimeInterval second, Operations operation)
        {
            this.First = first;
            this.Second = second;
            this.Operation = operation;
        }
    }

    public class ListOperationRequest
    {
        public List<DateTimeInterval> First { get; }
        public List<DateTimeInterval> Second { get; }
        public Operations Operation { get;}

        public ListOperationRequest(List<DateTimeInterval> first, List<DateTimeInterval> second, Operations operation)
        {
            this.First = first;
            this.Second = second;
            this.Operation = operation;
        }
    }
}
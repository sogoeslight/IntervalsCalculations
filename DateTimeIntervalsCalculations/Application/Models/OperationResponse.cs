using System.Collections.Generic;

namespace DateTimeIntervalsCalculations.Application
{
    /// <summary>
    /// In our case returns bool or DateTimeInterval
    /// </summary>
    public class OperationResponse
    {
        public object result;
        public OperationResponse(object result)
        {
            this.result = result;
        }
    }

    /// <summary>
    /// In our case returns List<Bool> or List<DateTimeInterval>
    /// </summary>
    public class ListOperationResponse
    {
        public List<object> result { get; set; }
        public ListOperationResponse(List<object> result)
        {
            this.result = result;
        }
    }
}
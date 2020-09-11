using System.Collections.Generic;

namespace DateTimeIntervalsCalculations.Application
{
    /// <summary>
    /// In our case returns bool or DateTimeInterval
    /// </summary>
    public class OperationResponse
    {
        public object Result { get; set; }
        public OperationResponse(object result)
        {
            this.Result = result;
        }
    }

    /// <summary>
    /// In our case returns List<Bool> or List<DateTimeInterval>
    /// </summary>
    public class ListOperationResponse
    {
        public List<object> Result { get; set; }
        public ListOperationResponse(List<object> result)
        {
            this.Result = result;
        }
    }
}
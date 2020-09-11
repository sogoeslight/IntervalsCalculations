using System;

namespace DateTimeIntervalsCalculations.Application
{
    public class ValidationService
    {
        public bool ValidateDateTimeIntervals(OperationRequest request)
        {
            if (request.First.Start.CompareTo(request.First.End) > 0 
                || request.Second.Start.CompareTo(request.Second.End) > 0)
            {
                throw new Exception("First number should not be greater than second");
            }

            return true;
        }

        public bool ValidateListLengths(ListOperationRequest request)
        {
            for (int i = 0; i < request.First.Count; i++)
            {
                if (request.First[i].Start.CompareTo(request.First[i].End) > 0
                    || request.First[i].Start.CompareTo(request.First[i].End) > 0
                    || request.Second[i].Start.CompareTo(request.Second[i].End) > 0
                    || request.Second[i].Start.CompareTo(request.Second[i].End) > 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

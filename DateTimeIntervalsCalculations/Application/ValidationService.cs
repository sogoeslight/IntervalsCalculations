using System;

namespace DateTimeIntervalsCalculations.Application
{
    public class ValidationService
    {
        public bool ValidateDateTimeIntervals(OperationRequest request)
        {
            if (request.first.Start.CompareTo(request.first.End) > 0 
                || request.second.Start.CompareTo(request.second.End) > 0)
            {
                throw new Exception("First number should not be greater than second");
            }

            return true;
        }

        public bool ValidateListLengths(ListOperationRequest request)
        {
            for (int i = 0; i < request.first.Count; i++)
            {
                if (request.first[i].Start.CompareTo(request.first[i].End) > 0
                    || request.first[i].Start.CompareTo(request.first[i].End) > 0
                    || request.second[i].Start.CompareTo(request.second[i].End) > 0
                    || request.second[i].Start.CompareTo(request.second[i].End) > 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;

namespace DateTimeIntervalsCalculations.Application
{
    [Route("api")]
    [ApiController]
    [Produces("application/json")]
    public class DateTimeIntervalController : Controller
    {
        private DateTimeIntervalService _dtiService;
        private ValidationService _validationService;

        public DateTimeIntervalController(DateTimeIntervalService _dtiService, ValidationService _validationService)
        {
            this._dtiService = _dtiService;
            this._validationService = _validationService;
        }
        
        [HttpPost]
        [Route("ops")]
        public ActionResult PerformOperation([FromBody] OperationRequest request)
        {
            if (_validationService.ValidateDateTimeIntervals(request)) // TO DO: normal exception handling
            {
                var result = _dtiService.PerformOperation(request.first, request.second, request.operation);
                return Ok(new OperationResponse(result));
            }
            else
            {
                return BadRequest("Interval start can not be greater than interval end");
            }
        }

        [HttpPost]
        [Route("listOps")]
        public ActionResult PerformListOperation([FromBody]ListOperationRequest request)
        {
            try
            {
                if (_validationService.ValidateListLengths(request))
                {
                    var result = _dtiService.PerformListOperation(request.first, request.second, request.operation);
                    return Ok(new ListOperationResponse(result));
                }
                else
                {
                    return BadRequest("Interval start can not be greater than interval end");
                }
            }
            catch(Exception ex)
            {
                if (request.first.Count != request.second.Count)
                {
                    return StatusCode(400, "Interval lists must have same length");
                }
                throw new Exception(ex.ToString());
            }
        }

    }
}
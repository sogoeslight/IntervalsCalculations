using DateTimeIntervalsCalculations.Application;
using System.Collections.Generic;
using Xunit;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;

namespace IntervalsCalculations.Tests
{
    public class ControllerIntegrationTests
    {
        // private static DateTimeIntervalService _dtiService;
        // private static ValidationService _validationService;
        // private DateTimeIntervalController dtiController = new DateTimeIntervalController(_dtiService, _validationService);

        // Status Code 

        // TO DO: finish integration tests

        //[Theory]
        //[ClassData(typeof(IntegrationTestData))]
        //public void PerformOperationReturnedStatusCode(DateTimeInterval first, DateTimeInterval second, Operations operation)
        //{
        //    OperationRequest request = new OperationRequest(first, second, operation);
        //    var responseCode = dtiController.PerformOperation(request);

        //    Assert.IsType<BadRequestResult>(responseCode);
        //}

        //[Theory]
        //[ClassData(typeof(IntegrationTestData))]
        //public void PerformListOperationReturnedStatusCode(List<DateTimeInterval> first, List<DateTimeInterval> second, Operations operation)
        //{
        //    ListOperationRequest request = new ListOperationRequest(first, second, operation);
        //    var responseCode = dtiController.PerformListOperation(request);

        //    Assert.IsType<BadRequestResult>((ObjectResult)responseCode);
        //}

        // JSon

        //[Theory]
        //[ClassData(typeof(IntegrationTestData))]
        //public void PerformOperationReturnedJson(string expectedJson, OperationRequest request)
        //{
        //    var response = _dtiService.PerformOperation(request.first, request.second, request.operation);

        //    Assert.Equal(expectedJson, response);
        //}

        //[Theory]
        //[ClassData(typeof(IntegrationTestData))]
        //public void PerformListOperationReturnedJson(List<string> expectedJson, ListOperationRequest request)
        //{
        //    var response = _dtiService.PerformListOperation(request.first, request.second, request.operation);

        //    Assert.Equal(expectedJson, response);
        //}
    }
}

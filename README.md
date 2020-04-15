# IntervalsCalculations

## ASP.NET Core library with REST-based webservice, which provides some basic datetime interval calculations.

## Provides next operations: (in code)
* Intersection (INTERSECTION)
* Containment (CONTAINMENT)
* Overlap (OVERLAP)
* Subsctraction (SUBSTRACTION)
.. of 2 intervals or 2 lists of intervals, pair-by-pair.

### This web service can be tested by existing unit tests or manually, for example with Postman
### Examples of requests:
POST request to the
https://localhost:[port]/api/ops
{
    "first": {
        "Start": "2015-02-25T15:30:30",
        "End": "2025-02-25T15:30:30"
    },
    "second": {
        "Start": "2015-02-25T15:30:30",
        "End": "2023-02-25T15:30:30"
    },
    "operation": "SUBSTRACTION"
}

POST request to the
https://localhost:[port]/api/listOps
{
    "first": [
        {
            "Start": "2010-02-25T15:30:30",
            "End": "2020-02-25T19:30:30"
        },
        {
            "Start": "2015-02-25T17:30:30",
            "End": "2025-02-25T12:30:30"
        }
    ],
    "second": [
        {
            "Start": "2012-04-27T15:30:30",
            "End": "2022-02-25T19:30:30"
        },
        {
            "Start": "2017-04-27T17:30:30",
            "End": "2027-02-25T12:30:30"
        }
    ],
    "operation": "OVERLAP"
}

### Things could be improved/finished:
* Adequate exception handling
* Integration tests
* Logging
* Security
* ...

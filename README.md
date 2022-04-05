# Project name
project-api

# Description
Automated API tests for the CRUD operations in https://reqres.in

# Technologies that are used and run the tests
- IDE: Visual Studio
- Software language: C#
- Rest API library: RestSharp version: 105.2.3: To send objects as the request body in JSON
- Testing framework: NUnit version: 3.12.0: To create and run the tests
- NewtonSoft Json.NET version: 13.0.1: To serialize and deserialize JSON.
- Operating system: 
- MacOS 64 bit version: 12.0.1
- CPU: Intel Core i5
- https://json2csharp.com/ is used for converting from json to C#

# Tests
Where are the tests created?
- Tests are created in APITest project:
- PayloadTests.cs
- StatusCodeTests.cs

# Solution details
- CrudOperations.cs - Class for the Get/PUT/POST/DELETE operations
- APIHelper.cs - Class to manage RestSharp library
- PayLoadTests.cs - Test class to check the operations
- StatusCodeTests.cs - Test class to check the status of the operations


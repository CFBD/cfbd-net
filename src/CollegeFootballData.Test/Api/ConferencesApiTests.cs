/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.7.0
 * Contact: admin@collegefootballdata.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using CollegeFootballData.Api;
using CollegeFootballData.Model;


/* *********************************************************************************
*              Follow these manual steps to construct tests.
*              This file will not be overwritten.
*  *********************************************************************************
* 1. Navigate to ApiTests.Base.cs and ensure any tokens are being created correctly.
*    Take care not to commit credentials to any repository.
*
* 2. Mocking is coordinated by ApiTestsBase#AddApiHttpClients.
*    To mock the client, use the generic AddApiHttpClients.
*    To mock the server, change the client's BaseAddress.
*
* 3. Locate the test you want below
*      - remove the skip property from the Fact attribute
*      - set the value of any variables if necessary
*
* 4. Run the tests and ensure they work.
*
*/


namespace CollegeFootballData.Test.Api
{
    /// <summary>
    ///  Class for testing ConferencesApi
    /// </summary>
    public sealed class ConferencesApiTests : ApiTestsBase
    {
        private readonly IConferencesApi _instance;

        public ConferencesApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IConferencesApi>();
        }

        /// <summary>
        /// Test GetConferences
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetConferencesAsyncTest()
        {
            var response = await _instance.GetConferencesAsync();
            var model = response.Ok();
            Assert.IsType<List<Conference>>(model);
        }
    }
}

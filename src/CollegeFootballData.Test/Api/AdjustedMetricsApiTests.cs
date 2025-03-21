/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.6.8
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
    ///  Class for testing AdjustedMetricsApi
    /// </summary>
    public sealed class AdjustedMetricsApiTests : ApiTestsBase
    {
        private readonly IAdjustedMetricsApi _instance;

        public AdjustedMetricsApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IAdjustedMetricsApi>();
        }

        /// <summary>
        /// Test GetAdjustedPlayerPassingStats
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetAdjustedPlayerPassingStatsAsyncTest()
        {
            Client.Option<int> year = default!;
            Client.Option<string> team = default!;
            Client.Option<string> conference = default!;
            Client.Option<string> position = default!;
            var response = await _instance.GetAdjustedPlayerPassingStatsAsync(year, team, conference, position);
            var model = response.Ok();
            Assert.IsType<List<PlayerWeightedEPA>>(model);
        }

        /// <summary>
        /// Test GetAdjustedPlayerRushingStats
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetAdjustedPlayerRushingStatsAsyncTest()
        {
            Client.Option<int> year = default!;
            Client.Option<string> team = default!;
            Client.Option<string> conference = default!;
            Client.Option<string> position = default!;
            var response = await _instance.GetAdjustedPlayerRushingStatsAsync(year, team, conference, position);
            var model = response.Ok();
            Assert.IsType<List<PlayerWeightedEPA>>(model);
        }

        /// <summary>
        /// Test GetAdjustedTeamSeasonStats
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetAdjustedTeamSeasonStatsAsyncTest()
        {
            Client.Option<int> year = default!;
            Client.Option<string> team = default!;
            Client.Option<string> conference = default!;
            var response = await _instance.GetAdjustedTeamSeasonStatsAsync(year, team, conference);
            var model = response.Ok();
            Assert.IsType<List<AdjustedTeamMetrics>>(model);
        }

        /// <summary>
        /// Test GetKickerPaar
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetKickerPaarAsyncTest()
        {
            Client.Option<int> year = default!;
            Client.Option<string> team = default!;
            Client.Option<string> conference = default!;
            var response = await _instance.GetKickerPaarAsync(year, team, conference);
            var model = response.Ok();
            Assert.IsType<List<KickerPAAR>>(model);
        }
    }
}

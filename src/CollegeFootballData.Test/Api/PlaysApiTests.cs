/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.6.9
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
    ///  Class for testing PlaysApi
    /// </summary>
    public sealed class PlaysApiTests : ApiTestsBase
    {
        private readonly IPlaysApi _instance;

        public PlaysApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IPlaysApi>();
        }

        /// <summary>
        /// Test GetLivePlays
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetLivePlaysAsyncTest()
        {
            int gameId = default!;
            var response = await _instance.GetLivePlaysAsync(gameId);
            var model = response.Ok();
            Assert.IsType<LiveGame>(model);
        }

        /// <summary>
        /// Test GetPlayStatTypes
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetPlayStatTypesAsyncTest()
        {
            var response = await _instance.GetPlayStatTypesAsync();
            var model = response.Ok();
            Assert.IsType<List<PlayStatType>>(model);
        }

        /// <summary>
        /// Test GetPlayStats
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetPlayStatsAsyncTest()
        {
            Client.Option<int> year = default!;
            Client.Option<int> week = default!;
            Client.Option<string> team = default!;
            Client.Option<int> gameId = default!;
            Client.Option<int> athleteId = default!;
            Client.Option<int> statTypeId = default!;
            Client.Option<SeasonType> seasonType = default!;
            Client.Option<string> conference = default!;
            var response = await _instance.GetPlayStatsAsync(year, week, team, gameId, athleteId, statTypeId, seasonType, conference);
            var model = response.Ok();
            Assert.IsType<List<PlayStat>>(model);
        }

        /// <summary>
        /// Test GetPlayTypes
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetPlayTypesAsyncTest()
        {
            var response = await _instance.GetPlayTypesAsync();
            var model = response.Ok();
            Assert.IsType<List<PlayType>>(model);
        }

        /// <summary>
        /// Test GetPlays
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetPlaysAsyncTest()
        {
            int year = default!;
            int week = default!;
            Client.Option<string> team = default!;
            Client.Option<string> offense = default!;
            Client.Option<string> defense = default!;
            Client.Option<string> offenseConference = default!;
            Client.Option<string> defenseConference = default!;
            Client.Option<string> conference = default!;
            Client.Option<string> playType = default!;
            Client.Option<SeasonType> seasonType = default!;
            Client.Option<DivisionClassification> classification = default!;
            var response = await _instance.GetPlaysAsync(year, week, team, offense, defense, offenseConference, defenseConference, conference, playType, seasonType, classification);
            var model = response.Ok();
            Assert.IsType<List<Play>>(model);
        }
    }
}

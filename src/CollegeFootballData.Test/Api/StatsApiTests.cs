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
    ///  Class for testing StatsApi
    /// </summary>
    public sealed class StatsApiTests : ApiTestsBase
    {
        private readonly IStatsApi _instance;

        public StatsApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IStatsApi>();
        }

        /// <summary>
        /// Test GetAdvancedGameStats
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetAdvancedGameStatsAsyncTest()
        {
            Client.Option<int> year = default!;
            Client.Option<string> team = default!;
            Client.Option<double> week = default!;
            Client.Option<string> opponent = default!;
            Client.Option<bool> excludeGarbageTime = default!;
            Client.Option<SeasonType> seasonType = default!;
            var response = await _instance.GetAdvancedGameStatsAsync(year, team, week, opponent, excludeGarbageTime, seasonType);
            var model = response.Ok();
            Assert.IsType<List<AdvancedGameStat>>(model);
        }

        /// <summary>
        /// Test GetAdvancedSeasonStats
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetAdvancedSeasonStatsAsyncTest()
        {
            Client.Option<int> year = default!;
            Client.Option<string> team = default!;
            Client.Option<bool> excludeGarbageTime = default!;
            Client.Option<int> startWeek = default!;
            Client.Option<int> endWeek = default!;
            var response = await _instance.GetAdvancedSeasonStatsAsync(year, team, excludeGarbageTime, startWeek, endWeek);
            var model = response.Ok();
            Assert.IsType<List<AdvancedSeasonStat>>(model);
        }

        /// <summary>
        /// Test GetCategories
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetCategoriesAsyncTest()
        {
            var response = await _instance.GetCategoriesAsync();
            var model = response.Ok();
            Assert.IsType<List<string>>(model);
        }

        /// <summary>
        /// Test GetPlayerSeasonStats
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetPlayerSeasonStatsAsyncTest()
        {
            int year = default!;
            Client.Option<string> conference = default!;
            Client.Option<string> team = default!;
            Client.Option<int> startWeek = default!;
            Client.Option<int> endWeek = default!;
            Client.Option<SeasonType> seasonType = default!;
            Client.Option<string> category = default!;
            var response = await _instance.GetPlayerSeasonStatsAsync(year, conference, team, startWeek, endWeek, seasonType, category);
            var model = response.Ok();
            Assert.IsType<List<PlayerStat>>(model);
        }

        /// <summary>
        /// Test GetTeamStats
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetTeamStatsAsyncTest()
        {
            Client.Option<int> year = default!;
            Client.Option<string> team = default!;
            Client.Option<string> conference = default!;
            Client.Option<int> startWeek = default!;
            Client.Option<int> endWeek = default!;
            var response = await _instance.GetTeamStatsAsync(year, team, conference, startWeek, endWeek);
            var model = response.Ok();
            Assert.IsType<List<TeamStat>>(model);
        }
    }
}

/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.6.7
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
    ///  Class for testing MetricsApi
    /// </summary>
    public sealed class MetricsApiTests : ApiTestsBase
    {
        private readonly IMetricsApi _instance;

        public MetricsApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IMetricsApi>();
        }

        /// <summary>
        /// Test GetFieldGoalExpectedPoints
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetFieldGoalExpectedPointsAsyncTest()
        {
            var response = await _instance.GetFieldGoalExpectedPointsAsync();
            var model = response.Ok();
            Assert.IsType<List<FieldGoalEP>>(model);
        }

        /// <summary>
        /// Test GetPredictedPoints
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetPredictedPointsAsyncTest()
        {
            int down = default!;
            int distance = default!;
            var response = await _instance.GetPredictedPointsAsync(down, distance);
            var model = response.Ok();
            Assert.IsType<List<PredictedPointsValue>>(model);
        }

        /// <summary>
        /// Test GetPredictedPointsAddedByGame
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetPredictedPointsAddedByGameAsyncTest()
        {
            int year = default!;
            Client.Option<int> week = default!;
            Client.Option<SeasonType> seasonType = default!;
            Client.Option<string> team = default!;
            Client.Option<string> conference = default!;
            Client.Option<bool> excludeGarbageTime = default!;
            var response = await _instance.GetPredictedPointsAddedByGameAsync(year, week, seasonType, team, conference, excludeGarbageTime);
            var model = response.Ok();
            Assert.IsType<List<TeamGamePredictedPointsAdded>>(model);
        }

        /// <summary>
        /// Test GetPredictedPointsAddedByPlayerGame
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetPredictedPointsAddedByPlayerGameAsyncTest()
        {
            int year = default!;
            Client.Option<int> week = default!;
            Client.Option<SeasonType> seasonType = default!;
            Client.Option<string> team = default!;
            Client.Option<string> position = default!;
            Client.Option<string> playerId = default!;
            Client.Option<double> threshold = default!;
            Client.Option<bool> excludeGarbageTime = default!;
            var response = await _instance.GetPredictedPointsAddedByPlayerGameAsync(year, week, seasonType, team, position, playerId, threshold, excludeGarbageTime);
            var model = response.Ok();
            Assert.IsType<List<PlayerGamePredictedPointsAdded>>(model);
        }

        /// <summary>
        /// Test GetPredictedPointsAddedByPlayerSeason
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetPredictedPointsAddedByPlayerSeasonAsyncTest()
        {
            Client.Option<int> year = default!;
            Client.Option<string> conference = default!;
            Client.Option<string> team = default!;
            Client.Option<string> position = default!;
            Client.Option<string> playerId = default!;
            Client.Option<double> threshold = default!;
            Client.Option<bool> excludeGarbageTime = default!;
            var response = await _instance.GetPredictedPointsAddedByPlayerSeasonAsync(year, conference, team, position, playerId, threshold, excludeGarbageTime);
            var model = response.Ok();
            Assert.IsType<List<PlayerSeasonPredictedPointsAdded>>(model);
        }

        /// <summary>
        /// Test GetPredictedPointsAddedByTeam
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetPredictedPointsAddedByTeamAsyncTest()
        {
            Client.Option<int> year = default!;
            Client.Option<string> team = default!;
            Client.Option<string> conference = default!;
            Client.Option<bool> excludeGarbageTime = default!;
            var response = await _instance.GetPredictedPointsAddedByTeamAsync(year, team, conference, excludeGarbageTime);
            var model = response.Ok();
            Assert.IsType<List<TeamSeasonPredictedPointsAdded>>(model);
        }

        /// <summary>
        /// Test GetPregameWinProbabilities
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetPregameWinProbabilitiesAsyncTest()
        {
            Client.Option<int> year = default!;
            Client.Option<int> week = default!;
            Client.Option<SeasonType> seasonType = default!;
            Client.Option<string> team = default!;
            var response = await _instance.GetPregameWinProbabilitiesAsync(year, week, seasonType, team);
            var model = response.Ok();
            Assert.IsType<List<PregameWinProbability>>(model);
        }

        /// <summary>
        /// Test GetWinProbability
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetWinProbabilityAsyncTest()
        {
            int gameId = default!;
            var response = await _instance.GetWinProbabilityAsync(gameId);
            var model = response.Ok();
            Assert.IsType<List<PlayWinProbability>>(model);
        }
    }
}

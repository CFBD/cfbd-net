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
    ///  Class for testing GamesApi
    /// </summary>
    public sealed class GamesApiTests : ApiTestsBase
    {
        private readonly IGamesApi _instance;

        public GamesApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IGamesApi>();
        }

        /// <summary>
        /// Test GetAdvancedBoxScore
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetAdvancedBoxScoreAsyncTest()
        {
            int id = default!;
            var response = await _instance.GetAdvancedBoxScoreAsync(id);
            var model = response.Ok();
            Assert.IsType<AdvancedBoxScore>(model);
        }

        /// <summary>
        /// Test GetCalendar
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetCalendarAsyncTest()
        {
            int year = default!;
            var response = await _instance.GetCalendarAsync(year);
            var model = response.Ok();
            Assert.IsType<List<CalendarWeek>>(model);
        }

        /// <summary>
        /// Test GetGamePlayerStats
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetGamePlayerStatsAsyncTest()
        {
            Client.Option<int> year = default!;
            Client.Option<int> week = default!;
            Client.Option<string> team = default!;
            Client.Option<string> conference = default!;
            Client.Option<DivisionClassification> classification = default!;
            Client.Option<SeasonType> seasonType = default!;
            Client.Option<string> category = default!;
            Client.Option<int> id = default!;
            var response = await _instance.GetGamePlayerStatsAsync(year, week, team, conference, classification, seasonType, category, id);
            var model = response.Ok();
            Assert.IsType<List<GamePlayerStats>>(model);
        }

        /// <summary>
        /// Test GetGameTeamStats
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetGameTeamStatsAsyncTest()
        {
            Client.Option<int> year = default!;
            Client.Option<int> week = default!;
            Client.Option<string> team = default!;
            Client.Option<string> conference = default!;
            Client.Option<DivisionClassification> classification = default!;
            Client.Option<SeasonType> seasonType = default!;
            Client.Option<int> id = default!;
            var response = await _instance.GetGameTeamStatsAsync(year, week, team, conference, classification, seasonType, id);
            var model = response.Ok();
            Assert.IsType<List<GameTeamStats>>(model);
        }

        /// <summary>
        /// Test GetGames
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetGamesAsyncTest()
        {
            Client.Option<int> year = default!;
            Client.Option<int> week = default!;
            Client.Option<SeasonType> seasonType = default!;
            Client.Option<DivisionClassification> classification = default!;
            Client.Option<string> team = default!;
            Client.Option<string> home = default!;
            Client.Option<string> away = default!;
            Client.Option<string> conference = default!;
            Client.Option<int> id = default!;
            var response = await _instance.GetGamesAsync(year, week, seasonType, classification, team, home, away, conference, id);
            var model = response.Ok();
            Assert.IsType<List<Game>>(model);
        }

        /// <summary>
        /// Test GetMedia
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetMediaAsyncTest()
        {
            int year = default!;
            Client.Option<SeasonType> seasonType = default!;
            Client.Option<int> week = default!;
            Client.Option<string> team = default!;
            Client.Option<string> conference = default!;
            Client.Option<MediaType> mediaType = default!;
            Client.Option<DivisionClassification> classification = default!;
            var response = await _instance.GetMediaAsync(year, seasonType, week, team, conference, mediaType, classification);
            var model = response.Ok();
            Assert.IsType<List<GameMedia>>(model);
        }

        /// <summary>
        /// Test GetRecords
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetRecordsAsyncTest()
        {
            Client.Option<int> year = default!;
            Client.Option<string> team = default!;
            Client.Option<string> conference = default!;
            var response = await _instance.GetRecordsAsync(year, team, conference);
            var model = response.Ok();
            Assert.IsType<List<TeamRecords>>(model);
        }

        /// <summary>
        /// Test GetScoreboard
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetScoreboardAsyncTest()
        {
            Client.Option<DivisionClassification> classification = default!;
            Client.Option<string> conference = default!;
            var response = await _instance.GetScoreboardAsync(classification, conference);
            var model = response.Ok();
            Assert.IsType<List<ScoreboardGame>>(model);
        }

        /// <summary>
        /// Test GetWeather
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetWeatherAsyncTest()
        {
            Client.Option<int> year = default!;
            Client.Option<SeasonType> seasonType = default!;
            Client.Option<int> week = default!;
            Client.Option<string> team = default!;
            Client.Option<string> conference = default!;
            Client.Option<DivisionClassification> classification = default!;
            Client.Option<int> gameId = default!;
            var response = await _instance.GetWeatherAsync(year, seasonType, week, team, conference, classification, gameId);
            var model = response.Ok();
            Assert.IsType<List<GameWeather>>(model);
        }
    }
}

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
    ///  Class for testing TeamsApi
    /// </summary>
    public sealed class TeamsApiTests : ApiTestsBase
    {
        private readonly ITeamsApi _instance;

        public TeamsApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<ITeamsApi>();
        }

        /// <summary>
        /// Test GetFBSTeams
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetFBSTeamsAsyncTest()
        {
            Client.Option<int> year = default!;
            var response = await _instance.GetFBSTeamsAsync(year);
            var model = response.Ok();
            Assert.IsType<List<Team>>(model);
        }

        /// <summary>
        /// Test GetMatchup
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetMatchupAsyncTest()
        {
            string team1 = default!;
            string team2 = default!;
            Client.Option<int> minYear = default!;
            Client.Option<int> maxYear = default!;
            var response = await _instance.GetMatchupAsync(team1, team2, minYear, maxYear);
            var model = response.Ok();
            Assert.IsType<Matchup>(model);
        }

        /// <summary>
        /// Test GetRoster
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetRosterAsyncTest()
        {
            Client.Option<string> team = default!;
            Client.Option<int> year = default!;
            var response = await _instance.GetRosterAsync(team, year);
            var model = response.Ok();
            Assert.IsType<List<RosterPlayer>>(model);
        }

        /// <summary>
        /// Test GetTalent
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetTalentAsyncTest()
        {
            int year = default!;
            var response = await _instance.GetTalentAsync(year);
            var model = response.Ok();
            Assert.IsType<List<TeamTalent>>(model);
        }

        /// <summary>
        /// Test GetTeams
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetTeamsAsyncTest()
        {
            Client.Option<string> conference = default!;
            Client.Option<int> year = default!;
            var response = await _instance.GetTeamsAsync(conference, year);
            var model = response.Ok();
            Assert.IsType<List<Team>>(model);
        }
    }
}

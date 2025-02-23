/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.6.3
 * Contact: admin@collegefootballdata.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using CollegeFootballData.Client;
using CollegeFootballData.Api;
// uncomment below to import models
//using CollegeFootballData.Model;

namespace CollegeFootballData.Test.Api
{
    /// <summary>
    ///  Class for testing PlayersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PlayersApiTests : IDisposable
    {
        private PlayersApi instance;

        public PlayersApiTests()
        {
            instance = new PlayersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PlayersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PlayersApi
            //Assert.IsType<PlayersApi>(instance);
        }

        /// <summary>
        /// Test GetPlayerUsage
        /// </summary>
        [Fact]
        public void GetPlayerUsageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int year = null;
            //string? conference = null;
            //string? position = null;
            //string? team = null;
            //int? playerId = null;
            //bool? excludeGarbageTime = null;
            //var response = instance.GetPlayerUsage(year, conference, position, team, playerId, excludeGarbageTime);
            //Assert.IsType<List<PlayerUsage>>(response);
        }

        /// <summary>
        /// Test GetReturningProduction
        /// </summary>
        [Fact]
        public void GetReturningProductionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? year = null;
            //string? team = null;
            //string? conference = null;
            //var response = instance.GetReturningProduction(year, team, conference);
            //Assert.IsType<List<ReturningProduction>>(response);
        }

        /// <summary>
        /// Test GetTransferPortal
        /// </summary>
        [Fact]
        public void GetTransferPortalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int year = null;
            //var response = instance.GetTransferPortal(year);
            //Assert.IsType<List<PlayerTransfer>>(response);
        }

        /// <summary>
        /// Test SearchPlayers
        /// </summary>
        [Fact]
        public void SearchPlayersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string searchTerm = null;
            //int? year = null;
            //string? team = null;
            //string? position = null;
            //var response = instance.SearchPlayers(searchTerm, year, team, position);
            //Assert.IsType<List<PlayerSearchResult>>(response);
        }
    }
}

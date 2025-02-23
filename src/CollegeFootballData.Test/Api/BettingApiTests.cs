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
    ///  Class for testing BettingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BettingApiTests : IDisposable
    {
        private BettingApi instance;

        public BettingApiTests()
        {
            instance = new BettingApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BettingApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BettingApi
            //Assert.IsType<BettingApi>(instance);
        }

        /// <summary>
        /// Test GetLines
        /// </summary>
        [Fact]
        public void GetLinesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? gameId = null;
            //int? year = null;
            //SeasonType? seasonType = null;
            //int? week = null;
            //string? team = null;
            //string? home = null;
            //string? away = null;
            //string? conference = null;
            //string? provider = null;
            //var response = instance.GetLines(gameId, year, seasonType, week, team, home, away, conference, provider);
            //Assert.IsType<List<BettingGame>>(response);
        }
    }
}

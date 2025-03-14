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
    ///  Class for testing RankingsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RankingsApiTests : IDisposable
    {
        private RankingsApi instance;

        public RankingsApiTests()
        {
            instance = new RankingsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RankingsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' RankingsApi
            //Assert.IsType<RankingsApi>(instance);
        }

        /// <summary>
        /// Test GetRankings
        /// </summary>
        [Fact]
        public void GetRankingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int year = null;
            //SeasonType? seasonType = null;
            //double? week = null;
            //var response = instance.GetRankings(year, seasonType, week);
            //Assert.IsType<List<PollWeek>>(response);
        }
    }
}

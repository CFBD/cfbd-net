/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.6.2
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
    ///  Class for testing RatingsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RatingsApiTests : IDisposable
    {
        private RatingsApi instance;

        public RatingsApiTests()
        {
            instance = new RatingsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RatingsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' RatingsApi
            //Assert.IsType<RatingsApi>(instance);
        }

        /// <summary>
        /// Test GetConferenceSP
        /// </summary>
        [Fact]
        public void GetConferenceSPTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? year = null;
            //string? conference = null;
            //var response = instance.GetConferenceSP(year, conference);
            //Assert.IsType<List<ConferenceSP>>(response);
        }

        /// <summary>
        /// Test GetElo
        /// </summary>
        [Fact]
        public void GetEloTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? year = null;
            //int? week = null;
            //SeasonType? seasonType = null;
            //string? team = null;
            //string? conference = null;
            //var response = instance.GetElo(year, week, seasonType, team, conference);
            //Assert.IsType<List<TeamElo>>(response);
        }

        /// <summary>
        /// Test GetFPI
        /// </summary>
        [Fact]
        public void GetFPITest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? year = null;
            //string? team = null;
            //string? conference = null;
            //var response = instance.GetFPI(year, team, conference);
            //Assert.IsType<List<TeamFPI>>(response);
        }

        /// <summary>
        /// Test GetSP
        /// </summary>
        [Fact]
        public void GetSPTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? year = null;
            //string? team = null;
            //var response = instance.GetSP(year, team);
            //Assert.IsType<List<TeamSP>>(response);
        }

        /// <summary>
        /// Test GetSRS
        /// </summary>
        [Fact]
        public void GetSRSTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? year = null;
            //string? team = null;
            //string? conference = null;
            //var response = instance.GetSRS(year, team, conference);
            //Assert.IsType<List<TeamSRS>>(response);
        }
    }
}

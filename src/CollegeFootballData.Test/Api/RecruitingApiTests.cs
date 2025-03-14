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
    ///  Class for testing RecruitingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RecruitingApiTests : IDisposable
    {
        private RecruitingApi instance;

        public RecruitingApiTests()
        {
            instance = new RecruitingApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RecruitingApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' RecruitingApi
            //Assert.IsType<RecruitingApi>(instance);
        }

        /// <summary>
        /// Test GetAggregatedTeamRecruitingRatings
        /// </summary>
        [Fact]
        public void GetAggregatedTeamRecruitingRatingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? team = null;
            //string? conference = null;
            //RecruitClassification? recruitType = null;
            //int? startYear = null;
            //int? endYear = null;
            //var response = instance.GetAggregatedTeamRecruitingRatings(team, conference, recruitType, startYear, endYear);
            //Assert.IsType<List<AggregatedTeamRecruiting>>(response);
        }

        /// <summary>
        /// Test GetRecruits
        /// </summary>
        [Fact]
        public void GetRecruitsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? year = null;
            //string? team = null;
            //string? position = null;
            //string? state = null;
            //RecruitClassification? classification = null;
            //var response = instance.GetRecruits(year, team, position, state, classification);
            //Assert.IsType<List<Recruit>>(response);
        }

        /// <summary>
        /// Test GetTeamRecruitingRankings
        /// </summary>
        [Fact]
        public void GetTeamRecruitingRankingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? year = null;
            //string? team = null;
            //var response = instance.GetTeamRecruitingRankings(year, team);
            //Assert.IsType<List<TeamRecruitingRanking>>(response);
        }
    }
}

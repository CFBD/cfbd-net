/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.5.1
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
    ///  Class for testing CoachesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CoachesApiTests : IDisposable
    {
        private CoachesApi instance;

        public CoachesApiTests()
        {
            instance = new CoachesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CoachesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CoachesApi
            //Assert.IsType<CoachesApi>(instance);
        }

        /// <summary>
        /// Test GetCoaches
        /// </summary>
        [Fact]
        public void GetCoachesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? firstName = null;
            //string? lastName = null;
            //string? team = null;
            //int? year = null;
            //int? minYear = null;
            //int? maxYear = null;
            //var response = instance.GetCoaches(firstName, lastName, team, year, minYear, maxYear);
            //Assert.IsType<List<Coach>>(response);
        }
    }
}

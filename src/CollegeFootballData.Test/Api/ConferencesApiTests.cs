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
    ///  Class for testing ConferencesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ConferencesApiTests : IDisposable
    {
        private ConferencesApi instance;

        public ConferencesApiTests()
        {
            instance = new ConferencesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ConferencesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ConferencesApi
            //Assert.IsType<ConferencesApi>(instance);
        }

        /// <summary>
        /// Test GetConferences
        /// </summary>
        [Fact]
        public void GetConferencesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetConferences();
            //Assert.IsType<List<Conference>>(response);
        }
    }
}

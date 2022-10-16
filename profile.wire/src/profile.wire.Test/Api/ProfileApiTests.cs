/*
 * TP.Profile.Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
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

using profile.wire.Client;
using profile.wire.Api;
// uncomment below to import models
//using profile.wire.Model;

namespace profile.wire.Test.Api
{
    /// <summary>
    ///  Class for testing ProfileApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProfileApiTests : IDisposable
    {
        private ProfileApi instance;

        public ProfileApiTests()
        {
            instance = new ProfileApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProfileApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ProfileApi
            //Assert.IsType<ProfileApi>(instance);
        }

        /// <summary>
        /// Test ProfileCanBeAssistantGet
        /// </summary>
        [Fact]
        public void ProfileCanBeAssistantGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ProfileCanBeAssistantGet();
            //Assert.IsType<CanBeAssistantRes>(response);
        }

        /// <summary>
        /// Test ProfileConvertToAssistantPost
        /// </summary>
        [Fact]
        public void ProfileConvertToAssistantPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ProfileConvertToAssistantPost();
            //Assert.IsType<EmptyResponse>(response);
        }

        /// <summary>
        /// Test ProfileMeGet
        /// </summary>
        [Fact]
        public void ProfileMeGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ProfileMeGet();
            //Assert.IsType<ProfileDto>(response);
        }

        /// <summary>
        /// Test ProfileProfileIdGet
        /// </summary>
        [Fact]
        public void ProfileProfileIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string profileId = null;
            //var response = instance.ProfileProfileIdGet(profileId);
            //Assert.IsType<ProfileDto>(response);
        }

        /// <summary>
        /// Test ProfileUpdateInterestsPost
        /// </summary>
        [Fact]
        public void ProfileUpdateInterestsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateInterestsReq? updateInterestsReq = null;
            //var response = instance.ProfileUpdateInterestsPost(updateInterestsReq);
            //Assert.IsType<ProfileDto>(response);
        }

        /// <summary>
        /// Test ProfileUpdateProfilePatch
        /// </summary>
        [Fact]
        public void ProfileUpdateProfilePatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateProfileReq? updateProfileReq = null;
            //var response = instance.ProfileUpdateProfilePatch(updateProfileReq);
            //Assert.IsType<ProfileDto>(response);
        }

        /// <summary>
        /// Test ProfileUploadAvatarPatch
        /// </summary>
        [Fact]
        public void ProfileUploadAvatarPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream? file = null;
            //var response = instance.ProfileUploadAvatarPatch(file);
            //Assert.IsType<ProfileDto>(response);
        }
    }
}

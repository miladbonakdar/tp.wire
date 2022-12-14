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
    ///  Class for testing UserAuthApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UserAuthApiTests : IDisposable
    {
        private UserAuthApi instance;

        public UserAuthApiTests()
        {
            instance = new UserAuthApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserAuthApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UserAuthApi
            //Assert.IsType<UserAuthApi>(instance);
        }

        /// <summary>
        /// Test UserAuthGoogleLoginPost
        /// </summary>
        [Fact]
        public void UserAuthGoogleLoginPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RefreshTokenReq? refreshTokenReq = null;
            //var response = instance.UserAuthGoogleLoginPost(refreshTokenReq);
            //Assert.IsType<LoginRes>(response);
        }

        /// <summary>
        /// Test UserAuthLoginPost
        /// </summary>
        [Fact]
        public void UserAuthLoginPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EmailPasswordLoginReq? emailPasswordLoginReq = null;
            //var response = instance.UserAuthLoginPost(emailPasswordLoginReq);
            //Assert.IsType<LoginRes>(response);
        }

        /// <summary>
        /// Test UserAuthOtpLoginRequestPost
        /// </summary>
        [Fact]
        public void UserAuthOtpLoginRequestPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OtpLoginReq? otpLoginReq = null;
            //var response = instance.UserAuthOtpLoginRequestPost(otpLoginReq);
            //Assert.IsType<OtpRequestRes>(response);
        }

        /// <summary>
        /// Test UserAuthOtpLoginValidatePost
        /// </summary>
        [Fact]
        public void UserAuthOtpLoginValidatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OtpLoginValidateReq? otpLoginValidateReq = null;
            //var response = instance.UserAuthOtpLoginValidatePost(otpLoginValidateReq);
            //Assert.IsType<LoginRes>(response);
        }

        /// <summary>
        /// Test UserAuthRefreshTokenPost
        /// </summary>
        [Fact]
        public void UserAuthRefreshTokenPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RefreshTokenReq? refreshTokenReq = null;
            //var response = instance.UserAuthRefreshTokenPost(refreshTokenReq);
            //Assert.IsType<LoginRes>(response);
        }

        /// <summary>
        /// Test UserAuthRegisterPost
        /// </summary>
        [Fact]
        public void UserAuthRegisterPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserRegisterReq? userRegisterReq = null;
            //var response = instance.UserAuthRegisterPost(userRegisterReq);
            //Assert.IsType<LoginRes>(response);
        }
    }
}

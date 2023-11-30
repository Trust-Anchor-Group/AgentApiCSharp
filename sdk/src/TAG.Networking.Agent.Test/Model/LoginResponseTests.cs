/*
 * Agent API
 *
 * The Neuron® publishes an Agent API that can be used by agents that do not wish to, or are able to, connect to the Neuron® via any of the XMPP bindings available, such as standard binary  socket, websocket or Synchronous HTTP (BOSH). Via the Agent API, the agent is permitted to do  basic tasks, such as send messages, create Agent IDs, and sign contracts with such Agent IDs.  The Full API is 
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using TAG.Networking.Agent.Model;
using TAG.Networking.Agent.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace TAG.Networking.Agent.Test.Model
{
    /// <summary>
    ///  Class for testing LoginResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class LoginResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for LoginResponse
        //private LoginResponse instance;

        public LoginResponseTests()
        {
            // TODO uncomment below to create an instance of LoginResponse
            //instance = new LoginResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LoginResponse
        /// </summary>
        [Fact]
        public void LoginResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" LoginResponse
            //Assert.IsType<LoginResponse>(instance);
        }

        /// <summary>
        /// Test the property 'Jwt'
        /// </summary>
        [Fact]
        public void JwtTest()
        {
            // TODO unit test for the property 'Jwt'
        }

        /// <summary>
        /// Test the property 'Expires'
        /// </summary>
        [Fact]
        public void ExpiresTest()
        {
            // TODO unit test for the property 'Expires'
        }
    }
}
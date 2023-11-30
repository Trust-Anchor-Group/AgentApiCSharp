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
    ///  Class for testing GetCreatedContractsBody
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GetCreatedContractsBodyTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GetCreatedContractsBody
        //private GetCreatedContractsBody instance;

        public GetCreatedContractsBodyTests()
        {
            // TODO uncomment below to create an instance of GetCreatedContractsBody
            //instance = new GetCreatedContractsBody();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GetCreatedContractsBody
        /// </summary>
        [Fact]
        public void GetCreatedContractsBodyInstanceTest()
        {
            // TODO uncomment below to test "IsType" GetCreatedContractsBody
            //Assert.IsType<GetCreatedContractsBody>(instance);
        }

        /// <summary>
        /// Test the property 'Offset'
        /// </summary>
        [Fact]
        public void OffsetTest()
        {
            // TODO unit test for the property 'Offset'
        }

        /// <summary>
        /// Test the property 'MaxCount'
        /// </summary>
        [Fact]
        public void MaxCountTest()
        {
            // TODO unit test for the property 'MaxCount'
        }
    }
}
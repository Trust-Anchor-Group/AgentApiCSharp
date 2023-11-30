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
    ///  Class for testing QueryResultXml
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class QueryResultXmlTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for QueryResultXml
        //private QueryResultXml instance;

        public QueryResultXmlTests()
        {
            // TODO uncomment below to create an instance of QueryResultXml
            //instance = new QueryResultXml();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of QueryResultXml
        /// </summary>
        [Fact]
        public void QueryResultXmlInstanceTest()
        {
            // TODO uncomment below to test "IsType" QueryResultXml
            //Assert.IsType<QueryResultXml>(instance);
        }

        /// <summary>
        /// Test the property 'Ok'
        /// </summary>
        [Fact]
        public void OkTest()
        {
            // TODO unit test for the property 'Ok'
        }

        /// <summary>
        /// Test the property 'ErrorCode'
        /// </summary>
        [Fact]
        public void ErrorCodeTest()
        {
            // TODO unit test for the property 'ErrorCode'
        }

        /// <summary>
        /// Test the property 'ErrorText'
        /// </summary>
        [Fact]
        public void ErrorTextTest()
        {
            // TODO unit test for the property 'ErrorText'
        }

        /// <summary>
        /// Test the property 'ErrorType'
        /// </summary>
        [Fact]
        public void ErrorTypeTest()
        {
            // TODO unit test for the property 'ErrorType'
        }

        /// <summary>
        /// Test the property 'Content'
        /// </summary>
        [Fact]
        public void ContentTest()
        {
            // TODO unit test for the property 'Content'
        }
    }
}
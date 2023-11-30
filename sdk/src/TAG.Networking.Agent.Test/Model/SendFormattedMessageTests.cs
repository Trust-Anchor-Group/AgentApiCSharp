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
    ///  Class for testing SendFormattedMessage
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SendFormattedMessageTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SendFormattedMessage
        //private SendFormattedMessage instance;

        public SendFormattedMessageTests()
        {
            // TODO uncomment below to create an instance of SendFormattedMessage
            //instance = new SendFormattedMessage();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SendFormattedMessage
        /// </summary>
        [Fact]
        public void SendFormattedMessageInstanceTest()
        {
            // TODO uncomment below to test "IsType" SendFormattedMessage
            //Assert.IsType<SendFormattedMessage>(instance);
        }

        /// <summary>
        /// Test the property 'To'
        /// </summary>
        [Fact]
        public void ToTest()
        {
            // TODO unit test for the property 'To'
        }

        /// <summary>
        /// Test the property 'Message'
        /// </summary>
        [Fact]
        public void MessageTest()
        {
            // TODO unit test for the property 'Message'
        }

        /// <summary>
        /// Test the property 'Subject'
        /// </summary>
        [Fact]
        public void SubjectTest()
        {
            // TODO unit test for the property 'Subject'
        }

        /// <summary>
        /// Test the property 'Language'
        /// </summary>
        [Fact]
        public void LanguageTest()
        {
            // TODO unit test for the property 'Language'
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
    }
}
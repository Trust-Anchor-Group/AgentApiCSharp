/*
 * Agent API
 *
 * The Neuron® publishes an Agent API that can be used by agents that do not wish to, or are able to, connect to the Neuron® via any of the XMPP bindings available, such as standard binary  socket, websocket or Synchronous HTTP (BOSH). Via the Agent API, the agent is permitted to do  basic tasks, such as send messages, create Agent IDs, and sign contracts with such Agent IDs.  The Full API is 
 *
 * The version of the OpenAPI document: 1.0.0
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

using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Api;
// uncomment below to import models
//using TAG.Networking.Agent.Model;

namespace TAG.Networking.Agent.Test.Api
{
    /// <summary>
    ///  Class for testing StorageApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class StorageApiTests : IDisposable
    {
        private StorageApi instance;

        public StorageApiTests()
        {
            instance = new StorageApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of StorageApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' StorageApi
            //Assert.IsType<StorageApi>(instance);
        }

        /// <summary>
        /// Test DeleteContent
        /// </summary>
        [Fact]
        public void DeleteContentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string path = null;
            //instance.DeleteContent(path);
        }

        /// <summary>
        /// Test GetContent
        /// </summary>
        [Fact]
        public void GetContentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string path = null;
            //var response = instance.GetContent(path);
            //Assert.IsType<ContentResponse>(response);
        }

        /// <summary>
        /// Test LoadPrivateXml
        /// </summary>
        [Fact]
        public void LoadPrivateXmlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LoadPrivateXmlBody loadPrivateXmlBody = null;
            //var response = instance.LoadPrivateXml(loadPrivateXmlBody);
            //Assert.IsType<PrivateXml>(response);
        }

        /// <summary>
        /// Test PostContent
        /// </summary>
        [Fact]
        public void PostContentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream content = null;
            //string contentId = null;
            //string visibility = null;
            //var response = instance.PostContent(content, contentId, visibility);
            //Assert.IsType<ContentResponse>(response);
        }

        /// <summary>
        /// Test PutContent
        /// </summary>
        [Fact]
        public void PutContentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string contentId = null;
            //string xVisibility = null;
            //System.IO.Stream body = null;
            //var response = instance.PutContent(username, contentId, xVisibility, body);
            //Assert.IsType<ContentResponse>(response);
        }

        /// <summary>
        /// Test SavePrivateXml
        /// </summary>
        [Fact]
        public void SavePrivateXmlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SavePrivateXmlBody savePrivateXmlBody = null;
            //var response = instance.SavePrivateXml(savePrivateXmlBody);
            //Assert.IsType<Stored>(response);
        }
    }
}
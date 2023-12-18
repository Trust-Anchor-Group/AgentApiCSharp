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
    ///  Class for testing LegalApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class LegalApiTests : IDisposable
    {
        private LegalApi instance;

        public LegalApiTests()
        {
            instance = new LegalApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LegalApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' LegalApi
            //Assert.IsType<LegalApi>(instance);
        }

        /// <summary>
        /// Test AddIdAttachment
        /// </summary>
        [Fact]
        public void AddIdAttachmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AddIdAttachmentBody addIdAttachmentBody = null;
            //var response = instance.AddIdAttachment(addIdAttachmentBody);
            //Assert.IsType<IdentityResponse>(response);
        }

        /// <summary>
        /// Test ApplyId
        /// </summary>
        [Fact]
        public void ApplyIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ApplyIdBody applyIdBody = null;
            //var response = instance.ApplyId(applyIdBody);
            //Assert.IsType<IdentityResponseJSON>(response);
        }

        /// <summary>
        /// Test AuthorizeAccessToContract
        /// </summary>
        [Fact]
        public void AuthorizeAccessToContractTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AuthorizeAccessToContractBody authorizeAccessToContractBody = null;
            //var response = instance.AuthorizeAccessToContract(authorizeAccessToContractBody);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test AuthorizeAccessToId
        /// </summary>
        [Fact]
        public void AuthorizeAccessToIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AuthorizeAccessToIdBody authorizeAccessToIdBody = null;
            //var response = instance.AuthorizeAccessToId(authorizeAccessToIdBody);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test CreateContract
        /// </summary>
        [Fact]
        public void CreateContractTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateContractBody createContractBody = null;
            //var response = instance.CreateContract(createContractBody);
            //Assert.IsType<ContractResponse>(response);
        }

        /// <summary>
        /// Test GetApplicationAttributes
        /// </summary>
        [Fact]
        public void GetApplicationAttributesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object body = null;
            //var response = instance.GetApplicationAttributes(body);
            //Assert.IsType<GetApplicationAttributesResponse>(response);
        }

        /// <summary>
        /// Test GetContract
        /// </summary>
        [Fact]
        public void GetContractTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetContractBody getContractBody = null;
            //var response = instance.GetContract(getContractBody);
            //Assert.IsType<ContractResponse>(response);
        }

        /// <summary>
        /// Test GetCreatedContracts
        /// </summary>
        [Fact]
        public void GetCreatedContractsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetCreatedContractsBody getCreatedContractsBody = null;
            //var response = instance.GetCreatedContracts(getCreatedContractsBody);
            //Assert.IsType<ContractsResponse>(response);
        }

        /// <summary>
        /// Test GetIdentities
        /// </summary>
        [Fact]
        public void GetIdentitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetIdentitiesBody getIdentitiesBody = null;
            //var response = instance.GetIdentities(getIdentitiesBody);
            //Assert.IsType<IdentitiesResponseJSON>(response);
        }

        /// <summary>
        /// Test GetIdentity
        /// </summary>
        [Fact]
        public void GetIdentityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetIdentityBody getIdentityBody = null;
            //var response = instance.GetIdentity(getIdentityBody);
            //Assert.IsType<IdentityResponseJSON>(response);
        }

        /// <summary>
        /// Test GetServiceProviderForIdReview
        /// </summary>
        [Fact]
        public void GetServiceProviderForIdReviewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetServiceProvidersForIdReviewBody getServiceProvidersForIdReviewBody = null;
            //var response = instance.GetServiceProviderForIdReview(getServiceProvidersForIdReviewBody);
            //Assert.IsType<ProvidersResponse>(response);
        }

        /// <summary>
        /// Test PetitionId
        /// </summary>
        [Fact]
        public void PetitionIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PetitionIdBody petitionIdBody = null;
            //var response = instance.PetitionId(petitionIdBody);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test PetitionPeerReview
        /// </summary>
        [Fact]
        public void PetitionPeerReviewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PetitionPeerReviewBody petitionPeerReviewBody = null;
            //var response = instance.PetitionPeerReview(petitionPeerReviewBody);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test PetitionSignature
        /// </summary>
        [Fact]
        public void PetitionSignatureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PetitionSignatureBody petitionSignatureBody = null;
            //var response = instance.PetitionSignature(petitionSignatureBody);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test ReadyForApproval
        /// </summary>
        [Fact]
        public void ReadyForApprovalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReadyForApprovalBody readyForApprovalBody = null;
            //var response = instance.ReadyForApproval(readyForApprovalBody);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test SelectReviewService
        /// </summary>
        [Fact]
        public void SelectReviewServiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SelectReviewServiceBody selectReviewServiceBody = null;
            //var response = instance.SelectReviewService(selectReviewServiceBody);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test SignContract
        /// </summary>
        [Fact]
        public void SignContractTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SignContractBody signContractBody = null;
            //var response = instance.SignContract(signContractBody);
            //Assert.IsType<ContractResponse>(response);
        }

        /// <summary>
        /// Test SignData
        /// </summary>
        [Fact]
        public void SignDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SignDataBody signDataBody = null;
            //var response = instance.SignData(signDataBody);
            //Assert.IsType<SignatureResponse>(response);
        }

        /// <summary>
        /// Test ValidatePNr
        /// </summary>
        [Fact]
        public void ValidatePNrTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ValidatePNrBody validatePNrBody = null;
            //var response = instance.ValidatePNr(validatePNrBody);
            //Assert.IsType<ValidatePNrResponse>(response);
        }
    }
}

# TAG.Networking.Agent.Api.LegalApi

All URIs are relative to *https://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddIdAttachment**](LegalApi.md#addidattachment) | **POST** /Agent/Legal/AddIdAttachment | Add attachment to legal id application (NOT IMPLEMENTED) |
| [**AuthorizeAccessToContract**](LegalApi.md#authorizeaccesstocontract) | **POST** /Agent/Legal/AuthorizeAccessToContract | Authorize Access to Contract |
| [**AuthorizeAccessToId**](LegalApi.md#authorizeaccesstoid) | **POST** /Agent/Legal/AuthorizeAccessToId | Authorize Access to ID |
| [**CreateContract**](LegalApi.md#createcontract) | **POST** /Agent/Legal/CreateContract | Create Contract |
| [**GetApplicationAttributes**](LegalApi.md#getapplicationattributes) | **POST** /Agent/Legal/GetApplicationAttributes | Get Application Attributes |
| [**GetContract**](LegalApi.md#getcontract) | **POST** /Agent/Legal/GetContract | Get Contract |
| [**GetCreatedContracts**](LegalApi.md#getcreatedcontracts) | **POST** /Agent/Legal/GetCreatedContracts | Get Created Contracts |
| [**GetIdentities**](LegalApi.md#getidentities) | **POST** /Agent/Legal/GetIdentities | Get Legal Identities |
| [**GetIdentity**](LegalApi.md#getidentity) | **POST** /Agent/Legal/GetIdentity | Get Legal Identity |
| [**GetServiceProviderForIdReview**](LegalApi.md#getserviceproviderforidreview) | **POST** /Agent/Legal/GetServiceProviderForIdReview | Get Service Provider for ID Review |
| [**PetitionId**](LegalApi.md#petitionid) | **POST** /Agent/Legal/PetitionId | Petition ID |
| [**PetitionPeerReview**](LegalApi.md#petitionpeerreview) | **POST** /Agent/Legal/PetitionPeerReview | Petition Peer Review |
| [**PetitionSignature**](LegalApi.md#petitionsignature) | **POST** /Agent/Legal/PetitionSignature | Petition Signature |
| [**ReadyForApproval**](LegalApi.md#readyforapproval) | **POST** /Agent/Legal/ReadyForApproval | Ready for Approval |
| [**SelectReviewService**](LegalApi.md#selectreviewservice) | **POST** /Agent/Legal/SelectReviewService | Select Review Service |
| [**SignContract**](LegalApi.md#signcontract) | **POST** /Agent/Legal/SignContract | Sign Contract |
| [**SignData**](LegalApi.md#signdata) | **POST** /Agent/Legal/SignData | Sign Data |
| [**ValidatePNr**](LegalApi.md#validatepnr) | **POST** /Agent/Legal/ValidatePNr | Validate Personal Number |

<a id="addidattachment"></a>
# **AddIdAttachment**
> IdentityResponse AddIdAttachment (AddIdAttachmentBody addIdAttachmentBody = null)

Add attachment to legal id application (NOT IMPLEMENTED)

Allows the client to add an attachment to a Legal Identity application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class AddIdAttachmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LegalApi(config);
            var addIdAttachmentBody = new AddIdAttachmentBody(); // AddIdAttachmentBody |  (optional) 

            try
            {
                // Add attachment to legal id application (NOT IMPLEMENTED)
                IdentityResponse result = apiInstance.AddIdAttachment(addIdAttachmentBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalApi.AddIdAttachment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddIdAttachmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add attachment to legal id application (NOT IMPLEMENTED)
    ApiResponse<IdentityResponse> response = apiInstance.AddIdAttachmentWithHttpInfo(addIdAttachmentBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LegalApi.AddIdAttachmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addIdAttachmentBody** | [**AddIdAttachmentBody**](AddIdAttachmentBody.md) |  | [optional]  |

### Return type

[**IdentityResponse**](IdentityResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request, most probably due to the content sent in the request not conforming to the specification. |  -  |
| **401** | Unauthorized access to a resource was prevented. Client must login first. |  -  |
| **403** | Forbidden access to resource was stopped. Client does not have sufficient privileges to access resource or perform requested action, or access is done using unencrypted, or a connection that is not sufficiently encrypted. |  -  |
| **404** | Resource, or item referenced in request, was not found. |  -  |
| **405** | Method not allowed. The method used in the request is not allowed for the resource. |  -  |
| **406** | Content sent, or content requested in a format that is not supported by the resource. |  -  |
| **429** | Too many requests have been made, for this resource, or any of the referenced resources in the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="authorizeaccesstocontract"></a>
# **AuthorizeAccessToContract**
> Object AuthorizeAccessToContract (AuthorizeAccessToContractBody authorizeAccessToContractBody = null)

Authorize Access to Contract

Allows the client to (pre-)authorize access to (or remove authorization to access) one of its Smart Contracts (or one of the Smart Contracts for which the client is part) to a remote party. When (if) the remote party requests access to the the Smart Contract, the broker will return it automatically, if already authorized. If not authorized, a petition to access the Smart Contract will be sent to the clients of the part of the contract for manual approval. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class AuthorizeAccessToContractExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LegalApi(config);
            var authorizeAccessToContractBody = new AuthorizeAccessToContractBody(); // AuthorizeAccessToContractBody |  (optional) 

            try
            {
                // Authorize Access to Contract
                Object result = apiInstance.AuthorizeAccessToContract(authorizeAccessToContractBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalApi.AuthorizeAccessToContract: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthorizeAccessToContractWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Authorize Access to Contract
    ApiResponse<Object> response = apiInstance.AuthorizeAccessToContractWithHttpInfo(authorizeAccessToContractBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LegalApi.AuthorizeAccessToContractWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorizeAccessToContractBody** | [**AuthorizeAccessToContractBody**](AuthorizeAccessToContractBody.md) |  | [optional]  |

### Return type

**Object**

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request, most probably due to the content sent in the request not conforming to the specification. |  -  |
| **401** | Unauthorized access to a resource was prevented. Client must login first. |  -  |
| **403** | Forbidden access to resource was stopped. Client does not have sufficient privileges to access resource or perform requested action, or access is done using unencrypted, or a connection that is not sufficiently encrypted. |  -  |
| **404** | Resource, or item referenced in request, was not found. |  -  |
| **405** | Method not allowed. The method used in the request is not allowed for the resource. |  -  |
| **406** | Content sent, or content requested in a format that is not supported by the resource. |  -  |
| **429** | Too many requests have been made, for this resource, or any of the referenced resources in the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="authorizeaccesstoid"></a>
# **AuthorizeAccessToId**
> Object AuthorizeAccessToId (AuthorizeAccessToIdBody authorizeAccessToIdBody = null)

Authorize Access to ID

Allows the client to (pre-)authorize access to (or remove authorization to access) one of its Legal Identities to a remote party. When (if) the remote party requests the ID, the broker will return it automatically, if already authorized. If not authorized, a petition to access the identity will be sent to the client for manual approval (or rejection).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class AuthorizeAccessToIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LegalApi(config);
            var authorizeAccessToIdBody = new AuthorizeAccessToIdBody(); // AuthorizeAccessToIdBody |  (optional) 

            try
            {
                // Authorize Access to ID
                Object result = apiInstance.AuthorizeAccessToId(authorizeAccessToIdBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalApi.AuthorizeAccessToId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthorizeAccessToIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Authorize Access to ID
    ApiResponse<Object> response = apiInstance.AuthorizeAccessToIdWithHttpInfo(authorizeAccessToIdBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LegalApi.AuthorizeAccessToIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorizeAccessToIdBody** | [**AuthorizeAccessToIdBody**](AuthorizeAccessToIdBody.md) |  | [optional]  |

### Return type

**Object**

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request, most probably due to the content sent in the request not conforming to the specification. |  -  |
| **401** | Unauthorized access to a resource was prevented. Client must login first. |  -  |
| **403** | Forbidden access to resource was stopped. Client does not have sufficient privileges to access resource or perform requested action, or access is done using unencrypted, or a connection that is not sufficiently encrypted. |  -  |
| **404** | Resource, or item referenced in request, was not found. |  -  |
| **405** | Method not allowed. The method used in the request is not allowed for the resource. |  -  |
| **406** | Content sent, or content requested in a format that is not supported by the resource. |  -  |
| **429** | Too many requests have been made, for this resource, or any of the referenced resources in the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createcontract"></a>
# **CreateContract**
> ContractResponse CreateContract (CreateContractBody createContractBody = null)

Create Contract

Allows the client to create a new smart contract, based on an existing (and approved) contract template. The request must be signed using one of the keys created by the client.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class CreateContractExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LegalApi(config);
            var createContractBody = new CreateContractBody(); // CreateContractBody |  (optional) 

            try
            {
                // Create Contract
                ContractResponse result = apiInstance.CreateContract(createContractBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalApi.CreateContract: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateContractWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Contract
    ApiResponse<ContractResponse> response = apiInstance.CreateContractWithHttpInfo(createContractBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LegalApi.CreateContractWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createContractBody** | [**CreateContractBody**](CreateContractBody.md) |  | [optional]  |

### Return type

[**ContractResponse**](ContractResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request, most probably due to the content sent in the request not conforming to the specification. |  -  |
| **401** | Unauthorized access to a resource was prevented. Client must login first. |  -  |
| **403** | Forbidden access to resource was stopped. Client does not have sufficient privileges to access resource or perform requested action, or access is done using unencrypted, or a connection that is not sufficiently encrypted. |  -  |
| **404** | Resource, or item referenced in request, was not found. |  -  |
| **405** | Method not allowed. The method used in the request is not allowed for the resource. |  -  |
| **406** | Content sent, or content requested in a format that is not supported by the resource. |  -  |
| **429** | Too many requests have been made, for this resource, or any of the referenced resources in the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getapplicationattributes"></a>
# **GetApplicationAttributes**
> GetApplicationAttributesResponse GetApplicationAttributes (Object body = null)

Get Application Attributes

Allows the client to get the attributes of a legal identity application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class GetApplicationAttributesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LegalApi(config);
            var body = null;  // Object |  (optional) 

            try
            {
                // Get Application Attributes
                GetApplicationAttributesResponse result = apiInstance.GetApplicationAttributes(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalApi.GetApplicationAttributes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetApplicationAttributesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Application Attributes
    ApiResponse<GetApplicationAttributesResponse> response = apiInstance.GetApplicationAttributesWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LegalApi.GetApplicationAttributesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object** |  | [optional]  |

### Return type

[**GetApplicationAttributesResponse**](GetApplicationAttributesResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request, most probably due to the content sent in the request not conforming to the specification. |  -  |
| **401** | Unauthorized access to a resource was prevented. Client must login first. |  -  |
| **403** | Forbidden access to resource was stopped. Client does not have sufficient privileges to access resource or perform requested action, or access is done using unencrypted, or a connection that is not sufficiently encrypted. |  -  |
| **404** | Resource, or item referenced in request, was not found. |  -  |
| **405** | Method not allowed. The method used in the request is not allowed for the resource. |  -  |
| **406** | Content sent, or content requested in a format that is not supported by the resource. |  -  |
| **429** | Too many requests have been made, for this resource, or any of the referenced resources in the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontract"></a>
# **GetContract**
> ContractResponse GetContract (GetContractBody getContractBody = null)

Get Contract

Allows the client to get a Smart Contract. If the Contract belongs to someone else, and the client is not authorized access to the Contract, an error will be returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class GetContractExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LegalApi(config);
            var getContractBody = new GetContractBody(); // GetContractBody |  (optional) 

            try
            {
                // Get Contract
                ContractResponse result = apiInstance.GetContract(getContractBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalApi.GetContract: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContractWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Contract
    ApiResponse<ContractResponse> response = apiInstance.GetContractWithHttpInfo(getContractBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LegalApi.GetContractWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getContractBody** | [**GetContractBody**](GetContractBody.md) |  | [optional]  |

### Return type

[**ContractResponse**](ContractResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request, most probably due to the content sent in the request not conforming to the specification. |  -  |
| **401** | Unauthorized access to a resource was prevented. Client must login first. |  -  |
| **403** | Forbidden access to resource was stopped. Client does not have sufficient privileges to access resource or perform requested action, or access is done using unencrypted, or a connection that is not sufficiently encrypted. |  -  |
| **404** | Resource, or item referenced in request, was not found. |  -  |
| **405** | Method not allowed. The method used in the request is not allowed for the resource. |  -  |
| **406** | Content sent, or content requested in a format that is not supported by the resource. |  -  |
| **429** | Too many requests have been made, for this resource, or any of the referenced resources in the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcreatedcontracts"></a>
# **GetCreatedContracts**
> ContractsResponse GetCreatedContracts (GetCreatedContractsBody getCreatedContractsBody = null)

Get Created Contracts

Allows the client to get a list of all Smart Contracts created by the client.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class GetCreatedContractsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LegalApi(config);
            var getCreatedContractsBody = new GetCreatedContractsBody(); // GetCreatedContractsBody |  (optional) 

            try
            {
                // Get Created Contracts
                ContractsResponse result = apiInstance.GetCreatedContracts(getCreatedContractsBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalApi.GetCreatedContracts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCreatedContractsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Created Contracts
    ApiResponse<ContractsResponse> response = apiInstance.GetCreatedContractsWithHttpInfo(getCreatedContractsBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LegalApi.GetCreatedContractsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getCreatedContractsBody** | [**GetCreatedContractsBody**](GetCreatedContractsBody.md) |  | [optional]  |

### Return type

[**ContractsResponse**](ContractsResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request, most probably due to the content sent in the request not conforming to the specification. |  -  |
| **401** | Unauthorized access to a resource was prevented. Client must login first. |  -  |
| **403** | Forbidden access to resource was stopped. Client does not have sufficient privileges to access resource or perform requested action, or access is done using unencrypted, or a connection that is not sufficiently encrypted. |  -  |
| **404** | Resource, or item referenced in request, was not found. |  -  |
| **405** | Method not allowed. The method used in the request is not allowed for the resource. |  -  |
| **406** | Content sent, or content requested in a format that is not supported by the resource. |  -  |
| **429** | Too many requests have been made, for this resource, or any of the referenced resources in the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getidentities"></a>
# **GetIdentities**
> IdentitiesResponseJSON GetIdentities (GetIdentitiesBody getIdentitiesBody = null)

Get Legal Identities

Allows the client to get a list of identities. If the identities belong to someone else, and the client is not authorized access to the identities, an error will be returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class GetIdentitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LegalApi(config);
            var getIdentitiesBody = new GetIdentitiesBody(); // GetIdentitiesBody |  (optional) 

            try
            {
                // Get Legal Identities
                IdentitiesResponseJSON result = apiInstance.GetIdentities(getIdentitiesBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalApi.GetIdentities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIdentitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Legal Identities
    ApiResponse<IdentitiesResponseJSON> response = apiInstance.GetIdentitiesWithHttpInfo(getIdentitiesBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LegalApi.GetIdentitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getIdentitiesBody** | [**GetIdentitiesBody**](GetIdentitiesBody.md) |  | [optional]  |

### Return type

[**IdentitiesResponseJSON**](IdentitiesResponseJSON.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request, most probably due to the content sent in the request not conforming to the specification. |  -  |
| **401** | Unauthorized access to a resource was prevented. Client must login first. |  -  |
| **403** | Forbidden access to resource was stopped. Client does not have sufficient privileges to access resource or perform requested action, or access is done using unencrypted, or a connection that is not sufficiently encrypted. |  -  |
| **404** | Resource, or item referenced in request, was not found. |  -  |
| **405** | Method not allowed. The method used in the request is not allowed for the resource. |  -  |
| **406** | Content sent, or content requested in a format that is not supported by the resource. |  -  |
| **429** | Too many requests have been made, for this resource, or any of the referenced resources in the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getidentity"></a>
# **GetIdentity**
> IdentityResponseJSON GetIdentity (GetIdentityBody getIdentityBody = null)

Get Legal Identity

Allows the client to get an Identity. If the Identity belongs to someone else, and the client is not authorized access to the Identity, an error will be returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class GetIdentityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LegalApi(config);
            var getIdentityBody = new GetIdentityBody(); // GetIdentityBody |  (optional) 

            try
            {
                // Get Legal Identity
                IdentityResponseJSON result = apiInstance.GetIdentity(getIdentityBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalApi.GetIdentity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIdentityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Legal Identity
    ApiResponse<IdentityResponseJSON> response = apiInstance.GetIdentityWithHttpInfo(getIdentityBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LegalApi.GetIdentityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getIdentityBody** | [**GetIdentityBody**](GetIdentityBody.md) |  | [optional]  |

### Return type

[**IdentityResponseJSON**](IdentityResponseJSON.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request, most probably due to the content sent in the request not conforming to the specification. |  -  |
| **401** | Unauthorized access to a resource was prevented. Client must login first. |  -  |
| **403** | Forbidden access to resource was stopped. Client does not have sufficient privileges to access resource or perform requested action, or access is done using unencrypted, or a connection that is not sufficiently encrypted. |  -  |
| **404** | Resource, or item referenced in request, was not found. |  -  |
| **405** | Method not allowed. The method used in the request is not allowed for the resource. |  -  |
| **406** | Content sent, or content requested in a format that is not supported by the resource. |  -  |
| **429** | Too many requests have been made, for this resource, or any of the referenced resources in the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getserviceproviderforidreview"></a>
# **GetServiceProviderForIdReview**
> ProvidersResponse GetServiceProviderForIdReview (GetServiceProvidersForIdReviewBody getServiceProvidersForIdReviewBody = null)

Get Service Provider for ID Review

Allows the client to retrieve a list of available service providers that can be used to review a recent ID application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class GetServiceProviderForIdReviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LegalApi(config);
            var getServiceProvidersForIdReviewBody = new GetServiceProvidersForIdReviewBody(); // GetServiceProvidersForIdReviewBody |  (optional) 

            try
            {
                // Get Service Provider for ID Review
                ProvidersResponse result = apiInstance.GetServiceProviderForIdReview(getServiceProvidersForIdReviewBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalApi.GetServiceProviderForIdReview: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetServiceProviderForIdReviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Service Provider for ID Review
    ApiResponse<ProvidersResponse> response = apiInstance.GetServiceProviderForIdReviewWithHttpInfo(getServiceProvidersForIdReviewBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LegalApi.GetServiceProviderForIdReviewWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getServiceProvidersForIdReviewBody** | [**GetServiceProvidersForIdReviewBody**](GetServiceProvidersForIdReviewBody.md) |  | [optional]  |

### Return type

[**ProvidersResponse**](ProvidersResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request, most probably due to the content sent in the request not conforming to the specification. |  -  |
| **401** | Unauthorized access to a resource was prevented. Client must login first. |  -  |
| **403** | Forbidden access to resource was stopped. Client does not have sufficient privileges to access resource or perform requested action, or access is done using unencrypted, or a connection that is not sufficiently encrypted. |  -  |
| **404** | Resource, or item referenced in request, was not found. |  -  |
| **405** | Method not allowed. The method used in the request is not allowed for the resource. |  -  |
| **406** | Content sent, or content requested in a format that is not supported by the resource. |  -  |
| **429** | Too many requests have been made, for this resource, or any of the referenced resources in the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="petitionid"></a>
# **PetitionId**
> Object PetitionId (PetitionIdBody petitionIdBody = null)

Petition ID

Allows the client to petition the owner of a Legal Identity, for information about the identity.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class PetitionIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LegalApi(config);
            var petitionIdBody = new PetitionIdBody(); // PetitionIdBody |  (optional) 

            try
            {
                // Petition ID
                Object result = apiInstance.PetitionId(petitionIdBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalApi.PetitionId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PetitionIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Petition ID
    ApiResponse<Object> response = apiInstance.PetitionIdWithHttpInfo(petitionIdBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LegalApi.PetitionIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **petitionIdBody** | [**PetitionIdBody**](PetitionIdBody.md) |  | [optional]  |

### Return type

**Object**

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request, most probably due to the content sent in the request not conforming to the specification. |  -  |
| **401** | Unauthorized access to a resource was prevented. Client must login first. |  -  |
| **403** | Forbidden access to resource was stopped. Client does not have sufficient privileges to access resource or perform requested action, or access is done using unencrypted, or a connection that is not sufficiently encrypted. |  -  |
| **404** | Resource, or item referenced in request, was not found. |  -  |
| **405** | Method not allowed. The method used in the request is not allowed for the resource. |  -  |
| **406** | Content sent, or content requested in a format that is not supported by the resource. |  -  |
| **429** | Too many requests have been made, for this resource, or any of the referenced resources in the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="petitionpeerreview"></a>
# **PetitionPeerReview**
> Object PetitionPeerReview (PetitionPeerReviewBody petitionPeerReviewBody = null)

Petition Peer Review

Allows the client to petition a peer review service to review a recent identity application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class PetitionPeerReviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LegalApi(config);
            var petitionPeerReviewBody = new PetitionPeerReviewBody(); // PetitionPeerReviewBody |  (optional) 

            try
            {
                // Petition Peer Review
                Object result = apiInstance.PetitionPeerReview(petitionPeerReviewBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalApi.PetitionPeerReview: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PetitionPeerReviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Petition Peer Review
    ApiResponse<Object> response = apiInstance.PetitionPeerReviewWithHttpInfo(petitionPeerReviewBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LegalApi.PetitionPeerReviewWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **petitionPeerReviewBody** | [**PetitionPeerReviewBody**](PetitionPeerReviewBody.md) |  | [optional]  |

### Return type

**Object**

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request, most probably due to the content sent in the request not conforming to the specification. |  -  |
| **401** | Unauthorized access to a resource was prevented. Client must login first. |  -  |
| **403** | Forbidden access to resource was stopped. Client does not have sufficient privileges to access resource or perform requested action, or access is done using unencrypted, or a connection that is not sufficiently encrypted. |  -  |
| **404** | Resource, or item referenced in request, was not found. |  -  |
| **405** | Method not allowed. The method used in the request is not allowed for the resource. |  -  |
| **406** | Content sent, or content requested in a format that is not supported by the resource. |  -  |
| **429** | Too many requests have been made, for this resource, or any of the referenced resources in the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="petitionsignature"></a>
# **PetitionSignature**
> Object PetitionSignature (PetitionSignatureBody petitionSignatureBody = null)

Petition Signature

Allows the client to petition the owner of a Legal Identity for a digital signature on some digital content.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class PetitionSignatureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LegalApi(config);
            var petitionSignatureBody = new PetitionSignatureBody(); // PetitionSignatureBody |  (optional) 

            try
            {
                // Petition Signature
                Object result = apiInstance.PetitionSignature(petitionSignatureBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalApi.PetitionSignature: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PetitionSignatureWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Petition Signature
    ApiResponse<Object> response = apiInstance.PetitionSignatureWithHttpInfo(petitionSignatureBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LegalApi.PetitionSignatureWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **petitionSignatureBody** | [**PetitionSignatureBody**](PetitionSignatureBody.md) |  | [optional]  |

### Return type

**Object**

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request, most probably due to the content sent in the request not conforming to the specification. |  -  |
| **401** | Unauthorized access to a resource was prevented. Client must login first. |  -  |
| **403** | Forbidden access to resource was stopped. Client does not have sufficient privileges to access resource or perform requested action, or access is done using unencrypted, or a connection that is not sufficiently encrypted. |  -  |
| **404** | Resource, or item referenced in request, was not found. |  -  |
| **405** | Method not allowed. The method used in the request is not allowed for the resource. |  -  |
| **406** | Content sent, or content requested in a format that is not supported by the resource. |  -  |
| **429** | Too many requests have been made, for this resource, or any of the referenced resources in the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="readyforapproval"></a>
# **ReadyForApproval**
> Object ReadyForApproval (ReadyForApprovalBody readyForApprovalBody = null)

Ready for Approval

When an ID application is ready (all attachments have been signed and uploaded),  the client can call this resource to flag the application as ready for approval.   This will execute any automated onboarding procedures to analyze the application, and, if passing them, will take the identity to the approved state.  They can also take the application to the rejected state, in case they find the information invalid. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class ReadyForApprovalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LegalApi(config);
            var readyForApprovalBody = new ReadyForApprovalBody(); // ReadyForApprovalBody |  (optional) 

            try
            {
                // Ready for Approval
                Object result = apiInstance.ReadyForApproval(readyForApprovalBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalApi.ReadyForApproval: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadyForApprovalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Ready for Approval
    ApiResponse<Object> response = apiInstance.ReadyForApprovalWithHttpInfo(readyForApprovalBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LegalApi.ReadyForApprovalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **readyForApprovalBody** | [**ReadyForApprovalBody**](ReadyForApprovalBody.md) |  | [optional]  |

### Return type

**Object**

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request, most probably due to the content sent in the request not conforming to the specification. |  -  |
| **401** | Unauthorized access to a resource was prevented. Client must login first. |  -  |
| **403** | Forbidden access to resource was stopped. Client does not have sufficient privileges to access resource or perform requested action, or access is done using unencrypted, or a connection that is not sufficiently encrypted. |  -  |
| **404** | Resource, or item referenced in request, was not found. |  -  |
| **405** | Method not allowed. The method used in the request is not allowed for the resource. |  -  |
| **406** | Content sent, or content requested in a format that is not supported by the resource. |  -  |
| **429** | Too many requests have been made, for this resource, or any of the referenced resources in the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="selectreviewservice"></a>
# **SelectReviewService**
> Object SelectReviewService (SelectReviewServiceBody selectReviewServiceBody = null)

Select Review Service

Allows the client to select an internal peer review service, for reviewing a recent identity application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class SelectReviewServiceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LegalApi(config);
            var selectReviewServiceBody = new SelectReviewServiceBody(); // SelectReviewServiceBody |  (optional) 

            try
            {
                // Select Review Service
                Object result = apiInstance.SelectReviewService(selectReviewServiceBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalApi.SelectReviewService: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SelectReviewServiceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Select Review Service
    ApiResponse<Object> response = apiInstance.SelectReviewServiceWithHttpInfo(selectReviewServiceBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LegalApi.SelectReviewServiceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **selectReviewServiceBody** | [**SelectReviewServiceBody**](SelectReviewServiceBody.md) |  | [optional]  |

### Return type

**Object**

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request, most probably due to the content sent in the request not conforming to the specification. |  -  |
| **401** | Unauthorized access to a resource was prevented. Client must login first. |  -  |
| **403** | Forbidden access to resource was stopped. Client does not have sufficient privileges to access resource or perform requested action, or access is done using unencrypted, or a connection that is not sufficiently encrypted. |  -  |
| **404** | Resource, or item referenced in request, was not found. |  -  |
| **405** | Method not allowed. The method used in the request is not allowed for the resource. |  -  |
| **406** | Content sent, or content requested in a format that is not supported by the resource. |  -  |
| **429** | Too many requests have been made, for this resource, or any of the referenced resources in the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="signcontract"></a>
# **SignContract**
> ContractResponse SignContract (SignContractBody signContractBody = null)

Sign Contract

Allows the client to sign a Smart Contract. The request must be signed using one of the keys created by the client.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class SignContractExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LegalApi(config);
            var signContractBody = new SignContractBody(); // SignContractBody |  (optional) 

            try
            {
                // Sign Contract
                ContractResponse result = apiInstance.SignContract(signContractBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalApi.SignContract: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SignContractWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sign Contract
    ApiResponse<ContractResponse> response = apiInstance.SignContractWithHttpInfo(signContractBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LegalApi.SignContractWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **signContractBody** | [**SignContractBody**](SignContractBody.md) |  | [optional]  |

### Return type

[**ContractResponse**](ContractResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request, most probably due to the content sent in the request not conforming to the specification. |  -  |
| **401** | Unauthorized access to a resource was prevented. Client must login first. |  -  |
| **403** | Forbidden access to resource was stopped. Client does not have sufficient privileges to access resource or perform requested action, or access is done using unencrypted, or a connection that is not sufficiently encrypted. |  -  |
| **404** | Resource, or item referenced in request, was not found. |  -  |
| **405** | Method not allowed. The method used in the request is not allowed for the resource. |  -  |
| **406** | Content sent, or content requested in a format that is not supported by the resource. |  -  |
| **429** | Too many requests have been made, for this resource, or any of the referenced resources in the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="signdata"></a>
# **SignData**
> SignatureResponse SignData (SignDataBody signDataBody = null)

Sign Data

Allows the client to sign binary data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class SignDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LegalApi(config);
            var signDataBody = new SignDataBody(); // SignDataBody |  (optional) 

            try
            {
                // Sign Data
                SignatureResponse result = apiInstance.SignData(signDataBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalApi.SignData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SignDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sign Data
    ApiResponse<SignatureResponse> response = apiInstance.SignDataWithHttpInfo(signDataBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LegalApi.SignDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **signDataBody** | [**SignDataBody**](SignDataBody.md) |  | [optional]  |

### Return type

[**SignatureResponse**](SignatureResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request, most probably due to the content sent in the request not conforming to the specification. |  -  |
| **401** | Unauthorized access to a resource was prevented. Client must login first. |  -  |
| **403** | Forbidden access to resource was stopped. Client does not have sufficient privileges to access resource or perform requested action, or access is done using unencrypted, or a connection that is not sufficiently encrypted. |  -  |
| **404** | Resource, or item referenced in request, was not found. |  -  |
| **405** | Method not allowed. The method used in the request is not allowed for the resource. |  -  |
| **406** | Content sent, or content requested in a format that is not supported by the resource. |  -  |
| **429** | Too many requests have been made, for this resource, or any of the referenced resources in the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="validatepnr"></a>
# **ValidatePNr**
> ValidatePNrResponse ValidatePNr (ValidatePNrBody validatePNrBody = null)

Validate Personal Number

Allows the client to validate a personal number before using it to apply for a Legal Identity.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class ValidatePNrExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LegalApi(config);
            var validatePNrBody = new ValidatePNrBody(); // ValidatePNrBody |  (optional) 

            try
            {
                // Validate Personal Number
                ValidatePNrResponse result = apiInstance.ValidatePNr(validatePNrBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalApi.ValidatePNr: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ValidatePNrWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Validate Personal Number
    ApiResponse<ValidatePNrResponse> response = apiInstance.ValidatePNrWithHttpInfo(validatePNrBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LegalApi.ValidatePNrWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **validatePNrBody** | [**ValidatePNrBody**](ValidatePNrBody.md) |  | [optional]  |

### Return type

[**ValidatePNrResponse**](ValidatePNrResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request, most probably due to the content sent in the request not conforming to the specification. |  -  |
| **401** | Unauthorized access to a resource was prevented. Client must login first. |  -  |
| **403** | Forbidden access to resource was stopped. Client does not have sufficient privileges to access resource or perform requested action, or access is done using unencrypted, or a connection that is not sufficiently encrypted. |  -  |
| **404** | Resource, or item referenced in request, was not found. |  -  |
| **405** | Method not allowed. The method used in the request is not allowed for the resource. |  -  |
| **406** | Content sent, or content requested in a format that is not supported by the resource. |  -  |
| **429** | Too many requests have been made, for this resource, or any of the referenced resources in the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


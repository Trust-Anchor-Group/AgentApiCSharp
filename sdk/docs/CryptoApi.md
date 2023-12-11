# TAG.Networking.Agent.Api.CryptoApi

All URIs are relative to *https://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateKey**](CryptoApi.md#createkey) | **POST** /Agent/Crypto/CreateKey | Create Key |
| [**GetAlgorithms**](CryptoApi.md#getalgorithms) | **POST** /Agent/Crypto/GetAlgorithms | Get Algorithms |
| [**GetPublicKey**](CryptoApi.md#getpublickey) | **POST** /Agent/Crypto/GetPublicKey | Get Public Key |

<a id="createkey"></a>
# **CreateKey**
> Stored CreateKey (CreateKeyBody createKeyBody = null)

Create Key

Allows the client to create a cryptographic key on the server, and protect it with a password. The key will be stored encrypted on the server, protected with the key password. The creation of a key will require the user to provide the account password again. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class CreateKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            var apiInstance = new CryptoApi(config);
            var createKeyBody = new CreateKeyBody(); // CreateKeyBody |  (optional) 

            try
            {
                // Create Key
                Stored result = apiInstance.CreateKey(createKeyBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CryptoApi.CreateKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Key
    ApiResponse<Stored> response = apiInstance.CreateKeyWithHttpInfo(createKeyBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CryptoApi.CreateKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createKeyBody** | [**CreateKeyBody**](CreateKeyBody.md) |  | [optional]  |

### Return type

[**Stored**](Stored.md)

### Authorization

No authorization required

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

<a id="getalgorithms"></a>
# **GetAlgorithms**
> AlgorithmsResult GetAlgorithms (Object body = null)

Get Algorithms

Gets a list of algorithms supported by the server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class GetAlgorithmsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            var apiInstance = new CryptoApi(config);
            var body = null;  // Object |  (optional) 

            try
            {
                // Get Algorithms
                AlgorithmsResult result = apiInstance.GetAlgorithms(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CryptoApi.GetAlgorithms: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAlgorithmsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Algorithms
    ApiResponse<AlgorithmsResult> response = apiInstance.GetAlgorithmsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CryptoApi.GetAlgorithmsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object** |  | [optional]  |

### Return type

[**AlgorithmsResult**](AlgorithmsResult.md)

### Authorization

No authorization required

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

<a id="getpublickey"></a>
# **GetPublicKey**
> GetPublicKeyResponse GetPublicKey (GetPublicKeyBody getPublicKeyBody = null)

Get Public Key

Gets the public key of a key pair.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class GetPublicKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            var apiInstance = new CryptoApi(config);
            var getPublicKeyBody = new GetPublicKeyBody(); // GetPublicKeyBody |  (optional) 

            try
            {
                // Get Public Key
                GetPublicKeyResponse result = apiInstance.GetPublicKey(getPublicKeyBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CryptoApi.GetPublicKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPublicKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Public Key
    ApiResponse<GetPublicKeyResponse> response = apiInstance.GetPublicKeyWithHttpInfo(getPublicKeyBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CryptoApi.GetPublicKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPublicKeyBody** | [**GetPublicKeyBody**](GetPublicKeyBody.md) |  | [optional]  |

### Return type

[**GetPublicKeyResponse**](GetPublicKeyResponse.md)

### Authorization

No authorization required

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


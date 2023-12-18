# TAG.Networking.Agent.Api.StorageApi

All URIs are relative to *https://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteContent**](StorageApi.md#deletecontent) | **DELETE** /Agent/Storage/Content/{path} | Deletes content from path |
| [**GetContent**](StorageApi.md#getcontent) | **GET** /Agent/Storage/Content/{path} | Get content from path |
| [**LoadPrivateXml**](StorageApi.md#loadprivatexml) | **POST** /Agent/Storage/LoadPrivateXml | Load Private XML |
| [**PostContent**](StorageApi.md#postcontent) | **POST** /Agent/Storage/Content | Upload new content using form data |
| [**PutContent**](StorageApi.md#putcontent) | **PUT** /Agent/Storage/Content/{username}/{contentId} | Upload new content with Content ID |
| [**SavePrivateXml**](StorageApi.md#saveprivatexml) | **POST** /Agent/Storage/SavePrivateXml | Save Private XML |

<a id="deletecontent"></a>
# **DeleteContent**
> void DeleteContent (string path)

Deletes content from path

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class DeleteContentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorageApi(config);
            var path = "path_example";  // string | The path to the uploaded content

            try
            {
                // Deletes content from path
                apiInstance.DeleteContent(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.DeleteContent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteContentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes content from path
    apiInstance.DeleteContentWithHttpInfo(path);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.DeleteContentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **path** | **string** | The path to the uploaded content |  |

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain


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

<a id="getcontent"></a>
# **GetContent**
> ContentResponse GetContent (string path)

Get content from path

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class GetContentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorageApi(config);
            var path = "path_example";  // string | The path to the uploaded content

            try
            {
                // Get content from path
                ContentResponse result = apiInstance.GetContent(path);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.GetContent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get content from path
    ApiResponse<ContentResponse> response = apiInstance.GetContentWithHttpInfo(path);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.GetContentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **path** | **string** | The path to the uploaded content |  |

### Return type

[**ContentResponse**](ContentResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
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

<a id="loadprivatexml"></a>
# **LoadPrivateXml**
> PrivateXml LoadPrivateXml (LoadPrivateXmlBody loadPrivateXmlBody)

Load Private XML

Loads private XML data from the server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class LoadPrivateXmlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorageApi(config);
            var loadPrivateXmlBody = new LoadPrivateXmlBody(); // LoadPrivateXmlBody | 

            try
            {
                // Load Private XML
                PrivateXml result = apiInstance.LoadPrivateXml(loadPrivateXmlBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.LoadPrivateXml: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LoadPrivateXmlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Load Private XML
    ApiResponse<PrivateXml> response = apiInstance.LoadPrivateXmlWithHttpInfo(loadPrivateXmlBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.LoadPrivateXmlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loadPrivateXmlBody** | [**LoadPrivateXmlBody**](LoadPrivateXmlBody.md) |  |  |

### Return type

[**PrivateXml**](PrivateXml.md)

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

<a id="postcontent"></a>
# **PostContent**
> ContentResponse PostContent (System.IO.Stream content = null, string contentId = null, string visibility = null)

Upload new content using form data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class PostContentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorageApi(config);
            var content = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 
            var contentId = "contentId_example";  // string |  (optional) 
            var visibility = "Public";  // string |  (optional) 

            try
            {
                // Upload new content using form data
                ContentResponse result = apiInstance.PostContent(content, contentId, visibility);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.PostContent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostContentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload new content using form data
    ApiResponse<ContentResponse> response = apiInstance.PostContentWithHttpInfo(content, contentId, visibility);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.PostContentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **content** | **System.IO.Stream****System.IO.Stream** |  | [optional]  |
| **contentId** | **string** |  | [optional]  |
| **visibility** | **string** |  | [optional]  |

### Return type

[**ContentResponse**](ContentResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Content successfully uploaded |  -  |
| **400** | Bad request, most probably due to the content sent in the request not conforming to the specification. |  -  |
| **401** | Unauthorized access to a resource was prevented. Client must login first. |  -  |
| **403** | Forbidden access to resource was stopped. Client does not have sufficient privileges to access resource or perform requested action, or access is done using unencrypted, or a connection that is not sufficiently encrypted. |  -  |
| **404** | Resource, or item referenced in request, was not found. |  -  |
| **405** | Method not allowed. The method used in the request is not allowed for the resource. |  -  |
| **406** | Content sent, or content requested in a format that is not supported by the resource. |  -  |
| **429** | Too many requests have been made, for this resource, or any of the referenced resources in the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putcontent"></a>
# **PutContent**
> ContentResponse PutContent (string username, string contentId, string xVisibility, System.IO.Stream body)

Upload new content with Content ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class PutContentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorageApi(config);
            var username = "username_example";  // string | Username of the agent uploading the content
            var contentId = "contentId_example";  // string | Content ID with file extension matching the Content-Type
            var xVisibility = "Public";  // string | Controls the visibility of the uploaded content
            var body = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | 

            try
            {
                // Upload new content with Content ID
                ContentResponse result = apiInstance.PutContent(username, contentId, xVisibility, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.PutContent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutContentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload new content with Content ID
    ApiResponse<ContentResponse> response = apiInstance.PutContentWithHttpInfo(username, contentId, xVisibility, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.PutContentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | Username of the agent uploading the content |  |
| **contentId** | **string** | Content ID with file extension matching the Content-Type |  |
| **xVisibility** | **string** | Controls the visibility of the uploaded content |  |
| **body** | **System.IO.Stream****System.IO.Stream** |  |  |

### Return type

[**ContentResponse**](ContentResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/xml, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Content successfully uploaded |  -  |
| **400** | Bad request, most probably due to the content sent in the request not conforming to the specification. |  -  |
| **401** | Unauthorized access to a resource was prevented. Client must login first. |  -  |
| **403** | Forbidden access to resource was stopped. Client does not have sufficient privileges to access resource or perform requested action, or access is done using unencrypted, or a connection that is not sufficiently encrypted. |  -  |
| **404** | Resource, or item referenced in request, was not found. |  -  |
| **405** | Method not allowed. The method used in the request is not allowed for the resource. |  -  |
| **406** | Content sent, or content requested in a format that is not supported by the resource. |  -  |
| **429** | Too many requests have been made, for this resource, or any of the referenced resources in the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="saveprivatexml"></a>
# **SavePrivateXml**
> Stored SavePrivateXml (SavePrivateXmlBody savePrivateXmlBody)

Save Private XML

Saves private XML data to the server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class SavePrivateXmlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorageApi(config);
            var savePrivateXmlBody = new SavePrivateXmlBody(); // SavePrivateXmlBody | 

            try
            {
                // Save Private XML
                Stored result = apiInstance.SavePrivateXml(savePrivateXmlBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.SavePrivateXml: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SavePrivateXmlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Save Private XML
    ApiResponse<Stored> response = apiInstance.SavePrivateXmlWithHttpInfo(savePrivateXmlBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.SavePrivateXmlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **savePrivateXmlBody** | [**SavePrivateXmlBody**](SavePrivateXmlBody.md) |  |  |

### Return type

[**Stored**](Stored.md)

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


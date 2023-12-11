# TAG.Networking.Agent.Api.WalletApi

All URIs are relative to *https://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetBalance**](WalletApi.md#getbalance) | **POST** /Agent/Wallet/GetBalance | Get Balance |
| [**GetPaymentOptionsForBuyingEDaler**](WalletApi.md#getpaymentoptionsforbuyingedaler) | **POST** /Agent/Wallet/GetPaymentOptionsForBuyingEDaler | Get Payment Options for Buying eDaler |
| [**GetPaymentOptionsForSellingEDaler**](WalletApi.md#getpaymentoptionsforsellingedaler) | **POST** /Agent/Wallet/GetPaymentOptionsForSellingEDaler | Get Payment Options for Selling eDaler |
| [**GetServiceProvidersForBuyingEDaler**](WalletApi.md#getserviceprovidersforbuyingedaler) | **POST** /Agent/Wallet/GetServiceProvidersForBuyingEDaler | Get Service Providers for Buying eDaler |
| [**GetServiceProvidersForSellingEDaler**](WalletApi.md#getserviceprovidersforsellingedaler) | **POST** /Agent/Wallet/GetServiceProvidersForSellingEDaler | Get Service Providers for Selling eDaler |
| [**GetTransactionInformation**](WalletApi.md#gettransactioninformation) | **POST** /Agent/Wallet/GetTransactionInformation | Get Transaction Information |
| [**InitiateBuyEDaler**](WalletApi.md#initiatebuyedaler) | **POST** /Agent/Wallet/InitiateBuyEDaler | Initiate Buy eDaler |
| [**InitiateSellEDaler**](WalletApi.md#initiateselledaler) | **POST** /Agent/Wallet/InitiateSellEDaler | Initiate Sell eDaler |
| [**ProcessEDalerUri**](WalletApi.md#processedaleruri) | **POST** /Agent/Wallet/ProcessEDalerUri | Process eDaler URI |

<a id="getbalance"></a>
# **GetBalance**
> GetBalanceResponse GetBalance (Object body = null)

Get Balance

Allows the client to retrieve information about the current state of its wallet.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class GetBalanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WalletApi(config);
            var body = null;  // Object |  (optional) 

            try
            {
                // Get Balance
                GetBalanceResponse result = apiInstance.GetBalance(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.GetBalance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBalanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Balance
    ApiResponse<GetBalanceResponse> response = apiInstance.GetBalanceWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WalletApi.GetBalanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object** |  | [optional]  |

### Return type

[**GetBalanceResponse**](GetBalanceResponse.md)

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

<a id="getpaymentoptionsforbuyingedaler"></a>
# **GetPaymentOptionsForBuyingEDaler**
> TransactionInformation GetPaymentOptionsForBuyingEDaler (GetPaymentOptionsForBuyingEDalerBody getPaymentOptionsForBuyingEDalerBody = null)

Get Payment Options for Buying eDaler

Allows the client to initiate the process of getting payment options for buying eDaler. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class GetPaymentOptionsForBuyingEDalerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WalletApi(config);
            var getPaymentOptionsForBuyingEDalerBody = new GetPaymentOptionsForBuyingEDalerBody(); // GetPaymentOptionsForBuyingEDalerBody |  (optional) 

            try
            {
                // Get Payment Options for Buying eDaler
                TransactionInformation result = apiInstance.GetPaymentOptionsForBuyingEDaler(getPaymentOptionsForBuyingEDalerBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.GetPaymentOptionsForBuyingEDaler: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPaymentOptionsForBuyingEDalerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Payment Options for Buying eDaler
    ApiResponse<TransactionInformation> response = apiInstance.GetPaymentOptionsForBuyingEDalerWithHttpInfo(getPaymentOptionsForBuyingEDalerBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WalletApi.GetPaymentOptionsForBuyingEDalerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPaymentOptionsForBuyingEDalerBody** | [**GetPaymentOptionsForBuyingEDalerBody**](GetPaymentOptionsForBuyingEDalerBody.md) |  | [optional]  |

### Return type

[**TransactionInformation**](TransactionInformation.md)

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

<a id="getpaymentoptionsforsellingedaler"></a>
# **GetPaymentOptionsForSellingEDaler**
> TransactionInformation GetPaymentOptionsForSellingEDaler (GetPaymentOptionsForSellingEDalerBody getPaymentOptionsForSellingEDalerBody)

Get Payment Options for Selling eDaler

Allows the client to initiate the process of getting payment options for selling eDaler. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class GetPaymentOptionsForSellingEDalerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WalletApi(config);
            var getPaymentOptionsForSellingEDalerBody = new GetPaymentOptionsForSellingEDalerBody(); // GetPaymentOptionsForSellingEDalerBody | 

            try
            {
                // Get Payment Options for Selling eDaler
                TransactionInformation result = apiInstance.GetPaymentOptionsForSellingEDaler(getPaymentOptionsForSellingEDalerBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.GetPaymentOptionsForSellingEDaler: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPaymentOptionsForSellingEDalerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Payment Options for Selling eDaler
    ApiResponse<TransactionInformation> response = apiInstance.GetPaymentOptionsForSellingEDalerWithHttpInfo(getPaymentOptionsForSellingEDalerBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WalletApi.GetPaymentOptionsForSellingEDalerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getPaymentOptionsForSellingEDalerBody** | [**GetPaymentOptionsForSellingEDalerBody**](GetPaymentOptionsForSellingEDalerBody.md) |  |  |

### Return type

[**TransactionInformation**](TransactionInformation.md)

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

<a id="getserviceprovidersforbuyingedaler"></a>
# **GetServiceProvidersForBuyingEDaler**
> ProvidersResponse GetServiceProvidersForBuyingEDaler (Object body = null)

Get Service Providers for Buying eDaler

Allows the client to retrieve a list of available service providers that can be used to buy eDaler.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class GetServiceProvidersForBuyingEDalerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WalletApi(config);
            var body = null;  // Object |  (optional) 

            try
            {
                // Get Service Providers for Buying eDaler
                ProvidersResponse result = apiInstance.GetServiceProvidersForBuyingEDaler(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.GetServiceProvidersForBuyingEDaler: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetServiceProvidersForBuyingEDalerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Service Providers for Buying eDaler
    ApiResponse<ProvidersResponse> response = apiInstance.GetServiceProvidersForBuyingEDalerWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WalletApi.GetServiceProvidersForBuyingEDalerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object** |  | [optional]  |

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

<a id="getserviceprovidersforsellingedaler"></a>
# **GetServiceProvidersForSellingEDaler**
> ProvidersResponse GetServiceProvidersForSellingEDaler (Object body = null)

Get Service Providers for Selling eDaler

Allows the client to retrieve a list of available service providers that can be used to sell eDaler.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class GetServiceProvidersForSellingEDalerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WalletApi(config);
            var body = null;  // Object |  (optional) 

            try
            {
                // Get Service Providers for Selling eDaler
                ProvidersResponse result = apiInstance.GetServiceProvidersForSellingEDaler(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.GetServiceProvidersForSellingEDaler: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetServiceProvidersForSellingEDalerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Service Providers for Selling eDaler
    ApiResponse<ProvidersResponse> response = apiInstance.GetServiceProvidersForSellingEDalerWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WalletApi.GetServiceProvidersForSellingEDalerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object** |  | [optional]  |

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

<a id="gettransactioninformation"></a>
# **GetTransactionInformation**
> TransactionInformation GetTransactionInformation (GetTransactionInformationBody getTransactionInformationBody = null)

Get Transaction Information

Allows the client to get updated transaction information from the server. It also allows the client to re-register the current Tab ID (from Events.js) and function to call, in case changes are registered with the server-side transaction object. Call this function to restart event notification if you navigate between pages. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class GetTransactionInformationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WalletApi(config);
            var getTransactionInformationBody = new GetTransactionInformationBody(); // GetTransactionInformationBody |  (optional) 

            try
            {
                // Get Transaction Information
                TransactionInformation result = apiInstance.GetTransactionInformation(getTransactionInformationBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.GetTransactionInformation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionInformationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Transaction Information
    ApiResponse<TransactionInformation> response = apiInstance.GetTransactionInformationWithHttpInfo(getTransactionInformationBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WalletApi.GetTransactionInformationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getTransactionInformationBody** | [**GetTransactionInformationBody**](GetTransactionInformationBody.md) |  | [optional]  |

### Return type

[**TransactionInformation**](TransactionInformation.md)

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

<a id="initiatebuyedaler"></a>
# **InitiateBuyEDaler**
> TransactionInformation InitiateBuyEDaler (InitiateBuyEDalerBody initiateBuyEDalerBody = null)

Initiate Buy eDaler

Allows the client to initiate the process of buying eDaler, using a service provider that does not use a smart contract as the basis for the transaction (i.e. a service provider that will require the client to open a third-party page to complete the transaction).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class InitiateBuyEDalerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WalletApi(config);
            var initiateBuyEDalerBody = new InitiateBuyEDalerBody(); // InitiateBuyEDalerBody |  (optional) 

            try
            {
                // Initiate Buy eDaler
                TransactionInformation result = apiInstance.InitiateBuyEDaler(initiateBuyEDalerBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.InitiateBuyEDaler: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InitiateBuyEDalerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Initiate Buy eDaler
    ApiResponse<TransactionInformation> response = apiInstance.InitiateBuyEDalerWithHttpInfo(initiateBuyEDalerBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WalletApi.InitiateBuyEDalerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **initiateBuyEDalerBody** | [**InitiateBuyEDalerBody**](InitiateBuyEDalerBody.md) |  | [optional]  |

### Return type

[**TransactionInformation**](TransactionInformation.md)

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

<a id="initiateselledaler"></a>
# **InitiateSellEDaler**
> TransactionInformation InitiateSellEDaler (InitiateSellEDalerBody initiateSellEDalerBody = null)

Initiate Sell eDaler

Allows the client to initiate the process of selling eDaler, using a service provider that does not use a smart contract as the basis for the transaction (i.e. a service provider that will require the client to open a third-party page to complete the transaction).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class InitiateSellEDalerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WalletApi(config);
            var initiateSellEDalerBody = new InitiateSellEDalerBody(); // InitiateSellEDalerBody |  (optional) 

            try
            {
                // Initiate Sell eDaler
                TransactionInformation result = apiInstance.InitiateSellEDaler(initiateSellEDalerBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.InitiateSellEDaler: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InitiateSellEDalerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Initiate Sell eDaler
    ApiResponse<TransactionInformation> response = apiInstance.InitiateSellEDalerWithHttpInfo(initiateSellEDalerBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WalletApi.InitiateSellEDalerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **initiateSellEDalerBody** | [**InitiateSellEDalerBody**](InitiateSellEDalerBody.md) |  | [optional]  |

### Return type

[**TransactionInformation**](TransactionInformation.md)

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

<a id="processedaleruri"></a>
# **ProcessEDalerUri**
> ProcessResult ProcessEDalerUri (ProcessEDalerUriBody processEDalerUriBody = null)

Process eDaler URI

Allows the client to process an eDaler URI.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class ProcessEDalerUriExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WalletApi(config);
            var processEDalerUriBody = new ProcessEDalerUriBody(); // ProcessEDalerUriBody |  (optional) 

            try
            {
                // Process eDaler URI
                ProcessResult result = apiInstance.ProcessEDalerUri(processEDalerUriBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.ProcessEDalerUri: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProcessEDalerUriWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Process eDaler URI
    ApiResponse<ProcessResult> response = apiInstance.ProcessEDalerUriWithHttpInfo(processEDalerUriBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WalletApi.ProcessEDalerUriWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **processEDalerUriBody** | [**ProcessEDalerUriBody**](ProcessEDalerUriBody.md) |  | [optional]  |

### Return type

[**ProcessResult**](ProcessResult.md)

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


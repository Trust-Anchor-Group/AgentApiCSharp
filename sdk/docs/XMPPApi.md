# TAG.Networking.Agent.Api.XMPPApi

All URIs are relative to *https://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetRoster**](XMPPApi.md#getroster) | **POST** /Agent/Xmpp/GetRoster | Get Roster |
| [**GetRosterItem**](XMPPApi.md#getrosteritem) | **POST** /Agent/Xmpp/GetRosterItem | Get Roster Item |
| [**InformationQuery**](XMPPApi.md#informationquery) | **POST** /Agent/Xmpp/InformationQuery | Information Query |
| [**PopMessages**](XMPPApi.md#popmessages) | **POST** /Agent/Xmpp/PopMessages | Pop Messages |
| [**PresenceProbe**](XMPPApi.md#presenceprobe) | **POST** /Agent/Xmpp/PresenceProbe | Presence Probe |
| [**RemoveRosterItem**](XMPPApi.md#removerosteritem) | **POST** /Agent/Xmpp/RemoveRosterItem | Remove Roster Item |
| [**SendFormattedMessage**](XMPPApi.md#sendformattedmessage) | **POST** /Agent/Xmpp/SendFormattedMessage | Send Formatted Message |
| [**SendPresenceSubscription**](XMPPApi.md#sendpresencesubscription) | **POST** /Agent/Xmpp/SendPresenceSubscription | Send Presence Subscription |
| [**SendPresenceUnsubscription**](XMPPApi.md#sendpresenceunsubscription) | **POST** /Agent/Xmpp/SendPresenceUnsubscription | Send Presence Unsubscription |
| [**SendSubscriptionAccepted**](XMPPApi.md#sendsubscriptionaccepted) | **POST** /Agent/Xmpp/SendSubscriptionAccepted | Send Subscription Accepted |
| [**SendSubscriptionDeclined**](XMPPApi.md#sendsubscriptiondeclined) | **POST** /Agent/Xmpp/SendSubscriptionDeclined | Send Subscription Declined |
| [**SendTextMessage**](XMPPApi.md#sendtextmessage) | **POST** /Agent/Xmpp/SendTextMessage | Send Text Message |
| [**SendXmlMessage**](XMPPApi.md#sendxmlmessage) | **POST** /Agent/Xmpp/SendXmlMessage | Send XML Message |
| [**SetRosterItem**](XMPPApi.md#setrosteritem) | **POST** /Agent/Xmpp/SetRosterItem | Set Roster Item |

<a id="getroster"></a>
# **GetRoster**
> GetRosterResponse GetRoster (GetRosterBody getRosterBody = null)

Get Roster

Allows the client to get the roster of its account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class GetRosterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new XMPPApi(config);
            var getRosterBody = new GetRosterBody(); // GetRosterBody |  (optional) 

            try
            {
                // Get Roster
                GetRosterResponse result = apiInstance.GetRoster(getRosterBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XMPPApi.GetRoster: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRosterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Roster
    ApiResponse<GetRosterResponse> response = apiInstance.GetRosterWithHttpInfo(getRosterBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling XMPPApi.GetRosterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getRosterBody** | [**GetRosterBody**](GetRosterBody.md) |  | [optional]  |

### Return type

[**GetRosterResponse**](GetRosterResponse.md)

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

<a id="getrosteritem"></a>
# **GetRosterItem**
> RosterItem GetRosterItem (GetRosterItemBody getRosterItemBody)

Get Roster Item

Allows the client to get a specific roster item of its account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class GetRosterItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new XMPPApi(config);
            var getRosterItemBody = new GetRosterItemBody(); // GetRosterItemBody | 

            try
            {
                // Get Roster Item
                RosterItem result = apiInstance.GetRosterItem(getRosterItemBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XMPPApi.GetRosterItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRosterItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Roster Item
    ApiResponse<RosterItem> response = apiInstance.GetRosterItemWithHttpInfo(getRosterItemBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling XMPPApi.GetRosterItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getRosterItemBody** | [**GetRosterItemBody**](GetRosterItemBody.md) |  |  |

### Return type

[**RosterItem**](RosterItem.md)

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

<a id="informationquery"></a>
# **InformationQuery**
> QueryResultJson InformationQuery (InformationQueryBody informationQueryBody)

Information Query

Sends an Information Query (iq) to an entity on the XMPP network, given its Full JID. For connected entities, you need to have an presence subscription to that entity, approved by the entity, to get the Full JID. You get the Full JID using the Presence Probe resource.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class InformationQueryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new XMPPApi(config);
            var informationQueryBody = new InformationQueryBody(); // InformationQueryBody | 

            try
            {
                // Information Query
                QueryResultJson result = apiInstance.InformationQuery(informationQueryBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XMPPApi.InformationQuery: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InformationQueryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Information Query
    ApiResponse<QueryResultJson> response = apiInstance.InformationQueryWithHttpInfo(informationQueryBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling XMPPApi.InformationQueryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **informationQueryBody** | [**InformationQueryBody**](InformationQueryBody.md) |  |  |

### Return type

[**QueryResultJson**](QueryResultJson.md)

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

<a id="popmessages"></a>
# **PopMessages**
> MessageResult PopMessages (PopMessagesBody popMessagesBody)

Pop Messages

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class PopMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new XMPPApi(config);
            var popMessagesBody = new PopMessagesBody(); // PopMessagesBody | 

            try
            {
                // Pop Messages
                MessageResult result = apiInstance.PopMessages(popMessagesBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XMPPApi.PopMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PopMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Pop Messages
    ApiResponse<MessageResult> response = apiInstance.PopMessagesWithHttpInfo(popMessagesBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling XMPPApi.PopMessagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **popMessagesBody** | [**PopMessagesBody**](PopMessagesBody.md) |  |  |

### Return type

[**MessageResult**](MessageResult.md)

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

<a id="presenceprobe"></a>
# **PresenceProbe**
> ProbeResult PresenceProbe (PresenceProbeBody presenceProbeBody)

Presence Probe

Gets the latest presence issued by a contact in your roster who has approved your presence subscription request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class PresenceProbeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new XMPPApi(config);
            var presenceProbeBody = new PresenceProbeBody(); // PresenceProbeBody | 

            try
            {
                // Presence Probe
                ProbeResult result = apiInstance.PresenceProbe(presenceProbeBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XMPPApi.PresenceProbe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PresenceProbeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Presence Probe
    ApiResponse<ProbeResult> response = apiInstance.PresenceProbeWithHttpInfo(presenceProbeBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling XMPPApi.PresenceProbeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **presenceProbeBody** | [**PresenceProbeBody**](PresenceProbeBody.md) |  |  |

### Return type

[**ProbeResult**](ProbeResult.md)

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

<a id="removerosteritem"></a>
# **RemoveRosterItem**
> RosterItem RemoveRosterItem (RemoveRosterItemBody removeRosterItemBody)

Remove Roster Item

Removes a specific roster item from the account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class RemoveRosterItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new XMPPApi(config);
            var removeRosterItemBody = new RemoveRosterItemBody(); // RemoveRosterItemBody | 

            try
            {
                // Remove Roster Item
                RosterItem result = apiInstance.RemoveRosterItem(removeRosterItemBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XMPPApi.RemoveRosterItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveRosterItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Roster Item
    ApiResponse<RosterItem> response = apiInstance.RemoveRosterItemWithHttpInfo(removeRosterItemBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling XMPPApi.RemoveRosterItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **removeRosterItemBody** | [**RemoveRosterItemBody**](RemoveRosterItemBody.md) |  |  |

### Return type

[**RosterItem**](RosterItem.md)

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

<a id="sendformattedmessage"></a>
# **SendFormattedMessage**
> StanzaResult SendFormattedMessage (SendFormattedMessage sendFormattedMessage)

Send Formatted Message

Allows the client to send a formatted chat message from its account to an XMPP recipient. A formatted message contains the message in plain text, Markdown and HTML. The recipient, depending on capabilities, will select the representation it handles best to present the message.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class SendFormattedMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new XMPPApi(config);
            var sendFormattedMessage = new SendFormattedMessage(); // SendFormattedMessage | 

            try
            {
                // Send Formatted Message
                StanzaResult result = apiInstance.SendFormattedMessage(sendFormattedMessage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XMPPApi.SendFormattedMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendFormattedMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send Formatted Message
    ApiResponse<StanzaResult> response = apiInstance.SendFormattedMessageWithHttpInfo(sendFormattedMessage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling XMPPApi.SendFormattedMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sendFormattedMessage** | [**SendFormattedMessage**](SendFormattedMessage.md) |  |  |

### Return type

[**StanzaResult**](StanzaResult.md)

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

<a id="sendpresencesubscription"></a>
# **SendPresenceSubscription**
> PresenceSubscriptionResult SendPresenceSubscription (SendPresenceSubscriptionBody sendPresenceSubscriptionBody)

Send Presence Subscription

Allows the client to send a presence subscription stanza from its account to an XMPP recipient.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class SendPresenceSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new XMPPApi(config);
            var sendPresenceSubscriptionBody = new SendPresenceSubscriptionBody(); // SendPresenceSubscriptionBody | 

            try
            {
                // Send Presence Subscription
                PresenceSubscriptionResult result = apiInstance.SendPresenceSubscription(sendPresenceSubscriptionBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XMPPApi.SendPresenceSubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendPresenceSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send Presence Subscription
    ApiResponse<PresenceSubscriptionResult> response = apiInstance.SendPresenceSubscriptionWithHttpInfo(sendPresenceSubscriptionBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling XMPPApi.SendPresenceSubscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sendPresenceSubscriptionBody** | [**SendPresenceSubscriptionBody**](SendPresenceSubscriptionBody.md) |  |  |

### Return type

[**PresenceSubscriptionResult**](PresenceSubscriptionResult.md)

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

<a id="sendpresenceunsubscription"></a>
# **SendPresenceUnsubscription**
> StanzaResult SendPresenceUnsubscription (SendPresenceUnsubscriptionBody sendPresenceUnsubscriptionBody)

Send Presence Unsubscription

Allows the client to send a presence unsubscription stanza from its account to an XMPP recipient.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class SendPresenceUnsubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new XMPPApi(config);
            var sendPresenceUnsubscriptionBody = new SendPresenceUnsubscriptionBody(); // SendPresenceUnsubscriptionBody | 

            try
            {
                // Send Presence Unsubscription
                StanzaResult result = apiInstance.SendPresenceUnsubscription(sendPresenceUnsubscriptionBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XMPPApi.SendPresenceUnsubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendPresenceUnsubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send Presence Unsubscription
    ApiResponse<StanzaResult> response = apiInstance.SendPresenceUnsubscriptionWithHttpInfo(sendPresenceUnsubscriptionBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling XMPPApi.SendPresenceUnsubscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sendPresenceUnsubscriptionBody** | [**SendPresenceUnsubscriptionBody**](SendPresenceUnsubscriptionBody.md) |  |  |

### Return type

[**StanzaResult**](StanzaResult.md)

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

<a id="sendsubscriptionaccepted"></a>
# **SendSubscriptionAccepted**
> SendSubscriptionAcceptedResponse SendSubscriptionAccepted (SendSubscriptionAcceptedBody sendSubscriptionAcceptedBody)

Send Subscription Accepted

Allows the client to accept a presence subscription made to its account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class SendSubscriptionAcceptedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new XMPPApi(config);
            var sendSubscriptionAcceptedBody = new SendSubscriptionAcceptedBody(); // SendSubscriptionAcceptedBody | 

            try
            {
                // Send Subscription Accepted
                SendSubscriptionAcceptedResponse result = apiInstance.SendSubscriptionAccepted(sendSubscriptionAcceptedBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XMPPApi.SendSubscriptionAccepted: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendSubscriptionAcceptedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send Subscription Accepted
    ApiResponse<SendSubscriptionAcceptedResponse> response = apiInstance.SendSubscriptionAcceptedWithHttpInfo(sendSubscriptionAcceptedBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling XMPPApi.SendSubscriptionAcceptedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sendSubscriptionAcceptedBody** | [**SendSubscriptionAcceptedBody**](SendSubscriptionAcceptedBody.md) |  |  |

### Return type

[**SendSubscriptionAcceptedResponse**](SendSubscriptionAcceptedResponse.md)

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

<a id="sendsubscriptiondeclined"></a>
# **SendSubscriptionDeclined**
> StanzaResult SendSubscriptionDeclined (SendSubscriptionDeclinedBody sendSubscriptionDeclinedBody)

Send Subscription Declined

Allows the client to decline a presence subscription made to its account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class SendSubscriptionDeclinedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new XMPPApi(config);
            var sendSubscriptionDeclinedBody = new SendSubscriptionDeclinedBody(); // SendSubscriptionDeclinedBody | 

            try
            {
                // Send Subscription Declined
                StanzaResult result = apiInstance.SendSubscriptionDeclined(sendSubscriptionDeclinedBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XMPPApi.SendSubscriptionDeclined: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendSubscriptionDeclinedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send Subscription Declined
    ApiResponse<StanzaResult> response = apiInstance.SendSubscriptionDeclinedWithHttpInfo(sendSubscriptionDeclinedBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling XMPPApi.SendSubscriptionDeclinedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sendSubscriptionDeclinedBody** | [**SendSubscriptionDeclinedBody**](SendSubscriptionDeclinedBody.md) |  |  |

### Return type

[**StanzaResult**](StanzaResult.md)

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

<a id="sendtextmessage"></a>
# **SendTextMessage**
> StanzaResult SendTextMessage (SendTextMessageBody sendTextMessageBody)

Send Text Message

Allows the client to send a plain text chat message from its account to an XMPP recipient.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class SendTextMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new XMPPApi(config);
            var sendTextMessageBody = new SendTextMessageBody(); // SendTextMessageBody | 

            try
            {
                // Send Text Message
                StanzaResult result = apiInstance.SendTextMessage(sendTextMessageBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XMPPApi.SendTextMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendTextMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send Text Message
    ApiResponse<StanzaResult> response = apiInstance.SendTextMessageWithHttpInfo(sendTextMessageBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling XMPPApi.SendTextMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sendTextMessageBody** | [**SendTextMessageBody**](SendTextMessageBody.md) |  |  |

### Return type

[**StanzaResult**](StanzaResult.md)

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

<a id="sendxmlmessage"></a>
# **SendXmlMessage**
> StanzaResult SendXmlMessage (SendXmlMessage sendXmlMessage)

Send XML Message

Allows the client to send a custom XML normal message from its account to an XMPP recipient.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class SendXmlMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new XMPPApi(config);
            var sendXmlMessage = new SendXmlMessage(); // SendXmlMessage | 

            try
            {
                // Send XML Message
                StanzaResult result = apiInstance.SendXmlMessage(sendXmlMessage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XMPPApi.SendXmlMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendXmlMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send XML Message
    ApiResponse<StanzaResult> response = apiInstance.SendXmlMessageWithHttpInfo(sendXmlMessage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling XMPPApi.SendXmlMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sendXmlMessage** | [**SendXmlMessage**](SendXmlMessage.md) |  |  |

### Return type

[**StanzaResult**](StanzaResult.md)

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

<a id="setrosteritem"></a>
# **SetRosterItem**
> RosterItem SetRosterItem (SetRosterItemBody setRosterItemBody)

Set Roster Item

Sets information about a specific roster item for the account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace Example
{
    public class SetRosterItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost";
            // Configure Bearer token for authorization: BearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new XMPPApi(config);
            var setRosterItemBody = new SetRosterItemBody(); // SetRosterItemBody | 

            try
            {
                // Set Roster Item
                RosterItem result = apiInstance.SetRosterItem(setRosterItemBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XMPPApi.SetRosterItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetRosterItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set Roster Item
    ApiResponse<RosterItem> response = apiInstance.SetRosterItemWithHttpInfo(setRosterItemBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling XMPPApi.SetRosterItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **setRosterItemBody** | [**SetRosterItemBody**](SetRosterItemBody.md) |  |  |

### Return type

[**RosterItem**](RosterItem.md)

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


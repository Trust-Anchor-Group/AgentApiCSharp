# TAG.Networking.Agent.Model.CreateAccountBody

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserName** | **string** | The user&#39;s name. | 
**EMail** | **string** | The user&#39;s email address. | 
**Password** | **string** | The user&#39;s password. | 
**ApiKey** | **string** | The API key used for identification. | 
**Nonce** | **string** | A unique nonce for this request. | 
**Signature** | **string** | The HMAC-SHA256 signature of the request. See the endpoint description for how to calculate the signature.  | 
**Seconds** | **int** | The number of seconds until the request expires. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


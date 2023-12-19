# Neuron.Agent.Model.LoginBody

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserName** | **string** | The user name of the account. | 
**Nonce** | **string** | A unique random string, at least 32 characters long, with sufficient entropy to not be reused again. | 
**Signature** | **string** | The HMAC-SHA256 signature of the request. See the endpoint description for how to calculate the signature.  | 
**Seconds** | **int** | The number of seconds until the request expires. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


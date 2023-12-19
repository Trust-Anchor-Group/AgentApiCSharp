# Neuron.Agent.Model.SignDataBody

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**KeyId** | **string** | Identity of key to use for signing the data. | 
**LegalId** | **string** | Identity of the Legal Identity that will be used to sign the data. | 
**DataBase64** | **string** | Base64-encoded binary data to sign. | 
**KeySignature** | **string** | Cryptographic signature of the key ID, using the key password.  | 
**RequestSignature** | **string** | Cryptographic signature of the request, using the account password.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


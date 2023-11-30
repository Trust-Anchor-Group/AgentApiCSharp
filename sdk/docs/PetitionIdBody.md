# TAG.Networking.Agent.Model.PetitionIdBody

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**KeyId** | **string** | Identity of key to use for signing the petition. It must correspond to the key used when signing the Legal Identity application that will be used to sign the petition. | 
**LegalId** | **string** | Identifier of the Legal Identity that will be used to sign the petition. | 
**RemoteId** | **string** | Identifier of the remote legal identity the client requests access to. | 
**PetitionId** | **string** | An identifier of the request, the client can use to correlate asynchronous responses with the corresponding petition request. | 
**Purpose** | **string** | A human readable text that will be presented to the remote user, describing the purpose of the petition. | 
**KeySignature** | **string** | Cryptographic signature of the key ID, using the key password.  | 
**RequestSignature** | **string** | Cryptographic signature of the request, using the account password.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


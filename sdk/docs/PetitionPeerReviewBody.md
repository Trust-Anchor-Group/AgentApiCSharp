# TAG.Networking.Agent.Model.PetitionPeerReviewBody

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**KeyId** | **string** | Identity of key to use for signing the petition. It must correspond to the key used when signing the Legal Identity application that will be used to sign the petition. | 
**LegalId** | **string** | Identifier of the Legal Identity that will be used to sign the petition, and that will be reviewed by the peer. | 
**RemoteId** | **string** | Identifier of the remote legal identity the client requests review the identity application. | 
**PetitionId** | **string** | An identifier of the request, the client can use to correlate asynchronous responses with the corresponding petition request. | 
**Purpose** | **string** | A human readable text that will be presented to the remote user, describing the purpose of the petition. | 
**KeySignature** | **string** | Cryptographic signature of the key ID, using the key password.  | 
**RequestSignature** | **string** | Cryptographic signature of the request, using the account password.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


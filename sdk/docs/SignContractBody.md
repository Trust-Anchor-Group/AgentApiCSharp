# Neuron.Agent.Model.SignContractBody

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**KeyId** | **string** | Identity of key to use for signing the contract. | 
**LegalId** | **string** | Identity of the Legal Identity that will be used to sign the contract. | 
**ContractId** | **string** | Identity of contract to sign. | 
**Role** | **string** | Role of a predefined part to the contract. | 
**Nonce** | **string** | A unique random string, at least 32 characters long, with sufficient entropy to not be reused again. If reused, an error will be returned. | 
**KeySignature** | **string** | Cryptographic signature of the key ID, using the key password.  | 
**RequestSignature** | **string** | Cryptographic signature of the request, using the account password.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


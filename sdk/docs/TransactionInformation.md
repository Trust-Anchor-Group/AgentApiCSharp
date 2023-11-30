# TAG.Networking.Agent.Model.TransactionInformation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Transaction ID. | 
**State** | **string** | Current state of transaction. | 
**Started** | **DateTime** | When the transaction was started. | 
**Ended** | **DateTime** | When the transaction ended. | 
**ServiceId** | **string** | ID of internal eDaler service. | 
**ServiceProvider** | **string** | Type (class name) of service provider. | 
**Amount** | **double** | Amount of eDaler to buy. | 
**Currency** | **string** | Currency to buy. | 
**SuccessUrl** | **string** | URL to redirect to if the operation is successful. | 
**FailureUrl** | **string** | URL to redirect to if the operation fails. | 
**CancelUrl** | **string** | URL to redirect to if the operation is cancelled. | 
**ClientUrl** | **string** | URL to redirect to if the operation is cancelled. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# ARXivarNEXT.Client.Model.QueueAggregationStatusInfoDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WorkingProgress** | **int?** |  | [optional] 
**QueueStatus** | **int?** | Possible values:  0: CompletedOk  1: CompletedPartialOk  2: CompletedKo  3: Deleted  4: Processing  5: Enqueued  6: Waiting  7: Failed  | [optional] 
**IsCompleted** | **bool?** |  | [optional] 
**QueueId** | **string** | Queue Identifier | [optional] 
**QueueName** | **string** | Queue Name | [optional] 
**QueueType** | **string** | Queue Type | [optional] 
**CreatedAt** | **DateTime?** | Creation Date | [optional] 
**ExpireAt** | **DateTime?** | Expiration Date | [optional] 
**WorkItemCount** | **int?** | Items | [optional] 
**StateCount** | [**QueueStateAggregationInfoDto**](QueueStateAggregationInfoDto.md) | Status of items | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# ARXivarNEXT.Client.Model.ViewEditDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Identifier | [optional] 
**Description** | **string** |  | [optional] 
**User** | **int?** | User Identifier | [optional] 
**UserCompleteName** | **string** | User Description | [optional] 
**DocumentType** | **int?** | Document Type Identifier for first level | [optional] 
**Type2** | **int?** | Document Type Identifier for second level | [optional] 
**Type3** | **int?** | Document Type Identifier for third level | [optional] 
**SelectFields** | [**SelectDTO**](SelectDTO.md) | Lista dei campi da visualizzare nel risultato di ricerca. | [optional] 
**EditFields** | [**SearchDTO**](SearchDTO.md) | List of edit fields | [optional] 
**LockFields** | [**SearchDTO**](SearchDTO.md) | List of lock fields | [optional] 
**ShowFields** | **bool?** | Mode of show fields | [optional] 
**FormOpen** | **bool?** | Mode of show search form | [optional] 
**AllowEmptyFilterMode** | **int?** | Possible values:  0: Yes  1: No  2: OnDemand  | [optional] 
**ShowGroupsMode** | **int?** | Possible values:  0: No  1: Yes  | [optional] 
**CanExecute** | **bool?** | Can Search | [optional] 
**CanUpdate** | **bool?** | Can Update | [optional] 
**CanDelete** | **bool?** | Can Delete | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


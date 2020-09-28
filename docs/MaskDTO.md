# ARXivarNEXT.Client.Model.MaskDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Identifier | [optional] 
**MaskName** | **string** | Name | [optional] 
**MaskDescription** | **string** | Description | [optional] 
**PredefinedProfileId** | **int?** | Predefined Profile Identifier | [optional] 
**User** | **int?** | Author Identifier | [optional] 
**ExternalId** | **string** | External Identifier | [optional] 
**IsRoot** | **bool?** | Root | [optional] 
**Type** | **int?** | Possible values:  0: Nothing  1: Barcode  2: Archiviazione  | [optional] 
**PaMode** | **int?** | Possible values:  0: None  1: OnlyNever  2: OnlyOptionally  3: NeverOrOptionally  4: OnlyAlways  5: AlwaysOrNever  6: AlwaysOrOptionally  7: All  | [optional] 
**ShowAdditional** | **bool?** | Show Additional | [optional] 
**Kind** | **int?** | Possible values:  0: UserMask  1: SystemMask  | [optional] 
**ShowGroups** | **bool?** | Show Groups | [optional] 
**UserCompleteName** | **string** | Author Complete Name | [optional] 
**PredefinedProfile** | [**PredefinedProfileDTO**](PredefinedProfileDTO.md) | Predefined Profile associated with the mask | [optional] 
**MaskDetails** | [**List&lt;MaskDetailDTO&gt;**](MaskDetailDTO.md) | Details | [optional] 
**MaskClassOptions** | [**List&lt;MaskClassOptionsDTO&gt;**](MaskClassOptionsDTO.md) | Options on document type | [optional] 
**UseAdvancedTool** | **bool?** | This option indicates if the mask use new features for ARXivar Next Portal | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


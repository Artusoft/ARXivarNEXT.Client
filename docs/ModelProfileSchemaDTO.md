# ARXivarNEXT.Client.Model.ModelProfileSchemaDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ModelId** | **int?** | Template Identifier | [optional] 
**ModelDescription** | **string** | Description | [optional] 
**Options** | [**ProfileMaskOptionsDTO**](ProfileMaskOptionsDTO.md) | Options | [optional] 
**Behaviour** | [**ProfileMaskBehaviourDTO**](ProfileMaskBehaviourDTO.md) | Behaviour | [optional] 
**OpenModelAfterProfilation** | **bool?** | Open file after profiling. | [optional] 
**EditModelAfterProfilation** | **bool?** | Editing file after profiling. | [optional] 
**MaskId** | **string** | Mask Identifier | [optional] 
**ShowOption** | **int?** | Possible values:  0: EmptyProfile  1: PredefinedProfile  2: Mask  | [optional] 
**Id** | **int?** | Identifier | [optional] 
**Document** | [**FileDTO**](FileDTO.md) | File data | [optional] 
**Fields** | [**List&lt;FieldBaseDTO&gt;**](FieldBaseDTO.md) | Fields | [optional] 
**PostProfilationActions** | [**List&lt;PostProfilationActionDTO&gt;**](PostProfilationActionDTO.md) | Post Profilation Actions | [optional] 
**ConstrainRoleBehaviour** | **int?** | Possible values:  0: None  1: ForceInsert  2: State  | [optional] 
**Attachments** | **List&lt;string&gt;** | Attachments | [optional] 
**Notes** | [**List&lt;NoteDTO&gt;**](NoteDTO.md) | Notes | [optional] 
**PaNotes** | **List&lt;string&gt;** | Public Amministration Notes | [optional] 
**AuthorityData** | [**AuthorityDataDTO**](AuthorityDataDTO.md) | Authority Data | [optional] 
**GeneratePaProtocol** | **bool?** | Defines if a protocol has been generated | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


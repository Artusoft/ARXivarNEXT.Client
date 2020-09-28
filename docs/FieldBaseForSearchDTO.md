# ARXivarNEXT.Client.Model.FieldBaseForSearchDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupId** | **int?** | Group Identifier | [optional] 
**FieldType** | **int?** | Possible values:  0: Standard  1: Group  2: Additional  | [optional] 
**AdditionalFieldType** | **int?** | Possible values:  0: Textbox  1: Databox  2: Numeric  3: Combobox  4: TableBox  5: Checkbox  6: MultiValue  7: ClasseBox  8: Group  9: RubricaBox  10: TextArea  | [optional] 
**DefaultOperator** | **int?** | Default Operator | [optional] 
**TableName** | **string** | Table name | [optional] 
**BinderFieldId** | **int?** | Binder Identifier | [optional] 
**Multiple** | **string** | Multiple values | [optional] 
**Name** | **string** | Name | [optional] 
**ExternalId** | **string** | External identifier | [optional] 
**Description** | **string** | Label | [optional] 
**Order** | **int?** | Order | [optional] 
**DataSource** | **string** | DataSource identifier | [optional] 
**Required** | **bool?** | Required | [optional] 
**Formula** | **string** | Formula | [optional] 
**ClassName** | **string** | Name of class | 
**Locked** | **bool?** | Locked in read-only | [optional] 
**ComboGruppiId** | **string** | Data Group Identifier | [optional] 
**DependencyFields** | [**List&lt;DependencyFieldItem&gt;**](DependencyFieldItem.md) | List of dependent fields | [optional] 
**Associations** | **Dictionary&lt;string, string&gt;** | Associated fields | [optional] 
**IsAdditional** | **bool?** | Field type additional | [optional] 
**Visible** | **bool?** | Visible | [optional] 
**PredefinedProfileFormula** | **string** | Formula in the context of predefined profile | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


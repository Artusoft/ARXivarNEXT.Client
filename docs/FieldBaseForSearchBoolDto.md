# ARXivarNEXT.Client.Model.FieldBaseForSearchBoolDto
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
**Operator** | **int?** | Possible values:  0: Non_Impostato  1: Minore  2: Minore_Uguale  3: Uguale  4: Maggiore_Uguale  5: Maggiore  6: Diverso  7: Compreso  8: Nullo  9: Non_Nullo  10: Nullo_o_Zero  11: Non_Nullo_e_Non_Zero  12: Escluso  | [optional] 
**Valore1** | **bool?** | The value of this field | [optional] 
**Valore2** | **bool?** | The second value for this field (used only for some operator) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


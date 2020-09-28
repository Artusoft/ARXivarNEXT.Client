# ARXivarNEXT.Client.Model.AdditionalFieldConfigurationComboDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
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
**Associations** | [**List&lt;AssocitationFieldItem&gt;**](AssocitationFieldItem.md) | Associated fields | [optional] 
**IsAdditional** | **bool?** | Field type additional | [optional] 
**Visible** | **bool?** | Visible | [optional] 
**PredefinedProfileFormula** | **string** | Formula in the context of predefined profile | [optional] 
**VisibilityCondition** | **string** | The visibility condition formula for this mask field | [optional] 
**AddressBookDefaultFilter** | **int?** | The preferred address book for search contacts for this field | [optional] 
**EnabledAddressBook** | **List&lt;int?&gt;** | Possible addressbook for selection for this field | [optional] 
**Columns** | **int?** | Number of display columns for the field | [optional] 
**LimitToList** | **bool?** | Possible values ​​limited to the list | [optional] 
**Values** | **List&lt;string&gt;** | List of possible fields | [optional] 
**DisplayValue** | **string** | Value to display | [optional] 
**Value** | **string** | Value | [optional] 
**NumMaxChar** | **int?** | Maximum number of characters | [optional] 
**NumRows** | **int?** | Maximum number of rows | [optional] 
**AdditionalFieldType** | **int?** | Possible values:  0: Textbox  1: Databox  2: Numeric  3: Combobox  4: TableBox  5: Checkbox  6: MultiValue  7: ClasseBox  8: Group  9: RubricaBox  10: TextArea  | [optional] 
**GroupId** | **int?** | Group Identifier | [optional] 
**BinderFieldId** | **int?** | Binder Field Identifier | [optional] 
**TaskWorkVariableId** | **int?** | Variable Identifier in taskword context | [optional] 
**ValidationType** | **int?** | Possible values:  0: None  1: Regex  2: Formula  | [optional] 
**ValidationString** | **string** | Validation string (regex or formula) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


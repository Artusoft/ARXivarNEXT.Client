# ARXivarNEXT.Client.Api.ProcessVariablesApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProcessVariablesGetFieldValuesByProcessVariable**](ProcessVariablesApi.md#processvariablesgetfieldvaluesbyprocessvariable) | **POST** /api/ProcessVariables/{processVariableId}/getDatasourceValues | This call returns the possibile values for a process variable in format list or table.
[**ProcessVariablesGetFiltersByProcessVariables**](ProcessVariablesApi.md#processvariablesgetfiltersbyprocessvariables) | **POST** /api/ProcessVariables/{processVariableId}/getFilters | This call returns the filter field associated woth a process variable
[**ProcessVariablesSetProcessVariableValue**](ProcessVariablesApi.md#processvariablessetprocessvariablevalue) | **PUT** /api/ProcessVariables/{processId}/setValues | This call inserts the variables associated with the process
[**ProcessVariablesValidateVariabile**](ProcessVariablesApi.md#processvariablesvalidatevariabile) | **POST** /api/ProcessVariables/process/{processId}/validation | Validate the variable data update of a specific variable


<a name="processvariablesgetfieldvaluesbyprocessvariable"></a>
# **ProcessVariablesGetFieldValuesByProcessVariable**
> FieldValuesDTO ProcessVariablesGetFieldValuesByProcessVariable (int? processVariableId, VariablesValuesCriteriaDTO processVariables)

This call returns the possibile values for a process variable in format list or table.

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProcessVariablesGetFieldValuesByProcessVariableExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProcessVariablesApi();
            var processVariableId = 56;  // int? | Process variable identifier
            var processVariables = new VariablesValuesCriteriaDTO(); // VariablesValuesCriteriaDTO | Actual values of the process variables (for value dependant query)

            try
            {
                // This call returns the possibile values for a process variable in format list or table.
                FieldValuesDTO result = apiInstance.ProcessVariablesGetFieldValuesByProcessVariable(processVariableId, processVariables);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessVariablesApi.ProcessVariablesGetFieldValuesByProcessVariable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processVariableId** | **int?**| Process variable identifier | 
 **processVariables** | [**VariablesValuesCriteriaDTO**](VariablesValuesCriteriaDTO.md)| Actual values of the process variables (for value dependant query) | 

### Return type

[**FieldValuesDTO**](FieldValuesDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processvariablesgetfiltersbyprocessvariables"></a>
# **ProcessVariablesGetFiltersByProcessVariables**
> FieldFilterConcreteDTO ProcessVariablesGetFiltersByProcessVariables (int? processVariableId, ProcessVariablesFieldsDTO processVariables)

This call returns the filter field associated woth a process variable

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProcessVariablesGetFiltersByProcessVariablesExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProcessVariablesApi();
            var processVariableId = 56;  // int? | Process variable identifier
            var processVariables = new ProcessVariablesFieldsDTO(); // ProcessVariablesFieldsDTO | Variable fields information

            try
            {
                // This call returns the filter field associated woth a process variable
                FieldFilterConcreteDTO result = apiInstance.ProcessVariablesGetFiltersByProcessVariables(processVariableId, processVariables);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessVariablesApi.ProcessVariablesGetFiltersByProcessVariables: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processVariableId** | **int?**| Process variable identifier | 
 **processVariables** | [**ProcessVariablesFieldsDTO**](ProcessVariablesFieldsDTO.md)| Variable fields information | 

### Return type

[**FieldFilterConcreteDTO**](FieldFilterConcreteDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processvariablessetprocessvariablevalue"></a>
# **ProcessVariablesSetProcessVariableValue**
> void ProcessVariablesSetProcessVariableValue (int? processId, ProcessVariablesFieldsDTO processVariables)

This call inserts the variables associated with the process

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProcessVariablesSetProcessVariableValueExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProcessVariablesApi();
            var processId = 56;  // int? | Process Identifier
            var processVariables = new ProcessVariablesFieldsDTO(); // ProcessVariablesFieldsDTO | Variables information

            try
            {
                // This call inserts the variables associated with the process
                apiInstance.ProcessVariablesSetProcessVariableValue(processId, processVariables);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessVariablesApi.ProcessVariablesSetProcessVariableValue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **int?**| Process Identifier | 
 **processVariables** | [**ProcessVariablesFieldsDTO**](ProcessVariablesFieldsDTO.md)| Variables information | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processvariablesvalidatevariabile"></a>
# **ProcessVariablesValidateVariabile**
> ValidationFieldResultDTO ProcessVariablesValidateVariabile (int? processId, ProcessVariableValidationDTO validationData)

Validate the variable data update of a specific variable

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProcessVariablesValidateVariabileExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProcessVariablesApi();
            var processId = 56;  // int? | The process instance id
            var validationData = new ProcessVariableValidationDTO(); // ProcessVariableValidationDTO | The validation data

            try
            {
                // Validate the variable data update of a specific variable
                ValidationFieldResultDTO result = apiInstance.ProcessVariablesValidateVariabile(processId, validationData);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessVariablesApi.ProcessVariablesValidateVariabile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **int?**| The process instance id | 
 **validationData** | [**ProcessVariableValidationDTO**](ProcessVariableValidationDTO.md)| The validation data | 

### Return type

[**ValidationFieldResultDTO**](ValidationFieldResultDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


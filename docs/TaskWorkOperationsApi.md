# ARXivarNEXT.Client.Api.TaskWorkOperationsApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TaskWorkOperationsExecuteSignOperation**](TaskWorkOperationsApi.md#taskworkoperationsexecutesignoperation) | **POST** /api/TaskOperations/ExecuteSignOperation | 
[**TaskWorkOperationsGetByTaskWorkId**](TaskWorkOperationsApi.md#taskworkoperationsgetbytaskworkid) | **GET** /api/TaskOperations/byTaskWork/{taskWorkId} | This call returns all the operations in a task work
[**TaskWorkOperationsGetDocumentForSignOperation**](TaskWorkOperationsApi.md#taskworkoperationsgetdocumentforsignoperation) | **GET** /api/TaskOperations/{taskWorkId}/signOperationInfo/{signOperationId} | 
[**TaskWorkOperationsGetDynamicJobOperationsByExitCodeAndTaskWorkIds**](TaskWorkOperationsApi.md#taskworkoperationsgetdynamicjoboperationsbyexitcodeandtaskworkids) | **POST** /api/TaskOperations/getdynamicjoboperations/exitcode | This call returns the dynamic job operation to execute for a taskwork list close action by an exit code
[**TaskWorkOperationsGetFieldValuesByProcessVariable**](TaskWorkOperationsApi.md#taskworkoperationsgetfieldvaluesbyprocessvariable) | **POST** /api/TaskOperations/{taskWorkId}/processvariable/{processVariableId}/getValues | This call returns the possibile values for a process variable (combo or table)
[**TaskWorkOperationsGetFiltersByProcessVariables**](TaskWorkOperationsApi.md#taskworkoperationsgetfiltersbyprocessvariables) | **POST** /api/TaskOperations/processvariable/{processVariableId}/getFilters | This call returns the possibile filters for a table process variable
[**TaskWorkOperationsGetProfessionalRoleByTaskIds**](TaskWorkOperationsApi.md#taskworkoperationsgetprofessionalrolebytaskids) | **POST** /api/TaskOperations/professionalroleoperation | This call returns all professional role operations by multiple TaskWork
[**TaskWorkOperationsGetProfessionalRoleOperationsByExitCodeAndTaskWorkIds**](TaskWorkOperationsApi.md#taskworkoperationsgetprofessionalroleoperationsbyexitcodeandtaskworkids) | **POST** /api/TaskOperations/getprofessionalroleoperations/exitcode | This call returns the professional role operation to execute for a taskwork list close action by an exit code
[**TaskWorkOperationsGetSelectedUsersForDynamicJob**](TaskWorkOperationsApi.md#taskworkoperationsgetselectedusersfordynamicjob) | **GET** /api/TaskOperations/dynamicjob/{dynamicJobUser}/byprocessid/{processId} | This call returns the selected users list for a dynamic job in a process
[**TaskWorkOperationsGetUsersForDynamicJob**](TaskWorkOperationsApi.md#taskworkoperationsgetusersfordynamicjob) | **GET** /api/TaskOperations/dynamicjobusers | This call returns al possibile user for a dynamic job attribution
[**TaskWorkOperationsGetUsersForProfessionalRoleSelection**](TaskWorkOperationsApi.md#taskworkoperationsgetusersforprofessionalroleselection) | **GET** /api/TaskOperations/professionalroleoperation/{professionalRoleId}/usersbytaskwork/{taskWorkId} | This call returns the professional role possibile users for a professional role operation
[**TaskWorkOperationsSetDynamicJob**](TaskWorkOperationsApi.md#taskworkoperationssetdynamicjob) | **PUT** /api/TaskOperations/dynamicjob/{dynamicJobId}/taskwork/{taskWorkId} | This call sets the users for a process dynamic job
[**TaskWorkOperationsSetDynamicJobMultiple**](TaskWorkOperationsApi.md#taskworkoperationssetdynamicjobmultiple) | **PUT** /api/TaskOperations/dynamicjobmultiple | This call sets the users for multiple process dynamic job
[**TaskWorkOperationsSetProcessVariableValueByTaskWorkId**](TaskWorkOperationsApi.md#taskworkoperationssetprocessvariablevaluebytaskworkid) | **POST** /api/TaskOperations/{taskWorkId}/setprocessvariables | This call sets the values for the process variables
[**TaskWorkOperationsSetProfessionalRoleByTaskIds**](TaskWorkOperationsApi.md#taskworkoperationssetprofessionalrolebytaskids) | **PUT** /api/TaskOperations/professionalroleoperation/{professionalRoleId}/{userToAssignId} | This call sets the professional roles users for multiple TaskWork Ids
[**TaskWorkOperationsSetUsersForProfessionalRoleSelection**](TaskWorkOperationsApi.md#taskworkoperationssetusersforprofessionalroleselection) | **PUT** /api/TaskOperations/professionalroleoperation/{professionalRoleId}/setuserbytaskwork/{taskWorkId}/{userId} | This call sets the user for a professional role operation
[**TaskWorkOperationsTaskWorkCommandExecute**](TaskWorkOperationsApi.md#taskworkoperationstaskworkcommandexecute) | **PUT** /api/TaskOperations/{taskWorkId}/taskworkcommand/{taskWorkCommandId}/execute | this call executes a command task operation
[**TaskWorkOperationsUnSetProfessionalRoleSelection**](TaskWorkOperationsApi.md#taskworkoperationsunsetprofessionalroleselection) | **DELETE** /api/TaskOperations/professionalroleoperation/{professionalRoleId}/bytaskwork/{taskWorkId} | This call deletes the professional role actual value
[**TaskWorkOperationsValidateVariabile**](TaskWorkOperationsApi.md#taskworkoperationsvalidatevariabile) | **POST** /api/TaskOperations/{taskWorkId}/validation | 


<a name="taskworkoperationsexecutesignoperation"></a>
# **TaskWorkOperationsExecuteSignOperation**
> void TaskWorkOperationsExecuteSignOperation (TaskWorkSignOperationRequestDTO request)



### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkOperationsExecuteSignOperationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkOperationsApi();
            var request = new TaskWorkSignOperationRequestDTO(); // TaskWorkSignOperationRequestDTO | 

            try
            {
                apiInstance.TaskWorkOperationsExecuteSignOperation(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkOperationsApi.TaskWorkOperationsExecuteSignOperation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**TaskWorkSignOperationRequestDTO**](TaskWorkSignOperationRequestDTO.md)|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkoperationsgetbytaskworkid"></a>
# **TaskWorkOperationsGetByTaskWorkId**
> TaskWorkOperationsDTO TaskWorkOperationsGetByTaskWorkId (int? taskWorkId)

This call returns all the operations in a task work

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkOperationsGetByTaskWorkIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkOperationsApi();
            var taskWorkId = 56;  // int? | Taskwork identifier

            try
            {
                // This call returns all the operations in a task work
                TaskWorkOperationsDTO result = apiInstance.TaskWorkOperationsGetByTaskWorkId(taskWorkId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkOperationsApi.TaskWorkOperationsGetByTaskWorkId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskWorkId** | **int?**| Taskwork identifier | 

### Return type

[**TaskWorkOperationsDTO**](TaskWorkOperationsDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkoperationsgetdocumentforsignoperation"></a>
# **TaskWorkOperationsGetDocumentForSignOperation**
> List<SignDocumentDataDTO> TaskWorkOperationsGetDocumentForSignOperation (int? taskWorkId, int? signOperationId)



### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkOperationsGetDocumentForSignOperationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkOperationsApi();
            var taskWorkId = 56;  // int? | 
            var signOperationId = 56;  // int? | 

            try
            {
                List&lt;SignDocumentDataDTO&gt; result = apiInstance.TaskWorkOperationsGetDocumentForSignOperation(taskWorkId, signOperationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkOperationsApi.TaskWorkOperationsGetDocumentForSignOperation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskWorkId** | **int?**|  | 
 **signOperationId** | **int?**|  | 

### Return type

[**List<SignDocumentDataDTO>**](SignDocumentDataDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkoperationsgetdynamicjoboperationsbyexitcodeandtaskworkids"></a>
# **TaskWorkOperationsGetDynamicJobOperationsByExitCodeAndTaskWorkIds**
> List<TaskWorkDynamicJobOperationDTO> TaskWorkOperationsGetDynamicJobOperationsByExitCodeAndTaskWorkIds (TaskExitCodeDTO taskExitCode)

This call returns the dynamic job operation to execute for a taskwork list close action by an exit code

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkOperationsGetDynamicJobOperationsByExitCodeAndTaskWorkIdsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkOperationsApi();
            var taskExitCode = new TaskExitCodeDTO(); // TaskExitCodeDTO | exit code for close action

            try
            {
                // This call returns the dynamic job operation to execute for a taskwork list close action by an exit code
                List&lt;TaskWorkDynamicJobOperationDTO&gt; result = apiInstance.TaskWorkOperationsGetDynamicJobOperationsByExitCodeAndTaskWorkIds(taskExitCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkOperationsApi.TaskWorkOperationsGetDynamicJobOperationsByExitCodeAndTaskWorkIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskExitCode** | [**TaskExitCodeDTO**](TaskExitCodeDTO.md)| exit code for close action | 

### Return type

[**List<TaskWorkDynamicJobOperationDTO>**](TaskWorkDynamicJobOperationDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkoperationsgetfieldvaluesbyprocessvariable"></a>
# **TaskWorkOperationsGetFieldValuesByProcessVariable**
> FieldValuesDTO TaskWorkOperationsGetFieldValuesByProcessVariable (int? processVariableId, int? taskWorkId, VariablesValuesCriteriaDTO processVariables)

This call returns the possibile values for a process variable (combo or table)

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkOperationsGetFieldValuesByProcessVariableExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkOperationsApi();
            var processVariableId = 56;  // int? | Id of the process variable
            var taskWorkId = 56;  // int? | Id of the task work
            var processVariables = new VariablesValuesCriteriaDTO(); // VariablesValuesCriteriaDTO | Actual values of the process variables (for value dependant query)

            try
            {
                // This call returns the possibile values for a process variable (combo or table)
                FieldValuesDTO result = apiInstance.TaskWorkOperationsGetFieldValuesByProcessVariable(processVariableId, taskWorkId, processVariables);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkOperationsApi.TaskWorkOperationsGetFieldValuesByProcessVariable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processVariableId** | **int?**| Id of the process variable | 
 **taskWorkId** | **int?**| Id of the task work | 
 **processVariables** | [**VariablesValuesCriteriaDTO**](VariablesValuesCriteriaDTO.md)| Actual values of the process variables (for value dependant query) | 

### Return type

[**FieldValuesDTO**](FieldValuesDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkoperationsgetfiltersbyprocessvariables"></a>
# **TaskWorkOperationsGetFiltersByProcessVariables**
> FieldFilterConcreteDTO TaskWorkOperationsGetFiltersByProcessVariables (int? processVariableId, ProcessVariablesFieldsDTO processVariables)

This call returns the possibile filters for a table process variable

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkOperationsGetFiltersByProcessVariablesExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkOperationsApi();
            var processVariableId = 56;  // int? | Id of the process variable
            var processVariables = new ProcessVariablesFieldsDTO(); // ProcessVariablesFieldsDTO | Actual values of the process variables (for value dependant query)

            try
            {
                // This call returns the possibile filters for a table process variable
                FieldFilterConcreteDTO result = apiInstance.TaskWorkOperationsGetFiltersByProcessVariables(processVariableId, processVariables);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkOperationsApi.TaskWorkOperationsGetFiltersByProcessVariables: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processVariableId** | **int?**| Id of the process variable | 
 **processVariables** | [**ProcessVariablesFieldsDTO**](ProcessVariablesFieldsDTO.md)| Actual values of the process variables (for value dependant query) | 

### Return type

[**FieldFilterConcreteDTO**](FieldFilterConcreteDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkoperationsgetprofessionalrolebytaskids"></a>
# **TaskWorkOperationsGetProfessionalRoleByTaskIds**
> List<ProfessionalRoleOperationDTO> TaskWorkOperationsGetProfessionalRoleByTaskIds (List<int?> taskWorkIds)

This call returns all professional role operations by multiple TaskWork

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkOperationsGetProfessionalRoleByTaskIdsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkOperationsApi();
            var taskWorkIds = ;  // List<int?> | Ids of the TaskWorks

            try
            {
                // This call returns all professional role operations by multiple TaskWork
                List&lt;ProfessionalRoleOperationDTO&gt; result = apiInstance.TaskWorkOperationsGetProfessionalRoleByTaskIds(taskWorkIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkOperationsApi.TaskWorkOperationsGetProfessionalRoleByTaskIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskWorkIds** | **List&lt;int?&gt;**| Ids of the TaskWorks | 

### Return type

[**List<ProfessionalRoleOperationDTO>**](ProfessionalRoleOperationDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkoperationsgetprofessionalroleoperationsbyexitcodeandtaskworkids"></a>
# **TaskWorkOperationsGetProfessionalRoleOperationsByExitCodeAndTaskWorkIds**
> List<ProfessionalRoleOperationDTO> TaskWorkOperationsGetProfessionalRoleOperationsByExitCodeAndTaskWorkIds (TaskExitCodeDTO taskExitCode)

This call returns the professional role operation to execute for a taskwork list close action by an exit code

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkOperationsGetProfessionalRoleOperationsByExitCodeAndTaskWorkIdsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkOperationsApi();
            var taskExitCode = new TaskExitCodeDTO(); // TaskExitCodeDTO | exit code for close action

            try
            {
                // This call returns the professional role operation to execute for a taskwork list close action by an exit code
                List&lt;ProfessionalRoleOperationDTO&gt; result = apiInstance.TaskWorkOperationsGetProfessionalRoleOperationsByExitCodeAndTaskWorkIds(taskExitCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkOperationsApi.TaskWorkOperationsGetProfessionalRoleOperationsByExitCodeAndTaskWorkIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskExitCode** | [**TaskExitCodeDTO**](TaskExitCodeDTO.md)| exit code for close action | 

### Return type

[**List<ProfessionalRoleOperationDTO>**](ProfessionalRoleOperationDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkoperationsgetselectedusersfordynamicjob"></a>
# **TaskWorkOperationsGetSelectedUsersForDynamicJob**
> List<UserCompleteDTO> TaskWorkOperationsGetSelectedUsersForDynamicJob (int? dynamicJobUser, int? processId)

This call returns the selected users list for a dynamic job in a process

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkOperationsGetSelectedUsersForDynamicJobExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkOperationsApi();
            var dynamicJobUser = 56;  // int? | Id of the dynamic job
            var processId = 56;  // int? | Id of the process

            try
            {
                // This call returns the selected users list for a dynamic job in a process
                List&lt;UserCompleteDTO&gt; result = apiInstance.TaskWorkOperationsGetSelectedUsersForDynamicJob(dynamicJobUser, processId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkOperationsApi.TaskWorkOperationsGetSelectedUsersForDynamicJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dynamicJobUser** | **int?**| Id of the dynamic job | 
 **processId** | **int?**| Id of the process | 

### Return type

[**List<UserCompleteDTO>**](UserCompleteDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkoperationsgetusersfordynamicjob"></a>
# **TaskWorkOperationsGetUsersForDynamicJob**
> List<UserCompleteDTO> TaskWorkOperationsGetUsersForDynamicJob ()

This call returns al possibile user for a dynamic job attribution

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkOperationsGetUsersForDynamicJobExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkOperationsApi();

            try
            {
                // This call returns al possibile user for a dynamic job attribution
                List&lt;UserCompleteDTO&gt; result = apiInstance.TaskWorkOperationsGetUsersForDynamicJob();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkOperationsApi.TaskWorkOperationsGetUsersForDynamicJob: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<UserCompleteDTO>**](UserCompleteDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkoperationsgetusersforprofessionalroleselection"></a>
# **TaskWorkOperationsGetUsersForProfessionalRoleSelection**
> List<UserCompleteDTO> TaskWorkOperationsGetUsersForProfessionalRoleSelection (int? taskWorkId, int? professionalRoleId)

This call returns the professional role possibile users for a professional role operation

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkOperationsGetUsersForProfessionalRoleSelectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkOperationsApi();
            var taskWorkId = 56;  // int? | Id of the task work
            var professionalRoleId = 56;  // int? | Id of the professional role

            try
            {
                // This call returns the professional role possibile users for a professional role operation
                List&lt;UserCompleteDTO&gt; result = apiInstance.TaskWorkOperationsGetUsersForProfessionalRoleSelection(taskWorkId, professionalRoleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkOperationsApi.TaskWorkOperationsGetUsersForProfessionalRoleSelection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskWorkId** | **int?**| Id of the task work | 
 **professionalRoleId** | **int?**| Id of the professional role | 

### Return type

[**List<UserCompleteDTO>**](UserCompleteDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkoperationssetdynamicjob"></a>
# **TaskWorkOperationsSetDynamicJob**
> void TaskWorkOperationsSetDynamicJob (int? dynamicJobId, int? taskWorkId, List<UserCompleteDTO> users)

This call sets the users for a process dynamic job

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkOperationsSetDynamicJobExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkOperationsApi();
            var dynamicJobId = 56;  // int? | Id of the dynamic job
            var taskWorkId = 56;  // int? | Id of the task work
            var users = new List<UserCompleteDTO>(); // List<UserCompleteDTO> | users list to add

            try
            {
                // This call sets the users for a process dynamic job
                apiInstance.TaskWorkOperationsSetDynamicJob(dynamicJobId, taskWorkId, users);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkOperationsApi.TaskWorkOperationsSetDynamicJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dynamicJobId** | **int?**| Id of the dynamic job | 
 **taskWorkId** | **int?**| Id of the task work | 
 **users** | [**List&lt;UserCompleteDTO&gt;**](UserCompleteDTO.md)| users list to add | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkoperationssetdynamicjobmultiple"></a>
# **TaskWorkOperationsSetDynamicJobMultiple**
> void TaskWorkOperationsSetDynamicJobMultiple (DynamicJobMultipleSetRequestDTO dynamicJobMultipleSetRequest)

This call sets the users for multiple process dynamic job

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkOperationsSetDynamicJobMultipleExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkOperationsApi();
            var dynamicJobMultipleSetRequest = new DynamicJobMultipleSetRequestDTO(); // DynamicJobMultipleSetRequestDTO | Request for multiple dynamic job set

            try
            {
                // This call sets the users for multiple process dynamic job
                apiInstance.TaskWorkOperationsSetDynamicJobMultiple(dynamicJobMultipleSetRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkOperationsApi.TaskWorkOperationsSetDynamicJobMultiple: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dynamicJobMultipleSetRequest** | [**DynamicJobMultipleSetRequestDTO**](DynamicJobMultipleSetRequestDTO.md)| Request for multiple dynamic job set | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkoperationssetprocessvariablevaluebytaskworkid"></a>
# **TaskWorkOperationsSetProcessVariableValueByTaskWorkId**
> void TaskWorkOperationsSetProcessVariableValueByTaskWorkId (int? taskWorkId, ProcessVariablesFieldsDTO processVariables)

This call sets the values for the process variables

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkOperationsSetProcessVariableValueByTaskWorkIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkOperationsApi();
            var taskWorkId = 56;  // int? | Id of the task work
            var processVariables = new ProcessVariablesFieldsDTO(); // ProcessVariablesFieldsDTO | Process variables informations

            try
            {
                // This call sets the values for the process variables
                apiInstance.TaskWorkOperationsSetProcessVariableValueByTaskWorkId(taskWorkId, processVariables);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkOperationsApi.TaskWorkOperationsSetProcessVariableValueByTaskWorkId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskWorkId** | **int?**| Id of the task work | 
 **processVariables** | [**ProcessVariablesFieldsDTO**](ProcessVariablesFieldsDTO.md)| Process variables informations | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkoperationssetprofessionalrolebytaskids"></a>
# **TaskWorkOperationsSetProfessionalRoleByTaskIds**
> void TaskWorkOperationsSetProfessionalRoleByTaskIds (int? professionalRoleId, int? userToAssignId, List<int?> taskWorkIds)

This call sets the professional roles users for multiple TaskWork Ids

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkOperationsSetProfessionalRoleByTaskIdsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkOperationsApi();
            var professionalRoleId = 56;  // int? | Id of the professional role
            var userToAssignId = 56;  // int? | If of user
            var taskWorkIds = ;  // List<int?> | List of taskwork id

            try
            {
                // This call sets the professional roles users for multiple TaskWork Ids
                apiInstance.TaskWorkOperationsSetProfessionalRoleByTaskIds(professionalRoleId, userToAssignId, taskWorkIds);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkOperationsApi.TaskWorkOperationsSetProfessionalRoleByTaskIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **professionalRoleId** | **int?**| Id of the professional role | 
 **userToAssignId** | **int?**| If of user | 
 **taskWorkIds** | **List&lt;int?&gt;**| List of taskwork id | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkoperationssetusersforprofessionalroleselection"></a>
# **TaskWorkOperationsSetUsersForProfessionalRoleSelection**
> void TaskWorkOperationsSetUsersForProfessionalRoleSelection (int? taskWorkId, int? professionalRoleId, int? userId)

This call sets the user for a professional role operation

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkOperationsSetUsersForProfessionalRoleSelectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkOperationsApi();
            var taskWorkId = 56;  // int? | Id of the task work
            var professionalRoleId = 56;  // int? | Id of the professional role
            var userId = 56;  // int? | Id of the user

            try
            {
                // This call sets the user for a professional role operation
                apiInstance.TaskWorkOperationsSetUsersForProfessionalRoleSelection(taskWorkId, professionalRoleId, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkOperationsApi.TaskWorkOperationsSetUsersForProfessionalRoleSelection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskWorkId** | **int?**| Id of the task work | 
 **professionalRoleId** | **int?**| Id of the professional role | 
 **userId** | **int?**| Id of the user | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkoperationstaskworkcommandexecute"></a>
# **TaskWorkOperationsTaskWorkCommandExecute**
> void TaskWorkOperationsTaskWorkCommandExecute (int? taskWorkId, int? taskWorkCommandId)

this call executes a command task operation

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkOperationsTaskWorkCommandExecuteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkOperationsApi();
            var taskWorkId = 56;  // int? | Task id of the operation
            var taskWorkCommandId = 56;  // int? | Id of the command operation

            try
            {
                // this call executes a command task operation
                apiInstance.TaskWorkOperationsTaskWorkCommandExecute(taskWorkId, taskWorkCommandId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkOperationsApi.TaskWorkOperationsTaskWorkCommandExecute: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskWorkId** | **int?**| Task id of the operation | 
 **taskWorkCommandId** | **int?**| Id of the command operation | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkoperationsunsetprofessionalroleselection"></a>
# **TaskWorkOperationsUnSetProfessionalRoleSelection**
> void TaskWorkOperationsUnSetProfessionalRoleSelection (int? professionalRoleId, int? taskWorkId)

This call deletes the professional role actual value

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkOperationsUnSetProfessionalRoleSelectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkOperationsApi();
            var professionalRoleId = 56;  // int? | Id of the professional role
            var taskWorkId = 56;  // int? | Id of the task work

            try
            {
                // This call deletes the professional role actual value
                apiInstance.TaskWorkOperationsUnSetProfessionalRoleSelection(professionalRoleId, taskWorkId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkOperationsApi.TaskWorkOperationsUnSetProfessionalRoleSelection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **professionalRoleId** | **int?**| Id of the professional role | 
 **taskWorkId** | **int?**| Id of the task work | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkoperationsvalidatevariabile"></a>
# **TaskWorkOperationsValidateVariabile**
> ValidationFieldResultDTO TaskWorkOperationsValidateVariabile (int? taskWorkId, ProcessVariableValidationDTO validationData)



### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkOperationsValidateVariabileExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkOperationsApi();
            var taskWorkId = 56;  // int? | 
            var validationData = new ProcessVariableValidationDTO(); // ProcessVariableValidationDTO | 

            try
            {
                ValidationFieldResultDTO result = apiInstance.TaskWorkOperationsValidateVariabile(taskWorkId, validationData);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkOperationsApi.TaskWorkOperationsValidateVariabile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskWorkId** | **int?**|  | 
 **validationData** | [**ProcessVariableValidationDTO**](ProcessVariableValidationDTO.md)|  | 

### Return type

[**ValidationFieldResultDTO**](ValidationFieldResultDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


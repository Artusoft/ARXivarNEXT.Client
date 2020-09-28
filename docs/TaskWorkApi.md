# ARXivarNEXT.Client.Api.TaskWorkApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TaskWorkActivateTaskwork**](TaskWorkApi.md#taskworkactivatetaskwork) | **PUT** /api/TaskWork/{taskWorkId}/Activate | This call returns a taskwork if active
[**TaskWorkAutoAssign**](TaskWorkApi.md#taskworkautoassign) | **POST** /api/TaskWork/autoassign/{taskworkId} | This call autoassigns the taskwork
[**TaskWorkCanFinalizeTaskByIds**](TaskWorkApi.md#taskworkcanfinalizetaskbyids) | **POST** /api/TaskWork/canfinalize | This call returns if is possible to close task work list
[**TaskWorkCanFinalizeTaskByIdsAndExitCodeAndPassword**](TaskWorkApi.md#taskworkcanfinalizetaskbyidsandexitcodeandpassword) | **POST** /api/TaskWork/canfinalizebyexitcodeandpassword | This call returns if is possible to close task work list by exit code and password
[**TaskWorkDeleteTaskWorkById**](TaskWorkApi.md#taskworkdeletetaskworkbyid) | **DELETE** /api/TaskWork/{taskWorkId} | This call deletes the task
[**TaskWorkFinalizeTaskByIdsAndExitCodeAndPassword**](TaskWorkApi.md#taskworkfinalizetaskbyidsandexitcodeandpassword) | **POST** /api/TaskWork/finalize | This call closes a task work list
[**TaskWorkGetActiveTaskWork**](TaskWorkApi.md#taskworkgetactivetaskwork) | **POST** /api/TaskWork/actives/{docnumber} | This call executes a task search and return taskwork active for the user on a specific document
[**TaskWorkGetDefaultSelect**](TaskWorkApi.md#taskworkgetdefaultselect) | **GET** /api/TaskWork/defaultselect | This call provides default select for tasklist search
[**TaskWorkGetDocumentsByProcessId**](TaskWorkApi.md#taskworkgetdocumentsbyprocessid) | **POST** /api/TaskWork/documents/{processId} | This call returns the task documents
[**TaskWorkGetDocumentsFilenameByProcessId**](TaskWorkApi.md#taskworkgetdocumentsfilenamebyprocessid) | **GET** /api/TaskWork/documents/filenames/{processId} | 
[**TaskWorkGetExitCodesByTaskWorkIds**](TaskWorkApi.md#taskworkgetexitcodesbytaskworkids) | **POST** /api/TaskWork/exitcodes | This call returns all possible exit code for taskWorks list
[**TaskWorkGetProfileSchemaForTaskWorkMaskDocumentOperation**](TaskWorkApi.md#taskworkgetprofileschemafortaskworkmaskdocumentoperation) | **GET** /api/TaskWork/{taskWorkId}/documentsoperations/{taskWorkDocumentOperationId}/maskprofileSchema | This call returns a document schema for a mask insert document taskWork operation
[**TaskWorkGetProfileSchemaForTaskWorkModelDocumentOperation**](TaskWorkApi.md#taskworkgetprofileschemafortaskworkmodeldocumentoperation) | **GET** /api/TaskWork/{taskWorkId}/documentsoperations/{taskWorkDocumentOperationId}/modelprofileSchema | This call returns a profile schema for a model insert document taskWork operation
[**TaskWorkGetProfileSchemaForTaskWorkStandardDocumentOperation**](TaskWorkApi.md#taskworkgetprofileschemafortaskworkstandarddocumentoperation) | **GET** /api/TaskWork/{taskWorkId}/documentsoperations/{taskWorkDocumentOperationId}/standardprofileSchema | This call returns a profile schema for a standard insert document taskWork operation
[**TaskWorkGetTaskWorkById**](TaskWorkApi.md#taskworkgettaskworkbyid) | **GET** /api/TaskWork/{taskWorkId} | This call returns the task
[**TaskWorkGetTaskWorkForAutoAssign**](TaskWorkApi.md#taskworkgettaskworkforautoassign) | **GET** /api/TaskWork/autoassignlist/{docnumber} | This call returns all autoassigned taskwork associated with a document
[**TaskWorkGetTasks**](TaskWorkApi.md#taskworkgettasks) | **POST** /api/TaskWork | This call executes a task search and return taskwork active for the user and the given workflows ids (with all revisions)
[**TaskWorkReassignTaskById**](TaskWorkApi.md#taskworkreassigntaskbyid) | **POST** /api/TaskWork/reassign/{taskworkid} | This call reassigns a task to selected users
[**TaskWorkReassignUsersTaskById**](TaskWorkApi.md#taskworkreassignuserstaskbyid) | **GET** /api/TaskWork/reassignusers/{taskworkid} | This call reassigns a task to selected users
[**TaskWorkSetProfileForTaskWorkBySelectionDocumentOperation**](TaskWorkApi.md#taskworksetprofilefortaskworkbyselectiondocumentoperation) | **PUT** /api/TaskWork/{taskWorkId}/documentsoperations/{taskWorkDocumentOperationId}/byselection | This call adds a profile to process for a selection document taskwork operation
[**TaskWorkSetProfileForTaskWorkMaskDocumentOperation**](TaskWorkApi.md#taskworksetprofilefortaskworkmaskdocumentoperation) | **POST** /api/TaskWork/{taskWorkId}/documentsoperations/{taskWorkDocumentOperationId}/bymask | This call profiles a new document for a mask insert document taskwork operation
[**TaskWorkSetProfileForTaskWorkModelDocumentOperation**](TaskWorkApi.md#taskworksetprofilefortaskworkmodeldocumentoperation) | **POST** /api/TaskWork/{taskWorkId}/documentsoperations/{taskWorkDocumentOperationId}/bymodel | This call profiles a new document for a model insert document taskwork operation
[**TaskWorkSetProfileForTaskWorkStandardDocumentOperation**](TaskWorkApi.md#taskworksetprofilefortaskworkstandarddocumentoperation) | **POST** /api/TaskWork/{taskWorkId}/documentsoperations/{taskWorkDocumentOperationId}/bystandard | This call profiles a new document for a standard insert document taskwork operation
[**TaskWorkSetTaskPriority**](TaskWorkApi.md#taskworksettaskpriority) | **PUT** /api/TaskWork/priority/{priority} | This call sets the tasks priority
[**TaskWorkSetTaskRead**](TaskWorkApi.md#taskworksettaskread) | **PUT** /api/TaskWork/read | This call sets the task as read
[**TaskWorkSetTaskUnRead**](TaskWorkApi.md#taskworksettaskunread) | **PUT** /api/TaskWork/unread | This call sets the tasks as unread
[**TaskWorkTaskWorkTakeCharge**](TaskWorkApi.md#taskworktaskworktakecharge) | **PUT** /api/TaskWork/{taskWorkId}/TakeCharge | This call takes charge of a taskwork


<a name="taskworkactivatetaskwork"></a>
# **TaskWorkActivateTaskwork**
> TaskWorkDTO TaskWorkActivateTaskwork (int? taskWorkId)

This call returns a taskwork if active

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkActivateTaskworkExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkApi();
            var taskWorkId = 56;  // int? | Taskwork identifier

            try
            {
                // This call returns a taskwork if active
                TaskWorkDTO result = apiInstance.TaskWorkActivateTaskwork(taskWorkId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkApi.TaskWorkActivateTaskwork: " + e.Message );
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

[**TaskWorkDTO**](TaskWorkDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkautoassign"></a>
# **TaskWorkAutoAssign**
> void TaskWorkAutoAssign (int? taskworkId)

This call autoassigns the taskwork

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkAutoAssignExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkApi();
            var taskworkId = 56;  // int? | Taskwork identifier

            try
            {
                // This call autoassigns the taskwork
                apiInstance.TaskWorkAutoAssign(taskworkId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkApi.TaskWorkAutoAssign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskworkId** | **int?**| Taskwork identifier | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkcanfinalizetaskbyids"></a>
# **TaskWorkCanFinalizeTaskByIds**
> List<CloseEligibleResult> TaskWorkCanFinalizeTaskByIds (List<int?> taskworkids)

This call returns if is possible to close task work list

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkCanFinalizeTaskByIdsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkApi();
            var taskworkids = ;  // List<int?> | List of taskwork identifier

            try
            {
                // This call returns if is possible to close task work list
                List&lt;CloseEligibleResult&gt; result = apiInstance.TaskWorkCanFinalizeTaskByIds(taskworkids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkApi.TaskWorkCanFinalizeTaskByIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskworkids** | **List&lt;int?&gt;**| List of taskwork identifier | 

### Return type

[**List<CloseEligibleResult>**](CloseEligibleResult.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkcanfinalizetaskbyidsandexitcodeandpassword"></a>
# **TaskWorkCanFinalizeTaskByIdsAndExitCodeAndPassword**
> List<CloseEligibleResult> TaskWorkCanFinalizeTaskByIdsAndExitCodeAndPassword (TaskWorkCloseRequest closeRequest)

This call returns if is possible to close task work list by exit code and password

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkCanFinalizeTaskByIdsAndExitCodeAndPasswordExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkApi();
            var closeRequest = new TaskWorkCloseRequest(); // TaskWorkCloseRequest | Taskwork information

            try
            {
                // This call returns if is possible to close task work list by exit code and password
                List&lt;CloseEligibleResult&gt; result = apiInstance.TaskWorkCanFinalizeTaskByIdsAndExitCodeAndPassword(closeRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkApi.TaskWorkCanFinalizeTaskByIdsAndExitCodeAndPassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **closeRequest** | [**TaskWorkCloseRequest**](TaskWorkCloseRequest.md)| Taskwork information | 

### Return type

[**List<CloseEligibleResult>**](CloseEligibleResult.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkdeletetaskworkbyid"></a>
# **TaskWorkDeleteTaskWorkById**
> void TaskWorkDeleteTaskWorkById (int? taskWorkId)

This call deletes the task

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkDeleteTaskWorkByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkApi();
            var taskWorkId = 56;  // int? | Taskwork identifier

            try
            {
                // This call deletes the task
                apiInstance.TaskWorkDeleteTaskWorkById(taskWorkId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkApi.TaskWorkDeleteTaskWorkById: " + e.Message );
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

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkfinalizetaskbyidsandexitcodeandpassword"></a>
# **TaskWorkFinalizeTaskByIdsAndExitCodeAndPassword**
> void TaskWorkFinalizeTaskByIdsAndExitCodeAndPassword (TaskWorkCloseRequest closeRequest)

This call closes a task work list

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkFinalizeTaskByIdsAndExitCodeAndPasswordExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkApi();
            var closeRequest = new TaskWorkCloseRequest(); // TaskWorkCloseRequest | Taskwork information

            try
            {
                // This call closes a task work list
                apiInstance.TaskWorkFinalizeTaskByIdsAndExitCodeAndPassword(closeRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkApi.TaskWorkFinalizeTaskByIdsAndExitCodeAndPassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **closeRequest** | [**TaskWorkCloseRequest**](TaskWorkCloseRequest.md)| Taskwork information | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkgetactivetaskwork"></a>
# **TaskWorkGetActiveTaskWork**
> List<RowSearchResult> TaskWorkGetActiveTaskWork (SelectDTO select, int? docnumber)

This call executes a task search and return taskwork active for the user on a specific document

Use the resource on api/v2/TaskWork/actives/{docnumber}

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkGetActiveTaskWorkExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkApi();
            var select = new SelectDTO(); // SelectDTO | Selection Fields
            var docnumber = 56;  // int? | Document Identifier

            try
            {
                // This call executes a task search and return taskwork active for the user on a specific document
                List&lt;RowSearchResult&gt; result = apiInstance.TaskWorkGetActiveTaskWork(select, docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkApi.TaskWorkGetActiveTaskWork: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **select** | [**SelectDTO**](SelectDTO.md)| Selection Fields | 
 **docnumber** | **int?**| Document Identifier | 

### Return type

[**List<RowSearchResult>**](RowSearchResult.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkgetdefaultselect"></a>
# **TaskWorkGetDefaultSelect**
> SelectDTO TaskWorkGetDefaultSelect ()

This call provides default select for tasklist search

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkGetDefaultSelectExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkApi();

            try
            {
                // This call provides default select for tasklist search
                SelectDTO result = apiInstance.TaskWorkGetDefaultSelect();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkApi.TaskWorkGetDefaultSelect: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SelectDTO**](SelectDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkgetdocumentsbyprocessid"></a>
# **TaskWorkGetDocumentsByProcessId**
> List<RowSearchResult> TaskWorkGetDocumentsByProcessId (int? processId, SelectDTO select)

This call returns the task documents

Use the resource on api/v2/TaskWork/documents/{processId}

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkGetDocumentsByProcessIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkApi();
            var processId = 56;  // int? | Process identifier
            var select = new SelectDTO(); // SelectDTO | Field select configuration

            try
            {
                // This call returns the task documents
                List&lt;RowSearchResult&gt; result = apiInstance.TaskWorkGetDocumentsByProcessId(processId, select);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkApi.TaskWorkGetDocumentsByProcessId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **int?**| Process identifier | 
 **select** | [**SelectDTO**](SelectDTO.md)| Field select configuration | 

### Return type

[**List<RowSearchResult>**](RowSearchResult.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkgetdocumentsfilenamebyprocessid"></a>
# **TaskWorkGetDocumentsFilenameByProcessId**
> List<KeyValueElementDto> TaskWorkGetDocumentsFilenameByProcessId (int? processId)



### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkGetDocumentsFilenameByProcessIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkApi();
            var processId = 56;  // int? | 

            try
            {
                List&lt;KeyValueElementDto&gt; result = apiInstance.TaskWorkGetDocumentsFilenameByProcessId(processId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkApi.TaskWorkGetDocumentsFilenameByProcessId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **int?**|  | 

### Return type

[**List<KeyValueElementDto>**](KeyValueElementDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkgetexitcodesbytaskworkids"></a>
# **TaskWorkGetExitCodesByTaskWorkIds**
> List<TaskExitCodeDTO> TaskWorkGetExitCodesByTaskWorkIds (List<int?> taskWorkIds)

This call returns all possible exit code for taskWorks list

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkGetExitCodesByTaskWorkIdsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkApi();
            var taskWorkIds = ;  // List<int?> | List of taskwork identifier

            try
            {
                // This call returns all possible exit code for taskWorks list
                List&lt;TaskExitCodeDTO&gt; result = apiInstance.TaskWorkGetExitCodesByTaskWorkIds(taskWorkIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkApi.TaskWorkGetExitCodesByTaskWorkIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskWorkIds** | **List&lt;int?&gt;**| List of taskwork identifier | 

### Return type

[**List<TaskExitCodeDTO>**](TaskExitCodeDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkgetprofileschemafortaskworkmaskdocumentoperation"></a>
# **TaskWorkGetProfileSchemaForTaskWorkMaskDocumentOperation**
> MaskProfileSchemaDTO TaskWorkGetProfileSchemaForTaskWorkMaskDocumentOperation (int? taskWorkId, string taskWorkDocumentOperationId)

This call returns a document schema for a mask insert document taskWork operation

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkGetProfileSchemaForTaskWorkMaskDocumentOperationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkApi();
            var taskWorkId = 56;  // int? | Taskwork identifier
            var taskWorkDocumentOperationId = taskWorkDocumentOperationId_example;  // string | Id of the operation

            try
            {
                // This call returns a document schema for a mask insert document taskWork operation
                MaskProfileSchemaDTO result = apiInstance.TaskWorkGetProfileSchemaForTaskWorkMaskDocumentOperation(taskWorkId, taskWorkDocumentOperationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkApi.TaskWorkGetProfileSchemaForTaskWorkMaskDocumentOperation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskWorkId** | **int?**| Taskwork identifier | 
 **taskWorkDocumentOperationId** | **string**| Id of the operation | 

### Return type

[**MaskProfileSchemaDTO**](MaskProfileSchemaDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkgetprofileschemafortaskworkmodeldocumentoperation"></a>
# **TaskWorkGetProfileSchemaForTaskWorkModelDocumentOperation**
> ModelProfileSchemaDTO TaskWorkGetProfileSchemaForTaskWorkModelDocumentOperation (int? taskWorkId, string taskWorkDocumentOperationId)

This call returns a profile schema for a model insert document taskWork operation

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkGetProfileSchemaForTaskWorkModelDocumentOperationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkApi();
            var taskWorkId = 56;  // int? | Taskwork identifier
            var taskWorkDocumentOperationId = taskWorkDocumentOperationId_example;  // string | Id of the operation

            try
            {
                // This call returns a profile schema for a model insert document taskWork operation
                ModelProfileSchemaDTO result = apiInstance.TaskWorkGetProfileSchemaForTaskWorkModelDocumentOperation(taskWorkId, taskWorkDocumentOperationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkApi.TaskWorkGetProfileSchemaForTaskWorkModelDocumentOperation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskWorkId** | **int?**| Taskwork identifier | 
 **taskWorkDocumentOperationId** | **string**| Id of the operation | 

### Return type

[**ModelProfileSchemaDTO**](ModelProfileSchemaDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkgetprofileschemafortaskworkstandarddocumentoperation"></a>
# **TaskWorkGetProfileSchemaForTaskWorkStandardDocumentOperation**
> MaskProfileSchemaDTO TaskWorkGetProfileSchemaForTaskWorkStandardDocumentOperation (int? taskWorkId, string taskWorkDocumentOperationId)

This call returns a profile schema for a standard insert document taskWork operation

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkGetProfileSchemaForTaskWorkStandardDocumentOperationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkApi();
            var taskWorkId = 56;  // int? | Taskwork identifier
            var taskWorkDocumentOperationId = taskWorkDocumentOperationId_example;  // string | Id of the operation

            try
            {
                // This call returns a profile schema for a standard insert document taskWork operation
                MaskProfileSchemaDTO result = apiInstance.TaskWorkGetProfileSchemaForTaskWorkStandardDocumentOperation(taskWorkId, taskWorkDocumentOperationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkApi.TaskWorkGetProfileSchemaForTaskWorkStandardDocumentOperation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskWorkId** | **int?**| Taskwork identifier | 
 **taskWorkDocumentOperationId** | **string**| Id of the operation | 

### Return type

[**MaskProfileSchemaDTO**](MaskProfileSchemaDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkgettaskworkbyid"></a>
# **TaskWorkGetTaskWorkById**
> TaskWorkDTO TaskWorkGetTaskWorkById (int? taskWorkId)

This call returns the task

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkGetTaskWorkByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkApi();
            var taskWorkId = 56;  // int? | Taskwork identifier

            try
            {
                // This call returns the task
                TaskWorkDTO result = apiInstance.TaskWorkGetTaskWorkById(taskWorkId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkApi.TaskWorkGetTaskWorkById: " + e.Message );
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

[**TaskWorkDTO**](TaskWorkDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkgettaskworkforautoassign"></a>
# **TaskWorkGetTaskWorkForAutoAssign**
> List<TaskWorkDTO> TaskWorkGetTaskWorkForAutoAssign (int? docnumber)

This call returns all autoassigned taskwork associated with a document

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkGetTaskWorkForAutoAssignExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkApi();
            var docnumber = 56;  // int? | Document identifier

            try
            {
                // This call returns all autoassigned taskwork associated with a document
                List&lt;TaskWorkDTO&gt; result = apiInstance.TaskWorkGetTaskWorkForAutoAssign(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkApi.TaskWorkGetTaskWorkForAutoAssign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| Document identifier | 

### Return type

[**List<TaskWorkDTO>**](TaskWorkDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkgettasks"></a>
# **TaskWorkGetTasks**
> List<RowSearchResult> TaskWorkGetTasks (TaskWorkRequestDTO request)

This call executes a task search and return taskwork active for the user and the given workflows ids (with all revisions)

Use the resource on api/v2/TaskWork

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkGetTasksExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkApi();
            var request = new TaskWorkRequestDTO(); // TaskWorkRequestDTO | The request object that defines select parte and workflows ids, if workflows ids is null or empty returns all taskWork for the user

            try
            {
                // This call executes a task search and return taskwork active for the user and the given workflows ids (with all revisions)
                List&lt;RowSearchResult&gt; result = apiInstance.TaskWorkGetTasks(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkApi.TaskWorkGetTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**TaskWorkRequestDTO**](TaskWorkRequestDTO.md)| The request object that defines select parte and workflows ids, if workflows ids is null or empty returns all taskWork for the user | 

### Return type

[**List<RowSearchResult>**](RowSearchResult.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkreassigntaskbyid"></a>
# **TaskWorkReassignTaskById**
> void TaskWorkReassignTaskById (int? taskworkid, TaskWorkReassignRequest reassignRequest)

This call reassigns a task to selected users

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkReassignTaskByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkApi();
            var taskworkid = 56;  // int? | Taskwork identifier
            var reassignRequest = new TaskWorkReassignRequest(); // TaskWorkReassignRequest | Information for re assign operation request

            try
            {
                // This call reassigns a task to selected users
                apiInstance.TaskWorkReassignTaskById(taskworkid, reassignRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkApi.TaskWorkReassignTaskById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskworkid** | **int?**| Taskwork identifier | 
 **reassignRequest** | [**TaskWorkReassignRequest**](TaskWorkReassignRequest.md)| Information for re assign operation request | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkreassignuserstaskbyid"></a>
# **TaskWorkReassignUsersTaskById**
> List<UserCompleteDTO> TaskWorkReassignUsersTaskById (int? taskworkid)

This call reassigns a task to selected users

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkReassignUsersTaskByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkApi();
            var taskworkid = 56;  // int? | Taskwork identifier

            try
            {
                // This call reassigns a task to selected users
                List&lt;UserCompleteDTO&gt; result = apiInstance.TaskWorkReassignUsersTaskById(taskworkid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkApi.TaskWorkReassignUsersTaskById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskworkid** | **int?**| Taskwork identifier | 

### Return type

[**List<UserCompleteDTO>**](UserCompleteDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworksetprofilefortaskworkbyselectiondocumentoperation"></a>
# **TaskWorkSetProfileForTaskWorkBySelectionDocumentOperation**
> void TaskWorkSetProfileForTaskWorkBySelectionDocumentOperation (int? taskWorkId, string taskWorkDocumentOperationId, List<int?> docnumbers)

This call adds a profile to process for a selection document taskwork operation

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkSetProfileForTaskWorkBySelectionDocumentOperationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkApi();
            var taskWorkId = 56;  // int? | Taskwork identifie
            var taskWorkDocumentOperationId = taskWorkDocumentOperationId_example;  // string | Id of the operation
            var docnumbers = ;  // List<int?> | List of document identifier to add

            try
            {
                // This call adds a profile to process for a selection document taskwork operation
                apiInstance.TaskWorkSetProfileForTaskWorkBySelectionDocumentOperation(taskWorkId, taskWorkDocumentOperationId, docnumbers);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkApi.TaskWorkSetProfileForTaskWorkBySelectionDocumentOperation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskWorkId** | **int?**| Taskwork identifie | 
 **taskWorkDocumentOperationId** | **string**| Id of the operation | 
 **docnumbers** | **List&lt;int?&gt;**| List of document identifier to add | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworksetprofilefortaskworkmaskdocumentoperation"></a>
# **TaskWorkSetProfileForTaskWorkMaskDocumentOperation**
> ProfileResultDTO TaskWorkSetProfileForTaskWorkMaskDocumentOperation (int? taskWorkId, string taskWorkDocumentOperationId, ProfileDTO profile = null)

This call profiles a new document for a mask insert document taskwork operation

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkSetProfileForTaskWorkMaskDocumentOperationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkApi();
            var taskWorkId = 56;  // int? | Taskwork identifie
            var taskWorkDocumentOperationId = taskWorkDocumentOperationId_example;  // string | Id of the operation
            var profile = new ProfileDTO(); // ProfileDTO |  (optional) 

            try
            {
                // This call profiles a new document for a mask insert document taskwork operation
                ProfileResultDTO result = apiInstance.TaskWorkSetProfileForTaskWorkMaskDocumentOperation(taskWorkId, taskWorkDocumentOperationId, profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkApi.TaskWorkSetProfileForTaskWorkMaskDocumentOperation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskWorkId** | **int?**| Taskwork identifie | 
 **taskWorkDocumentOperationId** | **string**| Id of the operation | 
 **profile** | [**ProfileDTO**](ProfileDTO.md)|  | [optional] 

### Return type

[**ProfileResultDTO**](ProfileResultDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworksetprofilefortaskworkmodeldocumentoperation"></a>
# **TaskWorkSetProfileForTaskWorkModelDocumentOperation**
> ProfileResultDTO TaskWorkSetProfileForTaskWorkModelDocumentOperation (int? taskWorkId, string taskWorkDocumentOperationId, ProfileDTO profile = null)

This call profiles a new document for a model insert document taskwork operation

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkSetProfileForTaskWorkModelDocumentOperationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkApi();
            var taskWorkId = 56;  // int? | Taskwork identifie
            var taskWorkDocumentOperationId = taskWorkDocumentOperationId_example;  // string | Id of the operation
            var profile = new ProfileDTO(); // ProfileDTO |  (optional) 

            try
            {
                // This call profiles a new document for a model insert document taskwork operation
                ProfileResultDTO result = apiInstance.TaskWorkSetProfileForTaskWorkModelDocumentOperation(taskWorkId, taskWorkDocumentOperationId, profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkApi.TaskWorkSetProfileForTaskWorkModelDocumentOperation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskWorkId** | **int?**| Taskwork identifie | 
 **taskWorkDocumentOperationId** | **string**| Id of the operation | 
 **profile** | [**ProfileDTO**](ProfileDTO.md)|  | [optional] 

### Return type

[**ProfileResultDTO**](ProfileResultDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworksetprofilefortaskworkstandarddocumentoperation"></a>
# **TaskWorkSetProfileForTaskWorkStandardDocumentOperation**
> ProfileResultDTO TaskWorkSetProfileForTaskWorkStandardDocumentOperation (int? taskWorkId, string taskWorkDocumentOperationId, ProfileDTO profile = null)

This call profiles a new document for a standard insert document taskwork operation

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkSetProfileForTaskWorkStandardDocumentOperationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkApi();
            var taskWorkId = 56;  // int? | Taskwork identifie
            var taskWorkDocumentOperationId = taskWorkDocumentOperationId_example;  // string | Id of the operation
            var profile = new ProfileDTO(); // ProfileDTO |  (optional) 

            try
            {
                // This call profiles a new document for a standard insert document taskwork operation
                ProfileResultDTO result = apiInstance.TaskWorkSetProfileForTaskWorkStandardDocumentOperation(taskWorkId, taskWorkDocumentOperationId, profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkApi.TaskWorkSetProfileForTaskWorkStandardDocumentOperation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskWorkId** | **int?**| Taskwork identifie | 
 **taskWorkDocumentOperationId** | **string**| Id of the operation | 
 **profile** | [**ProfileDTO**](ProfileDTO.md)|  | [optional] 

### Return type

[**ProfileResultDTO**](ProfileResultDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworksettaskpriority"></a>
# **TaskWorkSetTaskPriority**
> int? TaskWorkSetTaskPriority (List<int?> taskIds, int? priority)

This call sets the tasks priority

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkSetTaskPriorityExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkApi();
            var taskIds = ;  // List<int?> | List of task identifier
            var priority = 56;  // int? | Priority

            try
            {
                // This call sets the tasks priority
                int? result = apiInstance.TaskWorkSetTaskPriority(taskIds, priority);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkApi.TaskWorkSetTaskPriority: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskIds** | **List&lt;int?&gt;**| List of task identifier | 
 **priority** | **int?**| Priority | 

### Return type

**int?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworksettaskread"></a>
# **TaskWorkSetTaskRead**
> int? TaskWorkSetTaskRead (List<int?> taskid)

This call sets the task as read

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkSetTaskReadExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkApi();
            var taskid = ;  // List<int?> | Task Identifier

            try
            {
                // This call sets the task as read
                int? result = apiInstance.TaskWorkSetTaskRead(taskid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkApi.TaskWorkSetTaskRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskid** | **List&lt;int?&gt;**| Task Identifier | 

### Return type

**int?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworksettaskunread"></a>
# **TaskWorkSetTaskUnRead**
> int? TaskWorkSetTaskUnRead (List<int?> taskIds)

This call sets the tasks as unread

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkSetTaskUnReadExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkApi();
            var taskIds = ;  // List<int?> | List of task identifier

            try
            {
                // This call sets the tasks as unread
                int? result = apiInstance.TaskWorkSetTaskUnRead(taskIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkApi.TaskWorkSetTaskUnRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskIds** | **List&lt;int?&gt;**| List of task identifier | 

### Return type

**int?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworktaskworktakecharge"></a>
# **TaskWorkTaskWorkTakeCharge**
> void TaskWorkTaskWorkTakeCharge (int? taskWorkId)

This call takes charge of a taskwork

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkTaskWorkTakeChargeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkApi();
            var taskWorkId = 56;  // int? | Taskwork identifier

            try
            {
                // This call takes charge of a taskwork
                apiInstance.TaskWorkTaskWorkTakeCharge(taskWorkId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkApi.TaskWorkTaskWorkTakeCharge: " + e.Message );
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

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


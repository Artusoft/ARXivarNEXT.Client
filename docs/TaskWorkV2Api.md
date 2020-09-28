# ARXivarNEXT.Client.Api.TaskWorkV2Api

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TaskWorkV2ActivateTaskwork**](TaskWorkV2Api.md#taskworkv2activatetaskwork) | **PUT** /api/v2/TaskWork/{taskWorkId}/Activate | This call returns a taskwork if active
[**TaskWorkV2AutoAssign**](TaskWorkV2Api.md#taskworkv2autoassign) | **POST** /api/v2/TaskWork/autoassign/{taskworkId} | This call autoassigns the taskwork
[**TaskWorkV2CanFinalizeTaskByIds**](TaskWorkV2Api.md#taskworkv2canfinalizetaskbyids) | **POST** /api/v2/TaskWork/canfinalize | This call returns if is possible to close task work list
[**TaskWorkV2CanFinalizeTaskByIdsAndExitCodeAndPassword**](TaskWorkV2Api.md#taskworkv2canfinalizetaskbyidsandexitcodeandpassword) | **POST** /api/v2/TaskWork/canfinalizebyexitcodeandpassword | This call returns if is possible to close task work list by exit code and password
[**TaskWorkV2DeleteTaskWorkById**](TaskWorkV2Api.md#taskworkv2deletetaskworkbyid) | **DELETE** /api/v2/TaskWork/{taskWorkId} | This call deletes the task
[**TaskWorkV2FinalizeTaskByIdsAndExitCodeAndPassword**](TaskWorkV2Api.md#taskworkv2finalizetaskbyidsandexitcodeandpassword) | **POST** /api/v2/TaskWork/finalize | This call closes a task work list
[**TaskWorkV2GetActiveTaskWork**](TaskWorkV2Api.md#taskworkv2getactivetaskwork) | **POST** /api/v2/TaskWork/actives/{docnumber} | This call executes a task search and return taskwork active for the user on a specific document.  This call could not be compatible with some programming language, in this case use the call api/TaskWork/actives/{docnumber}
[**TaskWorkV2GetDefaultSelect**](TaskWorkV2Api.md#taskworkv2getdefaultselect) | **GET** /api/v2/TaskWork/defaultselect | This call provides default select for tasklist search
[**TaskWorkV2GetDocumentsByProcessId**](TaskWorkV2Api.md#taskworkv2getdocumentsbyprocessid) | **POST** /api/v2/TaskWork/documents/{processId} | This call returns the task documents.  This call could not be compatible with some programming language, in this case use the call api/TaskWork/documents/{processId}
[**TaskWorkV2GetDocumentsFilenameByProcessId**](TaskWorkV2Api.md#taskworkv2getdocumentsfilenamebyprocessid) | **GET** /api/v2/TaskWork/documents/filenames/{processId} | 
[**TaskWorkV2GetExitCodesByTaskWorkIds**](TaskWorkV2Api.md#taskworkv2getexitcodesbytaskworkids) | **POST** /api/v2/TaskWork/exitcodes | This call returns all possible exit code for taskWorks list
[**TaskWorkV2GetProfileSchemaForTaskWorkMaskDocumentOperation**](TaskWorkV2Api.md#taskworkv2getprofileschemafortaskworkmaskdocumentoperation) | **GET** /api/v2/TaskWork/{taskWorkId}/documentsoperations/{taskWorkDocumentOperationId}/maskprofileSchema | This call returns a document schema for a mask insert document taskWork operation
[**TaskWorkV2GetProfileSchemaForTaskWorkModelDocumentOperation**](TaskWorkV2Api.md#taskworkv2getprofileschemafortaskworkmodeldocumentoperation) | **GET** /api/v2/TaskWork/{taskWorkId}/documentsoperations/{taskWorkDocumentOperationId}/modelprofileSchema | This call returns a profile schema for a model insert document taskWork operation
[**TaskWorkV2GetProfileSchemaForTaskWorkStandardDocumentOperation**](TaskWorkV2Api.md#taskworkv2getprofileschemafortaskworkstandarddocumentoperation) | **GET** /api/v2/TaskWork/{taskWorkId}/documentsoperations/{taskWorkDocumentOperationId}/standardprofileSchema | This call returns a profile schema for a standard insert document taskWork operation
[**TaskWorkV2GetTaskWorkById**](TaskWorkV2Api.md#taskworkv2gettaskworkbyid) | **GET** /api/v2/TaskWork/{taskWorkId} | This call returns the task
[**TaskWorkV2GetTaskWorkForAutoAssign**](TaskWorkV2Api.md#taskworkv2gettaskworkforautoassign) | **GET** /api/v2/TaskWork/autoassignlist/{docnumber} | This call returns all autoassigned taskwork associated with a document
[**TaskWorkV2GetTasks**](TaskWorkV2Api.md#taskworkv2gettasks) | **POST** /api/v2/TaskWork | This call executes a task search and return taskwork active for the user and the given workflows ids (with all revisions).  This call could not be compatible with some programming language, in this case use the call api/TaskWork
[**TaskWorkV2ReassignTaskById**](TaskWorkV2Api.md#taskworkv2reassigntaskbyid) | **POST** /api/v2/TaskWork/reassign/{taskworkid} | This call reassigns a task to selected users
[**TaskWorkV2ReassignUsersTaskById**](TaskWorkV2Api.md#taskworkv2reassignuserstaskbyid) | **GET** /api/v2/TaskWork/reassignusers/{taskworkid} | This call reassigns a task to selected users
[**TaskWorkV2SetProfileForTaskWorkBySelectionDocumentOperation**](TaskWorkV2Api.md#taskworkv2setprofilefortaskworkbyselectiondocumentoperation) | **PUT** /api/v2/TaskWork/{taskWorkId}/documentsoperations/{taskWorkDocumentOperationId}/byselection | This call adds a profile to process for a selection document taskwork operation
[**TaskWorkV2SetProfileForTaskWorkMaskDocumentOperation**](TaskWorkV2Api.md#taskworkv2setprofilefortaskworkmaskdocumentoperation) | **POST** /api/v2/TaskWork/{taskWorkId}/documentsoperations/{taskWorkDocumentOperationId}/bymask | This call profiles a new document for a mask insert document taskwork operation
[**TaskWorkV2SetProfileForTaskWorkModelDocumentOperation**](TaskWorkV2Api.md#taskworkv2setprofilefortaskworkmodeldocumentoperation) | **POST** /api/v2/TaskWork/{taskWorkId}/documentsoperations/{taskWorkDocumentOperationId}/bymodel | This call profiles a new document for a model insert document taskwork operation
[**TaskWorkV2SetProfileForTaskWorkStandardDocumentOperation**](TaskWorkV2Api.md#taskworkv2setprofilefortaskworkstandarddocumentoperation) | **POST** /api/v2/TaskWork/{taskWorkId}/documentsoperations/{taskWorkDocumentOperationId}/bystandard | This call profiles a new document for a standard insert document taskwork operation
[**TaskWorkV2SetTaskPriority**](TaskWorkV2Api.md#taskworkv2settaskpriority) | **PUT** /api/v2/TaskWork/priority/{priority} | This call sets the tasks priority
[**TaskWorkV2SetTaskRead**](TaskWorkV2Api.md#taskworkv2settaskread) | **PUT** /api/v2/TaskWork/read | This call sets the task as read
[**TaskWorkV2SetTaskUnRead**](TaskWorkV2Api.md#taskworkv2settaskunread) | **PUT** /api/v2/TaskWork/unread | This call sets the tasks as unread
[**TaskWorkV2TaskWorkTakeCharge**](TaskWorkV2Api.md#taskworkv2taskworktakecharge) | **PUT** /api/v2/TaskWork/{taskWorkId}/TakeCharge | This call takes charge of a taskwork


<a name="taskworkv2activatetaskwork"></a>
# **TaskWorkV2ActivateTaskwork**
> TaskWorkDTO TaskWorkV2ActivateTaskwork (int? taskWorkId)

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
    public class TaskWorkV2ActivateTaskworkExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkV2Api();
            var taskWorkId = 56;  // int? | Taskwork identifier

            try
            {
                // This call returns a taskwork if active
                TaskWorkDTO result = apiInstance.TaskWorkV2ActivateTaskwork(taskWorkId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkV2Api.TaskWorkV2ActivateTaskwork: " + e.Message );
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

<a name="taskworkv2autoassign"></a>
# **TaskWorkV2AutoAssign**
> void TaskWorkV2AutoAssign (int? taskworkId)

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
    public class TaskWorkV2AutoAssignExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkV2Api();
            var taskworkId = 56;  // int? | Taskwork identifier

            try
            {
                // This call autoassigns the taskwork
                apiInstance.TaskWorkV2AutoAssign(taskworkId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkV2Api.TaskWorkV2AutoAssign: " + e.Message );
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

<a name="taskworkv2canfinalizetaskbyids"></a>
# **TaskWorkV2CanFinalizeTaskByIds**
> List<CloseEligibleResult> TaskWorkV2CanFinalizeTaskByIds (List<int?> taskworkids)

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
    public class TaskWorkV2CanFinalizeTaskByIdsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkV2Api();
            var taskworkids = ;  // List<int?> | List of taskwork identifier

            try
            {
                // This call returns if is possible to close task work list
                List&lt;CloseEligibleResult&gt; result = apiInstance.TaskWorkV2CanFinalizeTaskByIds(taskworkids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkV2Api.TaskWorkV2CanFinalizeTaskByIds: " + e.Message );
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

<a name="taskworkv2canfinalizetaskbyidsandexitcodeandpassword"></a>
# **TaskWorkV2CanFinalizeTaskByIdsAndExitCodeAndPassword**
> List<CloseEligibleResult> TaskWorkV2CanFinalizeTaskByIdsAndExitCodeAndPassword (TaskWorkCloseRequest closeRequest)

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
    public class TaskWorkV2CanFinalizeTaskByIdsAndExitCodeAndPasswordExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkV2Api();
            var closeRequest = new TaskWorkCloseRequest(); // TaskWorkCloseRequest | Taskwork information

            try
            {
                // This call returns if is possible to close task work list by exit code and password
                List&lt;CloseEligibleResult&gt; result = apiInstance.TaskWorkV2CanFinalizeTaskByIdsAndExitCodeAndPassword(closeRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkV2Api.TaskWorkV2CanFinalizeTaskByIdsAndExitCodeAndPassword: " + e.Message );
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

<a name="taskworkv2deletetaskworkbyid"></a>
# **TaskWorkV2DeleteTaskWorkById**
> void TaskWorkV2DeleteTaskWorkById (int? taskWorkId)

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
    public class TaskWorkV2DeleteTaskWorkByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkV2Api();
            var taskWorkId = 56;  // int? | Taskwork identifier

            try
            {
                // This call deletes the task
                apiInstance.TaskWorkV2DeleteTaskWorkById(taskWorkId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkV2Api.TaskWorkV2DeleteTaskWorkById: " + e.Message );
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

<a name="taskworkv2finalizetaskbyidsandexitcodeandpassword"></a>
# **TaskWorkV2FinalizeTaskByIdsAndExitCodeAndPassword**
> void TaskWorkV2FinalizeTaskByIdsAndExitCodeAndPassword (TaskWorkCloseRequest closeRequest)

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
    public class TaskWorkV2FinalizeTaskByIdsAndExitCodeAndPasswordExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkV2Api();
            var closeRequest = new TaskWorkCloseRequest(); // TaskWorkCloseRequest | Taskwork information

            try
            {
                // This call closes a task work list
                apiInstance.TaskWorkV2FinalizeTaskByIdsAndExitCodeAndPassword(closeRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkV2Api.TaskWorkV2FinalizeTaskByIdsAndExitCodeAndPassword: " + e.Message );
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

<a name="taskworkv2getactivetaskwork"></a>
# **TaskWorkV2GetActiveTaskWork**
> Object TaskWorkV2GetActiveTaskWork (SelectDTO select, int? docnumber)

This call executes a task search and return taskwork active for the user on a specific document.  This call could not be compatible with some programming language, in this case use the call api/TaskWork/actives/{docnumber}

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkV2GetActiveTaskWorkExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkV2Api();
            var select = new SelectDTO(); // SelectDTO | Selection Fields
            var docnumber = 56;  // int? | Document Identifier

            try
            {
                // This call executes a task search and return taskwork active for the user on a specific document.  This call could not be compatible with some programming language, in this case use the call api/TaskWork/actives/{docnumber}
                Object result = apiInstance.TaskWorkV2GetActiveTaskWork(select, docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkV2Api.TaskWorkV2GetActiveTaskWork: " + e.Message );
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

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkv2getdefaultselect"></a>
# **TaskWorkV2GetDefaultSelect**
> SelectDTO TaskWorkV2GetDefaultSelect ()

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
    public class TaskWorkV2GetDefaultSelectExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkV2Api();

            try
            {
                // This call provides default select for tasklist search
                SelectDTO result = apiInstance.TaskWorkV2GetDefaultSelect();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkV2Api.TaskWorkV2GetDefaultSelect: " + e.Message );
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

<a name="taskworkv2getdocumentsbyprocessid"></a>
# **TaskWorkV2GetDocumentsByProcessId**
> Object TaskWorkV2GetDocumentsByProcessId (int? processId, SelectDTO select)

This call returns the task documents.  This call could not be compatible with some programming language, in this case use the call api/TaskWork/documents/{processId}

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkV2GetDocumentsByProcessIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkV2Api();
            var processId = 56;  // int? | Process identifier
            var select = new SelectDTO(); // SelectDTO | Field select configuration

            try
            {
                // This call returns the task documents.  This call could not be compatible with some programming language, in this case use the call api/TaskWork/documents/{processId}
                Object result = apiInstance.TaskWorkV2GetDocumentsByProcessId(processId, select);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkV2Api.TaskWorkV2GetDocumentsByProcessId: " + e.Message );
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

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkv2getdocumentsfilenamebyprocessid"></a>
# **TaskWorkV2GetDocumentsFilenameByProcessId**
> List<KeyValueElementDto> TaskWorkV2GetDocumentsFilenameByProcessId (int? processId)



### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkV2GetDocumentsFilenameByProcessIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkV2Api();
            var processId = 56;  // int? | 

            try
            {
                List&lt;KeyValueElementDto&gt; result = apiInstance.TaskWorkV2GetDocumentsFilenameByProcessId(processId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkV2Api.TaskWorkV2GetDocumentsFilenameByProcessId: " + e.Message );
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

<a name="taskworkv2getexitcodesbytaskworkids"></a>
# **TaskWorkV2GetExitCodesByTaskWorkIds**
> List<TaskExitCodeDTO> TaskWorkV2GetExitCodesByTaskWorkIds (List<int?> taskWorkIds)

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
    public class TaskWorkV2GetExitCodesByTaskWorkIdsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkV2Api();
            var taskWorkIds = ;  // List<int?> | List of taskwork identifier

            try
            {
                // This call returns all possible exit code for taskWorks list
                List&lt;TaskExitCodeDTO&gt; result = apiInstance.TaskWorkV2GetExitCodesByTaskWorkIds(taskWorkIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkV2Api.TaskWorkV2GetExitCodesByTaskWorkIds: " + e.Message );
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

<a name="taskworkv2getprofileschemafortaskworkmaskdocumentoperation"></a>
# **TaskWorkV2GetProfileSchemaForTaskWorkMaskDocumentOperation**
> MaskProfileSchemaDTO TaskWorkV2GetProfileSchemaForTaskWorkMaskDocumentOperation (int? taskWorkId, string taskWorkDocumentOperationId)

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
    public class TaskWorkV2GetProfileSchemaForTaskWorkMaskDocumentOperationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkV2Api();
            var taskWorkId = 56;  // int? | Taskwork identifier
            var taskWorkDocumentOperationId = taskWorkDocumentOperationId_example;  // string | Id of the operation

            try
            {
                // This call returns a document schema for a mask insert document taskWork operation
                MaskProfileSchemaDTO result = apiInstance.TaskWorkV2GetProfileSchemaForTaskWorkMaskDocumentOperation(taskWorkId, taskWorkDocumentOperationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkV2Api.TaskWorkV2GetProfileSchemaForTaskWorkMaskDocumentOperation: " + e.Message );
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

<a name="taskworkv2getprofileschemafortaskworkmodeldocumentoperation"></a>
# **TaskWorkV2GetProfileSchemaForTaskWorkModelDocumentOperation**
> ModelProfileSchemaDTO TaskWorkV2GetProfileSchemaForTaskWorkModelDocumentOperation (int? taskWorkId, string taskWorkDocumentOperationId)

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
    public class TaskWorkV2GetProfileSchemaForTaskWorkModelDocumentOperationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkV2Api();
            var taskWorkId = 56;  // int? | Taskwork identifier
            var taskWorkDocumentOperationId = taskWorkDocumentOperationId_example;  // string | Id of the operation

            try
            {
                // This call returns a profile schema for a model insert document taskWork operation
                ModelProfileSchemaDTO result = apiInstance.TaskWorkV2GetProfileSchemaForTaskWorkModelDocumentOperation(taskWorkId, taskWorkDocumentOperationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkV2Api.TaskWorkV2GetProfileSchemaForTaskWorkModelDocumentOperation: " + e.Message );
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

<a name="taskworkv2getprofileschemafortaskworkstandarddocumentoperation"></a>
# **TaskWorkV2GetProfileSchemaForTaskWorkStandardDocumentOperation**
> MaskProfileSchemaDTO TaskWorkV2GetProfileSchemaForTaskWorkStandardDocumentOperation (int? taskWorkId, string taskWorkDocumentOperationId)

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
    public class TaskWorkV2GetProfileSchemaForTaskWorkStandardDocumentOperationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkV2Api();
            var taskWorkId = 56;  // int? | Taskwork identifier
            var taskWorkDocumentOperationId = taskWorkDocumentOperationId_example;  // string | Id of the operation

            try
            {
                // This call returns a profile schema for a standard insert document taskWork operation
                MaskProfileSchemaDTO result = apiInstance.TaskWorkV2GetProfileSchemaForTaskWorkStandardDocumentOperation(taskWorkId, taskWorkDocumentOperationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkV2Api.TaskWorkV2GetProfileSchemaForTaskWorkStandardDocumentOperation: " + e.Message );
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

<a name="taskworkv2gettaskworkbyid"></a>
# **TaskWorkV2GetTaskWorkById**
> TaskWorkDTO TaskWorkV2GetTaskWorkById (int? taskWorkId)

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
    public class TaskWorkV2GetTaskWorkByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkV2Api();
            var taskWorkId = 56;  // int? | Taskwork identifier

            try
            {
                // This call returns the task
                TaskWorkDTO result = apiInstance.TaskWorkV2GetTaskWorkById(taskWorkId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkV2Api.TaskWorkV2GetTaskWorkById: " + e.Message );
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

<a name="taskworkv2gettaskworkforautoassign"></a>
# **TaskWorkV2GetTaskWorkForAutoAssign**
> List<TaskWorkDTO> TaskWorkV2GetTaskWorkForAutoAssign (int? docnumber)

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
    public class TaskWorkV2GetTaskWorkForAutoAssignExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkV2Api();
            var docnumber = 56;  // int? | Document identifier

            try
            {
                // This call returns all autoassigned taskwork associated with a document
                List&lt;TaskWorkDTO&gt; result = apiInstance.TaskWorkV2GetTaskWorkForAutoAssign(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkV2Api.TaskWorkV2GetTaskWorkForAutoAssign: " + e.Message );
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

<a name="taskworkv2gettasks"></a>
# **TaskWorkV2GetTasks**
> Object TaskWorkV2GetTasks (TaskWorkRequestDTO request)

This call executes a task search and return taskwork active for the user and the given workflows ids (with all revisions).  This call could not be compatible with some programming language, in this case use the call api/TaskWork

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkV2GetTasksExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkV2Api();
            var request = new TaskWorkRequestDTO(); // TaskWorkRequestDTO | The request object that defines select parte and workflows ids, if workflows ids is null or empty returns all taskWork for the user

            try
            {
                // This call executes a task search and return taskwork active for the user and the given workflows ids (with all revisions).  This call could not be compatible with some programming language, in this case use the call api/TaskWork
                Object result = apiInstance.TaskWorkV2GetTasks(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkV2Api.TaskWorkV2GetTasks: " + e.Message );
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

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkv2reassigntaskbyid"></a>
# **TaskWorkV2ReassignTaskById**
> void TaskWorkV2ReassignTaskById (int? taskworkid, TaskWorkReassignRequest reassignRequest)

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
    public class TaskWorkV2ReassignTaskByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkV2Api();
            var taskworkid = 56;  // int? | Taskwork identifier
            var reassignRequest = new TaskWorkReassignRequest(); // TaskWorkReassignRequest | Information for re assign operation request

            try
            {
                // This call reassigns a task to selected users
                apiInstance.TaskWorkV2ReassignTaskById(taskworkid, reassignRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkV2Api.TaskWorkV2ReassignTaskById: " + e.Message );
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

<a name="taskworkv2reassignuserstaskbyid"></a>
# **TaskWorkV2ReassignUsersTaskById**
> List<UserCompleteDTO> TaskWorkV2ReassignUsersTaskById (int? taskworkid)

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
    public class TaskWorkV2ReassignUsersTaskByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkV2Api();
            var taskworkid = 56;  // int? | Taskwork identifier

            try
            {
                // This call reassigns a task to selected users
                List&lt;UserCompleteDTO&gt; result = apiInstance.TaskWorkV2ReassignUsersTaskById(taskworkid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkV2Api.TaskWorkV2ReassignUsersTaskById: " + e.Message );
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

<a name="taskworkv2setprofilefortaskworkbyselectiondocumentoperation"></a>
# **TaskWorkV2SetProfileForTaskWorkBySelectionDocumentOperation**
> void TaskWorkV2SetProfileForTaskWorkBySelectionDocumentOperation (int? taskWorkId, string taskWorkDocumentOperationId, List<int?> docnumbers)

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
    public class TaskWorkV2SetProfileForTaskWorkBySelectionDocumentOperationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkV2Api();
            var taskWorkId = 56;  // int? | Taskwork identifie
            var taskWorkDocumentOperationId = taskWorkDocumentOperationId_example;  // string | Id of the operation
            var docnumbers = ;  // List<int?> | List of document identifier to add

            try
            {
                // This call adds a profile to process for a selection document taskwork operation
                apiInstance.TaskWorkV2SetProfileForTaskWorkBySelectionDocumentOperation(taskWorkId, taskWorkDocumentOperationId, docnumbers);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkV2Api.TaskWorkV2SetProfileForTaskWorkBySelectionDocumentOperation: " + e.Message );
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

<a name="taskworkv2setprofilefortaskworkmaskdocumentoperation"></a>
# **TaskWorkV2SetProfileForTaskWorkMaskDocumentOperation**
> ProfileResultDTO TaskWorkV2SetProfileForTaskWorkMaskDocumentOperation (int? taskWorkId, string taskWorkDocumentOperationId, ProfileDTO profile = null)

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
    public class TaskWorkV2SetProfileForTaskWorkMaskDocumentOperationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkV2Api();
            var taskWorkId = 56;  // int? | Taskwork identifie
            var taskWorkDocumentOperationId = taskWorkDocumentOperationId_example;  // string | Id of the operation
            var profile = new ProfileDTO(); // ProfileDTO |  (optional) 

            try
            {
                // This call profiles a new document for a mask insert document taskwork operation
                ProfileResultDTO result = apiInstance.TaskWorkV2SetProfileForTaskWorkMaskDocumentOperation(taskWorkId, taskWorkDocumentOperationId, profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkV2Api.TaskWorkV2SetProfileForTaskWorkMaskDocumentOperation: " + e.Message );
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

<a name="taskworkv2setprofilefortaskworkmodeldocumentoperation"></a>
# **TaskWorkV2SetProfileForTaskWorkModelDocumentOperation**
> ProfileResultDTO TaskWorkV2SetProfileForTaskWorkModelDocumentOperation (int? taskWorkId, string taskWorkDocumentOperationId, ProfileDTO profile = null)

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
    public class TaskWorkV2SetProfileForTaskWorkModelDocumentOperationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkV2Api();
            var taskWorkId = 56;  // int? | Taskwork identifie
            var taskWorkDocumentOperationId = taskWorkDocumentOperationId_example;  // string | Id of the operation
            var profile = new ProfileDTO(); // ProfileDTO |  (optional) 

            try
            {
                // This call profiles a new document for a model insert document taskwork operation
                ProfileResultDTO result = apiInstance.TaskWorkV2SetProfileForTaskWorkModelDocumentOperation(taskWorkId, taskWorkDocumentOperationId, profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkV2Api.TaskWorkV2SetProfileForTaskWorkModelDocumentOperation: " + e.Message );
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

<a name="taskworkv2setprofilefortaskworkstandarddocumentoperation"></a>
# **TaskWorkV2SetProfileForTaskWorkStandardDocumentOperation**
> ProfileResultDTO TaskWorkV2SetProfileForTaskWorkStandardDocumentOperation (int? taskWorkId, string taskWorkDocumentOperationId, ProfileDTO profile = null)

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
    public class TaskWorkV2SetProfileForTaskWorkStandardDocumentOperationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkV2Api();
            var taskWorkId = 56;  // int? | Taskwork identifie
            var taskWorkDocumentOperationId = taskWorkDocumentOperationId_example;  // string | Id of the operation
            var profile = new ProfileDTO(); // ProfileDTO |  (optional) 

            try
            {
                // This call profiles a new document for a standard insert document taskwork operation
                ProfileResultDTO result = apiInstance.TaskWorkV2SetProfileForTaskWorkStandardDocumentOperation(taskWorkId, taskWorkDocumentOperationId, profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkV2Api.TaskWorkV2SetProfileForTaskWorkStandardDocumentOperation: " + e.Message );
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

<a name="taskworkv2settaskpriority"></a>
# **TaskWorkV2SetTaskPriority**
> int? TaskWorkV2SetTaskPriority (List<int?> taskIds, int? priority)

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
    public class TaskWorkV2SetTaskPriorityExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkV2Api();
            var taskIds = ;  // List<int?> | List of task identifier
            var priority = 56;  // int? | Priority

            try
            {
                // This call sets the tasks priority
                int? result = apiInstance.TaskWorkV2SetTaskPriority(taskIds, priority);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkV2Api.TaskWorkV2SetTaskPriority: " + e.Message );
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

<a name="taskworkv2settaskread"></a>
# **TaskWorkV2SetTaskRead**
> int? TaskWorkV2SetTaskRead (List<int?> taskid)

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
    public class TaskWorkV2SetTaskReadExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkV2Api();
            var taskid = ;  // List<int?> | Task Identifier

            try
            {
                // This call sets the task as read
                int? result = apiInstance.TaskWorkV2SetTaskRead(taskid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkV2Api.TaskWorkV2SetTaskRead: " + e.Message );
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

<a name="taskworkv2settaskunread"></a>
# **TaskWorkV2SetTaskUnRead**
> int? TaskWorkV2SetTaskUnRead (List<int?> taskIds)

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
    public class TaskWorkV2SetTaskUnReadExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkV2Api();
            var taskIds = ;  // List<int?> | List of task identifier

            try
            {
                // This call sets the tasks as unread
                int? result = apiInstance.TaskWorkV2SetTaskUnRead(taskIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkV2Api.TaskWorkV2SetTaskUnRead: " + e.Message );
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

<a name="taskworkv2taskworktakecharge"></a>
# **TaskWorkV2TaskWorkTakeCharge**
> void TaskWorkV2TaskWorkTakeCharge (int? taskWorkId)

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
    public class TaskWorkV2TaskWorkTakeChargeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkV2Api();
            var taskWorkId = 56;  // int? | Taskwork identifier

            try
            {
                // This call takes charge of a taskwork
                apiInstance.TaskWorkV2TaskWorkTakeCharge(taskWorkId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkV2Api.TaskWorkV2TaskWorkTakeCharge: " + e.Message );
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


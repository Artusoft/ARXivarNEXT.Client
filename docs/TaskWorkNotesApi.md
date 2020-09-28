# ARXivarNEXT.Client.Api.TaskWorkNotesApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TaskWorkNotesDeleteNote**](TaskWorkNotesApi.md#taskworknotesdeletenote) | **DELETE** /api/TaskNotes/{taskWorkNoteId} | This call deletes a process note
[**TaskWorkNotesGetByProcessId**](TaskWorkNotesApi.md#taskworknotesgetbyprocessid) | **GET** /api/TaskNotes/byProcessId/{processId} | This call returns all notes in a process
[**TaskWorkNotesInsertNewNote**](TaskWorkNotesApi.md#taskworknotesinsertnewnote) | **POST** /api/TaskNotes/taskWorkId/{taskWorkId} | This call adds a new note to a process
[**TaskWorkNotesUpdateNote**](TaskWorkNotesApi.md#taskworknotesupdatenote) | **PUT** /api/TaskNotes/{taskWorkNoteId} | This call updates a process note


<a name="taskworknotesdeletenote"></a>
# **TaskWorkNotesDeleteNote**
> void TaskWorkNotesDeleteNote (int? taskWorkNoteId)

This call deletes a process note

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkNotesDeleteNoteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkNotesApi();
            var taskWorkNoteId = 56;  // int? | Note identifier

            try
            {
                // This call deletes a process note
                apiInstance.TaskWorkNotesDeleteNote(taskWorkNoteId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkNotesApi.TaskWorkNotesDeleteNote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskWorkNoteId** | **int?**| Note identifier | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworknotesgetbyprocessid"></a>
# **TaskWorkNotesGetByProcessId**
> List<TaskWorkNoteDTO> TaskWorkNotesGetByProcessId (int? processId)

This call returns all notes in a process

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkNotesGetByProcessIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkNotesApi();
            var processId = 56;  // int? | Process identifier

            try
            {
                // This call returns all notes in a process
                List&lt;TaskWorkNoteDTO&gt; result = apiInstance.TaskWorkNotesGetByProcessId(processId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkNotesApi.TaskWorkNotesGetByProcessId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **int?**| Process identifier | 

### Return type

[**List<TaskWorkNoteDTO>**](TaskWorkNoteDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworknotesinsertnewnote"></a>
# **TaskWorkNotesInsertNewNote**
> TaskWorkNoteDTO TaskWorkNotesInsertNewNote (int? taskWorkId, TaskWorkNoteDTO note)

This call adds a new note to a process

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkNotesInsertNewNoteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkNotesApi();
            var taskWorkId = 56;  // int? | Taskwork identifier
            var note = new TaskWorkNoteDTO(); // TaskWorkNoteDTO | Note to add

            try
            {
                // This call adds a new note to a process
                TaskWorkNoteDTO result = apiInstance.TaskWorkNotesInsertNewNote(taskWorkId, note);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkNotesApi.TaskWorkNotesInsertNewNote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskWorkId** | **int?**| Taskwork identifier | 
 **note** | [**TaskWorkNoteDTO**](TaskWorkNoteDTO.md)| Note to add | 

### Return type

[**TaskWorkNoteDTO**](TaskWorkNoteDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworknotesupdatenote"></a>
# **TaskWorkNotesUpdateNote**
> TaskWorkNoteDTO TaskWorkNotesUpdateNote (int? taskWorkNoteId, TaskWorkNoteDTO note)

This call updates a process note

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkNotesUpdateNoteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkNotesApi();
            var taskWorkNoteId = 56;  // int? | Taskwork identifier
            var note = new TaskWorkNoteDTO(); // TaskWorkNoteDTO | Note to update

            try
            {
                // This call updates a process note
                TaskWorkNoteDTO result = apiInstance.TaskWorkNotesUpdateNote(taskWorkNoteId, note);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkNotesApi.TaskWorkNotesUpdateNote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskWorkNoteId** | **int?**| Taskwork identifier | 
 **note** | [**TaskWorkNoteDTO**](TaskWorkNoteDTO.md)| Note to update | 

### Return type

[**TaskWorkNoteDTO**](TaskWorkNoteDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


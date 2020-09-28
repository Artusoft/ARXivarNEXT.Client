# ARXivarNEXT.Client.Api.TaskWorkAttachmentsApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TaskWorkAttachmentsAddNewExternalAttachments**](TaskWorkAttachmentsApi.md#taskworkattachmentsaddnewexternalattachments) | **POST** /api/TaskAttachments/bytaskwork/{taskWorkId}/external/{bufferId} | This call adds a new external attachment to a process
[**TaskWorkAttachmentsAddNewInternalAttachments**](TaskWorkAttachmentsApi.md#taskworkattachmentsaddnewinternalattachments) | **POST** /api/TaskAttachments/bytaskwork/{taskWorkId}/internal/{docnumber} | This call adds a new internal attachments to a process
[**TaskWorkAttachmentsChangeToSendForTaskAttachments**](TaskWorkAttachmentsApi.md#taskworkattachmentschangetosendfortaskattachments) | **PUT** /api/TaskAttachments/{attachmentId}/tosend/{tosend} | this call changes the value of the &#39;to send&#39; flag for an attachment
[**TaskWorkAttachmentsDeleteTaskAttachementById**](TaskWorkAttachmentsApi.md#taskworkattachmentsdeletetaskattachementbyid) | **DELETE** /api/TaskAttachments/{attachmentId} | This call deletes a process attachment
[**TaskWorkAttachmentsGetAttachmentsByProcessId**](TaskWorkAttachmentsApi.md#taskworkattachmentsgetattachmentsbyprocessid) | **GET** /api/TaskAttachments/byprocessid/{processId} | This call returns all attachments of a process


<a name="taskworkattachmentsaddnewexternalattachments"></a>
# **TaskWorkAttachmentsAddNewExternalAttachments**
> void TaskWorkAttachmentsAddNewExternalAttachments (string bufferId, int? taskWorkId)

This call adds a new external attachment to a process

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkAttachmentsAddNewExternalAttachmentsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkAttachmentsApi();
            var bufferId = bufferId_example;  // string | Identifier of the buffer file
            var taskWorkId = 56;  // int? | Taskwork identifier

            try
            {
                // This call adds a new external attachment to a process
                apiInstance.TaskWorkAttachmentsAddNewExternalAttachments(bufferId, taskWorkId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkAttachmentsApi.TaskWorkAttachmentsAddNewExternalAttachments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bufferId** | **string**| Identifier of the buffer file | 
 **taskWorkId** | **int?**| Taskwork identifier | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkattachmentsaddnewinternalattachments"></a>
# **TaskWorkAttachmentsAddNewInternalAttachments**
> void TaskWorkAttachmentsAddNewInternalAttachments (int? docnumber, int? taskWorkId)

This call adds a new internal attachments to a process

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkAttachmentsAddNewInternalAttachmentsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkAttachmentsApi();
            var docnumber = 56;  // int? | Document identifier
            var taskWorkId = 56;  // int? | Taskwork identifier

            try
            {
                // This call adds a new internal attachments to a process
                apiInstance.TaskWorkAttachmentsAddNewInternalAttachments(docnumber, taskWorkId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkAttachmentsApi.TaskWorkAttachmentsAddNewInternalAttachments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| Document identifier | 
 **taskWorkId** | **int?**| Taskwork identifier | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkattachmentschangetosendfortaskattachments"></a>
# **TaskWorkAttachmentsChangeToSendForTaskAttachments**
> void TaskWorkAttachmentsChangeToSendForTaskAttachments (int? attachmentId, bool? tosend)

this call changes the value of the 'to send' flag for an attachment

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkAttachmentsChangeToSendForTaskAttachmentsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkAttachmentsApi();
            var attachmentId = 56;  // int? | Attachment identifier
            var tosend = true;  // bool? | Value of 'to send' flag

            try
            {
                // this call changes the value of the 'to send' flag for an attachment
                apiInstance.TaskWorkAttachmentsChangeToSendForTaskAttachments(attachmentId, tosend);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkAttachmentsApi.TaskWorkAttachmentsChangeToSendForTaskAttachments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachmentId** | **int?**| Attachment identifier | 
 **tosend** | **bool?**| Value of &#39;to send&#39; flag | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkattachmentsdeletetaskattachementbyid"></a>
# **TaskWorkAttachmentsDeleteTaskAttachementById**
> void TaskWorkAttachmentsDeleteTaskAttachementById (int? attachmentId)

This call deletes a process attachment

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkAttachmentsDeleteTaskAttachementByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkAttachmentsApi();
            var attachmentId = 56;  // int? | Attachment identifier

            try
            {
                // This call deletes a process attachment
                apiInstance.TaskWorkAttachmentsDeleteTaskAttachementById(attachmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkAttachmentsApi.TaskWorkAttachmentsDeleteTaskAttachementById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachmentId** | **int?**| Attachment identifier | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskworkattachmentsgetattachmentsbyprocessid"></a>
# **TaskWorkAttachmentsGetAttachmentsByProcessId**
> List<RowSearchResult> TaskWorkAttachmentsGetAttachmentsByProcessId (int? processId)

This call returns all attachments of a process

This method is deprecated. Use api/v2/TaskAttachments/byprocessid/{processId}

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkAttachmentsGetAttachmentsByProcessIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkAttachmentsApi();
            var processId = 56;  // int? | Process identifier

            try
            {
                // This call returns all attachments of a process
                List&lt;RowSearchResult&gt; result = apiInstance.TaskWorkAttachmentsGetAttachmentsByProcessId(processId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkAttachmentsApi.TaskWorkAttachmentsGetAttachmentsByProcessId: " + e.Message );
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

[**List<RowSearchResult>**](RowSearchResult.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


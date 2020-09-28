# ARXivarNEXT.Client.Api.TaskWorkAttachmentsV2Api

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TaskWorkAttachmentsV2AddNewExternalAttachments**](TaskWorkAttachmentsV2Api.md#taskworkattachmentsv2addnewexternalattachments) | **POST** /api/v2/TaskAttachments/bytaskwork/{taskWorkId}/external/{bufferId} | This call adds a new external attachment to a process
[**TaskWorkAttachmentsV2AddNewInternalAttachments**](TaskWorkAttachmentsV2Api.md#taskworkattachmentsv2addnewinternalattachments) | **POST** /api/v2/TaskAttachments/bytaskwork/{taskWorkId}/internal/{docnumber} | This call adds a new internal attachments to a process
[**TaskWorkAttachmentsV2ChangeToSendForTaskAttachments**](TaskWorkAttachmentsV2Api.md#taskworkattachmentsv2changetosendfortaskattachments) | **PUT** /api/v2/TaskAttachments/{attachmentId}/tosend/{tosend} | this call changes the value of the &#39;to send&#39; flag for an attachment
[**TaskWorkAttachmentsV2DeleteTaskAttachementById**](TaskWorkAttachmentsV2Api.md#taskworkattachmentsv2deletetaskattachementbyid) | **DELETE** /api/v2/TaskAttachments/{attachmentId} | This call deletes a process attachment
[**TaskWorkAttachmentsV2GetAttachmentsByProcessId**](TaskWorkAttachmentsV2Api.md#taskworkattachmentsv2getattachmentsbyprocessid) | **GET** /api/v2/TaskAttachments/byprocessid/{processId} | This call returns all attachments of a process


<a name="taskworkattachmentsv2addnewexternalattachments"></a>
# **TaskWorkAttachmentsV2AddNewExternalAttachments**
> void TaskWorkAttachmentsV2AddNewExternalAttachments (string bufferId, int? taskWorkId)

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
    public class TaskWorkAttachmentsV2AddNewExternalAttachmentsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkAttachmentsV2Api();
            var bufferId = bufferId_example;  // string | Identifier of the buffer file
            var taskWorkId = 56;  // int? | Taskwork identifier

            try
            {
                // This call adds a new external attachment to a process
                apiInstance.TaskWorkAttachmentsV2AddNewExternalAttachments(bufferId, taskWorkId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkAttachmentsV2Api.TaskWorkAttachmentsV2AddNewExternalAttachments: " + e.Message );
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

<a name="taskworkattachmentsv2addnewinternalattachments"></a>
# **TaskWorkAttachmentsV2AddNewInternalAttachments**
> void TaskWorkAttachmentsV2AddNewInternalAttachments (int? docnumber, int? taskWorkId)

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
    public class TaskWorkAttachmentsV2AddNewInternalAttachmentsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkAttachmentsV2Api();
            var docnumber = 56;  // int? | Document identifier
            var taskWorkId = 56;  // int? | Taskwork identifier

            try
            {
                // This call adds a new internal attachments to a process
                apiInstance.TaskWorkAttachmentsV2AddNewInternalAttachments(docnumber, taskWorkId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkAttachmentsV2Api.TaskWorkAttachmentsV2AddNewInternalAttachments: " + e.Message );
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

<a name="taskworkattachmentsv2changetosendfortaskattachments"></a>
# **TaskWorkAttachmentsV2ChangeToSendForTaskAttachments**
> void TaskWorkAttachmentsV2ChangeToSendForTaskAttachments (int? attachmentId, bool? tosend)

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
    public class TaskWorkAttachmentsV2ChangeToSendForTaskAttachmentsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkAttachmentsV2Api();
            var attachmentId = 56;  // int? | Attachment identifier
            var tosend = true;  // bool? | Value of 'to send' flag

            try
            {
                // this call changes the value of the 'to send' flag for an attachment
                apiInstance.TaskWorkAttachmentsV2ChangeToSendForTaskAttachments(attachmentId, tosend);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkAttachmentsV2Api.TaskWorkAttachmentsV2ChangeToSendForTaskAttachments: " + e.Message );
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

<a name="taskworkattachmentsv2deletetaskattachementbyid"></a>
# **TaskWorkAttachmentsV2DeleteTaskAttachementById**
> void TaskWorkAttachmentsV2DeleteTaskAttachementById (int? attachmentId)

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
    public class TaskWorkAttachmentsV2DeleteTaskAttachementByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkAttachmentsV2Api();
            var attachmentId = 56;  // int? | Attachment identifier

            try
            {
                // This call deletes a process attachment
                apiInstance.TaskWorkAttachmentsV2DeleteTaskAttachementById(attachmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkAttachmentsV2Api.TaskWorkAttachmentsV2DeleteTaskAttachementById: " + e.Message );
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

<a name="taskworkattachmentsv2getattachmentsbyprocessid"></a>
# **TaskWorkAttachmentsV2GetAttachmentsByProcessId**
> Object TaskWorkAttachmentsV2GetAttachmentsByProcessId (int? processId)

This call returns all attachments of a process

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkAttachmentsV2GetAttachmentsByProcessIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkAttachmentsV2Api();
            var processId = 56;  // int? | Process identifier

            try
            {
                // This call returns all attachments of a process
                Object result = apiInstance.TaskWorkAttachmentsV2GetAttachmentsByProcessId(processId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkAttachmentsV2Api.TaskWorkAttachmentsV2GetAttachmentsByProcessId: " + e.Message );
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

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


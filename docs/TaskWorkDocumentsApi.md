# ARXivarNEXT.Client.Api.TaskWorkDocumentsApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TaskWorkDocumentsGetTaskWorkDocumentPreviewBufferId**](TaskWorkDocumentsApi.md#taskworkdocumentsgettaskworkdocumentpreviewbufferid) | **GET** /api/TaskWorkDocuments/documentPreviewBufferId | This call returns the bufferId for document preview


<a name="taskworkdocumentsgettaskworkdocumentpreviewbufferid"></a>
# **TaskWorkDocumentsGetTaskWorkDocumentPreviewBufferId**
> string TaskWorkDocumentsGetTaskWorkDocumentPreviewBufferId (int? processdocId, int? taskworkId)

This call returns the bufferId for document preview

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkDocumentsGetTaskWorkDocumentPreviewBufferIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkDocumentsApi();
            var processdocId = 56;  // int? | 
            var taskworkId = 56;  // int? | 

            try
            {
                // This call returns the bufferId for document preview
                string result = apiInstance.TaskWorkDocumentsGetTaskWorkDocumentPreviewBufferId(processdocId, taskworkId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkDocumentsApi.TaskWorkDocumentsGetTaskWorkDocumentPreviewBufferId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processdocId** | **int?**|  | 
 **taskworkId** | **int?**|  | 

### Return type

**string**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


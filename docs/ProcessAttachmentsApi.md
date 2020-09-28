# ARXivarNEXT.Client.Api.ProcessAttachmentsApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProcessAttachmentsInsertTaskAttachment**](ProcessAttachmentsApi.md#processattachmentsinserttaskattachment) | **POST** /api/ProcessAttachments | This call inserts a new process attachment


<a name="processattachmentsinserttaskattachment"></a>
# **ProcessAttachmentsInsertTaskAttachment**
> void ProcessAttachmentsInsertTaskAttachment (ProcessAttachmentInsertDto request)

This call inserts a new process attachment

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProcessAttachmentsInsertTaskAttachmentExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProcessAttachmentsApi();
            var request = new ProcessAttachmentInsertDto(); // ProcessAttachmentInsertDto | Process Attachment information to insert

            try
            {
                // This call inserts a new process attachment
                apiInstance.ProcessAttachmentsInsertTaskAttachment(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessAttachmentsApi.ProcessAttachmentsInsertTaskAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ProcessAttachmentInsertDto**](ProcessAttachmentInsertDto.md)| Process Attachment information to insert | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


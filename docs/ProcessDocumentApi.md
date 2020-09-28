# ARXivarNEXT.Client.Api.ProcessDocumentApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProcessDocumentFreeWorkflowConstraint**](ProcessDocumentApi.md#processdocumentfreeworkflowconstraint) | **POST** /api/ProcessDocument | This call frees a document from workflow constraint


<a name="processdocumentfreeworkflowconstraint"></a>
# **ProcessDocumentFreeWorkflowConstraint**
> void ProcessDocumentFreeWorkflowConstraint (int? docnumber)

This call frees a document from workflow constraint

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProcessDocumentFreeWorkflowConstraintExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProcessDocumentApi();
            var docnumber = 56;  // int? | Document Identifier

            try
            {
                // This call frees a document from workflow constraint
                apiInstance.ProcessDocumentFreeWorkflowConstraint(docnumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessDocumentApi.ProcessDocumentFreeWorkflowConstraint: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| Document Identifier | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


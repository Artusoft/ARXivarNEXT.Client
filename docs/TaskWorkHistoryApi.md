# ARXivarNEXT.Client.Api.TaskWorkHistoryApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TaskWorkHistoryGetHistoryByProcessId**](TaskWorkHistoryApi.md#taskworkhistorygethistorybyprocessid) | **GET** /api/TaskHistory/byProcessId/{processId} | This call returns the datasource of a process history


<a name="taskworkhistorygethistorybyprocessid"></a>
# **TaskWorkHistoryGetHistoryByProcessId**
> List<RowSearchResult> TaskWorkHistoryGetHistoryByProcessId (int? processId)

This call returns the datasource of a process history

This method is deprecated. Use api/v2/TaskHistory/byProcessId/{processId}

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkHistoryGetHistoryByProcessIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkHistoryApi();
            var processId = 56;  // int? | Process identifier

            try
            {
                // This call returns the datasource of a process history
                List&lt;RowSearchResult&gt; result = apiInstance.TaskWorkHistoryGetHistoryByProcessId(processId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkHistoryApi.TaskWorkHistoryGetHistoryByProcessId: " + e.Message );
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


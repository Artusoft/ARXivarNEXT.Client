# ARXivarNEXT.Client.Api.TaskWorkHistoryV2Api

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TaskWorkHistoryV2GetHistoryByProcessId**](TaskWorkHistoryV2Api.md#taskworkhistoryv2gethistorybyprocessid) | **GET** /api/v2/TaskHistory/byProcessId/{processId} | This call returns the datasource of a process history.  This call could not be compatible with some programming language, in this case use the call api/TaskHistory/byProcessId/{processId}


<a name="taskworkhistoryv2gethistorybyprocessid"></a>
# **TaskWorkHistoryV2GetHistoryByProcessId**
> Object TaskWorkHistoryV2GetHistoryByProcessId (int? processId)

This call returns the datasource of a process history.  This call could not be compatible with some programming language, in this case use the call api/TaskHistory/byProcessId/{processId}

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkHistoryV2GetHistoryByProcessIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkHistoryV2Api();
            var processId = 56;  // int? | Process identifier

            try
            {
                // This call returns the datasource of a process history.  This call could not be compatible with some programming language, in this case use the call api/TaskHistory/byProcessId/{processId}
                Object result = apiInstance.TaskWorkHistoryV2GetHistoryByProcessId(processId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkHistoryV2Api.TaskWorkHistoryV2GetHistoryByProcessId: " + e.Message );
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


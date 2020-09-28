# ARXivarNEXT.Client.Api.TaskWorkInstructionsApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TaskWorkInstructionsGetInstructionsByTaskWorkId**](TaskWorkInstructionsApi.md#taskworkinstructionsgetinstructionsbytaskworkid) | **GET** /api/TaskInstructions/byTaskWorkId/{taskWorkId} | This call returns the instruction of taskwork


<a name="taskworkinstructionsgetinstructionsbytaskworkid"></a>
# **TaskWorkInstructionsGetInstructionsByTaskWorkId**
> TaskWorkInstructionDTO TaskWorkInstructionsGetInstructionsByTaskWorkId (int? taskWorkId)

This call returns the instruction of taskwork

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskWorkInstructionsGetInstructionsByTaskWorkIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskWorkInstructionsApi();
            var taskWorkId = 56;  // int? | Taskwork identifier

            try
            {
                // This call returns the instruction of taskwork
                TaskWorkInstructionDTO result = apiInstance.TaskWorkInstructionsGetInstructionsByTaskWorkId(taskWorkId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskWorkInstructionsApi.TaskWorkInstructionsGetInstructionsByTaskWorkId: " + e.Message );
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

[**TaskWorkInstructionDTO**](TaskWorkInstructionDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


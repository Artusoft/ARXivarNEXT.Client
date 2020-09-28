# ARXivarNEXT.Client.Api.LogJsApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LogJsPost**](LogJsApi.md#logjspost) | **POST** /api/Jslog | This call adds a log item for client purpose (javascript)


<a name="logjspost"></a>
# **LogJsPost**
> void LogJsPost (Object logData)

This call adds a log item for client purpose (javascript)

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class LogJsPostExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LogJsApi();
            var logData = ;  // Object | Object the contains the data

            try
            {
                // This call adds a log item for client purpose (javascript)
                apiInstance.LogJsPost(logData);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogJsApi.LogJsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **logData** | **Object**| Object the contains the data | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


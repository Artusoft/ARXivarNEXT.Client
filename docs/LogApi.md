# ARXivarNEXT.Client.Api.LogApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LogGetLog**](LogApi.md#loggetlog) | **GET** /api/Log/{docNumber} | This call returns all log items for a document


<a name="loggetlog"></a>
# **LogGetLog**
> List<LogDTO> LogGetLog (int? docNumber)

This call returns all log items for a document

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class LogGetLogExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LogApi();
            var docNumber = 56;  // int? | Document identifier

            try
            {
                // This call returns all log items for a document
                List&lt;LogDTO&gt; result = apiInstance.LogGetLog(docNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogApi.LogGetLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docNumber** | **int?**| Document identifier | 

### Return type

[**List<LogDTO>**](LogDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# ARXivarNEXT.Client.Api.OperationApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OperationGetByElementType**](OperationApi.md#operationgetbyelementtype) | **GET** /api/LayoutOperation/Element/{elementType} | This call returns all possibile operations for the given layout element type


<a name="operationgetbyelementtype"></a>
# **OperationGetByElementType**
> Dictionary<string, string> OperationGetByElementType (int? elementType)

This call returns all possibile operations for the given layout element type

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class OperationGetByElementTypeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OperationApi();
            var elementType = 56;  // int? | Layout element type

            try
            {
                // This call returns all possibile operations for the given layout element type
                Dictionary&lt;string, string&gt; result = apiInstance.OperationGetByElementType(elementType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationApi.OperationGetByElementType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **elementType** | **int?**| Layout element type | 

### Return type

**Dictionary<string, string>**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


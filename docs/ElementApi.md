# ARXivarNEXT.Client.Api.ElementApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ElementGetByElementType**](ElementApi.md#elementgetbyelementtype) | **GET** /api/LayoutListElements/{elementType} | This call returns all possible single element that can be used for the specific element type


<a name="elementgetbyelementtype"></a>
# **ElementGetByElementType**
> List<KeyValueElementDto> ElementGetByElementType (int? elementType)

This call returns all possible single element that can be used for the specific element type

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ElementGetByElementTypeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ElementApi();
            var elementType = 56;  // int? | Kind of elements that the call should return

            try
            {
                // This call returns all possible single element that can be used for the specific element type
                List&lt;KeyValueElementDto&gt; result = apiInstance.ElementGetByElementType(elementType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ElementApi.ElementGetByElementType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **elementType** | **int?**| Kind of elements that the call should return | 

### Return type

[**List<KeyValueElementDto>**](KeyValueElementDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


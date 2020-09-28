# ARXivarNEXT.Client.Api.FullTextApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FullTextGetByDocnumber**](FullTextApi.md#fulltextgetbydocnumber) | **GET** /api/FullText/{docnumber} | This method return the texts contained in specified document
[**FullTextInsertByDocnumber**](FullTextApi.md#fulltextinsertbydocnumber) | **POST** /api/FullText/{docnumber} | This method insert the texts in specific document
[**FullTextUpdateByDocnumber**](FullTextApi.md#fulltextupdatebydocnumber) | **PUT** /api/FullText/{docnumber} | This method update the texts in specific document by ocr


<a name="fulltextgetbydocnumber"></a>
# **FullTextGetByDocnumber**
> List<FullTextDTO> FullTextGetByDocnumber (int? docnumber)

This method return the texts contained in specified document

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FullTextGetByDocnumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FullTextApi();
            var docnumber = 56;  // int? | The identifier of the document

            try
            {
                // This method return the texts contained in specified document
                List&lt;FullTextDTO&gt; result = apiInstance.FullTextGetByDocnumber(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FullTextApi.FullTextGetByDocnumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| The identifier of the document | 

### Return type

[**List<FullTextDTO>**](FullTextDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fulltextinsertbydocnumber"></a>
# **FullTextInsertByDocnumber**
> void FullTextInsertByDocnumber (int? docnumber, string text)

This method insert the texts in specific document

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FullTextInsertByDocnumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FullTextApi();
            var docnumber = 56;  // int? | The document identifier
            var text = text_example;  // string | The text of the document

            try
            {
                // This method insert the texts in specific document
                apiInstance.FullTextInsertByDocnumber(docnumber, text);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FullTextApi.FullTextInsertByDocnumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| The document identifier | 
 **text** | **string**| The text of the document | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fulltextupdatebydocnumber"></a>
# **FullTextUpdateByDocnumber**
> void FullTextUpdateByDocnumber (int? docnumber, string text)

This method update the texts in specific document by ocr

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FullTextUpdateByDocnumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FullTextApi();
            var docnumber = 56;  // int? | The document idenfier
            var text = text_example;  // string | The text of the document

            try
            {
                // This method update the texts in specific document by ocr
                apiInstance.FullTextUpdateByDocnumber(docnumber, text);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FullTextApi.FullTextUpdateByDocnumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| The document idenfier | 
 **text** | **string**| The text of the document | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


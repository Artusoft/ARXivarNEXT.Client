# ARXivarNEXT.Client.Api.DocToOcrApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DocToOcrDocToOcrQueue**](DocToOcrApi.md#doctoocrdoctoocrqueue) | **POST** /api/DocToOcr/{docnumber} | This method enqueue document to ocr
[**DocToOcrGetByDocnumber**](DocToOcrApi.md#doctoocrgetbydocnumber) | **GET** /api/DocToOcr/{docnumber} | This method return the texts containedin specified document


<a name="doctoocrdoctoocrqueue"></a>
# **DocToOcrDocToOcrQueue**
> void DocToOcrDocToOcrQueue (int? docnumber)

This method enqueue document to ocr

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocToOcrDocToOcrQueueExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocToOcrApi();
            var docnumber = 56;  // int? | Document Identifier

            try
            {
                // This method enqueue document to ocr
                apiInstance.DocToOcrDocToOcrQueue(docnumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocToOcrApi.DocToOcrDocToOcrQueue: " + e.Message );
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

<a name="doctoocrgetbydocnumber"></a>
# **DocToOcrGetByDocnumber**
> List<DocToOcrDTO> DocToOcrGetByDocnumber (int? docnumber)

This method return the texts containedin specified document

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocToOcrGetByDocnumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocToOcrApi();
            var docnumber = 56;  // int? | Document Identifier

            try
            {
                // This method return the texts containedin specified document
                List&lt;DocToOcrDTO&gt; result = apiInstance.DocToOcrGetByDocnumber(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocToOcrApi.DocToOcrGetByDocnumber: " + e.Message );
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

[**List<DocToOcrDTO>**](DocToOcrDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


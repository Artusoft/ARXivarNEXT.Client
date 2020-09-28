# ARXivarNEXT.Client.Api.FieldsSelectorApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FieldsSelectorGetForConfigureBarcodeTemplate**](FieldsSelectorApi.md#fieldsselectorgetforconfigurebarcodetemplate) | **GET** /api/FieldsSelector/ForConfigureBarcodeTemplate/byDocumenttype/{documentType}/{tipo2}/{tipo3} | This call returns the selector fields for barcode template associated with a specific document type


<a name="fieldsselectorgetforconfigurebarcodetemplate"></a>
# **FieldsSelectorGetForConfigureBarcodeTemplate**
> List<FieldBaseForSelectDTO> FieldsSelectorGetForConfigureBarcodeTemplate (int? documentType, int? tipo2, int? tipo3)

This call returns the selector fields for barcode template associated with a specific document type

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FieldsSelectorGetForConfigureBarcodeTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FieldsSelectorApi();
            var documentType = 56;  // int? | Document type of first level
            var tipo2 = 56;  // int? | Document type of second level
            var tipo3 = 56;  // int? | Document type of third level

            try
            {
                // This call returns the selector fields for barcode template associated with a specific document type
                List&lt;FieldBaseForSelectDTO&gt; result = apiInstance.FieldsSelectorGetForConfigureBarcodeTemplate(documentType, tipo2, tipo3);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldsSelectorApi.FieldsSelectorGetForConfigureBarcodeTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentType** | **int?**| Document type of first level | 
 **tipo2** | **int?**| Document type of second level | 
 **tipo3** | **int?**| Document type of third level | 

### Return type

[**List<FieldBaseForSelectDTO>**](FieldBaseForSelectDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# ARXivarNEXT.Client.Api.ClassAdditionalFieldsV2Api

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ClassAdditionalFieldsV2AdditionalFieldClassComposeValues**](ClassAdditionalFieldsV2Api.md#classadditionalfieldsv2additionalfieldclasscomposevalues) | **POST** /api/v2/ClassAdditionalFields/fieldclasscomposevalues/{fieldName}/{documentType}/{tipo2}/{tipo3} | This call retrieve the entire datasource for values in an class additional fields (the call compose columns based on call additional field configuration).  This call could not be compatible with some programming language, in this case use the call api/ClassAdditionalFields/fieldclasscomposevalues/{fieldName}/{documentType}/{tipo2}/{tipo3}
[**ClassAdditionalFieldsV2AdditionalFieldClassComposeValues_0**](ClassAdditionalFieldsV2Api.md#classadditionalfieldsv2additionalfieldclasscomposevalues_0) | **POST** /api/v2/ClassAdditionalFields/fieldclasscomposevalues/{fieldName}/{documentTypeSystemId} | This call retrieve the entire datasource for values in an class additional fields (the call compose columns based on call additional field configuration).  This call could not be compatible with some programming language, in this case use the call api/ClassAdditionalFields/fieldclasscomposevalues/{fieldName}/{documentTypeSystemId}


<a name="classadditionalfieldsv2additionalfieldclasscomposevalues"></a>
# **ClassAdditionalFieldsV2AdditionalFieldClassComposeValues**
> Object ClassAdditionalFieldsV2AdditionalFieldClassComposeValues (string fieldName, int? documentType, int? tipo2, int? tipo3, List<int?> docNumbers)

This call retrieve the entire datasource for values in an class additional fields (the call compose columns based on call additional field configuration).  This call could not be compatible with some programming language, in this case use the call api/ClassAdditionalFields/fieldclasscomposevalues/{fieldName}/{documentType}/{tipo2}/{tipo3}

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ClassAdditionalFieldsV2AdditionalFieldClassComposeValuesExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClassAdditionalFieldsV2Api();
            var fieldName = fieldName_example;  // string | Name of the additional field
            var documentType = 56;  // int? | Document type of first level
            var tipo2 = 56;  // int? | Document type of second level
            var tipo3 = 56;  // int? | Document type of third level
            var docNumbers = ;  // List<int?> | Documents Identifier in the additional field

            try
            {
                // This call retrieve the entire datasource for values in an class additional fields (the call compose columns based on call additional field configuration).  This call could not be compatible with some programming language, in this case use the call api/ClassAdditionalFields/fieldclasscomposevalues/{fieldName}/{documentType}/{tipo2}/{tipo3}
                Object result = apiInstance.ClassAdditionalFieldsV2AdditionalFieldClassComposeValues(fieldName, documentType, tipo2, tipo3, docNumbers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClassAdditionalFieldsV2Api.ClassAdditionalFieldsV2AdditionalFieldClassComposeValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fieldName** | **string**| Name of the additional field | 
 **documentType** | **int?**| Document type of first level | 
 **tipo2** | **int?**| Document type of second level | 
 **tipo3** | **int?**| Document type of third level | 
 **docNumbers** | **List&lt;int?&gt;**| Documents Identifier in the additional field | 

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="classadditionalfieldsv2additionalfieldclasscomposevalues_0"></a>
# **ClassAdditionalFieldsV2AdditionalFieldClassComposeValues_0**
> Object ClassAdditionalFieldsV2AdditionalFieldClassComposeValues_0 (string fieldName, int? documentTypeSystemId, List<int?> docNumbers)

This call retrieve the entire datasource for values in an class additional fields (the call compose columns based on call additional field configuration).  This call could not be compatible with some programming language, in this case use the call api/ClassAdditionalFields/fieldclasscomposevalues/{fieldName}/{documentTypeSystemId}

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ClassAdditionalFieldsV2AdditionalFieldClassComposeValues_0Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClassAdditionalFieldsV2Api();
            var fieldName = fieldName_example;  // string | Name of the additional field
            var documentTypeSystemId = 56;  // int? | Document type
            var docNumbers = ;  // List<int?> | Documents Identifier in the additional field

            try
            {
                // This call retrieve the entire datasource for values in an class additional fields (the call compose columns based on call additional field configuration).  This call could not be compatible with some programming language, in this case use the call api/ClassAdditionalFields/fieldclasscomposevalues/{fieldName}/{documentTypeSystemId}
                Object result = apiInstance.ClassAdditionalFieldsV2AdditionalFieldClassComposeValues_0(fieldName, documentTypeSystemId, docNumbers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClassAdditionalFieldsV2Api.ClassAdditionalFieldsV2AdditionalFieldClassComposeValues_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fieldName** | **string**| Name of the additional field | 
 **documentTypeSystemId** | **int?**| Document type | 
 **docNumbers** | **List&lt;int?&gt;**| Documents Identifier in the additional field | 

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


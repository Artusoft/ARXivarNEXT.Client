# ARXivarNEXT.Client.Api.StatesApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**StatesGet**](StatesApi.md#statesget) | **GET** /api/States/{documentTypeId} | This call returns all the states defined in Arxivar by the given document type
[**StatesGetByDocNumber**](StatesApi.md#statesgetbydocnumber) | **GET** /api/States/bydocnumber/{docnumber} | This call returns the document states for a document
[**StatesGet_0**](StatesApi.md#statesget_0) | **GET** /api/States | This call returns all the document states in ARXivar


<a name="statesget"></a>
# **StatesGet**
> List<StateBaseDto> StatesGet (int? documentTypeId)

This call returns all the states defined in Arxivar by the given document type

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class StatesGetExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StatesApi();
            var documentTypeId = 56;  // int? | Document Type Identifier

            try
            {
                // This call returns all the states defined in Arxivar by the given document type
                List&lt;StateBaseDto&gt; result = apiInstance.StatesGet(documentTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatesApi.StatesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentTypeId** | **int?**| Document Type Identifier | 

### Return type

[**List<StateBaseDto>**](StateBaseDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statesgetbydocnumber"></a>
# **StatesGetByDocNumber**
> StateBaseDto StatesGetByDocNumber (int? docnumber)

This call returns the document states for a document

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class StatesGetByDocNumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StatesApi();
            var docnumber = 56;  // int? | Document Identifier

            try
            {
                // This call returns the document states for a document
                StateBaseDto result = apiInstance.StatesGetByDocNumber(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatesApi.StatesGetByDocNumber: " + e.Message );
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

[**StateBaseDto**](StateBaseDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statesget_0"></a>
# **StatesGet_0**
> List<StateBaseDto> StatesGet_0 ()

This call returns all the document states in ARXivar

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class StatesGet_0Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StatesApi();

            try
            {
                // This call returns all the document states in ARXivar
                List&lt;StateBaseDto&gt; result = apiInstance.StatesGet_0();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatesApi.StatesGet_0: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<StateBaseDto>**](StateBaseDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# ARXivarNEXT.Client.Api.IxServicesApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IxServicesCanDeleteAccumulationPackage**](IxServicesApi.md#ixservicescandeleteaccumulationpackage) | **GET** /api/IxServices/{accumulationPackageId}/CanDelete | This method return the possibility for user to delete a accumulation package
[**IxServicesCanDeleteAccumulationPackageDocument**](IxServicesApi.md#ixservicescandeleteaccumulationpackagedocument) | **GET** /api/IxServices/Document/{accumulationPackageDocumentId}/CanDelete | This method return the possibility for user to delete a document in an accumulation package
[**IxServicesDeleteAccumulationPackage**](IxServicesApi.md#ixservicesdeleteaccumulationpackage) | **DELETE** /api/IxServices/{accumulationPackageId} | This method deletes a accumulation package
[**IxServicesDeleteAccumulationPackageDocument**](IxServicesApi.md#ixservicesdeleteaccumulationpackagedocument) | **DELETE** /api/IxServices/Document/{accumulationPackageDocumentId} | This method deletes a document in an accumulation package
[**IxServicesDetachAccumulationPackage**](IxServicesApi.md#ixservicesdetachaccumulationpackage) | **GET** /api/IxServices/{accumulationPackageId}/Detach | Detach the accumulation package from the WebSuite service. This call is required if the call CanDelete returns DetachRequired &#x3D; 2
[**IxServicesDetachAccumulationPackageDocument**](IxServicesApi.md#ixservicesdetachaccumulationpackagedocument) | **GET** /api/IxServices/Document/{accumulationPackageDocumentId}/Detach | Detach the document from the WebSuite service. This call is required if the call CanDelete returns DetachRequired &#x3D; 2
[**IxServicesGetAccumulationPackageDocumentValidationByDate**](IxServicesApi.md#ixservicesgetaccumulationpackagedocumentvalidationbydate) | **GET** /api/IxServices/Validation | This call return the status of the validations for accumulation package documents in a range of date
[**IxServicesGetByAoo**](IxServicesApi.md#ixservicesgetbyaoo) | **GET** /api/IxServices | This method return the accumulation packages contained in IX-CE services
[**IxServicesGetDocumentsByAccumulationPackageId**](IxServicesApi.md#ixservicesgetdocumentsbyaccumulationpackageid) | **GET** /api/IxServices/{accumulationPackageId}/Documents | This method return the document contained in IX-CE accumulation packages
[**IxServicesGetIxCeCompleteDetailsByDocnumber**](IxServicesApi.md#ixservicesgetixcecompletedetailsbydocnumber) | **GET** /api/IxServices/Document/{docnumber}/IxCeInfo | This call returns all the information about a document sent to IX-CE Service
[**IxServicesGetIxFeCompleteDetailsByDocnumber**](IxServicesApi.md#ixservicesgetixfecompletedetailsbydocnumber) | **GET** /api/IxServices/Document/{docnumber}/IxFeInfo | This call returns all the information about a document sent to IX-FE Service
[**IxServicesSendOutcomeByDocnumber**](IxServicesApi.md#ixservicessendoutcomebydocnumber) | **POST** /api/IxServices/SendOutcome | This call send an outcome value for a docnumber (for invoice from IX-CE service)
[**IxServicesSendToIx**](IxServicesApi.md#ixservicessendtoix) | **POST** /api/IxServices/SendToIxFe | This call send docnumbers to IX-FE services
[**IxServicesSendToIxCe**](IxServicesApi.md#ixservicessendtoixce) | **POST** /api/IxServices/SendToIxCe | This call send docnumbers to IX-CE services
[**IxServicesSendToIxFeSignRequired**](IxServicesApi.md#ixservicessendtoixfesignrequired) | **POST** /api/IxServices/SendToIxFeSignRequired | Checks is the docnumber list must be signed before being sent to IX-FE


<a name="ixservicescandeleteaccumulationpackage"></a>
# **IxServicesCanDeleteAccumulationPackage**
> AccumulationPackageDeleteStatus IxServicesCanDeleteAccumulationPackage (int? accumulationPackageId)

This method return the possibility for user to delete a accumulation package

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class IxServicesCanDeleteAccumulationPackageExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IxServicesApi();
            var accumulationPackageId = 56;  // int? | The id of the accumulation package

            try
            {
                // This method return the possibility for user to delete a accumulation package
                AccumulationPackageDeleteStatus result = apiInstance.IxServicesCanDeleteAccumulationPackage(accumulationPackageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IxServicesApi.IxServicesCanDeleteAccumulationPackage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accumulationPackageId** | **int?**| The id of the accumulation package | 

### Return type

[**AccumulationPackageDeleteStatus**](AccumulationPackageDeleteStatus.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ixservicescandeleteaccumulationpackagedocument"></a>
# **IxServicesCanDeleteAccumulationPackageDocument**
> AccumulationPackageDocumentDeleteStatus IxServicesCanDeleteAccumulationPackageDocument (int? accumulationPackageDocumentId)

This method return the possibility for user to delete a document in an accumulation package

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class IxServicesCanDeleteAccumulationPackageDocumentExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IxServicesApi();
            var accumulationPackageDocumentId = 56;  // int? | The code of the accumulation package document

            try
            {
                // This method return the possibility for user to delete a document in an accumulation package
                AccumulationPackageDocumentDeleteStatus result = apiInstance.IxServicesCanDeleteAccumulationPackageDocument(accumulationPackageDocumentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IxServicesApi.IxServicesCanDeleteAccumulationPackageDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accumulationPackageDocumentId** | **int?**| The code of the accumulation package document | 

### Return type

[**AccumulationPackageDocumentDeleteStatus**](AccumulationPackageDocumentDeleteStatus.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ixservicesdeleteaccumulationpackage"></a>
# **IxServicesDeleteAccumulationPackage**
> void IxServicesDeleteAccumulationPackage (int? accumulationPackageId)

This method deletes a accumulation package

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class IxServicesDeleteAccumulationPackageExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IxServicesApi();
            var accumulationPackageId = 56;  // int? | The id of the package

            try
            {
                // This method deletes a accumulation package
                apiInstance.IxServicesDeleteAccumulationPackage(accumulationPackageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IxServicesApi.IxServicesDeleteAccumulationPackage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accumulationPackageId** | **int?**| The id of the package | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ixservicesdeleteaccumulationpackagedocument"></a>
# **IxServicesDeleteAccumulationPackageDocument**
> void IxServicesDeleteAccumulationPackageDocument (int? accumulationPackageDocumentId)

This method deletes a document in an accumulation package

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class IxServicesDeleteAccumulationPackageDocumentExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IxServicesApi();
            var accumulationPackageDocumentId = 56;  // int? | The id of the document

            try
            {
                // This method deletes a document in an accumulation package
                apiInstance.IxServicesDeleteAccumulationPackageDocument(accumulationPackageDocumentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IxServicesApi.IxServicesDeleteAccumulationPackageDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accumulationPackageDocumentId** | **int?**| The id of the document | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ixservicesdetachaccumulationpackage"></a>
# **IxServicesDetachAccumulationPackage**
> void IxServicesDetachAccumulationPackage (int? accumulationPackageId)

Detach the accumulation package from the WebSuite service. This call is required if the call CanDelete returns DetachRequired = 2

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class IxServicesDetachAccumulationPackageExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IxServicesApi();
            var accumulationPackageId = 56;  // int? | 

            try
            {
                // Detach the accumulation package from the WebSuite service. This call is required if the call CanDelete returns DetachRequired = 2
                apiInstance.IxServicesDetachAccumulationPackage(accumulationPackageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IxServicesApi.IxServicesDetachAccumulationPackage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accumulationPackageId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ixservicesdetachaccumulationpackagedocument"></a>
# **IxServicesDetachAccumulationPackageDocument**
> void IxServicesDetachAccumulationPackageDocument (int? accumulationPackageDocumentId)

Detach the document from the WebSuite service. This call is required if the call CanDelete returns DetachRequired = 2

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class IxServicesDetachAccumulationPackageDocumentExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IxServicesApi();
            var accumulationPackageDocumentId = 56;  // int? | The code of the accumulation package document

            try
            {
                // Detach the document from the WebSuite service. This call is required if the call CanDelete returns DetachRequired = 2
                apiInstance.IxServicesDetachAccumulationPackageDocument(accumulationPackageDocumentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IxServicesApi.IxServicesDetachAccumulationPackageDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accumulationPackageDocumentId** | **int?**| The code of the accumulation package document | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ixservicesgetaccumulationpackagedocumentvalidationbydate"></a>
# **IxServicesGetAccumulationPackageDocumentValidationByDate**
> List<AccumulationPackageDocumentValidationDTO> IxServicesGetAccumulationPackageDocumentValidationByDate (DateTime? startDate, DateTime? endDate)

This call return the status of the validations for accumulation package documents in a range of date

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class IxServicesGetAccumulationPackageDocumentValidationByDateExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IxServicesApi();
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | End date

            try
            {
                // This call return the status of the validations for accumulation package documents in a range of date
                List&lt;AccumulationPackageDocumentValidationDTO&gt; result = apiInstance.IxServicesGetAccumulationPackageDocumentValidationByDate(startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IxServicesApi.IxServicesGetAccumulationPackageDocumentValidationByDate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **DateTime?**| Start date | 
 **endDate** | **DateTime?**| End date | 

### Return type

[**List<AccumulationPackageDocumentValidationDTO>**](AccumulationPackageDocumentValidationDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ixservicesgetbyaoo"></a>
# **IxServicesGetByAoo**
> List<AccumulationPackageDTO> IxServicesGetByAoo (string businessUnitCode)

This method return the accumulation packages contained in IX-CE services

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class IxServicesGetByAooExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IxServicesApi();
            var businessUnitCode = businessUnitCode_example;  // string | The code of the business unit

            try
            {
                // This method return the accumulation packages contained in IX-CE services
                List&lt;AccumulationPackageDTO&gt; result = apiInstance.IxServicesGetByAoo(businessUnitCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IxServicesApi.IxServicesGetByAoo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **businessUnitCode** | **string**| The code of the business unit | 

### Return type

[**List<AccumulationPackageDTO>**](AccumulationPackageDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ixservicesgetdocumentsbyaccumulationpackageid"></a>
# **IxServicesGetDocumentsByAccumulationPackageId**
> List<IxCeDocumentDTO> IxServicesGetDocumentsByAccumulationPackageId (int? accumulationPackageId)

This method return the document contained in IX-CE accumulation packages

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class IxServicesGetDocumentsByAccumulationPackageIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IxServicesApi();
            var accumulationPackageId = 56;  // int? | The code of the accumulation package

            try
            {
                // This method return the document contained in IX-CE accumulation packages
                List&lt;IxCeDocumentDTO&gt; result = apiInstance.IxServicesGetDocumentsByAccumulationPackageId(accumulationPackageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IxServicesApi.IxServicesGetDocumentsByAccumulationPackageId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accumulationPackageId** | **int?**| The code of the accumulation package | 

### Return type

[**List<IxCeDocumentDTO>**](IxCeDocumentDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ixservicesgetixcecompletedetailsbydocnumber"></a>
# **IxServicesGetIxCeCompleteDetailsByDocnumber**
> List<IxCeDocumentCompleteDTO> IxServicesGetIxCeCompleteDetailsByDocnumber (int? docnumber)

This call returns all the information about a document sent to IX-CE Service

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class IxServicesGetIxCeCompleteDetailsByDocnumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IxServicesApi();
            var docnumber = 56;  // int? | Docnumber

            try
            {
                // This call returns all the information about a document sent to IX-CE Service
                List&lt;IxCeDocumentCompleteDTO&gt; result = apiInstance.IxServicesGetIxCeCompleteDetailsByDocnumber(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IxServicesApi.IxServicesGetIxCeCompleteDetailsByDocnumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| Docnumber | 

### Return type

[**List<IxCeDocumentCompleteDTO>**](IxCeDocumentCompleteDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ixservicesgetixfecompletedetailsbydocnumber"></a>
# **IxServicesGetIxFeCompleteDetailsByDocnumber**
> List<IxFeDocumentCompleteDTO> IxServicesGetIxFeCompleteDetailsByDocnumber (int? docnumber)

This call returns all the information about a document sent to IX-FE Service

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class IxServicesGetIxFeCompleteDetailsByDocnumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IxServicesApi();
            var docnumber = 56;  // int? | Docnumber

            try
            {
                // This call returns all the information about a document sent to IX-FE Service
                List&lt;IxFeDocumentCompleteDTO&gt; result = apiInstance.IxServicesGetIxFeCompleteDetailsByDocnumber(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IxServicesApi.IxServicesGetIxFeCompleteDetailsByDocnumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| Docnumber | 

### Return type

[**List<IxFeDocumentCompleteDTO>**](IxFeDocumentCompleteDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ixservicessendoutcomebydocnumber"></a>
# **IxServicesSendOutcomeByDocnumber**
> void IxServicesSendOutcomeByDocnumber (SendOutcomeRequestDTO request)

This call send an outcome value for a docnumber (for invoice from IX-CE service)

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class IxServicesSendOutcomeByDocnumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IxServicesApi();
            var request = new SendOutcomeRequestDTO(); // SendOutcomeRequestDTO | 

            try
            {
                // This call send an outcome value for a docnumber (for invoice from IX-CE service)
                apiInstance.IxServicesSendOutcomeByDocnumber(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IxServicesApi.IxServicesSendOutcomeByDocnumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SendOutcomeRequestDTO**](SendOutcomeRequestDTO.md)|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ixservicessendtoix"></a>
# **IxServicesSendToIx**
> IxFeSendResponseDTO IxServicesSendToIx (IxFeSendRequestDTO request)

This call send docnumbers to IX-FE services

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class IxServicesSendToIxExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IxServicesApi();
            var request = new IxFeSendRequestDTO(); // IxFeSendRequestDTO | 

            try
            {
                // This call send docnumbers to IX-FE services
                IxFeSendResponseDTO result = apiInstance.IxServicesSendToIx(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IxServicesApi.IxServicesSendToIx: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**IxFeSendRequestDTO**](IxFeSendRequestDTO.md)|  | 

### Return type

[**IxFeSendResponseDTO**](IxFeSendResponseDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ixservicessendtoixce"></a>
# **IxServicesSendToIxCe**
> void IxServicesSendToIxCe (SendToIxCeRequestDTO request)

This call send docnumbers to IX-CE services

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class IxServicesSendToIxCeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IxServicesApi();
            var request = new SendToIxCeRequestDTO(); // SendToIxCeRequestDTO | 

            try
            {
                // This call send docnumbers to IX-CE services
                apiInstance.IxServicesSendToIxCe(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IxServicesApi.IxServicesSendToIxCe: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SendToIxCeRequestDTO**](SendToIxCeRequestDTO.md)|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ixservicessendtoixfesignrequired"></a>
# **IxServicesSendToIxFeSignRequired**
> bool? IxServicesSendToIxFeSignRequired (SendToIxFeSignRequiredRequestDto request)

Checks is the docnumber list must be signed before being sent to IX-FE

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class IxServicesSendToIxFeSignRequiredExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IxServicesApi();
            var request = new SendToIxFeSignRequiredRequestDto(); // SendToIxFeSignRequiredRequestDto | 

            try
            {
                // Checks is the docnumber list must be signed before being sent to IX-FE
                bool? result = apiInstance.IxServicesSendToIxFeSignRequired(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IxServicesApi.IxServicesSendToIxFeSignRequired: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SendToIxFeSignRequiredRequestDto**](SendToIxFeSignRequiredRequestDto.md)|  | 

### Return type

**bool?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


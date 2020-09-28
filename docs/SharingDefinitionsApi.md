# ARXivarNEXT.Client.Api.SharingDefinitionsApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SharingDefinitionsGetNewSharingDefinition**](SharingDefinitionsApi.md#sharingdefinitionsgetnewsharingdefinition) | **GET** /api/SharingDefinitions/New | 
[**SharingDefinitionsGetSharingDefinitions**](SharingDefinitionsApi.md#sharingdefinitionsgetsharingdefinitions) | **GET** /api/SharingDefinitions | 
[**SharingDefinitionsGetSharingDefinitionsByDocumentTypeIdAndAooCode**](SharingDefinitionsApi.md#sharingdefinitionsgetsharingdefinitionsbydocumenttypeidandaoocode) | **POST** /api/SharingDefinitions/GetByAooAndDocumentType | 
[**SharingDefinitionsGetSharingDefinitionsById**](SharingDefinitionsApi.md#sharingdefinitionsgetsharingdefinitionsbyid) | **GET** /api/SharingDefinitions/ById/{sharingId} | 
[**SharingDefinitionsInsertSharingDefinition**](SharingDefinitionsApi.md#sharingdefinitionsinsertsharingdefinition) | **POST** /api/SharingDefinitions | 
[**SharingDefinitionsIsArxLinkConfigured**](SharingDefinitionsApi.md#sharingdefinitionsisarxlinkconfigured) | **GET** /api/SharingDefinitions/IsConfigured | 
[**SharingDefinitionsSharingDefinitionDeleteById**](SharingDefinitionsApi.md#sharingdefinitionssharingdefinitiondeletebyid) | **DELETE** /api/SharingDefinitions/{sharingDefinitionId} | 
[**SharingDefinitionsUpdateSharingDefinition**](SharingDefinitionsApi.md#sharingdefinitionsupdatesharingdefinition) | **PUT** /api/SharingDefinitions | 


<a name="sharingdefinitionsgetnewsharingdefinition"></a>
# **SharingDefinitionsGetNewSharingDefinition**
> SharingDefinitionDTO SharingDefinitionsGetNewSharingDefinition ()



### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SharingDefinitionsGetNewSharingDefinitionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SharingDefinitionsApi();

            try
            {
                SharingDefinitionDTO result = apiInstance.SharingDefinitionsGetNewSharingDefinition();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SharingDefinitionsApi.SharingDefinitionsGetNewSharingDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SharingDefinitionDTO**](SharingDefinitionDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sharingdefinitionsgetsharingdefinitions"></a>
# **SharingDefinitionsGetSharingDefinitions**
> List<SharingDefinitionDTO> SharingDefinitionsGetSharingDefinitions ()



### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SharingDefinitionsGetSharingDefinitionsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SharingDefinitionsApi();

            try
            {
                List&lt;SharingDefinitionDTO&gt; result = apiInstance.SharingDefinitionsGetSharingDefinitions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SharingDefinitionsApi.SharingDefinitionsGetSharingDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<SharingDefinitionDTO>**](SharingDefinitionDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sharingdefinitionsgetsharingdefinitionsbydocumenttypeidandaoocode"></a>
# **SharingDefinitionsGetSharingDefinitionsByDocumentTypeIdAndAooCode**
> SharingDefinitionDTO SharingDefinitionsGetSharingDefinitionsByDocumentTypeIdAndAooCode (GetSharingDefinitionsByDocumentTypeIdAndAooCodeRequestDTO request)



### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SharingDefinitionsGetSharingDefinitionsByDocumentTypeIdAndAooCodeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SharingDefinitionsApi();
            var request = new GetSharingDefinitionsByDocumentTypeIdAndAooCodeRequestDTO(); // GetSharingDefinitionsByDocumentTypeIdAndAooCodeRequestDTO | 

            try
            {
                SharingDefinitionDTO result = apiInstance.SharingDefinitionsGetSharingDefinitionsByDocumentTypeIdAndAooCode(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SharingDefinitionsApi.SharingDefinitionsGetSharingDefinitionsByDocumentTypeIdAndAooCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**GetSharingDefinitionsByDocumentTypeIdAndAooCodeRequestDTO**](GetSharingDefinitionsByDocumentTypeIdAndAooCodeRequestDTO.md)|  | 

### Return type

[**SharingDefinitionDTO**](SharingDefinitionDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sharingdefinitionsgetsharingdefinitionsbyid"></a>
# **SharingDefinitionsGetSharingDefinitionsById**
> SharingDefinitionDTO SharingDefinitionsGetSharingDefinitionsById (string sharingId)



### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SharingDefinitionsGetSharingDefinitionsByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SharingDefinitionsApi();
            var sharingId = sharingId_example;  // string | 

            try
            {
                SharingDefinitionDTO result = apiInstance.SharingDefinitionsGetSharingDefinitionsById(sharingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SharingDefinitionsApi.SharingDefinitionsGetSharingDefinitionsById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sharingId** | **string**|  | 

### Return type

[**SharingDefinitionDTO**](SharingDefinitionDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sharingdefinitionsinsertsharingdefinition"></a>
# **SharingDefinitionsInsertSharingDefinition**
> SharingDefinitionInsertResult SharingDefinitionsInsertSharingDefinition (SharingDefinitionDTO sharingDefinition)



### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SharingDefinitionsInsertSharingDefinitionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SharingDefinitionsApi();
            var sharingDefinition = new SharingDefinitionDTO(); // SharingDefinitionDTO | 

            try
            {
                SharingDefinitionInsertResult result = apiInstance.SharingDefinitionsInsertSharingDefinition(sharingDefinition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SharingDefinitionsApi.SharingDefinitionsInsertSharingDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sharingDefinition** | [**SharingDefinitionDTO**](SharingDefinitionDTO.md)|  | 

### Return type

[**SharingDefinitionInsertResult**](SharingDefinitionInsertResult.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sharingdefinitionsisarxlinkconfigured"></a>
# **SharingDefinitionsIsArxLinkConfigured**
> bool? SharingDefinitionsIsArxLinkConfigured ()



### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SharingDefinitionsIsArxLinkConfiguredExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SharingDefinitionsApi();

            try
            {
                bool? result = apiInstance.SharingDefinitionsIsArxLinkConfigured();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SharingDefinitionsApi.SharingDefinitionsIsArxLinkConfigured: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**bool?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sharingdefinitionssharingdefinitiondeletebyid"></a>
# **SharingDefinitionsSharingDefinitionDeleteById**
> void SharingDefinitionsSharingDefinitionDeleteById (string sharingDefinitionId)



### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SharingDefinitionsSharingDefinitionDeleteByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SharingDefinitionsApi();
            var sharingDefinitionId = sharingDefinitionId_example;  // string | 

            try
            {
                apiInstance.SharingDefinitionsSharingDefinitionDeleteById(sharingDefinitionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SharingDefinitionsApi.SharingDefinitionsSharingDefinitionDeleteById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sharingDefinitionId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sharingdefinitionsupdatesharingdefinition"></a>
# **SharingDefinitionsUpdateSharingDefinition**
> SharingDefinitionInsertResult SharingDefinitionsUpdateSharingDefinition (SharingDefinitionDTO sharingDefinition)



### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SharingDefinitionsUpdateSharingDefinitionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SharingDefinitionsApi();
            var sharingDefinition = new SharingDefinitionDTO(); // SharingDefinitionDTO | 

            try
            {
                SharingDefinitionInsertResult result = apiInstance.SharingDefinitionsUpdateSharingDefinition(sharingDefinition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SharingDefinitionsApi.SharingDefinitionsUpdateSharingDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sharingDefinition** | [**SharingDefinitionDTO**](SharingDefinitionDTO.md)|  | 

### Return type

[**SharingDefinitionInsertResult**](SharingDefinitionInsertResult.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


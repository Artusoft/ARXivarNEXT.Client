# ARXivarNEXT.Client.Api.DocumentTypesApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DocumentTypesGet**](DocumentTypesApi.md#documenttypesget) | **GET** /api/DocumentTypes/{mode}/mode | This call returns the document types that the user can access
[**DocumentTypesGetBySystemId**](DocumentTypesApi.md#documenttypesgetbysystemid) | **GET** /api/DocumentTypes/{documentTypeId} | This call returns a specific document type
[**DocumentTypesGetOld**](DocumentTypesApi.md#documenttypesgetold) | **GET** /api/DocumentTypes/{mode}/mode/{businessunitcode} | This call returns the document types that the user can access
[**DocumentTypesGetTree**](DocumentTypesApi.md#documenttypesgettree) | **GET** /api/DocumentTypes/GetTree/{mode} | This call returns the document types that the user can access but in a preformatted tree with parent/child relationship
[**DocumentTypesGetTreeOld**](DocumentTypesApi.md#documenttypesgettreeold) | **GET** /api/DocumentTypes/GetTree/{mode}/{businessunitcode}/{forProtocol} | This call returns the document types that the user can access but in a preformatted tree with parent/child relationship


<a name="documenttypesget"></a>
# **DocumentTypesGet**
> List<DocumentTypeBaseDTO> DocumentTypesGet (int? mode, string businessUnitCode = null)

This call returns the document types that the user can access

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentTypesGetExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentTypesApi();
            var mode = 56;  // int? | Possible values:  0: Archive  1: Search  2: EditProfile 
            var businessUnitCode = businessUnitCode_example;  // string | Business Unit (optional) (optional) 

            try
            {
                // This call returns the document types that the user can access
                List&lt;DocumentTypeBaseDTO&gt; result = apiInstance.DocumentTypesGet(mode, businessUnitCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTypesApi.DocumentTypesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mode** | **int?**| Possible values:  0: Archive  1: Search  2: EditProfile  | 
 **businessUnitCode** | **string**| Business Unit (optional) | [optional] 

### Return type

[**List<DocumentTypeBaseDTO>**](DocumentTypeBaseDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documenttypesgetbysystemid"></a>
# **DocumentTypesGetBySystemId**
> DocumentTypeBaseDTO DocumentTypesGetBySystemId (int? documentTypeId)

This call returns a specific document type

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentTypesGetBySystemIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentTypesApi();
            var documentTypeId = 56;  // int? | Document Type id

            try
            {
                // This call returns a specific document type
                DocumentTypeBaseDTO result = apiInstance.DocumentTypesGetBySystemId(documentTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTypesApi.DocumentTypesGetBySystemId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentTypeId** | **int?**| Document Type id | 

### Return type

[**DocumentTypeBaseDTO**](DocumentTypeBaseDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documenttypesgetold"></a>
# **DocumentTypesGetOld**
> List<DocumentTypeBaseDTO> DocumentTypesGetOld (int? mode, string businessunitcode)

This call returns the document types that the user can access

This method is deprecated. Use /api/DocumentTypes/{mode}/mode?businessunitcode={businessunitcode}

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentTypesGetOldExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentTypesApi();
            var mode = 56;  // int? | Possible values:  0: Archive  1: Search  2: EditProfile 
            var businessunitcode = businessunitcode_example;  // string | Business Unit (optional)

            try
            {
                // This call returns the document types that the user can access
                List&lt;DocumentTypeBaseDTO&gt; result = apiInstance.DocumentTypesGetOld(mode, businessunitcode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTypesApi.DocumentTypesGetOld: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mode** | **int?**| Possible values:  0: Archive  1: Search  2: EditProfile  | 
 **businessunitcode** | **string**| Business Unit (optional) | 

### Return type

[**List<DocumentTypeBaseDTO>**](DocumentTypeBaseDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documenttypesgettree"></a>
# **DocumentTypesGetTree**
> DocumentTypeBaseTreeDTO DocumentTypesGetTree (int? mode, string businessunitcode = null)

This call returns the document types that the user can access but in a preformatted tree with parent/child relationship

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentTypesGetTreeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentTypesApi();
            var mode = 56;  // int? | Possible values:  0: Archive  1: Search  2: EditProfile 
            var businessunitcode = businessunitcode_example;  // string | Business Unit (optional) (optional) 

            try
            {
                // This call returns the document types that the user can access but in a preformatted tree with parent/child relationship
                DocumentTypeBaseTreeDTO result = apiInstance.DocumentTypesGetTree(mode, businessunitcode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTypesApi.DocumentTypesGetTree: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mode** | **int?**| Possible values:  0: Archive  1: Search  2: EditProfile  | 
 **businessunitcode** | **string**| Business Unit (optional) | [optional] 

### Return type

[**DocumentTypeBaseTreeDTO**](DocumentTypeBaseTreeDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documenttypesgettreeold"></a>
# **DocumentTypesGetTreeOld**
> DocumentTypeBaseTreeDTO DocumentTypesGetTreeOld (int? mode, string businessunitcode, bool? forProtocol)

This call returns the document types that the user can access but in a preformatted tree with parent/child relationship

This method is deprecated. Use /api/DocumentTypes/GetTree/{mode}?businessunitcode={businessunitcode}

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentTypesGetTreeOldExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentTypesApi();
            var mode = 56;  // int? | Possible values:  0: Archive  1: Search  2: EditProfile 
            var businessunitcode = businessunitcode_example;  // string | Business Unit (optional)
            var forProtocol = true;  // bool? | If the type is of Protocol (PA) (default false)

            try
            {
                // This call returns the document types that the user can access but in a preformatted tree with parent/child relationship
                DocumentTypeBaseTreeDTO result = apiInstance.DocumentTypesGetTreeOld(mode, businessunitcode, forProtocol);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTypesApi.DocumentTypesGetTreeOld: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mode** | **int?**| Possible values:  0: Archive  1: Search  2: EditProfile  | 
 **businessunitcode** | **string**| Business Unit (optional) | 
 **forProtocol** | **bool?**| If the type is of Protocol (PA) (default false) | 

### Return type

[**DocumentTypeBaseTreeDTO**](DocumentTypeBaseTreeDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


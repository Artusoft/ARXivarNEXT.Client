# ARXivarNEXT.Client.Api.MasksApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MasksCanUpgradeToAdvanced**](MasksApi.md#maskscanupgradetoadvanced) | **GET** /api/Masks/{maskId}/CanUpgradeToAdvanced | Tells if the mask can be upgraded to advanced
[**MasksCloneMask**](MasksApi.md#masksclonemask) | **POST** /api/Masks/{id}/Clone | This call clones a mask
[**MasksDelete**](MasksApi.md#masksdelete) | **DELETE** /api/Masks/{id} | This call deletes a mask
[**MasksGetById**](MasksApi.md#masksgetbyid) | **GET** /api/Masks/{id} | This call returns a mask by its identifier
[**MasksGetDocumentTypesByMaskId**](MasksApi.md#masksgetdocumenttypesbymaskid) | **GET** /api/Masks/{maskId}/DocumentTypes | This call returns all possibile Document Types for a mask
[**MasksGetDocumentTypesByMaskIdOld**](MasksApi.md#masksgetdocumenttypesbymaskidold) | **GET** /api/Masks/{maskId}/DocumentTypes/{businessUnitCode} | This call returns all possibile Document Types for a mask
[**MasksGetDocumentTypesTreeByMaskId**](MasksApi.md#masksgetdocumenttypestreebymaskid) | **GET** /api/Masks/{maskId}/DocumentTypesTree | This call returns all possibile Document Types for a mask (tree format)
[**MasksGetDocumentTypesTreeByMaskIdOld**](MasksApi.md#masksgetdocumenttypestreebymaskidold) | **GET** /api/Masks/{maskId}/DocumentTypesTree/{businessUnitCode} | This call returns all possibile Document Types for a mask (tree format)
[**MasksGetFieldsByClasse**](MasksApi.md#masksgetfieldsbyclasse) | **GET** /api/Masks/fieldsbydocumenttype/{systemid} | This call returns possibile fields by a Document Type
[**MasksGetList**](MasksApi.md#masksgetlist) | **GET** /api/Masks | This call returns all masks
[**MasksGetPermission**](MasksApi.md#masksgetpermission) | **GET** /api/Masks/{maskId}/Permissions | This call returns the permissions for a mask
[**MasksGetProfileForClasseBox**](MasksApi.md#masksgetprofileforclassebox) | **POST** /api/Masks/byclassadditionalfield/{additionalFieldName}/profileSchema | This calls returns the profile schema for a mask associated to a class additional field
[**MasksGetProfileSchemaByMaskId**](MasksApi.md#masksgetprofileschemabymaskid) | **GET** /api/Masks/{maskId}/profileSchema | This call returns the profile schema by a mask
[**MasksGetRoot**](MasksApi.md#masksgetroot) | **GET** /api/Masks/root | This call returns the root mask
[**MasksInserMask**](MasksApi.md#masksinsermask) | **POST** /api/Masks | This call inserts a new mask
[**MasksPost**](MasksApi.md#maskspost) | **POST** /api/Masks/{maskId}/Profile | This call executes a new profiling
[**MasksSetPermission**](MasksApi.md#maskssetpermission) | **POST** /api/Masks/{maskId}/Permissions | This call updates the permissions for a mask
[**MasksUpdateMask**](MasksApi.md#masksupdatemask) | **PUT** /api/Masks/{id} | This call updates a mask


<a name="maskscanupgradetoadvanced"></a>
# **MasksCanUpgradeToAdvanced**
> bool? MasksCanUpgradeToAdvanced (string maskId)

Tells if the mask can be upgraded to advanced

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MasksCanUpgradeToAdvancedExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MasksApi();
            var maskId = maskId_example;  // string | 

            try
            {
                // Tells if the mask can be upgraded to advanced
                bool? result = apiInstance.MasksCanUpgradeToAdvanced(maskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasksApi.MasksCanUpgradeToAdvanced: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **maskId** | **string**|  | 

### Return type

**bool?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="masksclonemask"></a>
# **MasksCloneMask**
> void MasksCloneMask (string id, MaskCloneOptionsDto cloneOptions)

This call clones a mask

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MasksCloneMaskExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MasksApi();
            var id = id_example;  // string | Identifier of the mask
            var cloneOptions = new MaskCloneOptionsDto(); // MaskCloneOptionsDto | Options to use for cloning

            try
            {
                // This call clones a mask
                apiInstance.MasksCloneMask(id, cloneOptions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasksApi.MasksCloneMask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier of the mask | 
 **cloneOptions** | [**MaskCloneOptionsDto**](MaskCloneOptionsDto.md)| Options to use for cloning | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="masksdelete"></a>
# **MasksDelete**
> Object MasksDelete (string id)

This call deletes a mask

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MasksDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MasksApi();
            var id = id_example;  // string | Identifier of the mask

            try
            {
                // This call deletes a mask
                Object result = apiInstance.MasksDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasksApi.MasksDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier of the mask | 

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="masksgetbyid"></a>
# **MasksGetById**
> MaskDTO MasksGetById (string id)

This call returns a mask by its identifier

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MasksGetByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MasksApi();
            var id = id_example;  // string | Identifier of the mask

            try
            {
                // This call returns a mask by its identifier
                MaskDTO result = apiInstance.MasksGetById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasksApi.MasksGetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier of the mask | 

### Return type

[**MaskDTO**](MaskDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="masksgetdocumenttypesbymaskid"></a>
# **MasksGetDocumentTypesByMaskId**
> List<DocumentTypeBaseDTO> MasksGetDocumentTypesByMaskId (string maskId, string businessUnitCode = null)

This call returns all possibile Document Types for a mask

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MasksGetDocumentTypesByMaskIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MasksApi();
            var maskId = maskId_example;  // string | Identifier of the mask
            var businessUnitCode = businessUnitCode_example;  // string | Business Unit Code (optional) 

            try
            {
                // This call returns all possibile Document Types for a mask
                List&lt;DocumentTypeBaseDTO&gt; result = apiInstance.MasksGetDocumentTypesByMaskId(maskId, businessUnitCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasksApi.MasksGetDocumentTypesByMaskId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **maskId** | **string**| Identifier of the mask | 
 **businessUnitCode** | **string**| Business Unit Code | [optional] 

### Return type

[**List<DocumentTypeBaseDTO>**](DocumentTypeBaseDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="masksgetdocumenttypesbymaskidold"></a>
# **MasksGetDocumentTypesByMaskIdOld**
> List<DocumentTypeBaseDTO> MasksGetDocumentTypesByMaskIdOld (string maskId, string businessUnitCode)

This call returns all possibile Document Types for a mask

This method is deprecated. Use api/Masks/{maskId}/DocumentTypes?businessunitcode={businessunitcode}

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MasksGetDocumentTypesByMaskIdOldExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MasksApi();
            var maskId = maskId_example;  // string | Identifier of the mask
            var businessUnitCode = businessUnitCode_example;  // string | Business Unit Code

            try
            {
                // This call returns all possibile Document Types for a mask
                List&lt;DocumentTypeBaseDTO&gt; result = apiInstance.MasksGetDocumentTypesByMaskIdOld(maskId, businessUnitCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasksApi.MasksGetDocumentTypesByMaskIdOld: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **maskId** | **string**| Identifier of the mask | 
 **businessUnitCode** | **string**| Business Unit Code | 

### Return type

[**List<DocumentTypeBaseDTO>**](DocumentTypeBaseDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="masksgetdocumenttypestreebymaskid"></a>
# **MasksGetDocumentTypesTreeByMaskId**
> DocumentTypeBaseTreeDTO MasksGetDocumentTypesTreeByMaskId (string maskId, string businessUnitCode = null)

This call returns all possibile Document Types for a mask (tree format)

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MasksGetDocumentTypesTreeByMaskIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MasksApi();
            var maskId = maskId_example;  // string | Identifier of the mask
            var businessUnitCode = businessUnitCode_example;  // string | Business Unit Code (optional) 

            try
            {
                // This call returns all possibile Document Types for a mask (tree format)
                DocumentTypeBaseTreeDTO result = apiInstance.MasksGetDocumentTypesTreeByMaskId(maskId, businessUnitCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasksApi.MasksGetDocumentTypesTreeByMaskId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **maskId** | **string**| Identifier of the mask | 
 **businessUnitCode** | **string**| Business Unit Code | [optional] 

### Return type

[**DocumentTypeBaseTreeDTO**](DocumentTypeBaseTreeDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="masksgetdocumenttypestreebymaskidold"></a>
# **MasksGetDocumentTypesTreeByMaskIdOld**
> DocumentTypeBaseTreeDTO MasksGetDocumentTypesTreeByMaskIdOld (string maskId, string businessUnitCode)

This call returns all possibile Document Types for a mask (tree format)

This method is deprecated. Use api/Masks/{maskId}/DocumentTypesTree?businessunitcode={businessunitcode}

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MasksGetDocumentTypesTreeByMaskIdOldExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MasksApi();
            var maskId = maskId_example;  // string | Identifier of the mask
            var businessUnitCode = businessUnitCode_example;  // string | Business Unit Code

            try
            {
                // This call returns all possibile Document Types for a mask (tree format)
                DocumentTypeBaseTreeDTO result = apiInstance.MasksGetDocumentTypesTreeByMaskIdOld(maskId, businessUnitCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasksApi.MasksGetDocumentTypesTreeByMaskIdOld: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **maskId** | **string**| Identifier of the mask | 
 **businessUnitCode** | **string**| Business Unit Code | 

### Return type

[**DocumentTypeBaseTreeDTO**](DocumentTypeBaseTreeDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="masksgetfieldsbyclasse"></a>
# **MasksGetFieldsByClasse**
> List<MaskDetailDTO> MasksGetFieldsByClasse (int? systemid)

This call returns possibile fields by a Document Type

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MasksGetFieldsByClasseExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MasksApi();
            var systemid = 56;  // int? | Document Type Identifier

            try
            {
                // This call returns possibile fields by a Document Type
                List&lt;MaskDetailDTO&gt; result = apiInstance.MasksGetFieldsByClasse(systemid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasksApi.MasksGetFieldsByClasse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemid** | **int?**| Document Type Identifier | 

### Return type

[**List<MaskDetailDTO>**](MaskDetailDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="masksgetlist"></a>
# **MasksGetList**
> List<MaskDTO> MasksGetList ()

This call returns all masks

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MasksGetListExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MasksApi();

            try
            {
                // This call returns all masks
                List&lt;MaskDTO&gt; result = apiInstance.MasksGetList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasksApi.MasksGetList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<MaskDTO>**](MaskDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="masksgetpermission"></a>
# **MasksGetPermission**
> PermissionsDTO MasksGetPermission (string maskId)

This call returns the permissions for a mask

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MasksGetPermissionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MasksApi();
            var maskId = maskId_example;  // string | Identifier of the mask

            try
            {
                // This call returns the permissions for a mask
                PermissionsDTO result = apiInstance.MasksGetPermission(maskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasksApi.MasksGetPermission: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **maskId** | **string**| Identifier of the mask | 

### Return type

[**PermissionsDTO**](PermissionsDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="masksgetprofileforclassebox"></a>
# **MasksGetProfileForClasseBox**
> MaskProfileSchemaDTO MasksGetProfileForClasseBox (string additionalFieldName, ProfileDTO profile = null)

This calls returns the profile schema for a mask associated to a class additional field

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MasksGetProfileForClasseBoxExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MasksApi();
            var additionalFieldName = additionalFieldName_example;  // string | Additional name
            var profile = new ProfileDTO(); // ProfileDTO |  (optional) 

            try
            {
                // This calls returns the profile schema for a mask associated to a class additional field
                MaskProfileSchemaDTO result = apiInstance.MasksGetProfileForClasseBox(additionalFieldName, profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasksApi.MasksGetProfileForClasseBox: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **additionalFieldName** | **string**| Additional name | 
 **profile** | [**ProfileDTO**](ProfileDTO.md)|  | [optional] 

### Return type

[**MaskProfileSchemaDTO**](MaskProfileSchemaDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="masksgetprofileschemabymaskid"></a>
# **MasksGetProfileSchemaByMaskId**
> MaskProfileSchemaDTO MasksGetProfileSchemaByMaskId (string maskId)

This call returns the profile schema by a mask

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MasksGetProfileSchemaByMaskIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MasksApi();
            var maskId = maskId_example;  // string | Identifier of the mask

            try
            {
                // This call returns the profile schema by a mask
                MaskProfileSchemaDTO result = apiInstance.MasksGetProfileSchemaByMaskId(maskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasksApi.MasksGetProfileSchemaByMaskId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **maskId** | **string**| Identifier of the mask | 

### Return type

[**MaskProfileSchemaDTO**](MaskProfileSchemaDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="masksgetroot"></a>
# **MasksGetRoot**
> MaskDTO MasksGetRoot ()

This call returns the root mask

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MasksGetRootExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MasksApi();

            try
            {
                // This call returns the root mask
                MaskDTO result = apiInstance.MasksGetRoot();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasksApi.MasksGetRoot: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**MaskDTO**](MaskDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="masksinsermask"></a>
# **MasksInserMask**
> void MasksInserMask (MaskDTO mask = null)

This call inserts a new mask

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MasksInserMaskExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MasksApi();
            var mask = new MaskDTO(); // MaskDTO |  (optional) 

            try
            {
                // This call inserts a new mask
                apiInstance.MasksInserMask(mask);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasksApi.MasksInserMask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mask** | [**MaskDTO**](MaskDTO.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="maskspost"></a>
# **MasksPost**
> ProfileResultDTO MasksPost (string maskId, ProfileDTO profile = null)

This call executes a new profiling

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MasksPostExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MasksApi();
            var maskId = maskId_example;  // string | Identifier of the mask
            var profile = new ProfileDTO(); // ProfileDTO |  (optional) 

            try
            {
                // This call executes a new profiling
                ProfileResultDTO result = apiInstance.MasksPost(maskId, profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasksApi.MasksPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **maskId** | **string**| Identifier of the mask | 
 **profile** | [**ProfileDTO**](ProfileDTO.md)|  | [optional] 

### Return type

[**ProfileResultDTO**](ProfileResultDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="maskssetpermission"></a>
# **MasksSetPermission**
> void MasksSetPermission (string maskId, PermissionsDTO permissions)

This call updates the permissions for a mask

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MasksSetPermissionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MasksApi();
            var maskId = maskId_example;  // string | Identifier of the mask
            var permissions = new PermissionsDTO(); // PermissionsDTO | Permissions to update

            try
            {
                // This call updates the permissions for a mask
                apiInstance.MasksSetPermission(maskId, permissions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasksApi.MasksSetPermission: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **maskId** | **string**| Identifier of the mask | 
 **permissions** | [**PermissionsDTO**](PermissionsDTO.md)| Permissions to update | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="masksupdatemask"></a>
# **MasksUpdateMask**
> MaskDTO MasksUpdateMask (string id, MaskDTO mask = null)

This call updates a mask

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MasksUpdateMaskExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MasksApi();
            var id = id_example;  // string | Identifier of the mask
            var mask = new MaskDTO(); // MaskDTO |  (optional) 

            try
            {
                // This call updates a mask
                MaskDTO result = apiInstance.MasksUpdateMask(id, mask);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasksApi.MasksUpdateMask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier of the mask | 
 **mask** | [**MaskDTO**](MaskDTO.md)|  | [optional] 

### Return type

[**MaskDTO**](MaskDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# ARXivarNEXT.Client.Api.ProfilesApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProfilesArchiveMonitoredFolderFileFromBufferAutomatic**](ProfilesApi.md#profilesarchivemonitoredfolderfilefrombufferautomatic) | **POST** /api/Profiles/formonitoredfolder/{bufferId} | This call insert new profile from automatic monitored folder file
[**ProfilesDeleteIdErpById**](ProfilesApi.md#profilesdeleteiderpbyid) | **DELETE** /api/Profiles/iderp/byId/{id} | This call deletes association between Docnumber and IdErp
[**ProfilesDeleteProfile**](ProfilesApi.md#profilesdeleteprofile) | **DELETE** /api/Profiles/{docNumber} | This call deletes a document
[**ProfilesGet**](ProfilesApi.md#profilesget) | **GET** /api/Profiles/detail/{docNumber} | This call returns the mask schema of a document
[**ProfilesGetAdditionalAll**](ProfilesApi.md#profilesgetadditionalall) | **GET** /api/Profiles/Additional/All | This call returns the list of the additional field for archiving cross all classes and business units
[**ProfilesGetAdditionalByClasse**](ProfilesApi.md#profilesgetadditionalbyclasse) | **GET** /api/Profiles/Additional/{tipoUno}/{tipoDue}/{tipoTre} | This call returns the list of the additional field for archiving by the given business unit and document class (including groups)
[**ProfilesGetAdditionalByClasseOld**](ProfilesApi.md#profilesgetadditionalbyclasseold) | **GET** /api/Profiles/Additional/{tipoUno}/{tipoDue}/{tipoTre}/{aoo} | This call returns the list of the additional field for archiving by the given business unit and document class (including groups)
[**ProfilesGetByDocumentType**](ProfilesApi.md#profilesgetbydocumenttype) | **POST** /api/Profiles/bydocumenttype | This call allows the retrieval of the default profile for archiving by given document type
[**ProfilesGetByIdErp**](ProfilesApi.md#profilesgetbyiderp) | **GET** /api/Profiles/detail/byIdErp/{iderp} | This call returns the mask schema of documents by idErp
[**ProfilesGetByIdErp_0**](ProfilesApi.md#profilesgetbyiderp_0) | **POST** /api/Profiles/detail/byIdErp | This call returns the mask schema of documents by idErp
[**ProfilesGetDocnumberIdErpAssociationByDocnumber**](ProfilesApi.md#profilesgetdocnumberiderpassociationbydocnumber) | **GET** /api/Profiles/iderp/byDocnumber/{docnumber} | this call returns all association with idErps for a specific docnumber
[**ProfilesGetDocnumberIdErpAssociationByIdErp**](ProfilesApi.md#profilesgetdocnumberiderpassociationbyiderp) | **GET** /api/Profiles/iderp/byIdErp/{idErp} | this call returns all association with docnumbers for a specific idErp
[**ProfilesGetDocnumberIdErpAssociationByIdErp_0**](ProfilesApi.md#profilesgetdocnumberiderpassociationbyiderp_0) | **POST** /api/Profiles/iderp/byIdErp | this call returns all association with docnumbers for a specific idErp
[**ProfilesGetFiltersForArchive**](ProfilesApi.md#profilesgetfiltersforarchive) | **POST** /api/Profiles/Filters | This call returns the list of filter avaible for a specific additional field
[**ProfilesGetForBarcode**](ProfilesApi.md#profilesgetforbarcode) | **GET** /api/Profiles/forbarcode | This call allows the retrieval of the default profile for archiving barcode
[**ProfilesGetForClone**](ProfilesApi.md#profilesgetforclone) | **GET** /api/Profiles/clone/{docNumber}/{includefile} | This call clones a document
[**ProfilesGetForTask**](ProfilesApi.md#profilesgetfortask) | **GET** /api/Profiles/detail/{docNumber}/task/{taskId} | This call returns the mask schema of a document in a taskwork
[**ProfilesGetForTask_0**](ProfilesApi.md#profilesgetfortask_0) | **GET** /api/Profiles/detail/{docNumber}/task/{taskId}/{switched} | This call returns the mask schema of a document in a taskwork
[**ProfilesGetFormulaForArchive**](ProfilesApi.md#profilesgetformulaforarchive) | **POST** /api/Profiles/Formula | This call returns the result of a formula given the array of fields of profile and their value
[**ProfilesGetSchema**](ProfilesApi.md#profilesgetschema) | **GET** /api/Profiles/{docNumber}/schema/{switched} | This call returns the edit schema of a document
[**ProfilesGetSchema_0**](ProfilesApi.md#profilesgetschema_0) | **GET** /api/Profiles/formonitoredfolder/{bufferId} | This call returns the edit schema of a document from a file for a monitored folder
[**ProfilesGetValuesForArchive**](ProfilesApi.md#profilesgetvaluesforarchive) | **POST** /api/Profiles/Values | This call returns the possible values ​​for an external data source given the additional field code and the value of all other fields in profile
[**ProfilesGet_0**](ProfilesApi.md#profilesget_0) | **GET** /api/Profiles | This call allows the retrieval of the default profile for archiving
[**ProfilesInsertIdErp**](ProfilesApi.md#profilesinsertiderp) | **POST** /api/Profiles/iderp | This call insert new association between Docnumber and IdErp
[**ProfilesLockProfile**](ProfilesApi.md#profileslockprofile) | **POST** /api/Profiles/lock/{docNumber} | This call checks if a profile is lock
[**ProfilesLockProfile_0**](ProfilesApi.md#profileslockprofile_0) | **POST** /api/Profiles/lock/{docNumber}/taskid/{taskId} | This call checks if a profile is lock
[**ProfilesPost**](ProfilesApi.md#profilespost) | **POST** /api/Profiles | This call inserts a new profile
[**ProfilesPostForBarcode**](ProfilesApi.md#profilespostforbarcode) | **POST** /api/Profiles/forbarcode | This call allows the insertion of new profile for barcode purpose
[**ProfilesPut**](ProfilesApi.md#profilesput) | **PUT** /api/Profiles/{docnumber} | This call updates an existent profile
[**ProfilesUnLockProfile**](ProfilesApi.md#profilesunlockprofile) | **POST** /api/Profiles/unlock/{docNumber} | This call checks if a profile is not lock
[**ProfilesUnLockProfile_0**](ProfilesApi.md#profilesunlockprofile_0) | **POST** /api/Profiles/unlock/{docNumber}/taskid/{taskid} | This call checks if a profile is not lock
[**ProfilesValidateForArchive**](ProfilesApi.md#profilesvalidateforarchive) | **POST** /api/Profiles/Validation | This call returns the result of a validation given the array of fields of profile and their value


<a name="profilesarchivemonitoredfolderfilefrombufferautomatic"></a>
# **ProfilesArchiveMonitoredFolderFileFromBufferAutomatic**
> void ProfilesArchiveMonitoredFolderFileFromBufferAutomatic (string bufferId)

This call insert new profile from automatic monitored folder file

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesArchiveMonitoredFolderFileFromBufferAutomaticExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var bufferId = bufferId_example;  // string | File from monitored folder in buffer

            try
            {
                // This call insert new profile from automatic monitored folder file
                apiInstance.ProfilesArchiveMonitoredFolderFileFromBufferAutomatic(bufferId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesArchiveMonitoredFolderFileFromBufferAutomatic: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bufferId** | **string**| File from monitored folder in buffer | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesdeleteiderpbyid"></a>
# **ProfilesDeleteIdErpById**
> void ProfilesDeleteIdErpById (int? id)

This call deletes association between Docnumber and IdErp

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesDeleteIdErpByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var id = 56;  // int? | Association id for External Id and profile to delete

            try
            {
                // This call deletes association between Docnumber and IdErp
                apiInstance.ProfilesDeleteIdErpById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesDeleteIdErpById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Association id for External Id and profile to delete | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesdeleteprofile"></a>
# **ProfilesDeleteProfile**
> void ProfilesDeleteProfile (int? docNumber)

This call deletes a document

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesDeleteProfileExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var docNumber = 56;  // int? | Document Identfier to delete

            try
            {
                // This call deletes a document
                apiInstance.ProfilesDeleteProfile(docNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesDeleteProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docNumber** | **int?**| Document Identfier to delete | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesget"></a>
# **ProfilesGet**
> EditProfileSchemaDTO ProfilesGet (int? docNumber)

This call returns the mask schema of a document

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesGetExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var docNumber = 56;  // int? | Document Identifier

            try
            {
                // This call returns the mask schema of a document
                EditProfileSchemaDTO result = apiInstance.ProfilesGet(docNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docNumber** | **int?**| Document Identifier | 

### Return type

[**EditProfileSchemaDTO**](EditProfileSchemaDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesgetadditionalall"></a>
# **ProfilesGetAdditionalAll**
> List<FieldBaseDTO> ProfilesGetAdditionalAll ()

This call returns the list of the additional field for archiving cross all classes and business units

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesGetAdditionalAllExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();

            try
            {
                // This call returns the list of the additional field for archiving cross all classes and business units
                List&lt;FieldBaseDTO&gt; result = apiInstance.ProfilesGetAdditionalAll();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesGetAdditionalAll: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<FieldBaseDTO>**](FieldBaseDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesgetadditionalbyclasse"></a>
# **ProfilesGetAdditionalByClasse**
> List<FieldBaseDTO> ProfilesGetAdditionalByClasse (int? tipoUno, int? tipoDue, int? tipoTre, string aoo = null)

This call returns the list of the additional field for archiving by the given business unit and document class (including groups)

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesGetAdditionalByClasseExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var tipoUno = 56;  // int? | Document Type Identifier of first level
            var tipoDue = 56;  // int? | DocumentType Identifier of second level
            var tipoTre = 56;  // int? | DocumentType Identifier of third level
            var aoo = aoo_example;  // string | Business unit code (optional) 

            try
            {
                // This call returns the list of the additional field for archiving by the given business unit and document class (including groups)
                List&lt;FieldBaseDTO&gt; result = apiInstance.ProfilesGetAdditionalByClasse(tipoUno, tipoDue, tipoTre, aoo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesGetAdditionalByClasse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tipoUno** | **int?**| Document Type Identifier of first level | 
 **tipoDue** | **int?**| DocumentType Identifier of second level | 
 **tipoTre** | **int?**| DocumentType Identifier of third level | 
 **aoo** | **string**| Business unit code | [optional] 

### Return type

[**List<FieldBaseDTO>**](FieldBaseDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesgetadditionalbyclasseold"></a>
# **ProfilesGetAdditionalByClasseOld**
> List<FieldBaseDTO> ProfilesGetAdditionalByClasseOld (int? tipoUno, int? tipoDue, int? tipoTre, string aoo)

This call returns the list of the additional field for archiving by the given business unit and document class (including groups)

This method is deprecated. Use /api/Profiles/Additional/{tipoUno}/{tipoDue}/{tipoTre}?aoo={aoo}

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesGetAdditionalByClasseOldExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var tipoUno = 56;  // int? | Document Type Identifier of first level
            var tipoDue = 56;  // int? | DocumentType Identifier of second level
            var tipoTre = 56;  // int? | DocumentType Identifier of third level
            var aoo = aoo_example;  // string | Business unit code

            try
            {
                // This call returns the list of the additional field for archiving by the given business unit and document class (including groups)
                List&lt;FieldBaseDTO&gt; result = apiInstance.ProfilesGetAdditionalByClasseOld(tipoUno, tipoDue, tipoTre, aoo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesGetAdditionalByClasseOld: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tipoUno** | **int?**| Document Type Identifier of first level | 
 **tipoDue** | **int?**| DocumentType Identifier of second level | 
 **tipoTre** | **int?**| DocumentType Identifier of third level | 
 **aoo** | **string**| Business unit code | 

### Return type

[**List<FieldBaseDTO>**](FieldBaseDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesgetbydocumenttype"></a>
# **ProfilesGetByDocumentType**
> MaskProfileSchemaDTO ProfilesGetByDocumentType (GetByDocumentTypeRequestDTO documenttypecode)

This call allows the retrieval of the default profile for archiving by given document type

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesGetByDocumentTypeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var documenttypecode = new GetByDocumentTypeRequestDTO(); // GetByDocumentTypeRequestDTO | Document type code

            try
            {
                // This call allows the retrieval of the default profile for archiving by given document type
                MaskProfileSchemaDTO result = apiInstance.ProfilesGetByDocumentType(documenttypecode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesGetByDocumentType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documenttypecode** | [**GetByDocumentTypeRequestDTO**](GetByDocumentTypeRequestDTO.md)| Document type code | 

### Return type

[**MaskProfileSchemaDTO**](MaskProfileSchemaDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesgetbyiderp"></a>
# **ProfilesGetByIdErp**
> List<EditProfileSchemaDTO> ProfilesGetByIdErp (string iderp)

This call returns the mask schema of documents by idErp

Use detail/byIdErp

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesGetByIdErpExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var iderp = iderp_example;  // string | Document external Identifier

            try
            {
                // This call returns the mask schema of documents by idErp
                List&lt;EditProfileSchemaDTO&gt; result = apiInstance.ProfilesGetByIdErp(iderp);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesGetByIdErp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **iderp** | **string**| Document external Identifier | 

### Return type

[**List<EditProfileSchemaDTO>**](EditProfileSchemaDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesgetbyiderp_0"></a>
# **ProfilesGetByIdErp_0**
> List<EditProfileSchemaDTO> ProfilesGetByIdErp_0 (ByIdErpDto idErpDto)

This call returns the mask schema of documents by idErp

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesGetByIdErp_0Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var idErpDto = new ByIdErpDto(); // ByIdErpDto | 

            try
            {
                // This call returns the mask schema of documents by idErp
                List&lt;EditProfileSchemaDTO&gt; result = apiInstance.ProfilesGetByIdErp_0(idErpDto);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesGetByIdErp_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idErpDto** | [**ByIdErpDto**](ByIdErpDto.md)|  | 

### Return type

[**List<EditProfileSchemaDTO>**](EditProfileSchemaDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesgetdocnumberiderpassociationbydocnumber"></a>
# **ProfilesGetDocnumberIdErpAssociationByDocnumber**
> List<DocnumberIdErpAssociationDTO> ProfilesGetDocnumberIdErpAssociationByDocnumber (int? docnumber)

this call returns all association with idErps for a specific docnumber

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesGetDocnumberIdErpAssociationByDocnumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var docnumber = 56;  // int? | Docnumber to search

            try
            {
                // this call returns all association with idErps for a specific docnumber
                List&lt;DocnumberIdErpAssociationDTO&gt; result = apiInstance.ProfilesGetDocnumberIdErpAssociationByDocnumber(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesGetDocnumberIdErpAssociationByDocnumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| Docnumber to search | 

### Return type

[**List<DocnumberIdErpAssociationDTO>**](DocnumberIdErpAssociationDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesgetdocnumberiderpassociationbyiderp"></a>
# **ProfilesGetDocnumberIdErpAssociationByIdErp**
> List<DocnumberIdErpAssociationDTO> ProfilesGetDocnumberIdErpAssociationByIdErp (string idErp)

this call returns all association with docnumbers for a specific idErp

Use iderp/byIdErp

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesGetDocnumberIdErpAssociationByIdErpExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var idErp = idErp_example;  // string | IdErp to search

            try
            {
                // this call returns all association with docnumbers for a specific idErp
                List&lt;DocnumberIdErpAssociationDTO&gt; result = apiInstance.ProfilesGetDocnumberIdErpAssociationByIdErp(idErp);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesGetDocnumberIdErpAssociationByIdErp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idErp** | **string**| IdErp to search | 

### Return type

[**List<DocnumberIdErpAssociationDTO>**](DocnumberIdErpAssociationDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesgetdocnumberiderpassociationbyiderp_0"></a>
# **ProfilesGetDocnumberIdErpAssociationByIdErp_0**
> List<DocnumberIdErpAssociationDTO> ProfilesGetDocnumberIdErpAssociationByIdErp_0 (ByIdErpDto idErpDto)

this call returns all association with docnumbers for a specific idErp

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesGetDocnumberIdErpAssociationByIdErp_0Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var idErpDto = new ByIdErpDto(); // ByIdErpDto | 

            try
            {
                // this call returns all association with docnumbers for a specific idErp
                List&lt;DocnumberIdErpAssociationDTO&gt; result = apiInstance.ProfilesGetDocnumberIdErpAssociationByIdErp_0(idErpDto);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesGetDocnumberIdErpAssociationByIdErp_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idErpDto** | [**ByIdErpDto**](ByIdErpDto.md)|  | 

### Return type

[**List<DocnumberIdErpAssociationDTO>**](DocnumberIdErpAssociationDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesgetfiltersforarchive"></a>
# **ProfilesGetFiltersForArchive**
> FieldFilterDTO ProfilesGetFiltersForArchive (FieldValuesArchiveCriteriaDto fieldcriteria = null)

This call returns the list of filter avaible for a specific additional field

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesGetFiltersForArchiveExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var fieldcriteria = new FieldValuesArchiveCriteriaDto(); // FieldValuesArchiveCriteriaDto |  (optional) 

            try
            {
                // This call returns the list of filter avaible for a specific additional field
                FieldFilterDTO result = apiInstance.ProfilesGetFiltersForArchive(fieldcriteria);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesGetFiltersForArchive: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fieldcriteria** | [**FieldValuesArchiveCriteriaDto**](FieldValuesArchiveCriteriaDto.md)|  | [optional] 

### Return type

[**FieldFilterDTO**](FieldFilterDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesgetforbarcode"></a>
# **ProfilesGetForBarcode**
> MaskProfileSchemaDTO ProfilesGetForBarcode ()

This call allows the retrieval of the default profile for archiving barcode

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesGetForBarcodeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();

            try
            {
                // This call allows the retrieval of the default profile for archiving barcode
                MaskProfileSchemaDTO result = apiInstance.ProfilesGetForBarcode();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesGetForBarcode: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**MaskProfileSchemaDTO**](MaskProfileSchemaDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesgetforclone"></a>
# **ProfilesGetForClone**
> MaskProfileSchemaDTO ProfilesGetForClone (int? docNumber, bool? includefile)

This call clones a document

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesGetForCloneExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var docNumber = 56;  // int? | Document Identifier
            var includefile = true;  // bool? | Specify if the clone operation must include file

            try
            {
                // This call clones a document
                MaskProfileSchemaDTO result = apiInstance.ProfilesGetForClone(docNumber, includefile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesGetForClone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docNumber** | **int?**| Document Identifier | 
 **includefile** | **bool?**| Specify if the clone operation must include file | 

### Return type

[**MaskProfileSchemaDTO**](MaskProfileSchemaDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesgetfortask"></a>
# **ProfilesGetForTask**
> EditProfileSchemaDTO ProfilesGetForTask (int? docNumber, int? taskId)

This call returns the mask schema of a document in a taskwork

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesGetForTaskExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var docNumber = 56;  // int? | Document Identifier
            var taskId = 56;  // int? | TaskWork Identifier

            try
            {
                // This call returns the mask schema of a document in a taskwork
                EditProfileSchemaDTO result = apiInstance.ProfilesGetForTask(docNumber, taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesGetForTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docNumber** | **int?**| Document Identifier | 
 **taskId** | **int?**| TaskWork Identifier | 

### Return type

[**EditProfileSchemaDTO**](EditProfileSchemaDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesgetfortask_0"></a>
# **ProfilesGetForTask_0**
> EditProfileSchemaDTO ProfilesGetForTask_0 (int? docNumber, int? taskId, bool? switched)

This call returns the mask schema of a document in a taskwork

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesGetForTask_0Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var docNumber = 56;  // int? | Document Identifier
            var taskId = 56;  // int? | TaskWork Identifier
            var switched = true;  // bool? | 

            try
            {
                // This call returns the mask schema of a document in a taskwork
                EditProfileSchemaDTO result = apiInstance.ProfilesGetForTask_0(docNumber, taskId, switched);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesGetForTask_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docNumber** | **int?**| Document Identifier | 
 **taskId** | **int?**| TaskWork Identifier | 
 **switched** | **bool?**|  | 

### Return type

[**EditProfileSchemaDTO**](EditProfileSchemaDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesgetformulaforarchive"></a>
# **ProfilesGetFormulaForArchive**
> string ProfilesGetFormulaForArchive (FieldFormulaCalculateArchiveCriteriaDto fieldcriteria = null)

This call returns the result of a formula given the array of fields of profile and their value

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesGetFormulaForArchiveExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var fieldcriteria = new FieldFormulaCalculateArchiveCriteriaDto(); // FieldFormulaCalculateArchiveCriteriaDto |  (optional) 

            try
            {
                // This call returns the result of a formula given the array of fields of profile and their value
                string result = apiInstance.ProfilesGetFormulaForArchive(fieldcriteria);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesGetFormulaForArchive: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fieldcriteria** | [**FieldFormulaCalculateArchiveCriteriaDto**](FieldFormulaCalculateArchiveCriteriaDto.md)|  | [optional] 

### Return type

**string**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesgetschema"></a>
# **ProfilesGetSchema**
> EditProfileSchemaDTO ProfilesGetSchema (int? docNumber, bool? switched)

This call returns the edit schema of a document

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesGetSchemaExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var docNumber = 56;  // int? | Document Identifier
            var switched = true;  // bool? | 

            try
            {
                // This call returns the edit schema of a document
                EditProfileSchemaDTO result = apiInstance.ProfilesGetSchema(docNumber, switched);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesGetSchema: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docNumber** | **int?**| Document Identifier | 
 **switched** | **bool?**|  | 

### Return type

[**EditProfileSchemaDTO**](EditProfileSchemaDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesgetschema_0"></a>
# **ProfilesGetSchema_0**
> MaskProfileSchemaDTO ProfilesGetSchema_0 (string bufferId)

This call returns the edit schema of a document from a file for a monitored folder

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesGetSchema_0Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var bufferId = bufferId_example;  // string | buffer Identifier

            try
            {
                // This call returns the edit schema of a document from a file for a monitored folder
                MaskProfileSchemaDTO result = apiInstance.ProfilesGetSchema_0(bufferId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesGetSchema_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bufferId** | **string**| buffer Identifier | 

### Return type

[**MaskProfileSchemaDTO**](MaskProfileSchemaDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesgetvaluesforarchive"></a>
# **ProfilesGetValuesForArchive**
> FieldValuesDTO ProfilesGetValuesForArchive (FieldValuesArchiveCriteriaDto fieldcriteria = null)

This call returns the possible values ​​for an external data source given the additional field code and the value of all other fields in profile

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesGetValuesForArchiveExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var fieldcriteria = new FieldValuesArchiveCriteriaDto(); // FieldValuesArchiveCriteriaDto |  (optional) 

            try
            {
                // This call returns the possible values ​​for an external data source given the additional field code and the value of all other fields in profile
                FieldValuesDTO result = apiInstance.ProfilesGetValuesForArchive(fieldcriteria);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesGetValuesForArchive: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fieldcriteria** | [**FieldValuesArchiveCriteriaDto**](FieldValuesArchiveCriteriaDto.md)|  | [optional] 

### Return type

[**FieldValuesDTO**](FieldValuesDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesget_0"></a>
# **ProfilesGet_0**
> MaskProfileSchemaDTO ProfilesGet_0 ()

This call allows the retrieval of the default profile for archiving

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesGet_0Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();

            try
            {
                // This call allows the retrieval of the default profile for archiving
                MaskProfileSchemaDTO result = apiInstance.ProfilesGet_0();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesGet_0: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**MaskProfileSchemaDTO**](MaskProfileSchemaDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesinsertiderp"></a>
# **ProfilesInsertIdErp**
> void ProfilesInsertIdErp (DocnumberIdErpAssociationDTO docnumberIdErpAssociation)

This call insert new association between Docnumber and IdErp

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesInsertIdErpExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var docnumberIdErpAssociation = new DocnumberIdErpAssociationDTO(); // DocnumberIdErpAssociationDTO | Association DTO between Docnumber and External Id

            try
            {
                // This call insert new association between Docnumber and IdErp
                apiInstance.ProfilesInsertIdErp(docnumberIdErpAssociation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesInsertIdErp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumberIdErpAssociation** | [**DocnumberIdErpAssociationDTO**](DocnumberIdErpAssociationDTO.md)| Association DTO between Docnumber and External Id | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profileslockprofile"></a>
# **ProfilesLockProfile**
> bool? ProfilesLockProfile (int? docNumber)

This call checks if a profile is lock

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesLockProfileExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var docNumber = 56;  // int? | Document Identifier

            try
            {
                // This call checks if a profile is lock
                bool? result = apiInstance.ProfilesLockProfile(docNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesLockProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docNumber** | **int?**| Document Identifier | 

### Return type

**bool?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profileslockprofile_0"></a>
# **ProfilesLockProfile_0**
> bool? ProfilesLockProfile_0 (int? docNumber, int? taskId)

This call checks if a profile is lock

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesLockProfile_0Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var docNumber = 56;  // int? | Document Identifier
            var taskId = 56;  // int? | Id of task work

            try
            {
                // This call checks if a profile is lock
                bool? result = apiInstance.ProfilesLockProfile_0(docNumber, taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesLockProfile_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docNumber** | **int?**| Document Identifier | 
 **taskId** | **int?**| Id of task work | 

### Return type

**bool?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilespost"></a>
# **ProfilesPost**
> ProfileResultDTO ProfilesPost (ProfileDTO profile = null)

This call inserts a new profile

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesPostExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var profile = new ProfileDTO(); // ProfileDTO |  (optional) 

            try
            {
                // This call inserts a new profile
                ProfileResultDTO result = apiInstance.ProfilesPost(profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **profile** | [**ProfileDTO**](ProfileDTO.md)|  | [optional] 

### Return type

[**ProfileResultDTO**](ProfileResultDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilespostforbarcode"></a>
# **ProfilesPostForBarcode**
> ProfileResultDTO ProfilesPostForBarcode (ProfileDTO profile = null)

This call allows the insertion of new profile for barcode purpose

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesPostForBarcodeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var profile = new ProfileDTO(); // ProfileDTO |  (optional) 

            try
            {
                // This call allows the insertion of new profile for barcode purpose
                ProfileResultDTO result = apiInstance.ProfilesPostForBarcode(profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesPostForBarcode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **profile** | [**ProfileDTO**](ProfileDTO.md)|  | [optional] 

### Return type

[**ProfileResultDTO**](ProfileResultDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesput"></a>
# **ProfilesPut**
> void ProfilesPut (int? docnumber, ProfileDTO profile = null)

This call updates an existent profile

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesPutExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var docnumber = 56;  // int? | Document Identifier to update
            var profile = new ProfileDTO(); // ProfileDTO |  (optional) 

            try
            {
                // This call updates an existent profile
                apiInstance.ProfilesPut(docnumber, profile);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| Document Identifier to update | 
 **profile** | [**ProfileDTO**](ProfileDTO.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesunlockprofile"></a>
# **ProfilesUnLockProfile**
> bool? ProfilesUnLockProfile (int? docNumber)

This call checks if a profile is not lock

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesUnLockProfileExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var docNumber = 56;  // int? | Document Identifier

            try
            {
                // This call checks if a profile is not lock
                bool? result = apiInstance.ProfilesUnLockProfile(docNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesUnLockProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docNumber** | **int?**| Document Identifier | 

### Return type

**bool?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesunlockprofile_0"></a>
# **ProfilesUnLockProfile_0**
> bool? ProfilesUnLockProfile_0 (int? docNumber, int? taskid)

This call checks if a profile is not lock

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesUnLockProfile_0Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var docNumber = 56;  // int? | Document Identifier
            var taskid = 56;  // int? | Id of the task work

            try
            {
                // This call checks if a profile is not lock
                bool? result = apiInstance.ProfilesUnLockProfile_0(docNumber, taskid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesUnLockProfile_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docNumber** | **int?**| Document Identifier | 
 **taskid** | **int?**| Id of the task work | 

### Return type

**bool?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilesvalidateforarchive"></a>
# **ProfilesValidateForArchive**
> ValidationFieldResultDTO ProfilesValidateForArchive (FieldValidationCalculateArchiveCriteriaDto fieldcriteria = null)

This call returns the result of a validation given the array of fields of profile and their value

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilesValidateForArchiveExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilesApi();
            var fieldcriteria = new FieldValidationCalculateArchiveCriteriaDto(); // FieldValidationCalculateArchiveCriteriaDto |  (optional) 

            try
            {
                // This call returns the result of a validation given the array of fields of profile and their value
                ValidationFieldResultDTO result = apiInstance.ProfilesValidateForArchive(fieldcriteria);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilesApi.ProfilesValidateForArchive: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fieldcriteria** | [**FieldValidationCalculateArchiveCriteriaDto**](FieldValidationCalculateArchiveCriteriaDto.md)|  | [optional] 

### Return type

[**ValidationFieldResultDTO**](ValidationFieldResultDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


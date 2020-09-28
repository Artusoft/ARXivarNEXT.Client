# ARXivarNEXT.Client.Api.FoldersV2Api

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FoldersV2AutoinsertInFolderByDocnumber**](FoldersV2Api.md#foldersv2autoinsertinfolderbydocnumber) | **POST** /api/v2/Folders/{docnumber}/autoinsert | This method recalculate folder for profile
[**FoldersV2Delete**](FoldersV2Api.md#foldersv2delete) | **DELETE** /api/v2/Folders/{id} | This method allow to delete a folder
[**FoldersV2DeleteArxDriveConfiguration**](FoldersV2Api.md#foldersv2deletearxdriveconfiguration) | **DELETE** /api/v2/Folders/arxdriveinfo/{id} | This method delete the arxdrive configuration for the folder
[**FoldersV2FindByDocnumber**](FoldersV2Api.md#foldersv2findbydocnumber) | **GET** /api/v2/Folders/docnumber/{docnumber} | This method allows to find folders that contains docnumber
[**FoldersV2FindByName**](FoldersV2Api.md#foldersv2findbyname) | **GET** /api/v2/Folders/find | This method allows to find folders by their name
[**FoldersV2FindByNameOld**](FoldersV2Api.md#foldersv2findbynameold) | **GET** /api/v2/Folders/find/{name} | This method allows to find folders by their name
[**FoldersV2FindInFolderByName**](FoldersV2Api.md#foldersv2findinfolderbyname) | **GET** /api/v2/Folders/{id}/name/{name} | This method allows to find folders by their parent and name
[**FoldersV2GetArchiveInfo**](FoldersV2Api.md#foldersv2getarchiveinfo) | **GET** /api/v2/Folders/{id}/archiveinfo | This method returns the profile configuration for a folder
[**FoldersV2GetArxDriveConfiguration**](FoldersV2Api.md#foldersv2getarxdriveconfiguration) | **GET** /api/v2/Folders/{id}/arxdriveinfo | This method returns the ArxDrive configuration for the folder
[**FoldersV2GetById**](FoldersV2Api.md#foldersv2getbyid) | **GET** /api/v2/Folders/{id} | This method return the folders contained in specified folder
[**FoldersV2GetByParentId**](FoldersV2Api.md#foldersv2getbyparentid) | **GET** /api/v2/Folders/parent/{parentId} | This method return the folders contained in specified parent folder
[**FoldersV2GetDocumentsById**](FoldersV2Api.md#foldersv2getdocumentsbyid) | **POST** /api/v2/Folders/{id}/documents | This methods return the profiles contained in a folder.  This call could not be compatible with some programming language, in this case use the call api/Folders/{id}/documents
[**FoldersV2GetFolderPermission**](FoldersV2Api.md#foldersv2getfolderpermission) | **GET** /api/v2/Folders/{id}/permissions | This method returns the permissions for the folder
[**FoldersV2InsertDocnumbers**](FoldersV2Api.md#foldersv2insertdocnumbers) | **POST** /api/v2/Folders/{id}/add | This method allow to insert docnumbers in a folder
[**FoldersV2Move**](FoldersV2Api.md#foldersv2move) | **PUT** /api/v2/Folders/move/{id}/{parentid} | This method allows to change the parent of a folder
[**FoldersV2New**](FoldersV2Api.md#foldersv2new) | **POST** /api/v2/Folders/{parentId} | This method allow to create a new folder in the parent folder specified
[**FoldersV2NewFolder**](FoldersV2Api.md#foldersv2newfolder) | **POST** /api/v2/Folders/{parentId}/new | This method allow to create a new folder in the parent folder specified
[**FoldersV2RemoveDocumentsInFolder**](FoldersV2Api.md#foldersv2removedocumentsinfolder) | **PUT** /api/v2/Folders/{id}/documents/delete | This method allows to remove some docnumber from a folder
[**FoldersV2Rename**](FoldersV2Api.md#foldersv2rename) | **PUT** /api/v2/Folders/rename/{id} | This method allows to rename a folder
[**FoldersV2RenameOld**](FoldersV2Api.md#foldersv2renameold) | **PUT** /api/v2/Folders/rename/{id}/{name} | This method allows to rename a folder
[**FoldersV2SetArchiveInfo**](FoldersV2Api.md#foldersv2setarchiveinfo) | **POST** /api/v2/Folders/{id}/archiveinfo | This method allows to set the profile information for a folder
[**FoldersV2SetArxDriveConfiguration**](FoldersV2Api.md#foldersv2setarxdriveconfiguration) | **POST** /api/v2/Folders/{id}/arxdriveinfo | This method sets the ArxDrive configuration for the folder
[**FoldersV2SetFolderPermission**](FoldersV2Api.md#foldersv2setfolderpermission) | **POST** /api/v2/Folders/{id}/permissions | This method sets the permissions for the folder


<a name="foldersv2autoinsertinfolderbydocnumber"></a>
# **FoldersV2AutoinsertInFolderByDocnumber**
> void FoldersV2AutoinsertInFolderByDocnumber (int? docnumber)

This method recalculate folder for profile

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FoldersV2AutoinsertInFolderByDocnumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersV2Api();
            var docnumber = 56;  // int? | The identifier of the profile

            try
            {
                // This method recalculate folder for profile
                apiInstance.FoldersV2AutoinsertInFolderByDocnumber(docnumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersV2Api.FoldersV2AutoinsertInFolderByDocnumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| The identifier of the profile | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersv2delete"></a>
# **FoldersV2Delete**
> void FoldersV2Delete (int? id)

This method allow to delete a folder

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FoldersV2DeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersV2Api();
            var id = 56;  // int? | The identifier of the folder

            try
            {
                // This method allow to delete a folder
                apiInstance.FoldersV2Delete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersV2Api.FoldersV2Delete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The identifier of the folder | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersv2deletearxdriveconfiguration"></a>
# **FoldersV2DeleteArxDriveConfiguration**
> void FoldersV2DeleteArxDriveConfiguration (int? id)

This method delete the arxdrive configuration for the folder

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FoldersV2DeleteArxDriveConfigurationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersV2Api();
            var id = 56;  // int? | The identifier of the configuration

            try
            {
                // This method delete the arxdrive configuration for the folder
                apiInstance.FoldersV2DeleteArxDriveConfiguration(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersV2Api.FoldersV2DeleteArxDriveConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The identifier of the configuration | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersv2findbydocnumber"></a>
# **FoldersV2FindByDocnumber**
> List<FolderDTO> FoldersV2FindByDocnumber (int? docnumber)

This method allows to find folders that contains docnumber

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FoldersV2FindByDocnumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersV2Api();
            var docnumber = 56;  // int? | The document identifier

            try
            {
                // This method allows to find folders that contains docnumber
                List&lt;FolderDTO&gt; result = apiInstance.FoldersV2FindByDocnumber(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersV2Api.FoldersV2FindByDocnumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| The document identifier | 

### Return type

[**List<FolderDTO>**](FolderDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersv2findbyname"></a>
# **FoldersV2FindByName**
> List<FolderDTO> FoldersV2FindByName (string name)

This method allows to find folders by their name

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FoldersV2FindByNameExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersV2Api();
            var name = name_example;  // string | The name to search

            try
            {
                // This method allows to find folders by their name
                List&lt;FolderDTO&gt; result = apiInstance.FoldersV2FindByName(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersV2Api.FoldersV2FindByName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name to search | 

### Return type

[**List<FolderDTO>**](FolderDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersv2findbynameold"></a>
# **FoldersV2FindByNameOld**
> List<FolderDTO> FoldersV2FindByNameOld (string name)

This method allows to find folders by their name

This method is deprecated. Use /api/v2/Folders/find?name={name}

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FoldersV2FindByNameOldExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersV2Api();
            var name = name_example;  // string | The name to search

            try
            {
                // This method allows to find folders by their name
                List&lt;FolderDTO&gt; result = apiInstance.FoldersV2FindByNameOld(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersV2Api.FoldersV2FindByNameOld: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name to search | 

### Return type

[**List<FolderDTO>**](FolderDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersv2findinfolderbyname"></a>
# **FoldersV2FindInFolderByName**
> List<FolderDTO> FoldersV2FindInFolderByName (int? id, string name)

This method allows to find folders by their parent and name

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FoldersV2FindInFolderByNameExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersV2Api();
            var id = 56;  // int? | The identifier for root folder
            var name = name_example;  // string | The name to search

            try
            {
                // This method allows to find folders by their parent and name
                List&lt;FolderDTO&gt; result = apiInstance.FoldersV2FindInFolderByName(id, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersV2Api.FoldersV2FindInFolderByName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The identifier for root folder | 
 **name** | **string**| The name to search | 

### Return type

[**List<FolderDTO>**](FolderDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersv2getarchiveinfo"></a>
# **FoldersV2GetArchiveInfo**
> FolderArchiveModeInfo FoldersV2GetArchiveInfo (int? id)

This method returns the profile configuration for a folder

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FoldersV2GetArchiveInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersV2Api();
            var id = 56;  // int? | The identifier of the folder

            try
            {
                // This method returns the profile configuration for a folder
                FolderArchiveModeInfo result = apiInstance.FoldersV2GetArchiveInfo(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersV2Api.FoldersV2GetArchiveInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The identifier of the folder | 

### Return type

[**FolderArchiveModeInfo**](FolderArchiveModeInfo.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersv2getarxdriveconfiguration"></a>
# **FoldersV2GetArxDriveConfiguration**
> ArxDriveFolderModeInfo FoldersV2GetArxDriveConfiguration (int? id)

This method returns the ArxDrive configuration for the folder

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FoldersV2GetArxDriveConfigurationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersV2Api();
            var id = 56;  // int? | The identifier of the folder

            try
            {
                // This method returns the ArxDrive configuration for the folder
                ArxDriveFolderModeInfo result = apiInstance.FoldersV2GetArxDriveConfiguration(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersV2Api.FoldersV2GetArxDriveConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The identifier of the folder | 

### Return type

[**ArxDriveFolderModeInfo**](ArxDriveFolderModeInfo.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersv2getbyid"></a>
# **FoldersV2GetById**
> FolderDTO FoldersV2GetById (int? id)

This method return the folders contained in specified folder

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FoldersV2GetByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersV2Api();
            var id = 56;  // int? | The identifier of the folder

            try
            {
                // This method return the folders contained in specified folder
                FolderDTO result = apiInstance.FoldersV2GetById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersV2Api.FoldersV2GetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The identifier of the folder | 

### Return type

[**FolderDTO**](FolderDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersv2getbyparentid"></a>
# **FoldersV2GetByParentId**
> List<FolderDTO> FoldersV2GetByParentId (int? parentId)

This method return the folders contained in specified parent folder

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FoldersV2GetByParentIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersV2Api();
            var parentId = 56;  // int? | The identifier of the parent folder

            try
            {
                // This method return the folders contained in specified parent folder
                List&lt;FolderDTO&gt; result = apiInstance.FoldersV2GetByParentId(parentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersV2Api.FoldersV2GetByParentId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **int?**| The identifier of the parent folder | 

### Return type

[**List<FolderDTO>**](FolderDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersv2getdocumentsbyid"></a>
# **FoldersV2GetDocumentsById**
> Object FoldersV2GetDocumentsById (int? id, SelectDTO select)

This methods return the profiles contained in a folder.  This call could not be compatible with some programming language, in this case use the call api/Folders/{id}/documents

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FoldersV2GetDocumentsByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersV2Api();
            var id = 56;  // int? | The identifier of the folder
            var select = new SelectDTO(); // SelectDTO | The select object to instruct the server on which fields it must return

            try
            {
                // This methods return the profiles contained in a folder.  This call could not be compatible with some programming language, in this case use the call api/Folders/{id}/documents
                Object result = apiInstance.FoldersV2GetDocumentsById(id, select);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersV2Api.FoldersV2GetDocumentsById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The identifier of the folder | 
 **select** | [**SelectDTO**](SelectDTO.md)| The select object to instruct the server on which fields it must return | 

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersv2getfolderpermission"></a>
# **FoldersV2GetFolderPermission**
> FolderPermissionsDTO FoldersV2GetFolderPermission (int? id)

This method returns the permissions for the folder

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FoldersV2GetFolderPermissionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersV2Api();
            var id = 56;  // int? | The identifier of the folder

            try
            {
                // This method returns the permissions for the folder
                FolderPermissionsDTO result = apiInstance.FoldersV2GetFolderPermission(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersV2Api.FoldersV2GetFolderPermission: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The identifier of the folder | 

### Return type

[**FolderPermissionsDTO**](FolderPermissionsDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersv2insertdocnumbers"></a>
# **FoldersV2InsertDocnumbers**
> void FoldersV2InsertDocnumbers (int? id, List<int?> docnumbers)

This method allow to insert docnumbers in a folder

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FoldersV2InsertDocnumbersExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersV2Api();
            var id = 56;  // int? | The identifier of the folder
            var docnumbers = ;  // List<int?> | Array of identifier of docnumbers to insert

            try
            {
                // This method allow to insert docnumbers in a folder
                apiInstance.FoldersV2InsertDocnumbers(id, docnumbers);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersV2Api.FoldersV2InsertDocnumbers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The identifier of the folder | 
 **docnumbers** | **List&lt;int?&gt;**| Array of identifier of docnumbers to insert | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersv2move"></a>
# **FoldersV2Move**
> void FoldersV2Move (int? id, int? parentid)

This method allows to change the parent of a folder

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FoldersV2MoveExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersV2Api();
            var id = 56;  // int? | The identifier of folder
            var parentid = 56;  // int? | The new parent folder identifier

            try
            {
                // This method allows to change the parent of a folder
                apiInstance.FoldersV2Move(id, parentid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersV2Api.FoldersV2Move: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The identifier of folder | 
 **parentid** | **int?**| The new parent folder identifier | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersv2new"></a>
# **FoldersV2New**
> FolderDTO FoldersV2New (int? parentId, string name)

This method allow to create a new folder in the parent folder specified

This method is deprecated. Use /api/v2/Folders/{parentId}/new?name={name}

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FoldersV2NewExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersV2Api();
            var parentId = 56;  // int? | The identifier of the parent folder
            var name = name_example;  // string | The name of new folder

            try
            {
                // This method allow to create a new folder in the parent folder specified
                FolderDTO result = apiInstance.FoldersV2New(parentId, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersV2Api.FoldersV2New: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **int?**| The identifier of the parent folder | 
 **name** | **string**| The name of new folder | 

### Return type

[**FolderDTO**](FolderDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersv2newfolder"></a>
# **FoldersV2NewFolder**
> FolderDTO FoldersV2NewFolder (int? parentId, string name)

This method allow to create a new folder in the parent folder specified

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FoldersV2NewFolderExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersV2Api();
            var parentId = 56;  // int? | The identifier of the parent folder
            var name = name_example;  // string | The name of new folder

            try
            {
                // This method allow to create a new folder in the parent folder specified
                FolderDTO result = apiInstance.FoldersV2NewFolder(parentId, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersV2Api.FoldersV2NewFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **int?**| The identifier of the parent folder | 
 **name** | **string**| The name of new folder | 

### Return type

[**FolderDTO**](FolderDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersv2removedocumentsinfolder"></a>
# **FoldersV2RemoveDocumentsInFolder**
> void FoldersV2RemoveDocumentsInFolder (int? id, List<int?> docnumbers)

This method allows to remove some docnumber from a folder

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FoldersV2RemoveDocumentsInFolderExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersV2Api();
            var id = 56;  // int? | The identifier of the folder
            var docnumbers = ;  // List<int?> | Array of documents identifier to remove

            try
            {
                // This method allows to remove some docnumber from a folder
                apiInstance.FoldersV2RemoveDocumentsInFolder(id, docnumbers);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersV2Api.FoldersV2RemoveDocumentsInFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The identifier of the folder | 
 **docnumbers** | **List&lt;int?&gt;**| Array of documents identifier to remove | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersv2rename"></a>
# **FoldersV2Rename**
> void FoldersV2Rename (string name, int? id)

This method allows to rename a folder

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FoldersV2RenameExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersV2Api();
            var name = name_example;  // string | The new name of folder
            var id = 56;  // int? | The identifier of folder to rename

            try
            {
                // This method allows to rename a folder
                apiInstance.FoldersV2Rename(name, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersV2Api.FoldersV2Rename: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The new name of folder | 
 **id** | **int?**| The identifier of folder to rename | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersv2renameold"></a>
# **FoldersV2RenameOld**
> void FoldersV2RenameOld (string name, int? id)

This method allows to rename a folder

This method is deprecated. Use /api/v2/Folders/rename/{id}?name={name}

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FoldersV2RenameOldExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersV2Api();
            var name = name_example;  // string | The new name of folder
            var id = 56;  // int? | The identifier of folder to rename

            try
            {
                // This method allows to rename a folder
                apiInstance.FoldersV2RenameOld(name, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersV2Api.FoldersV2RenameOld: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The new name of folder | 
 **id** | **int?**| The identifier of folder to rename | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersv2setarchiveinfo"></a>
# **FoldersV2SetArchiveInfo**
> void FoldersV2SetArchiveInfo (int? id, FolderArchiveModeInfo archiveInfo)

This method allows to set the profile information for a folder

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FoldersV2SetArchiveInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersV2Api();
            var id = 56;  // int? | The identifier of folder
            var archiveInfo = new FolderArchiveModeInfo(); // FolderArchiveModeInfo | The profile configuration

            try
            {
                // This method allows to set the profile information for a folder
                apiInstance.FoldersV2SetArchiveInfo(id, archiveInfo);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersV2Api.FoldersV2SetArchiveInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The identifier of folder | 
 **archiveInfo** | [**FolderArchiveModeInfo**](FolderArchiveModeInfo.md)| The profile configuration | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersv2setarxdriveconfiguration"></a>
# **FoldersV2SetArxDriveConfiguration**
> void FoldersV2SetArxDriveConfiguration (int? id, ArxDriveFolderModeInfo arxDriveFolderModeInfo)

This method sets the ArxDrive configuration for the folder

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FoldersV2SetArxDriveConfigurationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersV2Api();
            var id = 56;  // int? | The identifier of the folder
            var arxDriveFolderModeInfo = new ArxDriveFolderModeInfo(); // ArxDriveFolderModeInfo | ArxDrive folder information

            try
            {
                // This method sets the ArxDrive configuration for the folder
                apiInstance.FoldersV2SetArxDriveConfiguration(id, arxDriveFolderModeInfo);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersV2Api.FoldersV2SetArxDriveConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The identifier of the folder | 
 **arxDriveFolderModeInfo** | [**ArxDriveFolderModeInfo**](ArxDriveFolderModeInfo.md)| ArxDrive folder information | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersv2setfolderpermission"></a>
# **FoldersV2SetFolderPermission**
> void FoldersV2SetFolderPermission (int? id, FolderPermissionsDTO permissions)

This method sets the permissions for the folder

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FoldersV2SetFolderPermissionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersV2Api();
            var id = 56;  // int? | The identifier of the folder
            var permissions = new FolderPermissionsDTO(); // FolderPermissionsDTO | The folder permissions

            try
            {
                // This method sets the permissions for the folder
                apiInstance.FoldersV2SetFolderPermission(id, permissions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersV2Api.FoldersV2SetFolderPermission: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The identifier of the folder | 
 **permissions** | [**FolderPermissionsDTO**](FolderPermissionsDTO.md)| The folder permissions | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


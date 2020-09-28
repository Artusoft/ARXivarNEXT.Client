# ARXivarNEXT.Client.Api.FoldersApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FoldersAutoinsertInFolderByDocnumber**](FoldersApi.md#foldersautoinsertinfolderbydocnumber) | **POST** /api/Folders/{docnumber}/autoinsert | This method recalculate folder for profile
[**FoldersDelete**](FoldersApi.md#foldersdelete) | **DELETE** /api/Folders/{id} | This method allow to delete a folder
[**FoldersDeleteArxDriveConfiguration**](FoldersApi.md#foldersdeletearxdriveconfiguration) | **DELETE** /api/Folders/arxdriveinfo/{id} | This method delete the arxdrive configuration for the folder
[**FoldersFindByDocnumber**](FoldersApi.md#foldersfindbydocnumber) | **GET** /api/Folders/docnumber/{docnumber} | This method allows to find folders that contains docnumber
[**FoldersFindByName**](FoldersApi.md#foldersfindbyname) | **GET** /api/Folders/find | This method allows to find folders by their name
[**FoldersFindByNameOld**](FoldersApi.md#foldersfindbynameold) | **GET** /api/Folders/find/{name} | This method allows to find folders by their name
[**FoldersFindInFolderByName**](FoldersApi.md#foldersfindinfolderbyname) | **GET** /api/Folders/{id}/name/{name} | This method allows to find folders by their parent and name
[**FoldersGetArchiveInfo**](FoldersApi.md#foldersgetarchiveinfo) | **GET** /api/Folders/{id}/archiveinfo | This method returns the profile configuration for a folder
[**FoldersGetArxDriveConfiguration**](FoldersApi.md#foldersgetarxdriveconfiguration) | **GET** /api/Folders/{id}/arxdriveinfo | This method returns the ArxDrive configuration for the folder
[**FoldersGetById**](FoldersApi.md#foldersgetbyid) | **GET** /api/Folders/{id} | This method return the folders contained in specified folder
[**FoldersGetByParentId**](FoldersApi.md#foldersgetbyparentid) | **GET** /api/Folders/parent/{parentId} | This method return the folders contained in specified parent folder
[**FoldersGetDocumentsById**](FoldersApi.md#foldersgetdocumentsbyid) | **POST** /api/Folders/{id}/documents | This methods return the profiles contained in a folder
[**FoldersGetFolderPermission**](FoldersApi.md#foldersgetfolderpermission) | **GET** /api/Folders/{id}/permissions | This method returns the permissions for the folder
[**FoldersInsertDocnumbers**](FoldersApi.md#foldersinsertdocnumbers) | **POST** /api/Folders/{id}/add | This method allow to insert docnumbers in a folder
[**FoldersMove**](FoldersApi.md#foldersmove) | **PUT** /api/Folders/move/{id}/{parentid} | This method allows to change the parent of a folder
[**FoldersNew**](FoldersApi.md#foldersnew) | **POST** /api/Folders/{parentId} | This method allow to create a new folder in the parent folder specified
[**FoldersNewFolder**](FoldersApi.md#foldersnewfolder) | **POST** /api/Folders/{parentId}/new | This method allow to create a new folder in the parent folder specified
[**FoldersRemoveDocumentsInFolder**](FoldersApi.md#foldersremovedocumentsinfolder) | **PUT** /api/Folders/{id}/documents/delete | This method allows to remove some docnumber from a folder
[**FoldersRename**](FoldersApi.md#foldersrename) | **PUT** /api/Folders/rename/{id} | This method allows to rename a folder
[**FoldersRenameOld**](FoldersApi.md#foldersrenameold) | **PUT** /api/Folders/rename/{id}/{name} | This method allows to rename a folder
[**FoldersSetArchiveInfo**](FoldersApi.md#folderssetarchiveinfo) | **POST** /api/Folders/{id}/archiveinfo | This method allows to set the profile information for a folder
[**FoldersSetArxDriveConfiguration**](FoldersApi.md#folderssetarxdriveconfiguration) | **POST** /api/Folders/{id}/arxdriveinfo | This method sets the ArxDrive configuration for the folder
[**FoldersSetFolderPermission**](FoldersApi.md#folderssetfolderpermission) | **POST** /api/Folders/{id}/permissions | This method sets the permissions for the folder


<a name="foldersautoinsertinfolderbydocnumber"></a>
# **FoldersAutoinsertInFolderByDocnumber**
> void FoldersAutoinsertInFolderByDocnumber (int? docnumber)

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
    public class FoldersAutoinsertInFolderByDocnumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersApi();
            var docnumber = 56;  // int? | The identifier of the profile

            try
            {
                // This method recalculate folder for profile
                apiInstance.FoldersAutoinsertInFolderByDocnumber(docnumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.FoldersAutoinsertInFolderByDocnumber: " + e.Message );
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

<a name="foldersdelete"></a>
# **FoldersDelete**
> void FoldersDelete (int? id)

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
    public class FoldersDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersApi();
            var id = 56;  // int? | The identifier of the folder

            try
            {
                // This method allow to delete a folder
                apiInstance.FoldersDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.FoldersDelete: " + e.Message );
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

<a name="foldersdeletearxdriveconfiguration"></a>
# **FoldersDeleteArxDriveConfiguration**
> void FoldersDeleteArxDriveConfiguration (int? id)

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
    public class FoldersDeleteArxDriveConfigurationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersApi();
            var id = 56;  // int? | The identifier of the configuration

            try
            {
                // This method delete the arxdrive configuration for the folder
                apiInstance.FoldersDeleteArxDriveConfiguration(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.FoldersDeleteArxDriveConfiguration: " + e.Message );
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

<a name="foldersfindbydocnumber"></a>
# **FoldersFindByDocnumber**
> List<FolderDTO> FoldersFindByDocnumber (int? docnumber)

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
    public class FoldersFindByDocnumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersApi();
            var docnumber = 56;  // int? | The document identifier

            try
            {
                // This method allows to find folders that contains docnumber
                List&lt;FolderDTO&gt; result = apiInstance.FoldersFindByDocnumber(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.FoldersFindByDocnumber: " + e.Message );
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

<a name="foldersfindbyname"></a>
# **FoldersFindByName**
> List<FolderDTO> FoldersFindByName (string name)

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
    public class FoldersFindByNameExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersApi();
            var name = name_example;  // string | The name to search

            try
            {
                // This method allows to find folders by their name
                List&lt;FolderDTO&gt; result = apiInstance.FoldersFindByName(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.FoldersFindByName: " + e.Message );
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

<a name="foldersfindbynameold"></a>
# **FoldersFindByNameOld**
> List<FolderDTO> FoldersFindByNameOld (string name)

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
    public class FoldersFindByNameOldExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersApi();
            var name = name_example;  // string | The name to search

            try
            {
                // This method allows to find folders by their name
                List&lt;FolderDTO&gt; result = apiInstance.FoldersFindByNameOld(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.FoldersFindByNameOld: " + e.Message );
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

<a name="foldersfindinfolderbyname"></a>
# **FoldersFindInFolderByName**
> List<FolderDTO> FoldersFindInFolderByName (int? id, string name)

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
    public class FoldersFindInFolderByNameExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersApi();
            var id = 56;  // int? | The identifier for root folder
            var name = name_example;  // string | The name to search

            try
            {
                // This method allows to find folders by their parent and name
                List&lt;FolderDTO&gt; result = apiInstance.FoldersFindInFolderByName(id, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.FoldersFindInFolderByName: " + e.Message );
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

<a name="foldersgetarchiveinfo"></a>
# **FoldersGetArchiveInfo**
> FolderArchiveModeInfo FoldersGetArchiveInfo (int? id)

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
    public class FoldersGetArchiveInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersApi();
            var id = 56;  // int? | The identifier of the folder

            try
            {
                // This method returns the profile configuration for a folder
                FolderArchiveModeInfo result = apiInstance.FoldersGetArchiveInfo(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.FoldersGetArchiveInfo: " + e.Message );
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

<a name="foldersgetarxdriveconfiguration"></a>
# **FoldersGetArxDriveConfiguration**
> ArxDriveFolderModeInfo FoldersGetArxDriveConfiguration (int? id)

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
    public class FoldersGetArxDriveConfigurationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersApi();
            var id = 56;  // int? | The identifier of the folder

            try
            {
                // This method returns the ArxDrive configuration for the folder
                ArxDriveFolderModeInfo result = apiInstance.FoldersGetArxDriveConfiguration(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.FoldersGetArxDriveConfiguration: " + e.Message );
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

<a name="foldersgetbyid"></a>
# **FoldersGetById**
> FolderDTO FoldersGetById (int? id)

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
    public class FoldersGetByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersApi();
            var id = 56;  // int? | The identifier of the folder

            try
            {
                // This method return the folders contained in specified folder
                FolderDTO result = apiInstance.FoldersGetById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.FoldersGetById: " + e.Message );
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

<a name="foldersgetbyparentid"></a>
# **FoldersGetByParentId**
> List<FolderDTO> FoldersGetByParentId (int? parentId)

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
    public class FoldersGetByParentIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersApi();
            var parentId = 56;  // int? | The identifier of the parent folder

            try
            {
                // This method return the folders contained in specified parent folder
                List&lt;FolderDTO&gt; result = apiInstance.FoldersGetByParentId(parentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.FoldersGetByParentId: " + e.Message );
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

<a name="foldersgetdocumentsbyid"></a>
# **FoldersGetDocumentsById**
> List<RowSearchResult> FoldersGetDocumentsById (int? id, SelectDTO select)

This methods return the profiles contained in a folder

This method is deprecated. Use api/v2/Folders/{id}/documents

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FoldersGetDocumentsByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersApi();
            var id = 56;  // int? | The identifier of the folder
            var select = new SelectDTO(); // SelectDTO | The select object to instruct the server on which fields it must return

            try
            {
                // This methods return the profiles contained in a folder
                List&lt;RowSearchResult&gt; result = apiInstance.FoldersGetDocumentsById(id, select);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.FoldersGetDocumentsById: " + e.Message );
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

[**List<RowSearchResult>**](RowSearchResult.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="foldersgetfolderpermission"></a>
# **FoldersGetFolderPermission**
> FolderPermissionsDTO FoldersGetFolderPermission (int? id)

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
    public class FoldersGetFolderPermissionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersApi();
            var id = 56;  // int? | The identifier of the folder

            try
            {
                // This method returns the permissions for the folder
                FolderPermissionsDTO result = apiInstance.FoldersGetFolderPermission(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.FoldersGetFolderPermission: " + e.Message );
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

<a name="foldersinsertdocnumbers"></a>
# **FoldersInsertDocnumbers**
> void FoldersInsertDocnumbers (int? id, List<int?> docnumbers)

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
    public class FoldersInsertDocnumbersExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersApi();
            var id = 56;  // int? | The identifier of the folder
            var docnumbers = ;  // List<int?> | Array of identifier of docnumbers to insert

            try
            {
                // This method allow to insert docnumbers in a folder
                apiInstance.FoldersInsertDocnumbers(id, docnumbers);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.FoldersInsertDocnumbers: " + e.Message );
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

<a name="foldersmove"></a>
# **FoldersMove**
> void FoldersMove (int? id, int? parentid)

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
    public class FoldersMoveExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersApi();
            var id = 56;  // int? | The identifier of folder
            var parentid = 56;  // int? | The new parent folder identifier

            try
            {
                // This method allows to change the parent of a folder
                apiInstance.FoldersMove(id, parentid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.FoldersMove: " + e.Message );
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

<a name="foldersnew"></a>
# **FoldersNew**
> FolderDTO FoldersNew (int? parentId, string name)

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
    public class FoldersNewExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersApi();
            var parentId = 56;  // int? | The identifier of the parent folder
            var name = name_example;  // string | The name of new folder

            try
            {
                // This method allow to create a new folder in the parent folder specified
                FolderDTO result = apiInstance.FoldersNew(parentId, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.FoldersNew: " + e.Message );
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

<a name="foldersnewfolder"></a>
# **FoldersNewFolder**
> FolderDTO FoldersNewFolder (int? parentId, string name)

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
    public class FoldersNewFolderExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersApi();
            var parentId = 56;  // int? | The identifier of the parent folder
            var name = name_example;  // string | The name of new folder

            try
            {
                // This method allow to create a new folder in the parent folder specified
                FolderDTO result = apiInstance.FoldersNewFolder(parentId, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.FoldersNewFolder: " + e.Message );
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

<a name="foldersremovedocumentsinfolder"></a>
# **FoldersRemoveDocumentsInFolder**
> void FoldersRemoveDocumentsInFolder (int? id, List<int?> docnumbers)

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
    public class FoldersRemoveDocumentsInFolderExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersApi();
            var id = 56;  // int? | The identifier of the folder
            var docnumbers = ;  // List<int?> | Array of documents identifier to remove

            try
            {
                // This method allows to remove some docnumber from a folder
                apiInstance.FoldersRemoveDocumentsInFolder(id, docnumbers);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.FoldersRemoveDocumentsInFolder: " + e.Message );
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

<a name="foldersrename"></a>
# **FoldersRename**
> void FoldersRename (string name, int? id)

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
    public class FoldersRenameExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersApi();
            var name = name_example;  // string | The new name of folder
            var id = 56;  // int? | The identifier of folder to rename

            try
            {
                // This method allows to rename a folder
                apiInstance.FoldersRename(name, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.FoldersRename: " + e.Message );
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

<a name="foldersrenameold"></a>
# **FoldersRenameOld**
> void FoldersRenameOld (string name, int? id)

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
    public class FoldersRenameOldExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersApi();
            var name = name_example;  // string | The new name of folder
            var id = 56;  // int? | The identifier of folder to rename

            try
            {
                // This method allows to rename a folder
                apiInstance.FoldersRenameOld(name, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.FoldersRenameOld: " + e.Message );
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

<a name="folderssetarchiveinfo"></a>
# **FoldersSetArchiveInfo**
> void FoldersSetArchiveInfo (int? id, FolderArchiveModeInfo archiveInfo)

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
    public class FoldersSetArchiveInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersApi();
            var id = 56;  // int? | The identifier of folder
            var archiveInfo = new FolderArchiveModeInfo(); // FolderArchiveModeInfo | The profile configuration

            try
            {
                // This method allows to set the profile information for a folder
                apiInstance.FoldersSetArchiveInfo(id, archiveInfo);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.FoldersSetArchiveInfo: " + e.Message );
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

<a name="folderssetarxdriveconfiguration"></a>
# **FoldersSetArxDriveConfiguration**
> void FoldersSetArxDriveConfiguration (int? id, ArxDriveFolderModeInfo arxDriveFolderModeInfo)

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
    public class FoldersSetArxDriveConfigurationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersApi();
            var id = 56;  // int? | The identifier of the folder
            var arxDriveFolderModeInfo = new ArxDriveFolderModeInfo(); // ArxDriveFolderModeInfo | ArxDrive folder information

            try
            {
                // This method sets the ArxDrive configuration for the folder
                apiInstance.FoldersSetArxDriveConfiguration(id, arxDriveFolderModeInfo);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.FoldersSetArxDriveConfiguration: " + e.Message );
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

<a name="folderssetfolderpermission"></a>
# **FoldersSetFolderPermission**
> void FoldersSetFolderPermission (int? id, FolderPermissionsDTO permissions)

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
    public class FoldersSetFolderPermissionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FoldersApi();
            var id = 56;  // int? | The identifier of the folder
            var permissions = new FolderPermissionsDTO(); // FolderPermissionsDTO | The folder permissions

            try
            {
                // This method sets the permissions for the folder
                apiInstance.FoldersSetFolderPermission(id, permissions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.FoldersSetFolderPermission: " + e.Message );
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


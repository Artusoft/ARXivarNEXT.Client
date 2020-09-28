# ARXivarNEXT.Client.Api.MonitoredFoldersApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MonitoredFoldersGetById**](MonitoredFoldersApi.md#monitoredfoldersgetbyid) | **GET** /api/MonitoredFolders/{monitoredFolderId} | This call returns the monitored folders by its id
[**MonitoredFoldersGetByUserId**](MonitoredFoldersApi.md#monitoredfoldersgetbyuserid) | **GET** /api/MonitoredFolders | This call returns all the monitored folders for a user
[**MonitoredFoldersMonitoredFolderDelete**](MonitoredFoldersApi.md#monitoredfoldersmonitoredfolderdelete) | **DELETE** /api/MonitoredFolders/{monitoredFolderId} | This call deletes a monitored folder
[**MonitoredFoldersMonitoredFolderInsert**](MonitoredFoldersApi.md#monitoredfoldersmonitoredfolderinsert) | **POST** /api/MonitoredFolders | This call insert new monitored folder for user
[**MonitoredFoldersMonitoredFolderUpdate**](MonitoredFoldersApi.md#monitoredfoldersmonitoredfolderupdate) | **PUT** /api/MonitoredFolders | This call updates a monitored folder


<a name="monitoredfoldersgetbyid"></a>
# **MonitoredFoldersGetById**
> MonitoredFolderDTO MonitoredFoldersGetById (string monitoredFolderId)

This call returns the monitored folders by its id

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MonitoredFoldersGetByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitoredFoldersApi();
            var monitoredFolderId = monitoredFolderId_example;  // string | 

            try
            {
                // This call returns the monitored folders by its id
                MonitoredFolderDTO result = apiInstance.MonitoredFoldersGetById(monitoredFolderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitoredFoldersApi.MonitoredFoldersGetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **monitoredFolderId** | **string**|  | 

### Return type

[**MonitoredFolderDTO**](MonitoredFolderDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="monitoredfoldersgetbyuserid"></a>
# **MonitoredFoldersGetByUserId**
> List<MonitoredFolderDTO> MonitoredFoldersGetByUserId ()

This call returns all the monitored folders for a user

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MonitoredFoldersGetByUserIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitoredFoldersApi();

            try
            {
                // This call returns all the monitored folders for a user
                List&lt;MonitoredFolderDTO&gt; result = apiInstance.MonitoredFoldersGetByUserId();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitoredFoldersApi.MonitoredFoldersGetByUserId: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<MonitoredFolderDTO>**](MonitoredFolderDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="monitoredfoldersmonitoredfolderdelete"></a>
# **MonitoredFoldersMonitoredFolderDelete**
> void MonitoredFoldersMonitoredFolderDelete (string monitoredFolderId)

This call deletes a monitored folder

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MonitoredFoldersMonitoredFolderDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitoredFoldersApi();
            var monitoredFolderId = monitoredFolderId_example;  // string | 

            try
            {
                // This call deletes a monitored folder
                apiInstance.MonitoredFoldersMonitoredFolderDelete(monitoredFolderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitoredFoldersApi.MonitoredFoldersMonitoredFolderDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **monitoredFolderId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="monitoredfoldersmonitoredfolderinsert"></a>
# **MonitoredFoldersMonitoredFolderInsert**
> MonitoredFolderDTO MonitoredFoldersMonitoredFolderInsert (MonitoredFolderDTO monitoredFolder)

This call insert new monitored folder for user

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MonitoredFoldersMonitoredFolderInsertExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitoredFoldersApi();
            var monitoredFolder = new MonitoredFolderDTO(); // MonitoredFolderDTO | 

            try
            {
                // This call insert new monitored folder for user
                MonitoredFolderDTO result = apiInstance.MonitoredFoldersMonitoredFolderInsert(monitoredFolder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitoredFoldersApi.MonitoredFoldersMonitoredFolderInsert: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **monitoredFolder** | [**MonitoredFolderDTO**](MonitoredFolderDTO.md)|  | 

### Return type

[**MonitoredFolderDTO**](MonitoredFolderDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="monitoredfoldersmonitoredfolderupdate"></a>
# **MonitoredFoldersMonitoredFolderUpdate**
> MonitoredFolderDTO MonitoredFoldersMonitoredFolderUpdate (MonitoredFolderDTO monitoredFolder)

This call updates a monitored folder

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MonitoredFoldersMonitoredFolderUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitoredFoldersApi();
            var monitoredFolder = new MonitoredFolderDTO(); // MonitoredFolderDTO | 

            try
            {
                // This call updates a monitored folder
                MonitoredFolderDTO result = apiInstance.MonitoredFoldersMonitoredFolderUpdate(monitoredFolder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitoredFoldersApi.MonitoredFoldersMonitoredFolderUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **monitoredFolder** | [**MonitoredFolderDTO**](MonitoredFolderDTO.md)|  | 

### Return type

[**MonitoredFolderDTO**](MonitoredFolderDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


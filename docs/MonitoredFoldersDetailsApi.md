# ARXivarNEXT.Client.Api.MonitoredFoldersDetailsApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MonitoredFoldersDetailsMonitoredFoldersDetailDelete**](MonitoredFoldersDetailsApi.md#monitoredfoldersdetailsmonitoredfoldersdetaildelete) | **DELETE** /api/MonitoredFoldersDetails/{monitoredFoldersDetailId} | This call deletes a monitored folders detail
[**MonitoredFoldersDetailsMonitoredFoldersDetailDeleteByMonitoredFolderId**](MonitoredFoldersDetailsApi.md#monitoredfoldersdetailsmonitoredfoldersdetaildeletebymonitoredfolderid) | **DELETE** /api/MonitoredFoldersDetails/bymonitoredfolder/{monitoredFoldersId} | This call deletes a monitored folders detail by monitored folder id
[**MonitoredFoldersDetailsMonitoredFoldersDetailGetDataByDmMonitoredfolderId**](MonitoredFoldersDetailsApi.md#monitoredfoldersdetailsmonitoredfoldersdetailgetdatabydmmonitoredfolderid) | **GET** /api/MonitoredFoldersDetails/{monitoredFoldersId} | This call returns all the monitored folders details for a gover monitored folder id
[**MonitoredFoldersDetailsMonitoredFoldersDetailInsert**](MonitoredFoldersDetailsApi.md#monitoredfoldersdetailsmonitoredfoldersdetailinsert) | **POST** /api/MonitoredFoldersDetails | This call insert new monitored folders detail


<a name="monitoredfoldersdetailsmonitoredfoldersdetaildelete"></a>
# **MonitoredFoldersDetailsMonitoredFoldersDetailDelete**
> void MonitoredFoldersDetailsMonitoredFoldersDetailDelete (string monitoredFoldersDetailId)

This call deletes a monitored folders detail

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MonitoredFoldersDetailsMonitoredFoldersDetailDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitoredFoldersDetailsApi();
            var monitoredFoldersDetailId = monitoredFoldersDetailId_example;  // string | 

            try
            {
                // This call deletes a monitored folders detail
                apiInstance.MonitoredFoldersDetailsMonitoredFoldersDetailDelete(monitoredFoldersDetailId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitoredFoldersDetailsApi.MonitoredFoldersDetailsMonitoredFoldersDetailDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **monitoredFoldersDetailId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="monitoredfoldersdetailsmonitoredfoldersdetaildeletebymonitoredfolderid"></a>
# **MonitoredFoldersDetailsMonitoredFoldersDetailDeleteByMonitoredFolderId**
> void MonitoredFoldersDetailsMonitoredFoldersDetailDeleteByMonitoredFolderId (string monitoredFoldersId)

This call deletes a monitored folders detail by monitored folder id

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MonitoredFoldersDetailsMonitoredFoldersDetailDeleteByMonitoredFolderIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitoredFoldersDetailsApi();
            var monitoredFoldersId = monitoredFoldersId_example;  // string | 

            try
            {
                // This call deletes a monitored folders detail by monitored folder id
                apiInstance.MonitoredFoldersDetailsMonitoredFoldersDetailDeleteByMonitoredFolderId(monitoredFoldersId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitoredFoldersDetailsApi.MonitoredFoldersDetailsMonitoredFoldersDetailDeleteByMonitoredFolderId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **monitoredFoldersId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="monitoredfoldersdetailsmonitoredfoldersdetailgetdatabydmmonitoredfolderid"></a>
# **MonitoredFoldersDetailsMonitoredFoldersDetailGetDataByDmMonitoredfolderId**
> List<MonitoredFolderDetailDTO> MonitoredFoldersDetailsMonitoredFoldersDetailGetDataByDmMonitoredfolderId (string monitoredFoldersId)

This call returns all the monitored folders details for a gover monitored folder id

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MonitoredFoldersDetailsMonitoredFoldersDetailGetDataByDmMonitoredfolderIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitoredFoldersDetailsApi();
            var monitoredFoldersId = monitoredFoldersId_example;  // string | 

            try
            {
                // This call returns all the monitored folders details for a gover monitored folder id
                List&lt;MonitoredFolderDetailDTO&gt; result = apiInstance.MonitoredFoldersDetailsMonitoredFoldersDetailGetDataByDmMonitoredfolderId(monitoredFoldersId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitoredFoldersDetailsApi.MonitoredFoldersDetailsMonitoredFoldersDetailGetDataByDmMonitoredfolderId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **monitoredFoldersId** | **string**|  | 

### Return type

[**List<MonitoredFolderDetailDTO>**](MonitoredFolderDetailDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="monitoredfoldersdetailsmonitoredfoldersdetailinsert"></a>
# **MonitoredFoldersDetailsMonitoredFoldersDetailInsert**
> MonitoredFolderDetailDTO MonitoredFoldersDetailsMonitoredFoldersDetailInsert (MonitoredFolderDetailDTO monitoredFoldersDetail)

This call insert new monitored folders detail

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MonitoredFoldersDetailsMonitoredFoldersDetailInsertExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitoredFoldersDetailsApi();
            var monitoredFoldersDetail = new MonitoredFolderDetailDTO(); // MonitoredFolderDetailDTO | 

            try
            {
                // This call insert new monitored folders detail
                MonitoredFolderDetailDTO result = apiInstance.MonitoredFoldersDetailsMonitoredFoldersDetailInsert(monitoredFoldersDetail);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitoredFoldersDetailsApi.MonitoredFoldersDetailsMonitoredFoldersDetailInsert: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **monitoredFoldersDetail** | [**MonitoredFolderDetailDTO**](MonitoredFolderDetailDTO.md)|  | 

### Return type

[**MonitoredFolderDetailDTO**](MonitoredFolderDetailDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


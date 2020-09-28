# ARXivarNEXT.Client.Api.AssistantApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssistantBufferInsertForMonitoredFolder**](AssistantApi.md#assistantbufferinsertformonitoredfolder) | **POST** /api/Assistant/BufferInsertForMonitoredFolder/{bufferId} | This call notifies the specified user that a document has been added to buffer from monitored folder
[**AssistantDetected**](AssistantApi.md#assistantdetected) | **GET** /api/Assistant | This call notifies the specified user that the assistant is active
[**AssistantManagementReceiptPAComplete**](AssistantApi.md#assistantmanagementreceiptpacomplete) | **POST** /api/Assistant/ReceiptPAResult/{connectionId} | This call notifies that a receipt PA configuration is finished
[**AssistantNotifyProcessDocChange**](AssistantApi.md#assistantnotifyprocessdocchange) | **PUT** /api/Assistant/UpdateProcessDoc/{processDocId}/TaskWork/{taskWorkId} | This call notifies the specified user that a document has changed
[**AssistantNotifyProfileChange**](AssistantApi.md#assistantnotifyprofilechange) | **PUT** /api/Assistant/UpdateProfile/{docNumber} | This call notifies the specified user that a document has changed
[**AssistantScanComplete**](AssistantApi.md#assistantscancomplete) | **POST** /api/Assistant/ScanResult/{connectionId} | This call notifies the specified user that a document has scanned


<a name="assistantbufferinsertformonitoredfolder"></a>
# **AssistantBufferInsertForMonitoredFolder**
> void AssistantBufferInsertForMonitoredFolder (string bufferId)

This call notifies the specified user that a document has been added to buffer from monitored folder

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AssistantBufferInsertForMonitoredFolderExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssistantApi();
            var bufferId = bufferId_example;  // string | Result information to scan

            try
            {
                // This call notifies the specified user that a document has been added to buffer from monitored folder
                apiInstance.AssistantBufferInsertForMonitoredFolder(bufferId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantApi.AssistantBufferInsertForMonitoredFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bufferId** | **string**| Result information to scan | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assistantdetected"></a>
# **AssistantDetected**
> void AssistantDetected (string connectionId, string version = null)

This call notifies the specified user that the assistant is active

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AssistantDetectedExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssistantApi();
            var connectionId = connectionId_example;  // string | Connection identifier
            var version = version_example;  // string | Version (optional) 

            try
            {
                // This call notifies the specified user that the assistant is active
                apiInstance.AssistantDetected(connectionId, version);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantApi.AssistantDetected: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectionId** | **string**| Connection identifier | 
 **version** | **string**| Version | [optional] 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assistantmanagementreceiptpacomplete"></a>
# **AssistantManagementReceiptPAComplete**
> void AssistantManagementReceiptPAComplete (string connectionId, ReceiptPAResultDTO receiptPAResult)

This call notifies that a receipt PA configuration is finished

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AssistantManagementReceiptPACompleteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssistantApi();
            var connectionId = connectionId_example;  // string | Connection identifier
            var receiptPAResult = new ReceiptPAResultDTO(); // ReceiptPAResultDTO | Receipt PA configuration result

            try
            {
                // This call notifies that a receipt PA configuration is finished
                apiInstance.AssistantManagementReceiptPAComplete(connectionId, receiptPAResult);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantApi.AssistantManagementReceiptPAComplete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectionId** | **string**| Connection identifier | 
 **receiptPAResult** | [**ReceiptPAResultDTO**](ReceiptPAResultDTO.md)| Receipt PA configuration result | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assistantnotifyprocessdocchange"></a>
# **AssistantNotifyProcessDocChange**
> void AssistantNotifyProcessDocChange (int? processDocId, int? taskWorkId)

This call notifies the specified user that a document has changed

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AssistantNotifyProcessDocChangeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssistantApi();
            var processDocId = 56;  // int? | Process document identifier
            var taskWorkId = 56;  // int? | Taskwork identifier

            try
            {
                // This call notifies the specified user that a document has changed
                apiInstance.AssistantNotifyProcessDocChange(processDocId, taskWorkId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantApi.AssistantNotifyProcessDocChange: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDocId** | **int?**| Process document identifier | 
 **taskWorkId** | **int?**| Taskwork identifier | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assistantnotifyprofilechange"></a>
# **AssistantNotifyProfileChange**
> void AssistantNotifyProfileChange (int? docNumber)

This call notifies the specified user that a document has changed

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AssistantNotifyProfileChangeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssistantApi();
            var docNumber = 56;  // int? | Document identifier

            try
            {
                // This call notifies the specified user that a document has changed
                apiInstance.AssistantNotifyProfileChange(docNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantApi.AssistantNotifyProfileChange: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docNumber** | **int?**| Document identifier | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assistantscancomplete"></a>
# **AssistantScanComplete**
> void AssistantScanComplete (string connectionId, ScanResultDto scanResultDto)

This call notifies the specified user that a document has scanned

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AssistantScanCompleteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssistantApi();
            var connectionId = connectionId_example;  // string | Connection identifier
            var scanResultDto = new ScanResultDto(); // ScanResultDto | Result information to scan

            try
            {
                // This call notifies the specified user that a document has scanned
                apiInstance.AssistantScanComplete(connectionId, scanResultDto);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssistantApi.AssistantScanComplete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectionId** | **string**| Connection identifier | 
 **scanResultDto** | [**ScanResultDto**](ScanResultDto.md)| Result information to scan | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


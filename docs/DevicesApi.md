# ARXivarNEXT.Client.Api.DevicesApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DevicesGetDevices**](DevicesApi.md#devicesgetdevices) | **GET** /api/Devices/{type} | This call returns all devices defined for specified type


<a name="devicesgetdevices"></a>
# **DevicesGetDevices**
> List<DeviceDTO> DevicesGetDevices (int? type)

This call returns all devices defined for specified type

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DevicesGetDevicesExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DevicesApi();
            var type = 56;  // int? | Possible values:  0: Conservazione  1: Outsourcing  2: ExternalEngine 

            try
            {
                // This call returns all devices defined for specified type
                List&lt;DeviceDTO&gt; result = apiInstance.DevicesGetDevices(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevicesApi.DevicesGetDevices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **int?**| Possible values:  0: Conservazione  1: Outsourcing  2: ExternalEngine  | 

### Return type

[**List<DeviceDTO>**](DeviceDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


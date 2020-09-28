# ARXivarNEXT.Client.Api.DesktopApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DesktopDeleteItem**](DesktopApi.md#desktopdeleteitem) | **DELETE** /api/desktop | This call delete items from desktop
[**DesktopGet**](DesktopApi.md#desktopget) | **GET** /api/desktop | This call returns the desktop items for the user (old ARXivar desktop functionality)
[**DesktopInsertDocnumbers**](DesktopApi.md#desktopinsertdocnumbers) | **POST** /api/desktop/insert/documents | This call add profiles to dekstop


<a name="desktopdeleteitem"></a>
# **DesktopDeleteItem**
> void DesktopDeleteItem (DesktopItemDeleteRequestDTO desktopItemDeleteRequestDTO)

This call delete items from desktop

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DesktopDeleteItemExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DesktopApi();
            var desktopItemDeleteRequestDTO = new DesktopItemDeleteRequestDTO(); // DesktopItemDeleteRequestDTO | 

            try
            {
                // This call delete items from desktop
                apiInstance.DesktopDeleteItem(desktopItemDeleteRequestDTO);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesktopApi.DesktopDeleteItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **desktopItemDeleteRequestDTO** | [**DesktopItemDeleteRequestDTO**](DesktopItemDeleteRequestDTO.md)|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="desktopget"></a>
# **DesktopGet**
> DesktopDTO DesktopGet ()

This call returns the desktop items for the user (old ARXivar desktop functionality)

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DesktopGetExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DesktopApi();

            try
            {
                // This call returns the desktop items for the user (old ARXivar desktop functionality)
                DesktopDTO result = apiInstance.DesktopGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesktopApi.DesktopGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**DesktopDTO**](DesktopDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="desktopinsertdocnumbers"></a>
# **DesktopInsertDocnumbers**
> void DesktopInsertDocnumbers (List<int?> docnumbers)

This call add profiles to dekstop

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DesktopInsertDocnumbersExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DesktopApi();
            var docnumbers = ;  // List<int?> | Profile docnumbers to add

            try
            {
                // This call add profiles to dekstop
                apiInstance.DesktopInsertDocnumbers(docnumbers);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesktopApi.DesktopInsertDocnumbers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumbers** | **List&lt;int?&gt;**| Profile docnumbers to add | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


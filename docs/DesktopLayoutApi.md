# ARXivarNEXT.Client.Api.DesktopLayoutApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DesktopLayoutDelete**](DesktopLayoutApi.md#desktoplayoutdelete) | **DELETE** /api/DesktopLayout/{layoutId} | This call delete an existent layout
[**DesktopLayoutGet**](DesktopLayoutApi.md#desktoplayoutget) | **GET** /api/DesktopLayout | This call returns all layout
[**DesktopLayoutGetById**](DesktopLayoutApi.md#desktoplayoutgetbyid) | **GET** /api/DesktopLayout/{id} | This call returns the single layout by the given id
[**DesktopLayoutPost**](DesktopLayoutApi.md#desktoplayoutpost) | **POST** /api/DesktopLayout | This call save a new layout
[**DesktopLayoutPut**](DesktopLayoutApi.md#desktoplayoutput) | **PUT** /api/DesktopLayout/{id} | This call update a layout


<a name="desktoplayoutdelete"></a>
# **DesktopLayoutDelete**
> void DesktopLayoutDelete (int? layoutId)

This call delete an existent layout

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DesktopLayoutDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DesktopLayoutApi();
            var layoutId = 56;  // int? | Identifier of the layout to be deleted

            try
            {
                // This call delete an existent layout
                apiInstance.DesktopLayoutDelete(layoutId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesktopLayoutApi.DesktopLayoutDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutId** | **int?**| Identifier of the layout to be deleted | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="desktoplayoutget"></a>
# **DesktopLayoutGet**
> List<LayoutDesktopDTO> DesktopLayoutGet ()

This call returns all layout

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DesktopLayoutGetExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DesktopLayoutApi();

            try
            {
                // This call returns all layout
                List&lt;LayoutDesktopDTO&gt; result = apiInstance.DesktopLayoutGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesktopLayoutApi.DesktopLayoutGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<LayoutDesktopDTO>**](LayoutDesktopDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="desktoplayoutgetbyid"></a>
# **DesktopLayoutGetById**
> LayoutDesktopDTO DesktopLayoutGetById (int? id)

This call returns the single layout by the given id

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DesktopLayoutGetByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DesktopLayoutApi();
            var id = 56;  // int? | Identifier of the wanted layout

            try
            {
                // This call returns the single layout by the given id
                LayoutDesktopDTO result = apiInstance.DesktopLayoutGetById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesktopLayoutApi.DesktopLayoutGetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Identifier of the wanted layout | 

### Return type

[**LayoutDesktopDTO**](LayoutDesktopDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="desktoplayoutpost"></a>
# **DesktopLayoutPost**
> LayoutDesktopDTO DesktopLayoutPost (LayoutDesktopDTO layout)

This call save a new layout

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DesktopLayoutPostExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DesktopLayoutApi();
            var layout = new LayoutDesktopDTO(); // LayoutDesktopDTO | Layout to be saved

            try
            {
                // This call save a new layout
                LayoutDesktopDTO result = apiInstance.DesktopLayoutPost(layout);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesktopLayoutApi.DesktopLayoutPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layout** | [**LayoutDesktopDTO**](LayoutDesktopDTO.md)| Layout to be saved | 

### Return type

[**LayoutDesktopDTO**](LayoutDesktopDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="desktoplayoutput"></a>
# **DesktopLayoutPut**
> void DesktopLayoutPut (int? id, LayoutDesktopDTO layout)

This call update a layout

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DesktopLayoutPutExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DesktopLayoutApi();
            var id = 56;  // int? | Identifier of the wanted layout
            var layout = new LayoutDesktopDTO(); // LayoutDesktopDTO | New data of layout

            try
            {
                // This call update a layout
                apiInstance.DesktopLayoutPut(id, layout);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesktopLayoutApi.DesktopLayoutPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Identifier of the wanted layout | 
 **layout** | [**LayoutDesktopDTO**](LayoutDesktopDTO.md)| New data of layout | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# ARXivarNEXT.Client.Api.LayoutApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LayoutDelete**](LayoutApi.md#layoutdelete) | **DELETE** /api/Layout/{layoutId} | This call delete an existent layout
[**LayoutGetById**](LayoutApi.md#layoutgetbyid) | **GET** /api/Layout/{id} | This call returns the single layout by the given id
[**LayoutGetByTask**](LayoutApi.md#layoutgetbytask) | **GET** /api/Layout/Task/{taskWorkId}/{usingtype} | This call returns the layout for the given user, the given type and the given utilization
[**LayoutGetByType**](LayoutApi.md#layoutgetbytype) | **GET** /api/Layout/Type/{type} | This call returns all layout of the specified type
[**LayoutGetByUser**](LayoutApi.md#layoutgetbyuser) | **GET** /api/Layout/User/{userId}/{usingtype}/{layouttype} | This call returns the layout for the given user, the given type and the given utilization
[**LayoutPost**](LayoutApi.md#layoutpost) | **POST** /api/Layout | This call save a new layout
[**LayoutPut**](LayoutApi.md#layoutput) | **PUT** /api/Layout/{id} | This call update a layout
[**LayoutPutChangeOrder**](LayoutApi.md#layoutputchangeorder) | **PUT** /api/Layout/{layoutId}/{order} | This call changes the layout order for a given layout


<a name="layoutdelete"></a>
# **LayoutDelete**
> void LayoutDelete (int? layoutId)

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
    public class LayoutDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LayoutApi();
            var layoutId = 56;  // int? | Id of the layout to be deleted

            try
            {
                // This call delete an existent layout
                apiInstance.LayoutDelete(layoutId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LayoutApi.LayoutDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutId** | **int?**| Id of the layout to be deleted | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="layoutgetbyid"></a>
# **LayoutGetById**
> LayoutDTO LayoutGetById (int? id)

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
    public class LayoutGetByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LayoutApi();
            var id = 56;  // int? | Id of the wanted layout

            try
            {
                // This call returns the single layout by the given id
                LayoutDTO result = apiInstance.LayoutGetById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LayoutApi.LayoutGetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the wanted layout | 

### Return type

[**LayoutDTO**](LayoutDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="layoutgetbytask"></a>
# **LayoutGetByTask**
> LayoutDTO LayoutGetByTask (int? taskWorkId, int? usingtype)

This call returns the layout for the given user, the given type and the given utilization

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class LayoutGetByTaskExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LayoutApi();
            var taskWorkId = 56;  // int? | TaskWorkId
            var usingtype = 56;  // int? | Possible values:  2: Computer  4: Tablet  8: Smartphone 

            try
            {
                // This call returns the layout for the given user, the given type and the given utilization
                LayoutDTO result = apiInstance.LayoutGetByTask(taskWorkId, usingtype);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LayoutApi.LayoutGetByTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskWorkId** | **int?**| TaskWorkId | 
 **usingtype** | **int?**| Possible values:  2: Computer  4: Tablet  8: Smartphone  | 

### Return type

[**LayoutDTO**](LayoutDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="layoutgetbytype"></a>
# **LayoutGetByType**
> List<LayoutDTO> LayoutGetByType (int? type)

This call returns all layout of the specified type

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class LayoutGetByTypeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LayoutApi();
            var type = 56;  // int? | Possible values:  1: DesktopMenu  2: CommandsPanel 

            try
            {
                // This call returns all layout of the specified type
                List&lt;LayoutDTO&gt; result = apiInstance.LayoutGetByType(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LayoutApi.LayoutGetByType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **int?**| Possible values:  1: DesktopMenu  2: CommandsPanel  | 

### Return type

[**List<LayoutDTO>**](LayoutDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="layoutgetbyuser"></a>
# **LayoutGetByUser**
> LayoutDTO LayoutGetByUser (int? userId, int? usingtype, int? layouttype)

This call returns the layout for the given user, the given type and the given utilization

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class LayoutGetByUserExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LayoutApi();
            var userId = 56;  // int? | User Id
            var usingtype = 56;  // int? | Possible values:  2: Computer  4: Tablet  8: Smartphone 
            var layouttype = 56;  // int? | Possible values:  1: DesktopMenu  2: CommandsPanel 

            try
            {
                // This call returns the layout for the given user, the given type and the given utilization
                LayoutDTO result = apiInstance.LayoutGetByUser(userId, usingtype, layouttype);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LayoutApi.LayoutGetByUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| User Id | 
 **usingtype** | **int?**| Possible values:  2: Computer  4: Tablet  8: Smartphone  | 
 **layouttype** | **int?**| Possible values:  1: DesktopMenu  2: CommandsPanel  | 

### Return type

[**LayoutDTO**](LayoutDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="layoutpost"></a>
# **LayoutPost**
> LayoutDTO LayoutPost (LayoutDTO layout)

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
    public class LayoutPostExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LayoutApi();
            var layout = new LayoutDTO(); // LayoutDTO | Layout to be saved

            try
            {
                // This call save a new layout
                LayoutDTO result = apiInstance.LayoutPost(layout);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LayoutApi.LayoutPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layout** | [**LayoutDTO**](LayoutDTO.md)| Layout to be saved | 

### Return type

[**LayoutDTO**](LayoutDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="layoutput"></a>
# **LayoutPut**
> void LayoutPut (int? id, LayoutDTO layout)

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
    public class LayoutPutExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LayoutApi();
            var id = 56;  // int? | id of the wanted layout
            var layout = new LayoutDTO(); // LayoutDTO | New version of layout

            try
            {
                // This call update a layout
                apiInstance.LayoutPut(id, layout);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LayoutApi.LayoutPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of the wanted layout | 
 **layout** | [**LayoutDTO**](LayoutDTO.md)| New version of layout | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="layoutputchangeorder"></a>
# **LayoutPutChangeOrder**
> void LayoutPutChangeOrder (int? layoutId, int? order)

This call changes the layout order for a given layout

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class LayoutPutChangeOrderExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LayoutApi();
            var layoutId = 56;  // int? | Id of the layout
            var order = 56;  // int? | new order index for the given layout

            try
            {
                // This call changes the layout order for a given layout
                apiInstance.LayoutPutChangeOrder(layoutId, order);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LayoutApi.LayoutPutChangeOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **layoutId** | **int?**| Id of the layout | 
 **order** | **int?**| new order index for the given layout | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


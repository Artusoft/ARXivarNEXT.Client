# ARXivarNEXT.Client.Api.ViewsApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ViewsDeleteView**](ViewsApi.md#viewsdeleteview) | **DELETE** /api/Views/{id} | This call deletes the view
[**ViewsGetResult**](ViewsApi.md#viewsgetresult) | **POST** /api/Views | This call returns the results for the given view
[**ViewsGetView**](ViewsApi.md#viewsgetview) | **GET** /api/Views/{id} | This call returns the view with all information
[**ViewsGetViewByTaskWorkOperationId**](ViewsApi.md#viewsgetviewbytaskworkoperationid) | **GET** /api/Views/task/{taskworkId}/operation/{operationId} | This call return the view configured on a task operation with all information
[**ViewsGetViews**](ViewsApi.md#viewsgetviews) | **GET** /api/Views | This call returns the list of views for the connected user


<a name="viewsdeleteview"></a>
# **ViewsDeleteView**
> void ViewsDeleteView (string id)

This call deletes the view

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ViewsDeleteViewExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewsApi();
            var id = id_example;  // string | 

            try
            {
                // This call deletes the view
                apiInstance.ViewsDeleteView(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.ViewsDeleteView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewsgetresult"></a>
# **ViewsGetResult**
> List<RowSearchResult> ViewsGetResult (ViewDTO view = null)

This call returns the results for the given view

This method is deprecated. Use api/v3/Views

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ViewsGetResultExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewsApi();
            var view = new ViewDTO(); // ViewDTO |  (optional) 

            try
            {
                // This call returns the results for the given view
                List&lt;RowSearchResult&gt; result = apiInstance.ViewsGetResult(view);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.ViewsGetResult: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **view** | [**ViewDTO**](ViewDTO.md)|  | [optional] 

### Return type

[**List<RowSearchResult>**](RowSearchResult.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewsgetview"></a>
# **ViewsGetView**
> ViewDTO ViewsGetView (string id)

This call returns the view with all information

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ViewsGetViewExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewsApi();
            var id = id_example;  // string | 

            try
            {
                // This call returns the view with all information
                ViewDTO result = apiInstance.ViewsGetView(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.ViewsGetView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

[**ViewDTO**](ViewDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewsgetviewbytaskworkoperationid"></a>
# **ViewsGetViewByTaskWorkOperationId**
> ViewDTO ViewsGetViewByTaskWorkOperationId (int? taskworkId, string operationId)

This call return the view configured on a task operation with all information

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ViewsGetViewByTaskWorkOperationIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewsApi();
            var taskworkId = 56;  // int? | The id of the task
            var operationId = operationId_example;  // string | The task operation id

            try
            {
                // This call return the view configured on a task operation with all information
                ViewDTO result = apiInstance.ViewsGetViewByTaskWorkOperationId(taskworkId, operationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.ViewsGetViewByTaskWorkOperationId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskworkId** | **int?**| The id of the task | 
 **operationId** | **string**| The task operation id | 

### Return type

[**ViewDTO**](ViewDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewsgetviews"></a>
# **ViewsGetViews**
> List<ViewDTO> ViewsGetViews ()

This call returns the list of views for the connected user

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ViewsGetViewsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewsApi();

            try
            {
                // This call returns the list of views for the connected user
                List&lt;ViewDTO&gt; result = apiInstance.ViewsGetViews();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.ViewsGetViews: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ViewDTO>**](ViewDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


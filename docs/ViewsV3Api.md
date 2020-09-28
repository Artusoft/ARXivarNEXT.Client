# ARXivarNEXT.Client.Api.ViewsV3Api

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ViewsV3DeleteView**](ViewsV3Api.md#viewsv3deleteview) | **DELETE** /api/v3/Views/{id} | This call deletes the view
[**ViewsV3GetResult**](ViewsV3Api.md#viewsv3getresult) | **POST** /api/v3/Views | This call returns the results for the given view.  This call could not be compatible with some programming language, in this case use the call api/Views
[**ViewsV3GetResultForTask**](ViewsV3Api.md#viewsv3getresultfortask) | **POST** /api/v3/Views/task/{taskworkId}/operation/{operationId} | This call returns the results for the given view  This call could not be compatible with some programming language, in this case use the call api/Views/task/{taskworkId}/operation/{operationId}
[**ViewsV3GetView**](ViewsV3Api.md#viewsv3getview) | **GET** /api/v3/Views/{id} | This call returns the view with all information
[**ViewsV3GetViewByTaskWorkOperationId**](ViewsV3Api.md#viewsv3getviewbytaskworkoperationid) | **GET** /api/v3/Views/task/{taskworkId}/operation/{operationId} | This call return the view configured on a task operation with all information
[**ViewsV3GetViews**](ViewsV3Api.md#viewsv3getviews) | **GET** /api/v3/Views | This call returns the list of views for the connected user


<a name="viewsv3deleteview"></a>
# **ViewsV3DeleteView**
> void ViewsV3DeleteView (string id)

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
    public class ViewsV3DeleteViewExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewsV3Api();
            var id = id_example;  // string | 

            try
            {
                // This call deletes the view
                apiInstance.ViewsV3DeleteView(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsV3Api.ViewsV3DeleteView: " + e.Message );
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

<a name="viewsv3getresult"></a>
# **ViewsV3GetResult**
> Object ViewsV3GetResult (ViewDTO view = null)

This call returns the results for the given view.  This call could not be compatible with some programming language, in this case use the call api/Views

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ViewsV3GetResultExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewsV3Api();
            var view = new ViewDTO(); // ViewDTO |  (optional) 

            try
            {
                // This call returns the results for the given view.  This call could not be compatible with some programming language, in this case use the call api/Views
                Object result = apiInstance.ViewsV3GetResult(view);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsV3Api.ViewsV3GetResult: " + e.Message );
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

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewsv3getresultfortask"></a>
# **ViewsV3GetResultForTask**
> Object ViewsV3GetResultForTask (int? taskworkId, string operationId, ViewDTO view = null)

This call returns the results for the given view  This call could not be compatible with some programming language, in this case use the call api/Views/task/{taskworkId}/operation/{operationId}

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ViewsV3GetResultForTaskExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewsV3Api();
            var taskworkId = 56;  // int? | 
            var operationId = operationId_example;  // string | 
            var view = new ViewDTO(); // ViewDTO |  (optional) 

            try
            {
                // This call returns the results for the given view  This call could not be compatible with some programming language, in this case use the call api/Views/task/{taskworkId}/operation/{operationId}
                Object result = apiInstance.ViewsV3GetResultForTask(taskworkId, operationId, view);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsV3Api.ViewsV3GetResultForTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskworkId** | **int?**|  | 
 **operationId** | **string**|  | 
 **view** | [**ViewDTO**](ViewDTO.md)|  | [optional] 

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewsv3getview"></a>
# **ViewsV3GetView**
> ViewDTO ViewsV3GetView (string id)

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
    public class ViewsV3GetViewExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewsV3Api();
            var id = id_example;  // string | 

            try
            {
                // This call returns the view with all information
                ViewDTO result = apiInstance.ViewsV3GetView(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsV3Api.ViewsV3GetView: " + e.Message );
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

<a name="viewsv3getviewbytaskworkoperationid"></a>
# **ViewsV3GetViewByTaskWorkOperationId**
> ViewDTO ViewsV3GetViewByTaskWorkOperationId (int? taskworkId, string operationId)

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
    public class ViewsV3GetViewByTaskWorkOperationIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewsV3Api();
            var taskworkId = 56;  // int? | The id of the task
            var operationId = operationId_example;  // string | The task operation id

            try
            {
                // This call return the view configured on a task operation with all information
                ViewDTO result = apiInstance.ViewsV3GetViewByTaskWorkOperationId(taskworkId, operationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsV3Api.ViewsV3GetViewByTaskWorkOperationId: " + e.Message );
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

<a name="viewsv3getviews"></a>
# **ViewsV3GetViews**
> List<ViewDTO> ViewsV3GetViews ()

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
    public class ViewsV3GetViewsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewsV3Api();

            try
            {
                // This call returns the list of views for the connected user
                List&lt;ViewDTO&gt; result = apiInstance.ViewsV3GetViews();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsV3Api.ViewsV3GetViews: " + e.Message );
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


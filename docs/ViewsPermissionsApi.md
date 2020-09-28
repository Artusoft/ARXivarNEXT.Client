# ARXivarNEXT.Client.Api.ViewsPermissionsApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ViewsPermissionsGetPermissionByView**](ViewsPermissionsApi.md#viewspermissionsgetpermissionbyview) | **GET** /api/ViewsPermissions/{viewId} | This call returns all permissions for a view
[**ViewsPermissionsWritePermissionByView**](ViewsPermissionsApi.md#viewspermissionswritepermissionbyview) | **PUT** /api/ViewsPermissions/{viewId} | This call writes permissions for a view
[**ViewsPermissionsWritePermissionByView_0**](ViewsPermissionsApi.md#viewspermissionswritepermissionbyview_0) | **POST** /api/ViewsPermissions/{viewId} | This call writes permissions for a view


<a name="viewspermissionsgetpermissionbyview"></a>
# **ViewsPermissionsGetPermissionByView**
> PermissionsDTO ViewsPermissionsGetPermissionByView (string viewId)

This call returns all permissions for a view

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ViewsPermissionsGetPermissionByViewExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewsPermissionsApi();
            var viewId = viewId_example;  // string | View identifier

            try
            {
                // This call returns all permissions for a view
                PermissionsDTO result = apiInstance.ViewsPermissionsGetPermissionByView(viewId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsPermissionsApi.ViewsPermissionsGetPermissionByView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewId** | **string**| View identifier | 

### Return type

[**PermissionsDTO**](PermissionsDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewspermissionswritepermissionbyview"></a>
# **ViewsPermissionsWritePermissionByView**
> void ViewsPermissionsWritePermissionByView (string viewId, PermissionsDTO permissions)

This call writes permissions for a view

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ViewsPermissionsWritePermissionByViewExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewsPermissionsApi();
            var viewId = viewId_example;  // string | View identifier
            var permissions = new PermissionsDTO(); // PermissionsDTO | Permissions to set

            try
            {
                // This call writes permissions for a view
                apiInstance.ViewsPermissionsWritePermissionByView(viewId, permissions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsPermissionsApi.ViewsPermissionsWritePermissionByView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewId** | **string**| View identifier | 
 **permissions** | [**PermissionsDTO**](PermissionsDTO.md)| Permissions to set | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewspermissionswritepermissionbyview_0"></a>
# **ViewsPermissionsWritePermissionByView_0**
> void ViewsPermissionsWritePermissionByView_0 (string viewId, PermissionsDTO permissions)

This call writes permissions for a view

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ViewsPermissionsWritePermissionByView_0Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewsPermissionsApi();
            var viewId = viewId_example;  // string | View identifier
            var permissions = new PermissionsDTO(); // PermissionsDTO | Permissions to set

            try
            {
                // This call writes permissions for a view
                apiInstance.ViewsPermissionsWritePermissionByView_0(viewId, permissions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsPermissionsApi.ViewsPermissionsWritePermissionByView_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewId** | **string**| View identifier | 
 **permissions** | [**PermissionsDTO**](PermissionsDTO.md)| Permissions to set | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


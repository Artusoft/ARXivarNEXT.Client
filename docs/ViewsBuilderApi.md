# ARXivarNEXT.Client.Api.ViewsBuilderApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ViewsBuilderChangeShowFields**](ViewsBuilderApi.md#viewsbuilderchangeshowfields) | **PUT** /api/ViewsBuilder/showFields/{viewId}/{showFields} | This call updates &#39;show field&#39; in view execution
[**ViewsBuilderEditView**](ViewsBuilderApi.md#viewsbuildereditview) | **PUT** /api/ViewsBuilder | This call updates a view
[**ViewsBuilderEditView_0**](ViewsBuilderApi.md#viewsbuildereditview_0) | **POST** /api/ViewsBuilder | This call updates a view
[**ViewsBuilderGetSearch**](ViewsBuilderApi.md#viewsbuildergetsearch) | **GET** /api/ViewsBuilder/search/{documentType} | This call returns a new search by a document type
[**ViewsBuilderGetSearch_0**](ViewsBuilderApi.md#viewsbuildergetsearch_0) | **GET** /api/ViewsBuilder/search/{documentType}/{tipo2}/{tipo3} | This call returns a new search by a document type
[**ViewsBuilderGetSelect**](ViewsBuilderApi.md#viewsbuildergetselect) | **GET** /api/ViewsBuilder/select/{documentType} | This call returns a new select by a document type
[**ViewsBuilderGetSelect_0**](ViewsBuilderApi.md#viewsbuildergetselect_0) | **GET** /api/ViewsBuilder/select/{documentType}/{tipo2}/{tipo3} | This call returns a new select by a document type
[**ViewsBuilderGetViewForEdit**](ViewsBuilderApi.md#viewsbuildergetviewforedit) | **GET** /api/ViewsBuilder/{viewId} | This call returns a view for edit purpose


<a name="viewsbuilderchangeshowfields"></a>
# **ViewsBuilderChangeShowFields**
> void ViewsBuilderChangeShowFields (string viewId, bool? showFields)

This call updates 'show field' in view execution

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ViewsBuilderChangeShowFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewsBuilderApi();
            var viewId = viewId_example;  // string | View identifier
            var showFields = true;  // bool? | Value for the flag

            try
            {
                // This call updates 'show field' in view execution
                apiInstance.ViewsBuilderChangeShowFields(viewId, showFields);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsBuilderApi.ViewsBuilderChangeShowFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewId** | **string**| View identifier | 
 **showFields** | **bool?**| Value for the flag | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewsbuildereditview"></a>
# **ViewsBuilderEditView**
> ViewEditDTO ViewsBuilderEditView (ViewEditDTO viewedit = null)

This call updates a view

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ViewsBuilderEditViewExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewsBuilderApi();
            var viewedit = new ViewEditDTO(); // ViewEditDTO |  (optional) 

            try
            {
                // This call updates a view
                ViewEditDTO result = apiInstance.ViewsBuilderEditView(viewedit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsBuilderApi.ViewsBuilderEditView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewedit** | [**ViewEditDTO**](ViewEditDTO.md)|  | [optional] 

### Return type

[**ViewEditDTO**](ViewEditDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewsbuildereditview_0"></a>
# **ViewsBuilderEditView_0**
> ViewEditDTO ViewsBuilderEditView_0 (ViewEditDTO viewedit = null)

This call updates a view

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ViewsBuilderEditView_0Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewsBuilderApi();
            var viewedit = new ViewEditDTO(); // ViewEditDTO |  (optional) 

            try
            {
                // This call updates a view
                ViewEditDTO result = apiInstance.ViewsBuilderEditView_0(viewedit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsBuilderApi.ViewsBuilderEditView_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewedit** | [**ViewEditDTO**](ViewEditDTO.md)|  | [optional] 

### Return type

[**ViewEditDTO**](ViewEditDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewsbuildergetsearch"></a>
# **ViewsBuilderGetSearch**
> SearchDTO ViewsBuilderGetSearch (int? documentType)

This call returns a new search by a document type

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ViewsBuilderGetSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewsBuilderApi();
            var documentType = 56;  // int? | Document type identifer

            try
            {
                // This call returns a new search by a document type
                SearchDTO result = apiInstance.ViewsBuilderGetSearch(documentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsBuilderApi.ViewsBuilderGetSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentType** | **int?**| Document type identifer | 

### Return type

[**SearchDTO**](SearchDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewsbuildergetsearch_0"></a>
# **ViewsBuilderGetSearch_0**
> SearchDTO ViewsBuilderGetSearch_0 (int? documentType, int? tipo2, int? tipo3)

This call returns a new search by a document type

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ViewsBuilderGetSearch_0Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewsBuilderApi();
            var documentType = 56;  // int? | Identifier of first level document type
            var tipo2 = 56;  // int? | Identifier of secodn level document type
            var tipo3 = 56;  // int? | Identifier of third level document type

            try
            {
                // This call returns a new search by a document type
                SearchDTO result = apiInstance.ViewsBuilderGetSearch_0(documentType, tipo2, tipo3);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsBuilderApi.ViewsBuilderGetSearch_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentType** | **int?**| Identifier of first level document type | 
 **tipo2** | **int?**| Identifier of secodn level document type | 
 **tipo3** | **int?**| Identifier of third level document type | 

### Return type

[**SearchDTO**](SearchDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewsbuildergetselect"></a>
# **ViewsBuilderGetSelect**
> SelectDTO ViewsBuilderGetSelect (int? documentType)

This call returns a new select by a document type

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ViewsBuilderGetSelectExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewsBuilderApi();
            var documentType = 56;  // int? | Document type identifier

            try
            {
                // This call returns a new select by a document type
                SelectDTO result = apiInstance.ViewsBuilderGetSelect(documentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsBuilderApi.ViewsBuilderGetSelect: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentType** | **int?**| Document type identifier | 

### Return type

[**SelectDTO**](SelectDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewsbuildergetselect_0"></a>
# **ViewsBuilderGetSelect_0**
> SelectDTO ViewsBuilderGetSelect_0 (int? documentType, int? tipo2, int? tipo3)

This call returns a new select by a document type

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ViewsBuilderGetSelect_0Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewsBuilderApi();
            var documentType = 56;  // int? | Identifier of first level document type
            var tipo2 = 56;  // int? | Identifier of secodn level document type
            var tipo3 = 56;  // int? | Identifier of third level document type

            try
            {
                // This call returns a new select by a document type
                SelectDTO result = apiInstance.ViewsBuilderGetSelect_0(documentType, tipo2, tipo3);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsBuilderApi.ViewsBuilderGetSelect_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentType** | **int?**| Identifier of first level document type | 
 **tipo2** | **int?**| Identifier of secodn level document type | 
 **tipo3** | **int?**| Identifier of third level document type | 

### Return type

[**SelectDTO**](SelectDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewsbuildergetviewforedit"></a>
# **ViewsBuilderGetViewForEdit**
> ViewEditDTO ViewsBuilderGetViewForEdit (string viewId)

This call returns a view for edit purpose

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ViewsBuilderGetViewForEditExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewsBuilderApi();
            var viewId = viewId_example;  // string | View identifier

            try
            {
                // This call returns a view for edit purpose
                ViewEditDTO result = apiInstance.ViewsBuilderGetViewForEdit(viewId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsBuilderApi.ViewsBuilderGetViewForEdit: " + e.Message );
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

[**ViewEditDTO**](ViewEditDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


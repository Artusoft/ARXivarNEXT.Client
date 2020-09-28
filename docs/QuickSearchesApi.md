# ARXivarNEXT.Client.Api.QuickSearchesApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**QuickSearchesChangeShowFields**](QuickSearchesApi.md#quicksearcheschangeshowfields) | **GET** /api/QuickSearches/showFields/{quickSearchId}/{showFields} | This call changes the flag that enable show of the search fields
[**QuickSearchesDeleteQuickSearchById**](QuickSearchesApi.md#quicksearchesdeletequicksearchbyid) | **DELETE** /api/QuickSearches/{quickSearchId} | This call deletes a quick search
[**QuickSearchesGetQuickSearch**](QuickSearchesApi.md#quicksearchesgetquicksearch) | **GET** /api/QuickSearches | This call returns all quick search
[**QuickSearchesGetQuickSearchById**](QuickSearchesApi.md#quicksearchesgetquicksearchbyid) | **GET** /api/QuickSearches/{quickSearchId} | Thi call returns a quick search by its id
[**QuickSearchesPost**](QuickSearchesApi.md#quicksearchespost) | **POST** /api/QuickSearches | This call adds a new quinck search
[**QuickSearchesPut**](QuickSearchesApi.md#quicksearchesput) | **PUT** /api/QuickSearches/{quickSearchId} | This call updates a quick search
[**QuickSearchesRename**](QuickSearchesApi.md#quicksearchesrename) | **PUT** /api/QuickSearches/rename | This call renames a quick search


<a name="quicksearcheschangeshowfields"></a>
# **QuickSearchesChangeShowFields**
> void QuickSearchesChangeShowFields (string quickSearchId, bool? showFields)

This call changes the flag that enable show of the search fields

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class QuickSearchesChangeShowFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuickSearchesApi();
            var quickSearchId = quickSearchId_example;  // string | Quick search identifier
            var showFields = true;  // bool? | Value for the flag

            try
            {
                // This call changes the flag that enable show of the search fields
                apiInstance.QuickSearchesChangeShowFields(quickSearchId, showFields);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickSearchesApi.QuickSearchesChangeShowFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quickSearchId** | **string**| Quick search identifier | 
 **showFields** | **bool?**| Value for the flag | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quicksearchesdeletequicksearchbyid"></a>
# **QuickSearchesDeleteQuickSearchById**
> void QuickSearchesDeleteQuickSearchById (string quickSearchId)

This call deletes a quick search

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class QuickSearchesDeleteQuickSearchByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuickSearchesApi();
            var quickSearchId = quickSearchId_example;  // string | Quick search identifier

            try
            {
                // This call deletes a quick search
                apiInstance.QuickSearchesDeleteQuickSearchById(quickSearchId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickSearchesApi.QuickSearchesDeleteQuickSearchById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quickSearchId** | **string**| Quick search identifier | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quicksearchesgetquicksearch"></a>
# **QuickSearchesGetQuickSearch**
> List<FindDTO> QuickSearchesGetQuickSearch ()

This call returns all quick search

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class QuickSearchesGetQuickSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuickSearchesApi();

            try
            {
                // This call returns all quick search
                List&lt;FindDTO&gt; result = apiInstance.QuickSearchesGetQuickSearch();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickSearchesApi.QuickSearchesGetQuickSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<FindDTO>**](FindDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quicksearchesgetquicksearchbyid"></a>
# **QuickSearchesGetQuickSearchById**
> SimpleQuickSearchDto QuickSearchesGetQuickSearchById (string quickSearchId)

Thi call returns a quick search by its id

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class QuickSearchesGetQuickSearchByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuickSearchesApi();
            var quickSearchId = quickSearchId_example;  // string | Quick search identifier

            try
            {
                // Thi call returns a quick search by its id
                SimpleQuickSearchDto result = apiInstance.QuickSearchesGetQuickSearchById(quickSearchId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickSearchesApi.QuickSearchesGetQuickSearchById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quickSearchId** | **string**| Quick search identifier | 

### Return type

[**SimpleQuickSearchDto**](SimpleQuickSearchDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quicksearchespost"></a>
# **QuickSearchesPost**
> string QuickSearchesPost (SimpleQuickSearchDto criteria = null)

This call adds a new quinck search

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class QuickSearchesPostExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuickSearchesApi();
            var criteria = new SimpleQuickSearchDto(); // SimpleQuickSearchDto |  (optional) 

            try
            {
                // This call adds a new quinck search
                string result = apiInstance.QuickSearchesPost(criteria);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickSearchesApi.QuickSearchesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | [**SimpleQuickSearchDto**](SimpleQuickSearchDto.md)|  | [optional] 

### Return type

**string**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quicksearchesput"></a>
# **QuickSearchesPut**
> string QuickSearchesPut (string quickSearchId, SimpleQuickSearchDto criteria = null)

This call updates a quick search

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class QuickSearchesPutExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuickSearchesApi();
            var quickSearchId = quickSearchId_example;  // string | Quick search identifier
            var criteria = new SimpleQuickSearchDto(); // SimpleQuickSearchDto |  (optional) 

            try
            {
                // This call updates a quick search
                string result = apiInstance.QuickSearchesPut(quickSearchId, criteria);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickSearchesApi.QuickSearchesPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quickSearchId** | **string**| Quick search identifier | 
 **criteria** | [**SimpleQuickSearchDto**](SimpleQuickSearchDto.md)|  | [optional] 

### Return type

**string**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quicksearchesrename"></a>
# **QuickSearchesRename**
> void QuickSearchesRename (RenamedQuickSearchDto quickSearchRenamed)

This call renames a quick search

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class QuickSearchesRenameExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuickSearchesApi();
            var quickSearchRenamed = new RenamedQuickSearchDto(); // RenamedQuickSearchDto | Information to update

            try
            {
                // This call renames a quick search
                apiInstance.QuickSearchesRename(quickSearchRenamed);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickSearchesApi.QuickSearchesRename: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quickSearchRenamed** | [**RenamedQuickSearchDto**](RenamedQuickSearchDto.md)| Information to update | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# ARXivarNEXT.Client.Api.GlobalSearchApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GlobalSearchGetFullIndexSearch**](GlobalSearchApi.md#globalsearchgetfullindexsearch) | **GET** /api/GlobalSearches/search/{searchFilter} | This call returns the result of a search in full index
[**GlobalSearchGetFullIndexSearch_0**](GlobalSearchApi.md#globalsearchgetfullindexsearch_0) | **POST** /api/GlobalSearches/search | This call returns the result of a search in full index
[**GlobalSearchGlobalSearch**](GlobalSearchApi.md#globalsearchglobalsearch) | **GET** /api/GlobalSearches/{searchFilter} | This call returns all elements match the given filter


<a name="globalsearchgetfullindexsearch"></a>
# **GlobalSearchGetFullIndexSearch**
> List<RowSearchResult> GlobalSearchGetFullIndexSearch (string searchFilter)

This call returns the result of a search in full index

This method is deprecated. Use api/v3/GlobalSearches/search/{searchFilter=searchFilter}

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class GlobalSearchGetFullIndexSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GlobalSearchApi();
            var searchFilter = searchFilter_example;  // string | Filter to be applied to the search

            try
            {
                // This call returns the result of a search in full index
                List&lt;RowSearchResult&gt; result = apiInstance.GlobalSearchGetFullIndexSearch(searchFilter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GlobalSearchApi.GlobalSearchGetFullIndexSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchFilter** | **string**| Filter to be applied to the search | 

### Return type

[**List<RowSearchResult>**](RowSearchResult.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="globalsearchgetfullindexsearch_0"></a>
# **GlobalSearchGetFullIndexSearch_0**
> List<RowSearchResult> GlobalSearchGetFullIndexSearch_0 (FullIndexSearchRequestDto fullindexsearchrequestdto = null)

This call returns the result of a search in full index

This method is deprecated. Use api/v3/GlobalSearches/search

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class GlobalSearchGetFullIndexSearch_0Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GlobalSearchApi();
            var fullindexsearchrequestdto = new FullIndexSearchRequestDto(); // FullIndexSearchRequestDto |  (optional) 

            try
            {
                // This call returns the result of a search in full index
                List&lt;RowSearchResult&gt; result = apiInstance.GlobalSearchGetFullIndexSearch_0(fullindexsearchrequestdto);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GlobalSearchApi.GlobalSearchGetFullIndexSearch_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fullindexsearchrequestdto** | [**FullIndexSearchRequestDto**](FullIndexSearchRequestDto.md)|  | [optional] 

### Return type

[**List<RowSearchResult>**](RowSearchResult.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="globalsearchglobalsearch"></a>
# **GlobalSearchGlobalSearch**
> List<GenericItemDTO> GlobalSearchGlobalSearch (string searchFilter)

This call returns all elements match the given filter

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class GlobalSearchGlobalSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GlobalSearchApi();
            var searchFilter = searchFilter_example;  // string | Filter to be applied to the search

            try
            {
                // This call returns all elements match the given filter
                List&lt;GenericItemDTO&gt; result = apiInstance.GlobalSearchGlobalSearch(searchFilter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GlobalSearchApi.GlobalSearchGlobalSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchFilter** | **string**| Filter to be applied to the search | 

### Return type

[**List<GenericItemDTO>**](GenericItemDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


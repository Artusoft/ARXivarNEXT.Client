# ARXivarNEXT.Client.Api.GlobalSearchV3Api

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GlobalSearchV3GetFullIndexSearch**](GlobalSearchV3Api.md#globalsearchv3getfullindexsearch) | **GET** /api/v3/GlobalSearches/search/{searchFilter} | This call returns the result of a search in full index.  This call could not be compatible with some programming language, in this case use the call api/GlobalSearches/search/{searchFilter&#x3D;searchFilter}
[**GlobalSearchV3GetFullIndexSearch_0**](GlobalSearchV3Api.md#globalsearchv3getfullindexsearch_0) | **POST** /api/v3/GlobalSearches/search | This call returns the result of a search in full index.  This call could not be compatible with some programming language, in this case use the call api/GlobalSearches/search
[**GlobalSearchV3GlobalSearch**](GlobalSearchV3Api.md#globalsearchv3globalsearch) | **GET** /api/v3/GlobalSearches/{searchFilter} | This call returns all elements match the given filter


<a name="globalsearchv3getfullindexsearch"></a>
# **GlobalSearchV3GetFullIndexSearch**
> Object GlobalSearchV3GetFullIndexSearch (string searchFilter)

This call returns the result of a search in full index.  This call could not be compatible with some programming language, in this case use the call api/GlobalSearches/search/{searchFilter=searchFilter}

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class GlobalSearchV3GetFullIndexSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GlobalSearchV3Api();
            var searchFilter = searchFilter_example;  // string | Filter to be applied to the search

            try
            {
                // This call returns the result of a search in full index.  This call could not be compatible with some programming language, in this case use the call api/GlobalSearches/search/{searchFilter=searchFilter}
                Object result = apiInstance.GlobalSearchV3GetFullIndexSearch(searchFilter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GlobalSearchV3Api.GlobalSearchV3GetFullIndexSearch: " + e.Message );
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

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="globalsearchv3getfullindexsearch_0"></a>
# **GlobalSearchV3GetFullIndexSearch_0**
> Object GlobalSearchV3GetFullIndexSearch_0 (FullIndexSearchRequestDto fullindexsearchrequestdto = null)

This call returns the result of a search in full index.  This call could not be compatible with some programming language, in this case use the call api/GlobalSearches/search

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class GlobalSearchV3GetFullIndexSearch_0Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GlobalSearchV3Api();
            var fullindexsearchrequestdto = new FullIndexSearchRequestDto(); // FullIndexSearchRequestDto |  (optional) 

            try
            {
                // This call returns the result of a search in full index.  This call could not be compatible with some programming language, in this case use the call api/GlobalSearches/search
                Object result = apiInstance.GlobalSearchV3GetFullIndexSearch_0(fullindexsearchrequestdto);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GlobalSearchV3Api.GlobalSearchV3GetFullIndexSearch_0: " + e.Message );
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

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="globalsearchv3globalsearch"></a>
# **GlobalSearchV3GlobalSearch**
> List<GenericItemDTO> GlobalSearchV3GlobalSearch (string searchFilter)

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
    public class GlobalSearchV3GlobalSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GlobalSearchV3Api();
            var searchFilter = searchFilter_example;  // string | Filter to be applied to the search

            try
            {
                // This call returns all elements match the given filter
                List&lt;GenericItemDTO&gt; result = apiInstance.GlobalSearchV3GlobalSearch(searchFilter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GlobalSearchV3Api.GlobalSearchV3GlobalSearch: " + e.Message );
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


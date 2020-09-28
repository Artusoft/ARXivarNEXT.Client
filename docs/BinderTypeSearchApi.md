# ARXivarNEXT.Client.Api.BinderTypeSearchApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BinderTypeSearchGetBindersByAdvancedSearch**](BinderTypeSearchApi.md#bindertypesearchgetbindersbyadvancedsearch) | **POST** /api/BinderTypeSearches | This call returns binders by a given search object
[**BinderTypeSearchGetSearchByBinderType**](BinderTypeSearchApi.md#bindertypesearchgetsearchbybindertype) | **GET** /api/BinderTypeSearches/{binderTypeId} | This call returns a search object for a search by binder type


<a name="bindertypesearchgetbindersbyadvancedsearch"></a>
# **BinderTypeSearchGetBindersByAdvancedSearch**
> List<BinderDTO> BinderTypeSearchGetBindersByAdvancedSearch (SearchConcreteDTO search)

This call returns binders by a given search object

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BinderTypeSearchGetBindersByAdvancedSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BinderTypeSearchApi();
            var search = new SearchConcreteDTO(); // SearchConcreteDTO | The search object

            try
            {
                // This call returns binders by a given search object
                List&lt;BinderDTO&gt; result = apiInstance.BinderTypeSearchGetBindersByAdvancedSearch(search);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BinderTypeSearchApi.BinderTypeSearchGetBindersByAdvancedSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **search** | [**SearchConcreteDTO**](SearchConcreteDTO.md)| The search object | 

### Return type

[**List<BinderDTO>**](BinderDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bindertypesearchgetsearchbybindertype"></a>
# **BinderTypeSearchGetSearchByBinderType**
> SearchConcreteDTO BinderTypeSearchGetSearchByBinderType (int? binderTypeId)

This call returns a search object for a search by binder type

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BinderTypeSearchGetSearchByBinderTypeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BinderTypeSearchApi();
            var binderTypeId = 56;  // int? | The identifier of the binder type

            try
            {
                // This call returns a search object for a search by binder type
                SearchConcreteDTO result = apiInstance.BinderTypeSearchGetSearchByBinderType(binderTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BinderTypeSearchApi.BinderTypeSearchGetSearchByBinderType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **binderTypeId** | **int?**| The identifier of the binder type | 

### Return type

[**SearchConcreteDTO**](SearchConcreteDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


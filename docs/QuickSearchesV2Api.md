# ARXivarNEXT.Client.Api.QuickSearchesV2Api

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**QuickSearchesV2ChangeShowFields**](QuickSearchesV2Api.md#quicksearchesv2changeshowfields) | **GET** /api/v2/QuickSearches/showFields/{quickSearchId}/{showFields} | This call changes the flag that enable show of the search fields
[**QuickSearchesV2DeleteQuickSearchById**](QuickSearchesV2Api.md#quicksearchesv2deletequicksearchbyid) | **DELETE** /api/v2/QuickSearches/{quickSearchId} | This call deletes a quick search
[**QuickSearchesV2GetQuickSearch**](QuickSearchesV2Api.md#quicksearchesv2getquicksearch) | **GET** /api/v2/QuickSearches | This call returns all quick search
[**QuickSearchesV2GetQuickSearchById**](QuickSearchesV2Api.md#quicksearchesv2getquicksearchbyid) | **GET** /api/v2/QuickSearches/{quickSearchId} | Thi call returns a quick search by its id
[**QuickSearchesV2Post**](QuickSearchesV2Api.md#quicksearchesv2post) | **POST** /api/v2/QuickSearches | This call adds a new quinck search
[**QuickSearchesV2Put**](QuickSearchesV2Api.md#quicksearchesv2put) | **PUT** /api/v2/QuickSearches/{quickSearchId} | This call updates a quick search
[**QuickSearchesV2Rename**](QuickSearchesV2Api.md#quicksearchesv2rename) | **PUT** /api/v2/QuickSearches/rename | This call renames a quick search


<a name="quicksearchesv2changeshowfields"></a>
# **QuickSearchesV2ChangeShowFields**
> void QuickSearchesV2ChangeShowFields (string quickSearchId, bool? showFields)

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
    public class QuickSearchesV2ChangeShowFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuickSearchesV2Api();
            var quickSearchId = quickSearchId_example;  // string | Quick search identifier
            var showFields = true;  // bool? | Value for the flag

            try
            {
                // This call changes the flag that enable show of the search fields
                apiInstance.QuickSearchesV2ChangeShowFields(quickSearchId, showFields);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickSearchesV2Api.QuickSearchesV2ChangeShowFields: " + e.Message );
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

<a name="quicksearchesv2deletequicksearchbyid"></a>
# **QuickSearchesV2DeleteQuickSearchById**
> void QuickSearchesV2DeleteQuickSearchById (string quickSearchId)

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
    public class QuickSearchesV2DeleteQuickSearchByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuickSearchesV2Api();
            var quickSearchId = quickSearchId_example;  // string | Quick search identifier

            try
            {
                // This call deletes a quick search
                apiInstance.QuickSearchesV2DeleteQuickSearchById(quickSearchId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickSearchesV2Api.QuickSearchesV2DeleteQuickSearchById: " + e.Message );
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

<a name="quicksearchesv2getquicksearch"></a>
# **QuickSearchesV2GetQuickSearch**
> List<FindDTO> QuickSearchesV2GetQuickSearch ()

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
    public class QuickSearchesV2GetQuickSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuickSearchesV2Api();

            try
            {
                // This call returns all quick search
                List&lt;FindDTO&gt; result = apiInstance.QuickSearchesV2GetQuickSearch();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickSearchesV2Api.QuickSearchesV2GetQuickSearch: " + e.Message );
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

<a name="quicksearchesv2getquicksearchbyid"></a>
# **QuickSearchesV2GetQuickSearchById**
> QuickSearchDto QuickSearchesV2GetQuickSearchById (string quickSearchId)

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
    public class QuickSearchesV2GetQuickSearchByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuickSearchesV2Api();
            var quickSearchId = quickSearchId_example;  // string | Quick search identifier

            try
            {
                // Thi call returns a quick search by its id
                QuickSearchDto result = apiInstance.QuickSearchesV2GetQuickSearchById(quickSearchId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickSearchesV2Api.QuickSearchesV2GetQuickSearchById: " + e.Message );
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

[**QuickSearchDto**](QuickSearchDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quicksearchesv2post"></a>
# **QuickSearchesV2Post**
> string QuickSearchesV2Post (QuickSearchDto criteria = null)

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
    public class QuickSearchesV2PostExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuickSearchesV2Api();
            var criteria = new QuickSearchDto(); // QuickSearchDto |  (optional) 

            try
            {
                // This call adds a new quinck search
                string result = apiInstance.QuickSearchesV2Post(criteria);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickSearchesV2Api.QuickSearchesV2Post: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | [**QuickSearchDto**](QuickSearchDto.md)|  | [optional] 

### Return type

**string**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quicksearchesv2put"></a>
# **QuickSearchesV2Put**
> string QuickSearchesV2Put (string quickSearchId, QuickSearchDto criteria = null)

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
    public class QuickSearchesV2PutExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuickSearchesV2Api();
            var quickSearchId = quickSearchId_example;  // string | Quick search identifier
            var criteria = new QuickSearchDto(); // QuickSearchDto |  (optional) 

            try
            {
                // This call updates a quick search
                string result = apiInstance.QuickSearchesV2Put(quickSearchId, criteria);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickSearchesV2Api.QuickSearchesV2Put: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quickSearchId** | **string**| Quick search identifier | 
 **criteria** | [**QuickSearchDto**](QuickSearchDto.md)|  | [optional] 

### Return type

**string**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quicksearchesv2rename"></a>
# **QuickSearchesV2Rename**
> void QuickSearchesV2Rename (RenamedQuickSearchDto quickSearchRenamed)

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
    public class QuickSearchesV2RenameExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuickSearchesV2Api();
            var quickSearchRenamed = new RenamedQuickSearchDto(); // RenamedQuickSearchDto | Information to update

            try
            {
                // This call renames a quick search
                apiInstance.QuickSearchesV2Rename(quickSearchRenamed);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuickSearchesV2Api.QuickSearchesV2Rename: " + e.Message );
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


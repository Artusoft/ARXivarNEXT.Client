# ARXivarNEXT.Client.Api.BinderSearchApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BinderSearchGetProfilesByPratica**](BinderSearchApi.md#bindersearchgetprofilesbypratica) | **POST** /api/BinderSearches | This call returns all documents contained in a specific binder


<a name="bindersearchgetprofilesbypratica"></a>
# **BinderSearchGetProfilesByPratica**
> List<RowSearchResult> BinderSearchGetProfilesByPratica (BinderProfilesSearchRequestDTO request)

This call returns all documents contained in a specific binder

This method is deprecated. Use api/v2/BinderSearches

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BinderSearchGetProfilesByPraticaExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BinderSearchApi();
            var request = new BinderProfilesSearchRequestDTO(); // BinderProfilesSearchRequestDTO | The request object for the search

            try
            {
                // This call returns all documents contained in a specific binder
                List&lt;RowSearchResult&gt; result = apiInstance.BinderSearchGetProfilesByPratica(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BinderSearchApi.BinderSearchGetProfilesByPratica: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**BinderProfilesSearchRequestDTO**](BinderProfilesSearchRequestDTO.md)| The request object for the search | 

### Return type

[**List<RowSearchResult>**](RowSearchResult.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


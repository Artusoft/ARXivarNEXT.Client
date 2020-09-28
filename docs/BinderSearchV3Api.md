# ARXivarNEXT.Client.Api.BinderSearchV3Api

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BinderSearchV3GetProfilesByPratica**](BinderSearchV3Api.md#bindersearchv3getprofilesbypratica) | **POST** /api/v3/BinderSearches | This call returns all documents contained in a specific binder  This call could not be compatible with some programming language, in this case use the call \&quot;api/BinderSearches


<a name="bindersearchv3getprofilesbypratica"></a>
# **BinderSearchV3GetProfilesByPratica**
> Object BinderSearchV3GetProfilesByPratica (BinderProfilesSearchRequestDTO request)

This call returns all documents contained in a specific binder  This call could not be compatible with some programming language, in this case use the call \"api/BinderSearches

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BinderSearchV3GetProfilesByPraticaExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BinderSearchV3Api();
            var request = new BinderProfilesSearchRequestDTO(); // BinderProfilesSearchRequestDTO | The request object for the search

            try
            {
                // This call returns all documents contained in a specific binder  This call could not be compatible with some programming language, in this case use the call \"api/BinderSearches
                Object result = apiInstance.BinderSearchV3GetProfilesByPratica(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BinderSearchV3Api.BinderSearchV3GetProfilesByPratica: " + e.Message );
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

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


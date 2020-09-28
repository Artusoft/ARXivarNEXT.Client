# ARXivarNEXT.Client.Api.AddressBookSearchApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddressBookSearchGetSearch**](AddressBookSearchApi.md#addressbooksearchgetsearch) | **GET** /api/AddressBookSearches/Search | This call returns a searchDTO object for search in addressbook
[**AddressBookSearchGetSelect**](AddressBookSearchApi.md#addressbooksearchgetselect) | **GET** /api/AddressBookSearches/Select | This call returns a selectDTO object for search in addressbook
[**AddressBookSearchPostSearch**](AddressBookSearchApi.md#addressbooksearchpostsearch) | **POST** /api/AddressBookSearches | This call searches in address book with search and select DTO system


<a name="addressbooksearchgetsearch"></a>
# **AddressBookSearchGetSearch**
> AddressBookSearchConcreteDTO AddressBookSearchGetSearch ()

This call returns a searchDTO object for search in addressbook

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookSearchGetSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookSearchApi();

            try
            {
                // This call returns a searchDTO object for search in addressbook
                AddressBookSearchConcreteDTO result = apiInstance.AddressBookSearchGetSearch();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookSearchApi.AddressBookSearchGetSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AddressBookSearchConcreteDTO**](AddressBookSearchConcreteDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbooksearchgetselect"></a>
# **AddressBookSearchGetSelect**
> SelectDTO AddressBookSearchGetSelect ()

This call returns a selectDTO object for search in addressbook

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookSearchGetSelectExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookSearchApi();

            try
            {
                // This call returns a selectDTO object for search in addressbook
                SelectDTO result = apiInstance.AddressBookSearchGetSelect();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookSearchApi.AddressBookSearchGetSelect: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SelectDTO**](SelectDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbooksearchpostsearch"></a>
# **AddressBookSearchPostSearch**
> List<RowSearchResult> AddressBookSearchPostSearch (AddressBookSearchConcreteCriteriaDTO searchCriteria)

This call searches in address book with search and select DTO system

This method is deprecated. Use api/v2/AddressBookSearches

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookSearchPostSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookSearchApi();
            var searchCriteria = new AddressBookSearchConcreteCriteriaDTO(); // AddressBookSearchConcreteCriteriaDTO | 

            try
            {
                // This call searches in address book with search and select DTO system
                List&lt;RowSearchResult&gt; result = apiInstance.AddressBookSearchPostSearch(searchCriteria);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookSearchApi.AddressBookSearchPostSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchCriteria** | [**AddressBookSearchConcreteCriteriaDTO**](AddressBookSearchConcreteCriteriaDTO.md)|  | 

### Return type

[**List<RowSearchResult>**](RowSearchResult.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


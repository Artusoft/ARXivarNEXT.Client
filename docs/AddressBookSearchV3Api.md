# ARXivarNEXT.Client.Api.AddressBookSearchV3Api

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddressBookSearchV3GetSearch**](AddressBookSearchV3Api.md#addressbooksearchv3getsearch) | **GET** /api/v3/AddressBookSearches/Search | This call returns a searchDTO object for search in addressbook
[**AddressBookSearchV3GetSelect**](AddressBookSearchV3Api.md#addressbooksearchv3getselect) | **GET** /api/v3/AddressBookSearches/Select | This call returns a selectDTO object for search in addressbook
[**AddressBookSearchV3PostSearch**](AddressBookSearchV3Api.md#addressbooksearchv3postsearch) | **POST** /api/v3/AddressBookSearches | This call searches in address book with search and select DTO system.  This call could not be compatible with some programming language, in this case use the call api/AddressBookSearches


<a name="addressbooksearchv3getsearch"></a>
# **AddressBookSearchV3GetSearch**
> AddressBookSearchConcreteDTO AddressBookSearchV3GetSearch ()

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
    public class AddressBookSearchV3GetSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookSearchV3Api();

            try
            {
                // This call returns a searchDTO object for search in addressbook
                AddressBookSearchConcreteDTO result = apiInstance.AddressBookSearchV3GetSearch();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookSearchV3Api.AddressBookSearchV3GetSearch: " + e.Message );
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

<a name="addressbooksearchv3getselect"></a>
# **AddressBookSearchV3GetSelect**
> SelectDTO AddressBookSearchV3GetSelect ()

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
    public class AddressBookSearchV3GetSelectExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookSearchV3Api();

            try
            {
                // This call returns a selectDTO object for search in addressbook
                SelectDTO result = apiInstance.AddressBookSearchV3GetSelect();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookSearchV3Api.AddressBookSearchV3GetSelect: " + e.Message );
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

<a name="addressbooksearchv3postsearch"></a>
# **AddressBookSearchV3PostSearch**
> Object AddressBookSearchV3PostSearch (AddressBookSearchConcreteCriteriaDTO searchCriteria)

This call searches in address book with search and select DTO system.  This call could not be compatible with some programming language, in this case use the call api/AddressBookSearches

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookSearchV3PostSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookSearchV3Api();
            var searchCriteria = new AddressBookSearchConcreteCriteriaDTO(); // AddressBookSearchConcreteCriteriaDTO | 

            try
            {
                // This call searches in address book with search and select DTO system.  This call could not be compatible with some programming language, in this case use the call api/AddressBookSearches
                Object result = apiInstance.AddressBookSearchV3PostSearch(searchCriteria);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookSearchV3Api.AddressBookSearchV3PostSearch: " + e.Message );
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

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


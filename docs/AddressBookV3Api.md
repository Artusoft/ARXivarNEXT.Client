# ARXivarNEXT.Client.Api.AddressBookV3Api

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddressBookV3PostSearch**](AddressBookV3Api.md#addressbookv3postsearch) | **POST** /api/V3/AddressBook | This call searches address book items


<a name="addressbookv3postsearch"></a>
# **AddressBookV3PostSearch**
> Object AddressBookV3PostSearch (AddressBookSearchListCriteriaDTO searchDto)

This call searches address book items

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookV3PostSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookV3Api();
            var searchDto = new AddressBookSearchListCriteriaDTO(); // AddressBookSearchListCriteriaDTO | The fields of the search

            try
            {
                // This call searches address book items
                Object result = apiInstance.AddressBookV3PostSearch(searchDto);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookV3Api.AddressBookV3PostSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchDto** | [**AddressBookSearchListCriteriaDTO**](AddressBookSearchListCriteriaDTO.md)| The fields of the search | 

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


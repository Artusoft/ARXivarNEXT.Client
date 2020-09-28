# ARXivarNEXT.Client.Api.AddressBookCategoryApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddressBookCategoryDelete**](AddressBookCategoryApi.md#addressbookcategorydelete) | **DELETE** /api/AddressBookCategory/{categoryId} | This call delete an addressbook category by its Id
[**AddressBookCategoryGet**](AddressBookCategoryApi.md#addressbookcategoryget) | **GET** /api/AddressBookCategory | This call returns all categories of address book
[**AddressBookCategoryPost**](AddressBookCategoryApi.md#addressbookcategorypost) | **POST** /api/AddressBookCategory | This call adds an addressbook category
[**AddressBookCategoryPut**](AddressBookCategoryApi.md#addressbookcategoryput) | **PUT** /api/AddressBookCategory | This call rename an addressbook category
[**AddressBookCategoryPutDefault**](AddressBookCategoryApi.md#addressbookcategoryputdefault) | **PUT** /api/AddressBookCategory/{addressBookCategoryId}/Default | This call saves the user default address book category


<a name="addressbookcategorydelete"></a>
# **AddressBookCategoryDelete**
> void AddressBookCategoryDelete (int? categoryId)

This call delete an addressbook category by its Id

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookCategoryDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookCategoryApi();
            var categoryId = 56;  // int? | 

            try
            {
                // This call delete an addressbook category by its Id
                apiInstance.AddressBookCategoryDelete(categoryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookCategoryApi.AddressBookCategoryDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categoryId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbookcategoryget"></a>
# **AddressBookCategoryGet**
> List<AddressBookCategoryDTO> AddressBookCategoryGet ()

This call returns all categories of address book

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookCategoryGetExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookCategoryApi();

            try
            {
                // This call returns all categories of address book
                List&lt;AddressBookCategoryDTO&gt; result = apiInstance.AddressBookCategoryGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookCategoryApi.AddressBookCategoryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<AddressBookCategoryDTO>**](AddressBookCategoryDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbookcategorypost"></a>
# **AddressBookCategoryPost**
> void AddressBookCategoryPost (AddressBookCategoryDTO category)

This call adds an addressbook category

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookCategoryPostExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookCategoryApi();
            var category = new AddressBookCategoryDTO(); // AddressBookCategoryDTO | 

            try
            {
                // This call adds an addressbook category
                apiInstance.AddressBookCategoryPost(category);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookCategoryApi.AddressBookCategoryPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **category** | [**AddressBookCategoryDTO**](AddressBookCategoryDTO.md)|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbookcategoryput"></a>
# **AddressBookCategoryPut**
> void AddressBookCategoryPut (AddressBookCategoryDTO category)

This call rename an addressbook category

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookCategoryPutExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookCategoryApi();
            var category = new AddressBookCategoryDTO(); // AddressBookCategoryDTO | 

            try
            {
                // This call rename an addressbook category
                apiInstance.AddressBookCategoryPut(category);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookCategoryApi.AddressBookCategoryPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **category** | [**AddressBookCategoryDTO**](AddressBookCategoryDTO.md)|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbookcategoryputdefault"></a>
# **AddressBookCategoryPutDefault**
> void AddressBookCategoryPutDefault (int? addressBookCategoryId)

This call saves the user default address book category

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookCategoryPutDefaultExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookCategoryApi();
            var addressBookCategoryId = 56;  // int? | Identifier of the address book category to set as default

            try
            {
                // This call saves the user default address book category
                apiInstance.AddressBookCategoryPutDefault(addressBookCategoryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookCategoryApi.AddressBookCategoryPutDefault: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addressBookCategoryId** | **int?**| Identifier of the address book category to set as default | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


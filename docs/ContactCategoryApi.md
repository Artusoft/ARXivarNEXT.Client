# ARXivarNEXT.Client.Api.ContactCategoryApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ContactCategoryDeleteCategories**](ContactCategoryApi.md#contactcategorydeletecategories) | **DELETE** /api/ContactCategory/{contactCategoryId} | This call adds new contact category
[**ContactCategoryGetCategories**](ContactCategoryApi.md#contactcategorygetcategories) | **GET** /api/ContactCategory | This call returns all the contact categories available
[**ContactCategoryInsertCategories**](ContactCategoryApi.md#contactcategoryinsertcategories) | **POST** /api/ContactCategory | This call adds new contact category


<a name="contactcategorydeletecategories"></a>
# **ContactCategoryDeleteCategories**
> void ContactCategoryDeleteCategories (int? contactCategoryId)

This call adds new contact category

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ContactCategoryDeleteCategoriesExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContactCategoryApi();
            var contactCategoryId = 56;  // int? | 

            try
            {
                // This call adds new contact category
                apiInstance.ContactCategoryDeleteCategories(contactCategoryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactCategoryApi.ContactCategoryDeleteCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactCategoryId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactcategorygetcategories"></a>
# **ContactCategoryGetCategories**
> List<ContactCategoryDTO> ContactCategoryGetCategories ()

This call returns all the contact categories available

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ContactCategoryGetCategoriesExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContactCategoryApi();

            try
            {
                // This call returns all the contact categories available
                List&lt;ContactCategoryDTO&gt; result = apiInstance.ContactCategoryGetCategories();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactCategoryApi.ContactCategoryGetCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ContactCategoryDTO>**](ContactCategoryDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactcategoryinsertcategories"></a>
# **ContactCategoryInsertCategories**
> void ContactCategoryInsertCategories (ContactCategoryDTO contactCategoryDTO)

This call adds new contact category

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ContactCategoryInsertCategoriesExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContactCategoryApi();
            var contactCategoryDTO = new ContactCategoryDTO(); // ContactCategoryDTO | 

            try
            {
                // This call adds new contact category
                apiInstance.ContactCategoryInsertCategories(contactCategoryDTO);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactCategoryApi.ContactCategoryInsertCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactCategoryDTO** | [**ContactCategoryDTO**](ContactCategoryDTO.md)|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


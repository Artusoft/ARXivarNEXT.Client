# ARXivarNEXT.Client.Api.AssociationsApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssociationsDelete**](AssociationsApi.md#associationsdelete) | **DELETE** /api/Associations/{id} | This call deletes an existing association
[**AssociationsGet**](AssociationsApi.md#associationsget) | **GET** /api/Associations | This calls returns all ARXivar associations
[**AssociationsGetByDocNumber**](AssociationsApi.md#associationsgetbydocnumber) | **GET** /api/Associations/docnumber/{docnumber} | This call returns all associations by a document identifier
[**AssociationsGetById**](AssociationsApi.md#associationsgetbyid) | **POST** /api/Associations/items/{id} | This call returns the profile data contained in the association
[**AssociationsInsertNew**](AssociationsApi.md#associationsinsertnew) | **POST** /api/Associations/insert/new | This call adds profiles in a new association with auto generated name
[**AssociationsInsertWithId**](AssociationsApi.md#associationsinsertwithid) | **POST** /api/Associations/{id} | This call adds profiles in an association by association Identifier
[**AssociationsInsertWithName**](AssociationsApi.md#associationsinsertwithname) | **POST** /api/Associations/insertWithName | This call adds profiles to an existing association by association name
[**AssociationsRemove**](AssociationsApi.md#associationsremove) | **DELETE** /api/Associations/{id}/docnumber/{docnumber} | This call removes a profile from association
[**AssociationsRename**](AssociationsApi.md#associationsrename) | **PUT** /api/Associations/rename/{id} | This call renames an existing association


<a name="associationsdelete"></a>
# **AssociationsDelete**
> void AssociationsDelete (int? id)

This call deletes an existing association

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AssociationsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssociationsApi();
            var id = 56;  // int? | Identifier of the association to delete

            try
            {
                // This call deletes an existing association
                apiInstance.AssociationsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssociationsApi.AssociationsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Identifier of the association to delete | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="associationsget"></a>
# **AssociationsGet**
> List<AssociationDTO> AssociationsGet ()

This calls returns all ARXivar associations

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AssociationsGetExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssociationsApi();

            try
            {
                // This calls returns all ARXivar associations
                List&lt;AssociationDTO&gt; result = apiInstance.AssociationsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssociationsApi.AssociationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<AssociationDTO>**](AssociationDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="associationsgetbydocnumber"></a>
# **AssociationsGetByDocNumber**
> List<AssociationDTO> AssociationsGetByDocNumber (int? docnumber)

This call returns all associations by a document identifier

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AssociationsGetByDocNumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssociationsApi();
            var docnumber = 56;  // int? | Document identifier

            try
            {
                // This call returns all associations by a document identifier
                List&lt;AssociationDTO&gt; result = apiInstance.AssociationsGetByDocNumber(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssociationsApi.AssociationsGetByDocNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| Document identifier | 

### Return type

[**List<AssociationDTO>**](AssociationDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="associationsgetbyid"></a>
# **AssociationsGetById**
> List<RowSearchResult> AssociationsGetById (int? id, SelectDTO select)

This call returns the profile data contained in the association

This method is deprecated. Use api/v2/Associations/items/{id}

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AssociationsGetByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssociationsApi();
            var id = 56;  // int? | Identifier of the association
            var select = new SelectDTO(); // SelectDTO | Columns settings for the result

            try
            {
                // This call returns the profile data contained in the association
                List&lt;RowSearchResult&gt; result = apiInstance.AssociationsGetById(id, select);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssociationsApi.AssociationsGetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Identifier of the association | 
 **select** | [**SelectDTO**](SelectDTO.md)| Columns settings for the result | 

### Return type

[**List<RowSearchResult>**](RowSearchResult.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="associationsinsertnew"></a>
# **AssociationsInsertNew**
> List<AssociationDTO> AssociationsInsertNew (List<int?> docnumbers)

This call adds profiles in a new association with auto generated name

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AssociationsInsertNewExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssociationsApi();
            var docnumbers = ;  // List<int?> | Identifiers of the profiles to add

            try
            {
                // This call adds profiles in a new association with auto generated name
                List&lt;AssociationDTO&gt; result = apiInstance.AssociationsInsertNew(docnumbers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssociationsApi.AssociationsInsertNew: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumbers** | **List&lt;int?&gt;**| Identifiers of the profiles to add | 

### Return type

[**List<AssociationDTO>**](AssociationDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="associationsinsertwithid"></a>
# **AssociationsInsertWithId**
> List<AssociationDTO> AssociationsInsertWithId (int? id, List<int?> docnumbers)

This call adds profiles in an association by association Identifier

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AssociationsInsertWithIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssociationsApi();
            var id = 56;  // int? | Identifier of the association
            var docnumbers = ;  // List<int?> | Identifiers of the profiles to add

            try
            {
                // This call adds profiles in an association by association Identifier
                List&lt;AssociationDTO&gt; result = apiInstance.AssociationsInsertWithId(id, docnumbers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssociationsApi.AssociationsInsertWithId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Identifier of the association | 
 **docnumbers** | **List&lt;int?&gt;**| Identifiers of the profiles to add | 

### Return type

[**List<AssociationDTO>**](AssociationDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="associationsinsertwithname"></a>
# **AssociationsInsertWithName**
> List<AssociationDTO> AssociationsInsertWithName (Object bodyData)

This call adds profiles to an existing association by association name

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AssociationsInsertWithNameExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssociationsApi();
            var bodyData = ;  // Object | JSON object with 2 properties: docnumbers (array of ints) and associationName (new association name)

            try
            {
                // This call adds profiles to an existing association by association name
                List&lt;AssociationDTO&gt; result = apiInstance.AssociationsInsertWithName(bodyData);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssociationsApi.AssociationsInsertWithName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bodyData** | **Object**| JSON object with 2 properties: docnumbers (array of ints) and associationName (new association name) | 

### Return type

[**List<AssociationDTO>**](AssociationDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="associationsremove"></a>
# **AssociationsRemove**
> void AssociationsRemove (int? id, int? docnumber)

This call removes a profile from association

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AssociationsRemoveExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssociationsApi();
            var id = 56;  // int? | Identifier of the association
            var docnumber = 56;  // int? | Identifier of the profile to remove

            try
            {
                // This call removes a profile from association
                apiInstance.AssociationsRemove(id, docnumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssociationsApi.AssociationsRemove: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Identifier of the association | 
 **docnumber** | **int?**| Identifier of the profile to remove | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="associationsrename"></a>
# **AssociationsRename**
> void AssociationsRename (int? id, Object bodyData)

This call renames an existing association

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AssociationsRenameExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssociationsApi();
            var id = 56;  // int? | Identifier of the association to rename
            var bodyData = ;  // Object | JSON object with 1 property: associationName (new association name)

            try
            {
                // This call renames an existing association
                apiInstance.AssociationsRename(id, bodyData);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssociationsApi.AssociationsRename: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Identifier of the association to rename | 
 **bodyData** | **Object**| JSON object with 1 property: associationName (new association name) | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# ARXivarNEXT.Client.Api.AssociationsV2Api

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssociationsV2Delete**](AssociationsV2Api.md#associationsv2delete) | **DELETE** /api/v2/Associations/{id} | This call deletes an existing association
[**AssociationsV2Get**](AssociationsV2Api.md#associationsv2get) | **GET** /api/v2/Associations | This calls returns all ARXivar associations
[**AssociationsV2GetByDocNumber**](AssociationsV2Api.md#associationsv2getbydocnumber) | **GET** /api/v2/Associations/docnumber/{docnumber} | This call returns all associations by a document identifier
[**AssociationsV2GetById**](AssociationsV2Api.md#associationsv2getbyid) | **POST** /api/v2/Associations/items/{id} | This call returns the profile data contained in the association  This call could not be compatible with some programming language, in this case use the call api/Associations/items/{id}
[**AssociationsV2InsertNew**](AssociationsV2Api.md#associationsv2insertnew) | **POST** /api/v2/Associations/insert/new | This call adds profiles in a new association with auto generated name
[**AssociationsV2InsertWithId**](AssociationsV2Api.md#associationsv2insertwithid) | **POST** /api/v2/Associations/{id} | This call adds profiles in an association by association Identifier
[**AssociationsV2InsertWithName**](AssociationsV2Api.md#associationsv2insertwithname) | **POST** /api/v2/Associations/insertWithName | This call adds profiles to an existing association by association name
[**AssociationsV2Remove**](AssociationsV2Api.md#associationsv2remove) | **DELETE** /api/v2/Associations/{id}/docnumber/{docnumber} | This call removes a profile from association
[**AssociationsV2Rename**](AssociationsV2Api.md#associationsv2rename) | **PUT** /api/v2/Associations/rename/{id} | This call renames an existing association


<a name="associationsv2delete"></a>
# **AssociationsV2Delete**
> void AssociationsV2Delete (int? id)

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
    public class AssociationsV2DeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssociationsV2Api();
            var id = 56;  // int? | Identifier of the association to delete

            try
            {
                // This call deletes an existing association
                apiInstance.AssociationsV2Delete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssociationsV2Api.AssociationsV2Delete: " + e.Message );
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

<a name="associationsv2get"></a>
# **AssociationsV2Get**
> List<AssociationDTO> AssociationsV2Get ()

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
    public class AssociationsV2GetExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssociationsV2Api();

            try
            {
                // This calls returns all ARXivar associations
                List&lt;AssociationDTO&gt; result = apiInstance.AssociationsV2Get();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssociationsV2Api.AssociationsV2Get: " + e.Message );
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

<a name="associationsv2getbydocnumber"></a>
# **AssociationsV2GetByDocNumber**
> List<AssociationDTO> AssociationsV2GetByDocNumber (int? docnumber)

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
    public class AssociationsV2GetByDocNumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssociationsV2Api();
            var docnumber = 56;  // int? | Document identifier

            try
            {
                // This call returns all associations by a document identifier
                List&lt;AssociationDTO&gt; result = apiInstance.AssociationsV2GetByDocNumber(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssociationsV2Api.AssociationsV2GetByDocNumber: " + e.Message );
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

<a name="associationsv2getbyid"></a>
# **AssociationsV2GetById**
> Object AssociationsV2GetById (int? id, SelectDTO select)

This call returns the profile data contained in the association  This call could not be compatible with some programming language, in this case use the call api/Associations/items/{id}

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AssociationsV2GetByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssociationsV2Api();
            var id = 56;  // int? | Identifier of the association
            var select = new SelectDTO(); // SelectDTO | Columns settings for the result

            try
            {
                // This call returns the profile data contained in the association  This call could not be compatible with some programming language, in this case use the call api/Associations/items/{id}
                Object result = apiInstance.AssociationsV2GetById(id, select);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssociationsV2Api.AssociationsV2GetById: " + e.Message );
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

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="associationsv2insertnew"></a>
# **AssociationsV2InsertNew**
> List<AssociationDTO> AssociationsV2InsertNew (List<int?> docnumbers)

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
    public class AssociationsV2InsertNewExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssociationsV2Api();
            var docnumbers = ;  // List<int?> | Identifiers of the profiles to add

            try
            {
                // This call adds profiles in a new association with auto generated name
                List&lt;AssociationDTO&gt; result = apiInstance.AssociationsV2InsertNew(docnumbers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssociationsV2Api.AssociationsV2InsertNew: " + e.Message );
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

<a name="associationsv2insertwithid"></a>
# **AssociationsV2InsertWithId**
> List<AssociationDTO> AssociationsV2InsertWithId (int? id, List<int?> docnumbers)

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
    public class AssociationsV2InsertWithIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssociationsV2Api();
            var id = 56;  // int? | Identifier of the association
            var docnumbers = ;  // List<int?> | Identifiers of the profiles to add

            try
            {
                // This call adds profiles in an association by association Identifier
                List&lt;AssociationDTO&gt; result = apiInstance.AssociationsV2InsertWithId(id, docnumbers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssociationsV2Api.AssociationsV2InsertWithId: " + e.Message );
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

<a name="associationsv2insertwithname"></a>
# **AssociationsV2InsertWithName**
> List<AssociationDTO> AssociationsV2InsertWithName (Object bodyData)

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
    public class AssociationsV2InsertWithNameExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssociationsV2Api();
            var bodyData = ;  // Object | JSON object with 2 properties: docnumbers (array of ints) and associationName (new association name)

            try
            {
                // This call adds profiles to an existing association by association name
                List&lt;AssociationDTO&gt; result = apiInstance.AssociationsV2InsertWithName(bodyData);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssociationsV2Api.AssociationsV2InsertWithName: " + e.Message );
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

<a name="associationsv2remove"></a>
# **AssociationsV2Remove**
> void AssociationsV2Remove (int? id, int? docnumber)

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
    public class AssociationsV2RemoveExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssociationsV2Api();
            var id = 56;  // int? | Identifier of the association
            var docnumber = 56;  // int? | Identifier of the profile to remove

            try
            {
                // This call removes a profile from association
                apiInstance.AssociationsV2Remove(id, docnumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssociationsV2Api.AssociationsV2Remove: " + e.Message );
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

<a name="associationsv2rename"></a>
# **AssociationsV2Rename**
> void AssociationsV2Rename (int? id, Object bodyData)

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
    public class AssociationsV2RenameExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssociationsV2Api();
            var id = 56;  // int? | Identifier of the association to rename
            var bodyData = ;  // Object | JSON object with 1 property: associationName (new association name)

            try
            {
                // This call renames an existing association
                apiInstance.AssociationsV2Rename(id, bodyData);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssociationsV2Api.AssociationsV2Rename: " + e.Message );
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


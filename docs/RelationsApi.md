# ARXivarNEXT.Client.Api.RelationsApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RelationsDeleteByDocNumberFromDocNumberTo**](RelationsApi.md#relationsdeletebydocnumberfromdocnumberto) | **DELETE** /api/Relations/{fromDocnumber}/{toDocnumber} | This call deletes a criteria by from and to profiles
[**RelationsGetById**](RelationsApi.md#relationsgetbyid) | **POST** /api/Relations | This call returns a relation by docnumber relation by exploring method
[**RelationsInsertNewRelation**](RelationsApi.md#relationsinsertnewrelation) | **POST** /api/Relations/Insert | This call adds a new Relation
[**RelationsRecalculateRelation**](RelationsApi.md#relationsrecalculaterelation) | **POST** /api/Relations/{docnumber} | This call recalculate the relations of a document


<a name="relationsdeletebydocnumberfromdocnumberto"></a>
# **RelationsDeleteByDocNumberFromDocNumberTo**
> void RelationsDeleteByDocNumberFromDocNumberTo (int? fromDocnumber, int? toDocnumber)

This call deletes a criteria by from and to profiles

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class RelationsDeleteByDocNumberFromDocNumberToExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RelationsApi();
            var fromDocnumber = 56;  // int? | Document identifier of the \"from\" profile
            var toDocnumber = 56;  // int? | Document identifier of the \"to\" profile

            try
            {
                // This call deletes a criteria by from and to profiles
                apiInstance.RelationsDeleteByDocNumberFromDocNumberTo(fromDocnumber, toDocnumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RelationsApi.RelationsDeleteByDocNumberFromDocNumberTo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fromDocnumber** | **int?**| Document identifier of the \&quot;from\&quot; profile | 
 **toDocnumber** | **int?**| Document identifier of the \&quot;to\&quot; profile | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="relationsgetbyid"></a>
# **RelationsGetById**
> RelationExploredDTO RelationsGetById (RelationCriteriaDTO criteria)

This call returns a relation by docnumber relation by exploring method

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class RelationsGetByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RelationsApi();
            var criteria = new RelationCriteriaDTO(); // RelationCriteriaDTO | Relation search criteria

            try
            {
                // This call returns a relation by docnumber relation by exploring method
                RelationExploredDTO result = apiInstance.RelationsGetById(criteria);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RelationsApi.RelationsGetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | [**RelationCriteriaDTO**](RelationCriteriaDTO.md)| Relation search criteria | 

### Return type

[**RelationExploredDTO**](RelationExploredDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="relationsinsertnewrelation"></a>
# **RelationsInsertNewRelation**
> void RelationsInsertNewRelation (RelationInsertDTO relationInsertDto)

This call adds a new Relation

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class RelationsInsertNewRelationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RelationsApi();
            var relationInsertDto = new RelationInsertDTO(); // RelationInsertDTO | Relation to insert

            try
            {
                // This call adds a new Relation
                apiInstance.RelationsInsertNewRelation(relationInsertDto);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RelationsApi.RelationsInsertNewRelation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **relationInsertDto** | [**RelationInsertDTO**](RelationInsertDTO.md)| Relation to insert | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="relationsrecalculaterelation"></a>
# **RelationsRecalculateRelation**
> void RelationsRecalculateRelation (int? docnumber)

This call recalculate the relations of a document

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class RelationsRecalculateRelationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RelationsApi();
            var docnumber = 56;  // int? | Document identifier

            try
            {
                // This call recalculate the relations of a document
                apiInstance.RelationsRecalculateRelation(docnumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RelationsApi.RelationsRecalculateRelation: " + e.Message );
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

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


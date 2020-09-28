# ARXivarNEXT.Client.Api.SearchesApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SearchesDelete**](SearchesApi.md#searchesdelete) | **DELETE** /api/Searches | This call delete the default search for the user
[**SearchesGet**](SearchesApi.md#searchesget) | **GET** /api/Searches | This call returns a default search according to the Arxivar system settings
[**SearchesGetAdditionalByClasse**](SearchesApi.md#searchesgetadditionalbyclasse) | **GET** /api/Searches/Additional/{tipoUno}/{tipoDue}/{tipoTre} | This call returns the additional fields for search by the given document class and business unit
[**SearchesGetAdditionalByClasseOld**](SearchesApi.md#searchesgetadditionalbyclasseold) | **GET** /api/Searches/Additional/{tipoUno}/{tipoDue}/{tipoTre}/{aoo} | This call returns the additional fields for search by the given document class and business unit
[**SearchesGetFiltersForSearch**](SearchesApi.md#searchesgetfiltersforsearch) | **POST** /api/Searches/Filters | This call returns the list of filter avaible for a specific additional field
[**SearchesGetFormulaForSearch**](SearchesApi.md#searchesgetformulaforsearch) | **POST** /api/Searches/Formula | this method return the result of a formula given the array of fields of profile and their value
[**SearchesGetLastSearch**](SearchesApi.md#searchesgetlastsearch) | **GET** /api/Searches/lastsearch | This call returns a default search according to the Arxivar system settings
[**SearchesGetSearchForClasseBox**](SearchesApi.md#searchesgetsearchforclassebox) | **POST** /api/Searches/byclassadditionalfield/{additionalFieldName}/Search | This call returns a complete search object for search a profile for a additional field
[**SearchesGetSelect**](SearchesApi.md#searchesgetselect) | **GET** /api/Searches/Select | This call returns a default select according to the Arxivar system settings
[**SearchesGetSelect_0**](SearchesApi.md#searchesgetselect_0) | **GET** /api/Searches/Select/{documentType} | This call returns a new select dto by document type
[**SearchesGetSelect_1**](SearchesApi.md#searchesgetselect_1) | **GET** /api/Searches/Select/{documentType}/{tipo2}/{tipo3} | This call returns a new select dto by document type levels
[**SearchesGetValuesForSearch**](SearchesApi.md#searchesgetvaluesforsearch) | **POST** /api/Searches/Values | This method returns the possible values ​​for an external data source given the additional field code and the value of all other fields in profile
[**SearchesLastDocuments**](SearchesApi.md#searcheslastdocuments) | **POST** /api/Searches/lastdocuments/{maxRows} | This call searches documents
[**SearchesPostSearch**](SearchesApi.md#searchespostsearch) | **POST** /api/Searches | This call searches documents
[**SearchesPostSelect**](SearchesApi.md#searchespostselect) | **POST** /api/Searches/Select | This call saves the default select for the user
[**SearchesResetSelect**](SearchesApi.md#searchesresetselect) | **POST** /api/Searches/Reset | This call deletes a possible custom select for the user
[**SearchesSetDefaultSearch**](SearchesApi.md#searchessetdefaultsearch) | **POST** /api/Searches/defaultsearch | This call saves the default search for the user
[**SearchesSetLastSearch**](SearchesApi.md#searchessetlastsearch) | **POST** /api/Searches/lastsearch | This call saves the last search for the user


<a name="searchesdelete"></a>
# **SearchesDelete**
> void SearchesDelete ()

This call delete the default search for the user

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SearchesDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesApi();

            try
            {
                // This call delete the default search for the user
                apiInstance.SearchesDelete();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesget"></a>
# **SearchesGet**
> SearchDTO SearchesGet ()

This call returns a default search according to the Arxivar system settings

This method is deprecated. Use /api/v3/Searches

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SearchesGetExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesApi();

            try
            {
                // This call returns a default search according to the Arxivar system settings
                SearchDTO result = apiInstance.SearchesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SearchDTO**](SearchDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesgetadditionalbyclasse"></a>
# **SearchesGetAdditionalByClasse**
> List<FieldBaseForSearchDTO> SearchesGetAdditionalByClasse (int? tipoUno, int? tipoDue, int? tipoTre, string aoo = null)

This call returns the additional fields for search by the given document class and business unit

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SearchesGetAdditionalByClasseExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesApi();
            var tipoUno = 56;  // int? | Document type identifier of first level
            var tipoDue = 56;  // int? | Document type identifier of second level
            var tipoTre = 56;  // int? | Document type identifier of third level
            var aoo = aoo_example;  // string | Business unit code (optional) 

            try
            {
                // This call returns the additional fields for search by the given document class and business unit
                List&lt;FieldBaseForSearchDTO&gt; result = apiInstance.SearchesGetAdditionalByClasse(tipoUno, tipoDue, tipoTre, aoo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesGetAdditionalByClasse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tipoUno** | **int?**| Document type identifier of first level | 
 **tipoDue** | **int?**| Document type identifier of second level | 
 **tipoTre** | **int?**| Document type identifier of third level | 
 **aoo** | **string**| Business unit code | [optional] 

### Return type

[**List<FieldBaseForSearchDTO>**](FieldBaseForSearchDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesgetadditionalbyclasseold"></a>
# **SearchesGetAdditionalByClasseOld**
> List<FieldBaseForSearchDTO> SearchesGetAdditionalByClasseOld (int? tipoUno, int? tipoDue, int? tipoTre, string aoo)

This call returns the additional fields for search by the given document class and business unit

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SearchesGetAdditionalByClasseOldExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesApi();
            var tipoUno = 56;  // int? | Document type identifier of first level
            var tipoDue = 56;  // int? | Document type identifier of second level
            var tipoTre = 56;  // int? | Document type identifier of third level
            var aoo = aoo_example;  // string | Business unit code

            try
            {
                // This call returns the additional fields for search by the given document class and business unit
                List&lt;FieldBaseForSearchDTO&gt; result = apiInstance.SearchesGetAdditionalByClasseOld(tipoUno, tipoDue, tipoTre, aoo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesGetAdditionalByClasseOld: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tipoUno** | **int?**| Document type identifier of first level | 
 **tipoDue** | **int?**| Document type identifier of second level | 
 **tipoTre** | **int?**| Document type identifier of third level | 
 **aoo** | **string**| Business unit code | 

### Return type

[**List<FieldBaseForSearchDTO>**](FieldBaseForSearchDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesgetfiltersforsearch"></a>
# **SearchesGetFiltersForSearch**
> FieldFilterDTO SearchesGetFiltersForSearch (FieldValuesSearchCriteriaDto fieldcriteria = null)

This call returns the list of filter avaible for a specific additional field

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SearchesGetFiltersForSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesApi();
            var fieldcriteria = new FieldValuesSearchCriteriaDto(); // FieldValuesSearchCriteriaDto |  (optional) 

            try
            {
                // This call returns the list of filter avaible for a specific additional field
                FieldFilterDTO result = apiInstance.SearchesGetFiltersForSearch(fieldcriteria);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesGetFiltersForSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fieldcriteria** | [**FieldValuesSearchCriteriaDto**](FieldValuesSearchCriteriaDto.md)|  | [optional] 

### Return type

[**FieldFilterDTO**](FieldFilterDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesgetformulaforsearch"></a>
# **SearchesGetFormulaForSearch**
> string SearchesGetFormulaForSearch (FieldFormulaCalculateCriteriaDto fieldcriteria = null)

this method return the result of a formula given the array of fields of profile and their value

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SearchesGetFormulaForSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesApi();
            var fieldcriteria = new FieldFormulaCalculateCriteriaDto(); // FieldFormulaCalculateCriteriaDto |  (optional) 

            try
            {
                // this method return the result of a formula given the array of fields of profile and their value
                string result = apiInstance.SearchesGetFormulaForSearch(fieldcriteria);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesGetFormulaForSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fieldcriteria** | [**FieldFormulaCalculateCriteriaDto**](FieldFormulaCalculateCriteriaDto.md)|  | [optional] 

### Return type

**string**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesgetlastsearch"></a>
# **SearchesGetLastSearch**
> SearchDTO SearchesGetLastSearch ()

This call returns a default search according to the Arxivar system settings

This method is deprecated. Use /api/v3/Searches/lastsearch

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SearchesGetLastSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesApi();

            try
            {
                // This call returns a default search according to the Arxivar system settings
                SearchDTO result = apiInstance.SearchesGetLastSearch();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesGetLastSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SearchDTO**](SearchDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesgetsearchforclassebox"></a>
# **SearchesGetSearchForClasseBox**
> SearchDTO SearchesGetSearchForClasseBox (string additionalFieldName, ProfileDTO profile = null)

This call returns a complete search object for search a profile for a additional field

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SearchesGetSearchForClasseBoxExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesApi();
            var additionalFieldName = additionalFieldName_example;  // string | Additional field name
            var profile = new ProfileDTO(); // ProfileDTO |  (optional) 

            try
            {
                // This call returns a complete search object for search a profile for a additional field
                SearchDTO result = apiInstance.SearchesGetSearchForClasseBox(additionalFieldName, profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesGetSearchForClasseBox: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **additionalFieldName** | **string**| Additional field name | 
 **profile** | [**ProfileDTO**](ProfileDTO.md)|  | [optional] 

### Return type

[**SearchDTO**](SearchDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesgetselect"></a>
# **SearchesGetSelect**
> SelectDTO SearchesGetSelect ()

This call returns a default select according to the Arxivar system settings

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SearchesGetSelectExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesApi();

            try
            {
                // This call returns a default select according to the Arxivar system settings
                SelectDTO result = apiInstance.SearchesGetSelect();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesGetSelect: " + e.Message );
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

<a name="searchesgetselect_0"></a>
# **SearchesGetSelect_0**
> SelectDTO SearchesGetSelect_0 (int? documentType)

This call returns a new select dto by document type

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SearchesGetSelect_0Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesApi();
            var documentType = 56;  // int? | Document Type Identifier

            try
            {
                // This call returns a new select dto by document type
                SelectDTO result = apiInstance.SearchesGetSelect_0(documentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesGetSelect_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentType** | **int?**| Document Type Identifier | 

### Return type

[**SelectDTO**](SelectDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesgetselect_1"></a>
# **SearchesGetSelect_1**
> SelectDTO SearchesGetSelect_1 (int? documentType, int? tipo2, int? tipo3)

This call returns a new select dto by document type levels

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SearchesGetSelect_1Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesApi();
            var documentType = 56;  // int? | Document type identifier of first level
            var tipo2 = 56;  // int? | Document type identifier of second level
            var tipo3 = 56;  // int? | Document type identifier of third level

            try
            {
                // This call returns a new select dto by document type levels
                SelectDTO result = apiInstance.SearchesGetSelect_1(documentType, tipo2, tipo3);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesGetSelect_1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentType** | **int?**| Document type identifier of first level | 
 **tipo2** | **int?**| Document type identifier of second level | 
 **tipo3** | **int?**| Document type identifier of third level | 

### Return type

[**SelectDTO**](SelectDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesgetvaluesforsearch"></a>
# **SearchesGetValuesForSearch**
> FieldValuesDTO SearchesGetValuesForSearch (FieldValuesSearchCriteriaDto fieldcriteria = null)

This method returns the possible values ​​for an external data source given the additional field code and the value of all other fields in profile

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SearchesGetValuesForSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesApi();
            var fieldcriteria = new FieldValuesSearchCriteriaDto(); // FieldValuesSearchCriteriaDto |  (optional) 

            try
            {
                // This method returns the possible values ​​for an external data source given the additional field code and the value of all other fields in profile
                FieldValuesDTO result = apiInstance.SearchesGetValuesForSearch(fieldcriteria);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesGetValuesForSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fieldcriteria** | [**FieldValuesSearchCriteriaDto**](FieldValuesSearchCriteriaDto.md)|  | [optional] 

### Return type

[**FieldValuesDTO**](FieldValuesDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searcheslastdocuments"></a>
# **SearchesLastDocuments**
> List<RowSearchResult> SearchesLastDocuments (int? maxRows, SelectDTO selectDto)

This call searches documents

This method is deprecated. Use api/v3/Searches/lastdocuments/{maxRows}

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SearchesLastDocumentsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesApi();
            var maxRows = 56;  // int? | Maximun items to search
            var selectDto = new SelectDTO(); // SelectDTO | Object representing the select

            try
            {
                // This call searches documents
                List&lt;RowSearchResult&gt; result = apiInstance.SearchesLastDocuments(maxRows, selectDto);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesLastDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **maxRows** | **int?**| Maximun items to search | 
 **selectDto** | [**SelectDTO**](SelectDTO.md)| Object representing the select | 

### Return type

[**List<RowSearchResult>**](RowSearchResult.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchespostsearch"></a>
# **SearchesPostSearch**
> List<RowSearchResult> SearchesPostSearch (SearchCriteriaDto searchwebapidto = null)

This call searches documents

This method is deprecated. Use /api/v3/Searches

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SearchesPostSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesApi();
            var searchwebapidto = new SearchCriteriaDto(); // SearchCriteriaDto |  (optional) 

            try
            {
                // This call searches documents
                List&lt;RowSearchResult&gt; result = apiInstance.SearchesPostSearch(searchwebapidto);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesPostSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchwebapidto** | [**SearchCriteriaDto**](SearchCriteriaDto.md)|  | [optional] 

### Return type

[**List<RowSearchResult>**](RowSearchResult.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchespostselect"></a>
# **SearchesPostSelect**
> void SearchesPostSelect (SelectDTO selectDto)

This call saves the default select for the user

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SearchesPostSelectExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesApi();
            var selectDto = new SelectDTO(); // SelectDTO | Object representing the select

            try
            {
                // This call saves the default select for the user
                apiInstance.SearchesPostSelect(selectDto);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesPostSelect: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **selectDto** | [**SelectDTO**](SelectDTO.md)| Object representing the select | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesresetselect"></a>
# **SearchesResetSelect**
> void SearchesResetSelect ()

This call deletes a possible custom select for the user

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SearchesResetSelectExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesApi();

            try
            {
                // This call deletes a possible custom select for the user
                apiInstance.SearchesResetSelect();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesResetSelect: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchessetdefaultsearch"></a>
# **SearchesSetDefaultSearch**
> void SearchesSetDefaultSearch (SearchCriteriaDto searchwebapidto = null)

This call saves the default search for the user

This method is deprecated. Use /api/v3/Searches/defaultsearch

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SearchesSetDefaultSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesApi();
            var searchwebapidto = new SearchCriteriaDto(); // SearchCriteriaDto |  (optional) 

            try
            {
                // This call saves the default search for the user
                apiInstance.SearchesSetDefaultSearch(searchwebapidto);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesSetDefaultSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchwebapidto** | [**SearchCriteriaDto**](SearchCriteriaDto.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchessetlastsearch"></a>
# **SearchesSetLastSearch**
> void SearchesSetLastSearch (SearchCriteriaDto searchwebapidto = null)

This call saves the last search for the user

This method is deprecated. Use /api/v3/Searches/lastsearch

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SearchesSetLastSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesApi();
            var searchwebapidto = new SearchCriteriaDto(); // SearchCriteriaDto |  (optional) 

            try
            {
                // This call saves the last search for the user
                apiInstance.SearchesSetLastSearch(searchwebapidto);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesApi.SearchesSetLastSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchwebapidto** | [**SearchCriteriaDto**](SearchCriteriaDto.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


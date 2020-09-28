# ARXivarNEXT.Client.Api.SearchesV2Api

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SearchesV2Delete**](SearchesV2Api.md#searchesv2delete) | **DELETE** /api/v2/searches | This call delete the default search for the user
[**SearchesV2Get**](SearchesV2Api.md#searchesv2get) | **GET** /api/v2/searches | This call returns a default search according to the Arxivar system settings
[**SearchesV2GetAdditionalByClasse**](SearchesV2Api.md#searchesv2getadditionalbyclasse) | **GET** /api/v2/searches/Additional/{tipoUno}/{tipoDue}/{tipoTre} | This call returns the additional fields for search by the given document class and business unit
[**SearchesV2GetEmpty**](SearchesV2Api.md#searchesv2getempty) | **GET** /api/v2/searches/empty | This call returns an empty search according to the Arxivar system settings
[**SearchesV2GetFiltersForSearch**](SearchesV2Api.md#searchesv2getfiltersforsearch) | **POST** /api/v2/searches/Filters | This call returns the list of filter avaible for a specific additional field
[**SearchesV2GetFormulaForSearch**](SearchesV2Api.md#searchesv2getformulaforsearch) | **POST** /api/v2/searches/Formula | this method return the result of a formula given the array of fields of profile and their value
[**SearchesV2GetLastSearch**](SearchesV2Api.md#searchesv2getlastsearch) | **GET** /api/v2/searches/lastsearch | This call returns a default search according to the Arxivar system settings
[**SearchesV2GetSearchForClasseBox**](SearchesV2Api.md#searchesv2getsearchforclassebox) | **POST** /api/v2/searches/byclassadditionalfield/{additionalFieldName}/Search | This call returns a complete search object for search a profile for a additional field
[**SearchesV2GetSelect**](SearchesV2Api.md#searchesv2getselect) | **GET** /api/v2/searches/Select | This call returns a default select according to the Arxivar system settings
[**SearchesV2GetSelect_0**](SearchesV2Api.md#searchesv2getselect_0) | **GET** /api/v2/searches/Select/{documentType} | This call returns a new select dto by document type
[**SearchesV2GetSelect_1**](SearchesV2Api.md#searchesv2getselect_1) | **GET** /api/v2/searches/Select/{documentType}/{tipo2}/{tipo3} | This call returns a new select dto by document type levels
[**SearchesV2GetValuesForSearch**](SearchesV2Api.md#searchesv2getvaluesforsearch) | **POST** /api/v2/searches/Values | This method returns the possible values ​​for an external data source given the additional field code and the value of all other fields in profile
[**SearchesV2LastDocuments**](SearchesV2Api.md#searchesv2lastdocuments) | **POST** /api/v2/searches/lastdocuments/{maxRows} | This call searches documents
[**SearchesV2PostSearchMultiple**](SearchesV2Api.md#searchesv2postsearchmultiple) | **POST** /api/v2/searches | This call searches documents
[**SearchesV2PostSelect**](SearchesV2Api.md#searchesv2postselect) | **POST** /api/v2/searches/Select | This call saves the default select for the user
[**SearchesV2ResetSelect**](SearchesV2Api.md#searchesv2resetselect) | **POST** /api/v2/searches/Reset | This call deletes a possible custom select for the user
[**SearchesV2SetDefaultSearch**](SearchesV2Api.md#searchesv2setdefaultsearch) | **POST** /api/v2/searches/defaultsearch | This call saves the default search for the user
[**SearchesV2SetLastSearch**](SearchesV2Api.md#searchesv2setlastsearch) | **POST** /api/v2/searches/lastsearch | This call saves the last search for the user


<a name="searchesv2delete"></a>
# **SearchesV2Delete**
> void SearchesV2Delete ()

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
    public class SearchesV2DeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV2Api();

            try
            {
                // This call delete the default search for the user
                apiInstance.SearchesV2Delete();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV2Api.SearchesV2Delete: " + e.Message );
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

<a name="searchesv2get"></a>
# **SearchesV2Get**
> List<SearchDTO> SearchesV2Get ()

This call returns a default search according to the Arxivar system settings

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SearchesV2GetExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV2Api();

            try
            {
                // This call returns a default search according to the Arxivar system settings
                List&lt;SearchDTO&gt; result = apiInstance.SearchesV2Get();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV2Api.SearchesV2Get: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<SearchDTO>**](SearchDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesv2getadditionalbyclasse"></a>
# **SearchesV2GetAdditionalByClasse**
> List<FieldBaseForSearchDTO> SearchesV2GetAdditionalByClasse (int? tipoUno, int? tipoDue, int? tipoTre, string aoo = null)

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
    public class SearchesV2GetAdditionalByClasseExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV2Api();
            var tipoUno = 56;  // int? | Document type identifier of first level
            var tipoDue = 56;  // int? | Document type identifier of second level
            var tipoTre = 56;  // int? | Document type identifier of third level
            var aoo = aoo_example;  // string | Business unit code (optional) 

            try
            {
                // This call returns the additional fields for search by the given document class and business unit
                List&lt;FieldBaseForSearchDTO&gt; result = apiInstance.SearchesV2GetAdditionalByClasse(tipoUno, tipoDue, tipoTre, aoo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV2Api.SearchesV2GetAdditionalByClasse: " + e.Message );
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

<a name="searchesv2getempty"></a>
# **SearchesV2GetEmpty**
> SearchDTO SearchesV2GetEmpty ()

This call returns an empty search according to the Arxivar system settings

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SearchesV2GetEmptyExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV2Api();

            try
            {
                // This call returns an empty search according to the Arxivar system settings
                SearchDTO result = apiInstance.SearchesV2GetEmpty();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV2Api.SearchesV2GetEmpty: " + e.Message );
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

<a name="searchesv2getfiltersforsearch"></a>
# **SearchesV2GetFiltersForSearch**
> FieldFilterDTO SearchesV2GetFiltersForSearch (FieldValuesSearchCriteriaDto fieldcriteria = null)

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
    public class SearchesV2GetFiltersForSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV2Api();
            var fieldcriteria = new FieldValuesSearchCriteriaDto(); // FieldValuesSearchCriteriaDto |  (optional) 

            try
            {
                // This call returns the list of filter avaible for a specific additional field
                FieldFilterDTO result = apiInstance.SearchesV2GetFiltersForSearch(fieldcriteria);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV2Api.SearchesV2GetFiltersForSearch: " + e.Message );
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

<a name="searchesv2getformulaforsearch"></a>
# **SearchesV2GetFormulaForSearch**
> string SearchesV2GetFormulaForSearch (FieldFormulaCalculateCriteriaDto fieldcriteria = null)

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
    public class SearchesV2GetFormulaForSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV2Api();
            var fieldcriteria = new FieldFormulaCalculateCriteriaDto(); // FieldFormulaCalculateCriteriaDto |  (optional) 

            try
            {
                // this method return the result of a formula given the array of fields of profile and their value
                string result = apiInstance.SearchesV2GetFormulaForSearch(fieldcriteria);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV2Api.SearchesV2GetFormulaForSearch: " + e.Message );
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

<a name="searchesv2getlastsearch"></a>
# **SearchesV2GetLastSearch**
> List<SearchDTO> SearchesV2GetLastSearch ()

This call returns a default search according to the Arxivar system settings

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SearchesV2GetLastSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV2Api();

            try
            {
                // This call returns a default search according to the Arxivar system settings
                List&lt;SearchDTO&gt; result = apiInstance.SearchesV2GetLastSearch();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV2Api.SearchesV2GetLastSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<SearchDTO>**](SearchDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesv2getsearchforclassebox"></a>
# **SearchesV2GetSearchForClasseBox**
> SearchDTO SearchesV2GetSearchForClasseBox (string additionalFieldName, ProfileDTO profile = null)

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
    public class SearchesV2GetSearchForClasseBoxExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV2Api();
            var additionalFieldName = additionalFieldName_example;  // string | Additional field name
            var profile = new ProfileDTO(); // ProfileDTO |  (optional) 

            try
            {
                // This call returns a complete search object for search a profile for a additional field
                SearchDTO result = apiInstance.SearchesV2GetSearchForClasseBox(additionalFieldName, profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV2Api.SearchesV2GetSearchForClasseBox: " + e.Message );
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

<a name="searchesv2getselect"></a>
# **SearchesV2GetSelect**
> SelectDTO SearchesV2GetSelect ()

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
    public class SearchesV2GetSelectExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV2Api();

            try
            {
                // This call returns a default select according to the Arxivar system settings
                SelectDTO result = apiInstance.SearchesV2GetSelect();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV2Api.SearchesV2GetSelect: " + e.Message );
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

<a name="searchesv2getselect_0"></a>
# **SearchesV2GetSelect_0**
> SelectDTO SearchesV2GetSelect_0 (int? documentType)

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
    public class SearchesV2GetSelect_0Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV2Api();
            var documentType = 56;  // int? | Document Type Identifier

            try
            {
                // This call returns a new select dto by document type
                SelectDTO result = apiInstance.SearchesV2GetSelect_0(documentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV2Api.SearchesV2GetSelect_0: " + e.Message );
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

<a name="searchesv2getselect_1"></a>
# **SearchesV2GetSelect_1**
> SelectDTO SearchesV2GetSelect_1 (int? documentType, int? tipo2, int? tipo3)

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
    public class SearchesV2GetSelect_1Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV2Api();
            var documentType = 56;  // int? | Document type identifier of first level
            var tipo2 = 56;  // int? | Document type identifier of second level
            var tipo3 = 56;  // int? | Document type identifier of third level

            try
            {
                // This call returns a new select dto by document type levels
                SelectDTO result = apiInstance.SearchesV2GetSelect_1(documentType, tipo2, tipo3);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV2Api.SearchesV2GetSelect_1: " + e.Message );
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

<a name="searchesv2getvaluesforsearch"></a>
# **SearchesV2GetValuesForSearch**
> FieldValuesDTO SearchesV2GetValuesForSearch (FieldValuesSearchCriteriaDto fieldcriteria = null)

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
    public class SearchesV2GetValuesForSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV2Api();
            var fieldcriteria = new FieldValuesSearchCriteriaDto(); // FieldValuesSearchCriteriaDto |  (optional) 

            try
            {
                // This method returns the possible values ​​for an external data source given the additional field code and the value of all other fields in profile
                FieldValuesDTO result = apiInstance.SearchesV2GetValuesForSearch(fieldcriteria);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV2Api.SearchesV2GetValuesForSearch: " + e.Message );
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

<a name="searchesv2lastdocuments"></a>
# **SearchesV2LastDocuments**
> List<RowSearchResult> SearchesV2LastDocuments (int? maxRows, SelectDTO selectDto)

This call searches documents

This method is deprecated. Use api/v3/searches/lastdocuments/{maxRows}

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SearchesV2LastDocumentsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV2Api();
            var maxRows = 56;  // int? | Maximun items to search
            var selectDto = new SelectDTO(); // SelectDTO | Object representing the select

            try
            {
                // This call searches documents
                List&lt;RowSearchResult&gt; result = apiInstance.SearchesV2LastDocuments(maxRows, selectDto);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV2Api.SearchesV2LastDocuments: " + e.Message );
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

<a name="searchesv2postsearchmultiple"></a>
# **SearchesV2PostSearchMultiple**
> List<RowSearchResult> SearchesV2PostSearchMultiple (SearchCriteriaMultipleDto searchwebapimultipledto = null)

This call searches documents

This method is deprecated. Use api/v3/searches

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SearchesV2PostSearchMultipleExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV2Api();
            var searchwebapimultipledto = new SearchCriteriaMultipleDto(); // SearchCriteriaMultipleDto |  (optional) 

            try
            {
                // This call searches documents
                List&lt;RowSearchResult&gt; result = apiInstance.SearchesV2PostSearchMultiple(searchwebapimultipledto);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV2Api.SearchesV2PostSearchMultiple: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchwebapimultipledto** | [**SearchCriteriaMultipleDto**](SearchCriteriaMultipleDto.md)|  | [optional] 

### Return type

[**List<RowSearchResult>**](RowSearchResult.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesv2postselect"></a>
# **SearchesV2PostSelect**
> void SearchesV2PostSelect (SelectDTO selectDto)

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
    public class SearchesV2PostSelectExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV2Api();
            var selectDto = new SelectDTO(); // SelectDTO | Object representing the select

            try
            {
                // This call saves the default select for the user
                apiInstance.SearchesV2PostSelect(selectDto);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV2Api.SearchesV2PostSelect: " + e.Message );
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

<a name="searchesv2resetselect"></a>
# **SearchesV2ResetSelect**
> void SearchesV2ResetSelect ()

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
    public class SearchesV2ResetSelectExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV2Api();

            try
            {
                // This call deletes a possible custom select for the user
                apiInstance.SearchesV2ResetSelect();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV2Api.SearchesV2ResetSelect: " + e.Message );
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

<a name="searchesv2setdefaultsearch"></a>
# **SearchesV2SetDefaultSearch**
> void SearchesV2SetDefaultSearch (SearchCriteriaMultipleDto searchwebapidto = null)

This call saves the default search for the user

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SearchesV2SetDefaultSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV2Api();
            var searchwebapidto = new SearchCriteriaMultipleDto(); // SearchCriteriaMultipleDto |  (optional) 

            try
            {
                // This call saves the default search for the user
                apiInstance.SearchesV2SetDefaultSearch(searchwebapidto);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV2Api.SearchesV2SetDefaultSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchwebapidto** | [**SearchCriteriaMultipleDto**](SearchCriteriaMultipleDto.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesv2setlastsearch"></a>
# **SearchesV2SetLastSearch**
> void SearchesV2SetLastSearch (SearchCriteriaMultipleDto searchwebapidto = null)

This call saves the last search for the user

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SearchesV2SetLastSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV2Api();
            var searchwebapidto = new SearchCriteriaMultipleDto(); // SearchCriteriaMultipleDto |  (optional) 

            try
            {
                // This call saves the last search for the user
                apiInstance.SearchesV2SetLastSearch(searchwebapidto);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV2Api.SearchesV2SetLastSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchwebapidto** | [**SearchCriteriaMultipleDto**](SearchCriteriaMultipleDto.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


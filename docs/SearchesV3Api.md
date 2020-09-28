# ARXivarNEXT.Client.Api.SearchesV3Api

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SearchesV3Delete**](SearchesV3Api.md#searchesv3delete) | **DELETE** /api/v3/searches | This call delete the default search for the user
[**SearchesV3Get**](SearchesV3Api.md#searchesv3get) | **GET** /api/v3/searches | This call returns a default search according to the Arxivar system settings
[**SearchesV3GetAdditionalByClasse**](SearchesV3Api.md#searchesv3getadditionalbyclasse) | **GET** /api/v3/searches/Additional/{tipoUno}/{tipoDue}/{tipoTre} | This call returns the additional fields for search by the given document class and business unit
[**SearchesV3GetEmpty**](SearchesV3Api.md#searchesv3getempty) | **GET** /api/v3/searches/empty | This call returns an empty search according to the Arxivar system settings
[**SearchesV3GetFiltersForSearch**](SearchesV3Api.md#searchesv3getfiltersforsearch) | **POST** /api/v3/searches/Filters | This call returns the list of filter avaible for a specific additional field
[**SearchesV3GetFormulaForSearch**](SearchesV3Api.md#searchesv3getformulaforsearch) | **POST** /api/v3/searches/Formula | this method return the result of a formula given the array of fields of profile and their value
[**SearchesV3GetLastSearch**](SearchesV3Api.md#searchesv3getlastsearch) | **GET** /api/v3/searches/lastsearch | This call returns a default search according to the Arxivar system settings
[**SearchesV3GetSearchForClasseBox**](SearchesV3Api.md#searchesv3getsearchforclassebox) | **POST** /api/v3/searches/byclassadditionalfield/{additionalFieldName}/Search | This call returns a complete search object for search a profile for a additional field
[**SearchesV3GetSelect**](SearchesV3Api.md#searchesv3getselect) | **GET** /api/v3/searches/Select | This call returns a default select according to the Arxivar system settings
[**SearchesV3GetSelect_0**](SearchesV3Api.md#searchesv3getselect_0) | **GET** /api/v3/searches/Select/{documentType} | This call returns a new select dto by document type
[**SearchesV3GetSelect_1**](SearchesV3Api.md#searchesv3getselect_1) | **GET** /api/v3/searches/Select/{documentType}/{tipo2}/{tipo3} | This call returns a new select dto by document type levels
[**SearchesV3GetValuesForSearch**](SearchesV3Api.md#searchesv3getvaluesforsearch) | **POST** /api/v3/searches/Values | This method returns the possible values ​​for an external data source given the additional field code and the value of all other fields in profile
[**SearchesV3LastDocuments**](SearchesV3Api.md#searchesv3lastdocuments) | **POST** /api/v3/searches/lastdocuments/{maxRows} | This call searches documents.  This call could not be compatible with some programming language, in this case use the call api/searches/lastdocuments/{maxRows}
[**SearchesV3PostSearchMultiple**](SearchesV3Api.md#searchesv3postsearchmultiple) | **POST** /api/v3/searches | This call searches documents.  This call could not be compatible with some programming language, in this case use the call api/searches
[**SearchesV3PostSelect**](SearchesV3Api.md#searchesv3postselect) | **POST** /api/v3/searches/Select | This call saves the default select for the user
[**SearchesV3ResetSelect**](SearchesV3Api.md#searchesv3resetselect) | **POST** /api/v3/searches/Reset | This call deletes a possible custom select for the user
[**SearchesV3SetDefaultSearch**](SearchesV3Api.md#searchesv3setdefaultsearch) | **POST** /api/v3/searches/defaultsearch | This call saves the default search for the user
[**SearchesV3SetLastSearch**](SearchesV3Api.md#searchesv3setlastsearch) | **POST** /api/v3/searches/lastsearch | This call saves the last search for the user


<a name="searchesv3delete"></a>
# **SearchesV3Delete**
> void SearchesV3Delete ()

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
    public class SearchesV3DeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV3Api();

            try
            {
                // This call delete the default search for the user
                apiInstance.SearchesV3Delete();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV3Api.SearchesV3Delete: " + e.Message );
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

<a name="searchesv3get"></a>
# **SearchesV3Get**
> List<SearchDTO> SearchesV3Get ()

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
    public class SearchesV3GetExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV3Api();

            try
            {
                // This call returns a default search according to the Arxivar system settings
                List&lt;SearchDTO&gt; result = apiInstance.SearchesV3Get();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV3Api.SearchesV3Get: " + e.Message );
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

<a name="searchesv3getadditionalbyclasse"></a>
# **SearchesV3GetAdditionalByClasse**
> List<FieldBaseForSearchDTO> SearchesV3GetAdditionalByClasse (int? tipoUno, int? tipoDue, int? tipoTre, string aoo = null)

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
    public class SearchesV3GetAdditionalByClasseExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV3Api();
            var tipoUno = 56;  // int? | Document type identifier of first level
            var tipoDue = 56;  // int? | Document type identifier of second level
            var tipoTre = 56;  // int? | Document type identifier of third level
            var aoo = aoo_example;  // string | Business unit code (optional) 

            try
            {
                // This call returns the additional fields for search by the given document class and business unit
                List&lt;FieldBaseForSearchDTO&gt; result = apiInstance.SearchesV3GetAdditionalByClasse(tipoUno, tipoDue, tipoTre, aoo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV3Api.SearchesV3GetAdditionalByClasse: " + e.Message );
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

<a name="searchesv3getempty"></a>
# **SearchesV3GetEmpty**
> SearchDTO SearchesV3GetEmpty ()

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
    public class SearchesV3GetEmptyExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV3Api();

            try
            {
                // This call returns an empty search according to the Arxivar system settings
                SearchDTO result = apiInstance.SearchesV3GetEmpty();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV3Api.SearchesV3GetEmpty: " + e.Message );
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

<a name="searchesv3getfiltersforsearch"></a>
# **SearchesV3GetFiltersForSearch**
> FieldFilterDTO SearchesV3GetFiltersForSearch (FieldValuesSearchCriteriaDto fieldcriteria = null)

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
    public class SearchesV3GetFiltersForSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV3Api();
            var fieldcriteria = new FieldValuesSearchCriteriaDto(); // FieldValuesSearchCriteriaDto |  (optional) 

            try
            {
                // This call returns the list of filter avaible for a specific additional field
                FieldFilterDTO result = apiInstance.SearchesV3GetFiltersForSearch(fieldcriteria);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV3Api.SearchesV3GetFiltersForSearch: " + e.Message );
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

<a name="searchesv3getformulaforsearch"></a>
# **SearchesV3GetFormulaForSearch**
> string SearchesV3GetFormulaForSearch (FieldFormulaCalculateCriteriaDto fieldcriteria = null)

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
    public class SearchesV3GetFormulaForSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV3Api();
            var fieldcriteria = new FieldFormulaCalculateCriteriaDto(); // FieldFormulaCalculateCriteriaDto |  (optional) 

            try
            {
                // this method return the result of a formula given the array of fields of profile and their value
                string result = apiInstance.SearchesV3GetFormulaForSearch(fieldcriteria);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV3Api.SearchesV3GetFormulaForSearch: " + e.Message );
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

<a name="searchesv3getlastsearch"></a>
# **SearchesV3GetLastSearch**
> List<SearchDTO> SearchesV3GetLastSearch ()

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
    public class SearchesV3GetLastSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV3Api();

            try
            {
                // This call returns a default search according to the Arxivar system settings
                List&lt;SearchDTO&gt; result = apiInstance.SearchesV3GetLastSearch();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV3Api.SearchesV3GetLastSearch: " + e.Message );
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

<a name="searchesv3getsearchforclassebox"></a>
# **SearchesV3GetSearchForClasseBox**
> SearchDTO SearchesV3GetSearchForClasseBox (string additionalFieldName, ProfileDTO profile = null)

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
    public class SearchesV3GetSearchForClasseBoxExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV3Api();
            var additionalFieldName = additionalFieldName_example;  // string | Additional field name
            var profile = new ProfileDTO(); // ProfileDTO |  (optional) 

            try
            {
                // This call returns a complete search object for search a profile for a additional field
                SearchDTO result = apiInstance.SearchesV3GetSearchForClasseBox(additionalFieldName, profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV3Api.SearchesV3GetSearchForClasseBox: " + e.Message );
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

<a name="searchesv3getselect"></a>
# **SearchesV3GetSelect**
> SelectDTO SearchesV3GetSelect ()

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
    public class SearchesV3GetSelectExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV3Api();

            try
            {
                // This call returns a default select according to the Arxivar system settings
                SelectDTO result = apiInstance.SearchesV3GetSelect();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV3Api.SearchesV3GetSelect: " + e.Message );
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

<a name="searchesv3getselect_0"></a>
# **SearchesV3GetSelect_0**
> SelectDTO SearchesV3GetSelect_0 (int? documentType)

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
    public class SearchesV3GetSelect_0Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV3Api();
            var documentType = 56;  // int? | Document Type Identifier

            try
            {
                // This call returns a new select dto by document type
                SelectDTO result = apiInstance.SearchesV3GetSelect_0(documentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV3Api.SearchesV3GetSelect_0: " + e.Message );
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

<a name="searchesv3getselect_1"></a>
# **SearchesV3GetSelect_1**
> SelectDTO SearchesV3GetSelect_1 (int? documentType, int? tipo2, int? tipo3)

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
    public class SearchesV3GetSelect_1Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV3Api();
            var documentType = 56;  // int? | Document type identifier of first level
            var tipo2 = 56;  // int? | Document type identifier of second level
            var tipo3 = 56;  // int? | Document type identifier of third level

            try
            {
                // This call returns a new select dto by document type levels
                SelectDTO result = apiInstance.SearchesV3GetSelect_1(documentType, tipo2, tipo3);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV3Api.SearchesV3GetSelect_1: " + e.Message );
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

<a name="searchesv3getvaluesforsearch"></a>
# **SearchesV3GetValuesForSearch**
> FieldValuesDTO SearchesV3GetValuesForSearch (FieldValuesSearchCriteriaDto fieldcriteria = null)

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
    public class SearchesV3GetValuesForSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV3Api();
            var fieldcriteria = new FieldValuesSearchCriteriaDto(); // FieldValuesSearchCriteriaDto |  (optional) 

            try
            {
                // This method returns the possible values ​​for an external data source given the additional field code and the value of all other fields in profile
                FieldValuesDTO result = apiInstance.SearchesV3GetValuesForSearch(fieldcriteria);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV3Api.SearchesV3GetValuesForSearch: " + e.Message );
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

<a name="searchesv3lastdocuments"></a>
# **SearchesV3LastDocuments**
> Object SearchesV3LastDocuments (int? maxRows, SelectDTO selectDto)

This call searches documents.  This call could not be compatible with some programming language, in this case use the call api/searches/lastdocuments/{maxRows}

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SearchesV3LastDocumentsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV3Api();
            var maxRows = 56;  // int? | Maximun items to search
            var selectDto = new SelectDTO(); // SelectDTO | Object representing the select

            try
            {
                // This call searches documents.  This call could not be compatible with some programming language, in this case use the call api/searches/lastdocuments/{maxRows}
                Object result = apiInstance.SearchesV3LastDocuments(maxRows, selectDto);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV3Api.SearchesV3LastDocuments: " + e.Message );
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

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesv3postsearchmultiple"></a>
# **SearchesV3PostSearchMultiple**
> Object SearchesV3PostSearchMultiple (SearchCriteriaMultipleDto searchwebapimultipledto = null)

This call searches documents.  This call could not be compatible with some programming language, in this case use the call api/searches

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SearchesV3PostSearchMultipleExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV3Api();
            var searchwebapimultipledto = new SearchCriteriaMultipleDto(); // SearchCriteriaMultipleDto |  (optional) 

            try
            {
                // This call searches documents.  This call could not be compatible with some programming language, in this case use the call api/searches
                Object result = apiInstance.SearchesV3PostSearchMultiple(searchwebapimultipledto);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV3Api.SearchesV3PostSearchMultiple: " + e.Message );
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

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchesv3postselect"></a>
# **SearchesV3PostSelect**
> void SearchesV3PostSelect (SelectDTO selectDto)

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
    public class SearchesV3PostSelectExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV3Api();
            var selectDto = new SelectDTO(); // SelectDTO | Object representing the select

            try
            {
                // This call saves the default select for the user
                apiInstance.SearchesV3PostSelect(selectDto);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV3Api.SearchesV3PostSelect: " + e.Message );
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

<a name="searchesv3resetselect"></a>
# **SearchesV3ResetSelect**
> void SearchesV3ResetSelect ()

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
    public class SearchesV3ResetSelectExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV3Api();

            try
            {
                // This call deletes a possible custom select for the user
                apiInstance.SearchesV3ResetSelect();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV3Api.SearchesV3ResetSelect: " + e.Message );
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

<a name="searchesv3setdefaultsearch"></a>
# **SearchesV3SetDefaultSearch**
> void SearchesV3SetDefaultSearch (SearchCriteriaMultipleDto searchwebapidto = null)

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
    public class SearchesV3SetDefaultSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV3Api();
            var searchwebapidto = new SearchCriteriaMultipleDto(); // SearchCriteriaMultipleDto |  (optional) 

            try
            {
                // This call saves the default search for the user
                apiInstance.SearchesV3SetDefaultSearch(searchwebapidto);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV3Api.SearchesV3SetDefaultSearch: " + e.Message );
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

<a name="searchesv3setlastsearch"></a>
# **SearchesV3SetLastSearch**
> void SearchesV3SetLastSearch (SearchCriteriaMultipleDto searchwebapidto = null)

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
    public class SearchesV3SetLastSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchesV3Api();
            var searchwebapidto = new SearchCriteriaMultipleDto(); // SearchCriteriaMultipleDto |  (optional) 

            try
            {
                // This call saves the last search for the user
                apiInstance.SearchesV3SetLastSearch(searchwebapidto);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchesV3Api.SearchesV3SetLastSearch: " + e.Message );
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


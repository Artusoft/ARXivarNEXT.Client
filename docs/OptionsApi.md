# ARXivarNEXT.Client.Api.OptionsApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OptionsGet**](OptionsApi.md#optionsget) | **GET** /api/Options | This call returns the options for the connected user (aka: Configura-Generale)
[**OptionsGetByArgomento**](OptionsApi.md#optionsgetbyargomento) | **GET** /api/Options/topic/{argument} | This call retrieves options by the given argument
[**OptionsGetByArgomentoCampo**](OptionsApi.md#optionsgetbyargomentocampo) | **GET** /api/Options/topicField/{argument}/{field} | This call returns options by the given argument and given field
[**OptionsGetByArgomentoUtente**](OptionsApi.md#optionsgetbyargomentoutente) | **GET** /api/Options/topicAndUser/{argument} | This call retrieves options by the given argument
[**OptionsGetDocumentTypeViewMode**](OptionsApi.md#optionsgetdocumenttypeviewmode) | **GET** /api/Options/documenttypeviewmode | This call returns the option for display Document Type
[**OptionsSetByArgomentoUtente**](OptionsApi.md#optionssetbyargomentoutente) | **PUT** /api/Options/topicAndUser | This call writes a option


<a name="optionsget"></a>
# **OptionsGet**
> UserOptionsDto OptionsGet ()

This call returns the options for the connected user (aka: Configura-Generale)

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class OptionsGetExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OptionsApi();

            try
            {
                // This call returns the options for the connected user (aka: Configura-Generale)
                UserOptionsDto result = apiInstance.OptionsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OptionsApi.OptionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserOptionsDto**](UserOptionsDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="optionsgetbyargomento"></a>
# **OptionsGetByArgomento**
> List<OptionsDTO> OptionsGetByArgomento (string argument)

This call retrieves options by the given argument

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class OptionsGetByArgomentoExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OptionsApi();
            var argument = argument_example;  // string | Argument filter

            try
            {
                // This call retrieves options by the given argument
                List&lt;OptionsDTO&gt; result = apiInstance.OptionsGetByArgomento(argument);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OptionsApi.OptionsGetByArgomento: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **argument** | **string**| Argument filter | 

### Return type

[**List<OptionsDTO>**](OptionsDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="optionsgetbyargomentocampo"></a>
# **OptionsGetByArgomentoCampo**
> List<OptionsDTO> OptionsGetByArgomentoCampo (string argument, string field)

This call returns options by the given argument and given field

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class OptionsGetByArgomentoCampoExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OptionsApi();
            var argument = argument_example;  // string | Argument filter
            var field = field_example;  // string | Field filter

            try
            {
                // This call returns options by the given argument and given field
                List&lt;OptionsDTO&gt; result = apiInstance.OptionsGetByArgomentoCampo(argument, field);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OptionsApi.OptionsGetByArgomentoCampo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **argument** | **string**| Argument filter | 
 **field** | **string**| Field filter | 

### Return type

[**List<OptionsDTO>**](OptionsDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="optionsgetbyargomentoutente"></a>
# **OptionsGetByArgomentoUtente**
> List<OptionsDTO> OptionsGetByArgomentoUtente (string argument)

This call retrieves options by the given argument

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class OptionsGetByArgomentoUtenteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OptionsApi();
            var argument = argument_example;  // string | Argument filter

            try
            {
                // This call retrieves options by the given argument
                List&lt;OptionsDTO&gt; result = apiInstance.OptionsGetByArgomentoUtente(argument);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OptionsApi.OptionsGetByArgomentoUtente: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **argument** | **string**| Argument filter | 

### Return type

[**List<OptionsDTO>**](OptionsDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="optionsgetdocumenttypeviewmode"></a>
# **OptionsGetDocumentTypeViewMode**
> int? OptionsGetDocumentTypeViewMode ()

This call returns the option for display Document Type

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class OptionsGetDocumentTypeViewModeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OptionsApi();

            try
            {
                // This call returns the option for display Document Type
                int? result = apiInstance.OptionsGetDocumentTypeViewMode();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OptionsApi.OptionsGetDocumentTypeViewMode: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**int?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="optionssetbyargomentoutente"></a>
# **OptionsSetByArgomentoUtente**
> void OptionsSetByArgomentoUtente (OptionsRequestDTO requestDto)

This call writes a option

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class OptionsSetByArgomentoUtenteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OptionsApi();
            var requestDto = new OptionsRequestDTO(); // OptionsRequestDTO | Option information

            try
            {
                // This call writes a option
                apiInstance.OptionsSetByArgomentoUtente(requestDto);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OptionsApi.OptionsSetByArgomentoUtente: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestDto** | [**OptionsRequestDTO**](OptionsRequestDTO.md)| Option information | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


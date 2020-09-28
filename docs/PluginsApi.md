# ARXivarNEXT.Client.Api.PluginsApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PluginsPluginsGet**](PluginsApi.md#pluginspluginsget) | **GET** /api/Plugins/{pluginCode} | This call invokes a server plugin
[**PluginsPluginsList**](PluginsApi.md#pluginspluginslist) | **GET** /api/Plugins/list | This call returns the server plugin list
[**PluginsPluginsPost**](PluginsApi.md#pluginspluginspost) | **POST** /api/Plugins/{pluginCode} | This call invokes a server plugin


<a name="pluginspluginsget"></a>
# **PluginsPluginsGet**
> Object PluginsPluginsGet (string pluginCode)

This call invokes a server plugin

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class PluginsPluginsGetExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PluginsApi();
            var pluginCode = pluginCode_example;  // string | Identifier of plugin

            try
            {
                // This call invokes a server plugin
                Object result = apiInstance.PluginsPluginsGet(pluginCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PluginsApi.PluginsPluginsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pluginCode** | **string**| Identifier of plugin | 

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pluginspluginslist"></a>
# **PluginsPluginsList**
> List<ServerPluginDto> PluginsPluginsList ()

This call returns the server plugin list

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class PluginsPluginsListExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PluginsApi();

            try
            {
                // This call returns the server plugin list
                List&lt;ServerPluginDto&gt; result = apiInstance.PluginsPluginsList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PluginsApi.PluginsPluginsList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ServerPluginDto>**](ServerPluginDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pluginspluginspost"></a>
# **PluginsPluginsPost**
> Object PluginsPluginsPost (string pluginCode, List<KeyValuePairStringString> parameters)

This call invokes a server plugin

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class PluginsPluginsPostExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PluginsApi();
            var pluginCode = pluginCode_example;  // string | Identifier of plugin
            var parameters = new List<KeyValuePairStringString>(); // List<KeyValuePairStringString> | Parameters

            try
            {
                // This call invokes a server plugin
                Object result = apiInstance.PluginsPluginsPost(pluginCode, parameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PluginsApi.PluginsPluginsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pluginCode** | **string**| Identifier of plugin | 
 **parameters** | [**List&lt;KeyValuePairStringString&gt;**](KeyValuePairStringString.md)| Parameters | 

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


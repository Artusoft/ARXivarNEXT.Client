# ARXivarNEXT.Client.Api.ClientSettingsApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ClientSettingsGetPluginSettings**](ClientSettingsApi.md#clientsettingsgetpluginsettings) | **GET** /api/Settings/plugin/{pluginId} | This call returns the settings of plugin
[**ClientSettingsGetPluginUserSettings**](ClientSettingsApi.md#clientsettingsgetpluginusersettings) | **POST** /api/Settings/pluginForUser | This call returns the plugin settings of connected user
[**ClientSettingsGetSettings**](ClientSettingsApi.md#clientsettingsgetsettings) | **GET** /api/Settings/user | This call returns the settings of connected user
[**ClientSettingsGetSystemSettings**](ClientSettingsApi.md#clientsettingsgetsystemsettings) | **GET** /api/Settings | This call returns the settings of system
[**ClientSettingsGetWidgetSettings**](ClientSettingsApi.md#clientsettingsgetwidgetsettings) | **GET** /api/Settings/widget/{id}/{instanceId}/{desktopId} | This call returns the widget settings
[**ClientSettingsGetWidgetUserSettings**](ClientSettingsApi.md#clientsettingsgetwidgetusersettings) | **GET** /api/Settings/widgetForUser/{id}/{instanceId}/{desktopId} | This call returns the widget settings of connected user
[**ClientSettingsUpdatePluginSetting**](ClientSettingsApi.md#clientsettingsupdatepluginsetting) | **PUT** /api/Settings/plugin/{pluginId} | This call upade the setting of plugin
[**ClientSettingsUpdatePluginUserSetting**](ClientSettingsApi.md#clientsettingsupdatepluginusersetting) | **PUT** /api/Settings/pluginForUser | This call upade the plugin settings of connected user
[**ClientSettingsUpdateUserSetting**](ClientSettingsApi.md#clientsettingsupdateusersetting) | **PUT** /api/Settings/user | This call upade the setting of system
[**ClientSettingsUpdateWidgetSetting**](ClientSettingsApi.md#clientsettingsupdatewidgetsetting) | **PUT** /api/Settings/widget/{id}/{instanceId}/{desktopId} | This call upade the widget settings
[**ClientSettingsUpdateWidgetUserSetting**](ClientSettingsApi.md#clientsettingsupdatewidgetusersetting) | **PUT** /api/Settings/widgetForUser/{id}/{instanceId}/{desktopId} | This call upade the widget settings of connected user


<a name="clientsettingsgetpluginsettings"></a>
# **ClientSettingsGetPluginSettings**
> Object ClientSettingsGetPluginSettings (string pluginId)

This call returns the settings of plugin

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ClientSettingsGetPluginSettingsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientSettingsApi();
            var pluginId = pluginId_example;  // string | Identifier of plugin

            try
            {
                // This call returns the settings of plugin
                Object result = apiInstance.ClientSettingsGetPluginSettings(pluginId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientSettingsApi.ClientSettingsGetPluginSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pluginId** | **string**| Identifier of plugin | 

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clientsettingsgetpluginusersettings"></a>
# **ClientSettingsGetPluginUserSettings**
> Object ClientSettingsGetPluginUserSettings (PluginSettingRequest pluginRequest)

This call returns the plugin settings of connected user

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ClientSettingsGetPluginUserSettingsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientSettingsApi();
            var pluginRequest = new PluginSettingRequest(); // PluginSettingRequest | Request of plugin settings

            try
            {
                // This call returns the plugin settings of connected user
                Object result = apiInstance.ClientSettingsGetPluginUserSettings(pluginRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientSettingsApi.ClientSettingsGetPluginUserSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pluginRequest** | [**PluginSettingRequest**](PluginSettingRequest.md)| Request of plugin settings | 

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clientsettingsgetsettings"></a>
# **ClientSettingsGetSettings**
> Object ClientSettingsGetSettings ()

This call returns the settings of connected user

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ClientSettingsGetSettingsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientSettingsApi();

            try
            {
                // This call returns the settings of connected user
                Object result = apiInstance.ClientSettingsGetSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientSettingsApi.ClientSettingsGetSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clientsettingsgetsystemsettings"></a>
# **ClientSettingsGetSystemSettings**
> Object ClientSettingsGetSystemSettings ()

This call returns the settings of system

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ClientSettingsGetSystemSettingsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientSettingsApi();

            try
            {
                // This call returns the settings of system
                Object result = apiInstance.ClientSettingsGetSystemSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientSettingsApi.ClientSettingsGetSystemSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clientsettingsgetwidgetsettings"></a>
# **ClientSettingsGetWidgetSettings**
> Object ClientSettingsGetWidgetSettings (string id, string instanceId, int? desktopId)

This call returns the widget settings

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ClientSettingsGetWidgetSettingsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientSettingsApi();
            var id = id_example;  // string | Widget identifier
            var instanceId = instanceId_example;  // string | Instance identifier
            var desktopId = 56;  // int? | Desktop identifier

            try
            {
                // This call returns the widget settings
                Object result = apiInstance.ClientSettingsGetWidgetSettings(id, instanceId, desktopId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientSettingsApi.ClientSettingsGetWidgetSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Widget identifier | 
 **instanceId** | **string**| Instance identifier | 
 **desktopId** | **int?**| Desktop identifier | 

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clientsettingsgetwidgetusersettings"></a>
# **ClientSettingsGetWidgetUserSettings**
> Object ClientSettingsGetWidgetUserSettings (string id, string instanceId, int? desktopId)

This call returns the widget settings of connected user

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ClientSettingsGetWidgetUserSettingsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientSettingsApi();
            var id = id_example;  // string | Widget identifier
            var instanceId = instanceId_example;  // string | Instance identifier
            var desktopId = 56;  // int? | Desktop identifier

            try
            {
                // This call returns the widget settings of connected user
                Object result = apiInstance.ClientSettingsGetWidgetUserSettings(id, instanceId, desktopId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientSettingsApi.ClientSettingsGetWidgetUserSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Widget identifier | 
 **instanceId** | **string**| Instance identifier | 
 **desktopId** | **int?**| Desktop identifier | 

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clientsettingsupdatepluginsetting"></a>
# **ClientSettingsUpdatePluginSetting**
> void ClientSettingsUpdatePluginSetting (string pluginId, Object setting)

This call upade the setting of plugin

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ClientSettingsUpdatePluginSettingExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientSettingsApi();
            var pluginId = pluginId_example;  // string | Identifier of plugin
            var setting = ;  // Object | Settings information to update

            try
            {
                // This call upade the setting of plugin
                apiInstance.ClientSettingsUpdatePluginSetting(pluginId, setting);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientSettingsApi.ClientSettingsUpdatePluginSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pluginId** | **string**| Identifier of plugin | 
 **setting** | **Object**| Settings information to update | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clientsettingsupdatepluginusersetting"></a>
# **ClientSettingsUpdatePluginUserSetting**
> void ClientSettingsUpdatePluginUserSetting (PluginSettingRequest pluginRequest)

This call upade the plugin settings of connected user

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ClientSettingsUpdatePluginUserSettingExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientSettingsApi();
            var pluginRequest = new PluginSettingRequest(); // PluginSettingRequest | Request of plugin settings

            try
            {
                // This call upade the plugin settings of connected user
                apiInstance.ClientSettingsUpdatePluginUserSetting(pluginRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientSettingsApi.ClientSettingsUpdatePluginUserSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pluginRequest** | [**PluginSettingRequest**](PluginSettingRequest.md)| Request of plugin settings | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clientsettingsupdateusersetting"></a>
# **ClientSettingsUpdateUserSetting**
> void ClientSettingsUpdateUserSetting (Object setting)

This call upade the setting of system

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ClientSettingsUpdateUserSettingExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientSettingsApi();
            var setting = ;  // Object | Settings information to update

            try
            {
                // This call upade the setting of system
                apiInstance.ClientSettingsUpdateUserSetting(setting);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientSettingsApi.ClientSettingsUpdateUserSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **setting** | **Object**| Settings information to update | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clientsettingsupdatewidgetsetting"></a>
# **ClientSettingsUpdateWidgetSetting**
> void ClientSettingsUpdateWidgetSetting (string id, string instanceId, int? desktopId, Object userSettings)

This call upade the widget settings

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ClientSettingsUpdateWidgetSettingExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientSettingsApi();
            var id = id_example;  // string | Widget identifier
            var instanceId = instanceId_example;  // string | Instance identifier
            var desktopId = 56;  // int? | Desktop identifier
            var userSettings = ;  // Object | Settings information to update

            try
            {
                // This call upade the widget settings
                apiInstance.ClientSettingsUpdateWidgetSetting(id, instanceId, desktopId, userSettings);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientSettingsApi.ClientSettingsUpdateWidgetSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Widget identifier | 
 **instanceId** | **string**| Instance identifier | 
 **desktopId** | **int?**| Desktop identifier | 
 **userSettings** | **Object**| Settings information to update | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clientsettingsupdatewidgetusersetting"></a>
# **ClientSettingsUpdateWidgetUserSetting**
> void ClientSettingsUpdateWidgetUserSetting (string id, string instanceId, int? desktopId, Object userSettings)

This call upade the widget settings of connected user

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ClientSettingsUpdateWidgetUserSettingExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientSettingsApi();
            var id = id_example;  // string | Widget identifier
            var instanceId = instanceId_example;  // string | Instance identifier
            var desktopId = 56;  // int? | Desktop identifier
            var userSettings = ;  // Object | Settings information to update

            try
            {
                // This call upade the widget settings of connected user
                apiInstance.ClientSettingsUpdateWidgetUserSetting(id, instanceId, desktopId, userSettings);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientSettingsApi.ClientSettingsUpdateWidgetUserSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Widget identifier | 
 **instanceId** | **string**| Instance identifier | 
 **desktopId** | **int?**| Desktop identifier | 
 **userSettings** | **Object**| Settings information to update | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


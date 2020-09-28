# ARXivarNEXT.Client.Api.ChatApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChatDeleteAvatar**](ChatApi.md#chatdeleteavatar) | **DELETE** /api/Chat/avatar | Thi call delete the avatar for the user connected
[**ChatGetAvatar**](ChatApi.md#chatgetavatar) | **GET** /api/Chat/{id} | Call that returns the user avatar given his identifier
[**ChatGetSettings**](ChatApi.md#chatgetsettings) | **GET** /api/Chat/settings | Call that returns the settings for the chat service
[**ChatGetShareOptions**](ChatApi.md#chatgetshareoptions) | **POST** /api/Chat/ShareOptions | This call returns the share option by a share object
[**ChatSetAvatar**](ChatApi.md#chatsetavatar) | **PUT** /api/Chat/avatar | This call set the avatar for the user connected
[**ChatSetSettings**](ChatApi.md#chatsetsettings) | **PUT** /api/Chat/settings | Call that save the settings for the chat service
[**ChatShareObject**](ChatApi.md#chatshareobject) | **POST** /api/Chat/Share/{conversationid} | This call share an object to conversation


<a name="chatdeleteavatar"></a>
# **ChatDeleteAvatar**
> void ChatDeleteAvatar ()

Thi call delete the avatar for the user connected

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ChatDeleteAvatarExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChatApi();

            try
            {
                // Thi call delete the avatar for the user connected
                apiInstance.ChatDeleteAvatar();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.ChatDeleteAvatar: " + e.Message );
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

<a name="chatgetavatar"></a>
# **ChatGetAvatar**
> Object ChatGetAvatar (int? id)

Call that returns the user avatar given his identifier

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ChatGetAvatarExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChatApi();
            var id = 56;  // int? | User identifier which you require avatar

            try
            {
                // Call that returns the user avatar given his identifier
                Object result = apiInstance.ChatGetAvatar(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.ChatGetAvatar: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| User identifier which you require avatar | 

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chatgetsettings"></a>
# **ChatGetSettings**
> ChatServiceSettingsDTO ChatGetSettings ()

Call that returns the settings for the chat service

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ChatGetSettingsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChatApi();

            try
            {
                // Call that returns the settings for the chat service
                ChatServiceSettingsDTO result = apiInstance.ChatGetSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.ChatGetSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ChatServiceSettingsDTO**](ChatServiceSettingsDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chatgetshareoptions"></a>
# **ChatGetShareOptions**
> ShareObjectOptionsDTO ChatGetShareOptions (ShareObjectBaseDTO shareObject)

This call returns the share option by a share object

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ChatGetShareOptionsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChatApi();
            var shareObject = new ShareObjectBaseDTO(); // ShareObjectBaseDTO | Share data

            try
            {
                // This call returns the share option by a share object
                ShareObjectOptionsDTO result = apiInstance.ChatGetShareOptions(shareObject);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.ChatGetShareOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shareObject** | [**ShareObjectBaseDTO**](ShareObjectBaseDTO.md)| Share data | 

### Return type

[**ShareObjectOptionsDTO**](ShareObjectOptionsDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chatsetavatar"></a>
# **ChatSetAvatar**
> void ChatSetAvatar (SetAvatarRequestDto request)

This call set the avatar for the user connected

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ChatSetAvatarExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChatApi();
            var request = new SetAvatarRequestDto(); // SetAvatarRequestDto | SetAvatarRequestDto that contain the base64 avatar

            try
            {
                // This call set the avatar for the user connected
                apiInstance.ChatSetAvatar(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.ChatSetAvatar: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SetAvatarRequestDto**](SetAvatarRequestDto.md)| SetAvatarRequestDto that contain the base64 avatar | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chatsetsettings"></a>
# **ChatSetSettings**
> void ChatSetSettings (ChatServiceSettingsDTO chatServiceSettings)

Call that save the settings for the chat service

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ChatSetSettingsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChatApi();
            var chatServiceSettings = new ChatServiceSettingsDTO(); // ChatServiceSettingsDTO | Settings of char service

            try
            {
                // Call that save the settings for the chat service
                apiInstance.ChatSetSettings(chatServiceSettings);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.ChatSetSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chatServiceSettings** | [**ChatServiceSettingsDTO**](ChatServiceSettingsDTO.md)| Settings of char service | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chatshareobject"></a>
# **ChatShareObject**
> void ChatShareObject (int? conversationid, ShareObjectDTO shareObject)

This call share an object to conversation

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ChatShareObjectExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChatApi();
            var conversationid = 56;  // int? | Identifier of the conversation
            var shareObject = new ShareObjectDTO(); // ShareObjectDTO | Object to share

            try
            {
                // This call share an object to conversation
                apiInstance.ChatShareObject(conversationid, shareObject);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.ChatShareObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationid** | **int?**| Identifier of the conversation | 
 **shareObject** | [**ShareObjectDTO**](ShareObjectDTO.md)| Object to share | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


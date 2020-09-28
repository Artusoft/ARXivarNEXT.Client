# ARXivarNEXT.Client.Api.AuthenticationApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthenticationDeleteLogonTicket**](AuthenticationApi.md#authenticationdeletelogonticket) | **DELETE** /api/Authentication/logonTicket/{logonTicketId} | Delete LogonTicket
[**AuthenticationDeleteLogonTicketAdmin**](AuthenticationApi.md#authenticationdeletelogonticketadmin) | **DELETE** /api/Authentication/logonTicket/admin/{logonTicketId} | Delete LogonTicket (admin required)
[**AuthenticationGetAcecssTokenClaims**](AuthenticationApi.md#authenticationgetacecsstokenclaims) | **GET** /api/Authentication/AcecssTokenClaims | This call returns the access token claims
[**AuthenticationGetLogonProviderInfo**](AuthenticationApi.md#authenticationgetlogonproviderinfo) | **GET** /api/Authentication/logonProvider/{id} | This call returns a specific logon provider by id
[**AuthenticationGetLogonProviderInfoList**](AuthenticationApi.md#authenticationgetlogonproviderinfolist) | **GET** /api/Authentication/logonProviderList | This call returns the logon provider list
[**AuthenticationGetLogonProviderRedirectUri**](AuthenticationApi.md#authenticationgetlogonproviderredirecturi) | **POST** /api/Authentication/getLogonProviderRedirectUri | This call returns the provides logon redirect uri for implicit logon provider authentication
[**AuthenticationGetLogonTicketAdmin**](AuthenticationApi.md#authenticationgetlogonticketadmin) | **GET** /api/Authentication/logonTicket/admin/list | Get LogonTicket list of all users. Included those no longer valid (admin required)
[**AuthenticationGetLogonTicketAdminByLogonTicket**](AuthenticationApi.md#authenticationgetlogonticketadminbylogonticket) | **GET** /api/Authentication/logonTicket/admin/{logonTicket} | Get LogonTicket by ticket (admin required)
[**AuthenticationGetLogonTicketByUserRequestor**](AuthenticationApi.md#authenticationgetlogonticketbyuserrequestor) | **GET** /api/Authentication/logonTicket/list | Get valid LogonTicket
[**AuthenticationGetToken**](AuthenticationApi.md#authenticationgettoken) | **POST** /api/Authentication | This call returns a new authentication token for a authentication request
[**AuthenticationGetTokenArxAssistant**](AuthenticationApi.md#authenticationgettokenarxassistant) | **GET** /api/Authentication/getTokenArxAssistant | This call returns authentication token for Assistant
[**AuthenticationGetTokenByLogonTicket**](AuthenticationApi.md#authenticationgettokenbylogonticket) | **POST** /api/Authentication/getTokenByLogonTicket | This call returns a new authentication token given a logon ticket
[**AuthenticationGetTokenInfoByLogonTicket**](AuthenticationApi.md#authenticationgettokeninfobylogonticket) | **POST** /api/Authentication/getTokenInfoByLogonTicket | This call returns a new authentication token with info given a logon ticket (admin required)
[**AuthenticationGetUserAuthenticationAccessTokenInfo**](AuthenticationApi.md#authenticationgetuserauthenticationaccesstokeninfo) | **POST** /api/Authentication/getUserAuthenticationAccessTokenInfo | This call returns a decoded authentication token for user
[**AuthenticationGetWindowsLogonRedirectUri**](AuthenticationApi.md#authenticationgetwindowslogonredirecturi) | **POST** /api/Authentication/getWindowsLogonRedirectUri | This call returns the provides logon redirect uri for implicit windows authentication
[**AuthenticationInsertLogonTicket**](AuthenticationApi.md#authenticationinsertlogonticket) | **POST** /api/Authentication/logonTicket/insert | Insert LogonTicket
[**AuthenticationPortalLogout**](AuthenticationApi.md#authenticationportallogout) | **POST** /api/Authentication/PortalLogout | Portal logout audit
[**AuthenticationRefresh**](AuthenticationApi.md#authenticationrefresh) | **POST** /api/Authentication/refreshtoken | This call returns a new authentication token by a refresh token string
[**AuthenticationRefreshAuthenticationAccessTokenInfo**](AuthenticationApi.md#authenticationrefreshauthenticationaccesstokeninfo) | **POST** /api/Authentication/refreshUserAuthenticationAccessTokenInfo | This call refreshes and decodes authentication token for user


<a name="authenticationdeletelogonticket"></a>
# **AuthenticationDeleteLogonTicket**
> void AuthenticationDeleteLogonTicket (int? logonTicketId)

Delete LogonTicket

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AuthenticationDeleteLogonTicketExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticationApi();
            var logonTicketId = 56;  // int? | 

            try
            {
                // Delete LogonTicket
                apiInstance.AuthenticationDeleteLogonTicket(logonTicketId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticationDeleteLogonTicket: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **logonTicketId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticationdeletelogonticketadmin"></a>
# **AuthenticationDeleteLogonTicketAdmin**
> void AuthenticationDeleteLogonTicketAdmin (int? logonTicketId)

Delete LogonTicket (admin required)

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AuthenticationDeleteLogonTicketAdminExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticationApi();
            var logonTicketId = 56;  // int? | 

            try
            {
                // Delete LogonTicket (admin required)
                apiInstance.AuthenticationDeleteLogonTicketAdmin(logonTicketId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticationDeleteLogonTicketAdmin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **logonTicketId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticationgetacecsstokenclaims"></a>
# **AuthenticationGetAcecssTokenClaims**
> List<ClaimInfoDTO> AuthenticationGetAcecssTokenClaims ()

This call returns the access token claims

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AuthenticationGetAcecssTokenClaimsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticationApi();

            try
            {
                // This call returns the access token claims
                List&lt;ClaimInfoDTO&gt; result = apiInstance.AuthenticationGetAcecssTokenClaims();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticationGetAcecssTokenClaims: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ClaimInfoDTO>**](ClaimInfoDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticationgetlogonproviderinfo"></a>
# **AuthenticationGetLogonProviderInfo**
> LogonProviderInfoDto AuthenticationGetLogonProviderInfo (string id)

This call returns a specific logon provider by id

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AuthenticationGetLogonProviderInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticationApi();
            var id = id_example;  // string | Logon provider identifier

            try
            {
                // This call returns a specific logon provider by id
                LogonProviderInfoDto result = apiInstance.AuthenticationGetLogonProviderInfo(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticationGetLogonProviderInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Logon provider identifier | 

### Return type

[**LogonProviderInfoDto**](LogonProviderInfoDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticationgetlogonproviderinfolist"></a>
# **AuthenticationGetLogonProviderInfoList**
> List<LogonProviderInfoDto> AuthenticationGetLogonProviderInfoList ()

This call returns the logon provider list

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AuthenticationGetLogonProviderInfoListExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticationApi();

            try
            {
                // This call returns the logon provider list
                List&lt;LogonProviderInfoDto&gt; result = apiInstance.AuthenticationGetLogonProviderInfoList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticationGetLogonProviderInfoList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<LogonProviderInfoDto>**](LogonProviderInfoDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticationgetlogonproviderredirecturi"></a>
# **AuthenticationGetLogonProviderRedirectUri**
> AuthenticationTokenResponseDTO AuthenticationGetLogonProviderRedirectUri (AuthenticationTokenImplicitRequestDTO authenticationTokenImplicitRequest)

This call returns the provides logon redirect uri for implicit logon provider authentication

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AuthenticationGetLogonProviderRedirectUriExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticationApi();
            var authenticationTokenImplicitRequest = new AuthenticationTokenImplicitRequestDTO(); // AuthenticationTokenImplicitRequestDTO | Token request for implicit authentication

            try
            {
                // This call returns the provides logon redirect uri for implicit logon provider authentication
                AuthenticationTokenResponseDTO result = apiInstance.AuthenticationGetLogonProviderRedirectUri(authenticationTokenImplicitRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticationGetLogonProviderRedirectUri: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authenticationTokenImplicitRequest** | [**AuthenticationTokenImplicitRequestDTO**](AuthenticationTokenImplicitRequestDTO.md)| Token request for implicit authentication | 

### Return type

[**AuthenticationTokenResponseDTO**](AuthenticationTokenResponseDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticationgetlogonticketadmin"></a>
# **AuthenticationGetLogonTicketAdmin**
> List<LogonTicketDto> AuthenticationGetLogonTicketAdmin ()

Get LogonTicket list of all users. Included those no longer valid (admin required)

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AuthenticationGetLogonTicketAdminExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticationApi();

            try
            {
                // Get LogonTicket list of all users. Included those no longer valid (admin required)
                List&lt;LogonTicketDto&gt; result = apiInstance.AuthenticationGetLogonTicketAdmin();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticationGetLogonTicketAdmin: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<LogonTicketDto>**](LogonTicketDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticationgetlogonticketadminbylogonticket"></a>
# **AuthenticationGetLogonTicketAdminByLogonTicket**
> LogonTicketDto AuthenticationGetLogonTicketAdminByLogonTicket (string logonTicket)

Get LogonTicket by ticket (admin required)

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AuthenticationGetLogonTicketAdminByLogonTicketExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticationApi();
            var logonTicket = logonTicket_example;  // string | 

            try
            {
                // Get LogonTicket by ticket (admin required)
                LogonTicketDto result = apiInstance.AuthenticationGetLogonTicketAdminByLogonTicket(logonTicket);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticationGetLogonTicketAdminByLogonTicket: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **logonTicket** | **string**|  | 

### Return type

[**LogonTicketDto**](LogonTicketDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticationgetlogonticketbyuserrequestor"></a>
# **AuthenticationGetLogonTicketByUserRequestor**
> List<LogonTicketDto> AuthenticationGetLogonTicketByUserRequestor ()

Get valid LogonTicket

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AuthenticationGetLogonTicketByUserRequestorExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticationApi();

            try
            {
                // Get valid LogonTicket
                List&lt;LogonTicketDto&gt; result = apiInstance.AuthenticationGetLogonTicketByUserRequestor();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticationGetLogonTicketByUserRequestor: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<LogonTicketDto>**](LogonTicketDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticationgettoken"></a>
# **AuthenticationGetToken**
> AuthenticationTokenDTO AuthenticationGetToken (AuthenticationTokenRequestDTO authenticationTokenRequest)

This call returns a new authentication token for a authentication request

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AuthenticationGetTokenExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticationApi();
            var authenticationTokenRequest = new AuthenticationTokenRequestDTO(); // AuthenticationTokenRequestDTO | Token request for authentication

            try
            {
                // This call returns a new authentication token for a authentication request
                AuthenticationTokenDTO result = apiInstance.AuthenticationGetToken(authenticationTokenRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticationGetToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authenticationTokenRequest** | [**AuthenticationTokenRequestDTO**](AuthenticationTokenRequestDTO.md)| Token request for authentication | 

### Return type

[**AuthenticationTokenDTO**](AuthenticationTokenDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticationgettokenarxassistant"></a>
# **AuthenticationGetTokenArxAssistant**
> AuthenticationTokenDTO AuthenticationGetTokenArxAssistant ()

This call returns authentication token for Assistant

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AuthenticationGetTokenArxAssistantExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticationApi();

            try
            {
                // This call returns authentication token for Assistant
                AuthenticationTokenDTO result = apiInstance.AuthenticationGetTokenArxAssistant();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticationGetTokenArxAssistant: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AuthenticationTokenDTO**](AuthenticationTokenDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticationgettokenbylogonticket"></a>
# **AuthenticationGetTokenByLogonTicket**
> AuthenticationTokenDTO AuthenticationGetTokenByLogonTicket (AuthenticationTokenByLogonTicketRequestDTO logonTicketRequest)

This call returns a new authentication token given a logon ticket

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AuthenticationGetTokenByLogonTicketExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticationApi();
            var logonTicketRequest = new AuthenticationTokenByLogonTicketRequestDTO(); // AuthenticationTokenByLogonTicketRequestDTO | Token request for authentication

            try
            {
                // This call returns a new authentication token given a logon ticket
                AuthenticationTokenDTO result = apiInstance.AuthenticationGetTokenByLogonTicket(logonTicketRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticationGetTokenByLogonTicket: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **logonTicketRequest** | [**AuthenticationTokenByLogonTicketRequestDTO**](AuthenticationTokenByLogonTicketRequestDTO.md)| Token request for authentication | 

### Return type

[**AuthenticationTokenDTO**](AuthenticationTokenDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticationgettokeninfobylogonticket"></a>
# **AuthenticationGetTokenInfoByLogonTicket**
> AccessTokenInfoDTO AuthenticationGetTokenInfoByLogonTicket (AuthenticationTokenByLogonTicketRequestDTO logonTicketRequest)

This call returns a new authentication token with info given a logon ticket (admin required)

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AuthenticationGetTokenInfoByLogonTicketExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticationApi();
            var logonTicketRequest = new AuthenticationTokenByLogonTicketRequestDTO(); // AuthenticationTokenByLogonTicketRequestDTO | 

            try
            {
                // This call returns a new authentication token with info given a logon ticket (admin required)
                AccessTokenInfoDTO result = apiInstance.AuthenticationGetTokenInfoByLogonTicket(logonTicketRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticationGetTokenInfoByLogonTicket: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **logonTicketRequest** | [**AuthenticationTokenByLogonTicketRequestDTO**](AuthenticationTokenByLogonTicketRequestDTO.md)|  | 

### Return type

[**AccessTokenInfoDTO**](AccessTokenInfoDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticationgetuserauthenticationaccesstokeninfo"></a>
# **AuthenticationGetUserAuthenticationAccessTokenInfo**
> AccessTokenInfoDTO AuthenticationGetUserAuthenticationAccessTokenInfo (AuthenticationTokenRequestDTO authenticationTokenRequest)

This call returns a decoded authentication token for user

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AuthenticationGetUserAuthenticationAccessTokenInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticationApi();
            var authenticationTokenRequest = new AuthenticationTokenRequestDTO(); // AuthenticationTokenRequestDTO | Token request for authentication

            try
            {
                // This call returns a decoded authentication token for user
                AccessTokenInfoDTO result = apiInstance.AuthenticationGetUserAuthenticationAccessTokenInfo(authenticationTokenRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticationGetUserAuthenticationAccessTokenInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authenticationTokenRequest** | [**AuthenticationTokenRequestDTO**](AuthenticationTokenRequestDTO.md)| Token request for authentication | 

### Return type

[**AccessTokenInfoDTO**](AccessTokenInfoDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticationgetwindowslogonredirecturi"></a>
# **AuthenticationGetWindowsLogonRedirectUri**
> AuthenticationTokenResponseDTO AuthenticationGetWindowsLogonRedirectUri (AuthenticationTokenImplicitRequestDTO authenticationTokenImplicitRequestDto)

This call returns the provides logon redirect uri for implicit windows authentication

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AuthenticationGetWindowsLogonRedirectUriExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticationApi();
            var authenticationTokenImplicitRequestDto = new AuthenticationTokenImplicitRequestDTO(); // AuthenticationTokenImplicitRequestDTO | Token request for implicit authentication

            try
            {
                // This call returns the provides logon redirect uri for implicit windows authentication
                AuthenticationTokenResponseDTO result = apiInstance.AuthenticationGetWindowsLogonRedirectUri(authenticationTokenImplicitRequestDto);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticationGetWindowsLogonRedirectUri: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authenticationTokenImplicitRequestDto** | [**AuthenticationTokenImplicitRequestDTO**](AuthenticationTokenImplicitRequestDTO.md)| Token request for implicit authentication | 

### Return type

[**AuthenticationTokenResponseDTO**](AuthenticationTokenResponseDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticationinsertlogonticket"></a>
# **AuthenticationInsertLogonTicket**
> LogonTicketDto AuthenticationInsertLogonTicket (LogonTicketRequestDto ticketRequest)

Insert LogonTicket

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AuthenticationInsertLogonTicketExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticationApi();
            var ticketRequest = new LogonTicketRequestDto(); // LogonTicketRequestDto | 

            try
            {
                // Insert LogonTicket
                LogonTicketDto result = apiInstance.AuthenticationInsertLogonTicket(ticketRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticationInsertLogonTicket: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ticketRequest** | [**LogonTicketRequestDto**](LogonTicketRequestDto.md)|  | 

### Return type

[**LogonTicketDto**](LogonTicketDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticationportallogout"></a>
# **AuthenticationPortalLogout**
> void AuthenticationPortalLogout (PortalLogoutRequestDto portalLogoutRequest)

Portal logout audit

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AuthenticationPortalLogoutExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticationApi();
            var portalLogoutRequest = new PortalLogoutRequestDto(); // PortalLogoutRequestDto | 

            try
            {
                // Portal logout audit
                apiInstance.AuthenticationPortalLogout(portalLogoutRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticationPortalLogout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **portalLogoutRequest** | [**PortalLogoutRequestDto**](PortalLogoutRequestDto.md)|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticationrefresh"></a>
# **AuthenticationRefresh**
> AuthenticationTokenDTO AuthenticationRefresh (RefreshTokenRequestDTO refreshTokenRequest)

This call returns a new authentication token by a refresh token string

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AuthenticationRefreshExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticationApi();
            var refreshTokenRequest = new RefreshTokenRequestDTO(); // RefreshTokenRequestDTO | Token request for authentication refresh

            try
            {
                // This call returns a new authentication token by a refresh token string
                AuthenticationTokenDTO result = apiInstance.AuthenticationRefresh(refreshTokenRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticationRefresh: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **refreshTokenRequest** | [**RefreshTokenRequestDTO**](RefreshTokenRequestDTO.md)| Token request for authentication refresh | 

### Return type

[**AuthenticationTokenDTO**](AuthenticationTokenDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticationrefreshauthenticationaccesstokeninfo"></a>
# **AuthenticationRefreshAuthenticationAccessTokenInfo**
> AccessTokenInfoDTO AuthenticationRefreshAuthenticationAccessTokenInfo (AuthenticationRefreshTokenRequestDTO authenticationRefreshTokenRequest)

This call refreshes and decodes authentication token for user

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AuthenticationRefreshAuthenticationAccessTokenInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticationApi();
            var authenticationRefreshTokenRequest = new AuthenticationRefreshTokenRequestDTO(); // AuthenticationRefreshTokenRequestDTO | Authetication refresh token request

            try
            {
                // This call refreshes and decodes authentication token for user
                AccessTokenInfoDTO result = apiInstance.AuthenticationRefreshAuthenticationAccessTokenInfo(authenticationRefreshTokenRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticationRefreshAuthenticationAccessTokenInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authenticationRefreshTokenRequest** | [**AuthenticationRefreshTokenRequestDTO**](AuthenticationRefreshTokenRequestDTO.md)| Authetication refresh token request | 

### Return type

[**AccessTokenInfoDTO**](AccessTokenInfoDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


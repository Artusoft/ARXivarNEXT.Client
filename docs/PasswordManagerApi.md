# ARXivarNEXT.Client.Api.PasswordManagerApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PasswordManagerChangePassword**](PasswordManagerApi.md#passwordmanagerchangepassword) | **POST** /api/PasswordManager/ChangePassword | This call changes the password of connected user
[**PasswordManagerChangePasswordUnAuthorize**](PasswordManagerApi.md#passwordmanagerchangepasswordunauthorize) | **POST** /api/PasswordManager/ChangePasswordUnAuthorize | This call changes the password of connected user
[**PasswordManagerGet**](PasswordManagerApi.md#passwordmanagerget) | **GET** /api/PasswordManager/ChangePasswordConstraints | This call returns the change password options
[**PasswordManagerGetPasswordRetrieveMode**](PasswordManagerApi.md#passwordmanagergetpasswordretrievemode) | **GET** /api/PasswordManager/PasswordRetrieveMode | This call returns the user password retrieve mode
[**PasswordManagerRetrievePassword**](PasswordManagerApi.md#passwordmanagerretrievepassword) | **POST** /api/PasswordManager/RetrievePassword | This call retrieves user password according to server configuration


<a name="passwordmanagerchangepassword"></a>
# **PasswordManagerChangePassword**
> void PasswordManagerChangePassword (ChangePasswordRequestDTO passwordRequest)

This call changes the password of connected user

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class PasswordManagerChangePasswordExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PasswordManagerApi();
            var passwordRequest = new ChangePasswordRequestDTO(); // ChangePasswordRequestDTO | Password request to change

            try
            {
                // This call changes the password of connected user
                apiInstance.PasswordManagerChangePassword(passwordRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PasswordManagerApi.PasswordManagerChangePassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **passwordRequest** | [**ChangePasswordRequestDTO**](ChangePasswordRequestDTO.md)| Password request to change | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="passwordmanagerchangepasswordunauthorize"></a>
# **PasswordManagerChangePasswordUnAuthorize**
> void PasswordManagerChangePasswordUnAuthorize (ChangePasswordRequestUnAuthorizeDTO passwordRequest)

This call changes the password of connected user

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class PasswordManagerChangePasswordUnAuthorizeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PasswordManagerApi();
            var passwordRequest = new ChangePasswordRequestUnAuthorizeDTO(); // ChangePasswordRequestUnAuthorizeDTO | Password request to change

            try
            {
                // This call changes the password of connected user
                apiInstance.PasswordManagerChangePasswordUnAuthorize(passwordRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PasswordManagerApi.PasswordManagerChangePasswordUnAuthorize: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **passwordRequest** | [**ChangePasswordRequestUnAuthorizeDTO**](ChangePasswordRequestUnAuthorizeDTO.md)| Password request to change | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="passwordmanagerget"></a>
# **PasswordManagerGet**
> Object PasswordManagerGet ()

This call returns the change password options

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class PasswordManagerGetExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PasswordManagerApi();

            try
            {
                // This call returns the change password options
                Object result = apiInstance.PasswordManagerGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PasswordManagerApi.PasswordManagerGet: " + e.Message );
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

<a name="passwordmanagergetpasswordretrievemode"></a>
# **PasswordManagerGetPasswordRetrieveMode**
> string PasswordManagerGetPasswordRetrieveMode ()

This call returns the user password retrieve mode

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class PasswordManagerGetPasswordRetrieveModeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PasswordManagerApi();

            try
            {
                // This call returns the user password retrieve mode
                string result = apiInstance.PasswordManagerGetPasswordRetrieveMode();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PasswordManagerApi.PasswordManagerGetPasswordRetrieveMode: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="passwordmanagerretrievepassword"></a>
# **PasswordManagerRetrievePassword**
> string PasswordManagerRetrievePassword (RetrievePasswordRequestDTO retrievePasswordRequest)

This call retrieves user password according to server configuration

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class PasswordManagerRetrievePasswordExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PasswordManagerApi();
            var retrievePasswordRequest = new RetrievePasswordRequestDTO(); // RetrievePasswordRequestDTO | Retrieve password option

            try
            {
                // This call retrieves user password according to server configuration
                string result = apiInstance.PasswordManagerRetrievePassword(retrievePasswordRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PasswordManagerApi.PasswordManagerRetrievePassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **retrievePasswordRequest** | [**RetrievePasswordRequestDTO**](RetrievePasswordRequestDTO.md)| Retrieve password option | 

### Return type

**string**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


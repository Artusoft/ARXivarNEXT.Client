# ARXivarNEXT.Client.Api.UsersLangApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsersLangGet**](UsersLangApi.md#userslangget) | **POST** /api/UsersLang | This call retrieves the default language for a user by the given username


<a name="userslangget"></a>
# **UsersLangGet**
> string UsersLangGet (UserLangDto langDto)

This call retrieves the default language for a user by the given username

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class UsersLangGetExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersLangApi();
            var langDto = new UserLangDto(); // UserLangDto | Dto that contains the username for the language

            try
            {
                // This call retrieves the default language for a user by the given username
                string result = apiInstance.UsersLangGet(langDto);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersLangApi.UsersLangGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **langDto** | [**UserLangDto**](UserLangDto.md)| Dto that contains the username for the language | 

### Return type

**string**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


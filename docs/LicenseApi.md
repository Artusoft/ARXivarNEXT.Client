# ARXivarNEXT.Client.Api.LicenseApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LicenseGetLoadedlicense**](LicenseApi.md#licensegetloadedlicense) | **GET** /api/License/LoadedLicense | Get the current loaded license (Admin permission required)
[**LicenseLicenseIsLoaded**](LicenseApi.md#licenselicenseisloaded) | **GET** /api/License/IsLoaded | Checks if license is loaded (Admin permission required)


<a name="licensegetloadedlicense"></a>
# **LicenseGetLoadedlicense**
> ServerLicense LicenseGetLoadedlicense ()

Get the current loaded license (Admin permission required)

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class LicenseGetLoadedlicenseExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LicenseApi();

            try
            {
                // Get the current loaded license (Admin permission required)
                ServerLicense result = apiInstance.LicenseGetLoadedlicense();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseApi.LicenseGetLoadedlicense: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ServerLicense**](ServerLicense.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="licenselicenseisloaded"></a>
# **LicenseLicenseIsLoaded**
> bool? LicenseLicenseIsLoaded ()

Checks if license is loaded (Admin permission required)

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class LicenseLicenseIsLoadedExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LicenseApi();

            try
            {
                // Checks if license is loaded (Admin permission required)
                bool? result = apiInstance.LicenseLicenseIsLoaded();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseApi.LicenseLicenseIsLoaded: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**bool?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


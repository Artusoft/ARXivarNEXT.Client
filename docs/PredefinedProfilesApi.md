# ARXivarNEXT.Client.Api.PredefinedProfilesApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PredefinedProfilesClone**](PredefinedProfilesApi.md#predefinedprofilesclone) | **POST** /api/PredefinedProfiles/{predefinedProfileId}/clone | This call clones a predefined profile
[**PredefinedProfilesDeletePredefinedProfile**](PredefinedProfilesApi.md#predefinedprofilesdeletepredefinedprofile) | **DELETE** /api/PredefinedProfiles/{predefinedProfileId} | This call deletes a predefined profile
[**PredefinedProfilesGet**](PredefinedProfilesApi.md#predefinedprofilesget) | **GET** /api/PredefinedProfiles | This call returns all the predefined profiles
[**PredefinedProfilesGetById**](PredefinedProfilesApi.md#predefinedprofilesgetbyid) | **GET** /api/PredefinedProfiles/{predefinedProfileId} | This call returns a predefined profile by its id
[**PredefinedProfilesGetNew**](PredefinedProfilesApi.md#predefinedprofilesgetnew) | **GET** /api/PredefinedProfiles/new | This call returns a new predefined profile template
[**PredefinedProfilesGetProfileSchemaByPredefinedProfileId**](PredefinedProfilesApi.md#predefinedprofilesgetprofileschemabypredefinedprofileid) | **POST** /api/PredefinedProfiles/{predefinedProfileId}/profileSchema | This call returns the profile schema by a predefined profile
[**PredefinedProfilesPermissionsById**](PredefinedProfilesApi.md#predefinedprofilespermissionsbyid) | **GET** /api/PredefinedProfiles/{predefinedProfileId}/Permissions | This call returns the permissions for a predefiend profile
[**PredefinedProfilesUpdatePredefinedProfile**](PredefinedProfilesApi.md#predefinedprofilesupdatepredefinedprofile) | **PUT** /api/PredefinedProfiles/{predefinedProfileId} | This call updates a predefined profile
[**PredefinedProfilesWritePermissionsById**](PredefinedProfilesApi.md#predefinedprofileswritepermissionsbyid) | **POST** /api/PredefinedProfiles/{predefinedProfileId}/Permissions | This call updates permissions for a predefined profile
[**PredefinedProfilesWritePredefinedProfile**](PredefinedProfilesApi.md#predefinedprofileswritepredefinedprofile) | **POST** /api/PredefinedProfiles | This call creates a predefined profile


<a name="predefinedprofilesclone"></a>
# **PredefinedProfilesClone**
> void PredefinedProfilesClone (int? predefinedProfileId, string name)

This call clones a predefined profile

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class PredefinedProfilesCloneExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PredefinedProfilesApi();
            var predefinedProfileId = 56;  // int? | Predefined profile identifier to clone
            var name = name_example;  // string | Name of the cloned predefined profile

            try
            {
                // This call clones a predefined profile
                apiInstance.PredefinedProfilesClone(predefinedProfileId, name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PredefinedProfilesApi.PredefinedProfilesClone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **predefinedProfileId** | **int?**| Predefined profile identifier to clone | 
 **name** | **string**| Name of the cloned predefined profile | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="predefinedprofilesdeletepredefinedprofile"></a>
# **PredefinedProfilesDeletePredefinedProfile**
> void PredefinedProfilesDeletePredefinedProfile (int? predefinedProfileId)

This call deletes a predefined profile

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class PredefinedProfilesDeletePredefinedProfileExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PredefinedProfilesApi();
            var predefinedProfileId = 56;  // int? | Predefined profile identifier

            try
            {
                // This call deletes a predefined profile
                apiInstance.PredefinedProfilesDeletePredefinedProfile(predefinedProfileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PredefinedProfilesApi.PredefinedProfilesDeletePredefinedProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **predefinedProfileId** | **int?**| Predefined profile identifier | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="predefinedprofilesget"></a>
# **PredefinedProfilesGet**
> List<PredefinedProfileDTO> PredefinedProfilesGet ()

This call returns all the predefined profiles

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class PredefinedProfilesGetExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PredefinedProfilesApi();

            try
            {
                // This call returns all the predefined profiles
                List&lt;PredefinedProfileDTO&gt; result = apiInstance.PredefinedProfilesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PredefinedProfilesApi.PredefinedProfilesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<PredefinedProfileDTO>**](PredefinedProfileDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="predefinedprofilesgetbyid"></a>
# **PredefinedProfilesGetById**
> PredefinedProfileDTO PredefinedProfilesGetById (int? predefinedProfileId)

This call returns a predefined profile by its id

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class PredefinedProfilesGetByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PredefinedProfilesApi();
            var predefinedProfileId = 56;  // int? | Predefined profile identifier

            try
            {
                // This call returns a predefined profile by its id
                PredefinedProfileDTO result = apiInstance.PredefinedProfilesGetById(predefinedProfileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PredefinedProfilesApi.PredefinedProfilesGetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **predefinedProfileId** | **int?**| Predefined profile identifier | 

### Return type

[**PredefinedProfileDTO**](PredefinedProfileDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="predefinedprofilesgetnew"></a>
# **PredefinedProfilesGetNew**
> PredefinedProfileDTO PredefinedProfilesGetNew ()

This call returns a new predefined profile template

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class PredefinedProfilesGetNewExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PredefinedProfilesApi();

            try
            {
                // This call returns a new predefined profile template
                PredefinedProfileDTO result = apiInstance.PredefinedProfilesGetNew();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PredefinedProfilesApi.PredefinedProfilesGetNew: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PredefinedProfileDTO**](PredefinedProfileDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="predefinedprofilesgetprofileschemabypredefinedprofileid"></a>
# **PredefinedProfilesGetProfileSchemaByPredefinedProfileId**
> PredefinedProfileSchemaDTO PredefinedProfilesGetProfileSchemaByPredefinedProfileId (int? predefinedProfileId, ProfileDTO profile = null)

This call returns the profile schema by a predefined profile

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class PredefinedProfilesGetProfileSchemaByPredefinedProfileIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PredefinedProfilesApi();
            var predefinedProfileId = 56;  // int? | Predefined profile identifier
            var profile = new ProfileDTO(); // ProfileDTO |  (optional) 

            try
            {
                // This call returns the profile schema by a predefined profile
                PredefinedProfileSchemaDTO result = apiInstance.PredefinedProfilesGetProfileSchemaByPredefinedProfileId(predefinedProfileId, profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PredefinedProfilesApi.PredefinedProfilesGetProfileSchemaByPredefinedProfileId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **predefinedProfileId** | **int?**| Predefined profile identifier | 
 **profile** | [**ProfileDTO**](ProfileDTO.md)|  | [optional] 

### Return type

[**PredefinedProfileSchemaDTO**](PredefinedProfileSchemaDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="predefinedprofilespermissionsbyid"></a>
# **PredefinedProfilesPermissionsById**
> PermissionsDTO PredefinedProfilesPermissionsById (int? predefinedProfileId)

This call returns the permissions for a predefiend profile

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class PredefinedProfilesPermissionsByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PredefinedProfilesApi();
            var predefinedProfileId = 56;  // int? | Predefined profile identifier

            try
            {
                // This call returns the permissions for a predefiend profile
                PermissionsDTO result = apiInstance.PredefinedProfilesPermissionsById(predefinedProfileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PredefinedProfilesApi.PredefinedProfilesPermissionsById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **predefinedProfileId** | **int?**| Predefined profile identifier | 

### Return type

[**PermissionsDTO**](PermissionsDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="predefinedprofilesupdatepredefinedprofile"></a>
# **PredefinedProfilesUpdatePredefinedProfile**
> void PredefinedProfilesUpdatePredefinedProfile (int? predefinedProfileId, PredefinedProfileDTO predefinedprofiledto = null)

This call updates a predefined profile

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class PredefinedProfilesUpdatePredefinedProfileExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PredefinedProfilesApi();
            var predefinedProfileId = 56;  // int? | Predefined profile identifier
            var predefinedprofiledto = new PredefinedProfileDTO(); // PredefinedProfileDTO |  (optional) 

            try
            {
                // This call updates a predefined profile
                apiInstance.PredefinedProfilesUpdatePredefinedProfile(predefinedProfileId, predefinedprofiledto);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PredefinedProfilesApi.PredefinedProfilesUpdatePredefinedProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **predefinedProfileId** | **int?**| Predefined profile identifier | 
 **predefinedprofiledto** | [**PredefinedProfileDTO**](PredefinedProfileDTO.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="predefinedprofileswritepermissionsbyid"></a>
# **PredefinedProfilesWritePermissionsById**
> void PredefinedProfilesWritePermissionsById (int? predefinedProfileId, PermissionsDTO permissions)

This call updates permissions for a predefined profile

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class PredefinedProfilesWritePermissionsByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PredefinedProfilesApi();
            var predefinedProfileId = 56;  // int? | Predefined profile identifier
            var permissions = new PermissionsDTO(); // PermissionsDTO | Permissions to update

            try
            {
                // This call updates permissions for a predefined profile
                apiInstance.PredefinedProfilesWritePermissionsById(predefinedProfileId, permissions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PredefinedProfilesApi.PredefinedProfilesWritePermissionsById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **predefinedProfileId** | **int?**| Predefined profile identifier | 
 **permissions** | [**PermissionsDTO**](PermissionsDTO.md)| Permissions to update | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="predefinedprofileswritepredefinedprofile"></a>
# **PredefinedProfilesWritePredefinedProfile**
> void PredefinedProfilesWritePredefinedProfile (PredefinedProfileDTO predefinedprofiledto = null)

This call creates a predefined profile

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class PredefinedProfilesWritePredefinedProfileExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PredefinedProfilesApi();
            var predefinedprofiledto = new PredefinedProfileDTO(); // PredefinedProfileDTO |  (optional) 

            try
            {
                // This call creates a predefined profile
                apiInstance.PredefinedProfilesWritePredefinedProfile(predefinedprofiledto);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PredefinedProfilesApi.PredefinedProfilesWritePredefinedProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **predefinedprofiledto** | [**PredefinedProfileDTO**](PredefinedProfileDTO.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


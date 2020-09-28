# ARXivarNEXT.Client.Api.ProfilePermissionsApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProfilePermissionsGetPermissionByDocNumber**](ProfilePermissionsApi.md#profilepermissionsgetpermissionbydocnumber) | **GET** /api/ProfilePermissions/{docnumber} | This call returns all additional or exclusive permissions by document identifier
[**ProfilePermissionsSetPermission**](ProfilePermissionsApi.md#profilepermissionssetpermission) | **POST** /api/ProfilePermissions/{docnumber}/Permissions | This call save all additional or exclusive permissions


<a name="profilepermissionsgetpermissionbydocnumber"></a>
# **ProfilePermissionsGetPermissionByDocNumber**
> SingleProfilePermissionsDTO ProfilePermissionsGetPermissionByDocNumber (int? docnumber)

This call returns all additional or exclusive permissions by document identifier

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilePermissionsGetPermissionByDocNumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilePermissionsApi();
            var docnumber = 56;  // int? | Document Identifier

            try
            {
                // This call returns all additional or exclusive permissions by document identifier
                SingleProfilePermissionsDTO result = apiInstance.ProfilePermissionsGetPermissionByDocNumber(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilePermissionsApi.ProfilePermissionsGetPermissionByDocNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| Document Identifier | 

### Return type

[**SingleProfilePermissionsDTO**](SingleProfilePermissionsDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="profilepermissionssetpermission"></a>
# **ProfilePermissionsSetPermission**
> void ProfilePermissionsSetPermission (int? docnumber, SingleProfilePermissionsDTO permissions)

This call save all additional or exclusive permissions

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProfilePermissionsSetPermissionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProfilePermissionsApi();
            var docnumber = 56;  // int? | Document Identifier
            var permissions = new SingleProfilePermissionsDTO(); // SingleProfilePermissionsDTO | Permissions to save

            try
            {
                // This call save all additional or exclusive permissions
                apiInstance.ProfilePermissionsSetPermission(docnumber, permissions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProfilePermissionsApi.ProfilePermissionsSetPermission: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| Document Identifier | 
 **permissions** | [**SingleProfilePermissionsDTO**](SingleProfilePermissionsDTO.md)| Permissions to save | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


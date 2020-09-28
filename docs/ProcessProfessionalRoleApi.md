# ARXivarNEXT.Client.Api.ProcessProfessionalRoleApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProcessProfessionalRoleGetUsersForProfessionalRoleSelection**](ProcessProfessionalRoleApi.md#processprofessionalrolegetusersforprofessionalroleselection) | **GET** /api/ProcessProfessionalRoleInfo/{professionalRoleId}/{processId} | This call returns the users associated with a professional role of process
[**ProcessProfessionalRoleSetUsersForProfessionalRole**](ProcessProfessionalRoleApi.md#processprofessionalrolesetusersforprofessionalrole) | **POST** /api/ProcessProfessionalRoleInfo/{professionalRoleId}/{processId}/{userId} | This call inserts a new professional role associated with a process


<a name="processprofessionalrolegetusersforprofessionalroleselection"></a>
# **ProcessProfessionalRoleGetUsersForProfessionalRoleSelection**
> List<UserCompleteDTO> ProcessProfessionalRoleGetUsersForProfessionalRoleSelection (int? processId, int? professionalRoleId)

This call returns the users associated with a professional role of process

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProcessProfessionalRoleGetUsersForProfessionalRoleSelectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProcessProfessionalRoleApi();
            var processId = 56;  // int? | Process Identifier
            var professionalRoleId = 56;  // int? | Professional Role Idenfier

            try
            {
                // This call returns the users associated with a professional role of process
                List&lt;UserCompleteDTO&gt; result = apiInstance.ProcessProfessionalRoleGetUsersForProfessionalRoleSelection(processId, professionalRoleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessProfessionalRoleApi.ProcessProfessionalRoleGetUsersForProfessionalRoleSelection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **int?**| Process Identifier | 
 **professionalRoleId** | **int?**| Professional Role Idenfier | 

### Return type

[**List<UserCompleteDTO>**](UserCompleteDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processprofessionalrolesetusersforprofessionalrole"></a>
# **ProcessProfessionalRoleSetUsersForProfessionalRole**
> void ProcessProfessionalRoleSetUsersForProfessionalRole (int? processId, int? professionalRoleId, int? userId)

This call inserts a new professional role associated with a process

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProcessProfessionalRoleSetUsersForProfessionalRoleExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProcessProfessionalRoleApi();
            var processId = 56;  // int? | Process Identifier
            var professionalRoleId = 56;  // int? | Porfessional Role Idenfier
            var userId = 56;  // int? | User Identifier

            try
            {
                // This call inserts a new professional role associated with a process
                apiInstance.ProcessProfessionalRoleSetUsersForProfessionalRole(processId, professionalRoleId, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessProfessionalRoleApi.ProcessProfessionalRoleSetUsersForProfessionalRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **int?**| Process Identifier | 
 **professionalRoleId** | **int?**| Porfessional Role Idenfier | 
 **userId** | **int?**| User Identifier | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


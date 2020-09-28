# ARXivarNEXT.Client.Api.DelegationApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DelegationDeactivate**](DelegationApi.md#delegationdeactivate) | **PUT** /api/Delegation/{id}/setInactive | This call deactivate an active delegation
[**DelegationGet**](DelegationApi.md#delegationget) | **GET** /api/Delegation/{onlyActive} | This call returns all the delegation for the connected user or all delegation for user of type admin
[**DelegationGetById**](DelegationApi.md#delegationgetbyid) | **GET** /api/Delegation/byId/{id} | This call returns the delegation by its id
[**DelegationInsert**](DelegationApi.md#delegationinsert) | **POST** /api/Delegation | This call insert new delegation
[**DelegationUpdate**](DelegationApi.md#delegationupdate) | **PUT** /api/Delegation | This call update a delegation


<a name="delegationdeactivate"></a>
# **DelegationDeactivate**
> void DelegationDeactivate (int? id)

This call deactivate an active delegation

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DelegationDeactivateExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DelegationApi();
            var id = 56;  // int? | Id of the delegation

            try
            {
                // This call deactivate an active delegation
                apiInstance.DelegationDeactivate(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DelegationApi.DelegationDeactivate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the delegation | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="delegationget"></a>
# **DelegationGet**
> List<DelegationDTO> DelegationGet (bool? onlyActive)

This call returns all the delegation for the connected user or all delegation for user of type admin

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DelegationGetExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DelegationApi();
            var onlyActive = true;  // bool? | Get only active delegation

            try
            {
                // This call returns all the delegation for the connected user or all delegation for user of type admin
                List&lt;DelegationDTO&gt; result = apiInstance.DelegationGet(onlyActive);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DelegationApi.DelegationGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **onlyActive** | **bool?**| Get only active delegation | 

### Return type

[**List<DelegationDTO>**](DelegationDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="delegationgetbyid"></a>
# **DelegationGetById**
> DelegationDTO DelegationGetById (int? id)

This call returns the delegation by its id

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DelegationGetByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DelegationApi();
            var id = 56;  // int? | Id of the delegation

            try
            {
                // This call returns the delegation by its id
                DelegationDTO result = apiInstance.DelegationGetById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DelegationApi.DelegationGetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Id of the delegation | 

### Return type

[**DelegationDTO**](DelegationDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="delegationinsert"></a>
# **DelegationInsert**
> void DelegationInsert (DelegationDTO delegation)

This call insert new delegation

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DelegationInsertExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DelegationApi();
            var delegation = new DelegationDTO(); // DelegationDTO | 

            try
            {
                // This call insert new delegation
                apiInstance.DelegationInsert(delegation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DelegationApi.DelegationInsert: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **delegation** | [**DelegationDTO**](DelegationDTO.md)|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="delegationupdate"></a>
# **DelegationUpdate**
> void DelegationUpdate (DelegationDTO delegation)

This call update a delegation

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DelegationUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DelegationApi();
            var delegation = new DelegationDTO(); // DelegationDTO | 

            try
            {
                // This call update a delegation
                apiInstance.DelegationUpdate(delegation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DelegationApi.DelegationUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **delegation** | [**DelegationDTO**](DelegationDTO.md)|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


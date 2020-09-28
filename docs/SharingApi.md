# ARXivarNEXT.Client.Api.SharingApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SharingDeleteSharing**](SharingApi.md#sharingdeletesharing) | **DELETE** /api/Sharing/{sharingId} | 
[**SharingGetOperations**](SharingApi.md#sharinggetoperations) | **GET** /api/Sharing/Operations/{sharingId} | 
[**SharingGetSharing**](SharingApi.md#sharinggetsharing) | **GET** /api/Sharing/ForUpdate/{sharingId} | 
[**SharingGetSharingForShow**](SharingApi.md#sharinggetsharingforshow) | **GET** /api/Sharing/{sharingId} | 
[**SharingGetSharings**](SharingApi.md#sharinggetsharings) | **GET** /api/Sharing | 
[**SharingGetSharingsByDocnumber**](SharingApi.md#sharinggetsharingsbydocnumber) | **GET** /api/Sharing/ByDocnumber/{docnumber} | 
[**SharingInsertSharing**](SharingApi.md#sharinginsertsharing) | **POST** /api/Sharing | 
[**SharingNewByBusinessUnitAndDocumentTypeId**](SharingApi.md#sharingnewbybusinessunitanddocumenttypeid) | **POST** /api/Sharing/NewByBusinessUnitAndDocumentType | 
[**SharingReprocessSharing**](SharingApi.md#sharingreprocesssharing) | **PUT** /api/Sharing/Reprocess/{sharingId} | 
[**SharingUpdateSharing**](SharingApi.md#sharingupdatesharing) | **PUT** /api/Sharing | 
[**SharingUserConnectedIsConfigurationRole**](SharingApi.md#sharinguserconnectedisconfigurationrole) | **GET** /api/Sharing/Permissions/IsConfigurationRole | 
[**SharingUserConnectedIsSharingManager**](SharingApi.md#sharinguserconnectedissharingmanager) | **GET** /api/Sharing/Permissions/IsSharingManager | 


<a name="sharingdeletesharing"></a>
# **SharingDeleteSharing**
> void SharingDeleteSharing (string sharingId)



### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SharingDeleteSharingExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SharingApi();
            var sharingId = sharingId_example;  // string | 

            try
            {
                apiInstance.SharingDeleteSharing(sharingId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SharingApi.SharingDeleteSharing: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sharingId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sharinggetoperations"></a>
# **SharingGetOperations**
> List<SharingOperationDTO> SharingGetOperations (string sharingId)



### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SharingGetOperationsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SharingApi();
            var sharingId = sharingId_example;  // string | 

            try
            {
                List&lt;SharingOperationDTO&gt; result = apiInstance.SharingGetOperations(sharingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SharingApi.SharingGetOperations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sharingId** | **string**|  | 

### Return type

[**List<SharingOperationDTO>**](SharingOperationDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sharinggetsharing"></a>
# **SharingGetSharing**
> SharingDTO SharingGetSharing (string sharingId)



### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SharingGetSharingExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SharingApi();
            var sharingId = sharingId_example;  // string | 

            try
            {
                SharingDTO result = apiInstance.SharingGetSharing(sharingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SharingApi.SharingGetSharing: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sharingId** | **string**|  | 

### Return type

[**SharingDTO**](SharingDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sharinggetsharingforshow"></a>
# **SharingGetSharingForShow**
> SharingDTO SharingGetSharingForShow (string sharingId)



### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SharingGetSharingForShowExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SharingApi();
            var sharingId = sharingId_example;  // string | 

            try
            {
                SharingDTO result = apiInstance.SharingGetSharingForShow(sharingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SharingApi.SharingGetSharingForShow: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sharingId** | **string**|  | 

### Return type

[**SharingDTO**](SharingDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sharinggetsharings"></a>
# **SharingGetSharings**
> List<SharingDTO> SharingGetSharings ()



### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SharingGetSharingsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SharingApi();

            try
            {
                List&lt;SharingDTO&gt; result = apiInstance.SharingGetSharings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SharingApi.SharingGetSharings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<SharingDTO>**](SharingDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sharinggetsharingsbydocnumber"></a>
# **SharingGetSharingsByDocnumber**
> List<SharingDTO> SharingGetSharingsByDocnumber (int? docnumber)



### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SharingGetSharingsByDocnumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SharingApi();
            var docnumber = 56;  // int? | 

            try
            {
                List&lt;SharingDTO&gt; result = apiInstance.SharingGetSharingsByDocnumber(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SharingApi.SharingGetSharingsByDocnumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**|  | 

### Return type

[**List<SharingDTO>**](SharingDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sharinginsertsharing"></a>
# **SharingInsertSharing**
> SharingDTO SharingInsertSharing (SharingDTO sharing)



### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SharingInsertSharingExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SharingApi();
            var sharing = new SharingDTO(); // SharingDTO | 

            try
            {
                SharingDTO result = apiInstance.SharingInsertSharing(sharing);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SharingApi.SharingInsertSharing: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sharing** | [**SharingDTO**](SharingDTO.md)|  | 

### Return type

[**SharingDTO**](SharingDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sharingnewbybusinessunitanddocumenttypeid"></a>
# **SharingNewByBusinessUnitAndDocumentTypeId**
> SharingDTO SharingNewByBusinessUnitAndDocumentTypeId (GetNewSharingRequestDTO sharingRequest)



### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SharingNewByBusinessUnitAndDocumentTypeIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SharingApi();
            var sharingRequest = new GetNewSharingRequestDTO(); // GetNewSharingRequestDTO | 

            try
            {
                SharingDTO result = apiInstance.SharingNewByBusinessUnitAndDocumentTypeId(sharingRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SharingApi.SharingNewByBusinessUnitAndDocumentTypeId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sharingRequest** | [**GetNewSharingRequestDTO**](GetNewSharingRequestDTO.md)|  | 

### Return type

[**SharingDTO**](SharingDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sharingreprocesssharing"></a>
# **SharingReprocessSharing**
> SharingDTO SharingReprocessSharing (string sharingId)



### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SharingReprocessSharingExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SharingApi();
            var sharingId = sharingId_example;  // string | 

            try
            {
                SharingDTO result = apiInstance.SharingReprocessSharing(sharingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SharingApi.SharingReprocessSharing: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sharingId** | **string**|  | 

### Return type

[**SharingDTO**](SharingDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sharingupdatesharing"></a>
# **SharingUpdateSharing**
> SharingDTO SharingUpdateSharing (SharingDTO sharing)



### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SharingUpdateSharingExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SharingApi();
            var sharing = new SharingDTO(); // SharingDTO | 

            try
            {
                SharingDTO result = apiInstance.SharingUpdateSharing(sharing);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SharingApi.SharingUpdateSharing: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sharing** | [**SharingDTO**](SharingDTO.md)|  | 

### Return type

[**SharingDTO**](SharingDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sharinguserconnectedisconfigurationrole"></a>
# **SharingUserConnectedIsConfigurationRole**
> bool? SharingUserConnectedIsConfigurationRole ()



### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SharingUserConnectedIsConfigurationRoleExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SharingApi();

            try
            {
                bool? result = apiInstance.SharingUserConnectedIsConfigurationRole();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SharingApi.SharingUserConnectedIsConfigurationRole: " + e.Message );
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

<a name="sharinguserconnectedissharingmanager"></a>
# **SharingUserConnectedIsSharingManager**
> bool? SharingUserConnectedIsSharingManager ()



### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SharingUserConnectedIsSharingManagerExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SharingApi();

            try
            {
                bool? result = apiInstance.SharingUserConnectedIsSharingManager();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SharingApi.SharingUserConnectedIsSharingManager: " + e.Message );
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


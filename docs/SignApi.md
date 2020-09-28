# ARXivarNEXT.Client.Api.SignApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SignDeleteSignCert**](SignApi.md#signdeletesigncert) | **DELETE** /api/Sign/SignCert/{id} | This call deletes a signature certificate
[**SignGetRelatedSignCertList**](SignApi.md#signgetrelatedsigncertlist) | **GET** /api/Sign/RelatedSignCertList/{signCertId} | This call returns the related certificates of a given Sign certificate (es: Telecom Remote Provider)
[**SignGetSignCert**](SignApi.md#signgetsigncert) | **GET** /api/Sign/SignCert/{id} | This call returs a specific signature certificate
[**SignGetSignCertList**](SignApi.md#signgetsigncertlist) | **GET** /api/Sign/SignCertList | This call returs all signature certificates of user
[**SignGetSignCertTypeList**](SignApi.md#signgetsigncerttypelist) | **GET** /api/Sign/SignCertTypeList | This call returs all signature certificates
[**SignGetSignCertUseList**](SignApi.md#signgetsigncertuselist) | **GET** /api/Sign/SignCertUse/{signCertId} | This call returns the automatic use of a given Sign certificate
[**SignGetVerifyInfo**](SignApi.md#signgetverifyinfo) | **POST** /api/Sign/GetVerifyInfo | 
[**SignInsertSignCert**](SignApi.md#signinsertsigncert) | **POST** /api/Sign/InsertSignCert | This call inserts a signature certificate
[**SignRemoteSign**](SignApi.md#signremotesign) | **POST** /api/Sign/RemoteSign | This call executes a remote signature operation
[**SignRemoteSignTaskWork**](SignApi.md#signremotesigntaskwork) | **POST** /api/Sign/RemoteSignTaskWork | This call executes a remote signature operation on a TaskWork list
[**SignTestSignCert**](SignApi.md#signtestsigncert) | **POST** /api/Sign/TestSignCert/{signCertId} | This call tests a Sign certificate
[**SignUpdateSignCert**](SignApi.md#signupdatesigncert) | **POST** /api/Sign/UpdateSignCert/{id} | This call updates a signature certificate
[**SignUpdateSignCertUseList**](SignApi.md#signupdatesigncertuselist) | **POST** /api/Sign/UpdateSignCertUse/{signCertId} | This call updates the automatic use for a given Sign certificate


<a name="signdeletesigncert"></a>
# **SignDeleteSignCert**
> void SignDeleteSignCert (int? id)

This call deletes a signature certificate

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SignDeleteSignCertExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignApi();
            var id = 56;  // int? | Identifier

            try
            {
                // This call deletes a signature certificate
                apiInstance.SignDeleteSignCert(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SignApi.SignDeleteSignCert: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Identifier | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signgetrelatedsigncertlist"></a>
# **SignGetRelatedSignCertList**
> List<SignCertRelatedDTO> SignGetRelatedSignCertList (int? signCertId)

This call returns the related certificates of a given Sign certificate (es: Telecom Remote Provider)

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SignGetRelatedSignCertListExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignApi();
            var signCertId = 56;  // int? | Identifier of certificate

            try
            {
                // This call returns the related certificates of a given Sign certificate (es: Telecom Remote Provider)
                List&lt;SignCertRelatedDTO&gt; result = apiInstance.SignGetRelatedSignCertList(signCertId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SignApi.SignGetRelatedSignCertList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **signCertId** | **int?**| Identifier of certificate | 

### Return type

[**List<SignCertRelatedDTO>**](SignCertRelatedDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signgetsigncert"></a>
# **SignGetSignCert**
> SignCertDTO SignGetSignCert (int? id)

This call returs a specific signature certificate

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SignGetSignCertExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignApi();
            var id = 56;  // int? | Identifier

            try
            {
                // This call returs a specific signature certificate
                SignCertDTO result = apiInstance.SignGetSignCert(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SignApi.SignGetSignCert: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Identifier | 

### Return type

[**SignCertDTO**](SignCertDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signgetsigncertlist"></a>
# **SignGetSignCertList**
> List<SignCertDTO> SignGetSignCertList ()

This call returs all signature certificates of user

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SignGetSignCertListExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignApi();

            try
            {
                // This call returs all signature certificates of user
                List&lt;SignCertDTO&gt; result = apiInstance.SignGetSignCertList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SignApi.SignGetSignCertList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<SignCertDTO>**](SignCertDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signgetsigncerttypelist"></a>
# **SignGetSignCertTypeList**
> List<SignCertTypeDTO> SignGetSignCertTypeList ()

This call returs all signature certificates

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SignGetSignCertTypeListExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignApi();

            try
            {
                // This call returs all signature certificates
                List&lt;SignCertTypeDTO&gt; result = apiInstance.SignGetSignCertTypeList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SignApi.SignGetSignCertTypeList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<SignCertTypeDTO>**](SignCertTypeDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signgetsigncertuselist"></a>
# **SignGetSignCertUseList**
> SignCertUseGetDTO SignGetSignCertUseList (int? signCertId)

This call returns the automatic use of a given Sign certificate

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SignGetSignCertUseListExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignApi();
            var signCertId = 56;  // int? | Identifier of certificate

            try
            {
                // This call returns the automatic use of a given Sign certificate
                SignCertUseGetDTO result = apiInstance.SignGetSignCertUseList(signCertId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SignApi.SignGetSignCertUseList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **signCertId** | **int?**| Identifier of certificate | 

### Return type

[**SignCertUseGetDTO**](SignCertUseGetDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signgetverifyinfo"></a>
# **SignGetVerifyInfo**
> VerifyInfoDTO SignGetVerifyInfo (VerifyInfoRequestDTO verifyInfoRequestDto)



### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SignGetVerifyInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignApi();
            var verifyInfoRequestDto = new VerifyInfoRequestDTO(); // VerifyInfoRequestDTO | 

            try
            {
                VerifyInfoDTO result = apiInstance.SignGetVerifyInfo(verifyInfoRequestDto);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SignApi.SignGetVerifyInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **verifyInfoRequestDto** | [**VerifyInfoRequestDTO**](VerifyInfoRequestDTO.md)|  | 

### Return type

[**VerifyInfoDTO**](VerifyInfoDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signinsertsigncert"></a>
# **SignInsertSignCert**
> SignCertDTO SignInsertSignCert (SignCertInsertDTO certInsert)

This call inserts a signature certificate

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SignInsertSignCertExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignApi();
            var certInsert = new SignCertInsertDTO(); // SignCertInsertDTO | 

            try
            {
                // This call inserts a signature certificate
                SignCertDTO result = apiInstance.SignInsertSignCert(certInsert);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SignApi.SignInsertSignCert: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **certInsert** | [**SignCertInsertDTO**](SignCertInsertDTO.md)|  | 

### Return type

[**SignCertDTO**](SignCertDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signremotesign"></a>
# **SignRemoteSign**
> RemoteSignResponseDTO SignRemoteSign (RemoteSignRequestDTO remoteSignRequest)

This call executes a remote signature operation

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SignRemoteSignExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignApi();
            var remoteSignRequest = new RemoteSignRequestDTO(); // RemoteSignRequestDTO | List of documents to sign

            try
            {
                // This call executes a remote signature operation
                RemoteSignResponseDTO result = apiInstance.SignRemoteSign(remoteSignRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SignApi.SignRemoteSign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **remoteSignRequest** | [**RemoteSignRequestDTO**](RemoteSignRequestDTO.md)| List of documents to sign | 

### Return type

[**RemoteSignResponseDTO**](RemoteSignResponseDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signremotesigntaskwork"></a>
# **SignRemoteSignTaskWork**
> RemoteSignResponseDTO SignRemoteSignTaskWork (RemoteSignTaskWorkRequestDTO remoteSignTaskWorkRequest)

This call executes a remote signature operation on a TaskWork list

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SignRemoteSignTaskWorkExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignApi();
            var remoteSignTaskWorkRequest = new RemoteSignTaskWorkRequestDTO(); // RemoteSignTaskWorkRequestDTO | List of taskWorks to sign

            try
            {
                // This call executes a remote signature operation on a TaskWork list
                RemoteSignResponseDTO result = apiInstance.SignRemoteSignTaskWork(remoteSignTaskWorkRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SignApi.SignRemoteSignTaskWork: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **remoteSignTaskWorkRequest** | [**RemoteSignTaskWorkRequestDTO**](RemoteSignTaskWorkRequestDTO.md)| List of taskWorks to sign | 

### Return type

[**RemoteSignResponseDTO**](RemoteSignResponseDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signtestsigncert"></a>
# **SignTestSignCert**
> void SignTestSignCert (int? signCertId, SignCertPasswordTestDTO certPasswordTest)

This call tests a Sign certificate

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SignTestSignCertExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignApi();
            var signCertId = 56;  // int? | Identifier of certificate
            var certPasswordTest = new SignCertPasswordTestDTO(); // SignCertPasswordTestDTO | Information of test password

            try
            {
                // This call tests a Sign certificate
                apiInstance.SignTestSignCert(signCertId, certPasswordTest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SignApi.SignTestSignCert: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **signCertId** | **int?**| Identifier of certificate | 
 **certPasswordTest** | [**SignCertPasswordTestDTO**](SignCertPasswordTestDTO.md)| Information of test password | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signupdatesigncert"></a>
# **SignUpdateSignCert**
> SignCertDTO SignUpdateSignCert (int? id, SignCertUpdateDTO certUpdate)

This call updates a signature certificate

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SignUpdateSignCertExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignApi();
            var id = 56;  // int? | Identifier
            var certUpdate = new SignCertUpdateDTO(); // SignCertUpdateDTO | Information to update

            try
            {
                // This call updates a signature certificate
                SignCertDTO result = apiInstance.SignUpdateSignCert(id, certUpdate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SignApi.SignUpdateSignCert: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Identifier | 
 **certUpdate** | [**SignCertUpdateDTO**](SignCertUpdateDTO.md)| Information to update | 

### Return type

[**SignCertDTO**](SignCertDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signupdatesigncertuselist"></a>
# **SignUpdateSignCertUseList**
> SignCertUseGetDTO SignUpdateSignCertUseList (int? signCertId, SignCertUseSetDTO certUseSet)

This call updates the automatic use for a given Sign certificate

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class SignUpdateSignCertUseListExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SignApi();
            var signCertId = 56;  // int? | Identifier of certificate
            var certUseSet = new SignCertUseSetDTO(); // SignCertUseSetDTO | Setting of certificate use

            try
            {
                // This call updates the automatic use for a given Sign certificate
                SignCertUseGetDTO result = apiInstance.SignUpdateSignCertUseList(signCertId, certUseSet);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SignApi.SignUpdateSignCertUseList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **signCertId** | **int?**| Identifier of certificate | 
 **certUseSet** | [**SignCertUseSetDTO**](SignCertUseSetDTO.md)| Setting of certificate use | 

### Return type

[**SignCertUseGetDTO**](SignCertUseGetDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# ARXivarNEXT.Client.Api.TimestampApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TimestampApplyTimestamp**](TimestampApi.md#timestampapplytimestamp) | **POST** /api/Timestamps/ApplyTimestamp | This call applies a timestamp
[**TimestampDeleteTsa**](TimestampApi.md#timestampdeletetsa) | **DELETE** /api/Timestamps/{id} | This call deletes a timestamp account
[**TimestampGetTsa**](TimestampApi.md#timestampgettsa) | **GET** /api/Timestamps/{id} | This call returns a specific timestamp account
[**TimestampGetTsaList**](TimestampApi.md#timestampgettsalist) | **GET** /api/Timestamps | This call returns the timestamp list
[**TimestampGetTsaProtocolList**](TimestampApi.md#timestampgettsaprotocollist) | **GET** /api/Timestamps/TsaProtocolList | This call returns the timestamp account protocol list
[**TimestampInsertTsa**](TimestampApi.md#timestampinserttsa) | **POST** /api/Timestamps | This call inserts a new timestamp account
[**TimestampTestTsa**](TimestampApi.md#timestamptesttsa) | **POST** /api/Timestamps/TestTsa/{id} | This call tests timestamp account
[**TimestampUpdateTsa**](TimestampApi.md#timestampupdatetsa) | **PUT** /api/Timestamps/{id} | This call updates a given timestamp account


<a name="timestampapplytimestamp"></a>
# **TimestampApplyTimestamp**
> TimestampResponseDTO TimestampApplyTimestamp (TimestampRequestDTO timestampRequest)

This call applies a timestamp

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TimestampApplyTimestampExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TimestampApi();
            var timestampRequest = new TimestampRequestDTO(); // TimestampRequestDTO | Timestamp information to apply

            try
            {
                // This call applies a timestamp
                TimestampResponseDTO result = apiInstance.TimestampApplyTimestamp(timestampRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimestampApi.TimestampApplyTimestamp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **timestampRequest** | [**TimestampRequestDTO**](TimestampRequestDTO.md)| Timestamp information to apply | 

### Return type

[**TimestampResponseDTO**](TimestampResponseDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timestampdeletetsa"></a>
# **TimestampDeleteTsa**
> void TimestampDeleteTsa (string id)

This call deletes a timestamp account

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TimestampDeleteTsaExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TimestampApi();
            var id = id_example;  // string | Identifier

            try
            {
                // This call deletes a timestamp account
                apiInstance.TimestampDeleteTsa(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimestampApi.TimestampDeleteTsa: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timestampgettsa"></a>
# **TimestampGetTsa**
> TsaDTO TimestampGetTsa (string id)

This call returns a specific timestamp account

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TimestampGetTsaExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TimestampApi();
            var id = id_example;  // string | Identifier

            try
            {
                // This call returns a specific timestamp account
                TsaDTO result = apiInstance.TimestampGetTsa(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimestampApi.TimestampGetTsa: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier | 

### Return type

[**TsaDTO**](TsaDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timestampgettsalist"></a>
# **TimestampGetTsaList**
> List<TsaDTO> TimestampGetTsaList ()

This call returns the timestamp list

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TimestampGetTsaListExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TimestampApi();

            try
            {
                // This call returns the timestamp list
                List&lt;TsaDTO&gt; result = apiInstance.TimestampGetTsaList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimestampApi.TimestampGetTsaList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsaDTO>**](TsaDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timestampgettsaprotocollist"></a>
# **TimestampGetTsaProtocolList**
> List<TsaProtocolDTO> TimestampGetTsaProtocolList ()

This call returns the timestamp account protocol list

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TimestampGetTsaProtocolListExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TimestampApi();

            try
            {
                // This call returns the timestamp account protocol list
                List&lt;TsaProtocolDTO&gt; result = apiInstance.TimestampGetTsaProtocolList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimestampApi.TimestampGetTsaProtocolList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsaProtocolDTO>**](TsaProtocolDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timestampinserttsa"></a>
# **TimestampInsertTsa**
> TsaDTO TimestampInsertTsa (TsaInsertDTO tsaInsert)

This call inserts a new timestamp account

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TimestampInsertTsaExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TimestampApi();
            var tsaInsert = new TsaInsertDTO(); // TsaInsertDTO | Timestamp information to insert

            try
            {
                // This call inserts a new timestamp account
                TsaDTO result = apiInstance.TimestampInsertTsa(tsaInsert);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimestampApi.TimestampInsertTsa: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tsaInsert** | [**TsaInsertDTO**](TsaInsertDTO.md)| Timestamp information to insert | 

### Return type

[**TsaDTO**](TsaDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timestamptesttsa"></a>
# **TimestampTestTsa**
> void TimestampTestTsa (string id)

This call tests timestamp account

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TimestampTestTsaExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TimestampApi();
            var id = id_example;  // string | Identifier

            try
            {
                // This call tests timestamp account
                apiInstance.TimestampTestTsa(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimestampApi.TimestampTestTsa: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timestampupdatetsa"></a>
# **TimestampUpdateTsa**
> TsaDTO TimestampUpdateTsa (string id, TsaUpdateDTO tsaUpdate)

This call updates a given timestamp account

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TimestampUpdateTsaExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TimestampApi();
            var id = id_example;  // string | Identifier
            var tsaUpdate = new TsaUpdateDTO(); // TsaUpdateDTO | Timestamp information to update

            try
            {
                // This call updates a given timestamp account
                TsaDTO result = apiInstance.TimestampUpdateTsa(id, tsaUpdate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimestampApi.TimestampUpdateTsa: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier | 
 **tsaUpdate** | [**TsaUpdateDTO**](TsaUpdateDTO.md)| Timestamp information to update | 

### Return type

[**TsaDTO**](TsaDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


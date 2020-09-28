# ARXivarNEXT.Client.Api.MassiveChangeApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MassiveChangeCanExecute**](MassiveChangeApi.md#massivechangecanexecute) | **POST** /api/MassiveChange/canExecute | This call returns if is possible to start a specific profiles massive change
[**MassiveChangeInsertNewMassiveChange**](MassiveChangeApi.md#massivechangeinsertnewmassivechange) | **POST** /api/MassiveChange | This call insert new massive change in the system


<a name="massivechangecanexecute"></a>
# **MassiveChangeCanExecute**
> MassiveChangeCanExecuteResult MassiveChangeCanExecute (MassiveChangeCanExecuteRequest massiveChangeCanExecuteRequest)

This call returns if is possible to start a specific profiles massive change

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MassiveChangeCanExecuteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MassiveChangeApi();
            var massiveChangeCanExecuteRequest = new MassiveChangeCanExecuteRequest(); // MassiveChangeCanExecuteRequest | Request with profiles for massive change

            try
            {
                // This call returns if is possible to start a specific profiles massive change
                MassiveChangeCanExecuteResult result = apiInstance.MassiveChangeCanExecute(massiveChangeCanExecuteRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MassiveChangeApi.MassiveChangeCanExecute: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **massiveChangeCanExecuteRequest** | [**MassiveChangeCanExecuteRequest**](MassiveChangeCanExecuteRequest.md)| Request with profiles for massive change | 

### Return type

[**MassiveChangeCanExecuteResult**](MassiveChangeCanExecuteResult.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="massivechangeinsertnewmassivechange"></a>
# **MassiveChangeInsertNewMassiveChange**
> MassiveChangeResponseDTO MassiveChangeInsertNewMassiveChange (MassiveChangeRequestDTO massivechangerequest = null)

This call insert new massive change in the system

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MassiveChangeInsertNewMassiveChangeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MassiveChangeApi();
            var massivechangerequest = new MassiveChangeRequestDTO(); // MassiveChangeRequestDTO |  (optional) 

            try
            {
                // This call insert new massive change in the system
                MassiveChangeResponseDTO result = apiInstance.MassiveChangeInsertNewMassiveChange(massivechangerequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MassiveChangeApi.MassiveChangeInsertNewMassiveChange: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **massivechangerequest** | [**MassiveChangeRequestDTO**](MassiveChangeRequestDTO.md)|  | [optional] 

### Return type

[**MassiveChangeResponseDTO**](MassiveChangeResponseDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


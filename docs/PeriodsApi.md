# ARXivarNEXT.Client.Api.PeriodsApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PeriodsGetPeriods**](PeriodsApi.md#periodsgetperiods) | **GET** /api/Periods | This call returns all periods defined for electronic storage in Arxivar


<a name="periodsgetperiods"></a>
# **PeriodsGetPeriods**
> List<PeriodDTO> PeriodsGetPeriods ()

This call returns all periods defined for electronic storage in Arxivar

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class PeriodsGetPeriodsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PeriodsApi();

            try
            {
                // This call returns all periods defined for electronic storage in Arxivar
                List&lt;PeriodDTO&gt; result = apiInstance.PeriodsGetPeriods();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PeriodsApi.PeriodsGetPeriods: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<PeriodDTO>**](PeriodDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


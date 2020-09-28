# ARXivarNEXT.Client.Api.ShippingApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ShippingGetShippings**](ShippingApi.md#shippinggetshippings) | **GET** /api/Shippings | This call returns all shippings stored in ARXivar


<a name="shippinggetshippings"></a>
# **ShippingGetShippings**
> List<ShippingDTO> ShippingGetShippings ()

This call returns all shippings stored in ARXivar

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ShippingGetShippingsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ShippingApi();

            try
            {
                // This call returns all shippings stored in ARXivar
                List&lt;ShippingDTO&gt; result = apiInstance.ShippingGetShippings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingApi.ShippingGetShippings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ShippingDTO>**](ShippingDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


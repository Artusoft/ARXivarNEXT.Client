# ARXivarNEXT.Client.Api.CustomLabelsApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CustomLabelsGetBinderLabel**](CustomLabelsApi.md#customlabelsgetbinderlabel) | **GET** /api/CustomLabels/binders | This method return the binder label


<a name="customlabelsgetbinderlabel"></a>
# **CustomLabelsGetBinderLabel**
> string CustomLabelsGetBinderLabel ()

This method return the binder label

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class CustomLabelsGetBinderLabelExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomLabelsApi();

            try
            {
                // This method return the binder label
                string result = apiInstance.CustomLabelsGetBinderLabel();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomLabelsApi.CustomLabelsGetBinderLabel: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# ARXivarNEXT.Client.Api.MailApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MailMailOutInsert**](MailApi.md#mailmailoutinsert) | **POST** /api/Mail | This call insert new mail for send queue


<a name="mailmailoutinsert"></a>
# **MailMailOutInsert**
> MailOutDTO MailMailOutInsert (MailOutInsertRequestDTO mailOutInsertRequestDTO)

This call insert new mail for send queue

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class MailMailOutInsertExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MailApi();
            var mailOutInsertRequestDTO = new MailOutInsertRequestDTO(); // MailOutInsertRequestDTO | 

            try
            {
                // This call insert new mail for send queue
                MailOutDTO result = apiInstance.MailMailOutInsert(mailOutInsertRequestDTO);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MailApi.MailMailOutInsert: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mailOutInsertRequestDTO** | [**MailOutInsertRequestDTO**](MailOutInsertRequestDTO.md)|  | 

### Return type

[**MailOutDTO**](MailOutDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


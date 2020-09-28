# ARXivarNEXT.Client.Api.TicketDownloadsApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TicketDownloadsDownloadDocumentByTicket**](TicketDownloadsApi.md#ticketdownloadsdownloaddocumentbyticket) | **GET** /api/TicketDownloads/download/{ticketId} | This call returns the file associated with a pre requested Ticket


<a name="ticketdownloadsdownloaddocumentbyticket"></a>
# **TicketDownloadsDownloadDocumentByTicket**
> System.IO.Stream TicketDownloadsDownloadDocumentByTicket (string ticketId)

This call returns the file associated with a pre requested Ticket

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TicketDownloadsDownloadDocumentByTicketExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TicketDownloadsApi();
            var ticketId = ticketId_example;  // string | 

            try
            {
                // This call returns the file associated with a pre requested Ticket
                System.IO.Stream result = apiInstance.TicketDownloadsDownloadDocumentByTicket(ticketId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TicketDownloadsApi.TicketDownloadsDownloadDocumentByTicket: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ticketId** | **string**|  | 

### Return type

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


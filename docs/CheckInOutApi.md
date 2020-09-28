# ARXivarNEXT.Client.Api.CheckInOutApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckInOutCheckIn**](CheckInOutApi.md#checkinoutcheckin) | **POST** /api/CheckInOut/checkIn/{docnumber}/{fileId}/{option}/{undoCheckOut} | This call set file and remove document from checkout list
[**CheckInOutCheckInForTask**](CheckInOutApi.md#checkinoutcheckinfortask) | **POST** /api/CheckInOut/checkInForTask/{processDocId}/{taskWorkId}/{fileId} | This call set file and remove document from checkout list when document is used in taskwork
[**CheckInOutCheckOut**](CheckInOutApi.md#checkinoutcheckout) | **PUT** /api/CheckInOut/checkOut/{docNumber} | This call allows checkout document
[**CheckInOutCheckOutForTask**](CheckInOutApi.md#checkinoutcheckoutfortask) | **PUT** /api/CheckInOut/checkOutTask/{processDocId}/{taskWorkId} | This call allows checkout document for task
[**CheckInOutGetCheckOutProfilesList**](CheckInOutApi.md#checkinoutgetcheckoutprofileslist) | **POST** /api/CheckInOut | This call allows the retrieval of the default profile for archiving based on user connected
[**CheckInOutIsAlreadyInCheckOutByUserConnected**](CheckInOutApi.md#checkinoutisalreadyincheckoutbyuserconnected) | **POST** /api/CheckInOut/isInCheckOut/{docnumber} | This call allows to know if the document is in checkout
[**CheckInOutUndoCheckOut**](CheckInOutApi.md#checkinoutundocheckout) | **PUT** /api/CheckInOut/undoCheckOut | This call allows undo checkout document
[**CheckInOutUndoCheckOutForTask**](CheckInOutApi.md#checkinoutundocheckoutfortask) | **PUT** /api/CheckInOut/undoCheckOutForTask/{processDocId}/{taskWorkId} | This call allows undo checkout document for task


<a name="checkinoutcheckin"></a>
# **CheckInOutCheckIn**
> void CheckInOutCheckIn (int? docnumber, string fileId, int? option, bool? undoCheckOut)

This call set file and remove document from checkout list

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class CheckInOutCheckInExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CheckInOutApi();
            var docnumber = 56;  // int? | Identifier of the document you want to checkin
            var fileId = fileId_example;  // string | Identifier of file you want to upload
            var option = 56;  // int? | State option
            var undoCheckOut = true;  // bool? | If import fails execute undo checkout

            try
            {
                // This call set file and remove document from checkout list
                apiInstance.CheckInOutCheckIn(docnumber, fileId, option, undoCheckOut);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckInOutApi.CheckInOutCheckIn: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| Identifier of the document you want to checkin | 
 **fileId** | **string**| Identifier of file you want to upload | 
 **option** | **int?**| State option | 
 **undoCheckOut** | **bool?**| If import fails execute undo checkout | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkinoutcheckinfortask"></a>
# **CheckInOutCheckInForTask**
> void CheckInOutCheckInForTask (int? processDocId, int? taskWorkId, string fileId)

This call set file and remove document from checkout list when document is used in taskwork

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class CheckInOutCheckInForTaskExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CheckInOutApi();
            var processDocId = 56;  // int? | Identifier of the document you want to checkin
            var taskWorkId = 56;  // int? | Identifier of the document you want to checkin
            var fileId = fileId_example;  // string | Identifier of file in cache you want to upload

            try
            {
                // This call set file and remove document from checkout list when document is used in taskwork
                apiInstance.CheckInOutCheckInForTask(processDocId, taskWorkId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckInOutApi.CheckInOutCheckInForTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDocId** | **int?**| Identifier of the document you want to checkin | 
 **taskWorkId** | **int?**| Identifier of the document you want to checkin | 
 **fileId** | **string**| Identifier of file in cache you want to upload | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkinoutcheckout"></a>
# **CheckInOutCheckOut**
> void CheckInOutCheckOut (int? docNumber)

This call allows checkout document

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class CheckInOutCheckOutExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CheckInOutApi();
            var docNumber = 56;  // int? | The identifier of document to checkout

            try
            {
                // This call allows checkout document
                apiInstance.CheckInOutCheckOut(docNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckInOutApi.CheckInOutCheckOut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docNumber** | **int?**| The identifier of document to checkout | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkinoutcheckoutfortask"></a>
# **CheckInOutCheckOutForTask**
> void CheckInOutCheckOutForTask (int? processDocId, int? taskWorkId)

This call allows checkout document for task

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class CheckInOutCheckOutForTaskExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CheckInOutApi();
            var processDocId = 56;  // int? | The process document identifier of profile to checkout
            var taskWorkId = 56;  // int? | The taskWork identifier for the profile to checkout

            try
            {
                // This call allows checkout document for task
                apiInstance.CheckInOutCheckOutForTask(processDocId, taskWorkId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckInOutApi.CheckInOutCheckOutForTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDocId** | **int?**| The process document identifier of profile to checkout | 
 **taskWorkId** | **int?**| The taskWork identifier for the profile to checkout | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkinoutgetcheckoutprofileslist"></a>
# **CheckInOutGetCheckOutProfilesList**
> List<RowSearchResult> CheckInOutGetCheckOutProfilesList (SelectDTO selectDto)

This call allows the retrieval of the default profile for archiving based on user connected

This method is deprecated. Use api/v2/CheckInOut

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class CheckInOutGetCheckOutProfilesListExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CheckInOutApi();
            var selectDto = new SelectDTO(); // SelectDTO | Seleted data for search

            try
            {
                // This call allows the retrieval of the default profile for archiving based on user connected
                List&lt;RowSearchResult&gt; result = apiInstance.CheckInOutGetCheckOutProfilesList(selectDto);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckInOutApi.CheckInOutGetCheckOutProfilesList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **selectDto** | [**SelectDTO**](SelectDTO.md)| Seleted data for search | 

### Return type

[**List<RowSearchResult>**](RowSearchResult.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkinoutisalreadyincheckoutbyuserconnected"></a>
# **CheckInOutIsAlreadyInCheckOutByUserConnected**
> bool? CheckInOutIsAlreadyInCheckOutByUserConnected (int? docnumber)

This call allows to know if the document is in checkout

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class CheckInOutIsAlreadyInCheckOutByUserConnectedExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CheckInOutApi();
            var docnumber = 56;  // int? | Document identifier

            try
            {
                // This call allows to know if the document is in checkout
                bool? result = apiInstance.CheckInOutIsAlreadyInCheckOutByUserConnected(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckInOutApi.CheckInOutIsAlreadyInCheckOutByUserConnected: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| Document identifier | 

### Return type

**bool?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkinoutundocheckout"></a>
# **CheckInOutUndoCheckOut**
> void CheckInOutUndoCheckOut (List<int?> docNumbers)

This call allows undo checkout document

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class CheckInOutUndoCheckOutExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CheckInOutApi();
            var docNumbers = ;  // List<int?> | Array of document identifiers

            try
            {
                // This call allows undo checkout document
                apiInstance.CheckInOutUndoCheckOut(docNumbers);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckInOutApi.CheckInOutUndoCheckOut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docNumbers** | **List&lt;int?&gt;**| Array of document identifiers | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkinoutundocheckoutfortask"></a>
# **CheckInOutUndoCheckOutForTask**
> void CheckInOutUndoCheckOutForTask (int? processDocId, int? taskWorkId)

This call allows undo checkout document for task

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class CheckInOutUndoCheckOutForTaskExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CheckInOutApi();
            var processDocId = 56;  // int? | The process document identifier of profile to checkout
            var taskWorkId = 56;  // int? | The taskWork identifier for the profile to checkout

            try
            {
                // This call allows undo checkout document for task
                apiInstance.CheckInOutUndoCheckOutForTask(processDocId, taskWorkId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckInOutApi.CheckInOutUndoCheckOutForTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDocId** | **int?**| The process document identifier of profile to checkout | 
 **taskWorkId** | **int?**| The taskWork identifier for the profile to checkout | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


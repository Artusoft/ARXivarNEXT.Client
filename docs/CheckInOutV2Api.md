# ARXivarNEXT.Client.Api.CheckInOutV2Api

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckInOutV2CheckIn**](CheckInOutV2Api.md#checkinoutv2checkin) | **POST** /api/v2/CheckInOut/checkIn/{docnumber}/{fileId}/{option}/{undoCheckOut} | This call set file and remove document from checkout list
[**CheckInOutV2CheckInForTask**](CheckInOutV2Api.md#checkinoutv2checkinfortask) | **POST** /api/v2/CheckInOut/checkInForTask/{processDocId}/{taskWorkId}/{fileId} | This call set file and remove document from checkout list when document is used in taskwork
[**CheckInOutV2CheckOut**](CheckInOutV2Api.md#checkinoutv2checkout) | **PUT** /api/v2/CheckInOut/checkOut/{docNumber} | This call allows checkout document
[**CheckInOutV2CheckOutForTask**](CheckInOutV2Api.md#checkinoutv2checkoutfortask) | **PUT** /api/v2/CheckInOut/checkOutTask/{processDocId}/{taskWorkId} | This call allows checkout document for task
[**CheckInOutV2GetCheckOutProfilesList**](CheckInOutV2Api.md#checkinoutv2getcheckoutprofileslist) | **POST** /api/v2/CheckInOut | This call allows the retrieval of the default profile for archiving based on user connected.  This call could not be compatible with some programming language, in this case use the call api/CheckInOut
[**CheckInOutV2IsAlreadyInCheckOutByUserConnected**](CheckInOutV2Api.md#checkinoutv2isalreadyincheckoutbyuserconnected) | **POST** /api/v2/CheckInOut/isInCheckOut/{docnumber} | This call allows to know if the document is in checkout
[**CheckInOutV2UndoCheckOut**](CheckInOutV2Api.md#checkinoutv2undocheckout) | **PUT** /api/v2/CheckInOut/undoCheckOut | This call allows undo checkout document
[**CheckInOutV2UndoCheckOutForTask**](CheckInOutV2Api.md#checkinoutv2undocheckoutfortask) | **PUT** /api/v2/CheckInOut/undoCheckOutForTask/{processDocId}/{taskWorkId} | This call allows undo checkout document for task


<a name="checkinoutv2checkin"></a>
# **CheckInOutV2CheckIn**
> void CheckInOutV2CheckIn (int? docnumber, string fileId, int? option, bool? undoCheckOut)

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
    public class CheckInOutV2CheckInExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CheckInOutV2Api();
            var docnumber = 56;  // int? | Identifier of the document you want to checkin
            var fileId = fileId_example;  // string | Identifier of file you want to upload
            var option = 56;  // int? | State option
            var undoCheckOut = true;  // bool? | If import fails execute undo checkout

            try
            {
                // This call set file and remove document from checkout list
                apiInstance.CheckInOutV2CheckIn(docnumber, fileId, option, undoCheckOut);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckInOutV2Api.CheckInOutV2CheckIn: " + e.Message );
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

<a name="checkinoutv2checkinfortask"></a>
# **CheckInOutV2CheckInForTask**
> void CheckInOutV2CheckInForTask (int? processDocId, int? taskWorkId, string fileId)

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
    public class CheckInOutV2CheckInForTaskExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CheckInOutV2Api();
            var processDocId = 56;  // int? | Identifier of the document you want to checkin
            var taskWorkId = 56;  // int? | Identifier of the document you want to checkin
            var fileId = fileId_example;  // string | Identifier of file in the cache you want to upload

            try
            {
                // This call set file and remove document from checkout list when document is used in taskwork
                apiInstance.CheckInOutV2CheckInForTask(processDocId, taskWorkId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckInOutV2Api.CheckInOutV2CheckInForTask: " + e.Message );
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
 **fileId** | **string**| Identifier of file in the cache you want to upload | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkinoutv2checkout"></a>
# **CheckInOutV2CheckOut**
> void CheckInOutV2CheckOut (int? docNumber)

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
    public class CheckInOutV2CheckOutExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CheckInOutV2Api();
            var docNumber = 56;  // int? | The identifier of document to checkout

            try
            {
                // This call allows checkout document
                apiInstance.CheckInOutV2CheckOut(docNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckInOutV2Api.CheckInOutV2CheckOut: " + e.Message );
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

<a name="checkinoutv2checkoutfortask"></a>
# **CheckInOutV2CheckOutForTask**
> void CheckInOutV2CheckOutForTask (int? processDocId, int? taskWorkId)

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
    public class CheckInOutV2CheckOutForTaskExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CheckInOutV2Api();
            var processDocId = 56;  // int? | The process document identifier of profile to checkout
            var taskWorkId = 56;  // int? | The taskWork identifier for the profile to checkout

            try
            {
                // This call allows checkout document for task
                apiInstance.CheckInOutV2CheckOutForTask(processDocId, taskWorkId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckInOutV2Api.CheckInOutV2CheckOutForTask: " + e.Message );
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

<a name="checkinoutv2getcheckoutprofileslist"></a>
# **CheckInOutV2GetCheckOutProfilesList**
> Object CheckInOutV2GetCheckOutProfilesList (SelectDTO selectDto)

This call allows the retrieval of the default profile for archiving based on user connected.  This call could not be compatible with some programming language, in this case use the call api/CheckInOut

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class CheckInOutV2GetCheckOutProfilesListExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CheckInOutV2Api();
            var selectDto = new SelectDTO(); // SelectDTO | Seleted data for search

            try
            {
                // This call allows the retrieval of the default profile for archiving based on user connected.  This call could not be compatible with some programming language, in this case use the call api/CheckInOut
                Object result = apiInstance.CheckInOutV2GetCheckOutProfilesList(selectDto);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckInOutV2Api.CheckInOutV2GetCheckOutProfilesList: " + e.Message );
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

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkinoutv2isalreadyincheckoutbyuserconnected"></a>
# **CheckInOutV2IsAlreadyInCheckOutByUserConnected**
> bool? CheckInOutV2IsAlreadyInCheckOutByUserConnected (int? docnumber)

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
    public class CheckInOutV2IsAlreadyInCheckOutByUserConnectedExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CheckInOutV2Api();
            var docnumber = 56;  // int? | Document identifier

            try
            {
                // This call allows to know if the document is in checkout
                bool? result = apiInstance.CheckInOutV2IsAlreadyInCheckOutByUserConnected(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckInOutV2Api.CheckInOutV2IsAlreadyInCheckOutByUserConnected: " + e.Message );
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

<a name="checkinoutv2undocheckout"></a>
# **CheckInOutV2UndoCheckOut**
> void CheckInOutV2UndoCheckOut (List<int?> docNumbers)

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
    public class CheckInOutV2UndoCheckOutExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CheckInOutV2Api();
            var docNumbers = ;  // List<int?> | Array of document identifiers

            try
            {
                // This call allows undo checkout document
                apiInstance.CheckInOutV2UndoCheckOut(docNumbers);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckInOutV2Api.CheckInOutV2UndoCheckOut: " + e.Message );
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

<a name="checkinoutv2undocheckoutfortask"></a>
# **CheckInOutV2UndoCheckOutForTask**
> void CheckInOutV2UndoCheckOutForTask (int? processDocId, int? taskWorkId)

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
    public class CheckInOutV2UndoCheckOutForTaskExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CheckInOutV2Api();
            var processDocId = 56;  // int? | The process document identifier of profile to checkout
            var taskWorkId = 56;  // int? | The taskWork identifier for the profile to checkout

            try
            {
                // This call allows undo checkout document for task
                apiInstance.CheckInOutV2UndoCheckOutForTask(processDocId, taskWorkId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CheckInOutV2Api.CheckInOutV2UndoCheckOutForTask: " + e.Message );
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


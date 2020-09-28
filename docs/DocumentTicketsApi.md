# ARXivarNEXT.Client.Api.DocumentTicketsApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DocumentTicketsGetDocumentByRevisionId**](DocumentTicketsApi.md#documentticketsgetdocumentbyrevisionid) | **GET** /api/DocumentTickets/ticketByRevision/{revisionId} | This call returns the ticket for downloading a document associated to a specified revision
[**DocumentTicketsGetForExternalAttachment**](DocumentTicketsApi.md#documentticketsgetforexternalattachment) | **GET** /api/DocumentTickets/ticketProfileAttachment/{id} | This call retrieve a ticket for downloading a file for an external profile attachment
[**DocumentTicketsGetForProcessAttachement**](DocumentTicketsApi.md#documentticketsgetforprocessattachement) | **GET** /api/DocumentTickets/ticketProcessattachments/{processId}/{attachementid} | This call returns the ticket for downloading a file associated with the attachment into in a process workflow
[**DocumentTicketsGetForProcessDocument**](DocumentTicketsApi.md#documentticketsgetforprocessdocument) | **GET** /api/DocumentTickets/ticketProcessdocument/{processId}/{processdocid} | This call returns the ticket for downloading a file associated with the document process into in a process workflow
[**DocumentTicketsGetForProfile**](DocumentTicketsApi.md#documentticketsgetforprofile) | **GET** /api/DocumentTickets/ticket/{id} | This call returns the ticket for downloading a file associated with a specified profile
[**DocumentTicketsGetForTask**](DocumentTicketsApi.md#documentticketsgetfortask) | **GET** /api/DocumentTickets/ticketForTask/{processDocId}/{taskWorkId} | This call returns the ticket for downloading a file associated with a taskwork and a document in process
[**DocumentTicketsGetForTaskAttachement**](DocumentTicketsApi.md#documentticketsgetfortaskattachement) | **GET** /api/DocumentTickets/ticketTaskattachments/{id} | This call returns the ticket for downloading a file associated with the task attachment
[**DocumentTicketsGetForTaskReadOnly**](DocumentTicketsApi.md#documentticketsgetfortaskreadonly) | **GET** /api/DocumentTickets/ticketForTaskReadOnly/{processDocId}/{taskWorkId} | This call returns the ticket for downloading a file associated with a taskwork and a document in process, for read-only management
[**DocumentTicketsGetRevisionDocumentById**](DocumentTicketsApi.md#documentticketsgetrevisiondocumentbyid) | **GET** /api/DocumentTickets/ticketProfileAttachment/{attachmentId}/revisions/{revisionId} | This call retrieve the ticket for downloading an attachemnt file by its revision


<a name="documentticketsgetdocumentbyrevisionid"></a>
# **DocumentTicketsGetDocumentByRevisionId**
> string DocumentTicketsGetDocumentByRevisionId (int? revisionId, bool? forView = null)

This call returns the ticket for downloading a document associated to a specified revision

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentTicketsGetDocumentByRevisionIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentTicketsApi();
            var revisionId = 56;  // int? | Identifier of revision
            var forView = true;  // bool? | Cryptographic envelope removed and stylesheet applied if available (optional) 

            try
            {
                // This call returns the ticket for downloading a document associated to a specified revision
                string result = apiInstance.DocumentTicketsGetDocumentByRevisionId(revisionId, forView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTicketsApi.DocumentTicketsGetDocumentByRevisionId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **revisionId** | **int?**| Identifier of revision | 
 **forView** | **bool?**| Cryptographic envelope removed and stylesheet applied if available | [optional] 

### Return type

**string**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentticketsgetforexternalattachment"></a>
# **DocumentTicketsGetForExternalAttachment**
> string DocumentTicketsGetForExternalAttachment (int? id, bool? forView = null)

This call retrieve a ticket for downloading a file for an external profile attachment

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentTicketsGetForExternalAttachmentExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentTicketsApi();
            var id = 56;  // int? | Identifier of attachment
            var forView = true;  // bool? | Cryptographic envelope removed and stylesheet applied if available (optional) 

            try
            {
                // This call retrieve a ticket for downloading a file for an external profile attachment
                string result = apiInstance.DocumentTicketsGetForExternalAttachment(id, forView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTicketsApi.DocumentTicketsGetForExternalAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Identifier of attachment | 
 **forView** | **bool?**| Cryptographic envelope removed and stylesheet applied if available | [optional] 

### Return type

**string**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentticketsgetforprocessattachement"></a>
# **DocumentTicketsGetForProcessAttachement**
> System.IO.Stream DocumentTicketsGetForProcessAttachement (int? attachementid, int? processId, bool? forView = null)

This call returns the ticket for downloading a file associated with the attachment into in a process workflow

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentTicketsGetForProcessAttachementExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentTicketsApi();
            var attachementid = 56;  // int? | Identifier of attachment
            var processId = 56;  // int? | Identifier of process
            var forView = true;  // bool? | Cryptographic envelope removed and stylesheet applied if available (optional) 

            try
            {
                // This call returns the ticket for downloading a file associated with the attachment into in a process workflow
                System.IO.Stream result = apiInstance.DocumentTicketsGetForProcessAttachement(attachementid, processId, forView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTicketsApi.DocumentTicketsGetForProcessAttachement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachementid** | **int?**| Identifier of attachment | 
 **processId** | **int?**| Identifier of process | 
 **forView** | **bool?**| Cryptographic envelope removed and stylesheet applied if available | [optional] 

### Return type

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentticketsgetforprocessdocument"></a>
# **DocumentTicketsGetForProcessDocument**
> System.IO.Stream DocumentTicketsGetForProcessDocument (int? processdocid, int? processId, bool? forView = null)

This call returns the ticket for downloading a file associated with the document process into in a process workflow

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentTicketsGetForProcessDocumentExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentTicketsApi();
            var processdocid = 56;  // int? | Identifier of document process
            var processId = 56;  // int? | Identifier of process workflow
            var forView = true;  // bool? | Cryptographic envelope removed and stylesheet applied if available (optional) 

            try
            {
                // This call returns the ticket for downloading a file associated with the document process into in a process workflow
                System.IO.Stream result = apiInstance.DocumentTicketsGetForProcessDocument(processdocid, processId, forView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTicketsApi.DocumentTicketsGetForProcessDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processdocid** | **int?**| Identifier of document process | 
 **processId** | **int?**| Identifier of process workflow | 
 **forView** | **bool?**| Cryptographic envelope removed and stylesheet applied if available | [optional] 

### Return type

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentticketsgetforprofile"></a>
# **DocumentTicketsGetForProfile**
> System.IO.Stream DocumentTicketsGetForProfile (int? id, bool? forView = null)

This call returns the ticket for downloading a file associated with a specified profile

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentTicketsGetForProfileExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentTicketsApi();
            var id = 56;  // int? | Document Identifier
            var forView = true;  // bool? | Cryptographic envelope removed and stylesheet applied if available (optional) 

            try
            {
                // This call returns the ticket for downloading a file associated with a specified profile
                System.IO.Stream result = apiInstance.DocumentTicketsGetForProfile(id, forView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTicketsApi.DocumentTicketsGetForProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Document Identifier | 
 **forView** | **bool?**| Cryptographic envelope removed and stylesheet applied if available | [optional] 

### Return type

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentticketsgetfortask"></a>
# **DocumentTicketsGetForTask**
> System.IO.Stream DocumentTicketsGetForTask (int? processDocId, int? taskWorkId, bool? forView = null)

This call returns the ticket for downloading a file associated with a taskwork and a document in process

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentTicketsGetForTaskExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentTicketsApi();
            var processDocId = 56;  // int? | Identifier of document process
            var taskWorkId = 56;  // int? | Identifier of taskwork
            var forView = true;  // bool? | Cryptographic envelope removed and stylesheet applied if available (optional) 

            try
            {
                // This call returns the ticket for downloading a file associated with a taskwork and a document in process
                System.IO.Stream result = apiInstance.DocumentTicketsGetForTask(processDocId, taskWorkId, forView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTicketsApi.DocumentTicketsGetForTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDocId** | **int?**| Identifier of document process | 
 **taskWorkId** | **int?**| Identifier of taskwork | 
 **forView** | **bool?**| Cryptographic envelope removed and stylesheet applied if available | [optional] 

### Return type

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentticketsgetfortaskattachement"></a>
# **DocumentTicketsGetForTaskAttachement**
> System.IO.Stream DocumentTicketsGetForTaskAttachement (int? id, bool? forView = null)

This call returns the ticket for downloading a file associated with the task attachment

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentTicketsGetForTaskAttachementExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentTicketsApi();
            var id = 56;  // int? | Identifier of task attachment
            var forView = true;  // bool? | Cryptographic envelope removed and stylesheet applied if available (optional) 

            try
            {
                // This call returns the ticket for downloading a file associated with the task attachment
                System.IO.Stream result = apiInstance.DocumentTicketsGetForTaskAttachement(id, forView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTicketsApi.DocumentTicketsGetForTaskAttachement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Identifier of task attachment | 
 **forView** | **bool?**| Cryptographic envelope removed and stylesheet applied if available | [optional] 

### Return type

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentticketsgetfortaskreadonly"></a>
# **DocumentTicketsGetForTaskReadOnly**
> System.IO.Stream DocumentTicketsGetForTaskReadOnly (int? processDocId, int? taskWorkId, bool? forView = null)

This call returns the ticket for downloading a file associated with a taskwork and a document in process, for read-only management

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentTicketsGetForTaskReadOnlyExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentTicketsApi();
            var processDocId = 56;  // int? | Identifier of document process
            var taskWorkId = 56;  // int? | Identifier of taskwork
            var forView = true;  // bool? | Cryptographic envelope removed and stylesheet applied if available (optional) 

            try
            {
                // This call returns the ticket for downloading a file associated with a taskwork and a document in process, for read-only management
                System.IO.Stream result = apiInstance.DocumentTicketsGetForTaskReadOnly(processDocId, taskWorkId, forView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTicketsApi.DocumentTicketsGetForTaskReadOnly: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDocId** | **int?**| Identifier of document process | 
 **taskWorkId** | **int?**| Identifier of taskwork | 
 **forView** | **bool?**| Cryptographic envelope removed and stylesheet applied if available | [optional] 

### Return type

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentticketsgetrevisiondocumentbyid"></a>
# **DocumentTicketsGetRevisionDocumentById**
> string DocumentTicketsGetRevisionDocumentById (int? attachmentId, int? revisionId, bool? forView = null)

This call retrieve the ticket for downloading an attachemnt file by its revision

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentTicketsGetRevisionDocumentByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentTicketsApi();
            var attachmentId = 56;  // int? | Identifier of attachment
            var revisionId = 56;  // int? | Revision Number
            var forView = true;  // bool? | Cryptographic envelope removed and stylesheet applied if available (optional) 

            try
            {
                // This call retrieve the ticket for downloading an attachemnt file by its revision
                string result = apiInstance.DocumentTicketsGetRevisionDocumentById(attachmentId, revisionId, forView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTicketsApi.DocumentTicketsGetRevisionDocumentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachmentId** | **int?**| Identifier of attachment | 
 **revisionId** | **int?**| Revision Number | 
 **forView** | **bool?**| Cryptographic envelope removed and stylesheet applied if available | [optional] 

### Return type

**string**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


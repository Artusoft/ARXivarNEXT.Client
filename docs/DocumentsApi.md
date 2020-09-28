# ARXivarNEXT.Client.Api.DocumentsApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DocumentsCanWrite**](DocumentsApi.md#documentscanwrite) | **POST** /api/Documents/{docnumber}/canWrite | This call returns if the user can write the file.
[**DocumentsCanWriteForTask**](DocumentsApi.md#documentscanwritefortask) | **POST** /api/Documents/forTask/{processDocId}/{taskWorkId}/canWrite | This call returns if the user can write the document under workflow process.
[**DocumentsExportMassiveForProfile**](DocumentsApi.md#documentsexportmassiveforprofile) | **POST** /api/Documents/ExportMassive | This call start new export procedure
[**DocumentsExportMassiveForProfile_0**](DocumentsApi.md#documentsexportmassiveforprofile_0) | **POST** /api/Documents/ExportMassiveProcessDoc | This call start new export procedure for processdoc
[**DocumentsGetDocumentByRevisionId**](DocumentsApi.md#documentsgetdocumentbyrevisionid) | **GET** /api/Documents/byRevision/{revisionId} | This call returns the document associated to a specified revision
[**DocumentsGetExtractP7M**](DocumentsApi.md#documentsgetextractp7m) | **GET** /api/Documents/{id}/extract | This call returns the file, contained in the signature, associated with the profile
[**DocumentsGetExtractedDocumentByRevisionId**](DocumentsApi.md#documentsgetextracteddocumentbyrevisionid) | **GET** /api/Documents/extractByRevision/{revisionId} | This call returns the document associated to a specified revision (extracted from cryptographic envelopes)
[**DocumentsGetExtractedForProfile**](DocumentsApi.md#documentsgetextractedforprofile) | **GET** /api/Documents/extract/{id} | This call returns the file associated with a specified profile (extracted from cryptographic envelopes)
[**DocumentsGetExtractedForTask**](DocumentsApi.md#documentsgetextractedfortask) | **GET** /api/Documents/extractForTask/{processDocId}/{taskWorkId} | This call returns the file associated with a taskwork and a document in process (extracted from cryptographic envelopes)
[**DocumentsGetExtractedForTaskAttachement**](DocumentsApi.md#documentsgetextractedfortaskattachement) | **GET** /api/Documents/extractTaskattachments/{id} | This call returns the file associated with the task attachment (extracted from cryptographic envelopes)
[**DocumentsGetExtractedProfileAttachment**](DocumentsApi.md#documentsgetextractedprofileattachment) | **GET** /api/Documents/extractProfileAttachment/{id} | This call retrieve a file for an external profile attachment (extracted from cryptographic envelopes)
[**DocumentsGetExtractedProfileAttachmentRevision**](DocumentsApi.md#documentsgetextractedprofileattachmentrevision) | **GET** /api/Documents/extractProfileAttachment/{attachmentId}/revisions/{attachmentRevisionId} | This call retrieve the attachemnt file by its revision (extracted from cryptographic envelopes)
[**DocumentsGetForExternalAttachment**](DocumentsApi.md#documentsgetforexternalattachment) | **GET** /api/Documents/profileAttachment/{id} | This call retrieve a file for an external profile attachment
[**DocumentsGetForMail**](DocumentsApi.md#documentsgetformail) | **GET** /api/Documents/GetMail/{id} | This call gets the document as attachment inside of an eml file
[**DocumentsGetForProcessAttachement**](DocumentsApi.md#documentsgetforprocessattachement) | **GET** /api/Documents/processattachments/{processId}/{attachementid} | This call returns the file associated with the attachment into in a process workflow
[**DocumentsGetForProcessDocument**](DocumentsApi.md#documentsgetforprocessdocument) | **GET** /api/Documents/processdocument/{processId}/{processdocid} | This call returns the file associated with the document process into in a process workflow
[**DocumentsGetForProfile**](DocumentsApi.md#documentsgetforprofile) | **GET** /api/Documents/{id} | This call returns the file associated with a specified profile
[**DocumentsGetForTask**](DocumentsApi.md#documentsgetfortask) | **GET** /api/Documents/ForTask/{processDocId}/{taskWorkId} | This call returns the file associated with a taskwork and a document in process
[**DocumentsGetForTaskAttachement**](DocumentsApi.md#documentsgetfortaskattachement) | **GET** /api/Documents/taskattachments/{id} | This call returns the file associated with the task attachment
[**DocumentsGetForTaskHasDocument**](DocumentsApi.md#documentsgetfortaskhasdocument) | **GET** /api/Documents/ForTask/HasDocument/{processDocId} | This call returns if the document process has a associated file
[**DocumentsGetForTaskReadOnly**](DocumentsApi.md#documentsgetfortaskreadonly) | **GET** /api/Documents/ForTaskReadOnly/{processDocId}/{taskWorkId} | This call returns the file associated with a taskwork and a document in process, for read-only management
[**DocumentsGetHasDocumentForProfile**](DocumentsApi.md#documentsgethasdocumentforprofile) | **GET** /api/Documents/HasDocument/{id} | This call returns if the profile has a associated file
[**DocumentsGetMailMassiveForProcessDoc**](DocumentsApi.md#documentsgetmailmassiveforprocessdoc) | **POST** /api/Documents/GetMailMassiveProcessDoc | Creates an asynchronous queue job that creates an eml file with process documents in attachment
[**DocumentsGetMailMassiveForProfile**](DocumentsApi.md#documentsgetmailmassiveforprofile) | **POST** /api/Documents/GetMailMassive | Creates an asynchronous queue job that creates an eml file with documents in attachment
[**DocumentsGetProcessdocForMail**](DocumentsApi.md#documentsgetprocessdocformail) | **GET** /api/Documents/GetMail/ForTask/{processDocId}/{taskWorkId} | This call gets the process document as attachment inside of an eml file
[**DocumentsGetRevisionDocumentById**](DocumentsApi.md#documentsgetrevisiondocumentbyid) | **GET** /api/Documents/profileAttachment/{attachmentId}/revisions/{revisionId} | This call retrieve the attachemnt file by its revision
[**DocumentsSetDocument**](DocumentsApi.md#documentssetdocument) | **POST** /api/Documents/{docNumber}/{cacheId} | This call update a file associated to a profile


<a name="documentscanwrite"></a>
# **DocumentsCanWrite**
> void DocumentsCanWrite (int? docnumber)

This call returns if the user can write the file.

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentsCanWriteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var docnumber = 56;  // int? | Document Identifier

            try
            {
                // This call returns if the user can write the file.
                apiInstance.DocumentsCanWrite(docnumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsCanWrite: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| Document Identifier | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentscanwritefortask"></a>
# **DocumentsCanWriteForTask**
> void DocumentsCanWriteForTask (int? processDocId, int? taskWorkId)

This call returns if the user can write the document under workflow process.

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentsCanWriteForTaskExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var processDocId = 56;  // int? | Identifier of document process
            var taskWorkId = 56;  // int? | Identifier of taskwork

            try
            {
                // This call returns if the user can write the document under workflow process.
                apiInstance.DocumentsCanWriteForTask(processDocId, taskWorkId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsCanWriteForTask: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsexportmassiveforprofile"></a>
# **DocumentsExportMassiveForProfile**
> System.IO.Stream DocumentsExportMassiveForProfile (ExportMassiveForProfileRequestDTO exportMassiveForProfileRequest)

This call start new export procedure

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentsExportMassiveForProfileExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var exportMassiveForProfileRequest = new ExportMassiveForProfileRequestDTO(); // ExportMassiveForProfileRequestDTO | Request for export procedure

            try
            {
                // This call start new export procedure
                System.IO.Stream result = apiInstance.DocumentsExportMassiveForProfile(exportMassiveForProfileRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsExportMassiveForProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exportMassiveForProfileRequest** | [**ExportMassiveForProfileRequestDTO**](ExportMassiveForProfileRequestDTO.md)| Request for export procedure | 

### Return type

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsexportmassiveforprofile_0"></a>
# **DocumentsExportMassiveForProfile_0**
> System.IO.Stream DocumentsExportMassiveForProfile_0 (ExportMassiveForProcessDocRequestDTO exportMassiveForProcessDocRequest)

This call start new export procedure for processdoc

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentsExportMassiveForProfile_0Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var exportMassiveForProcessDocRequest = new ExportMassiveForProcessDocRequestDTO(); // ExportMassiveForProcessDocRequestDTO | Request for export procedure

            try
            {
                // This call start new export procedure for processdoc
                System.IO.Stream result = apiInstance.DocumentsExportMassiveForProfile_0(exportMassiveForProcessDocRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsExportMassiveForProfile_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exportMassiveForProcessDocRequest** | [**ExportMassiveForProcessDocRequestDTO**](ExportMassiveForProcessDocRequestDTO.md)| Request for export procedure | 

### Return type

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsgetdocumentbyrevisionid"></a>
# **DocumentsGetDocumentByRevisionId**
> System.IO.Stream DocumentsGetDocumentByRevisionId (int? revisionId, bool? forView = null)

This call returns the document associated to a specified revision

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentsGetDocumentByRevisionIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var revisionId = 56;  // int? | Identifier of revision
            var forView = true;  // bool? | Cryptographic envelope removed and stylesheet applied if available (optional) 

            try
            {
                // This call returns the document associated to a specified revision
                System.IO.Stream result = apiInstance.DocumentsGetDocumentByRevisionId(revisionId, forView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetDocumentByRevisionId: " + e.Message );
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

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsgetextractp7m"></a>
# **DocumentsGetExtractP7M**
> System.IO.Stream DocumentsGetExtractP7M (int? id)

This call returns the file, contained in the signature, associated with the profile

This method is deprecated. Use {id}/{forView} instead

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentsGetExtractP7MExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var id = 56;  // int? | Document Identifier

            try
            {
                // This call returns the file, contained in the signature, associated with the profile
                System.IO.Stream result = apiInstance.DocumentsGetExtractP7M(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetExtractP7M: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Document Identifier | 

### Return type

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsgetextracteddocumentbyrevisionid"></a>
# **DocumentsGetExtractedDocumentByRevisionId**
> System.IO.Stream DocumentsGetExtractedDocumentByRevisionId (int? revisionId)

This call returns the document associated to a specified revision (extracted from cryptographic envelopes)

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentsGetExtractedDocumentByRevisionIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var revisionId = 56;  // int? | Identifier of revision

            try
            {
                // This call returns the document associated to a specified revision (extracted from cryptographic envelopes)
                System.IO.Stream result = apiInstance.DocumentsGetExtractedDocumentByRevisionId(revisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetExtractedDocumentByRevisionId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **revisionId** | **int?**| Identifier of revision | 

### Return type

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsgetextractedforprofile"></a>
# **DocumentsGetExtractedForProfile**
> System.IO.Stream DocumentsGetExtractedForProfile (int? id)

This call returns the file associated with a specified profile (extracted from cryptographic envelopes)

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentsGetExtractedForProfileExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var id = 56;  // int? | Document Identifier

            try
            {
                // This call returns the file associated with a specified profile (extracted from cryptographic envelopes)
                System.IO.Stream result = apiInstance.DocumentsGetExtractedForProfile(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetExtractedForProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Document Identifier | 

### Return type

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsgetextractedfortask"></a>
# **DocumentsGetExtractedForTask**
> System.IO.Stream DocumentsGetExtractedForTask (int? processDocId, int? taskWorkId)

This call returns the file associated with a taskwork and a document in process (extracted from cryptographic envelopes)

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentsGetExtractedForTaskExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var processDocId = 56;  // int? | Identifier of document process
            var taskWorkId = 56;  // int? | Identifier of taskwork

            try
            {
                // This call returns the file associated with a taskwork and a document in process (extracted from cryptographic envelopes)
                System.IO.Stream result = apiInstance.DocumentsGetExtractedForTask(processDocId, taskWorkId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetExtractedForTask: " + e.Message );
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

### Return type

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsgetextractedfortaskattachement"></a>
# **DocumentsGetExtractedForTaskAttachement**
> System.IO.Stream DocumentsGetExtractedForTaskAttachement (int? id)

This call returns the file associated with the task attachment (extracted from cryptographic envelopes)

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentsGetExtractedForTaskAttachementExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var id = 56;  // int? | Identifier of task attachment

            try
            {
                // This call returns the file associated with the task attachment (extracted from cryptographic envelopes)
                System.IO.Stream result = apiInstance.DocumentsGetExtractedForTaskAttachement(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetExtractedForTaskAttachement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Identifier of task attachment | 

### Return type

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsgetextractedprofileattachment"></a>
# **DocumentsGetExtractedProfileAttachment**
> System.IO.Stream DocumentsGetExtractedProfileAttachment (int? id)

This call retrieve a file for an external profile attachment (extracted from cryptographic envelopes)

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentsGetExtractedProfileAttachmentExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var id = 56;  // int? | Identifier of attachment

            try
            {
                // This call retrieve a file for an external profile attachment (extracted from cryptographic envelopes)
                System.IO.Stream result = apiInstance.DocumentsGetExtractedProfileAttachment(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetExtractedProfileAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Identifier of attachment | 

### Return type

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsgetextractedprofileattachmentrevision"></a>
# **DocumentsGetExtractedProfileAttachmentRevision**
> System.IO.Stream DocumentsGetExtractedProfileAttachmentRevision (int? attachmentId, int? attachmentRevisionId)

This call retrieve the attachemnt file by its revision (extracted from cryptographic envelopes)

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentsGetExtractedProfileAttachmentRevisionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var attachmentId = 56;  // int? | Identifier of attachment
            var attachmentRevisionId = 56;  // int? | Identifier of attachment revision

            try
            {
                // This call retrieve the attachemnt file by its revision (extracted from cryptographic envelopes)
                System.IO.Stream result = apiInstance.DocumentsGetExtractedProfileAttachmentRevision(attachmentId, attachmentRevisionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetExtractedProfileAttachmentRevision: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachmentId** | **int?**| Identifier of attachment | 
 **attachmentRevisionId** | **int?**| Identifier of attachment revision | 

### Return type

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsgetforexternalattachment"></a>
# **DocumentsGetForExternalAttachment**
> System.IO.Stream DocumentsGetForExternalAttachment (int? id, bool? forView = null)

This call retrieve a file for an external profile attachment

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentsGetForExternalAttachmentExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var id = 56;  // int? | Identifier of attachment
            var forView = true;  // bool? | Cryptographic envelope removed and stylesheet applied if available (optional) 

            try
            {
                // This call retrieve a file for an external profile attachment
                System.IO.Stream result = apiInstance.DocumentsGetForExternalAttachment(id, forView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetForExternalAttachment: " + e.Message );
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

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsgetformail"></a>
# **DocumentsGetForMail**
> System.IO.Stream DocumentsGetForMail (int? id, bool? forView, bool? createZip)

This call gets the document as attachment inside of an eml file

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentsGetForMailExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var id = 56;  // int? | Docnumber
            var forView = true;  // bool? | Cryptographic envelopes will be removed and stylesheet applied
            var createZip = true;  // bool? | Attachment as zip

            try
            {
                // This call gets the document as attachment inside of an eml file
                System.IO.Stream result = apiInstance.DocumentsGetForMail(id, forView, createZip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetForMail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Docnumber | 
 **forView** | **bool?**| Cryptographic envelopes will be removed and stylesheet applied | 
 **createZip** | **bool?**| Attachment as zip | 

### Return type

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsgetforprocessattachement"></a>
# **DocumentsGetForProcessAttachement**
> System.IO.Stream DocumentsGetForProcessAttachement (int? attachementid, int? processId, bool? forView = null)

This call returns the file associated with the attachment into in a process workflow

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentsGetForProcessAttachementExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var attachementid = 56;  // int? | Identifier of attachment
            var processId = 56;  // int? | Identifier of process
            var forView = true;  // bool? | Cryptographic envelope removed and stylesheet applied if available (optional) 

            try
            {
                // This call returns the file associated with the attachment into in a process workflow
                System.IO.Stream result = apiInstance.DocumentsGetForProcessAttachement(attachementid, processId, forView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetForProcessAttachement: " + e.Message );
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

<a name="documentsgetforprocessdocument"></a>
# **DocumentsGetForProcessDocument**
> System.IO.Stream DocumentsGetForProcessDocument (int? processdocid, int? processId, bool? forView = null)

This call returns the file associated with the document process into in a process workflow

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentsGetForProcessDocumentExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var processdocid = 56;  // int? | Identifier of document process
            var processId = 56;  // int? | Identifier of process workflow
            var forView = true;  // bool? | Cryptographic envelope removed and stylesheet applied if available (optional) 

            try
            {
                // This call returns the file associated with the document process into in a process workflow
                System.IO.Stream result = apiInstance.DocumentsGetForProcessDocument(processdocid, processId, forView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetForProcessDocument: " + e.Message );
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

<a name="documentsgetforprofile"></a>
# **DocumentsGetForProfile**
> System.IO.Stream DocumentsGetForProfile (int? id, bool? forView = null)

This call returns the file associated with a specified profile

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentsGetForProfileExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var id = 56;  // int? | Document Identifier
            var forView = true;  // bool? | Cryptographic envelope removed and stylesheet applied if available (optional) 

            try
            {
                // This call returns the file associated with a specified profile
                System.IO.Stream result = apiInstance.DocumentsGetForProfile(id, forView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetForProfile: " + e.Message );
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

<a name="documentsgetfortask"></a>
# **DocumentsGetForTask**
> System.IO.Stream DocumentsGetForTask (int? processDocId, int? taskWorkId, bool? forView = null)

This call returns the file associated with a taskwork and a document in process

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentsGetForTaskExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var processDocId = 56;  // int? | Identifier of document process
            var taskWorkId = 56;  // int? | Identifier of taskwork
            var forView = true;  // bool? | Cryptographic envelope removed and stylesheet applied if available (optional) 

            try
            {
                // This call returns the file associated with a taskwork and a document in process
                System.IO.Stream result = apiInstance.DocumentsGetForTask(processDocId, taskWorkId, forView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetForTask: " + e.Message );
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

<a name="documentsgetfortaskattachement"></a>
# **DocumentsGetForTaskAttachement**
> System.IO.Stream DocumentsGetForTaskAttachement (int? id, bool? forView = null)

This call returns the file associated with the task attachment

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentsGetForTaskAttachementExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var id = 56;  // int? | Identifier of task attachment
            var forView = true;  // bool? | Cryptographic envelope removed and stylesheet applied if available (optional) 

            try
            {
                // This call returns the file associated with the task attachment
                System.IO.Stream result = apiInstance.DocumentsGetForTaskAttachement(id, forView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetForTaskAttachement: " + e.Message );
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

<a name="documentsgetfortaskhasdocument"></a>
# **DocumentsGetForTaskHasDocument**
> bool? DocumentsGetForTaskHasDocument (int? processDocId)

This call returns if the document process has a associated file

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentsGetForTaskHasDocumentExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var processDocId = 56;  // int? | Identifier of document process

            try
            {
                // This call returns if the document process has a associated file
                bool? result = apiInstance.DocumentsGetForTaskHasDocument(processDocId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetForTaskHasDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDocId** | **int?**| Identifier of document process | 

### Return type

**bool?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsgetfortaskreadonly"></a>
# **DocumentsGetForTaskReadOnly**
> System.IO.Stream DocumentsGetForTaskReadOnly (int? processDocId, int? taskWorkId, bool? forView = null)

This call returns the file associated with a taskwork and a document in process, for read-only management

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentsGetForTaskReadOnlyExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var processDocId = 56;  // int? | Identifier of document process
            var taskWorkId = 56;  // int? | Identifier of taskwork
            var forView = true;  // bool? | Cryptographic envelope removed and stylesheet applied if available (optional) 

            try
            {
                // This call returns the file associated with a taskwork and a document in process, for read-only management
                System.IO.Stream result = apiInstance.DocumentsGetForTaskReadOnly(processDocId, taskWorkId, forView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetForTaskReadOnly: " + e.Message );
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

<a name="documentsgethasdocumentforprofile"></a>
# **DocumentsGetHasDocumentForProfile**
> bool? DocumentsGetHasDocumentForProfile (int? id)

This call returns if the profile has a associated file

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentsGetHasDocumentForProfileExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var id = 56;  // int? | Document Identifier

            try
            {
                // This call returns if the profile has a associated file
                bool? result = apiInstance.DocumentsGetHasDocumentForProfile(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetHasDocumentForProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Document Identifier | 

### Return type

**bool?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsgetmailmassiveforprocessdoc"></a>
# **DocumentsGetMailMassiveForProcessDoc**
> MailMassiveForProfileResponseDTO DocumentsGetMailMassiveForProcessDoc (MailMassiveForProcessDocRequestDTO mailMassiveForProcessDocRequest)

Creates an asynchronous queue job that creates an eml file with process documents in attachment

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentsGetMailMassiveForProcessDocExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var mailMassiveForProcessDocRequest = new MailMassiveForProcessDocRequestDTO(); // MailMassiveForProcessDocRequestDTO | 

            try
            {
                // Creates an asynchronous queue job that creates an eml file with process documents in attachment
                MailMassiveForProfileResponseDTO result = apiInstance.DocumentsGetMailMassiveForProcessDoc(mailMassiveForProcessDocRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetMailMassiveForProcessDoc: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mailMassiveForProcessDocRequest** | [**MailMassiveForProcessDocRequestDTO**](MailMassiveForProcessDocRequestDTO.md)|  | 

### Return type

[**MailMassiveForProfileResponseDTO**](MailMassiveForProfileResponseDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsgetmailmassiveforprofile"></a>
# **DocumentsGetMailMassiveForProfile**
> MailMassiveForProfileResponseDTO DocumentsGetMailMassiveForProfile (MailMassiveForProfileRequestDTO mailMassiveForProfileRequest)

Creates an asynchronous queue job that creates an eml file with documents in attachment

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentsGetMailMassiveForProfileExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var mailMassiveForProfileRequest = new MailMassiveForProfileRequestDTO(); // MailMassiveForProfileRequestDTO | 

            try
            {
                // Creates an asynchronous queue job that creates an eml file with documents in attachment
                MailMassiveForProfileResponseDTO result = apiInstance.DocumentsGetMailMassiveForProfile(mailMassiveForProfileRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetMailMassiveForProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mailMassiveForProfileRequest** | [**MailMassiveForProfileRequestDTO**](MailMassiveForProfileRequestDTO.md)|  | 

### Return type

[**MailMassiveForProfileResponseDTO**](MailMassiveForProfileResponseDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsgetprocessdocformail"></a>
# **DocumentsGetProcessdocForMail**
> System.IO.Stream DocumentsGetProcessdocForMail (int? processDocId, int? taskWorkId, bool? forView, bool? createZip)

This call gets the process document as attachment inside of an eml file

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentsGetProcessdocForMailExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var processDocId = 56;  // int? | Id of process document
            var taskWorkId = 56;  // int? | Id of task
            var forView = true;  // bool? | Cryptographic envelopes will be removed and stylesheet applied
            var createZip = true;  // bool? | Attachment as zip

            try
            {
                // This call gets the process document as attachment inside of an eml file
                System.IO.Stream result = apiInstance.DocumentsGetProcessdocForMail(processDocId, taskWorkId, forView, createZip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetProcessdocForMail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDocId** | **int?**| Id of process document | 
 **taskWorkId** | **int?**| Id of task | 
 **forView** | **bool?**| Cryptographic envelopes will be removed and stylesheet applied | 
 **createZip** | **bool?**| Attachment as zip | 

### Return type

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsgetrevisiondocumentbyid"></a>
# **DocumentsGetRevisionDocumentById**
> System.IO.Stream DocumentsGetRevisionDocumentById (int? attachmentId, int? revisionId, bool? forView = null)

This call retrieve the attachemnt file by its revision

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentsGetRevisionDocumentByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var attachmentId = 56;  // int? | Identifier of attachment
            var revisionId = 56;  // int? | Revision Number
            var forView = true;  // bool? | Cryptographic envelope removed and stylesheet applied if available (optional) 

            try
            {
                // This call retrieve the attachemnt file by its revision
                System.IO.Stream result = apiInstance.DocumentsGetRevisionDocumentById(attachmentId, revisionId, forView);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetRevisionDocumentById: " + e.Message );
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

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentssetdocument"></a>
# **DocumentsSetDocument**
> void DocumentsSetDocument (string cacheId, int? docNumber)

This call update a file associated to a profile

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class DocumentsSetDocumentExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var cacheId = cacheId_example;  // string | Identifier of cache
            var docNumber = 56;  // int? | Document Identifier

            try
            {
                // This call update a file associated to a profile
                apiInstance.DocumentsSetDocument(cacheId, docNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsSetDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cacheId** | **string**| Identifier of cache | 
 **docNumber** | **int?**| Document Identifier | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# ARXivarNEXT.Client.Api.AttachmentsApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AttachmentsAttachmentRevisionByRevision**](AttachmentsApi.md#attachmentsattachmentrevisionbyrevision) | **POST** /api/Attachments/{attachmentId}/Revisions/{revisionId} | This call adds a revision for the attachment by a existent revision
[**AttachmentsConvertoToPrincipalDocument**](AttachmentsApi.md#attachmentsconvertotoprincipaldocument) | **POST** /api/Attachments/{attachmentId}/convertToPrincipal | This call converts an attachment file to the profile file
[**AttachmentsDelete**](AttachmentsApi.md#attachmentsdelete) | **DELETE** /api/Attachments/{id} | This call deletes an attachment by its identifier
[**AttachmentsDeleteRevision**](AttachmentsApi.md#attachmentsdeleterevision) | **DELETE** /api/Attachments/Revisions/{revisionId} | This call deletes revision by its identifier
[**AttachmentsGetByDocnumber**](AttachmentsApi.md#attachmentsgetbydocnumber) | **GET** /api/Attachments/docnumber/{docnumber} | This call retrieves all the attachments of a profile
[**AttachmentsGetByDocnumberForGrid**](AttachmentsApi.md#attachmentsgetbydocnumberforgrid) | **GET** /api/Attachments/docnumber/{docnumber}/grid | This call returns the data for external and internal attachement of a profile
[**AttachmentsGetById**](AttachmentsApi.md#attachmentsgetbyid) | **GET** /api/Attachments/{id} | This call returns the attachment by its identifier
[**AttachmentsGetRevisionsByAttachmentId**](AttachmentsApi.md#attachmentsgetrevisionsbyattachmentid) | **GET** /api/Attachments/{attachmentId}/Revisions | This call retrieves the list of the revisions of an attachment
[**AttachmentsInsertExternal**](AttachmentsApi.md#attachmentsinsertexternal) | **POST** /api/Attachments/InsertExternal/{bufferid}/{docnumber} | This call adds a new external attachment for a profile
[**AttachmentsInsertInternal**](AttachmentsApi.md#attachmentsinsertinternal) | **POST** /api/Attachments/InsertInternal/{attachmentDocnumber}/{docnumber} | This call adds a new internal attachment for a profile
[**AttachmentsPermissionsById**](AttachmentsApi.md#attachmentspermissionsbyid) | **GET** /api/Attachments/{id}/Permissions | This call returns the permissions for an attachment
[**AttachmentsPutAttachmentDocument**](AttachmentsApi.md#attachmentsputattachmentdocument) | **PUT** /api/Attachments/{attachmentId}/Document/{bufferId} | This call updates attachment file
[**AttachmentsUpdate**](AttachmentsApi.md#attachmentsupdate) | **PUT** /api/Attachments/{id} | This call updates a attachment by its identifier
[**AttachmentsWritePermissionsById**](AttachmentsApi.md#attachmentswritepermissionsbyid) | **POST** /api/Attachments/{id}/Permissions | This call updates permission of an attachment


<a name="attachmentsattachmentrevisionbyrevision"></a>
# **AttachmentsAttachmentRevisionByRevision**
> void AttachmentsAttachmentRevisionByRevision (int? attachmentId, int? revisionId)

This call adds a revision for the attachment by a existent revision

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AttachmentsAttachmentRevisionByRevisionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AttachmentsApi();
            var attachmentId = 56;  // int? | Identifier of the attachment
            var revisionId = 56;  // int? | Identifier of the revision

            try
            {
                // This call adds a revision for the attachment by a existent revision
                apiInstance.AttachmentsAttachmentRevisionByRevision(attachmentId, revisionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AttachmentsAttachmentRevisionByRevision: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachmentId** | **int?**| Identifier of the attachment | 
 **revisionId** | **int?**| Identifier of the revision | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachmentsconvertotoprincipaldocument"></a>
# **AttachmentsConvertoToPrincipalDocument**
> void AttachmentsConvertoToPrincipalDocument (int? attachmentId)

This call converts an attachment file to the profile file

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AttachmentsConvertoToPrincipalDocumentExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AttachmentsApi();
            var attachmentId = 56;  // int? | Identifier of the attachment

            try
            {
                // This call converts an attachment file to the profile file
                apiInstance.AttachmentsConvertoToPrincipalDocument(attachmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AttachmentsConvertoToPrincipalDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachmentId** | **int?**| Identifier of the attachment | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachmentsdelete"></a>
# **AttachmentsDelete**
> void AttachmentsDelete (int? id)

This call deletes an attachment by its identifier

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AttachmentsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AttachmentsApi();
            var id = 56;  // int? | Identifier of the attachment

            try
            {
                // This call deletes an attachment by its identifier
                apiInstance.AttachmentsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AttachmentsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Identifier of the attachment | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachmentsdeleterevision"></a>
# **AttachmentsDeleteRevision**
> void AttachmentsDeleteRevision (int? revisionId)

This call deletes revision by its identifier

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AttachmentsDeleteRevisionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AttachmentsApi();
            var revisionId = 56;  // int? | Identifier of the revision

            try
            {
                // This call deletes revision by its identifier
                apiInstance.AttachmentsDeleteRevision(revisionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AttachmentsDeleteRevision: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **revisionId** | **int?**| Identifier of the revision | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachmentsgetbydocnumber"></a>
# **AttachmentsGetByDocnumber**
> List<AttachmentDTO> AttachmentsGetByDocnumber (int? docnumber)

This call retrieves all the attachments of a profile

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AttachmentsGetByDocnumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AttachmentsApi();
            var docnumber = 56;  // int? | Identifier of the profile

            try
            {
                // This call retrieves all the attachments of a profile
                List&lt;AttachmentDTO&gt; result = apiInstance.AttachmentsGetByDocnumber(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AttachmentsGetByDocnumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| Identifier of the profile | 

### Return type

[**List<AttachmentDTO>**](AttachmentDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachmentsgetbydocnumberforgrid"></a>
# **AttachmentsGetByDocnumberForGrid**
> AttachmentsDataSourceDTO AttachmentsGetByDocnumberForGrid (int? docnumber)

This call returns the data for external and internal attachement of a profile

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AttachmentsGetByDocnumberForGridExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AttachmentsApi();
            var docnumber = 56;  // int? | Identifier of the profile

            try
            {
                // This call returns the data for external and internal attachement of a profile
                AttachmentsDataSourceDTO result = apiInstance.AttachmentsGetByDocnumberForGrid(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AttachmentsGetByDocnumberForGrid: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| Identifier of the profile | 

### Return type

[**AttachmentsDataSourceDTO**](AttachmentsDataSourceDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachmentsgetbyid"></a>
# **AttachmentsGetById**
> AttachmentDTO AttachmentsGetById (int? id)

This call returns the attachment by its identifier

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AttachmentsGetByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AttachmentsApi();
            var id = 56;  // int? | Identifier of the attachment

            try
            {
                // This call returns the attachment by its identifier
                AttachmentDTO result = apiInstance.AttachmentsGetById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AttachmentsGetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Identifier of the attachment | 

### Return type

[**AttachmentDTO**](AttachmentDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachmentsgetrevisionsbyattachmentid"></a>
# **AttachmentsGetRevisionsByAttachmentId**
> List<AttachmentRevisionDTO> AttachmentsGetRevisionsByAttachmentId (int? attachmentId)

This call retrieves the list of the revisions of an attachment

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AttachmentsGetRevisionsByAttachmentIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AttachmentsApi();
            var attachmentId = 56;  // int? | Identifier of the attachment

            try
            {
                // This call retrieves the list of the revisions of an attachment
                List&lt;AttachmentRevisionDTO&gt; result = apiInstance.AttachmentsGetRevisionsByAttachmentId(attachmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AttachmentsGetRevisionsByAttachmentId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachmentId** | **int?**| Identifier of the attachment | 

### Return type

[**List<AttachmentRevisionDTO>**](AttachmentRevisionDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachmentsinsertexternal"></a>
# **AttachmentsInsertExternal**
> AttachmentDTO AttachmentsInsertExternal (string bufferid, int? docnumber, string comment)

This call adds a new external attachment for a profile

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AttachmentsInsertExternalExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AttachmentsApi();
            var bufferid = bufferid_example;  // string | Buffer Identifier of the file to attach
            var docnumber = 56;  // int? | Identifier of the profile
            var comment = comment_example;  // string | Comment for the new attachment

            try
            {
                // This call adds a new external attachment for a profile
                AttachmentDTO result = apiInstance.AttachmentsInsertExternal(bufferid, docnumber, comment);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AttachmentsInsertExternal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bufferid** | **string**| Buffer Identifier of the file to attach | 
 **docnumber** | **int?**| Identifier of the profile | 
 **comment** | **string**| Comment for the new attachment | 

### Return type

[**AttachmentDTO**](AttachmentDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachmentsinsertinternal"></a>
# **AttachmentsInsertInternal**
> AttachmentDTO AttachmentsInsertInternal (int? attachmentDocnumber, int? docnumber)

This call adds a new internal attachment for a profile

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AttachmentsInsertInternalExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AttachmentsApi();
            var attachmentDocnumber = 56;  // int? | Identifier of the attachment
            var docnumber = 56;  // int? | Identifier of the profile

            try
            {
                // This call adds a new internal attachment for a profile
                AttachmentDTO result = apiInstance.AttachmentsInsertInternal(attachmentDocnumber, docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AttachmentsInsertInternal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachmentDocnumber** | **int?**| Identifier of the attachment | 
 **docnumber** | **int?**| Identifier of the profile | 

### Return type

[**AttachmentDTO**](AttachmentDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachmentspermissionsbyid"></a>
# **AttachmentsPermissionsById**
> PermissionsDTO AttachmentsPermissionsById (int? id)

This call returns the permissions for an attachment

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AttachmentsPermissionsByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AttachmentsApi();
            var id = 56;  // int? | Identifier of the attachment

            try
            {
                // This call returns the permissions for an attachment
                PermissionsDTO result = apiInstance.AttachmentsPermissionsById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AttachmentsPermissionsById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Identifier of the attachment | 

### Return type

[**PermissionsDTO**](PermissionsDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachmentsputattachmentdocument"></a>
# **AttachmentsPutAttachmentDocument**
> void AttachmentsPutAttachmentDocument (int? attachmentId, string bufferId)

This call updates attachment file

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AttachmentsPutAttachmentDocumentExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AttachmentsApi();
            var attachmentId = 56;  // int? | Identifier of the attachment
            var bufferId = bufferId_example;  // string | Buffer Identifier of the file

            try
            {
                // This call updates attachment file
                apiInstance.AttachmentsPutAttachmentDocument(attachmentId, bufferId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AttachmentsPutAttachmentDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachmentId** | **int?**| Identifier of the attachment | 
 **bufferId** | **string**| Buffer Identifier of the file | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachmentsupdate"></a>
# **AttachmentsUpdate**
> void AttachmentsUpdate (int? id, AttachmentDTO attachment)

This call updates a attachment by its identifier

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AttachmentsUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AttachmentsApi();
            var id = 56;  // int? | Identifier of the attachment
            var attachment = new AttachmentDTO(); // AttachmentDTO | Object that indicates the attachment data to update

            try
            {
                // This call updates a attachment by its identifier
                apiInstance.AttachmentsUpdate(id, attachment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AttachmentsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Identifier of the attachment | 
 **attachment** | [**AttachmentDTO**](AttachmentDTO.md)| Object that indicates the attachment data to update | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachmentswritepermissionsbyid"></a>
# **AttachmentsWritePermissionsById**
> void AttachmentsWritePermissionsById (int? id, PermissionsDTO permissions)

This call updates permission of an attachment

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AttachmentsWritePermissionsByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AttachmentsApi();
            var id = 56;  // int? | Identifier of the attachment
            var permissions = new PermissionsDTO(); // PermissionsDTO | Permission data to update

            try
            {
                // This call updates permission of an attachment
                apiInstance.AttachmentsWritePermissionsById(id, permissions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AttachmentsWritePermissionsById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Identifier of the attachment | 
 **permissions** | [**PermissionsDTO**](PermissionsDTO.md)| Permission data to update | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


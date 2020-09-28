# ARXivarNEXT.Client.Api.RevisionsApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RevisionsDelete**](RevisionsApi.md#revisionsdelete) | **DELETE** /api/Revisions/{revisionId} | This call deletes a revision
[**RevisionsGetByDocnumber**](RevisionsApi.md#revisionsgetbydocnumber) | **GET** /api/Revisions/byDocnumber/{docnumber} | This call returns all revisions of a document
[**RevisionsRevisionByRevision**](RevisionsApi.md#revisionsrevisionbyrevision) | **POST** /api/Revisions/{docNumber}/{revision}/{option} | This call adds a revision from an existent revision of a document
[**RevisionsRevisionByRevision_0**](RevisionsApi.md#revisionsrevisionbyrevision_0) | **POST** /api/Revisions/task/{taskWorkId}/{processDocId}/{revision}/{option} | This call adds a revision from an existent revision of a profile in a task


<a name="revisionsdelete"></a>
# **RevisionsDelete**
> void RevisionsDelete (int? revisionId)

This call deletes a revision

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class RevisionsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RevisionsApi();
            var revisionId = 56;  // int? | Revision Identifier

            try
            {
                // This call deletes a revision
                apiInstance.RevisionsDelete(revisionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RevisionsApi.RevisionsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **revisionId** | **int?**| Revision Identifier | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="revisionsgetbydocnumber"></a>
# **RevisionsGetByDocnumber**
> List<RevisionDTO> RevisionsGetByDocnumber (int? docnumber)

This call returns all revisions of a document

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class RevisionsGetByDocnumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RevisionsApi();
            var docnumber = 56;  // int? | Document Identifier

            try
            {
                // This call returns all revisions of a document
                List&lt;RevisionDTO&gt; result = apiInstance.RevisionsGetByDocnumber(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RevisionsApi.RevisionsGetByDocnumber: " + e.Message );
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

[**List<RevisionDTO>**](RevisionDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="revisionsrevisionbyrevision"></a>
# **RevisionsRevisionByRevision**
> void RevisionsRevisionByRevision (int? docNumber, int? revision, int? option)

This call adds a revision from an existent revision of a document

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class RevisionsRevisionByRevisionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RevisionsApi();
            var docNumber = 56;  // int? | Document Identifier
            var revision = 56;  // int? | Revision number to start
            var option = 56;  // int? | Advanced options

            try
            {
                // This call adds a revision from an existent revision of a document
                apiInstance.RevisionsRevisionByRevision(docNumber, revision, option);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RevisionsApi.RevisionsRevisionByRevision: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docNumber** | **int?**| Document Identifier | 
 **revision** | **int?**| Revision number to start | 
 **option** | **int?**| Advanced options | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="revisionsrevisionbyrevision_0"></a>
# **RevisionsRevisionByRevision_0**
> void RevisionsRevisionByRevision_0 (int? taskWorkId, int? processDocId, int? revision, int? option)

This call adds a revision from an existent revision of a profile in a task

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class RevisionsRevisionByRevision_0Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RevisionsApi();
            var taskWorkId = 56;  // int? | Taskwork Identifier
            var processDocId = 56;  // int? | Process Document Identifier
            var revision = 56;  // int? | Revision number to start
            var option = 56;  // int? | Advanced options

            try
            {
                // This call adds a revision from an existent revision of a profile in a task
                apiInstance.RevisionsRevisionByRevision_0(taskWorkId, processDocId, revision, option);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RevisionsApi.RevisionsRevisionByRevision_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskWorkId** | **int?**| Taskwork Identifier | 
 **processDocId** | **int?**| Process Document Identifier | 
 **revision** | **int?**| Revision number to start | 
 **option** | **int?**| Advanced options | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


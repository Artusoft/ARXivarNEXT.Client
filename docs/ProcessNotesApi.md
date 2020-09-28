# ARXivarNEXT.Client.Api.ProcessNotesApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProcessNotesDelete**](ProcessNotesApi.md#processnotesdelete) | **DELETE** /api/ProcessNotes/{noteworkid} | This call deletes a process note
[**ProcessNotesInsert**](ProcessNotesApi.md#processnotesinsert) | **POST** /api/ProcessNotes/insert | This call inserts a new note
[**ProcessNotesUpdate**](ProcessNotesApi.md#processnotesupdate) | **PUT** /api/ProcessNotes/update | This call updates a process note


<a name="processnotesdelete"></a>
# **ProcessNotesDelete**
> void ProcessNotesDelete (int? noteworkid)

This call deletes a process note

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProcessNotesDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProcessNotesApi();
            var noteworkid = 56;  // int? | Process note idenfier

            try
            {
                // This call deletes a process note
                apiInstance.ProcessNotesDelete(noteworkid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessNotesApi.ProcessNotesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **noteworkid** | **int?**| Process note idenfier | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processnotesinsert"></a>
# **ProcessNotesInsert**
> ProcessNoteDTO ProcessNotesInsert (ProcessNoteDTO note)

This call inserts a new note

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProcessNotesInsertExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProcessNotesApi();
            var note = new ProcessNoteDTO(); // ProcessNoteDTO | Note information to insert

            try
            {
                // This call inserts a new note
                ProcessNoteDTO result = apiInstance.ProcessNotesInsert(note);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessNotesApi.ProcessNotesInsert: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **note** | [**ProcessNoteDTO**](ProcessNoteDTO.md)| Note information to insert | 

### Return type

[**ProcessNoteDTO**](ProcessNoteDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processnotesupdate"></a>
# **ProcessNotesUpdate**
> ProcessNoteDTO ProcessNotesUpdate (ProcessNoteDTO note)

This call updates a process note

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProcessNotesUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProcessNotesApi();
            var note = new ProcessNoteDTO(); // ProcessNoteDTO | Note information to update

            try
            {
                // This call updates a process note
                ProcessNoteDTO result = apiInstance.ProcessNotesUpdate(note);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessNotesApi.ProcessNotesUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **note** | [**ProcessNoteDTO**](ProcessNoteDTO.md)| Note information to update | 

### Return type

[**ProcessNoteDTO**](ProcessNoteDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


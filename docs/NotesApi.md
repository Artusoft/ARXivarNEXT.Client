# ARXivarNEXT.Client.Api.NotesApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NotesChangeAosFlag**](NotesApi.md#noteschangeaosflag) | **GET** /api/Notes/aosflag/{noteId}/{aosFlag} | This call changes the value for the aos flag of a note
[**NotesDeleteById**](NotesApi.md#notesdeletebyid) | **DELETE** /api/Notes/{noteId} | This call deletes a note
[**NotesGetByDocnumber**](NotesApi.md#notesgetbydocnumber) | **GET** /api/Notes/{docnumber} | This call returns all the notes for a profile
[**NotesGetById**](NotesApi.md#notesgetbyid) | **GET** /api/Notes/byid/{id} | This call returns a note
[**NotesGetPermissions**](NotesApi.md#notesgetpermissions) | **GET** /api/Notes/permissions/{noteId} | This call returns the permissions for a note
[**NotesNewNote**](NotesApi.md#notesnewnote) | **POST** /api/Notes | This call adds new note
[**NotesUpdateNote**](NotesApi.md#notesupdatenote) | **PUT** /api/Notes/{id} | This call updates a note
[**NotesWritePermissions**](NotesApi.md#noteswritepermissions) | **POST** /api/Notes/permissions/{noteId} | This call updates the permissions for a note


<a name="noteschangeaosflag"></a>
# **NotesChangeAosFlag**
> void NotesChangeAosFlag (int? noteId, bool? aosFlag)

This call changes the value for the aos flag of a note

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class NotesChangeAosFlagExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NotesApi();
            var noteId = 56;  // int? | Note identifier
            var aosFlag = true;  // bool? | Flag value

            try
            {
                // This call changes the value for the aos flag of a note
                apiInstance.NotesChangeAosFlag(noteId, aosFlag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotesApi.NotesChangeAosFlag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **noteId** | **int?**| Note identifier | 
 **aosFlag** | **bool?**| Flag value | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notesdeletebyid"></a>
# **NotesDeleteById**
> void NotesDeleteById (int? noteId)

This call deletes a note

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class NotesDeleteByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NotesApi();
            var noteId = 56;  // int? | Note identifier

            try
            {
                // This call deletes a note
                apiInstance.NotesDeleteById(noteId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotesApi.NotesDeleteById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **noteId** | **int?**| Note identifier | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notesgetbydocnumber"></a>
# **NotesGetByDocnumber**
> List<NoteDTO> NotesGetByDocnumber (int? docnumber)

This call returns all the notes for a profile

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class NotesGetByDocnumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NotesApi();
            var docnumber = 56;  // int? | Docnumber of the profile

            try
            {
                // This call returns all the notes for a profile
                List&lt;NoteDTO&gt; result = apiInstance.NotesGetByDocnumber(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotesApi.NotesGetByDocnumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| Docnumber of the profile | 

### Return type

[**List<NoteDTO>**](NoteDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notesgetbyid"></a>
# **NotesGetById**
> NoteDTO NotesGetById (int? id)

This call returns a note

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class NotesGetByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NotesApi();
            var id = 56;  // int? | Note identifier

            try
            {
                // This call returns a note
                NoteDTO result = apiInstance.NotesGetById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotesApi.NotesGetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Note identifier | 

### Return type

[**NoteDTO**](NoteDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notesgetpermissions"></a>
# **NotesGetPermissions**
> PermissionsDTO NotesGetPermissions (int? noteId)

This call returns the permissions for a note

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class NotesGetPermissionsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NotesApi();
            var noteId = 56;  // int? | Id of the note

            try
            {
                // This call returns the permissions for a note
                PermissionsDTO result = apiInstance.NotesGetPermissions(noteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotesApi.NotesGetPermissions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **noteId** | **int?**| Id of the note | 

### Return type

[**PermissionsDTO**](PermissionsDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notesnewnote"></a>
# **NotesNewNote**
> NoteDTO NotesNewNote (NoteDTO note)

This call adds new note

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class NotesNewNoteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NotesApi();
            var note = new NoteDTO(); // NoteDTO | Note to add

            try
            {
                // This call adds new note
                NoteDTO result = apiInstance.NotesNewNote(note);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotesApi.NotesNewNote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **note** | [**NoteDTO**](NoteDTO.md)| Note to add | 

### Return type

[**NoteDTO**](NoteDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notesupdatenote"></a>
# **NotesUpdateNote**
> NoteDTO NotesUpdateNote (int? id, NoteDTO note)

This call updates a note

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class NotesUpdateNoteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NotesApi();
            var id = 56;  // int? | Note identifier
            var note = new NoteDTO(); // NoteDTO | Note to update

            try
            {
                // This call updates a note
                NoteDTO result = apiInstance.NotesUpdateNote(id, note);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotesApi.NotesUpdateNote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Note identifier | 
 **note** | [**NoteDTO**](NoteDTO.md)| Note to update | 

### Return type

[**NoteDTO**](NoteDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="noteswritepermissions"></a>
# **NotesWritePermissions**
> void NotesWritePermissions (int? noteId, PermissionsDTO permissions)

This call updates the permissions for a note

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class NotesWritePermissionsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NotesApi();
            var noteId = 56;  // int? | Id of the note
            var permissions = new PermissionsDTO(); // PermissionsDTO | Permissions to update

            try
            {
                // This call updates the permissions for a note
                apiInstance.NotesWritePermissions(noteId, permissions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotesApi.NotesWritePermissions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **noteId** | **int?**| Id of the note | 
 **permissions** | [**PermissionsDTO**](PermissionsDTO.md)| Permissions to update | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


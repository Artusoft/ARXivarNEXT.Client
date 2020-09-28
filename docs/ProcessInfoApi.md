# ARXivarNEXT.Client.Api.ProcessInfoApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProcessInfoGetAttachmentInfoByProcess**](ProcessInfoApi.md#processinfogetattachmentinfobyprocess) | **GET** /api/ProcessInfo/{processId}/Attachment | This call returns the attachments of process
[**ProcessInfoGetChronoInfoByProcess**](ProcessInfoApi.md#processinfogetchronoinfobyprocess) | **GET** /api/ProcessInfo/{processId}/Chrono | This call returns the chrono information of process
[**ProcessInfoGetDocumentInfoByProcess**](ProcessInfoApi.md#processinfogetdocumentinfobyprocess) | **GET** /api/ProcessInfo/{processId}/Document | This call returns the document information associated with the process
[**ProcessInfoGetNoteInfoByProcess**](ProcessInfoApi.md#processinfogetnoteinfobyprocess) | **GET** /api/ProcessInfo/{processId}/Note | This call returns the note associated with process
[**ProcessInfoGetProcessInfo**](ProcessInfoApi.md#processinfogetprocessinfo) | **GET** /api/ProcessInfo/{processId} | This call returns the process information
[**ProcessInfoGetProfessionalRoleInfoByProcess**](ProcessInfoApi.md#processinfogetprofessionalroleinfobyprocess) | **GET** /api/ProcessInfo/{processId}/ProfessionalRole | This call returns the professional roles
[**ProcessInfoGetTaskInfoByProcess**](ProcessInfoApi.md#processinfogettaskinfobyprocess) | **GET** /api/ProcessInfo/{processId}/Task | This call returns all task associated with the process
[**ProcessInfoGetVariableInfoByProcess**](ProcessInfoApi.md#processinfogetvariableinfobyprocess) | **GET** /api/ProcessInfo/{processId}/Variable | This call returns the process variable information of a process
[**ProcessInfoIsSupervisor**](ProcessInfoApi.md#processinfoissupervisor) | **GET** /api/ProcessInfo/{processId}/IsSupervisor | This call checks if the user connected is supervisor of process


<a name="processinfogetattachmentinfobyprocess"></a>
# **ProcessInfoGetAttachmentInfoByProcess**
> List<AttachmentWorkInfoDTO> ProcessInfoGetAttachmentInfoByProcess (int? processId)

This call returns the attachments of process

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProcessInfoGetAttachmentInfoByProcessExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProcessInfoApi();
            var processId = 56;  // int? | Process identifier

            try
            {
                // This call returns the attachments of process
                List&lt;AttachmentWorkInfoDTO&gt; result = apiInstance.ProcessInfoGetAttachmentInfoByProcess(processId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessInfoApi.ProcessInfoGetAttachmentInfoByProcess: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **int?**| Process identifier | 

### Return type

[**List<AttachmentWorkInfoDTO>**](AttachmentWorkInfoDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processinfogetchronoinfobyprocess"></a>
# **ProcessInfoGetChronoInfoByProcess**
> List<ChronoInfoDTO> ProcessInfoGetChronoInfoByProcess (int? processId)

This call returns the chrono information of process

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProcessInfoGetChronoInfoByProcessExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProcessInfoApi();
            var processId = 56;  // int? | Process identifier

            try
            {
                // This call returns the chrono information of process
                List&lt;ChronoInfoDTO&gt; result = apiInstance.ProcessInfoGetChronoInfoByProcess(processId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessInfoApi.ProcessInfoGetChronoInfoByProcess: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **int?**| Process identifier | 

### Return type

[**List<ChronoInfoDTO>**](ChronoInfoDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processinfogetdocumentinfobyprocess"></a>
# **ProcessInfoGetDocumentInfoByProcess**
> List<DocumentWorkInfoDTO> ProcessInfoGetDocumentInfoByProcess (int? processId)

This call returns the document information associated with the process

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProcessInfoGetDocumentInfoByProcessExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProcessInfoApi();
            var processId = 56;  // int? | Process identifier

            try
            {
                // This call returns the document information associated with the process
                List&lt;DocumentWorkInfoDTO&gt; result = apiInstance.ProcessInfoGetDocumentInfoByProcess(processId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessInfoApi.ProcessInfoGetDocumentInfoByProcess: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **int?**| Process identifier | 

### Return type

[**List<DocumentWorkInfoDTO>**](DocumentWorkInfoDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processinfogetnoteinfobyprocess"></a>
# **ProcessInfoGetNoteInfoByProcess**
> List<NoteWorkInfoDTO> ProcessInfoGetNoteInfoByProcess (int? processId)

This call returns the note associated with process

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProcessInfoGetNoteInfoByProcessExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProcessInfoApi();
            var processId = 56;  // int? | Process identifier

            try
            {
                // This call returns the note associated with process
                List&lt;NoteWorkInfoDTO&gt; result = apiInstance.ProcessInfoGetNoteInfoByProcess(processId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessInfoApi.ProcessInfoGetNoteInfoByProcess: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **int?**| Process identifier | 

### Return type

[**List<NoteWorkInfoDTO>**](NoteWorkInfoDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processinfogetprocessinfo"></a>
# **ProcessInfoGetProcessInfo**
> ProcessInfoDTO ProcessInfoGetProcessInfo (int? processId)

This call returns the process information

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProcessInfoGetProcessInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProcessInfoApi();
            var processId = 56;  // int? | Process identifier

            try
            {
                // This call returns the process information
                ProcessInfoDTO result = apiInstance.ProcessInfoGetProcessInfo(processId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessInfoApi.ProcessInfoGetProcessInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **int?**| Process identifier | 

### Return type

[**ProcessInfoDTO**](ProcessInfoDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processinfogetprofessionalroleinfobyprocess"></a>
# **ProcessInfoGetProfessionalRoleInfoByProcess**
> List<ProfessionalRoleInfoDTO> ProcessInfoGetProfessionalRoleInfoByProcess (int? processId)

This call returns the professional roles

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProcessInfoGetProfessionalRoleInfoByProcessExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProcessInfoApi();
            var processId = 56;  // int? | Process identifier

            try
            {
                // This call returns the professional roles
                List&lt;ProfessionalRoleInfoDTO&gt; result = apiInstance.ProcessInfoGetProfessionalRoleInfoByProcess(processId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessInfoApi.ProcessInfoGetProfessionalRoleInfoByProcess: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **int?**| Process identifier | 

### Return type

[**List<ProfessionalRoleInfoDTO>**](ProfessionalRoleInfoDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processinfogettaskinfobyprocess"></a>
# **ProcessInfoGetTaskInfoByProcess**
> List<TaskInfoDTO> ProcessInfoGetTaskInfoByProcess (int? processId)

This call returns all task associated with the process

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProcessInfoGetTaskInfoByProcessExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProcessInfoApi();
            var processId = 56;  // int? | Process identifier

            try
            {
                // This call returns all task associated with the process
                List&lt;TaskInfoDTO&gt; result = apiInstance.ProcessInfoGetTaskInfoByProcess(processId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessInfoApi.ProcessInfoGetTaskInfoByProcess: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **int?**| Process identifier | 

### Return type

[**List<TaskInfoDTO>**](TaskInfoDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processinfogetvariableinfobyprocess"></a>
# **ProcessInfoGetVariableInfoByProcess**
> ProcessInfoVariableDTO ProcessInfoGetVariableInfoByProcess (int? processId)

This call returns the process variable information of a process

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProcessInfoGetVariableInfoByProcessExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProcessInfoApi();
            var processId = 56;  // int? | Process identifier

            try
            {
                // This call returns the process variable information of a process
                ProcessInfoVariableDTO result = apiInstance.ProcessInfoGetVariableInfoByProcess(processId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessInfoApi.ProcessInfoGetVariableInfoByProcess: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **int?**| Process identifier | 

### Return type

[**ProcessInfoVariableDTO**](ProcessInfoVariableDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="processinfoissupervisor"></a>
# **ProcessInfoIsSupervisor**
> bool? ProcessInfoIsSupervisor (int? processId)

This call checks if the user connected is supervisor of process

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ProcessInfoIsSupervisorExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ProcessInfoApi();
            var processId = 56;  // int? | Process identifier

            try
            {
                // This call checks if the user connected is supervisor of process
                bool? result = apiInstance.ProcessInfoIsSupervisor(processId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessInfoApi.ProcessInfoIsSupervisor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **int?**| Process identifier | 

### Return type

**bool?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# ARXivarNEXT.Client.Api.WorkflowApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WorkflowCanStartByDocnumber**](WorkflowApi.md#workflowcanstartbydocnumber) | **GET** /api/Workflow/CanStartByDocnumber/{docnumber} | Check if a new workflow can start
[**WorkflowDeleteWorkflow**](WorkflowApi.md#workflowdeleteworkflow) | **DELETE** /api/Workflow/delete/{processId}/{keepHistory} | This call deletes instance of workflow
[**WorkflowFreeUserConstraint**](WorkflowApi.md#workflowfreeuserconstraint) | **PUT** /api/Workflow/FreeUserConstraint/{processId} | This call removes the user checkout
[**WorkflowGetAllEventsForManualStarts**](WorkflowApi.md#workflowgetalleventsformanualstarts) | **POST** /api/Workflow/userevents | This call returns all available events for manual start a workflow by the user
[**WorkflowGetEventsForManualStarts**](WorkflowApi.md#workflowgeteventsformanualstarts) | **POST** /api/Workflow/events | This call returns all available events for manual start a workflow on a list of profiles
[**WorkflowGetTasksExternalIds**](WorkflowApi.md#workflowgettasksexternalids) | **GET** /api/Workflow/externalids | This call retruns all external identifier of tasks
[**WorkflowGetWorkflowInfoByDocnumber**](WorkflowApi.md#workflowgetworkflowinfobydocnumber) | **GET** /api/Workflow/bydocnumber/{docnumber}/history | This call returns all workflow associated with a document
[**WorkflowGetWorkflowInfoByProcessId**](WorkflowApi.md#workflowgetworkflowinfobyprocessid) | **GET** /api/Workflow/{processId}/history | This call returns the workflow information of process
[**WorkflowGetWorkflows**](WorkflowApi.md#workflowgetworkflows) | **GET** /api/Workflow | This call returns all workflow configured
[**WorkflowRemoveProfileFromTask**](WorkflowApi.md#workflowremoveprofilefromtask) | **DELETE** /api/Workflow/processdoc/{processDocId} | This call removes a document from a workflow process
[**WorkflowStopWorkflow**](WorkflowApi.md#workflowstopworkflow) | **PUT** /api/Workflow/stop/{processId} | This call stops instance of workflow
[**WorkflowWorkflowManualStart**](WorkflowApi.md#workflowworkflowmanualstart) | **PUT** /api/Workflow/start/{docnumber}/{workFlowEventId} | This call starts a new instance of workflow on a document
[**WorkflowWorkflowManualStartWithoutDocnumber**](WorkflowApi.md#workflowworkflowmanualstartwithoutdocnumber) | **PUT** /api/Workflow/start/byevent/{workFlowEventId} | This call starts a new instance of workflow without document


<a name="workflowcanstartbydocnumber"></a>
# **WorkflowCanStartByDocnumber**
> bool? WorkflowCanStartByDocnumber (int? docnumber)

Check if a new workflow can start

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class WorkflowCanStartByDocnumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkflowApi();
            var docnumber = 56;  // int? | 

            try
            {
                // Check if a new workflow can start
                bool? result = apiInstance.WorkflowCanStartByDocnumber(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkflowApi.WorkflowCanStartByDocnumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**|  | 

### Return type

**bool?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workflowdeleteworkflow"></a>
# **WorkflowDeleteWorkflow**
> void WorkflowDeleteWorkflow (int? processId, bool? keepHistory)

This call deletes instance of workflow

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class WorkflowDeleteWorkflowExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkflowApi();
            var processId = 56;  // int? | Process identifier
            var keepHistory = true;  // bool? | false if the hostiry must be deleted

            try
            {
                // This call deletes instance of workflow
                apiInstance.WorkflowDeleteWorkflow(processId, keepHistory);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkflowApi.WorkflowDeleteWorkflow: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **int?**| Process identifier | 
 **keepHistory** | **bool?**| false if the hostiry must be deleted | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workflowfreeuserconstraint"></a>
# **WorkflowFreeUserConstraint**
> void WorkflowFreeUserConstraint (int? processId)

This call removes the user checkout

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class WorkflowFreeUserConstraintExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkflowApi();
            var processId = 56;  // int? | Process Id

            try
            {
                // This call removes the user checkout
                apiInstance.WorkflowFreeUserConstraint(processId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkflowApi.WorkflowFreeUserConstraint: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **int?**| Process Id | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workflowgetalleventsformanualstarts"></a>
# **WorkflowGetAllEventsForManualStarts**
> List<WorkFlowEventDTO> WorkflowGetAllEventsForManualStarts ()

This call returns all available events for manual start a workflow by the user

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class WorkflowGetAllEventsForManualStartsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkflowApi();

            try
            {
                // This call returns all available events for manual start a workflow by the user
                List&lt;WorkFlowEventDTO&gt; result = apiInstance.WorkflowGetAllEventsForManualStarts();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkflowApi.WorkflowGetAllEventsForManualStarts: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<WorkFlowEventDTO>**](WorkFlowEventDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workflowgeteventsformanualstarts"></a>
# **WorkflowGetEventsForManualStarts**
> List<WorkFlowEventDTO> WorkflowGetEventsForManualStarts (List<int?> docnumbers)

This call returns all available events for manual start a workflow on a list of profiles

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class WorkflowGetEventsForManualStartsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkflowApi();
            var docnumbers = ;  // List<int?> | List of document identifier

            try
            {
                // This call returns all available events for manual start a workflow on a list of profiles
                List&lt;WorkFlowEventDTO&gt; result = apiInstance.WorkflowGetEventsForManualStarts(docnumbers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkflowApi.WorkflowGetEventsForManualStarts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumbers** | **List&lt;int?&gt;**| List of document identifier | 

### Return type

[**List<WorkFlowEventDTO>**](WorkFlowEventDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workflowgettasksexternalids"></a>
# **WorkflowGetTasksExternalIds**
> List<string> WorkflowGetTasksExternalIds ()

This call retruns all external identifier of tasks

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class WorkflowGetTasksExternalIdsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkflowApi();

            try
            {
                // This call retruns all external identifier of tasks
                List&lt;string&gt; result = apiInstance.WorkflowGetTasksExternalIds();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkflowApi.WorkflowGetTasksExternalIds: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workflowgetworkflowinfobydocnumber"></a>
# **WorkflowGetWorkflowInfoByDocnumber**
> List<WorkflowInfoDTO> WorkflowGetWorkflowInfoByDocnumber (int? docnumber)

This call returns all workflow associated with a document

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class WorkflowGetWorkflowInfoByDocnumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkflowApi();
            var docnumber = 56;  // int? | Document Idenfier

            try
            {
                // This call returns all workflow associated with a document
                List&lt;WorkflowInfoDTO&gt; result = apiInstance.WorkflowGetWorkflowInfoByDocnumber(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkflowApi.WorkflowGetWorkflowInfoByDocnumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| Document Idenfier | 

### Return type

[**List<WorkflowInfoDTO>**](WorkflowInfoDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workflowgetworkflowinfobyprocessid"></a>
# **WorkflowGetWorkflowInfoByProcessId**
> WorkflowInfoDTO WorkflowGetWorkflowInfoByProcessId (int? processId)

This call returns the workflow information of process

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class WorkflowGetWorkflowInfoByProcessIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkflowApi();
            var processId = 56;  // int? | Process identifier

            try
            {
                // This call returns the workflow information of process
                WorkflowInfoDTO result = apiInstance.WorkflowGetWorkflowInfoByProcessId(processId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkflowApi.WorkflowGetWorkflowInfoByProcessId: " + e.Message );
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

[**WorkflowInfoDTO**](WorkflowInfoDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workflowgetworkflows"></a>
# **WorkflowGetWorkflows**
> List<WorkflowDTO> WorkflowGetWorkflows ()

This call returns all workflow configured

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class WorkflowGetWorkflowsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkflowApi();

            try
            {
                // This call returns all workflow configured
                List&lt;WorkflowDTO&gt; result = apiInstance.WorkflowGetWorkflows();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkflowApi.WorkflowGetWorkflows: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<WorkflowDTO>**](WorkflowDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workflowremoveprofilefromtask"></a>
# **WorkflowRemoveProfileFromTask**
> void WorkflowRemoveProfileFromTask (int? processDocId)

This call removes a document from a workflow process

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class WorkflowRemoveProfileFromTaskExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkflowApi();
            var processDocId = 56;  // int? | Identifier of process document

            try
            {
                // This call removes a document from a workflow process
                apiInstance.WorkflowRemoveProfileFromTask(processDocId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkflowApi.WorkflowRemoveProfileFromTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDocId** | **int?**| Identifier of process document | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workflowstopworkflow"></a>
# **WorkflowStopWorkflow**
> void WorkflowStopWorkflow (int? processId)

This call stops instance of workflow

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class WorkflowStopWorkflowExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkflowApi();
            var processId = 56;  // int? | Process identifier

            try
            {
                // This call stops instance of workflow
                apiInstance.WorkflowStopWorkflow(processId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkflowApi.WorkflowStopWorkflow: " + e.Message );
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

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workflowworkflowmanualstart"></a>
# **WorkflowWorkflowManualStart**
> void WorkflowWorkflowManualStart (int? docnumber, int? workFlowEventId)

This call starts a new instance of workflow on a document

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class WorkflowWorkflowManualStartExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkflowApi();
            var docnumber = 56;  // int? | Document identifier to apply workflow
            var workFlowEventId = 56;  // int? | Workflow event identifier

            try
            {
                // This call starts a new instance of workflow on a document
                apiInstance.WorkflowWorkflowManualStart(docnumber, workFlowEventId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkflowApi.WorkflowWorkflowManualStart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| Document identifier to apply workflow | 
 **workFlowEventId** | **int?**| Workflow event identifier | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="workflowworkflowmanualstartwithoutdocnumber"></a>
# **WorkflowWorkflowManualStartWithoutDocnumber**
> void WorkflowWorkflowManualStartWithoutDocnumber (int? workFlowEventId)

This call starts a new instance of workflow without document

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class WorkflowWorkflowManualStartWithoutDocnumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkflowApi();
            var workFlowEventId = 56;  // int? | Workflow event identifier

            try
            {
                // This call starts a new instance of workflow without document
                apiInstance.WorkflowWorkflowManualStartWithoutDocnumber(workFlowEventId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkflowApi.WorkflowWorkflowManualStartWithoutDocnumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workFlowEventId** | **int?**| Workflow event identifier | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


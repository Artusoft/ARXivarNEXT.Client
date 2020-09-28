# ARXivarNEXT.Client.Api.TaskLayoutApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TaskLayoutDeleteTaskLayout**](TaskLayoutApi.md#tasklayoutdeletetasklayout) | **DELETE** /api/TaskLayout/{tasklayoutid} | This call deletes a task layout by the id
[**TaskLayoutGetTaskLayoutById**](TaskLayoutApi.md#tasklayoutgettasklayoutbyid) | **GET** /api/TaskLayout/{tasklayoutid} | This call returns the task layout by the task layout id
[**TaskLayoutGetTaskLayoutByTaskWorkId**](TaskLayoutApi.md#tasklayoutgettasklayoutbytaskworkid) | **GET** /api/TaskLayout/taskwork/{taskWorkId} | This call returns the task layout by the taskwork
[**TaskLayoutGetTaskLayoutForUser**](TaskLayoutApi.md#tasklayoutgettasklayoutforuser) | **GET** /api/TaskLayout/foruser | This call returns the task layout for user default if exist
[**TaskLayoutGetTaskLayouts**](TaskLayoutApi.md#tasklayoutgettasklayouts) | **GET** /api/TaskLayout | This call returns all task layouts configured
[**TaskLayoutNewTaskLayout**](TaskLayoutApi.md#tasklayoutnewtasklayout) | **POST** /api/TaskLayout | This call inserts a new task layout
[**TaskLayoutUpdateTaskLayout**](TaskLayoutApi.md#tasklayoutupdatetasklayout) | **PUT** /api/TaskLayout | This call updates a task layout
[**TaskLayoutUpdateTaskLayoutPriority**](TaskLayoutApi.md#tasklayoutupdatetasklayoutpriority) | **PUT** /api/TaskLayout/changepriority/{tasklayoutid}/{priority} | This call updates the priority of a task layout
[**TaskLayoutWriteTaskLayoutForUser**](TaskLayoutApi.md#tasklayoutwritetasklayoutforuser) | **POST** /api/TaskLayout/foruser | This call inserts or updates personal task layout for user


<a name="tasklayoutdeletetasklayout"></a>
# **TaskLayoutDeleteTaskLayout**
> void TaskLayoutDeleteTaskLayout (int? tasklayoutid)

This call deletes a task layout by the id

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskLayoutDeleteTaskLayoutExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskLayoutApi();
            var tasklayoutid = 56;  // int? | Task layout identifier

            try
            {
                // This call deletes a task layout by the id
                apiInstance.TaskLayoutDeleteTaskLayout(tasklayoutid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskLayoutApi.TaskLayoutDeleteTaskLayout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tasklayoutid** | **int?**| Task layout identifier | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tasklayoutgettasklayoutbyid"></a>
# **TaskLayoutGetTaskLayoutById**
> TaskLayoutDTO TaskLayoutGetTaskLayoutById (int? tasklayoutid)

This call returns the task layout by the task layout id

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskLayoutGetTaskLayoutByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskLayoutApi();
            var tasklayoutid = 56;  // int? | Task Layout Identifier

            try
            {
                // This call returns the task layout by the task layout id
                TaskLayoutDTO result = apiInstance.TaskLayoutGetTaskLayoutById(tasklayoutid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskLayoutApi.TaskLayoutGetTaskLayoutById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tasklayoutid** | **int?**| Task Layout Identifier | 

### Return type

[**TaskLayoutDTO**](TaskLayoutDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tasklayoutgettasklayoutbytaskworkid"></a>
# **TaskLayoutGetTaskLayoutByTaskWorkId**
> TaskLayoutDTO TaskLayoutGetTaskLayoutByTaskWorkId (int? taskWorkId)

This call returns the task layout by the taskwork

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskLayoutGetTaskLayoutByTaskWorkIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskLayoutApi();
            var taskWorkId = 56;  // int? | Taskwork Identifier

            try
            {
                // This call returns the task layout by the taskwork
                TaskLayoutDTO result = apiInstance.TaskLayoutGetTaskLayoutByTaskWorkId(taskWorkId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskLayoutApi.TaskLayoutGetTaskLayoutByTaskWorkId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskWorkId** | **int?**| Taskwork Identifier | 

### Return type

[**TaskLayoutDTO**](TaskLayoutDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tasklayoutgettasklayoutforuser"></a>
# **TaskLayoutGetTaskLayoutForUser**
> TaskLayoutDTO TaskLayoutGetTaskLayoutForUser ()

This call returns the task layout for user default if exist

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskLayoutGetTaskLayoutForUserExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskLayoutApi();

            try
            {
                // This call returns the task layout for user default if exist
                TaskLayoutDTO result = apiInstance.TaskLayoutGetTaskLayoutForUser();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskLayoutApi.TaskLayoutGetTaskLayoutForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TaskLayoutDTO**](TaskLayoutDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tasklayoutgettasklayouts"></a>
# **TaskLayoutGetTaskLayouts**
> List<TaskLayoutDTO> TaskLayoutGetTaskLayouts ()

This call returns all task layouts configured

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskLayoutGetTaskLayoutsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskLayoutApi();

            try
            {
                // This call returns all task layouts configured
                List&lt;TaskLayoutDTO&gt; result = apiInstance.TaskLayoutGetTaskLayouts();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskLayoutApi.TaskLayoutGetTaskLayouts: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TaskLayoutDTO>**](TaskLayoutDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tasklayoutnewtasklayout"></a>
# **TaskLayoutNewTaskLayout**
> TaskLayoutDTO TaskLayoutNewTaskLayout (TaskLayoutDTO taskLayout)

This call inserts a new task layout

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskLayoutNewTaskLayoutExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskLayoutApi();
            var taskLayout = new TaskLayoutDTO(); // TaskLayoutDTO | Task layout information to insert

            try
            {
                // This call inserts a new task layout
                TaskLayoutDTO result = apiInstance.TaskLayoutNewTaskLayout(taskLayout);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskLayoutApi.TaskLayoutNewTaskLayout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskLayout** | [**TaskLayoutDTO**](TaskLayoutDTO.md)| Task layout information to insert | 

### Return type

[**TaskLayoutDTO**](TaskLayoutDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tasklayoutupdatetasklayout"></a>
# **TaskLayoutUpdateTaskLayout**
> TaskLayoutDTO TaskLayoutUpdateTaskLayout (TaskLayoutDTO taskLayout)

This call updates a task layout

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskLayoutUpdateTaskLayoutExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskLayoutApi();
            var taskLayout = new TaskLayoutDTO(); // TaskLayoutDTO | Task layout information to edit

            try
            {
                // This call updates a task layout
                TaskLayoutDTO result = apiInstance.TaskLayoutUpdateTaskLayout(taskLayout);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskLayoutApi.TaskLayoutUpdateTaskLayout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskLayout** | [**TaskLayoutDTO**](TaskLayoutDTO.md)| Task layout information to edit | 

### Return type

[**TaskLayoutDTO**](TaskLayoutDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tasklayoutupdatetasklayoutpriority"></a>
# **TaskLayoutUpdateTaskLayoutPriority**
> void TaskLayoutUpdateTaskLayoutPriority (int? tasklayoutid, int? priority)

This call updates the priority of a task layout

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskLayoutUpdateTaskLayoutPriorityExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskLayoutApi();
            var tasklayoutid = 56;  // int? | Task layout identifier
            var priority = 56;  // int? | Priority to set

            try
            {
                // This call updates the priority of a task layout
                apiInstance.TaskLayoutUpdateTaskLayoutPriority(tasklayoutid, priority);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskLayoutApi.TaskLayoutUpdateTaskLayoutPriority: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tasklayoutid** | **int?**| Task layout identifier | 
 **priority** | **int?**| Priority to set | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tasklayoutwritetasklayoutforuser"></a>
# **TaskLayoutWriteTaskLayoutForUser**
> TaskLayoutDTO TaskLayoutWriteTaskLayoutForUser (TaskLayoutDTO taskLayout)

This call inserts or updates personal task layout for user

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class TaskLayoutWriteTaskLayoutForUserExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskLayoutApi();
            var taskLayout = new TaskLayoutDTO(); // TaskLayoutDTO | Task layout information to write

            try
            {
                // This call inserts or updates personal task layout for user
                TaskLayoutDTO result = apiInstance.TaskLayoutWriteTaskLayoutForUser(taskLayout);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskLayoutApi.TaskLayoutWriteTaskLayoutForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskLayout** | [**TaskLayoutDTO**](TaskLayoutDTO.md)| Task layout information to write | 

### Return type

[**TaskLayoutDTO**](TaskLayoutDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


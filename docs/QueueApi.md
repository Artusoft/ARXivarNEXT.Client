# ARXivarNEXT.Client.Api.QueueApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**QueueAdminDeleteQueue**](QueueApi.md#queueadmindeletequeue) | **DELETE** /api/Queue/AdminQueue/{queueId} | This call checks if to delete a queue (administrator required)
[**QueueAdminGetQueueAggregationList**](QueueApi.md#queueadmingetqueueaggregationlist) | **POST** /api/Queue/AdminGetQueueAggregatedList | This call returns the queue aggregated information list  (administrator required)
[**QueueAdminGetQueueAggregationList_0**](QueueApi.md#queueadmingetqueueaggregationlist_0) | **GET** /api/Queue/AdminQueueAggregated/{queueId} | This call returns the specific queue aggregated information (administrator required)
[**QueueAdminGetQueueEndJobInfo**](QueueApi.md#queueadmingetqueueendjobinfo) | **GET** /api/Queue/AdminEndJobInfo/{queueId} | This call returns the end job information (administrator required)
[**QueueAdminGetQueueJobInfo**](QueueApi.md#queueadmingetqueuejobinfo) | **POST** /api/Queue/AdminGetQueueJobInfoList | This call returns the job information list (administrator required)
[**QueueAdminGetQueueList**](QueueApi.md#queueadmingetqueuelist) | **POST** /api/Queue/AdminGetQueueList | This call returns all queue (administrator required)
[**QueueAdminGetQueueWorkJobInfo**](QueueApi.md#queueadmingetqueueworkjobinfo) | **GET** /api/Queue/AdminWorkJobInfo/{queueId} | This call returns a work job information (administrator required)
[**QueueDeleteJob**](QueueApi.md#queuedeletejob) | **DELETE** /api/Queue/Job/{jobId} | This call checks if to delete a queue job
[**QueueDeleteQueue**](QueueApi.md#queuedeletequeue) | **DELETE** /api/Queue/Queue/{queueId} | This call checks if to delete a queue
[**QueueEnqueuedJob**](QueueApi.md#queueenqueuedjob) | **POST** /api/Queue/Enqueue/{jobId} | This call checks if to equeue a job is in state Scheduled or Failed
[**QueueGetJobInfo**](QueueApi.md#queuegetjobinfo) | **GET** /api/Queue/JobInfo/{jobId} | This call returns a job info
[**QueueGetQueueAggregationList**](QueueApi.md#queuegetqueueaggregationlist) | **POST** /api/Queue/GetQueueAggregatedList | This call returns the queue aggregated information list
[**QueueGetQueueAggregationList_0**](QueueApi.md#queuegetqueueaggregationlist_0) | **GET** /api/Queue/QueueAggregated/{queueId} | This call returns the specific queue aggregated information
[**QueueGetQueueAggregationStatusInfo**](QueueApi.md#queuegetqueueaggregationstatusinfo) | **GET** /api/Queue/QueueAggregationStatusInfo/{queueId} | This call returns the specific queue aggregated status
[**QueueGetQueueEndJobInfo**](QueueApi.md#queuegetqueueendjobinfo) | **GET** /api/Queue/EndJobInfo/{queueId} | This call returns the end job information
[**QueueGetQueueJobInfo**](QueueApi.md#queuegetqueuejobinfo) | **POST** /api/Queue/GetQueueJobInfoList | This call returns the job info information list
[**QueueGetQueueJobSucceededResultList**](QueueApi.md#queuegetqueuejobsucceededresultlist) | **POST** /api/Queue/GetQueueJobSucceededResultList | Gets the job result of specific queue
[**QueueGetQueueList**](QueueApi.md#queuegetqueuelist) | **POST** /api/Queue/GetQueueList | This call returns all jobs of queue
[**QueueGetQueueWorkItemCount**](QueueApi.md#queuegetqueueworkitemcount) | **GET** /api/Queue/WorkItemCount/{queueId} | This call returns the counts of work item for a queue
[**QueueGetQueueWorkItemLeftCount**](QueueApi.md#queuegetqueueworkitemleftcount) | **GET** /api/Queue/WorkItemLeftCount/{queueId} | This call returns the counts how many work item jobs left
[**QueueGetQueueWorkJobInfo**](QueueApi.md#queuegetqueueworkjobinfo) | **GET** /api/Queue/WorkJobInfo/{queueId} | This call returns a work job information


<a name="queueadmindeletequeue"></a>
# **QueueAdminDeleteQueue**
> bool? QueueAdminDeleteQueue (string queueId)

This call checks if to delete a queue (administrator required)

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class QueueAdminDeleteQueueExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QueueApi();
            var queueId = queueId_example;  // string | Queue Identifier

            try
            {
                // This call checks if to delete a queue (administrator required)
                bool? result = apiInstance.QueueAdminDeleteQueue(queueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueApi.QueueAdminDeleteQueue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueId** | **string**| Queue Identifier | 

### Return type

**bool?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queueadmingetqueueaggregationlist"></a>
# **QueueAdminGetQueueAggregationList**
> List<QueueAggregationInfoDto> QueueAdminGetQueueAggregationList (GetQueueInfoDto getQueueInfo)

This call returns the queue aggregated information list  (administrator required)

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class QueueAdminGetQueueAggregationListExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QueueApi();
            var getQueueInfo = new GetQueueInfoDto(); // GetQueueInfoDto | Queue information

            try
            {
                // This call returns the queue aggregated information list  (administrator required)
                List&lt;QueueAggregationInfoDto&gt; result = apiInstance.QueueAdminGetQueueAggregationList(getQueueInfo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueApi.QueueAdminGetQueueAggregationList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **getQueueInfo** | [**GetQueueInfoDto**](GetQueueInfoDto.md)| Queue information | 

### Return type

[**List<QueueAggregationInfoDto>**](QueueAggregationInfoDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queueadmingetqueueaggregationlist_0"></a>
# **QueueAdminGetQueueAggregationList_0**
> QueueAggregationInfoDto QueueAdminGetQueueAggregationList_0 (string queueId)

This call returns the specific queue aggregated information (administrator required)

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class QueueAdminGetQueueAggregationList_0Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QueueApi();
            var queueId = queueId_example;  // string | Queue Identifier

            try
            {
                // This call returns the specific queue aggregated information (administrator required)
                QueueAggregationInfoDto result = apiInstance.QueueAdminGetQueueAggregationList_0(queueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueApi.QueueAdminGetQueueAggregationList_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueId** | **string**| Queue Identifier | 

### Return type

[**QueueAggregationInfoDto**](QueueAggregationInfoDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queueadmingetqueueendjobinfo"></a>
# **QueueAdminGetQueueEndJobInfo**
> QueueJobInfoDto QueueAdminGetQueueEndJobInfo (string queueId)

This call returns the end job information (administrator required)

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class QueueAdminGetQueueEndJobInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QueueApi();
            var queueId = queueId_example;  // string | Queue Identifier

            try
            {
                // This call returns the end job information (administrator required)
                QueueJobInfoDto result = apiInstance.QueueAdminGetQueueEndJobInfo(queueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueApi.QueueAdminGetQueueEndJobInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueId** | **string**| Queue Identifier | 

### Return type

[**QueueJobInfoDto**](QueueJobInfoDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queueadmingetqueuejobinfo"></a>
# **QueueAdminGetQueueJobInfo**
> List<QueueJobInfoDto> QueueAdminGetQueueJobInfo (string queueId, GetQueueJobInfoDto getQueueJobInfo)

This call returns the job information list (administrator required)

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class QueueAdminGetQueueJobInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QueueApi();
            var queueId = queueId_example;  // string | Queue Identifier
            var getQueueJobInfo = new GetQueueJobInfoDto(); // GetQueueJobInfoDto | Job Information

            try
            {
                // This call returns the job information list (administrator required)
                List&lt;QueueJobInfoDto&gt; result = apiInstance.QueueAdminGetQueueJobInfo(queueId, getQueueJobInfo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueApi.QueueAdminGetQueueJobInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueId** | **string**| Queue Identifier | 
 **getQueueJobInfo** | [**GetQueueJobInfoDto**](GetQueueJobInfoDto.md)| Job Information | 

### Return type

[**List<QueueJobInfoDto>**](QueueJobInfoDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queueadmingetqueuelist"></a>
# **QueueAdminGetQueueList**
> List<QueueJobInfoDto> QueueAdminGetQueueList (GetQueueInfoDto getQueueInfo)

This call returns all queue (administrator required)

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class QueueAdminGetQueueListExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QueueApi();
            var getQueueInfo = new GetQueueInfoDto(); // GetQueueInfoDto | Queue information

            try
            {
                // This call returns all queue (administrator required)
                List&lt;QueueJobInfoDto&gt; result = apiInstance.QueueAdminGetQueueList(getQueueInfo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueApi.QueueAdminGetQueueList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **getQueueInfo** | [**GetQueueInfoDto**](GetQueueInfoDto.md)| Queue information | 

### Return type

[**List<QueueJobInfoDto>**](QueueJobInfoDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queueadmingetqueueworkjobinfo"></a>
# **QueueAdminGetQueueWorkJobInfo**
> QueueJobInfoDto QueueAdminGetQueueWorkJobInfo (string queueId)

This call returns a work job information (administrator required)

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class QueueAdminGetQueueWorkJobInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QueueApi();
            var queueId = queueId_example;  // string | Queue Identifier

            try
            {
                // This call returns a work job information (administrator required)
                QueueJobInfoDto result = apiInstance.QueueAdminGetQueueWorkJobInfo(queueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueApi.QueueAdminGetQueueWorkJobInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueId** | **string**| Queue Identifier | 

### Return type

[**QueueJobInfoDto**](QueueJobInfoDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queuedeletejob"></a>
# **QueueDeleteJob**
> bool? QueueDeleteJob (string jobId)

This call checks if to delete a queue job

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class QueueDeleteJobExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QueueApi();
            var jobId = jobId_example;  // string | Job Identifier

            try
            {
                // This call checks if to delete a queue job
                bool? result = apiInstance.QueueDeleteJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueApi.QueueDeleteJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **string**| Job Identifier | 

### Return type

**bool?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queuedeletequeue"></a>
# **QueueDeleteQueue**
> bool? QueueDeleteQueue (string queueId)

This call checks if to delete a queue

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class QueueDeleteQueueExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QueueApi();
            var queueId = queueId_example;  // string | Queue Identifier

            try
            {
                // This call checks if to delete a queue
                bool? result = apiInstance.QueueDeleteQueue(queueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueApi.QueueDeleteQueue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueId** | **string**| Queue Identifier | 

### Return type

**bool?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queueenqueuedjob"></a>
# **QueueEnqueuedJob**
> bool? QueueEnqueuedJob (string jobId)

This call checks if to equeue a job is in state Scheduled or Failed

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class QueueEnqueuedJobExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QueueApi();
            var jobId = jobId_example;  // string | Job Identifier

            try
            {
                // This call checks if to equeue a job is in state Scheduled or Failed
                bool? result = apiInstance.QueueEnqueuedJob(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueApi.QueueEnqueuedJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **string**| Job Identifier | 

### Return type

**bool?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queuegetjobinfo"></a>
# **QueueGetJobInfo**
> QueueJobInfoDto QueueGetJobInfo (string jobId)

This call returns a job info

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class QueueGetJobInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QueueApi();
            var jobId = jobId_example;  // string | Job Identifier

            try
            {
                // This call returns a job info
                QueueJobInfoDto result = apiInstance.QueueGetJobInfo(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueApi.QueueGetJobInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **string**| Job Identifier | 

### Return type

[**QueueJobInfoDto**](QueueJobInfoDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queuegetqueueaggregationlist"></a>
# **QueueGetQueueAggregationList**
> List<QueueAggregationInfoDto> QueueGetQueueAggregationList (GetQueueInfoDto getQueueInfo)

This call returns the queue aggregated information list

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class QueueGetQueueAggregationListExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QueueApi();
            var getQueueInfo = new GetQueueInfoDto(); // GetQueueInfoDto | Queue information

            try
            {
                // This call returns the queue aggregated information list
                List&lt;QueueAggregationInfoDto&gt; result = apiInstance.QueueGetQueueAggregationList(getQueueInfo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueApi.QueueGetQueueAggregationList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **getQueueInfo** | [**GetQueueInfoDto**](GetQueueInfoDto.md)| Queue information | 

### Return type

[**List<QueueAggregationInfoDto>**](QueueAggregationInfoDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queuegetqueueaggregationlist_0"></a>
# **QueueGetQueueAggregationList_0**
> QueueAggregationInfoDto QueueGetQueueAggregationList_0 (string queueId)

This call returns the specific queue aggregated information

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class QueueGetQueueAggregationList_0Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QueueApi();
            var queueId = queueId_example;  // string | Queue Identifier

            try
            {
                // This call returns the specific queue aggregated information
                QueueAggregationInfoDto result = apiInstance.QueueGetQueueAggregationList_0(queueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueApi.QueueGetQueueAggregationList_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueId** | **string**| Queue Identifier | 

### Return type

[**QueueAggregationInfoDto**](QueueAggregationInfoDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queuegetqueueaggregationstatusinfo"></a>
# **QueueGetQueueAggregationStatusInfo**
> QueueAggregationStatusInfoDto QueueGetQueueAggregationStatusInfo (string queueId)

This call returns the specific queue aggregated status

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class QueueGetQueueAggregationStatusInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QueueApi();
            var queueId = queueId_example;  // string | Queue Identifier

            try
            {
                // This call returns the specific queue aggregated status
                QueueAggregationStatusInfoDto result = apiInstance.QueueGetQueueAggregationStatusInfo(queueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueApi.QueueGetQueueAggregationStatusInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueId** | **string**| Queue Identifier | 

### Return type

[**QueueAggregationStatusInfoDto**](QueueAggregationStatusInfoDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queuegetqueueendjobinfo"></a>
# **QueueGetQueueEndJobInfo**
> QueueJobInfoDto QueueGetQueueEndJobInfo (string queueId)

This call returns the end job information

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class QueueGetQueueEndJobInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QueueApi();
            var queueId = queueId_example;  // string | Queue Identifier

            try
            {
                // This call returns the end job information
                QueueJobInfoDto result = apiInstance.QueueGetQueueEndJobInfo(queueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueApi.QueueGetQueueEndJobInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueId** | **string**| Queue Identifier | 

### Return type

[**QueueJobInfoDto**](QueueJobInfoDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queuegetqueuejobinfo"></a>
# **QueueGetQueueJobInfo**
> List<QueueJobInfoDto> QueueGetQueueJobInfo (string queueId, GetQueueJobInfoDto getQueueJobInfo)

This call returns the job info information list

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class QueueGetQueueJobInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QueueApi();
            var queueId = queueId_example;  // string | Queue Identifier
            var getQueueJobInfo = new GetQueueJobInfoDto(); // GetQueueJobInfoDto | Job Information

            try
            {
                // This call returns the job info information list
                List&lt;QueueJobInfoDto&gt; result = apiInstance.QueueGetQueueJobInfo(queueId, getQueueJobInfo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueApi.QueueGetQueueJobInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueId** | **string**| Queue Identifier | 
 **getQueueJobInfo** | [**GetQueueJobInfoDto**](GetQueueJobInfoDto.md)| Job Information | 

### Return type

[**List<QueueJobInfoDto>**](QueueJobInfoDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queuegetqueuejobsucceededresultlist"></a>
# **QueueGetQueueJobSucceededResultList**
> List<JobResultDto> QueueGetQueueJobSucceededResultList (string queueId, GetQueueJobInfoDto getQueueJobInfo)

Gets the job result of specific queue

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class QueueGetQueueJobSucceededResultListExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QueueApi();
            var queueId = queueId_example;  // string | 
            var getQueueJobInfo = new GetQueueJobInfoDto(); // GetQueueJobInfoDto | 

            try
            {
                // Gets the job result of specific queue
                List&lt;JobResultDto&gt; result = apiInstance.QueueGetQueueJobSucceededResultList(queueId, getQueueJobInfo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueApi.QueueGetQueueJobSucceededResultList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueId** | **string**|  | 
 **getQueueJobInfo** | [**GetQueueJobInfoDto**](GetQueueJobInfoDto.md)|  | 

### Return type

[**List<JobResultDto>**](JobResultDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queuegetqueuelist"></a>
# **QueueGetQueueList**
> List<QueueJobInfoDto> QueueGetQueueList (GetQueueInfoDto getQueueInfo)

This call returns all jobs of queue

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class QueueGetQueueListExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QueueApi();
            var getQueueInfo = new GetQueueInfoDto(); // GetQueueInfoDto | Queue information

            try
            {
                // This call returns all jobs of queue
                List&lt;QueueJobInfoDto&gt; result = apiInstance.QueueGetQueueList(getQueueInfo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueApi.QueueGetQueueList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **getQueueInfo** | [**GetQueueInfoDto**](GetQueueInfoDto.md)| Queue information | 

### Return type

[**List<QueueJobInfoDto>**](QueueJobInfoDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queuegetqueueworkitemcount"></a>
# **QueueGetQueueWorkItemCount**
> int? QueueGetQueueWorkItemCount (string queueId)

This call returns the counts of work item for a queue

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class QueueGetQueueWorkItemCountExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QueueApi();
            var queueId = queueId_example;  // string | Queue Identifier

            try
            {
                // This call returns the counts of work item for a queue
                int? result = apiInstance.QueueGetQueueWorkItemCount(queueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueApi.QueueGetQueueWorkItemCount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueId** | **string**| Queue Identifier | 

### Return type

**int?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queuegetqueueworkitemleftcount"></a>
# **QueueGetQueueWorkItemLeftCount**
> long? QueueGetQueueWorkItemLeftCount (string queueId)

This call returns the counts how many work item jobs left

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class QueueGetQueueWorkItemLeftCountExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QueueApi();
            var queueId = queueId_example;  // string | Queue Identifier

            try
            {
                // This call returns the counts how many work item jobs left
                long? result = apiInstance.QueueGetQueueWorkItemLeftCount(queueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueApi.QueueGetQueueWorkItemLeftCount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueId** | **string**| Queue Identifier | 

### Return type

**long?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queuegetqueueworkjobinfo"></a>
# **QueueGetQueueWorkJobInfo**
> QueueJobInfoDto QueueGetQueueWorkJobInfo (string queueId)

This call returns a work job information

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class QueueGetQueueWorkJobInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QueueApi();
            var queueId = queueId_example;  // string | Queue Identifier

            try
            {
                // This call returns a work job information
                QueueJobInfoDto result = apiInstance.QueueGetQueueWorkJobInfo(queueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueueApi.QueueGetQueueWorkJobInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueId** | **string**| Queue Identifier | 

### Return type

[**QueueJobInfoDto**](QueueJobInfoDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


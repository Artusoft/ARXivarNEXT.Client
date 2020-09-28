# ARXivarNEXT.Client.Api.ReportApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReportDelete**](ReportApi.md#reportdelete) | **DELETE** /api/Report/{id} | Deletes a report
[**ReportDeleteReportTemplate**](ReportApi.md#reportdeletereporttemplate) | **DELETE** /api/Report/{id}/DeleteTemplate | Deletes the template file of the report
[**ReportExecuteById**](ReportApi.md#reportexecutebyid) | **POST** /api/Report/Execute | Executes a report by id
[**ReportExecuteMultpileAsyncById**](ReportApi.md#reportexecutemultpileasyncbyid) | **POST** /api/Report/Execute/Async | Executes a report with one or more output formats by id. The operation is async
[**ReportGetById**](ReportApi.md#reportgetbyid) | **GET** /api/Report/{id} | Returns the report specified by id
[**ReportGetFindGroupById**](ReportApi.md#reportgetfindgroupbyid) | **GET** /api/Report/FindGroup/{findGroupId}/{reportId} | Get Find Group by Id considering report permissions
[**ReportGetFindGroupList**](ReportApi.md#reportgetfindgrouplist) | **GET** /api/Report/FindGroupList/{reportId} | List of Find Group considering report permissions
[**ReportGetList**](ReportApi.md#reportgetlist) | **GET** /api/Report | Returns the list of all the report available for the user
[**ReportGetPermission**](ReportApi.md#reportgetpermission) | **GET** /api/Report/{id}/Permissions | Returns permissions of report
[**ReportGetReportDataSource**](ReportApi.md#reportgetreportdatasource) | **GET** /api/Report/DataSource/{findGroupId}/{reportId} | Gets report data source
[**ReportGetReportParamDataSourceByFindGroupId**](ReportApi.md#reportgetreportparamdatasourcebyfindgroupid) | **GET** /api/Report/ParamDataSource/{findGroupId}/{reportId} | Gets report parameters datasource
[**ReportGetReportTemplate**](ReportApi.md#reportgetreporttemplate) | **GET** /api/Report/{id}/Template | Gets the report template file
[**ReportHandlerEditMode**](ReportApi.md#reporthandlereditmode) | **POST** /api/Report/DataSourceHandlerForEdit | Executes a query for internal data source in edit mode
[**ReportHandlerRunningMode**](ReportApi.md#reporthandlerrunningmode) | **POST** /api/Report/DataSourceHandlerForRun | Executes a query for internal data source in running mode
[**ReportInsertReport**](ReportApi.md#reportinsertreport) | **POST** /api/Report/Insert | Inserts a new report
[**ReportSetPermission**](ReportApi.md#reportsetpermission) | **POST** /api/Report/{id}/Permissions | Sets report permissions
[**ReportUpdateReport**](ReportApi.md#reportupdatereport) | **POST** /api/Report/Update | Updates the report
[**ReportUpdateReportTemplate**](ReportApi.md#reportupdatereporttemplate) | **POST** /api/Report/{id}/UpdateTemplate | Updates the template file of the report


<a name="reportdelete"></a>
# **ReportDelete**
> Object ReportDelete (string id)

Deletes a report

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ReportDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReportApi();
            var id = id_example;  // string | Identifier of the report

            try
            {
                // Deletes a report
                Object result = apiInstance.ReportDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Identifier of the report | 

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportdeletereporttemplate"></a>
# **ReportDeleteReportTemplate**
> void ReportDeleteReportTemplate (string id)

Deletes the template file of the report

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ReportDeleteReportTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReportApi();
            var id = id_example;  // string | Report id

            try
            {
                // Deletes the template file of the report
                apiInstance.ReportDeleteReportTemplate(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportDeleteReportTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Report id | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportexecutebyid"></a>
# **ReportExecuteById**
> System.IO.Stream ReportExecuteById (ReportExecuteRequestDTO executerequest = null)

Executes a report by id

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ReportExecuteByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReportApi();
            var executerequest = new ReportExecuteRequestDTO(); // ReportExecuteRequestDTO |  (optional) 

            try
            {
                // Executes a report by id
                System.IO.Stream result = apiInstance.ReportExecuteById(executerequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportExecuteById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **executerequest** | [**ReportExecuteRequestDTO**](ReportExecuteRequestDTO.md)|  | [optional] 

### Return type

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportexecutemultpileasyncbyid"></a>
# **ReportExecuteMultpileAsyncById**
> ReportExecuteAsyncResponseDTO ReportExecuteMultpileAsyncById (ReportExecuteMultipleRequestDTO executerequest = null)

Executes a report with one or more output formats by id. The operation is async

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ReportExecuteMultpileAsyncByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReportApi();
            var executerequest = new ReportExecuteMultipleRequestDTO(); // ReportExecuteMultipleRequestDTO |  (optional) 

            try
            {
                // Executes a report with one or more output formats by id. The operation is async
                ReportExecuteAsyncResponseDTO result = apiInstance.ReportExecuteMultpileAsyncById(executerequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportExecuteMultpileAsyncById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **executerequest** | [**ReportExecuteMultipleRequestDTO**](ReportExecuteMultipleRequestDTO.md)|  | [optional] 

### Return type

[**ReportExecuteAsyncResponseDTO**](ReportExecuteAsyncResponseDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportgetbyid"></a>
# **ReportGetById**
> void ReportGetById (string id)

Returns the report specified by id

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ReportGetByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReportApi();
            var id = id_example;  // string | 

            try
            {
                // Returns the report specified by id
                apiInstance.ReportGetById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportGetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportgetfindgroupbyid"></a>
# **ReportGetFindGroupById**
> FindGroupDTO ReportGetFindGroupById (string findGroupId, string reportId)

Get Find Group by Id considering report permissions

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ReportGetFindGroupByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReportApi();
            var findGroupId = findGroupId_example;  // string | 
            var reportId = reportId_example;  // string | 

            try
            {
                // Get Find Group by Id considering report permissions
                FindGroupDTO result = apiInstance.ReportGetFindGroupById(findGroupId, reportId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportGetFindGroupById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **findGroupId** | **string**|  | 
 **reportId** | **string**|  | 

### Return type

[**FindGroupDTO**](FindGroupDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportgetfindgrouplist"></a>
# **ReportGetFindGroupList**
> List<FindGroupDTO> ReportGetFindGroupList (string reportId)

List of Find Group considering report permissions

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ReportGetFindGroupListExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReportApi();
            var reportId = reportId_example;  // string | 

            try
            {
                // List of Find Group considering report permissions
                List&lt;FindGroupDTO&gt; result = apiInstance.ReportGetFindGroupList(reportId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportGetFindGroupList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportId** | **string**|  | 

### Return type

[**List<FindGroupDTO>**](FindGroupDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportgetlist"></a>
# **ReportGetList**
> void ReportGetList ()

Returns the list of all the report available for the user

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ReportGetListExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReportApi();

            try
            {
                // Returns the list of all the report available for the user
                apiInstance.ReportGetList();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportGetList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportgetpermission"></a>
# **ReportGetPermission**
> PermissionsDTO ReportGetPermission (string id)

Returns permissions of report

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ReportGetPermissionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReportApi();
            var id = id_example;  // string | 

            try
            {
                // Returns permissions of report
                PermissionsDTO result = apiInstance.ReportGetPermission(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportGetPermission: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

[**PermissionsDTO**](PermissionsDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportgetreportdatasource"></a>
# **ReportGetReportDataSource**
> Object ReportGetReportDataSource (string findGroupId, string reportId)

Gets report data source

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ReportGetReportDataSourceExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReportApi();
            var findGroupId = findGroupId_example;  // string | 
            var reportId = reportId_example;  // string | 

            try
            {
                // Gets report data source
                Object result = apiInstance.ReportGetReportDataSource(findGroupId, reportId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportGetReportDataSource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **findGroupId** | **string**|  | 
 **reportId** | **string**|  | 

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportgetreportparamdatasourcebyfindgroupid"></a>
# **ReportGetReportParamDataSourceByFindGroupId**
> List<ReportParamDataSourceDTO> ReportGetReportParamDataSourceByFindGroupId (string findGroupId, string reportId)

Gets report parameters datasource

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ReportGetReportParamDataSourceByFindGroupIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReportApi();
            var findGroupId = findGroupId_example;  // string | 
            var reportId = reportId_example;  // string | 

            try
            {
                // Gets report parameters datasource
                List&lt;ReportParamDataSourceDTO&gt; result = apiInstance.ReportGetReportParamDataSourceByFindGroupId(findGroupId, reportId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportGetReportParamDataSourceByFindGroupId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **findGroupId** | **string**|  | 
 **reportId** | **string**|  | 

### Return type

[**List<ReportParamDataSourceDTO>**](ReportParamDataSourceDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportgetreporttemplate"></a>
# **ReportGetReportTemplate**
> string ReportGetReportTemplate (string id, bool? editMode = null)

Gets the report template file

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ReportGetReportTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReportApi();
            var id = id_example;  // string | Report id
            var editMode = true;  // bool? | Determine if report references are visible (optional) 

            try
            {
                // Gets the report template file
                string result = apiInstance.ReportGetReportTemplate(id, editMode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportGetReportTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Report id | 
 **editMode** | **bool?**| Determine if report references are visible | [optional] 

### Return type

**string**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reporthandlereditmode"></a>
# **ReportHandlerEditMode**
> Object ReportHandlerEditMode ()

Executes a query for internal data source in edit mode

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ReportHandlerEditModeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReportApi();

            try
            {
                // Executes a query for internal data source in edit mode
                Object result = apiInstance.ReportHandlerEditMode();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportHandlerEditMode: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reporthandlerrunningmode"></a>
# **ReportHandlerRunningMode**
> Object ReportHandlerRunningMode ()

Executes a query for internal data source in running mode

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ReportHandlerRunningModeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReportApi();

            try
            {
                // Executes a query for internal data source in running mode
                Object result = apiInstance.ReportHandlerRunningMode();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportHandlerRunningMode: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportinsertreport"></a>
# **ReportInsertReport**
> ReportDTO ReportInsertReport (ReportDTO reportdto = null)

Inserts a new report

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ReportInsertReportExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReportApi();
            var reportdto = new ReportDTO(); // ReportDTO |  (optional) 

            try
            {
                // Inserts a new report
                ReportDTO result = apiInstance.ReportInsertReport(reportdto);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportInsertReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportdto** | [**ReportDTO**](ReportDTO.md)|  | [optional] 

### Return type

[**ReportDTO**](ReportDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsetpermission"></a>
# **ReportSetPermission**
> void ReportSetPermission (string id, PermissionsDTO permissions)

Sets report permissions

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ReportSetPermissionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReportApi();
            var id = id_example;  // string | Report Identifier
            var permissions = new PermissionsDTO(); // PermissionsDTO | Permissions data

            try
            {
                // Sets report permissions
                apiInstance.ReportSetPermission(id, permissions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportSetPermission: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Report Identifier | 
 **permissions** | [**PermissionsDTO**](PermissionsDTO.md)| Permissions data | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportupdatereport"></a>
# **ReportUpdateReport**
> ReportDTO ReportUpdateReport (ReportDTO reportdto = null)

Updates the report

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ReportUpdateReportExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReportApi();
            var reportdto = new ReportDTO(); // ReportDTO |  (optional) 

            try
            {
                // Updates the report
                ReportDTO result = apiInstance.ReportUpdateReport(reportdto);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportUpdateReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportdto** | [**ReportDTO**](ReportDTO.md)|  | [optional] 

### Return type

[**ReportDTO**](ReportDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportupdatereporttemplate"></a>
# **ReportUpdateReportTemplate**
> void ReportUpdateReportTemplate (string id, string reportTemplate)

Updates the template file of the report

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ReportUpdateReportTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReportApi();
            var id = id_example;  // string | Report id
            var reportTemplate = reportTemplate_example;  // string | Report template

            try
            {
                // Updates the template file of the report
                apiInstance.ReportUpdateReportTemplate(id, reportTemplate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportUpdateReportTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Report id | 
 **reportTemplate** | **string**| Report template | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


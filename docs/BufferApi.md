# ARXivarNEXT.Client.Api.BufferApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BufferDeleteByBufferId**](BufferApi.md#bufferdeletebybufferid) | **DELETE** /api/Buffer/{bufferId} | 
[**BufferGetBufferElement**](BufferApi.md#buffergetbufferelement) | **GET** /api/Buffer/{id} | This call returns the information about the buffer element
[**BufferGetFile**](BufferApi.md#buffergetfile) | **GET** /api/Buffer/file/{id} | This call returns the file of the buffer element
[**BufferGetForMonitoredFolder**](BufferApi.md#buffergetformonitoredfolder) | **GET** /api/Buffer/ForMonitoredFolder | This call returns the list of the document in the buffer for the monitored folder
[**BufferInsert**](BufferApi.md#bufferinsert) | **POST** /api/Buffer/insert | This call allows to add a file to the buffer
[**BufferInsertAdvanced**](BufferApi.md#bufferinsertadvanced) | **POST** /api/Buffer/insert/{elementTypeEnum}/{description} | This call allows to add a file to the buffer
[**BufferInsertAdvancedForMonitoredFolder**](BufferApi.md#bufferinsertadvancedformonitoredfolder) | **POST** /api/Buffer/insertForMonitoredFolder/{elementTypeEnum}/{monitoredFolderId}/{description} | This call allows to add a file to the buffer


<a name="bufferdeletebybufferid"></a>
# **BufferDeleteByBufferId**
> bool? BufferDeleteByBufferId (string bufferId)



### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BufferDeleteByBufferIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BufferApi();
            var bufferId = bufferId_example;  // string | 

            try
            {
                bool? result = apiInstance.BufferDeleteByBufferId(bufferId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BufferApi.BufferDeleteByBufferId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bufferId** | **string**|  | 

### Return type

**bool?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buffergetbufferelement"></a>
# **BufferGetBufferElement**
> BufferSimpleElement BufferGetBufferElement (string id)

This call returns the information about the buffer element

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BufferGetBufferElementExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BufferApi();
            var id = id_example;  // string | 

            try
            {
                // This call returns the information about the buffer element
                BufferSimpleElement result = apiInstance.BufferGetBufferElement(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BufferApi.BufferGetBufferElement: " + e.Message );
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

[**BufferSimpleElement**](BufferSimpleElement.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buffergetfile"></a>
# **BufferGetFile**
> System.IO.Stream BufferGetFile (string id)

This call returns the file of the buffer element

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BufferGetFileExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BufferApi();
            var id = id_example;  // string | 

            try
            {
                // This call returns the file of the buffer element
                System.IO.Stream result = apiInstance.BufferGetFile(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BufferApi.BufferGetFile: " + e.Message );
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

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buffergetformonitoredfolder"></a>
# **BufferGetForMonitoredFolder**
> List<BufferSimpleElement> BufferGetForMonitoredFolder ()

This call returns the list of the document in the buffer for the monitored folder

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BufferGetForMonitoredFolderExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BufferApi();

            try
            {
                // This call returns the list of the document in the buffer for the monitored folder
                List&lt;BufferSimpleElement&gt; result = apiInstance.BufferGetForMonitoredFolder();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BufferApi.BufferGetForMonitoredFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<BufferSimpleElement>**](BufferSimpleElement.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bufferinsert"></a>
# **BufferInsert**
> List<string> BufferInsert (System.IO.Stream _file)

This call allows to add a file to the buffer

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BufferInsertExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BufferApi();
            var _file = new System.IO.Stream(); // System.IO.Stream | The file

            try
            {
                // This call allows to add a file to the buffer
                List&lt;string&gt; result = apiInstance.BufferInsert(_file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BufferApi.BufferInsert: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_file** | **System.IO.Stream**| The file | 

### Return type

**List<string>**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bufferinsertadvanced"></a>
# **BufferInsertAdvanced**
> List<string> BufferInsertAdvanced (int? elementTypeEnum, string description, System.IO.Stream _file)

This call allows to add a file to the buffer

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BufferInsertAdvancedExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BufferApi();
            var elementTypeEnum = 56;  // int? | Possible values:  0: DmBuffer  1: NextArchive  2: MonitoredFolder  3: ProcessDocThumbnail  4: CloneProfile  5: ReportExecuted 
            var description = description_example;  // string | Description
            var _file = new System.IO.Stream(); // System.IO.Stream | The file

            try
            {
                // This call allows to add a file to the buffer
                List&lt;string&gt; result = apiInstance.BufferInsertAdvanced(elementTypeEnum, description, _file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BufferApi.BufferInsertAdvanced: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **elementTypeEnum** | **int?**| Possible values:  0: DmBuffer  1: NextArchive  2: MonitoredFolder  3: ProcessDocThumbnail  4: CloneProfile  5: ReportExecuted  | 
 **description** | **string**| Description | 
 **_file** | **System.IO.Stream**| The file | 

### Return type

**List<string>**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bufferinsertadvancedformonitoredfolder"></a>
# **BufferInsertAdvancedForMonitoredFolder**
> List<string> BufferInsertAdvancedForMonitoredFolder (int? elementTypeEnum, string monitoredFolderId, string description, System.IO.Stream _file)

This call allows to add a file to the buffer

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BufferInsertAdvancedForMonitoredFolderExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BufferApi();
            var elementTypeEnum = 56;  // int? | Possible values:  0: DmBuffer  1: NextArchive  2: MonitoredFolder  3: ProcessDocThumbnail  4: CloneProfile  5: ReportExecuted 
            var monitoredFolderId = monitoredFolderId_example;  // string | If the buffer is related to a monitored folder
            var description = description_example;  // string | Description
            var _file = new System.IO.Stream(); // System.IO.Stream | The file

            try
            {
                // This call allows to add a file to the buffer
                List&lt;string&gt; result = apiInstance.BufferInsertAdvancedForMonitoredFolder(elementTypeEnum, monitoredFolderId, description, _file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BufferApi.BufferInsertAdvancedForMonitoredFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **elementTypeEnum** | **int?**| Possible values:  0: DmBuffer  1: NextArchive  2: MonitoredFolder  3: ProcessDocThumbnail  4: CloneProfile  5: ReportExecuted  | 
 **monitoredFolderId** | **string**| If the buffer is related to a monitored folder | 
 **description** | **string**| Description | 
 **_file** | **System.IO.Stream**| The file | 

### Return type

**List<string>**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


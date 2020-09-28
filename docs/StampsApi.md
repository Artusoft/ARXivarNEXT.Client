# ARXivarNEXT.Client.Api.StampsApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**StampsApplyStampInstanceFromDocnumber**](StampsApi.md#stampsapplystampinstancefromdocnumber) | **PUT** /api/Stamps/applyStampInstanceFromDocnumber/{docnumber} | This call apply stampinstances in document
[**StampsApplyStampInstanceFromProcessDoc**](StampsApi.md#stampsapplystampinstancefromprocessdoc) | **PUT** /api/Stamps/applyStampInstanceFromProcessDoc/{processDocId} | This call apply stampinstances in process document
[**StampsCanAddVirtualStamp**](StampsApi.md#stampscanaddvirtualstamp) | **GET** /api/Stamps/canAddVirtualStamps | This call returns if user can add virtual stamps
[**StampsCanApplyStamp**](StampsApi.md#stampscanapplystamp) | **GET** /api/Stamps/canApplyStamps | This call returns if user can apply stamps
[**StampsConvertToPngByDocnumberAndPageIndex**](StampsApi.md#stampsconverttopngbydocnumberandpageindex) | **POST** /api/Stamps/convertToPng/{docnumber}/{pageIndex} | This call returns the png file results on convertion from pdf file of profile
[**StampsConvertToPngByProcessDocAndPageIndex**](StampsApi.md#stampsconverttopngbyprocessdocandpageindex) | **POST** /api/Stamps/convertToPngForTask/{processDocId}/{pageIndex} | This call returns the png file results on convertion from pdf file of task profile
[**StampsDeleteStampInstanceFromDocnumber**](StampsApi.md#stampsdeletestampinstancefromdocnumber) | **DELETE** /api/Stamps/stampInstanceFromDocnumber/{docnumber} | This call deletes stampinstances from docnumber
[**StampsDeleteStampInstanceFromProcessDoc**](StampsApi.md#stampsdeletestampinstancefromprocessdoc) | **DELETE** /api/Stamps/stampInstanceFromProcessDoc/{processDocId} | This call deletes stampinstances from docnumber for task
[**StampsGet**](StampsApi.md#stampsget) | **GET** /api/Stamps | This call returns all the type of stamp defined in Arxivar
[**StampsGetPdfPageNumber**](StampsApi.md#stampsgetpdfpagenumber) | **GET** /api/Stamps/getPdfPageNumber/{docnumber} | This call returns the number of pages for pdf document
[**StampsGetPdfPageNumberForProcessDoc**](StampsApi.md#stampsgetpdfpagenumberforprocessdoc) | **GET** /api/Stamps/getPdfPageNumberForProcessDoc/{processDocId} | This call returns the number of pages for pdf document for task
[**StampsGetStampsDefinitionByDocnumber**](StampsApi.md#stampsgetstampsdefinitionbydocnumber) | **GET** /api/Stamps/stampDefinitionByDocnumber/{docnumber} | This call returns all the stamp definition virtual by a docnumber
[**StampsGetStampsDefinitionByProcessDoc**](StampsApi.md#stampsgetstampsdefinitionbyprocessdoc) | **GET** /api/Stamps/stampDefinitionByProcessDoc/{processDocId} | This call returns all the stamp definition virtual by a process document
[**StampsGetStampsInstanceByDocnumber**](StampsApi.md#stampsgetstampsinstancebydocnumber) | **GET** /api/Stamps/stampInstanceByDocnumber/{docnumber} | This call returns all the stamp applied virtual on a docnumber
[**StampsGetStampsInstanceByProcessDoc**](StampsApi.md#stampsgetstampsinstancebyprocessdoc) | **GET** /api/Stamps/stampInstanceByProcessDoc/{processDocId} | This call returns all the stamp applied virtual on a process document
[**StampsInsertStampInstanceFromDocnumber**](StampsApi.md#stampsinsertstampinstancefromdocnumber) | **POST** /api/Stamps/stampInstanceFromDocnumber/{docnumber} | This call inserts new stampinstances for docnumber
[**StampsInsertStampInstanceFromProcessDoc**](StampsApi.md#stampsinsertstampinstancefromprocessdoc) | **POST** /api/Stamps/stampInstanceFromProcessDoc/{processDocId} | This call inserts new stampinstances for process document
[**StampsUpdateStampInstanceFromDocnumber**](StampsApi.md#stampsupdatestampinstancefromdocnumber) | **PUT** /api/Stamps/stampInstanceFromDocnumber/{docnumber} | This call updates new stampinstances for docnumber
[**StampsUpdateStampInstanceFromProcessDoc**](StampsApi.md#stampsupdatestampinstancefromprocessdoc) | **PUT** /api/Stamps/stampInstanceFromProcessDoc/{processDocId} | This call updates stampinstances for process document


<a name="stampsapplystampinstancefromdocnumber"></a>
# **StampsApplyStampInstanceFromDocnumber**
> void StampsApplyStampInstanceFromDocnumber (int? docnumber)

This call apply stampinstances in document

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class StampsApplyStampInstanceFromDocnumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StampsApi();
            var docnumber = 56;  // int? | 

            try
            {
                // This call apply stampinstances in document
                apiInstance.StampsApplyStampInstanceFromDocnumber(docnumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StampsApi.StampsApplyStampInstanceFromDocnumber: " + e.Message );
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

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stampsapplystampinstancefromprocessdoc"></a>
# **StampsApplyStampInstanceFromProcessDoc**
> void StampsApplyStampInstanceFromProcessDoc (int? processDocId)

This call apply stampinstances in process document

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class StampsApplyStampInstanceFromProcessDocExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StampsApi();
            var processDocId = 56;  // int? | 

            try
            {
                // This call apply stampinstances in process document
                apiInstance.StampsApplyStampInstanceFromProcessDoc(processDocId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StampsApi.StampsApplyStampInstanceFromProcessDoc: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDocId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stampscanaddvirtualstamp"></a>
# **StampsCanAddVirtualStamp**
> bool? StampsCanAddVirtualStamp ()

This call returns if user can add virtual stamps

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class StampsCanAddVirtualStampExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StampsApi();

            try
            {
                // This call returns if user can add virtual stamps
                bool? result = apiInstance.StampsCanAddVirtualStamp();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StampsApi.StampsCanAddVirtualStamp: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**bool?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stampscanapplystamp"></a>
# **StampsCanApplyStamp**
> bool? StampsCanApplyStamp ()

This call returns if user can apply stamps

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class StampsCanApplyStampExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StampsApi();

            try
            {
                // This call returns if user can apply stamps
                bool? result = apiInstance.StampsCanApplyStamp();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StampsApi.StampsCanApplyStamp: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**bool?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stampsconverttopngbydocnumberandpageindex"></a>
# **StampsConvertToPngByDocnumberAndPageIndex**
> System.IO.Stream StampsConvertToPngByDocnumberAndPageIndex (int? docnumber, int? pageIndex)

This call returns the png file results on convertion from pdf file of profile

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class StampsConvertToPngByDocnumberAndPageIndexExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StampsApi();
            var docnumber = 56;  // int? | Document Identifier
            var pageIndex = 56;  // int? | Page index

            try
            {
                // This call returns the png file results on convertion from pdf file of profile
                System.IO.Stream result = apiInstance.StampsConvertToPngByDocnumberAndPageIndex(docnumber, pageIndex);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StampsApi.StampsConvertToPngByDocnumberAndPageIndex: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| Document Identifier | 
 **pageIndex** | **int?**| Page index | 

### Return type

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stampsconverttopngbyprocessdocandpageindex"></a>
# **StampsConvertToPngByProcessDocAndPageIndex**
> System.IO.Stream StampsConvertToPngByProcessDocAndPageIndex (int? processDocId, int? pageIndex)

This call returns the png file results on convertion from pdf file of task profile

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class StampsConvertToPngByProcessDocAndPageIndexExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StampsApi();
            var processDocId = 56;  // int? | Process document Identifier
            var pageIndex = 56;  // int? | Page index

            try
            {
                // This call returns the png file results on convertion from pdf file of task profile
                System.IO.Stream result = apiInstance.StampsConvertToPngByProcessDocAndPageIndex(processDocId, pageIndex);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StampsApi.StampsConvertToPngByProcessDocAndPageIndex: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDocId** | **int?**| Process document Identifier | 
 **pageIndex** | **int?**| Page index | 

### Return type

**System.IO.Stream**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stampsdeletestampinstancefromdocnumber"></a>
# **StampsDeleteStampInstanceFromDocnumber**
> void StampsDeleteStampInstanceFromDocnumber (int? docnumber, List<StampsInstanceDTO> toRemove)

This call deletes stampinstances from docnumber

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class StampsDeleteStampInstanceFromDocnumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StampsApi();
            var docnumber = 56;  // int? | 
            var toRemove = new List<StampsInstanceDTO>(); // List<StampsInstanceDTO> | 

            try
            {
                // This call deletes stampinstances from docnumber
                apiInstance.StampsDeleteStampInstanceFromDocnumber(docnumber, toRemove);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StampsApi.StampsDeleteStampInstanceFromDocnumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**|  | 
 **toRemove** | [**List&lt;StampsInstanceDTO&gt;**](StampsInstanceDTO.md)|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stampsdeletestampinstancefromprocessdoc"></a>
# **StampsDeleteStampInstanceFromProcessDoc**
> void StampsDeleteStampInstanceFromProcessDoc (int? processDocId, List<StampsInstanceDTO> toRemove)

This call deletes stampinstances from docnumber for task

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class StampsDeleteStampInstanceFromProcessDocExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StampsApi();
            var processDocId = 56;  // int? | 
            var toRemove = new List<StampsInstanceDTO>(); // List<StampsInstanceDTO> | 

            try
            {
                // This call deletes stampinstances from docnumber for task
                apiInstance.StampsDeleteStampInstanceFromProcessDoc(processDocId, toRemove);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StampsApi.StampsDeleteStampInstanceFromProcessDoc: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDocId** | **int?**|  | 
 **toRemove** | [**List&lt;StampsInstanceDTO&gt;**](StampsInstanceDTO.md)|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stampsget"></a>
# **StampsGet**
> List<StampDefinitionDTO> StampsGet ()

This call returns all the type of stamp defined in Arxivar

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class StampsGetExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StampsApi();

            try
            {
                // This call returns all the type of stamp defined in Arxivar
                List&lt;StampDefinitionDTO&gt; result = apiInstance.StampsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StampsApi.StampsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<StampDefinitionDTO>**](StampDefinitionDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stampsgetpdfpagenumber"></a>
# **StampsGetPdfPageNumber**
> int? StampsGetPdfPageNumber (int? docnumber)

This call returns the number of pages for pdf document

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class StampsGetPdfPageNumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StampsApi();
            var docnumber = 56;  // int? | 

            try
            {
                // This call returns the number of pages for pdf document
                int? result = apiInstance.StampsGetPdfPageNumber(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StampsApi.StampsGetPdfPageNumber: " + e.Message );
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

**int?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stampsgetpdfpagenumberforprocessdoc"></a>
# **StampsGetPdfPageNumberForProcessDoc**
> int? StampsGetPdfPageNumberForProcessDoc (int? processDocId)

This call returns the number of pages for pdf document for task

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class StampsGetPdfPageNumberForProcessDocExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StampsApi();
            var processDocId = 56;  // int? | 

            try
            {
                // This call returns the number of pages for pdf document for task
                int? result = apiInstance.StampsGetPdfPageNumberForProcessDoc(processDocId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StampsApi.StampsGetPdfPageNumberForProcessDoc: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDocId** | **int?**|  | 

### Return type

**int?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stampsgetstampsdefinitionbydocnumber"></a>
# **StampsGetStampsDefinitionByDocnumber**
> List<StampDefinitionDTO> StampsGetStampsDefinitionByDocnumber (int? docnumber)

This call returns all the stamp definition virtual by a docnumber

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class StampsGetStampsDefinitionByDocnumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StampsApi();
            var docnumber = 56;  // int? | 

            try
            {
                // This call returns all the stamp definition virtual by a docnumber
                List&lt;StampDefinitionDTO&gt; result = apiInstance.StampsGetStampsDefinitionByDocnumber(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StampsApi.StampsGetStampsDefinitionByDocnumber: " + e.Message );
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

[**List<StampDefinitionDTO>**](StampDefinitionDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stampsgetstampsdefinitionbyprocessdoc"></a>
# **StampsGetStampsDefinitionByProcessDoc**
> List<StampDefinitionDTO> StampsGetStampsDefinitionByProcessDoc (int? processDocId)

This call returns all the stamp definition virtual by a process document

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class StampsGetStampsDefinitionByProcessDocExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StampsApi();
            var processDocId = 56;  // int? | 

            try
            {
                // This call returns all the stamp definition virtual by a process document
                List&lt;StampDefinitionDTO&gt; result = apiInstance.StampsGetStampsDefinitionByProcessDoc(processDocId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StampsApi.StampsGetStampsDefinitionByProcessDoc: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDocId** | **int?**|  | 

### Return type

[**List<StampDefinitionDTO>**](StampDefinitionDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stampsgetstampsinstancebydocnumber"></a>
# **StampsGetStampsInstanceByDocnumber**
> List<StampsInstanceDTO> StampsGetStampsInstanceByDocnumber (int? docnumber)

This call returns all the stamp applied virtual on a docnumber

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class StampsGetStampsInstanceByDocnumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StampsApi();
            var docnumber = 56;  // int? | 

            try
            {
                // This call returns all the stamp applied virtual on a docnumber
                List&lt;StampsInstanceDTO&gt; result = apiInstance.StampsGetStampsInstanceByDocnumber(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StampsApi.StampsGetStampsInstanceByDocnumber: " + e.Message );
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

[**List<StampsInstanceDTO>**](StampsInstanceDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stampsgetstampsinstancebyprocessdoc"></a>
# **StampsGetStampsInstanceByProcessDoc**
> List<StampsInstanceDTO> StampsGetStampsInstanceByProcessDoc (int? processDocId)

This call returns all the stamp applied virtual on a process document

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class StampsGetStampsInstanceByProcessDocExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StampsApi();
            var processDocId = 56;  // int? | 

            try
            {
                // This call returns all the stamp applied virtual on a process document
                List&lt;StampsInstanceDTO&gt; result = apiInstance.StampsGetStampsInstanceByProcessDoc(processDocId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StampsApi.StampsGetStampsInstanceByProcessDoc: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDocId** | **int?**|  | 

### Return type

[**List<StampsInstanceDTO>**](StampsInstanceDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stampsinsertstampinstancefromdocnumber"></a>
# **StampsInsertStampInstanceFromDocnumber**
> void StampsInsertStampInstanceFromDocnumber (int? docnumber, List<StampsInstanceDTO> toInsert)

This call inserts new stampinstances for docnumber

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class StampsInsertStampInstanceFromDocnumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StampsApi();
            var docnumber = 56;  // int? | 
            var toInsert = new List<StampsInstanceDTO>(); // List<StampsInstanceDTO> | 

            try
            {
                // This call inserts new stampinstances for docnumber
                apiInstance.StampsInsertStampInstanceFromDocnumber(docnumber, toInsert);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StampsApi.StampsInsertStampInstanceFromDocnumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**|  | 
 **toInsert** | [**List&lt;StampsInstanceDTO&gt;**](StampsInstanceDTO.md)|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stampsinsertstampinstancefromprocessdoc"></a>
# **StampsInsertStampInstanceFromProcessDoc**
> void StampsInsertStampInstanceFromProcessDoc (int? processDocId, List<StampsInstanceDTO> toInsert)

This call inserts new stampinstances for process document

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class StampsInsertStampInstanceFromProcessDocExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StampsApi();
            var processDocId = 56;  // int? | 
            var toInsert = new List<StampsInstanceDTO>(); // List<StampsInstanceDTO> | 

            try
            {
                // This call inserts new stampinstances for process document
                apiInstance.StampsInsertStampInstanceFromProcessDoc(processDocId, toInsert);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StampsApi.StampsInsertStampInstanceFromProcessDoc: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDocId** | **int?**|  | 
 **toInsert** | [**List&lt;StampsInstanceDTO&gt;**](StampsInstanceDTO.md)|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stampsupdatestampinstancefromdocnumber"></a>
# **StampsUpdateStampInstanceFromDocnumber**
> void StampsUpdateStampInstanceFromDocnumber (int? docnumber, List<StampsInstanceDTO> toUpdate)

This call updates new stampinstances for docnumber

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class StampsUpdateStampInstanceFromDocnumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StampsApi();
            var docnumber = 56;  // int? | 
            var toUpdate = new List<StampsInstanceDTO>(); // List<StampsInstanceDTO> | 

            try
            {
                // This call updates new stampinstances for docnumber
                apiInstance.StampsUpdateStampInstanceFromDocnumber(docnumber, toUpdate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StampsApi.StampsUpdateStampInstanceFromDocnumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**|  | 
 **toUpdate** | [**List&lt;StampsInstanceDTO&gt;**](StampsInstanceDTO.md)|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stampsupdatestampinstancefromprocessdoc"></a>
# **StampsUpdateStampInstanceFromProcessDoc**
> void StampsUpdateStampInstanceFromProcessDoc (int? processDocId, List<StampsInstanceDTO> toUpdate)

This call updates stampinstances for process document

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class StampsUpdateStampInstanceFromProcessDocExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StampsApi();
            var processDocId = 56;  // int? | 
            var toUpdate = new List<StampsInstanceDTO>(); // List<StampsInstanceDTO> | 

            try
            {
                // This call updates stampinstances for process document
                apiInstance.StampsUpdateStampInstanceFromProcessDoc(processDocId, toUpdate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StampsApi.StampsUpdateStampInstanceFromProcessDoc: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processDocId** | **int?**|  | 
 **toUpdate** | [**List&lt;StampsInstanceDTO&gt;**](StampsInstanceDTO.md)|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


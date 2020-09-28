# ARXivarNEXT.Client.Api.FindApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FindGetFindGroupById**](FindApi.md#findgetfindgroupbyid) | **GET** /api/Find/{id} | Get Find Group by Id
[**FindGetFindGroupList**](FindApi.md#findgetfindgrouplist) | **GET** /api/Find/GroupList | List of Find Group


<a name="findgetfindgroupbyid"></a>
# **FindGetFindGroupById**
> FindGroupDTO FindGetFindGroupById (string id)

Get Find Group by Id

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FindGetFindGroupByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindApi();
            var id = id_example;  // string | 

            try
            {
                // Get Find Group by Id
                FindGroupDTO result = apiInstance.FindGetFindGroupById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindApi.FindGetFindGroupById: " + e.Message );
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

[**FindGroupDTO**](FindGroupDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findgetfindgrouplist"></a>
# **FindGetFindGroupList**
> List<FindGroupDTO> FindGetFindGroupList ()

List of Find Group

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class FindGetFindGroupListExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FindApi();

            try
            {
                // List of Find Group
                List&lt;FindGroupDTO&gt; result = apiInstance.FindGetFindGroupList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FindApi.FindGetFindGroupList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<FindGroupDTO>**](FindGroupDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


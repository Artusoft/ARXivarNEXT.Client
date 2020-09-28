# ARXivarNEXT.Client.Api.GroupsModelsApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GroupsModelsDeleteGroupModel**](GroupsModelsApi.md#groupsmodelsdeletegroupmodel) | **DELETE** /api/ModelsGroups/{id} | This call deletes a group model
[**GroupsModelsGetGroupsModels**](GroupsModelsApi.md#groupsmodelsgetgroupsmodels) | **GET** /api/ModelsGroups | This call returns the groups models on user connected
[**GroupsModelsUpdateModel**](GroupsModelsApi.md#groupsmodelsupdatemodel) | **PUT** /api/ModelsGroups/{id} | This call updates a model group
[**GroupsModelsWriteGroupModel**](GroupsModelsApi.md#groupsmodelswritegroupmodel) | **POST** /api/ModelsGroups | This call adds new group model


<a name="groupsmodelsdeletegroupmodel"></a>
# **GroupsModelsDeleteGroupModel**
> void GroupsModelsDeleteGroupModel (int? id)

This call deletes a group model

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class GroupsModelsDeleteGroupModelExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupsModelsApi();
            var id = 56;  // int? | Identifier of the group model

            try
            {
                // This call deletes a group model
                apiInstance.GroupsModelsDeleteGroupModel(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsModelsApi.GroupsModelsDeleteGroupModel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Identifier of the group model | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupsmodelsgetgroupsmodels"></a>
# **GroupsModelsGetGroupsModels**
> List<GroupModelDTO> GroupsModelsGetGroupsModels ()

This call returns the groups models on user connected

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class GroupsModelsGetGroupsModelsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupsModelsApi();

            try
            {
                // This call returns the groups models on user connected
                List&lt;GroupModelDTO&gt; result = apiInstance.GroupsModelsGetGroupsModels();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsModelsApi.GroupsModelsGetGroupsModels: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<GroupModelDTO>**](GroupModelDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupsmodelsupdatemodel"></a>
# **GroupsModelsUpdateModel**
> void GroupsModelsUpdateModel (int? id, string groupModelName)

This call updates a model group

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class GroupsModelsUpdateModelExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupsModelsApi();
            var id = 56;  // int? | Identifier of the group model
            var groupModelName = groupModelName_example;  // string | Name to update

            try
            {
                // This call updates a model group
                apiInstance.GroupsModelsUpdateModel(id, groupModelName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsModelsApi.GroupsModelsUpdateModel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Identifier of the group model | 
 **groupModelName** | **string**| Name to update | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupsmodelswritegroupmodel"></a>
# **GroupsModelsWriteGroupModel**
> void GroupsModelsWriteGroupModel (GroupModelDTO groupModelDto)

This call adds new group model

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class GroupsModelsWriteGroupModelExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GroupsModelsApi();
            var groupModelDto = new GroupModelDTO(); // GroupModelDTO | Data of group model

            try
            {
                // This call adds new group model
                apiInstance.GroupsModelsWriteGroupModel(groupModelDto);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsModelsApi.GroupsModelsWriteGroupModel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupModelDto** | [**GroupModelDTO**](GroupModelDTO.md)| Data of group model | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


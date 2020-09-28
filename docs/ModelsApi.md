# ARXivarNEXT.Client.Api.ModelsApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ModelsCancelPostArchiveModelEdit**](ModelsApi.md#modelscancelpostarchivemodeledit) | **PUT** /api/Models/canceledit/{docnumber} | This call allows to cancel the editing of a document created by model profilation in order to generate the first revision of the document itself
[**ModelsDelete**](ModelsApi.md#modelsdelete) | **DELETE** /api/Models/{id} | This call deletes a model
[**ModelsGetForModelPreviewTemplate**](ModelsApi.md#modelsgetformodelpreviewtemplate) | **GET** /api/Models/previewTemplate/{id} | This call returns the template preview file for a model
[**ModelsGetForModelTemplate**](ModelsApi.md#modelsgetformodeltemplate) | **GET** /api/Models/template/{modelId} | This call retrieves the template file for a model
[**ModelsGetModelById**](ModelsApi.md#modelsgetmodelbyid) | **GET** /api/Models/{id} | This call returns model
[**ModelsGetModelsList**](ModelsApi.md#modelsgetmodelslist) | **GET** /api/Models | This call allows the retrieval of the default profile for archiving
[**ModelsGetPermission**](ModelsApi.md#modelsgetpermission) | **GET** /api/Models/{id}/Permissions | This call returns permissions of model
[**ModelsGetProfileSchemaByModelId**](ModelsApi.md#modelsgetprofileschemabymodelid) | **GET** /api/Models/{modelId}/profileSchema | This call returns a profile schema for a model
[**ModelsInsertModel**](ModelsApi.md#modelsinsertmodel) | **POST** /api/Models | This call inserts a model
[**ModelsPost**](ModelsApi.md#modelspost) | **POST** /api/Models/{modelId}/Profile | This call executes a new profiling by model
[**ModelsSetPermission**](ModelsApi.md#modelssetpermission) | **POST** /api/Models/{id}/Permissions | This call sets model&#39;s permissions
[**ModelsUpdateModel**](ModelsApi.md#modelsupdatemodel) | **PUT** /api/Models/{id} | This call updates a model


<a name="modelscancelpostarchivemodeledit"></a>
# **ModelsCancelPostArchiveModelEdit**
> void ModelsCancelPostArchiveModelEdit (int? docnumber)

This call allows to cancel the editing of a document created by model profilation in order to generate the first revision of the document itself

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ModelsCancelPostArchiveModelEditExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModelsApi();
            var docnumber = 56;  // int? | Document Identifier

            try
            {
                // This call allows to cancel the editing of a document created by model profilation in order to generate the first revision of the document itself
                apiInstance.ModelsCancelPostArchiveModelEdit(docnumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModelsApi.ModelsCancelPostArchiveModelEdit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| Document Identifier | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modelsdelete"></a>
# **ModelsDelete**
> Object ModelsDelete (int? id)

This call deletes a model

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ModelsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModelsApi();
            var id = 56;  // int? | Model Identifier

            try
            {
                // This call deletes a model
                Object result = apiInstance.ModelsDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModelsApi.ModelsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Model Identifier | 

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modelsgetformodelpreviewtemplate"></a>
# **ModelsGetForModelPreviewTemplate**
> Object ModelsGetForModelPreviewTemplate (int? id)

This call returns the template preview file for a model

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ModelsGetForModelPreviewTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModelsApi();
            var id = 56;  // int? | Model Identifier

            try
            {
                // This call returns the template preview file for a model
                Object result = apiInstance.ModelsGetForModelPreviewTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModelsApi.ModelsGetForModelPreviewTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Model Identifier | 

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modelsgetformodeltemplate"></a>
# **ModelsGetForModelTemplate**
> Object ModelsGetForModelTemplate (int? modelId)

This call retrieves the template file for a model

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ModelsGetForModelTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModelsApi();
            var modelId = 56;  // int? | Model Identifier

            try
            {
                // This call retrieves the template file for a model
                Object result = apiInstance.ModelsGetForModelTemplate(modelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModelsApi.ModelsGetForModelTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **modelId** | **int?**| Model Identifier | 

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modelsgetmodelbyid"></a>
# **ModelsGetModelById**
> ModelConfigurationDTO ModelsGetModelById (int? id)

This call returns model

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ModelsGetModelByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModelsApi();
            var id = 56;  // int? | Model Identifier

            try
            {
                // This call returns model
                ModelConfigurationDTO result = apiInstance.ModelsGetModelById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModelsApi.ModelsGetModelById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Model Identifier | 

### Return type

[**ModelConfigurationDTO**](ModelConfigurationDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modelsgetmodelslist"></a>
# **ModelsGetModelsList**
> List<ModelDTO> ModelsGetModelsList ()

This call allows the retrieval of the default profile for archiving

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ModelsGetModelsListExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModelsApi();

            try
            {
                // This call allows the retrieval of the default profile for archiving
                List&lt;ModelDTO&gt; result = apiInstance.ModelsGetModelsList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModelsApi.ModelsGetModelsList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ModelDTO>**](ModelDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modelsgetpermission"></a>
# **ModelsGetPermission**
> PermissionsDTO ModelsGetPermission (int? id)

This call returns permissions of model

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ModelsGetPermissionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModelsApi();
            var id = 56;  // int? | Model Identifier

            try
            {
                // This call returns permissions of model
                PermissionsDTO result = apiInstance.ModelsGetPermission(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModelsApi.ModelsGetPermission: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Model Identifier | 

### Return type

[**PermissionsDTO**](PermissionsDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modelsgetprofileschemabymodelid"></a>
# **ModelsGetProfileSchemaByModelId**
> ModelProfileSchemaDTO ModelsGetProfileSchemaByModelId (int? modelId)

This call returns a profile schema for a model

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ModelsGetProfileSchemaByModelIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModelsApi();
            var modelId = 56;  // int? | Model Identifier

            try
            {
                // This call returns a profile schema for a model
                ModelProfileSchemaDTO result = apiInstance.ModelsGetProfileSchemaByModelId(modelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModelsApi.ModelsGetProfileSchemaByModelId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **modelId** | **int?**| Model Identifier | 

### Return type

[**ModelProfileSchemaDTO**](ModelProfileSchemaDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modelsinsertmodel"></a>
# **ModelsInsertModel**
> void ModelsInsertModel (ModelConfigurationDTO model = null)

This call inserts a model

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ModelsInsertModelExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModelsApi();
            var model = new ModelConfigurationDTO(); // ModelConfigurationDTO |  (optional) 

            try
            {
                // This call inserts a model
                apiInstance.ModelsInsertModel(model);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModelsApi.ModelsInsertModel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**ModelConfigurationDTO**](ModelConfigurationDTO.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modelspost"></a>
# **ModelsPost**
> ProfileResultDTO ModelsPost (int? modelId, ProfileDTO profile = null)

This call executes a new profiling by model

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ModelsPostExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModelsApi();
            var modelId = 56;  // int? | Model Identifier
            var profile = new ProfileDTO(); // ProfileDTO |  (optional) 

            try
            {
                // This call executes a new profiling by model
                ProfileResultDTO result = apiInstance.ModelsPost(modelId, profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModelsApi.ModelsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **modelId** | **int?**| Model Identifier | 
 **profile** | [**ProfileDTO**](ProfileDTO.md)|  | [optional] 

### Return type

[**ProfileResultDTO**](ProfileResultDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modelssetpermission"></a>
# **ModelsSetPermission**
> void ModelsSetPermission (int? id, PermissionsDTO permissions)

This call sets model's permissions

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ModelsSetPermissionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModelsApi();
            var id = 56;  // int? | Model Identifier
            var permissions = new PermissionsDTO(); // PermissionsDTO | Permissions data

            try
            {
                // This call sets model's permissions
                apiInstance.ModelsSetPermission(id, permissions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModelsApi.ModelsSetPermission: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Model Identifier | 
 **permissions** | [**PermissionsDTO**](PermissionsDTO.md)| Permissions data | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modelsupdatemodel"></a>
# **ModelsUpdateModel**
> void ModelsUpdateModel (int? id, ModelConfigurationDTO model = null)

This call updates a model

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class ModelsUpdateModelExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModelsApi();
            var id = 56;  // int? | Model Identifier
            var model = new ModelConfigurationDTO(); // ModelConfigurationDTO |  (optional) 

            try
            {
                // This call updates a model
                apiInstance.ModelsUpdateModel(id, model);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModelsApi.ModelsUpdateModel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Model Identifier | 
 **model** | [**ModelConfigurationDTO**](ModelConfigurationDTO.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


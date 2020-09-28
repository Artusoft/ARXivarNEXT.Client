# ARXivarNEXT.Client.Api.BindersApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BindersAddProfilesToBinder**](BindersApi.md#bindersaddprofilestobinder) | **POST** /api/Binders/addprofiles | This call adds specified profiles to a binder container
[**BindersBinderComboValues**](BindersApi.md#bindersbindercombovalues) | **PUT** /api/Binders/combofieldvalues | This call updates the possible values for a combo custom binder field
[**BindersBinderCustomFieldsTranslations**](BindersApi.md#bindersbindercustomfieldstranslations) | **PUT** /api/Binders/customfieldsbytype | This call updates custom field for a binder type
[**BindersBinderCustomFieldsTranslations_0**](BindersApi.md#bindersbindercustomfieldstranslations_0) | **PUT** /api/Binders/customFieldsTranslations/{customFieldId} | This call updates translation custom field for a binder type
[**BindersCanInsertNewBinderType**](BindersApi.md#binderscaninsertnewbindertype) | **GET** /api/Binders/CanInsertNewType | This call returns if the connected user can insert a new binder type
[**BindersDeleteBinderType**](BindersApi.md#bindersdeletebindertype) | **DELETE** /api/Binders/type/{binderTypeId} | This call creates delete a binder type
[**BindersDeleteById**](BindersApi.md#bindersdeletebyid) | **DELETE** /api/Binders/{binderId} | This call deletes a binder by the identifier
[**BindersGetBinderComboValues**](BindersApi.md#bindersgetbindercombovalues) | **GET** /api/Binders/combofieldvalues/{comboFieldId} | This call returns the possible combo value of a binder combo custom field by field id
[**BindersGetBinderCustomFields**](BindersApi.md#bindersgetbindercustomfields) | **GET** /api/Binders/customfieldsbytype/{binderType} | This call returns the custom fields by binder type
[**BindersGetBinderCustomFieldsTranslations**](BindersApi.md#bindersgetbindercustomfieldstranslations) | **GET** /api/Binders/customFieldsTranslations/{customFieldId} | This call returns translation custom field for a binder type
[**BindersGetBinderPermission**](BindersApi.md#bindersgetbinderpermission) | **GET** /api/Binders/binderpermission/{binderId} | This call returns the users permissions for a binder
[**BindersGetBinderStateForVisualization**](BindersApi.md#bindersgetbinderstateforvisualization) | **GET** /api/Binders/visualizationstates | This call returns the possible states for binder visualization
[**BindersGetBinderStates**](BindersApi.md#bindersgetbinderstates) | **GET** /api/Binders/states | This call returns the possible states for a binder
[**BindersGetBinderTypeById**](BindersApi.md#bindersgetbindertypebyid) | **GET** /api/Binders/type/{binderTypeId} | This call returns a binder type by its identifier
[**BindersGetBinderTypePermission**](BindersApi.md#bindersgetbindertypepermission) | **GET** /api/Binders/bindertypepermission/{binderTypeId} | This call returns the permission for a binder type
[**BindersGetBindersFieldsByType**](BindersApi.md#bindersgetbindersfieldsbytype) | **GET** /api/Binders/binderfields/{binderType} | This call returns the binder custom fields by binder type
[**BindersGetById**](BindersApi.md#bindersgetbyid) | **GET** /api/Binders/{id} | This call search a binder by the given identifiers
[**BindersGetByIds**](BindersApi.md#bindersgetbyids) | **POST** /api/Binders/getByIds | This call search a binder by the given identifiers
[**BindersGetByNumero**](BindersApi.md#bindersgetbynumero) | **GET** /api/Binders | This call search a binder by the given number
[**BindersGetByNumeroOld**](BindersApi.md#bindersgetbynumeroold) | **GET** /api/Binders/number/{numero} | This call search a binder by the given number
[**BindersGetByTypeAndState**](BindersApi.md#bindersgetbytypeandstate) | **GET** /api/Binders/{type}/{state} | This call retrieve binders of the given type and state
[**BindersGetTypesOfPratiche**](BindersApi.md#bindersgettypesofpratiche) | **GET** /api/Binders/Type | This call returns the types of binders available
[**BindersGetUserDefaultTypeAndStateSelection**](BindersApi.md#bindersgetuserdefaulttypeandstateselection) | **GET** /api/Binders/defaulttypeandstate | This call returns the default type and state for the user
[**BindersInsertNewBinder**](BindersApi.md#bindersinsertnewbinder) | **POST** /api/Binders | This call adds new binder
[**BindersInsertNewBinderType**](BindersApi.md#bindersinsertnewbindertype) | **POST** /api/Binders/type | This call creates new binder type
[**BindersRemoveProfilesFromBinder**](BindersApi.md#bindersremoveprofilesfrombinder) | **POST** /api/Binders/removeprofiles | This call removes specified profiles from a binder container
[**BindersSetBinderPermission**](BindersApi.md#binderssetbinderpermission) | **POST** /api/Binders/binderpermission/{binderId} | This call updates permission for a binder
[**BindersSetBinderTypePermission**](BindersApi.md#binderssetbindertypepermission) | **POST** /api/Binders/bindertypepermission/{binderTypeId} | This call updates permission for a binder type
[**BindersSetUserDefaultTypeAndStateSelection**](BindersApi.md#binderssetuserdefaulttypeandstateselection) | **POST** /api/Binders/defaulttypeandstate | This call saves the user binder type and state default
[**BindersUpdateBinderById**](BindersApi.md#bindersupdatebinderbyid) | **PUT** /api/Binders/{binderId} | This call updates all binder values, also custom fields, by binder identifier
[**BindersUpdateBinderTypeById**](BindersApi.md#bindersupdatebindertypebyid) | **PUT** /api/Binders/type | This call updates a binder type


<a name="bindersaddprofilestobinder"></a>
# **BindersAddProfilesToBinder**
> void BindersAddProfilesToBinder (BinderProfilesInsertRequest profilesInsertRequest)

This call adds specified profiles to a binder container

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersAddProfilesToBinderExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();
            var profilesInsertRequest = new BinderProfilesInsertRequest(); // BinderProfilesInsertRequest | Request for insert profiles into the binder

            try
            {
                // This call adds specified profiles to a binder container
                apiInstance.BindersAddProfilesToBinder(profilesInsertRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersAddProfilesToBinder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **profilesInsertRequest** | [**BinderProfilesInsertRequest**](BinderProfilesInsertRequest.md)| Request for insert profiles into the binder | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bindersbindercombovalues"></a>
# **BindersBinderComboValues**
> void BindersBinderComboValues (BinderComboValuesUpdateRequest request)

This call updates the possible values for a combo custom binder field

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersBinderComboValuesExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();
            var request = new BinderComboValuesUpdateRequest(); // BinderComboValuesUpdateRequest | The update values request

            try
            {
                // This call updates the possible values for a combo custom binder field
                apiInstance.BindersBinderComboValues(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersBinderComboValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**BinderComboValuesUpdateRequest**](BinderComboValuesUpdateRequest.md)| The update values request | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bindersbindercustomfieldstranslations"></a>
# **BindersBinderCustomFieldsTranslations**
> List<FieldBaseDTO> BindersBinderCustomFieldsTranslations (BinderTypeCustomFieldUpdateRequest request)

This call updates custom field for a binder type

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersBinderCustomFieldsTranslationsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();
            var request = new BinderTypeCustomFieldUpdateRequest(); // BinderTypeCustomFieldUpdateRequest | The update custom fields request

            try
            {
                // This call updates custom field for a binder type
                List&lt;FieldBaseDTO&gt; result = apiInstance.BindersBinderCustomFieldsTranslations(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersBinderCustomFieldsTranslations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**BinderTypeCustomFieldUpdateRequest**](BinderTypeCustomFieldUpdateRequest.md)| The update custom fields request | 

### Return type

[**List<FieldBaseDTO>**](FieldBaseDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bindersbindercustomfieldstranslations_0"></a>
# **BindersBinderCustomFieldsTranslations_0**
> void BindersBinderCustomFieldsTranslations_0 (int? customFieldId, UpdateFieldTranslationRequest request)

This call updates translation custom field for a binder type

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersBinderCustomFieldsTranslations_0Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();
            var customFieldId = 56;  // int? | customFieldId
            var request = new UpdateFieldTranslationRequest(); // UpdateFieldTranslationRequest | The update custom fields request object

            try
            {
                // This call updates translation custom field for a binder type
                apiInstance.BindersBinderCustomFieldsTranslations_0(customFieldId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersBinderCustomFieldsTranslations_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customFieldId** | **int?**| customFieldId | 
 **request** | [**UpdateFieldTranslationRequest**](UpdateFieldTranslationRequest.md)| The update custom fields request object | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="binderscaninsertnewbindertype"></a>
# **BindersCanInsertNewBinderType**
> bool? BindersCanInsertNewBinderType ()

This call returns if the connected user can insert a new binder type

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersCanInsertNewBinderTypeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();

            try
            {
                // This call returns if the connected user can insert a new binder type
                bool? result = apiInstance.BindersCanInsertNewBinderType();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersCanInsertNewBinderType: " + e.Message );
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

<a name="bindersdeletebindertype"></a>
# **BindersDeleteBinderType**
> void BindersDeleteBinderType (int? binderTypeId)

This call creates delete a binder type

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersDeleteBinderTypeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();
            var binderTypeId = 56;  // int? | Identifier of the binder type to delete

            try
            {
                // This call creates delete a binder type
                apiInstance.BindersDeleteBinderType(binderTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersDeleteBinderType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **binderTypeId** | **int?**| Identifier of the binder type to delete | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bindersdeletebyid"></a>
# **BindersDeleteById**
> void BindersDeleteById (int? binderId)

This call deletes a binder by the identifier

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersDeleteByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();
            var binderId = 56;  // int? | Identifier of the binder to delete

            try
            {
                // This call deletes a binder by the identifier
                apiInstance.BindersDeleteById(binderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersDeleteById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **binderId** | **int?**| Identifier of the binder to delete | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bindersgetbindercombovalues"></a>
# **BindersGetBinderComboValues**
> List<string> BindersGetBinderComboValues (int? comboFieldId)

This call returns the possible combo value of a binder combo custom field by field id

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersGetBinderComboValuesExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();
            var comboFieldId = 56;  // int? | The identifier of a binder combo custom field

            try
            {
                // This call returns the possible combo value of a binder combo custom field by field id
                List&lt;string&gt; result = apiInstance.BindersGetBinderComboValues(comboFieldId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersGetBinderComboValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **comboFieldId** | **int?**| The identifier of a binder combo custom field | 

### Return type

**List<string>**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bindersgetbindercustomfields"></a>
# **BindersGetBinderCustomFields**
> List<FieldBaseDTO> BindersGetBinderCustomFields (int? binderType)

This call returns the custom fields by binder type

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersGetBinderCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();
            var binderType = 56;  // int? | Binder type identifier

            try
            {
                // This call returns the custom fields by binder type
                List&lt;FieldBaseDTO&gt; result = apiInstance.BindersGetBinderCustomFields(binderType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersGetBinderCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **binderType** | **int?**| Binder type identifier | 

### Return type

[**List<FieldBaseDTO>**](FieldBaseDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bindersgetbindercustomfieldstranslations"></a>
# **BindersGetBinderCustomFieldsTranslations**
> List<FieldTranslation> BindersGetBinderCustomFieldsTranslations (int? customFieldId)

This call returns translation custom field for a binder type

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersGetBinderCustomFieldsTranslationsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();
            var customFieldId = 56;  // int? | Identifier of the custm field

            try
            {
                // This call returns translation custom field for a binder type
                List&lt;FieldTranslation&gt; result = apiInstance.BindersGetBinderCustomFieldsTranslations(customFieldId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersGetBinderCustomFieldsTranslations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customFieldId** | **int?**| Identifier of the custm field | 

### Return type

[**List<FieldTranslation>**](FieldTranslation.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bindersgetbinderpermission"></a>
# **BindersGetBinderPermission**
> PermissionsDTO BindersGetBinderPermission (int? binderId)

This call returns the users permissions for a binder

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersGetBinderPermissionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();
            var binderId = 56;  // int? | The binder identifier

            try
            {
                // This call returns the users permissions for a binder
                PermissionsDTO result = apiInstance.BindersGetBinderPermission(binderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersGetBinderPermission: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **binderId** | **int?**| The binder identifier | 

### Return type

[**PermissionsDTO**](PermissionsDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bindersgetbinderstateforvisualization"></a>
# **BindersGetBinderStateForVisualization**
> List<BinderStateDto> BindersGetBinderStateForVisualization ()

This call returns the possible states for binder visualization

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersGetBinderStateForVisualizationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();

            try
            {
                // This call returns the possible states for binder visualization
                List&lt;BinderStateDto&gt; result = apiInstance.BindersGetBinderStateForVisualization();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersGetBinderStateForVisualization: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<BinderStateDto>**](BinderStateDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bindersgetbinderstates"></a>
# **BindersGetBinderStates**
> List<BinderStateDto> BindersGetBinderStates ()

This call returns the possible states for a binder

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersGetBinderStatesExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();

            try
            {
                // This call returns the possible states for a binder
                List&lt;BinderStateDto&gt; result = apiInstance.BindersGetBinderStates();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersGetBinderStates: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<BinderStateDto>**](BinderStateDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bindersgetbindertypebyid"></a>
# **BindersGetBinderTypeById**
> BinderTypeDTO BindersGetBinderTypeById (int? binderTypeId)

This call returns a binder type by its identifier

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersGetBinderTypeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();
            var binderTypeId = 56;  // int? | The identifier of the binder type

            try
            {
                // This call returns a binder type by its identifier
                BinderTypeDTO result = apiInstance.BindersGetBinderTypeById(binderTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersGetBinderTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **binderTypeId** | **int?**| The identifier of the binder type | 

### Return type

[**BinderTypeDTO**](BinderTypeDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bindersgetbindertypepermission"></a>
# **BindersGetBinderTypePermission**
> PermissionsDTO BindersGetBinderTypePermission (int? binderTypeId)

This call returns the permission for a binder type

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersGetBinderTypePermissionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();
            var binderTypeId = 56;  // int? | The binder type identifier

            try
            {
                // This call returns the permission for a binder type
                PermissionsDTO result = apiInstance.BindersGetBinderTypePermission(binderTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersGetBinderTypePermission: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **binderTypeId** | **int?**| The binder type identifier | 

### Return type

[**PermissionsDTO**](PermissionsDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bindersgetbindersfieldsbytype"></a>
# **BindersGetBindersFieldsByType**
> List<FieldBaseDTO> BindersGetBindersFieldsByType (int? binderType)

This call returns the binder custom fields by binder type

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersGetBindersFieldsByTypeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();
            var binderType = 56;  // int? | Binder type identifier

            try
            {
                // This call returns the binder custom fields by binder type
                List&lt;FieldBaseDTO&gt; result = apiInstance.BindersGetBindersFieldsByType(binderType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersGetBindersFieldsByType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **binderType** | **int?**| Binder type identifier | 

### Return type

[**List<FieldBaseDTO>**](FieldBaseDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bindersgetbyid"></a>
# **BindersGetById**
> BinderDTO BindersGetById (int? id)

This call search a binder by the given identifiers

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersGetByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();
            var id = 56;  // int? | The identifiers filter

            try
            {
                // This call search a binder by the given identifiers
                BinderDTO result = apiInstance.BindersGetById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersGetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The identifiers filter | 

### Return type

[**BinderDTO**](BinderDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bindersgetbyids"></a>
# **BindersGetByIds**
> List<BinderDTO> BindersGetByIds (List<int?> ids)

This call search a binder by the given identifiers

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersGetByIdsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();
            var ids = ;  // List<int?> | The identifiers filter

            try
            {
                // This call search a binder by the given identifiers
                List&lt;BinderDTO&gt; result = apiInstance.BindersGetByIds(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersGetByIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | **List&lt;int?&gt;**| The identifiers filter | 

### Return type

[**List<BinderDTO>**](BinderDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bindersgetbynumero"></a>
# **BindersGetByNumero**
> List<BinderDTO> BindersGetByNumero (string number)

This call search a binder by the given number

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersGetByNumeroExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();
            var number = number_example;  // string | The number filter

            try
            {
                // This call search a binder by the given number
                List&lt;BinderDTO&gt; result = apiInstance.BindersGetByNumero(number);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersGetByNumero: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **number** | **string**| The number filter | 

### Return type

[**List<BinderDTO>**](BinderDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bindersgetbynumeroold"></a>
# **BindersGetByNumeroOld**
> List<BinderDTO> BindersGetByNumeroOld (string numero)

This call search a binder by the given number

This method is deprecated. Use api/Binders?number={number}

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersGetByNumeroOldExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();
            var numero = numero_example;  // string | The number filter

            try
            {
                // This call search a binder by the given number
                List&lt;BinderDTO&gt; result = apiInstance.BindersGetByNumeroOld(numero);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersGetByNumeroOld: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **numero** | **string**| The number filter | 

### Return type

[**List<BinderDTO>**](BinderDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bindersgetbytypeandstate"></a>
# **BindersGetByTypeAndState**
> List<BinderDTO> BindersGetByTypeAndState (int? type, int? state)

This call retrieve binders of the given type and state

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersGetByTypeAndStateExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();
            var type = 56;  // int? | Binders type filter
            var state = 56;  // int? | Binder state filter

            try
            {
                // This call retrieve binders of the given type and state
                List&lt;BinderDTO&gt; result = apiInstance.BindersGetByTypeAndState(type, state);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersGetByTypeAndState: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **int?**| Binders type filter | 
 **state** | **int?**| Binder state filter | 

### Return type

[**List<BinderDTO>**](BinderDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bindersgettypesofpratiche"></a>
# **BindersGetTypesOfPratiche**
> List<BinderTypeDTO> BindersGetTypesOfPratiche ()

This call returns the types of binders available

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersGetTypesOfPraticheExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();

            try
            {
                // This call returns the types of binders available
                List&lt;BinderTypeDTO&gt; result = apiInstance.BindersGetTypesOfPratiche();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersGetTypesOfPratiche: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<BinderTypeDTO>**](BinderTypeDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bindersgetuserdefaulttypeandstateselection"></a>
# **BindersGetUserDefaultTypeAndStateSelection**
> BinderUserDefaultTypeAndStateDto BindersGetUserDefaultTypeAndStateSelection ()

This call returns the default type and state for the user

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersGetUserDefaultTypeAndStateSelectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();

            try
            {
                // This call returns the default type and state for the user
                BinderUserDefaultTypeAndStateDto result = apiInstance.BindersGetUserDefaultTypeAndStateSelection();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersGetUserDefaultTypeAndStateSelection: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BinderUserDefaultTypeAndStateDto**](BinderUserDefaultTypeAndStateDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bindersinsertnewbinder"></a>
# **BindersInsertNewBinder**
> BinderDTO BindersInsertNewBinder (BinderDTO binder = null)

This call adds new binder

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersInsertNewBinderExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();
            var binder = new BinderDTO(); // BinderDTO |  (optional) 

            try
            {
                // This call adds new binder
                BinderDTO result = apiInstance.BindersInsertNewBinder(binder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersInsertNewBinder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **binder** | [**BinderDTO**](BinderDTO.md)|  | [optional] 

### Return type

[**BinderDTO**](BinderDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bindersinsertnewbindertype"></a>
# **BindersInsertNewBinderType**
> BinderTypeDTO BindersInsertNewBinderType (BinderTypeDTO bindertype = null)

This call creates new binder type

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersInsertNewBinderTypeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();
            var bindertype = new BinderTypeDTO(); // BinderTypeDTO |  (optional) 

            try
            {
                // This call creates new binder type
                BinderTypeDTO result = apiInstance.BindersInsertNewBinderType(bindertype);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersInsertNewBinderType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bindertype** | [**BinderTypeDTO**](BinderTypeDTO.md)|  | [optional] 

### Return type

[**BinderTypeDTO**](BinderTypeDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bindersremoveprofilesfrombinder"></a>
# **BindersRemoveProfilesFromBinder**
> void BindersRemoveProfilesFromBinder (BinderProfilesRemoveRequest profilesRemoveRequest)

This call removes specified profiles from a binder container

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersRemoveProfilesFromBinderExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();
            var profilesRemoveRequest = new BinderProfilesRemoveRequest(); // BinderProfilesRemoveRequest | Request for remove profiles into the binder

            try
            {
                // This call removes specified profiles from a binder container
                apiInstance.BindersRemoveProfilesFromBinder(profilesRemoveRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersRemoveProfilesFromBinder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **profilesRemoveRequest** | [**BinderProfilesRemoveRequest**](BinderProfilesRemoveRequest.md)| Request for remove profiles into the binder | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="binderssetbinderpermission"></a>
# **BindersSetBinderPermission**
> void BindersSetBinderPermission (PermissionsDTO permissionDto, int? binderId)

This call updates permission for a binder

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersSetBinderPermissionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();
            var permissionDto = new PermissionsDTO(); // PermissionsDTO | The permissions data
            var binderId = 56;  // int? | The binder identifier

            try
            {
                // This call updates permission for a binder
                apiInstance.BindersSetBinderPermission(permissionDto, binderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersSetBinderPermission: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **permissionDto** | [**PermissionsDTO**](PermissionsDTO.md)| The permissions data | 
 **binderId** | **int?**| The binder identifier | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="binderssetbindertypepermission"></a>
# **BindersSetBinderTypePermission**
> void BindersSetBinderTypePermission (BinderPermissionsDTO permissionDto, int? binderTypeId)

This call updates permission for a binder type

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersSetBinderTypePermissionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();
            var permissionDto = new BinderPermissionsDTO(); // BinderPermissionsDTO | The permissions data
            var binderTypeId = 56;  // int? | The binder type identifier

            try
            {
                // This call updates permission for a binder type
                apiInstance.BindersSetBinderTypePermission(permissionDto, binderTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersSetBinderTypePermission: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **permissionDto** | [**BinderPermissionsDTO**](BinderPermissionsDTO.md)| The permissions data | 
 **binderTypeId** | **int?**| The binder type identifier | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="binderssetuserdefaulttypeandstateselection"></a>
# **BindersSetUserDefaultTypeAndStateSelection**
> void BindersSetUserDefaultTypeAndStateSelection (BinderUserDefaultTypeAndStateDto defaultoption)

This call saves the user binder type and state default

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersSetUserDefaultTypeAndStateSelectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();
            var defaultoption = new BinderUserDefaultTypeAndStateDto(); // BinderUserDefaultTypeAndStateDto | The new default for the user

            try
            {
                // This call saves the user binder type and state default
                apiInstance.BindersSetUserDefaultTypeAndStateSelection(defaultoption);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersSetUserDefaultTypeAndStateSelection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **defaultoption** | [**BinderUserDefaultTypeAndStateDto**](BinderUserDefaultTypeAndStateDto.md)| The new default for the user | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bindersupdatebinderbyid"></a>
# **BindersUpdateBinderById**
> BinderDTO BindersUpdateBinderById (int? binderId, BinderDTO binder = null)

This call updates all binder values, also custom fields, by binder identifier

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersUpdateBinderByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();
            var binderId = 56;  // int? | The identifier of the binder
            var binder = new BinderDTO(); // BinderDTO |  (optional) 

            try
            {
                // This call updates all binder values, also custom fields, by binder identifier
                BinderDTO result = apiInstance.BindersUpdateBinderById(binderId, binder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersUpdateBinderById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **binderId** | **int?**| The identifier of the binder | 
 **binder** | [**BinderDTO**](BinderDTO.md)|  | [optional] 

### Return type

[**BinderDTO**](BinderDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bindersupdatebindertypebyid"></a>
# **BindersUpdateBinderTypeById**
> BinderTypeDTO BindersUpdateBinderTypeById (BinderTypeDTO bindertype = null)

This call updates a binder type

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BindersUpdateBinderTypeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BindersApi();
            var bindertype = new BinderTypeDTO(); // BinderTypeDTO |  (optional) 

            try
            {
                // This call updates a binder type
                BinderTypeDTO result = apiInstance.BindersUpdateBinderTypeById(bindertype);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BindersApi.BindersUpdateBinderTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bindertype** | [**BinderTypeDTO**](BinderTypeDTO.md)|  | [optional] 

### Return type

[**BinderTypeDTO**](BinderTypeDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


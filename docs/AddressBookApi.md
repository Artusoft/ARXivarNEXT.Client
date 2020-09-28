# ARXivarNEXT.Client.Api.AddressBookApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddressBookAddressBookCanWriteByAddressBookId**](AddressBookApi.md#addressbookaddressbookcanwritebyaddressbookid) | **GET** /api/AddressBook/canwrite/{addressbookId} | This call returns true if the connected user can edit an address book
[**AddressBookAddressBookCanWriteByCategoryId**](AddressBookApi.md#addressbookaddressbookcanwritebycategoryid) | **GET** /api/AddressBook/canwritebycategory/{addressbookCategoryId} | This call returns true if the connected user can edit address books of a specified category
[**AddressBookDeleteAddressBook**](AddressBookApi.md#addressbookdeleteaddressbook) | **DELETE** /api/AddressBook/addressbook/{addressBookId} | This call deletes an addressbook by its Id
[**AddressBookDeleteAddressBook_0**](AddressBookApi.md#addressbookdeleteaddressbook_0) | **POST** /api/AddressBook/delete/addressbooks | This call deletes addressbooks by their ids
[**AddressBookDeleteContact**](AddressBookApi.md#addressbookdeletecontact) | **DELETE** /api/AddressBook/contact/{contactId} | This call deletes a contact
[**AddressBookDeleteContact_0**](AddressBookApi.md#addressbookdeletecontact_0) | **POST** /api/AddressBook/delete/contacts | This call deletes contacts by their ids
[**AddressBookGetAddressBookComboFieldValues**](AddressBookApi.md#addressbookgetaddressbookcombofieldvalues) | **GET** /api/AddressBook/addressbook/combovalues | This call returns the values for combo box address book additional field
[**AddressBookGetByAddressBookId**](AddressBookApi.md#addressbookgetbyaddressbookid) | **GET** /api/AddressBook/AddressBook/{addressBookId}/UserProfile/{type} | This call returns new profile data (for archiving purpose) by address book identifier
[**AddressBookGetByContactId**](AddressBookApi.md#addressbookgetbycontactid) | **GET** /api/AddressBook/Contact/{contactId}/UserProfile/{type} | This call returns new profile data (for archiving purpose) by contact identifier
[**AddressBookGetById**](AddressBookApi.md#addressbookgetbyid) | **GET** /api/AddressBook/addressbook/{addressBookId} | This call returns an adressbook by the identifier
[**AddressBookGetByUserId**](AddressBookApi.md#addressbookgetbyuserid) | **GET** /api/AddressBook/User/{userId}/UserProfile/{type} | This call returns new profile data (for archiving purpose) by user identifier
[**AddressBookGetForInsert**](AddressBookApi.md#addressbookgetforinsert) | **GET** /api/AddressBook/newinstance | This call returns new AddreBookDTO object for insert purpose
[**AddressBookGetForInsert_0**](AddressBookApi.md#addressbookgetforinsert_0) | **GET** /api/AddressBook/newinstance/{addressbookCategoryId} | This call returns new AddreBookDTO for insert purpose by category
[**AddressBookGetPermissionByAddrebookId**](AddressBookApi.md#addressbookgetpermissionbyaddrebookid) | **GET** /api/AddressBook/{addressBookId}/Permission | This call returns all permissions for an AddreBook
[**AddressBookGetSearchField**](AddressBookApi.md#addressbookgetsearchfield) | **GET** /api/AddressBook/SearchField | This call returns all the possible fields for search in address book
[**AddressBookGetSelectField**](AddressBookApi.md#addressbookgetselectfield) | **GET** /api/AddressBook/SelectField | This call returns all the possible select fields for search in address book
[**AddressBookInsertAddressBook**](AddressBookApi.md#addressbookinsertaddressbook) | **POST** /api/AddressBook/addressbook | This call inserts new addres book item
[**AddressBookInsertAddressBook_0**](AddressBookApi.md#addressbookinsertaddressbook_0) | **POST** /api/AddressBook/addressbooks | This call inserts new address book items
[**AddressBookInsertContact**](AddressBookApi.md#addressbookinsertcontact) | **POST** /api/AddressBook/contact | This call inserts new contact of a address book item
[**AddressBookPostSearch**](AddressBookApi.md#addressbookpostsearch) | **POST** /api/AddressBook | This call searches address book items
[**AddressBookPutSelectField**](AddressBookApi.md#addressbookputselectfield) | **PUT** /api/AddressBook/SelectField | This call saves the select fields with the user settings
[**AddressBookSetPermissionByAddrebookId**](AddressBookApi.md#addressbooksetpermissionbyaddrebookid) | **PUT** /api/AddressBook/{addressBookId}/Permission | This call saves all permissions for an AddreBook
[**AddressBookUpdateAddressBook**](AddressBookApi.md#addressbookupdateaddressbook) | **PUT** /api/AddressBook/addressbook/{addressbookId} | This call updates a addresbook item
[**AddressBookUpdateContact**](AddressBookApi.md#addressbookupdatecontact) | **PUT** /api/AddressBook/contact | This call updates a contact


<a name="addressbookaddressbookcanwritebyaddressbookid"></a>
# **AddressBookAddressBookCanWriteByAddressBookId**
> bool? AddressBookAddressBookCanWriteByAddressBookId (int? addressbookId)

This call returns true if the connected user can edit an address book

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookAddressBookCanWriteByAddressBookIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookApi();
            var addressbookId = 56;  // int? | Identifier of the address book

            try
            {
                // This call returns true if the connected user can edit an address book
                bool? result = apiInstance.AddressBookAddressBookCanWriteByAddressBookId(addressbookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookApi.AddressBookAddressBookCanWriteByAddressBookId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addressbookId** | **int?**| Identifier of the address book | 

### Return type

**bool?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbookaddressbookcanwritebycategoryid"></a>
# **AddressBookAddressBookCanWriteByCategoryId**
> bool? AddressBookAddressBookCanWriteByCategoryId (int? addressbookCategoryId)

This call returns true if the connected user can edit address books of a specified category

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookAddressBookCanWriteByCategoryIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookApi();
            var addressbookCategoryId = 56;  // int? | Identifier of address book category

            try
            {
                // This call returns true if the connected user can edit address books of a specified category
                bool? result = apiInstance.AddressBookAddressBookCanWriteByCategoryId(addressbookCategoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookApi.AddressBookAddressBookCanWriteByCategoryId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addressbookCategoryId** | **int?**| Identifier of address book category | 

### Return type

**bool?**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbookdeleteaddressbook"></a>
# **AddressBookDeleteAddressBook**
> void AddressBookDeleteAddressBook (int? addressBookId)

This call deletes an addressbook by its Id

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookDeleteAddressBookExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookApi();
            var addressBookId = 56;  // int? | AddressBook Id

            try
            {
                // This call deletes an addressbook by its Id
                apiInstance.AddressBookDeleteAddressBook(addressBookId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookApi.AddressBookDeleteAddressBook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addressBookId** | **int?**| AddressBook Id | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbookdeleteaddressbook_0"></a>
# **AddressBookDeleteAddressBook_0**
> void AddressBookDeleteAddressBook_0 (List<int?> addressBookIdList)

This call deletes addressbooks by their ids

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookDeleteAddressBook_0Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookApi();
            var addressBookIdList = ;  // List<int?> | The id list

            try
            {
                // This call deletes addressbooks by their ids
                apiInstance.AddressBookDeleteAddressBook_0(addressBookIdList);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookApi.AddressBookDeleteAddressBook_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addressBookIdList** | **List&lt;int?&gt;**| The id list | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbookdeletecontact"></a>
# **AddressBookDeleteContact**
> void AddressBookDeleteContact (int? contactId)

This call deletes a contact

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookDeleteContactExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookApi();
            var contactId = 56;  // int? | Identifier of contact to delete

            try
            {
                // This call deletes a contact
                apiInstance.AddressBookDeleteContact(contactId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookApi.AddressBookDeleteContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactId** | **int?**| Identifier of contact to delete | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbookdeletecontact_0"></a>
# **AddressBookDeleteContact_0**
> void AddressBookDeleteContact_0 (List<int?> contactIdList)

This call deletes contacts by their ids

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookDeleteContact_0Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookApi();
            var contactIdList = ;  // List<int?> | The id list

            try
            {
                // This call deletes contacts by their ids
                apiInstance.AddressBookDeleteContact_0(contactIdList);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookApi.AddressBookDeleteContact_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactIdList** | **List&lt;int?&gt;**| The id list | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbookgetaddressbookcombofieldvalues"></a>
# **AddressBookGetAddressBookComboFieldValues**
> List<string> AddressBookGetAddressBookComboFieldValues (string fieldName)

This call returns the values for combo box address book additional field

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookGetAddressBookComboFieldValuesExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookApi();
            var fieldName = fieldName_example;  // string | The field name of the combo

            try
            {
                // This call returns the values for combo box address book additional field
                List&lt;string&gt; result = apiInstance.AddressBookGetAddressBookComboFieldValues(fieldName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookApi.AddressBookGetAddressBookComboFieldValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fieldName** | **string**| The field name of the combo | 

### Return type

**List<string>**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbookgetbyaddressbookid"></a>
# **AddressBookGetByAddressBookId**
> UserProfileDTO AddressBookGetByAddressBookId (int? addressBookId, int? type)

This call returns new profile data (for archiving purpose) by address book identifier

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookGetByAddressBookIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookApi();
            var addressBookId = 56;  // int? | Identifier of the adress book
            var type = 56;  // int? | Possible values:  0: To  1: From  2: Cc  3: Senders 

            try
            {
                // This call returns new profile data (for archiving purpose) by address book identifier
                UserProfileDTO result = apiInstance.AddressBookGetByAddressBookId(addressBookId, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookApi.AddressBookGetByAddressBookId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addressBookId** | **int?**| Identifier of the adress book | 
 **type** | **int?**| Possible values:  0: To  1: From  2: Cc  3: Senders  | 

### Return type

[**UserProfileDTO**](UserProfileDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbookgetbycontactid"></a>
# **AddressBookGetByContactId**
> UserProfileDTO AddressBookGetByContactId (int? contactId, int? type)

This call returns new profile data (for archiving purpose) by contact identifier

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookGetByContactIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookApi();
            var contactId = 56;  // int? | Identifier of the contact
            var type = 56;  // int? | Possible values:  0: To  1: From  2: Cc  3: Senders 

            try
            {
                // This call returns new profile data (for archiving purpose) by contact identifier
                UserProfileDTO result = apiInstance.AddressBookGetByContactId(contactId, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookApi.AddressBookGetByContactId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactId** | **int?**| Identifier of the contact | 
 **type** | **int?**| Possible values:  0: To  1: From  2: Cc  3: Senders  | 

### Return type

[**UserProfileDTO**](UserProfileDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbookgetbyid"></a>
# **AddressBookGetById**
> AddressBookDTO AddressBookGetById (int? addressBookId)

This call returns an adressbook by the identifier

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookGetByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookApi();
            var addressBookId = 56;  // int? | Identifier of the adress book

            try
            {
                // This call returns an adressbook by the identifier
                AddressBookDTO result = apiInstance.AddressBookGetById(addressBookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookApi.AddressBookGetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addressBookId** | **int?**| Identifier of the adress book | 

### Return type

[**AddressBookDTO**](AddressBookDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbookgetbyuserid"></a>
# **AddressBookGetByUserId**
> UserProfileDTO AddressBookGetByUserId (int? userId, int? type)

This call returns new profile data (for archiving purpose) by user identifier

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookGetByUserIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookApi();
            var userId = 56;  // int? | Identifier of the user
            var type = 56;  // int? | Possible values:  0: To  1: From  2: Cc  3: Senders 

            try
            {
                // This call returns new profile data (for archiving purpose) by user identifier
                UserProfileDTO result = apiInstance.AddressBookGetByUserId(userId, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookApi.AddressBookGetByUserId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| Identifier of the user | 
 **type** | **int?**| Possible values:  0: To  1: From  2: Cc  3: Senders  | 

### Return type

[**UserProfileDTO**](UserProfileDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbookgetforinsert"></a>
# **AddressBookGetForInsert**
> AddressBookDTO AddressBookGetForInsert ()

This call returns new AddreBookDTO object for insert purpose

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookGetForInsertExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookApi();

            try
            {
                // This call returns new AddreBookDTO object for insert purpose
                AddressBookDTO result = apiInstance.AddressBookGetForInsert();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookApi.AddressBookGetForInsert: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AddressBookDTO**](AddressBookDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbookgetforinsert_0"></a>
# **AddressBookGetForInsert_0**
> AddressBookDTO AddressBookGetForInsert_0 (int? addressbookCategoryId)

This call returns new AddreBookDTO for insert purpose by category

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookGetForInsert_0Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookApi();
            var addressbookCategoryId = 56;  // int? | Identifier of the address book category

            try
            {
                // This call returns new AddreBookDTO for insert purpose by category
                AddressBookDTO result = apiInstance.AddressBookGetForInsert_0(addressbookCategoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookApi.AddressBookGetForInsert_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addressbookCategoryId** | **int?**| Identifier of the address book category | 

### Return type

[**AddressBookDTO**](AddressBookDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbookgetpermissionbyaddrebookid"></a>
# **AddressBookGetPermissionByAddrebookId**
> PermissionsDTO AddressBookGetPermissionByAddrebookId (int? addressBookId)

This call returns all permissions for an AddreBook

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookGetPermissionByAddrebookIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookApi();
            var addressBookId = 56;  // int? | Id of the addressBook

            try
            {
                // This call returns all permissions for an AddreBook
                PermissionsDTO result = apiInstance.AddressBookGetPermissionByAddrebookId(addressBookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookApi.AddressBookGetPermissionByAddrebookId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addressBookId** | **int?**| Id of the addressBook | 

### Return type

[**PermissionsDTO**](PermissionsDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbookgetsearchfield"></a>
# **AddressBookGetSearchField**
> List<RubricaFieldDTO> AddressBookGetSearchField ()

This call returns all the possible fields for search in address book

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookGetSearchFieldExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookApi();

            try
            {
                // This call returns all the possible fields for search in address book
                List&lt;RubricaFieldDTO&gt; result = apiInstance.AddressBookGetSearchField();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookApi.AddressBookGetSearchField: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<RubricaFieldDTO>**](RubricaFieldDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbookgetselectfield"></a>
# **AddressBookGetSelectField**
> List<RubricaFieldDTO> AddressBookGetSelectField ()

This call returns all the possible select fields for search in address book

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookGetSelectFieldExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookApi();

            try
            {
                // This call returns all the possible select fields for search in address book
                List&lt;RubricaFieldDTO&gt; result = apiInstance.AddressBookGetSelectField();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookApi.AddressBookGetSelectField: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<RubricaFieldDTO>**](RubricaFieldDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbookinsertaddressbook"></a>
# **AddressBookInsertAddressBook**
> AddressBookDTO AddressBookInsertAddressBook (AddressBookDTO addressBookDto)

This call inserts new addres book item

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookInsertAddressBookExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookApi();
            var addressBookDto = new AddressBookDTO(); // AddressBookDTO | Address book item to profile

            try
            {
                // This call inserts new addres book item
                AddressBookDTO result = apiInstance.AddressBookInsertAddressBook(addressBookDto);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookApi.AddressBookInsertAddressBook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addressBookDto** | [**AddressBookDTO**](AddressBookDTO.md)| Address book item to profile | 

### Return type

[**AddressBookDTO**](AddressBookDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbookinsertaddressbook_0"></a>
# **AddressBookInsertAddressBook_0**
> List<AddressBookDTO> AddressBookInsertAddressBook_0 (List<AddressBookDTO> addressBookDtos)

This call inserts new address book items

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookInsertAddressBook_0Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookApi();
            var addressBookDtos = new List<AddressBookDTO>(); // List<AddressBookDTO> | Address book items to profile

            try
            {
                // This call inserts new address book items
                List&lt;AddressBookDTO&gt; result = apiInstance.AddressBookInsertAddressBook_0(addressBookDtos);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookApi.AddressBookInsertAddressBook_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addressBookDtos** | [**List&lt;AddressBookDTO&gt;**](AddressBookDTO.md)| Address book items to profile | 

### Return type

[**List<AddressBookDTO>**](AddressBookDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbookinsertcontact"></a>
# **AddressBookInsertContact**
> ContactDTO AddressBookInsertContact (ContactDTO contactDto)

This call inserts new contact of a address book item

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookInsertContactExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookApi();
            var contactDto = new ContactDTO(); // ContactDTO | Contact item to insert

            try
            {
                // This call inserts new contact of a address book item
                ContactDTO result = apiInstance.AddressBookInsertContact(contactDto);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookApi.AddressBookInsertContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactDto** | [**ContactDTO**](ContactDTO.md)| Contact item to insert | 

### Return type

[**ContactDTO**](ContactDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbookpostsearch"></a>
# **AddressBookPostSearch**
> AddressBookSearchResultDTO AddressBookPostSearch (AddressBookSearchCriteriaDTO searchDto)

This call searches address book items

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookPostSearchExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookApi();
            var searchDto = new AddressBookSearchCriteriaDTO(); // AddressBookSearchCriteriaDTO | The fields of the search

            try
            {
                // This call searches address book items
                AddressBookSearchResultDTO result = apiInstance.AddressBookPostSearch(searchDto);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookApi.AddressBookPostSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchDto** | [**AddressBookSearchCriteriaDTO**](AddressBookSearchCriteriaDTO.md)| The fields of the search | 

### Return type

[**AddressBookSearchResultDTO**](AddressBookSearchResultDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbookputselectfield"></a>
# **AddressBookPutSelectField**
> void AddressBookPutSelectField (List<RubricaFieldDTO> selectFields)

This call saves the select fields with the user settings

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookPutSelectFieldExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookApi();
            var selectFields = new List<RubricaFieldDTO>(); // List<RubricaFieldDTO> | Array of select fields

            try
            {
                // This call saves the select fields with the user settings
                apiInstance.AddressBookPutSelectField(selectFields);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookApi.AddressBookPutSelectField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **selectFields** | [**List&lt;RubricaFieldDTO&gt;**](RubricaFieldDTO.md)| Array of select fields | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbooksetpermissionbyaddrebookid"></a>
# **AddressBookSetPermissionByAddrebookId**
> void AddressBookSetPermissionByAddrebookId (int? addressBookId, PermissionsDTO permissions)

This call saves all permissions for an AddreBook

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookSetPermissionByAddrebookIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookApi();
            var addressBookId = 56;  // int? | Id of the addressBook
            var permissions = new PermissionsDTO(); // PermissionsDTO | 

            try
            {
                // This call saves all permissions for an AddreBook
                apiInstance.AddressBookSetPermissionByAddrebookId(addressBookId, permissions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookApi.AddressBookSetPermissionByAddrebookId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addressBookId** | **int?**| Id of the addressBook | 
 **permissions** | [**PermissionsDTO**](PermissionsDTO.md)|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbookupdateaddressbook"></a>
# **AddressBookUpdateAddressBook**
> AddressBookDTO AddressBookUpdateAddressBook (int? addressbookId, AddressBookDTO addressBookDto)

This call updates a addresbook item

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookUpdateAddressBookExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookApi();
            var addressbookId = 56;  // int? | Identifier of Address book to update
            var addressBookDto = new AddressBookDTO(); // AddressBookDTO | Address book data to update

            try
            {
                // This call updates a addresbook item
                AddressBookDTO result = apiInstance.AddressBookUpdateAddressBook(addressbookId, addressBookDto);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookApi.AddressBookUpdateAddressBook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addressbookId** | **int?**| Identifier of Address book to update | 
 **addressBookDto** | [**AddressBookDTO**](AddressBookDTO.md)| Address book data to update | 

### Return type

[**AddressBookDTO**](AddressBookDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbookupdatecontact"></a>
# **AddressBookUpdateContact**
> ContactDTO AddressBookUpdateContact (ContactDTO contact)

This call updates a contact

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookUpdateContactExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookApi();
            var contact = new ContactDTO(); // ContactDTO | Identifier of contact to update

            try
            {
                // This call updates a contact
                ContactDTO result = apiInstance.AddressBookUpdateContact(contact);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookApi.AddressBookUpdateContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contact** | [**ContactDTO**](ContactDTO.md)| Identifier of contact to update | 

### Return type

[**ContactDTO**](ContactDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


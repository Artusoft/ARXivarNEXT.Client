# ARXivarNEXT.Client.Api.AddressBookNoteApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddressBookNoteDeleteAddressBookNote**](AddressBookNoteApi.md#addressbooknotedeleteaddressbooknote) | **DELETE** /api/AddressBookNote/{addressBookNoteId} | This call deletes an addressbook note
[**AddressBookNoteGetByAddressBookId**](AddressBookNoteApi.md#addressbooknotegetbyaddressbookid) | **GET** /api/AddressBookNote/ByAddressBookId/{addressBookId} | This call returns all the notes created in an addressbook item
[**AddressBookNoteInsertAddressBookNote**](AddressBookNoteApi.md#addressbooknoteinsertaddressbooknote) | **POST** /api/AddressBookNote | This call creates a note for an addressBook
[**AddressBookNoteUpdateAddressBookNote**](AddressBookNoteApi.md#addressbooknoteupdateaddressbooknote) | **PUT** /api/AddressBookNote | This call updates an addressbook note


<a name="addressbooknotedeleteaddressbooknote"></a>
# **AddressBookNoteDeleteAddressBookNote**
> void AddressBookNoteDeleteAddressBookNote (int? addressBookNoteId)

This call deletes an addressbook note

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookNoteDeleteAddressBookNoteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookNoteApi();
            var addressBookNoteId = 56;  // int? | 

            try
            {
                // This call deletes an addressbook note
                apiInstance.AddressBookNoteDeleteAddressBookNote(addressBookNoteId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookNoteApi.AddressBookNoteDeleteAddressBookNote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addressBookNoteId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbooknotegetbyaddressbookid"></a>
# **AddressBookNoteGetByAddressBookId**
> List<AddressBookNoteDTO> AddressBookNoteGetByAddressBookId (int? addressBookId)

This call returns all the notes created in an addressbook item

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookNoteGetByAddressBookIdExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookNoteApi();
            var addressBookId = 56;  // int? | System Id of the addressbook

            try
            {
                // This call returns all the notes created in an addressbook item
                List&lt;AddressBookNoteDTO&gt; result = apiInstance.AddressBookNoteGetByAddressBookId(addressBookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookNoteApi.AddressBookNoteGetByAddressBookId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addressBookId** | **int?**| System Id of the addressbook | 

### Return type

[**List<AddressBookNoteDTO>**](AddressBookNoteDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbooknoteinsertaddressbooknote"></a>
# **AddressBookNoteInsertAddressBookNote**
> void AddressBookNoteInsertAddressBookNote (AddressBookNoteDTO addressBookNote)

This call creates a note for an addressBook

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookNoteInsertAddressBookNoteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookNoteApi();
            var addressBookNote = new AddressBookNoteDTO(); // AddressBookNoteDTO | 

            try
            {
                // This call creates a note for an addressBook
                apiInstance.AddressBookNoteInsertAddressBookNote(addressBookNote);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookNoteApi.AddressBookNoteInsertAddressBookNote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addressBookNote** | [**AddressBookNoteDTO**](AddressBookNoteDTO.md)|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressbooknoteupdateaddressbooknote"></a>
# **AddressBookNoteUpdateAddressBookNote**
> void AddressBookNoteUpdateAddressBookNote (AddressBookNoteDTO addressBookNote)

This call updates an addressbook note

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class AddressBookNoteUpdateAddressBookNoteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressBookNoteApi();
            var addressBookNote = new AddressBookNoteDTO(); // AddressBookNoteDTO | 

            try
            {
                // This call updates an addressbook note
                apiInstance.AddressBookNoteUpdateAddressBookNote(addressBookNote);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressBookNoteApi.AddressBookNoteUpdateAddressBookNote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addressBookNote** | [**AddressBookNoteDTO**](AddressBookNoteDTO.md)|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


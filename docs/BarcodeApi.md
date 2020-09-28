# ARXivarNEXT.Client.Api.BarcodeApi

All URIs are relative to *https://arxivar.pragmos.it/ARXivarNextWebApi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BarcodeGetBarcodeGraphicUserTemplate**](BarcodeApi.md#barcodegetbarcodegraphicusertemplate) | **GET** /api/Barcode/userGraphicTemplate/documentType/{dmTipidocumentoId} | This call returns the barcode grapich user template
[**BarcodeGetBarcodeUserSettings**](BarcodeApi.md#barcodegetbarcodeusersettings) | **GET** /api/Barcode/userSettings | This call returns the barcode user default settings
[**BarcodeGetBarcodeUserTemplate**](BarcodeApi.md#barcodegetbarcodeusertemplate) | **GET** /api/Barcode/userTemplate/documentType/{dmTipidocumentoId} | This call returns the barcode user template by document type
[**BarcodeGetDefaultTemplate**](BarcodeApi.md#barcodegetdefaulttemplate) | **GET** /api/Barcode/defaultTemplate/printerFamily/{printerFamilyValue} | This call returns the barcode default template by a printer family   - ZEBRA_EPL2,   - ZEBRA_ZPL2,   - TOSHIBA_BSV4,   - EPSON_ESC_POS
[**BarcodePrintArxBarcode**](BarcodeApi.md#barcodeprintarxbarcode) | **POST** /api/Barcode/printArxBarcode | This call executes the print of barcode in format Arxivar
[**BarcodePrintAttachmentByDocnumber**](BarcodeApi.md#barcodeprintattachmentbydocnumber) | **POST** /api/Barcode/printAttachment/byDocnumber/{docnumber} | This call executes the print of barcode for attachment of document
[**BarcodePrintByDocnumber**](BarcodeApi.md#barcodeprintbydocnumber) | **POST** /api/Barcode/print/byDocnumber/{docnumber} | This call executes the print of barcode associated with a document
[**BarcodePrintByIdBarcode**](BarcodeApi.md#barcodeprintbyidbarcode) | **POST** /api/Barcode/print/{idBarcode} | This call executes the print of barcode
[**BarcodePrintRevisionByDocnumber**](BarcodeApi.md#barcodeprintrevisionbydocnumber) | **POST** /api/Barcode/printRevision/byDocnumber/{docnumber} | This call executes the print of barcode for revision of document
[**BarcodeSetBarcodeGraphicUserTemplate**](BarcodeApi.md#barcodesetbarcodegraphicusertemplate) | **POST** /api/Barcode/setUserGraphicTemplate | This call sets the barcode graphic user template
[**BarcodeSetBarcodeUserSettings**](BarcodeApi.md#barcodesetbarcodeusersettings) | **POST** /api/Barcode/setUserSettings | This call sets the barcode user default settings
[**BarcodeSetBarcodeUserTemplate**](BarcodeApi.md#barcodesetbarcodeusertemplate) | **POST** /api/Barcode/setUserTemplate | This call sets the barcode user template


<a name="barcodegetbarcodegraphicusertemplate"></a>
# **BarcodeGetBarcodeGraphicUserTemplate**
> BarcodeGraphicTemplateDto BarcodeGetBarcodeGraphicUserTemplate (int? dmTipidocumentoId)

This call returns the barcode grapich user template

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BarcodeGetBarcodeGraphicUserTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BarcodeApi();
            var dmTipidocumentoId = 56;  // int? | Document type identifier

            try
            {
                // This call returns the barcode grapich user template
                BarcodeGraphicTemplateDto result = apiInstance.BarcodeGetBarcodeGraphicUserTemplate(dmTipidocumentoId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BarcodeApi.BarcodeGetBarcodeGraphicUserTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dmTipidocumentoId** | **int?**| Document type identifier | 

### Return type

[**BarcodeGraphicTemplateDto**](BarcodeGraphicTemplateDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="barcodegetbarcodeusersettings"></a>
# **BarcodeGetBarcodeUserSettings**
> BarcodeUserSettingsDto BarcodeGetBarcodeUserSettings ()

This call returns the barcode user default settings

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BarcodeGetBarcodeUserSettingsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BarcodeApi();

            try
            {
                // This call returns the barcode user default settings
                BarcodeUserSettingsDto result = apiInstance.BarcodeGetBarcodeUserSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BarcodeApi.BarcodeGetBarcodeUserSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BarcodeUserSettingsDto**](BarcodeUserSettingsDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="barcodegetbarcodeusertemplate"></a>
# **BarcodeGetBarcodeUserTemplate**
> BarcodeTemplateDto BarcodeGetBarcodeUserTemplate (int? dmTipidocumentoId)

This call returns the barcode user template by document type

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BarcodeGetBarcodeUserTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BarcodeApi();
            var dmTipidocumentoId = 56;  // int? | Document type identifier

            try
            {
                // This call returns the barcode user template by document type
                BarcodeTemplateDto result = apiInstance.BarcodeGetBarcodeUserTemplate(dmTipidocumentoId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BarcodeApi.BarcodeGetBarcodeUserTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dmTipidocumentoId** | **int?**| Document type identifier | 

### Return type

[**BarcodeTemplateDto**](BarcodeTemplateDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="barcodegetdefaulttemplate"></a>
# **BarcodeGetDefaultTemplate**
> DefaultBarcodeTemplateDto BarcodeGetDefaultTemplate (string printerFamilyValue)

This call returns the barcode default template by a printer family   - ZEBRA_EPL2,   - ZEBRA_ZPL2,   - TOSHIBA_BSV4,   - EPSON_ESC_POS

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BarcodeGetDefaultTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BarcodeApi();
            var printerFamilyValue = printerFamilyValue_example;  // string | The printer family (see Dm_Barcode_PrinterFamily)

            try
            {
                // This call returns the barcode default template by a printer family   - ZEBRA_EPL2,   - ZEBRA_ZPL2,   - TOSHIBA_BSV4,   - EPSON_ESC_POS
                DefaultBarcodeTemplateDto result = apiInstance.BarcodeGetDefaultTemplate(printerFamilyValue);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BarcodeApi.BarcodeGetDefaultTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **printerFamilyValue** | **string**| The printer family (see Dm_Barcode_PrinterFamily) | 

### Return type

[**DefaultBarcodeTemplateDto**](DefaultBarcodeTemplateDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="barcodeprintarxbarcode"></a>
# **BarcodePrintArxBarcode**
> BarcodePrintResultDto BarcodePrintArxBarcode (int? docnumber)

This call executes the print of barcode in format Arxivar

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BarcodePrintArxBarcodeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BarcodeApi();
            var docnumber = 56;  // int? | Document identifier

            try
            {
                // This call executes the print of barcode in format Arxivar
                BarcodePrintResultDto result = apiInstance.BarcodePrintArxBarcode(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BarcodeApi.BarcodePrintArxBarcode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| Document identifier | 

### Return type

[**BarcodePrintResultDto**](BarcodePrintResultDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="barcodeprintattachmentbydocnumber"></a>
# **BarcodePrintAttachmentByDocnumber**
> BarcodePrintResultDto BarcodePrintAttachmentByDocnumber (int? docnumber)

This call executes the print of barcode for attachment of document

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BarcodePrintAttachmentByDocnumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BarcodeApi();
            var docnumber = 56;  // int? | Document identifier

            try
            {
                // This call executes the print of barcode for attachment of document
                BarcodePrintResultDto result = apiInstance.BarcodePrintAttachmentByDocnumber(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BarcodeApi.BarcodePrintAttachmentByDocnumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| Document identifier | 

### Return type

[**BarcodePrintResultDto**](BarcodePrintResultDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="barcodeprintbydocnumber"></a>
# **BarcodePrintByDocnumber**
> BarcodePrintResultDto BarcodePrintByDocnumber (int? docnumber)

This call executes the print of barcode associated with a document

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BarcodePrintByDocnumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BarcodeApi();
            var docnumber = 56;  // int? | Document identifier

            try
            {
                // This call executes the print of barcode associated with a document
                BarcodePrintResultDto result = apiInstance.BarcodePrintByDocnumber(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BarcodeApi.BarcodePrintByDocnumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| Document identifier | 

### Return type

[**BarcodePrintResultDto**](BarcodePrintResultDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="barcodeprintbyidbarcode"></a>
# **BarcodePrintByIdBarcode**
> BarcodePrintResultDto BarcodePrintByIdBarcode (int? idBarcode)

This call executes the print of barcode

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BarcodePrintByIdBarcodeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BarcodeApi();
            var idBarcode = 56;  // int? | Barcode identifier

            try
            {
                // This call executes the print of barcode
                BarcodePrintResultDto result = apiInstance.BarcodePrintByIdBarcode(idBarcode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BarcodeApi.BarcodePrintByIdBarcode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idBarcode** | **int?**| Barcode identifier | 

### Return type

[**BarcodePrintResultDto**](BarcodePrintResultDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="barcodeprintrevisionbydocnumber"></a>
# **BarcodePrintRevisionByDocnumber**
> BarcodePrintResultDto BarcodePrintRevisionByDocnumber (int? docnumber)

This call executes the print of barcode for revision of document

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BarcodePrintRevisionByDocnumberExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BarcodeApi();
            var docnumber = 56;  // int? | Document identifier

            try
            {
                // This call executes the print of barcode for revision of document
                BarcodePrintResultDto result = apiInstance.BarcodePrintRevisionByDocnumber(docnumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BarcodeApi.BarcodePrintRevisionByDocnumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docnumber** | **int?**| Document identifier | 

### Return type

[**BarcodePrintResultDto**](BarcodePrintResultDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="barcodesetbarcodegraphicusertemplate"></a>
# **BarcodeSetBarcodeGraphicUserTemplate**
> void BarcodeSetBarcodeGraphicUserTemplate (BarcodeGraphicTemplateSaveDto dto)

This call sets the barcode graphic user template

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BarcodeSetBarcodeGraphicUserTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BarcodeApi();
            var dto = new BarcodeGraphicTemplateSaveDto(); // BarcodeGraphicTemplateSaveDto | Barcode Graphic Template to save

            try
            {
                // This call sets the barcode graphic user template
                apiInstance.BarcodeSetBarcodeGraphicUserTemplate(dto);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BarcodeApi.BarcodeSetBarcodeGraphicUserTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dto** | [**BarcodeGraphicTemplateSaveDto**](BarcodeGraphicTemplateSaveDto.md)| Barcode Graphic Template to save | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="barcodesetbarcodeusersettings"></a>
# **BarcodeSetBarcodeUserSettings**
> void BarcodeSetBarcodeUserSettings (BarcodeUserSettingsDto barcodeSettings)

This call sets the barcode user default settings

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BarcodeSetBarcodeUserSettingsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BarcodeApi();
            var barcodeSettings = new BarcodeUserSettingsDto(); // BarcodeUserSettingsDto | Barcode settings for user

            try
            {
                // This call sets the barcode user default settings
                apiInstance.BarcodeSetBarcodeUserSettings(barcodeSettings);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BarcodeApi.BarcodeSetBarcodeUserSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **barcodeSettings** | [**BarcodeUserSettingsDto**](BarcodeUserSettingsDto.md)| Barcode settings for user | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="barcodesetbarcodeusertemplate"></a>
# **BarcodeSetBarcodeUserTemplate**
> void BarcodeSetBarcodeUserTemplate (BarcodeTemplateDto templateDto)

This call sets the barcode user template

### Example
```csharp
using System;
using System.Diagnostics;
using ARXivarNEXT.Client.Api;
using ARXivarNEXT.Client.Client;
using ARXivarNEXT.Client.Model;

namespace Example
{
    public class BarcodeSetBarcodeUserTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BarcodeApi();
            var templateDto = new BarcodeTemplateDto(); // BarcodeTemplateDto | Barcode Template

            try
            {
                // This call sets the barcode user template
                apiInstance.BarcodeSetBarcodeUserTemplate(templateDto);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BarcodeApi.BarcodeSetBarcodeUserTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateDto** | [**BarcodeTemplateDto**](BarcodeTemplateDto.md)| Barcode Template | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# ARXivarNEXT.Client.Model.SharingDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SharingId** | **string** | Sharing unique id | [optional] 
**UserId** | **int?** | Owner user id | [optional] 
**CreationDate** | **DateTime?** | Date time of creation | [optional] 
**HtmlForAccess** | [**List&lt;SharingHtmlDTO&gt;**](SharingHtmlDTO.md) | Html for the sharing page | [optional] 
**HtmlForExpiration** | [**List&lt;SharingHtmlDTO&gt;**](SharingHtmlDTO.md) | Html for the expiration page | [optional] 
**UrlForReceivers** | [**List&lt;SharingReceiverUriDTO&gt;**](SharingReceiverUriDTO.md) | Collection of URL for receivers | [optional] 
**SharingDefinitionId** | **string** | Unique identifier for the configuration | [optional] 
**DocumentTypeId** | **int?** | System id for the documentType. | [optional] 
**Beginning** | **int?** | Days for the activation of the sharing. | [optional] 
**Expiration** | **int?** | Days for the expiration of the sharing. | [optional] 
**AfterSend** | **int?** | Possible values:  0: None  1: Email  2: R  3: RR  4: EmailArchiveContent  | [optional] 
**RepeatSendMail** | **bool?** | Resend for the mail. | [optional] 
**RepeatSendMailTime** | **int?** | Resend mail Days. | [optional] 
**RepeatSendMailNumber** | **int?** | Max number of resend for mail. | [optional] 
**WorkflowAfterRead** | **int?** | Workflow id for the read operation. | [optional] 
**WorkflowAfterExpiration** | **int?** | Workflow id for the expiration of a read sharing | [optional] 
**WorkflowAfterExpirationNotRead** | **int?** | Workflow id for the expiration of a not read sharing | [optional] 
**AlertForNoRead** | **bool?** | Enable warning for no read sharing. | [optional] 
**AlertForNoReadTime** | **int?** | Warning message for no read sharing days. | [optional] 
**DisableAfterRead** | **bool?** | Disable sharing after read. | [optional] 
**DeleteAfterExpiration** | **bool?** | Delete after expiration. | [optional] 
**ImmediatlySend** | **bool?** | Immediatly send. | [optional] 
**SendTime** | **DateTime?** | Send datetime. | [optional] 
**MaxDownloadTime** | **int?** | Max number of download | [optional] 
**DetailsAsZip** | **bool?** | Archive the details in one zip | [optional] 
**DefaultLanguage** | **string** | Default language. | [optional] 
**DownloadDirectly** | **bool?** | Donwload the documents directly from mail | [optional] 
**SharingMode** | **int?** | Possible values:  0: Link  1: Attachment  2: None  | [optional] 
**MailDefinitions** | [**List&lt;SharingMailDTO&gt;**](SharingMailDTO.md) | List of mails to send. | [optional] 
**ShareName** | **string** | Sharing name. | [optional] 
**ShareDescription** | **string** | Sharing description. | [optional] 
**IsEnable** | **bool?** | Is enable. | [optional] 
**Virtual** | **bool?** | Is virtual sharing. | [optional] 
**SharingReceivers** | [**List&lt;SharingReceiverDTO&gt;**](SharingReceiverDTO.md) | Sharing receivers. | [optional] 
**SharingDetails** | [**List&lt;SharingDetailDTO&gt;**](SharingDetailDTO.md) | Sharing details. | [optional] 
**ExternalData** | [**List&lt;KeyValueDTO&gt;**](KeyValueDTO.md) | Sharing external data. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


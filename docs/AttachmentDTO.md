# ARXivarNEXT.Client.Model.AttachmentDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Unique identifier | [optional] 
**Docnumber** | **int?** | Document Identifier | [optional] 
**Revision** | **int?** | Revision number | [optional] 
**Filename** | **string** | Name for the zip file. | [optional] 
**Filepath** | **string** | Path of compressed file. | [optional] 
**Originalname** | **string** | Name of the file. | [optional] 
**Device** | **int?** | Possible values:  0: Hd  1: Cd  | [optional] 
**Cdlabel** | **string** | CD Label | [optional] 
**Comment** | **string** | Description | [optional] 
**Importdate** | **DateTime?** | Creation Date | [optional] 
**User** | **int?** | Identifier of the author | [optional] 
**UserCompleteName** | **string** | Full name of the author | [optional] 
**Block** | **int?** | Possible values:  0: None  1: Active  2: Marked  | [optional] 
**Compliantcopy** | **bool?** | Replace with the profile data for web visualization | [optional] 
**Footprint** | **string** | Hash of the file | [optional] 
**Checksend** | **bool?** | Send the file in the case of email shipment | [optional] 
**Aosflag** | **bool?** | Kept in the replacement mode with the document profile | [optional] 
**Access** | **int?** | Possible values:  0: Access_Denied  1: Read_Only  2: Edit  4: Full_Trust  -1: None  | [optional] 
**SaveType** | **int?** | Possible values:  0: File_System  1: Database  | [optional] 
**Filesize** | **long?** | File Size | [optional] 
**Kind** | **int?** | Possible values:  0: ExternalAttachement  1: InternalAttachement  | [optional] 
**AttachedDocnumber** | **int?** | Document Identifier if the internal attachment | [optional] 
**IxCheck** | **bool?** | Send the file to IX service in the case of shipment | [optional] 
**AttachmentRevision** | **int?** |  | [optional] 
**CompressionMode** | **int?** | Possible values:  0: None  1: CompressChilkat91  2: CompressChilkat95  3: CompressChilkat95AndCryptoAes256  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


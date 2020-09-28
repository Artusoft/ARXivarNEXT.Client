# ARXivarNEXT.Client.Model.SignatureInfoDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SignatureStandard** | **string** |  | [optional] 
**CertificateInfo** | [**CertificateInfoDTO**](CertificateInfoDTO.md) |  | [optional] 
**TimestampInfo** | [**TimestampInfoDTO**](TimestampInfoDTO.md) |  | [optional] 
**CounterSignatures** | [**List&lt;SignatureInfoDTO&gt;**](SignatureInfoDTO.md) |  | [optional] 
**ContentType** | [**IdValuePairDTO**](IdValuePairDTO.md) |  | [optional] 
**DigestAlgorithm** | [**IdValuePairDTO**](IdValuePairDTO.md) |  | [optional] 
**SignAlgorithm** | [**IdValuePairDTO**](IdValuePairDTO.md) |  | [optional] 
**SignatureHex** | **string** |  | [optional] 
**IsValid** | **bool?** |  | [optional] 
**SignatureIntegrity** | **bool?** |  | [optional] 
**IsCounterSign** | **bool?** |  | [optional] 
**SignatureValidationMessageList** | [**List&lt;ValidationMessageDTO&gt;**](ValidationMessageDTO.md) |  | [optional] 
**SignatureTimeUtc** | **DateTime?** |  | [optional] 
**SignedAttributeList** | [**List&lt;SignatureAttributeDTO&gt;**](SignatureAttributeDTO.md) |  | [optional] 
**UnsignedAttributeList** | [**List&lt;SignatureAttributeDTO&gt;**](SignatureAttributeDTO.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# ARXivarNEXT.Client.Model.CertificateInfoDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SignAlgorithm** | [**IdValuePairDTO**](IdValuePairDTO.md) |  | [optional] 
**KeyBitLength** | **int?** |  | [optional] 
**SerialNumber** | **string** |  | [optional] 
**ThumbprintAlgorithm** | [**IdValuePairDTO**](IdValuePairDTO.md) |  | [optional] 
**Thumbprint** | **string** |  | [optional] 
**TrustLevel** | **string** |  | [optional] 
**KeyUsageList** | **List&lt;int?&gt;** |  | [optional] 
**ExtendedKeyUsageList** | [**List&lt;IdValuePairDTO&gt;**](IdValuePairDTO.md) |  | [optional] 
**ValidNotBeforeUtc** | **DateTime?** |  | [optional] 
**ValidNotAfterUtc** | **DateTime?** |  | [optional] 
**SubjectKeyIdentifier** | **string** |  | [optional] 
**SubjectAlternativeName** | **string** |  | [optional] 
**SubjectUniqueId** | **string** |  | [optional] 
**SubjectInfoList** | [**List&lt;IdValuePairDTO&gt;**](IdValuePairDTO.md) |  | [optional] 
**Version** | **int?** |  | [optional] 
**IssuerUniqueId** | **string** |  | [optional] 
**IssuerAlternativeName** | **string** |  | [optional] 
**IssuerInfoList** | [**List&lt;IdValuePairDTO&gt;**](IdValuePairDTO.md) |  | [optional] 
**AuthorityInfoAccessOcsp** | **List&lt;string&gt;** |  | [optional] 
**CrlDistributionPoints** | **List&lt;string&gt;** |  | [optional] 
**ValidationMessageList** | [**List&lt;ValidationMessageDTO&gt;**](ValidationMessageDTO.md) |  | [optional] 
**CertificatePolicies** | [**List&lt;CertificatePolicyInfoDTO&gt;**](CertificatePolicyInfoDTO.md) |  | [optional] 
**QcStatementList** | [**List&lt;SignatureAttributeDTO&gt;**](SignatureAttributeDTO.md) |  | [optional] 
**IsTrusted** | **bool?** |  | [optional] 
**TrustValidationMessageList** | [**List&lt;ValidationMessageDTO&gt;**](ValidationMessageDTO.md) |  | [optional] 
**IsValid** | **bool?** |  | [optional] 
**CertificateB64** | **string** |  | [optional] 
**VerifyCondition** | [**VerifyConditionDTO**](VerifyConditionDTO.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


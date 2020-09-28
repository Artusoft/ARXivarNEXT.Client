/* 
 * WebAPI
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: data
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = ARXivarNEXT.Client.Client.SwaggerDateConverter;

namespace ARXivarNEXT.Client.Model
{
    /// <summary>
    /// GetByDocumentTypeRequestDTO
    /// </summary>
    [DataContract]
    public partial class GetByDocumentTypeRequestDTO :  IEquatable<GetByDocumentTypeRequestDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetByDocumentTypeRequestDTO" /> class.
        /// </summary>
        /// <param name="documentTypeCode">documentTypeCode.</param>
        public GetByDocumentTypeRequestDTO(string documentTypeCode = default(string))
        {
            this.DocumentTypeCode = documentTypeCode;
        }
        
        /// <summary>
        /// Gets or Sets DocumentTypeCode
        /// </summary>
        [DataMember(Name="documentTypeCode", EmitDefaultValue=false)]
        public string DocumentTypeCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetByDocumentTypeRequestDTO {\n");
            sb.Append("  DocumentTypeCode: ").Append(DocumentTypeCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetByDocumentTypeRequestDTO);
        }

        /// <summary>
        /// Returns true if GetByDocumentTypeRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of GetByDocumentTypeRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetByDocumentTypeRequestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocumentTypeCode == input.DocumentTypeCode ||
                    (this.DocumentTypeCode != null &&
                    this.DocumentTypeCode.Equals(input.DocumentTypeCode))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DocumentTypeCode != null)
                    hashCode = hashCode * 59 + this.DocumentTypeCode.GetHashCode();
                return hashCode;
            }
        }
    }

}
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
    /// ProfileMailResponseDTO
    /// </summary>
    [DataContract]
    public partial class ProfileMailResponseDTO :  IEquatable<ProfileMailResponseDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileMailResponseDTO" /> class.
        /// </summary>
        /// <param name="processingMode">Possible values:  0: Automatic  1: Interactive  2: Asynchronous .</param>
        /// <param name="responseItemList">responseItemList.</param>
        public ProfileMailResponseDTO(int? processingMode = default(int?), List<ProfileMailResponseItem> responseItemList = default(List<ProfileMailResponseItem>))
        {
            this.ProcessingMode = processingMode;
            this.ResponseItemList = responseItemList;
        }
        
        /// <summary>
        /// Possible values:  0: Automatic  1: Interactive  2: Asynchronous 
        /// </summary>
        /// <value>Possible values:  0: Automatic  1: Interactive  2: Asynchronous </value>
        [DataMember(Name="processingMode", EmitDefaultValue=false)]
        public int? ProcessingMode { get; set; }

        /// <summary>
        /// Gets or Sets ResponseItemList
        /// </summary>
        [DataMember(Name="responseItemList", EmitDefaultValue=false)]
        public List<ProfileMailResponseItem> ResponseItemList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProfileMailResponseDTO {\n");
            sb.Append("  ProcessingMode: ").Append(ProcessingMode).Append("\n");
            sb.Append("  ResponseItemList: ").Append(ResponseItemList).Append("\n");
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
            return this.Equals(input as ProfileMailResponseDTO);
        }

        /// <summary>
        /// Returns true if ProfileMailResponseDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ProfileMailResponseDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfileMailResponseDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProcessingMode == input.ProcessingMode ||
                    (this.ProcessingMode != null &&
                    this.ProcessingMode.Equals(input.ProcessingMode))
                ) && 
                (
                    this.ResponseItemList == input.ResponseItemList ||
                    this.ResponseItemList != null &&
                    this.ResponseItemList.SequenceEqual(input.ResponseItemList)
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
                if (this.ProcessingMode != null)
                    hashCode = hashCode * 59 + this.ProcessingMode.GetHashCode();
                if (this.ResponseItemList != null)
                    hashCode = hashCode * 59 + this.ResponseItemList.GetHashCode();
                return hashCode;
            }
        }
    }

}
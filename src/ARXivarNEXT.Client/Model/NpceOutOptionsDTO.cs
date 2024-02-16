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
    /// NpceOutOptionsDTO
    /// </summary>
    [DataContract]
    public partial class NpceOutOptionsDTO :  IEquatable<NpceOutOptionsDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NpceOutOptionsDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NpceOutOptionsDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NpceOutOptionsDTO" /> class.
        /// </summary>
        /// <param name="colors">Possible values:  0: BlackWhite  1: Colors  (required).</param>
        /// <param name="frontRear">Possible values:  0: FrontOnly  1: FrontRear  (required).</param>
        public NpceOutOptionsDTO(int? colors = default(int?), int? frontRear = default(int?))
        {
            // to ensure "colors" is required (not null)
            if (colors == null)
            {
                throw new InvalidDataException("colors is a required property for NpceOutOptionsDTO and cannot be null");
            }
            else
            {
                this.Colors = colors;
            }
            // to ensure "frontRear" is required (not null)
            if (frontRear == null)
            {
                throw new InvalidDataException("frontRear is a required property for NpceOutOptionsDTO and cannot be null");
            }
            else
            {
                this.FrontRear = frontRear;
            }
        }
        
        /// <summary>
        /// Possible values:  0: BlackWhite  1: Colors 
        /// </summary>
        /// <value>Possible values:  0: BlackWhite  1: Colors </value>
        [DataMember(Name="colors", EmitDefaultValue=false)]
        public int? Colors { get; set; }

        /// <summary>
        /// Possible values:  0: FrontOnly  1: FrontRear 
        /// </summary>
        /// <value>Possible values:  0: FrontOnly  1: FrontRear </value>
        [DataMember(Name="frontRear", EmitDefaultValue=false)]
        public int? FrontRear { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NpceOutOptionsDTO {\n");
            sb.Append("  Colors: ").Append(Colors).Append("\n");
            sb.Append("  FrontRear: ").Append(FrontRear).Append("\n");
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
            return this.Equals(input as NpceOutOptionsDTO);
        }

        /// <summary>
        /// Returns true if NpceOutOptionsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of NpceOutOptionsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NpceOutOptionsDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Colors == input.Colors ||
                    (this.Colors != null &&
                    this.Colors.Equals(input.Colors))
                ) && 
                (
                    this.FrontRear == input.FrontRear ||
                    (this.FrontRear != null &&
                    this.FrontRear.Equals(input.FrontRear))
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
                if (this.Colors != null)
                    hashCode = hashCode * 59 + this.Colors.GetHashCode();
                if (this.FrontRear != null)
                    hashCode = hashCode * 59 + this.FrontRear.GetHashCode();
                return hashCode;
            }
        }
    }

}
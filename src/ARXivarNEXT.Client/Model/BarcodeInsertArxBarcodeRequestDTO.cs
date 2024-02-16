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
    /// Class that represents a new arxbarcode item request
    /// </summary>
    [DataContract]
    public partial class BarcodeInsertArxBarcodeRequestDTO :  IEquatable<BarcodeInsertArxBarcodeRequestDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BarcodeInsertArxBarcodeRequestDTO" /> class.
        /// </summary>
        /// <param name="docnumber">Docnumber.</param>
        /// <param name="numPages">Number of pages.</param>
        public BarcodeInsertArxBarcodeRequestDTO(int? docnumber = default(int?), int? numPages = default(int?))
        {
            this.Docnumber = docnumber;
            this.NumPages = numPages;
        }
        
        /// <summary>
        /// Docnumber
        /// </summary>
        /// <value>Docnumber</value>
        [DataMember(Name="docnumber", EmitDefaultValue=false)]
        public int? Docnumber { get; set; }

        /// <summary>
        /// Number of pages
        /// </summary>
        /// <value>Number of pages</value>
        [DataMember(Name="numPages", EmitDefaultValue=false)]
        public int? NumPages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BarcodeInsertArxBarcodeRequestDTO {\n");
            sb.Append("  Docnumber: ").Append(Docnumber).Append("\n");
            sb.Append("  NumPages: ").Append(NumPages).Append("\n");
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
            return this.Equals(input as BarcodeInsertArxBarcodeRequestDTO);
        }

        /// <summary>
        /// Returns true if BarcodeInsertArxBarcodeRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of BarcodeInsertArxBarcodeRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BarcodeInsertArxBarcodeRequestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Docnumber == input.Docnumber ||
                    (this.Docnumber != null &&
                    this.Docnumber.Equals(input.Docnumber))
                ) && 
                (
                    this.NumPages == input.NumPages ||
                    (this.NumPages != null &&
                    this.NumPages.Equals(input.NumPages))
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
                if (this.Docnumber != null)
                    hashCode = hashCode * 59 + this.Docnumber.GetHashCode();
                if (this.NumPages != null)
                    hashCode = hashCode * 59 + this.NumPages.GetHashCode();
                return hashCode;
            }
        }
    }

}
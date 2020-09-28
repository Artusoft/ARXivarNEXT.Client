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
    /// Class of layout deatil
    /// </summary>
    [DataContract]
    public partial class LayoutDetailDTO :  IEquatable<LayoutDetailDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutDetailDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="label">label.</param>
        /// <param name="elementType">Element Type.</param>
        /// <param name="elementId">Element Identifier.</param>
        /// <param name="elementAction">Element Action.</param>
        /// <param name="orderIndex">Order.</param>
        /// <param name="parentId">Parent Identifier.</param>
        /// <param name="layoutId">Layout Identifier.</param>
        /// <param name="operation">Operation Type.</param>
        /// <param name="favourite">favourite.</param>
        /// <param name="translations">Translated Labels.</param>
        /// <param name="childs">Details of child layout.</param>
        public LayoutDetailDTO(int? id = default(int?), string label = default(string), int? elementType = default(int?), string elementId = default(string), int? elementAction = default(int?), int? orderIndex = default(int?), int? parentId = default(int?), int? layoutId = default(int?), int? operation = default(int?), bool? favourite = default(bool?), List<LabelTranslationsDto> translations = default(List<LabelTranslationsDto>), List<LayoutDetailDTO> childs = default(List<LayoutDetailDTO>))
        {
            this.Id = id;
            this.Label = label;
            this.ElementType = elementType;
            this.ElementId = elementId;
            this.ElementAction = elementAction;
            this.OrderIndex = orderIndex;
            this.ParentId = parentId;
            this.LayoutId = layoutId;
            this.Operation = operation;
            this.Favourite = favourite;
            this.Translations = translations;
            this.Childs = childs;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Element Type
        /// </summary>
        /// <value>Element Type</value>
        [DataMember(Name="elementType", EmitDefaultValue=false)]
        public int? ElementType { get; set; }

        /// <summary>
        /// Element Identifier
        /// </summary>
        /// <value>Element Identifier</value>
        [DataMember(Name="elementId", EmitDefaultValue=false)]
        public string ElementId { get; set; }

        /// <summary>
        /// Element Action
        /// </summary>
        /// <value>Element Action</value>
        [DataMember(Name="elementAction", EmitDefaultValue=false)]
        public int? ElementAction { get; set; }

        /// <summary>
        /// Order
        /// </summary>
        /// <value>Order</value>
        [DataMember(Name="orderIndex", EmitDefaultValue=false)]
        public int? OrderIndex { get; set; }

        /// <summary>
        /// Parent Identifier
        /// </summary>
        /// <value>Parent Identifier</value>
        [DataMember(Name="parentId", EmitDefaultValue=false)]
        public int? ParentId { get; set; }

        /// <summary>
        /// Layout Identifier
        /// </summary>
        /// <value>Layout Identifier</value>
        [DataMember(Name="layoutId", EmitDefaultValue=false)]
        public int? LayoutId { get; set; }

        /// <summary>
        /// Operation Type
        /// </summary>
        /// <value>Operation Type</value>
        [DataMember(Name="operation", EmitDefaultValue=false)]
        public int? Operation { get; set; }

        /// <summary>
        /// Gets or Sets Favourite
        /// </summary>
        [DataMember(Name="favourite", EmitDefaultValue=false)]
        public bool? Favourite { get; set; }

        /// <summary>
        /// Translated Labels
        /// </summary>
        /// <value>Translated Labels</value>
        [DataMember(Name="translations", EmitDefaultValue=false)]
        public List<LabelTranslationsDto> Translations { get; set; }

        /// <summary>
        /// Details of child layout
        /// </summary>
        /// <value>Details of child layout</value>
        [DataMember(Name="childs", EmitDefaultValue=false)]
        public List<LayoutDetailDTO> Childs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LayoutDetailDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  ElementType: ").Append(ElementType).Append("\n");
            sb.Append("  ElementId: ").Append(ElementId).Append("\n");
            sb.Append("  ElementAction: ").Append(ElementAction).Append("\n");
            sb.Append("  OrderIndex: ").Append(OrderIndex).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  LayoutId: ").Append(LayoutId).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  Favourite: ").Append(Favourite).Append("\n");
            sb.Append("  Translations: ").Append(Translations).Append("\n");
            sb.Append("  Childs: ").Append(Childs).Append("\n");
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
            return this.Equals(input as LayoutDetailDTO);
        }

        /// <summary>
        /// Returns true if LayoutDetailDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of LayoutDetailDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LayoutDetailDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.ElementType == input.ElementType ||
                    (this.ElementType != null &&
                    this.ElementType.Equals(input.ElementType))
                ) && 
                (
                    this.ElementId == input.ElementId ||
                    (this.ElementId != null &&
                    this.ElementId.Equals(input.ElementId))
                ) && 
                (
                    this.ElementAction == input.ElementAction ||
                    (this.ElementAction != null &&
                    this.ElementAction.Equals(input.ElementAction))
                ) && 
                (
                    this.OrderIndex == input.OrderIndex ||
                    (this.OrderIndex != null &&
                    this.OrderIndex.Equals(input.OrderIndex))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.LayoutId == input.LayoutId ||
                    (this.LayoutId != null &&
                    this.LayoutId.Equals(input.LayoutId))
                ) && 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
                ) && 
                (
                    this.Favourite == input.Favourite ||
                    (this.Favourite != null &&
                    this.Favourite.Equals(input.Favourite))
                ) && 
                (
                    this.Translations == input.Translations ||
                    this.Translations != null &&
                    this.Translations.SequenceEqual(input.Translations)
                ) && 
                (
                    this.Childs == input.Childs ||
                    this.Childs != null &&
                    this.Childs.SequenceEqual(input.Childs)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.ElementType != null)
                    hashCode = hashCode * 59 + this.ElementType.GetHashCode();
                if (this.ElementId != null)
                    hashCode = hashCode * 59 + this.ElementId.GetHashCode();
                if (this.ElementAction != null)
                    hashCode = hashCode * 59 + this.ElementAction.GetHashCode();
                if (this.OrderIndex != null)
                    hashCode = hashCode * 59 + this.OrderIndex.GetHashCode();
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.LayoutId != null)
                    hashCode = hashCode * 59 + this.LayoutId.GetHashCode();
                if (this.Operation != null)
                    hashCode = hashCode * 59 + this.Operation.GetHashCode();
                if (this.Favourite != null)
                    hashCode = hashCode * 59 + this.Favourite.GetHashCode();
                if (this.Translations != null)
                    hashCode = hashCode * 59 + this.Translations.GetHashCode();
                if (this.Childs != null)
                    hashCode = hashCode * 59 + this.Childs.GetHashCode();
                return hashCode;
            }
        }
    }

}
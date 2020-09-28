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
    /// TaskWorkInstructionDTO
    /// </summary>
    [DataContract]
    public partial class TaskWorkInstructionDTO :  IEquatable<TaskWorkInstructionDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskWorkInstructionDTO" /> class.
        /// </summary>
        /// <param name="taskWorkInstructionGroups">taskWorkInstructionGroups.</param>
        /// <param name="taskWorkInstructionItems">taskWorkInstructionItems.</param>
        public TaskWorkInstructionDTO(List<TaskWorkInstructionGroupDTO> taskWorkInstructionGroups = default(List<TaskWorkInstructionGroupDTO>), List<TaskWorkInstructionItemDTO> taskWorkInstructionItems = default(List<TaskWorkInstructionItemDTO>))
        {
            this.TaskWorkInstructionGroups = taskWorkInstructionGroups;
            this.TaskWorkInstructionItems = taskWorkInstructionItems;
        }
        
        /// <summary>
        /// Gets or Sets TaskWorkInstructionGroups
        /// </summary>
        [DataMember(Name="taskWorkInstructionGroups", EmitDefaultValue=false)]
        public List<TaskWorkInstructionGroupDTO> TaskWorkInstructionGroups { get; set; }

        /// <summary>
        /// Gets or Sets TaskWorkInstructionItems
        /// </summary>
        [DataMember(Name="taskWorkInstructionItems", EmitDefaultValue=false)]
        public List<TaskWorkInstructionItemDTO> TaskWorkInstructionItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskWorkInstructionDTO {\n");
            sb.Append("  TaskWorkInstructionGroups: ").Append(TaskWorkInstructionGroups).Append("\n");
            sb.Append("  TaskWorkInstructionItems: ").Append(TaskWorkInstructionItems).Append("\n");
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
            return this.Equals(input as TaskWorkInstructionDTO);
        }

        /// <summary>
        /// Returns true if TaskWorkInstructionDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskWorkInstructionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskWorkInstructionDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskWorkInstructionGroups == input.TaskWorkInstructionGroups ||
                    this.TaskWorkInstructionGroups != null &&
                    this.TaskWorkInstructionGroups.SequenceEqual(input.TaskWorkInstructionGroups)
                ) && 
                (
                    this.TaskWorkInstructionItems == input.TaskWorkInstructionItems ||
                    this.TaskWorkInstructionItems != null &&
                    this.TaskWorkInstructionItems.SequenceEqual(input.TaskWorkInstructionItems)
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
                if (this.TaskWorkInstructionGroups != null)
                    hashCode = hashCode * 59 + this.TaskWorkInstructionGroups.GetHashCode();
                if (this.TaskWorkInstructionItems != null)
                    hashCode = hashCode * 59 + this.TaskWorkInstructionItems.GetHashCode();
                return hashCode;
            }
        }
    }

}
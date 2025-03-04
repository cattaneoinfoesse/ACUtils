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
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = ACUtils.AXRepository.ArxivarNext.Client.SwaggerDateConverter;

namespace ACUtils.AXRepository.ArxivarNext.Model
{
    /// <summary>
    /// TaskWorkDynamicJobOperationsDTO
    /// </summary>
    [DataContract]
    public partial class TaskWorkDynamicJobOperationsDTO :  IEquatable<TaskWorkDynamicJobOperationsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskWorkDynamicJobOperationsDTO" /> class.
        /// </summary>
        /// <param name="operations">operations.</param>
        /// <param name="description">description.</param>
        public TaskWorkDynamicJobOperationsDTO(List<TaskWorkDynamicJobOperationDTO> operations = default(List<TaskWorkDynamicJobOperationDTO>), string description = default(string))
        {
            this.Operations = operations;
            this.Description = description;
        }
        
        /// <summary>
        /// Gets or Sets Operations
        /// </summary>
        [DataMember(Name="operations", EmitDefaultValue=false)]
        public List<TaskWorkDynamicJobOperationDTO> Operations { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskWorkDynamicJobOperationsDTO {\n");
            sb.Append("  Operations: ").Append(Operations).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as TaskWorkDynamicJobOperationsDTO);
        }

        /// <summary>
        /// Returns true if TaskWorkDynamicJobOperationsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskWorkDynamicJobOperationsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskWorkDynamicJobOperationsDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Operations == input.Operations ||
                    this.Operations != null &&
                    this.Operations.SequenceEqual(input.Operations)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Operations != null)
                    hashCode = hashCode * 59 + this.Operations.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

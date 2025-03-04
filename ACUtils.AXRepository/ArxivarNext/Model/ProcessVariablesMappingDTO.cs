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
    /// Process Variables mapping
    /// </summary>
    [DataContract]
    public partial class ProcessVariablesMappingDTO :  IEquatable<ProcessVariablesMappingDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessVariablesMappingDTO" /> class.
        /// </summary>
        /// <param name="processVariableList">Process variable list.</param>
        public ProcessVariablesMappingDTO(List<GenericKeyValueDTO> processVariableList = default(List<GenericKeyValueDTO>))
        {
            this.ProcessVariableList = processVariableList;
        }
        
        /// <summary>
        /// Process variable list
        /// </summary>
        /// <value>Process variable list</value>
        [DataMember(Name="processVariableList", EmitDefaultValue=false)]
        public List<GenericKeyValueDTO> ProcessVariableList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessVariablesMappingDTO {\n");
            sb.Append("  ProcessVariableList: ").Append(ProcessVariableList).Append("\n");
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
            return this.Equals(input as ProcessVariablesMappingDTO);
        }

        /// <summary>
        /// Returns true if ProcessVariablesMappingDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessVariablesMappingDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessVariablesMappingDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProcessVariableList == input.ProcessVariableList ||
                    this.ProcessVariableList != null &&
                    this.ProcessVariableList.SequenceEqual(input.ProcessVariableList)
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
                if (this.ProcessVariableList != null)
                    hashCode = hashCode * 59 + this.ProcessVariableList.GetHashCode();
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

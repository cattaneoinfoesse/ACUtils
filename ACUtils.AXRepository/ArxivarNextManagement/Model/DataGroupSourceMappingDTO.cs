/* 
 * WebAPI - Area Management
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: management
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
using SwaggerDateConverter = ACUtils.AXRepository.ArxivarNextManagement.Client.SwaggerDateConverter;

namespace ACUtils.AXRepository.ArxivarNextManagement.Model
{
    /// <summary>
    /// Class of data group external source mapping
    /// </summary>
    [DataContract]
    public partial class DataGroupSourceMappingDTO :  IEquatable<DataGroupSourceMappingDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataGroupSourceMappingDTO" /> class.
        /// </summary>
        /// <param name="sourceField">Source field from SQL or API.</param>
        /// <param name="destinationField">Destination field.</param>
        public DataGroupSourceMappingDTO(string sourceField = default(string), FieldManagementDTO destinationField = default(FieldManagementDTO))
        {
            this.SourceField = sourceField;
            this.DestinationField = destinationField;
        }
        
        /// <summary>
        /// Source field from SQL or API
        /// </summary>
        /// <value>Source field from SQL or API</value>
        [DataMember(Name="sourceField", EmitDefaultValue=false)]
        public string SourceField { get; set; }

        /// <summary>
        /// Destination field
        /// </summary>
        /// <value>Destination field</value>
        [DataMember(Name="destinationField", EmitDefaultValue=false)]
        public FieldManagementDTO DestinationField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataGroupSourceMappingDTO {\n");
            sb.Append("  SourceField: ").Append(SourceField).Append("\n");
            sb.Append("  DestinationField: ").Append(DestinationField).Append("\n");
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
            return this.Equals(input as DataGroupSourceMappingDTO);
        }

        /// <summary>
        /// Returns true if DataGroupSourceMappingDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of DataGroupSourceMappingDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataGroupSourceMappingDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceField == input.SourceField ||
                    (this.SourceField != null &&
                    this.SourceField.Equals(input.SourceField))
                ) && 
                (
                    this.DestinationField == input.DestinationField ||
                    (this.DestinationField != null &&
                    this.DestinationField.Equals(input.DestinationField))
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
                if (this.SourceField != null)
                    hashCode = hashCode * 59 + this.SourceField.GetHashCode();
                if (this.DestinationField != null)
                    hashCode = hashCode * 59 + this.DestinationField.GetHashCode();
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

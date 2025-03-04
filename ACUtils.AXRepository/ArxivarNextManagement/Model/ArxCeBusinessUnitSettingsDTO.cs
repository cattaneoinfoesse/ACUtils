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
    /// Class of ArxCe Business unit settings
    /// </summary>
    [DataContract]
    public partial class ArxCeBusinessUnitSettingsDTO :  IEquatable<ArxCeBusinessUnitSettingsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArxCeBusinessUnitSettingsDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="arxBusinessUnit">ArxCe Business unit.</param>
        /// <param name="arxCeBusinessUnit">Arxivar Business unit.</param>
        /// <param name="enabled">Enabled.</param>
        /// <param name="credentials">Credentials for business unit.</param>
        public ArxCeBusinessUnitSettingsDTO(int? id = default(int?), BusinessUnitDTO arxBusinessUnit = default(BusinessUnitDTO), ArxCeBusinessUnitSimpleDTO arxCeBusinessUnit = default(ArxCeBusinessUnitSimpleDTO), bool? enabled = default(bool?), ArxCeCredentialsDTO credentials = default(ArxCeCredentialsDTO))
        {
            this.Id = id;
            this.ArxBusinessUnit = arxBusinessUnit;
            this.ArxCeBusinessUnit = arxCeBusinessUnit;
            this.Enabled = enabled;
            this.Credentials = credentials;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// ArxCe Business unit
        /// </summary>
        /// <value>ArxCe Business unit</value>
        [DataMember(Name="arxBusinessUnit", EmitDefaultValue=false)]
        public BusinessUnitDTO ArxBusinessUnit { get; set; }

        /// <summary>
        /// Arxivar Business unit
        /// </summary>
        /// <value>Arxivar Business unit</value>
        [DataMember(Name="arxCeBusinessUnit", EmitDefaultValue=false)]
        public ArxCeBusinessUnitSimpleDTO ArxCeBusinessUnit { get; set; }

        /// <summary>
        /// Enabled
        /// </summary>
        /// <value>Enabled</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Credentials for business unit
        /// </summary>
        /// <value>Credentials for business unit</value>
        [DataMember(Name="credentials", EmitDefaultValue=false)]
        public ArxCeCredentialsDTO Credentials { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArxCeBusinessUnitSettingsDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ArxBusinessUnit: ").Append(ArxBusinessUnit).Append("\n");
            sb.Append("  ArxCeBusinessUnit: ").Append(ArxCeBusinessUnit).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
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
            return this.Equals(input as ArxCeBusinessUnitSettingsDTO);
        }

        /// <summary>
        /// Returns true if ArxCeBusinessUnitSettingsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ArxCeBusinessUnitSettingsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArxCeBusinessUnitSettingsDTO input)
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
                    this.ArxBusinessUnit == input.ArxBusinessUnit ||
                    (this.ArxBusinessUnit != null &&
                    this.ArxBusinessUnit.Equals(input.ArxBusinessUnit))
                ) && 
                (
                    this.ArxCeBusinessUnit == input.ArxCeBusinessUnit ||
                    (this.ArxCeBusinessUnit != null &&
                    this.ArxCeBusinessUnit.Equals(input.ArxCeBusinessUnit))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))
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
                if (this.ArxBusinessUnit != null)
                    hashCode = hashCode * 59 + this.ArxBusinessUnit.GetHashCode();
                if (this.ArxCeBusinessUnit != null)
                    hashCode = hashCode * 59 + this.ArxCeBusinessUnit.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Credentials != null)
                    hashCode = hashCode * 59 + this.Credentials.GetHashCode();
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

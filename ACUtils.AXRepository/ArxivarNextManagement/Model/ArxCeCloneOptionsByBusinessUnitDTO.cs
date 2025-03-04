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
    /// Class for cloning settings by business unit for ArxCe
    /// </summary>
    [DataContract]
    public partial class ArxCeCloneOptionsByBusinessUnitDTO :  IEquatable<ArxCeCloneOptionsByBusinessUnitDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArxCeCloneOptionsByBusinessUnitDTO" /> class.
        /// </summary>
        /// <param name="originalBusinessUnitCode">Business unit source.</param>
        /// <param name="documentTypeIds">Document types to clone.</param>
        /// <param name="businessUnitCodes">Destination business units.</param>
        public ArxCeCloneOptionsByBusinessUnitDTO(string originalBusinessUnitCode = default(string), List<int?> documentTypeIds = default(List<int?>), List<string> businessUnitCodes = default(List<string>))
        {
            this.OriginalBusinessUnitCode = originalBusinessUnitCode;
            this.DocumentTypeIds = documentTypeIds;
            this.BusinessUnitCodes = businessUnitCodes;
        }
        
        /// <summary>
        /// Business unit source
        /// </summary>
        /// <value>Business unit source</value>
        [DataMember(Name="originalBusinessUnitCode", EmitDefaultValue=false)]
        public string OriginalBusinessUnitCode { get; set; }

        /// <summary>
        /// Document types to clone
        /// </summary>
        /// <value>Document types to clone</value>
        [DataMember(Name="documentTypeIds", EmitDefaultValue=false)]
        public List<int?> DocumentTypeIds { get; set; }

        /// <summary>
        /// Destination business units
        /// </summary>
        /// <value>Destination business units</value>
        [DataMember(Name="businessUnitCodes", EmitDefaultValue=false)]
        public List<string> BusinessUnitCodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArxCeCloneOptionsByBusinessUnitDTO {\n");
            sb.Append("  OriginalBusinessUnitCode: ").Append(OriginalBusinessUnitCode).Append("\n");
            sb.Append("  DocumentTypeIds: ").Append(DocumentTypeIds).Append("\n");
            sb.Append("  BusinessUnitCodes: ").Append(BusinessUnitCodes).Append("\n");
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
            return this.Equals(input as ArxCeCloneOptionsByBusinessUnitDTO);
        }

        /// <summary>
        /// Returns true if ArxCeCloneOptionsByBusinessUnitDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ArxCeCloneOptionsByBusinessUnitDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArxCeCloneOptionsByBusinessUnitDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OriginalBusinessUnitCode == input.OriginalBusinessUnitCode ||
                    (this.OriginalBusinessUnitCode != null &&
                    this.OriginalBusinessUnitCode.Equals(input.OriginalBusinessUnitCode))
                ) && 
                (
                    this.DocumentTypeIds == input.DocumentTypeIds ||
                    this.DocumentTypeIds != null &&
                    this.DocumentTypeIds.SequenceEqual(input.DocumentTypeIds)
                ) && 
                (
                    this.BusinessUnitCodes == input.BusinessUnitCodes ||
                    this.BusinessUnitCodes != null &&
                    this.BusinessUnitCodes.SequenceEqual(input.BusinessUnitCodes)
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
                if (this.OriginalBusinessUnitCode != null)
                    hashCode = hashCode * 59 + this.OriginalBusinessUnitCode.GetHashCode();
                if (this.DocumentTypeIds != null)
                    hashCode = hashCode * 59 + this.DocumentTypeIds.GetHashCode();
                if (this.BusinessUnitCodes != null)
                    hashCode = hashCode * 59 + this.BusinessUnitCodes.GetHashCode();
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

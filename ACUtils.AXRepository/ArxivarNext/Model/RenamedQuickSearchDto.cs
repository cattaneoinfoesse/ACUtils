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
    /// Class of to rename a quick search
    /// </summary>
    [DataContract]
    public partial class RenamedQuickSearchDto :  IEquatable<RenamedQuickSearchDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenamedQuickSearchDto" /> class.
        /// </summary>
        /// <param name="quickSearchId">Identifier of quick search.</param>
        /// <param name="description">Description.</param>
        public RenamedQuickSearchDto(string quickSearchId = default(string), string description = default(string))
        {
            this.QuickSearchId = quickSearchId;
            this.Description = description;
        }
        
        /// <summary>
        /// Identifier of quick search
        /// </summary>
        /// <value>Identifier of quick search</value>
        [DataMember(Name="quickSearchId", EmitDefaultValue=false)]
        public string QuickSearchId { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RenamedQuickSearchDto {\n");
            sb.Append("  QuickSearchId: ").Append(QuickSearchId).Append("\n");
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
            return this.Equals(input as RenamedQuickSearchDto);
        }

        /// <summary>
        /// Returns true if RenamedQuickSearchDto instances are equal
        /// </summary>
        /// <param name="input">Instance of RenamedQuickSearchDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RenamedQuickSearchDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QuickSearchId == input.QuickSearchId ||
                    (this.QuickSearchId != null &&
                    this.QuickSearchId.Equals(input.QuickSearchId))
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
                if (this.QuickSearchId != null)
                    hashCode = hashCode * 59 + this.QuickSearchId.GetHashCode();
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

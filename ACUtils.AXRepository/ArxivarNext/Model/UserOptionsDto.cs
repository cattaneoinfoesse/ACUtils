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
    /// Class of user options
    /// </summary>
    [DataContract]
    public partial class UserOptionsDto :  IEquatable<UserOptionsDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserOptionsDto" /> class.
        /// </summary>
        /// <param name="search">Search Options.</param>
        /// <param name="documentTypeViewMode">Possible values:  0: Code  1: Description .</param>
        /// <param name="p7MView">p7MView.</param>
        public UserOptionsDto(UserSearchOptionDTO search = default(UserSearchOptionDTO), int? documentTypeViewMode = default(int?), bool? p7MView = default(bool?))
        {
            this.Search = search;
            this.DocumentTypeViewMode = documentTypeViewMode;
            this.P7MView = p7MView;
        }
        
        /// <summary>
        /// Search Options
        /// </summary>
        /// <value>Search Options</value>
        [DataMember(Name="search", EmitDefaultValue=false)]
        public UserSearchOptionDTO Search { get; set; }

        /// <summary>
        /// Possible values:  0: Code  1: Description 
        /// </summary>
        /// <value>Possible values:  0: Code  1: Description </value>
        [DataMember(Name="documentTypeViewMode", EmitDefaultValue=false)]
        public int? DocumentTypeViewMode { get; set; }

        /// <summary>
        /// Gets or Sets P7MView
        /// </summary>
        [DataMember(Name="p7MView", EmitDefaultValue=false)]
        public bool? P7MView { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserOptionsDto {\n");
            sb.Append("  Search: ").Append(Search).Append("\n");
            sb.Append("  DocumentTypeViewMode: ").Append(DocumentTypeViewMode).Append("\n");
            sb.Append("  P7MView: ").Append(P7MView).Append("\n");
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
            return this.Equals(input as UserOptionsDto);
        }

        /// <summary>
        /// Returns true if UserOptionsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of UserOptionsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserOptionsDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Search == input.Search ||
                    (this.Search != null &&
                    this.Search.Equals(input.Search))
                ) && 
                (
                    this.DocumentTypeViewMode == input.DocumentTypeViewMode ||
                    (this.DocumentTypeViewMode != null &&
                    this.DocumentTypeViewMode.Equals(input.DocumentTypeViewMode))
                ) && 
                (
                    this.P7MView == input.P7MView ||
                    (this.P7MView != null &&
                    this.P7MView.Equals(input.P7MView))
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
                if (this.Search != null)
                    hashCode = hashCode * 59 + this.Search.GetHashCode();
                if (this.DocumentTypeViewMode != null)
                    hashCode = hashCode * 59 + this.DocumentTypeViewMode.GetHashCode();
                if (this.P7MView != null)
                    hashCode = hashCode * 59 + this.P7MView.GetHashCode();
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

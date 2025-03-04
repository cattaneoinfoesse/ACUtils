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
    /// Class of users layout
    /// </summary>
    [DataContract]
    public partial class LayoutUsersDto :  IEquatable<LayoutUsersDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutUsersDto" /> class.
        /// </summary>
        /// <param name="layoutId">Layout Identifier.</param>
        /// <param name="userId">User Identifier.</param>
        /// <param name="completeName">User Name.</param>
        /// <param name="category">User Category.</param>
        /// <param name="isUserDisabled">isUserDisabled.</param>
        public LayoutUsersDto(int? layoutId = default(int?), int? userId = default(int?), string completeName = default(string), int? category = default(int?), bool? isUserDisabled = default(bool?))
        {
            this.LayoutId = layoutId;
            this.UserId = userId;
            this.CompleteName = completeName;
            this.Category = category;
            this.IsUserDisabled = isUserDisabled;
        }
        
        /// <summary>
        /// Layout Identifier
        /// </summary>
        /// <value>Layout Identifier</value>
        [DataMember(Name="layoutId", EmitDefaultValue=false)]
        public int? LayoutId { get; set; }

        /// <summary>
        /// User Identifier
        /// </summary>
        /// <value>User Identifier</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// User Name
        /// </summary>
        /// <value>User Name</value>
        [DataMember(Name="completeName", EmitDefaultValue=false)]
        public string CompleteName { get; set; }

        /// <summary>
        /// User Category
        /// </summary>
        /// <value>User Category</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public int? Category { get; set; }

        /// <summary>
        /// Gets or Sets IsUserDisabled
        /// </summary>
        [DataMember(Name="isUserDisabled", EmitDefaultValue=false)]
        public bool? IsUserDisabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LayoutUsersDto {\n");
            sb.Append("  LayoutId: ").Append(LayoutId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  CompleteName: ").Append(CompleteName).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  IsUserDisabled: ").Append(IsUserDisabled).Append("\n");
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
            return this.Equals(input as LayoutUsersDto);
        }

        /// <summary>
        /// Returns true if LayoutUsersDto instances are equal
        /// </summary>
        /// <param name="input">Instance of LayoutUsersDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LayoutUsersDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LayoutId == input.LayoutId ||
                    (this.LayoutId != null &&
                    this.LayoutId.Equals(input.LayoutId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.CompleteName == input.CompleteName ||
                    (this.CompleteName != null &&
                    this.CompleteName.Equals(input.CompleteName))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.IsUserDisabled == input.IsUserDisabled ||
                    (this.IsUserDisabled != null &&
                    this.IsUserDisabled.Equals(input.IsUserDisabled))
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
                if (this.LayoutId != null)
                    hashCode = hashCode * 59 + this.LayoutId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.CompleteName != null)
                    hashCode = hashCode * 59 + this.CompleteName.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.IsUserDisabled != null)
                    hashCode = hashCode * 59 + this.IsUserDisabled.GetHashCode();
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

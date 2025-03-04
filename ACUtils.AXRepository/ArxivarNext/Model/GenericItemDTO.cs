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
    /// Class of generic item
    /// </summary>
    [DataContract]
    public partial class GenericItemDTO :  IEquatable<GenericItemDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericItemDTO" /> class.
        /// </summary>
        /// <param name="itemId">Identifier.</param>
        /// <param name="itemType">Table Type.</param>
        /// <param name="description">Description.</param>
        /// <param name="addtionalInfo">Additional Field.</param>
        /// <param name="userDescription">User Name.</param>
        public GenericItemDTO(string itemId = default(string), int? itemType = default(int?), string description = default(string), string addtionalInfo = default(string), string userDescription = default(string))
        {
            this.ItemId = itemId;
            this.ItemType = itemType;
            this.Description = description;
            this.AddtionalInfo = addtionalInfo;
            this.UserDescription = userDescription;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="itemId", EmitDefaultValue=false)]
        public string ItemId { get; set; }

        /// <summary>
        /// Table Type
        /// </summary>
        /// <value>Table Type</value>
        [DataMember(Name="itemType", EmitDefaultValue=false)]
        public int? ItemType { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Additional Field
        /// </summary>
        /// <value>Additional Field</value>
        [DataMember(Name="addtionalInfo", EmitDefaultValue=false)]
        public string AddtionalInfo { get; set; }

        /// <summary>
        /// User Name
        /// </summary>
        /// <value>User Name</value>
        [DataMember(Name="userDescription", EmitDefaultValue=false)]
        public string UserDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenericItemDTO {\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  ItemType: ").Append(ItemType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AddtionalInfo: ").Append(AddtionalInfo).Append("\n");
            sb.Append("  UserDescription: ").Append(UserDescription).Append("\n");
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
            return this.Equals(input as GenericItemDTO);
        }

        /// <summary>
        /// Returns true if GenericItemDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of GenericItemDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenericItemDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.ItemType == input.ItemType ||
                    (this.ItemType != null &&
                    this.ItemType.Equals(input.ItemType))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.AddtionalInfo == input.AddtionalInfo ||
                    (this.AddtionalInfo != null &&
                    this.AddtionalInfo.Equals(input.AddtionalInfo))
                ) && 
                (
                    this.UserDescription == input.UserDescription ||
                    (this.UserDescription != null &&
                    this.UserDescription.Equals(input.UserDescription))
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
                if (this.ItemId != null)
                    hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.ItemType != null)
                    hashCode = hashCode * 59 + this.ItemType.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AddtionalInfo != null)
                    hashCode = hashCode * 59 + this.AddtionalInfo.GetHashCode();
                if (this.UserDescription != null)
                    hashCode = hashCode * 59 + this.UserDescription.GetHashCode();
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

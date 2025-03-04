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
    /// Class of rule of folder
    /// </summary>
    [DataContract]
    public partial class FolderCompositionRule :  IEquatable<FolderCompositionRule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderCompositionRule" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="folderId">Folder Identifier.</param>
        /// <param name="userId">User Identifier.</param>
        /// <param name="parseMode">Possible values:  0: ByPosition  1: BySeparator  2: None .</param>
        /// <param name="character">Character Separator.</param>
        /// <param name="creationDateTime">Creation Date.</param>
        /// <param name="compositionRuleDetails">Details.</param>
        public FolderCompositionRule(int? id = default(int?), int? folderId = default(int?), int? userId = default(int?), int? parseMode = default(int?), string character = default(string), DateTime? creationDateTime = default(DateTime?), List<FolderCompositionRuleDetail> compositionRuleDetails = default(List<FolderCompositionRuleDetail>))
        {
            this.Id = id;
            this.FolderId = folderId;
            this.UserId = userId;
            this.ParseMode = parseMode;
            this.Character = character;
            this.CreationDateTime = creationDateTime;
            this.CompositionRuleDetails = compositionRuleDetails;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Folder Identifier
        /// </summary>
        /// <value>Folder Identifier</value>
        [DataMember(Name="folderId", EmitDefaultValue=false)]
        public int? FolderId { get; set; }

        /// <summary>
        /// User Identifier
        /// </summary>
        /// <value>User Identifier</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Possible values:  0: ByPosition  1: BySeparator  2: None 
        /// </summary>
        /// <value>Possible values:  0: ByPosition  1: BySeparator  2: None </value>
        [DataMember(Name="parseMode", EmitDefaultValue=false)]
        public int? ParseMode { get; set; }

        /// <summary>
        /// Character Separator
        /// </summary>
        /// <value>Character Separator</value>
        [DataMember(Name="character", EmitDefaultValue=false)]
        public string Character { get; set; }

        /// <summary>
        /// Creation Date
        /// </summary>
        /// <value>Creation Date</value>
        [DataMember(Name="creationDateTime", EmitDefaultValue=false)]
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Details
        /// </summary>
        /// <value>Details</value>
        [DataMember(Name="compositionRuleDetails", EmitDefaultValue=false)]
        public List<FolderCompositionRuleDetail> CompositionRuleDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FolderCompositionRule {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ParseMode: ").Append(ParseMode).Append("\n");
            sb.Append("  Character: ").Append(Character).Append("\n");
            sb.Append("  CreationDateTime: ").Append(CreationDateTime).Append("\n");
            sb.Append("  CompositionRuleDetails: ").Append(CompositionRuleDetails).Append("\n");
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
            return this.Equals(input as FolderCompositionRule);
        }

        /// <summary>
        /// Returns true if FolderCompositionRule instances are equal
        /// </summary>
        /// <param name="input">Instance of FolderCompositionRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FolderCompositionRule input)
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
                    this.FolderId == input.FolderId ||
                    (this.FolderId != null &&
                    this.FolderId.Equals(input.FolderId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.ParseMode == input.ParseMode ||
                    (this.ParseMode != null &&
                    this.ParseMode.Equals(input.ParseMode))
                ) && 
                (
                    this.Character == input.Character ||
                    (this.Character != null &&
                    this.Character.Equals(input.Character))
                ) && 
                (
                    this.CreationDateTime == input.CreationDateTime ||
                    (this.CreationDateTime != null &&
                    this.CreationDateTime.Equals(input.CreationDateTime))
                ) && 
                (
                    this.CompositionRuleDetails == input.CompositionRuleDetails ||
                    this.CompositionRuleDetails != null &&
                    this.CompositionRuleDetails.SequenceEqual(input.CompositionRuleDetails)
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
                if (this.FolderId != null)
                    hashCode = hashCode * 59 + this.FolderId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.ParseMode != null)
                    hashCode = hashCode * 59 + this.ParseMode.GetHashCode();
                if (this.Character != null)
                    hashCode = hashCode * 59 + this.Character.GetHashCode();
                if (this.CreationDateTime != null)
                    hashCode = hashCode * 59 + this.CreationDateTime.GetHashCode();
                if (this.CompositionRuleDetails != null)
                    hashCode = hashCode * 59 + this.CompositionRuleDetails.GetHashCode();
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

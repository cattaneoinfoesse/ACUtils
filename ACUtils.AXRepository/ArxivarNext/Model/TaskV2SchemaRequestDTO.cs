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
    /// Schema request for task V2
    /// </summary>
    [DataContract]
    public partial class TaskV2SchemaRequestDTO :  IEquatable<TaskV2SchemaRequestDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskV2SchemaRequestDTO" /> class.
        /// </summary>
        /// <param name="docnumber">Docnumber.</param>
        /// <param name="maskId">Mask identifier.</param>
        /// <param name="allowEditProfileLockedFields">Allow edit profile locked fields.</param>
        /// <param name="switched">Switched.</param>
        public TaskV2SchemaRequestDTO(int? docnumber = default(int?), string maskId = default(string), bool? allowEditProfileLockedFields = default(bool?), bool? switched = default(bool?))
        {
            this.Docnumber = docnumber;
            this.MaskId = maskId;
            this.AllowEditProfileLockedFields = allowEditProfileLockedFields;
            this.Switched = switched;
        }
        
        /// <summary>
        /// Docnumber
        /// </summary>
        /// <value>Docnumber</value>
        [DataMember(Name="docnumber", EmitDefaultValue=false)]
        public int? Docnumber { get; set; }

        /// <summary>
        /// Mask identifier
        /// </summary>
        /// <value>Mask identifier</value>
        [DataMember(Name="maskId", EmitDefaultValue=false)]
        public string MaskId { get; set; }

        /// <summary>
        /// Allow edit profile locked fields
        /// </summary>
        /// <value>Allow edit profile locked fields</value>
        [DataMember(Name="allowEditProfileLockedFields", EmitDefaultValue=false)]
        public bool? AllowEditProfileLockedFields { get; set; }

        /// <summary>
        /// Switched
        /// </summary>
        /// <value>Switched</value>
        [DataMember(Name="switched", EmitDefaultValue=false)]
        public bool? Switched { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskV2SchemaRequestDTO {\n");
            sb.Append("  Docnumber: ").Append(Docnumber).Append("\n");
            sb.Append("  MaskId: ").Append(MaskId).Append("\n");
            sb.Append("  AllowEditProfileLockedFields: ").Append(AllowEditProfileLockedFields).Append("\n");
            sb.Append("  Switched: ").Append(Switched).Append("\n");
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
            return this.Equals(input as TaskV2SchemaRequestDTO);
        }

        /// <summary>
        /// Returns true if TaskV2SchemaRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskV2SchemaRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskV2SchemaRequestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Docnumber == input.Docnumber ||
                    (this.Docnumber != null &&
                    this.Docnumber.Equals(input.Docnumber))
                ) && 
                (
                    this.MaskId == input.MaskId ||
                    (this.MaskId != null &&
                    this.MaskId.Equals(input.MaskId))
                ) && 
                (
                    this.AllowEditProfileLockedFields == input.AllowEditProfileLockedFields ||
                    (this.AllowEditProfileLockedFields != null &&
                    this.AllowEditProfileLockedFields.Equals(input.AllowEditProfileLockedFields))
                ) && 
                (
                    this.Switched == input.Switched ||
                    (this.Switched != null &&
                    this.Switched.Equals(input.Switched))
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
                if (this.Docnumber != null)
                    hashCode = hashCode * 59 + this.Docnumber.GetHashCode();
                if (this.MaskId != null)
                    hashCode = hashCode * 59 + this.MaskId.GetHashCode();
                if (this.AllowEditProfileLockedFields != null)
                    hashCode = hashCode * 59 + this.AllowEditProfileLockedFields.GetHashCode();
                if (this.Switched != null)
                    hashCode = hashCode * 59 + this.Switched.GetHashCode();
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

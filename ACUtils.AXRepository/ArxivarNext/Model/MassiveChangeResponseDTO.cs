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
    /// Response class for new massive change inserted
    /// </summary>
    [DataContract]
    public partial class MassiveChangeResponseDTO :  IEquatable<MassiveChangeResponseDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MassiveChangeResponseDTO" /> class.
        /// </summary>
        /// <param name="massiveChangeRequestId">Identifier of massive change in progress.</param>
        public MassiveChangeResponseDTO(string massiveChangeRequestId = default(string))
        {
            this.MassiveChangeRequestId = massiveChangeRequestId;
        }
        
        /// <summary>
        /// Identifier of massive change in progress
        /// </summary>
        /// <value>Identifier of massive change in progress</value>
        [DataMember(Name="massiveChangeRequestId", EmitDefaultValue=false)]
        public string MassiveChangeRequestId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MassiveChangeResponseDTO {\n");
            sb.Append("  MassiveChangeRequestId: ").Append(MassiveChangeRequestId).Append("\n");
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
            return this.Equals(input as MassiveChangeResponseDTO);
        }

        /// <summary>
        /// Returns true if MassiveChangeResponseDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MassiveChangeResponseDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MassiveChangeResponseDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MassiveChangeRequestId == input.MassiveChangeRequestId ||
                    (this.MassiveChangeRequestId != null &&
                    this.MassiveChangeRequestId.Equals(input.MassiveChangeRequestId))
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
                if (this.MassiveChangeRequestId != null)
                    hashCode = hashCode * 59 + this.MassiveChangeRequestId.GetHashCode();
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

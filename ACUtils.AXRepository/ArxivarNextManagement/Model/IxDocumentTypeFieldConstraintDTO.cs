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
    /// Class of Ix document type field constraint
    /// </summary>
    [DataContract]
    public partial class IxDocumentTypeFieldConstraintDTO :  IEquatable<IxDocumentTypeFieldConstraintDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IxDocumentTypeFieldConstraintDTO" /> class.
        /// </summary>
        /// <param name="type">Possible values:  0: Required  1: Unique  2: ReadyOnly  3: Uneditable .</param>
        public IxDocumentTypeFieldConstraintDTO(int? type = default(int?))
        {
            this.Type = type;
        }
        
        /// <summary>
        /// Possible values:  0: Required  1: Unique  2: ReadyOnly  3: Uneditable 
        /// </summary>
        /// <value>Possible values:  0: Required  1: Unique  2: ReadyOnly  3: Uneditable </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IxDocumentTypeFieldConstraintDTO {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as IxDocumentTypeFieldConstraintDTO);
        }

        /// <summary>
        /// Returns true if IxDocumentTypeFieldConstraintDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of IxDocumentTypeFieldConstraintDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IxDocumentTypeFieldConstraintDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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

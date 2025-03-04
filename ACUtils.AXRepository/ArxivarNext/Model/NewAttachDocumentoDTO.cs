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
    /// NewAttachDocumentoDTO
    /// </summary>
    [DataContract]
    public partial class NewAttachDocumentoDTO : EmailDocumentDTO,  IEquatable<NewAttachDocumentoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAttachDocumentoDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewAttachDocumentoDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAttachDocumentoDTO" /> class.
        /// </summary>
        /// <param name="cacheIdentifier">Buffer document identifier.</param>
        public NewAttachDocumentoDTO(string cacheIdentifier = default(string), string className = "NewAttachDocumentoDTO") : base(className)
        {
            this.CacheIdentifier = cacheIdentifier;
        }
        
        /// <summary>
        /// Buffer document identifier
        /// </summary>
        /// <value>Buffer document identifier</value>
        [DataMember(Name="cacheIdentifier", EmitDefaultValue=false)]
        public string CacheIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewAttachDocumentoDTO {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  CacheIdentifier: ").Append(CacheIdentifier).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as NewAttachDocumentoDTO);
        }

        /// <summary>
        /// Returns true if NewAttachDocumentoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of NewAttachDocumentoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewAttachDocumentoDTO input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.CacheIdentifier == input.CacheIdentifier ||
                    (this.CacheIdentifier != null &&
                    this.CacheIdentifier.Equals(input.CacheIdentifier))
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
                int hashCode = base.GetHashCode();
                if (this.CacheIdentifier != null)
                    hashCode = hashCode * 59 + this.CacheIdentifier.GetHashCode();
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}

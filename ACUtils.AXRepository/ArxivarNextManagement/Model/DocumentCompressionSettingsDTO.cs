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
    /// DocumentCompressionSettingsDTO
    /// </summary>
    [DataContract]
    public partial class DocumentCompressionSettingsDTO :  IEquatable<DocumentCompressionSettingsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentCompressionSettingsDTO" /> class.
        /// </summary>
        /// <param name="compressionExtensionExclusionList">Compression expluded extension list. * indicates all extensions.</param>
        /// <param name="noCompressGreaterThanMB">Documents grater than will not be compressed.</param>
        /// <param name="noCompressSmallerThanMB">Documents smaller than will not be compressed.</param>
        public DocumentCompressionSettingsDTO(List<string> compressionExtensionExclusionList = default(List<string>), int? noCompressGreaterThanMB = default(int?), int? noCompressSmallerThanMB = default(int?))
        {
            this.CompressionExtensionExclusionList = compressionExtensionExclusionList;
            this.NoCompressGreaterThanMB = noCompressGreaterThanMB;
            this.NoCompressSmallerThanMB = noCompressSmallerThanMB;
        }
        
        /// <summary>
        /// Compression expluded extension list. * indicates all extensions
        /// </summary>
        /// <value>Compression expluded extension list. * indicates all extensions</value>
        [DataMember(Name="compressionExtensionExclusionList", EmitDefaultValue=false)]
        public List<string> CompressionExtensionExclusionList { get; set; }

        /// <summary>
        /// Documents grater than will not be compressed
        /// </summary>
        /// <value>Documents grater than will not be compressed</value>
        [DataMember(Name="noCompressGreaterThanMB", EmitDefaultValue=false)]
        public int? NoCompressGreaterThanMB { get; set; }

        /// <summary>
        /// Documents smaller than will not be compressed
        /// </summary>
        /// <value>Documents smaller than will not be compressed</value>
        [DataMember(Name="noCompressSmallerThanMB", EmitDefaultValue=false)]
        public int? NoCompressSmallerThanMB { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentCompressionSettingsDTO {\n");
            sb.Append("  CompressionExtensionExclusionList: ").Append(CompressionExtensionExclusionList).Append("\n");
            sb.Append("  NoCompressGreaterThanMB: ").Append(NoCompressGreaterThanMB).Append("\n");
            sb.Append("  NoCompressSmallerThanMB: ").Append(NoCompressSmallerThanMB).Append("\n");
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
            return this.Equals(input as DocumentCompressionSettingsDTO);
        }

        /// <summary>
        /// Returns true if DocumentCompressionSettingsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentCompressionSettingsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentCompressionSettingsDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompressionExtensionExclusionList == input.CompressionExtensionExclusionList ||
                    this.CompressionExtensionExclusionList != null &&
                    this.CompressionExtensionExclusionList.SequenceEqual(input.CompressionExtensionExclusionList)
                ) && 
                (
                    this.NoCompressGreaterThanMB == input.NoCompressGreaterThanMB ||
                    (this.NoCompressGreaterThanMB != null &&
                    this.NoCompressGreaterThanMB.Equals(input.NoCompressGreaterThanMB))
                ) && 
                (
                    this.NoCompressSmallerThanMB == input.NoCompressSmallerThanMB ||
                    (this.NoCompressSmallerThanMB != null &&
                    this.NoCompressSmallerThanMB.Equals(input.NoCompressSmallerThanMB))
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
                if (this.CompressionExtensionExclusionList != null)
                    hashCode = hashCode * 59 + this.CompressionExtensionExclusionList.GetHashCode();
                if (this.NoCompressGreaterThanMB != null)
                    hashCode = hashCode * 59 + this.NoCompressGreaterThanMB.GetHashCode();
                if (this.NoCompressSmallerThanMB != null)
                    hashCode = hashCode * 59 + this.NoCompressSmallerThanMB.GetHashCode();
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

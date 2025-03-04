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
    /// Class file dto
    /// </summary>
    [DataContract]
    public partial class FileDTO :  IEquatable<FileDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileDTO" /> class.
        /// </summary>
        /// <param name="fileNames">Filename list.</param>
        /// <param name="bufferIds">Buffer id list.</param>
        public FileDTO(List<string> fileNames = default(List<string>), List<string> bufferIds = default(List<string>))
        {
            this.FileNames = fileNames;
            this.BufferIds = bufferIds;
        }
        
        /// <summary>
        /// Filename list
        /// </summary>
        /// <value>Filename list</value>
        [DataMember(Name="fileNames", EmitDefaultValue=false)]
        public List<string> FileNames { get; set; }

        /// <summary>
        /// Buffer id list
        /// </summary>
        /// <value>Buffer id list</value>
        [DataMember(Name="bufferIds", EmitDefaultValue=false)]
        public List<string> BufferIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileDTO {\n");
            sb.Append("  FileNames: ").Append(FileNames).Append("\n");
            sb.Append("  BufferIds: ").Append(BufferIds).Append("\n");
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
            return this.Equals(input as FileDTO);
        }

        /// <summary>
        /// Returns true if FileDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of FileDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileNames == input.FileNames ||
                    this.FileNames != null &&
                    this.FileNames.SequenceEqual(input.FileNames)
                ) && 
                (
                    this.BufferIds == input.BufferIds ||
                    this.BufferIds != null &&
                    this.BufferIds.SequenceEqual(input.BufferIds)
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
                if (this.FileNames != null)
                    hashCode = hashCode * 59 + this.FileNames.GetHashCode();
                if (this.BufferIds != null)
                    hashCode = hashCode * 59 + this.BufferIds.GetHashCode();
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

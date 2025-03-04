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
    /// Class of report execute async response
    /// </summary>
    [DataContract]
    public partial class ReportExecuteAsyncResponseDTO :  IEquatable<ReportExecuteAsyncResponseDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportExecuteAsyncResponseDTO" /> class.
        /// </summary>
        /// <param name="asyncRequestId">Identifier of asynchronous activity (QueueId).</param>
        public ReportExecuteAsyncResponseDTO(string asyncRequestId = default(string))
        {
            this.AsyncRequestId = asyncRequestId;
        }
        
        /// <summary>
        /// Identifier of asynchronous activity (QueueId)
        /// </summary>
        /// <value>Identifier of asynchronous activity (QueueId)</value>
        [DataMember(Name="asyncRequestId", EmitDefaultValue=false)]
        public string AsyncRequestId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportExecuteAsyncResponseDTO {\n");
            sb.Append("  AsyncRequestId: ").Append(AsyncRequestId).Append("\n");
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
            return this.Equals(input as ReportExecuteAsyncResponseDTO);
        }

        /// <summary>
        /// Returns true if ReportExecuteAsyncResponseDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportExecuteAsyncResponseDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportExecuteAsyncResponseDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AsyncRequestId == input.AsyncRequestId ||
                    (this.AsyncRequestId != null &&
                    this.AsyncRequestId.Equals(input.AsyncRequestId))
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
                if (this.AsyncRequestId != null)
                    hashCode = hashCode * 59 + this.AsyncRequestId.GetHashCode();
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

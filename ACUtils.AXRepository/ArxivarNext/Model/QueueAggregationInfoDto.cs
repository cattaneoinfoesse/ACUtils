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
    /// Class of queue aggregation information
    /// </summary>
    [DataContract]
    public partial class QueueAggregationInfoDto :  IEquatable<QueueAggregationInfoDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueAggregationInfoDto" /> class.
        /// </summary>
        /// <param name="queueId">Queue Identifier.</param>
        /// <param name="queueName">Queue Name.</param>
        /// <param name="queueType">Queue Type.</param>
        /// <param name="createdAt">Creation Date.</param>
        /// <param name="expireAt">Expiration Date.</param>
        /// <param name="workItemCount">Items.</param>
        /// <param name="stateCount">Status of items.</param>
        public QueueAggregationInfoDto(string queueId = default(string), string queueName = default(string), string queueType = default(string), DateTime? createdAt = default(DateTime?), DateTime? expireAt = default(DateTime?), int? workItemCount = default(int?), QueueStateAggregationInfoDto stateCount = default(QueueStateAggregationInfoDto))
        {
            this.QueueId = queueId;
            this.QueueName = queueName;
            this.QueueType = queueType;
            this.CreatedAt = createdAt;
            this.ExpireAt = expireAt;
            this.WorkItemCount = workItemCount;
            this.StateCount = stateCount;
        }
        
        /// <summary>
        /// Queue Identifier
        /// </summary>
        /// <value>Queue Identifier</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }

        /// <summary>
        /// Queue Name
        /// </summary>
        /// <value>Queue Name</value>
        [DataMember(Name="queueName", EmitDefaultValue=false)]
        public string QueueName { get; set; }

        /// <summary>
        /// Queue Type
        /// </summary>
        /// <value>Queue Type</value>
        [DataMember(Name="queueType", EmitDefaultValue=false)]
        public string QueueType { get; set; }

        /// <summary>
        /// Creation Date
        /// </summary>
        /// <value>Creation Date</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Expiration Date
        /// </summary>
        /// <value>Expiration Date</value>
        [DataMember(Name="expireAt", EmitDefaultValue=false)]
        public DateTime? ExpireAt { get; set; }

        /// <summary>
        /// Items
        /// </summary>
        /// <value>Items</value>
        [DataMember(Name="workItemCount", EmitDefaultValue=false)]
        public int? WorkItemCount { get; set; }

        /// <summary>
        /// Status of items
        /// </summary>
        /// <value>Status of items</value>
        [DataMember(Name="stateCount", EmitDefaultValue=false)]
        public QueueStateAggregationInfoDto StateCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueAggregationInfoDto {\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  QueueName: ").Append(QueueName).Append("\n");
            sb.Append("  QueueType: ").Append(QueueType).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ExpireAt: ").Append(ExpireAt).Append("\n");
            sb.Append("  WorkItemCount: ").Append(WorkItemCount).Append("\n");
            sb.Append("  StateCount: ").Append(StateCount).Append("\n");
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
            return this.Equals(input as QueueAggregationInfoDto);
        }

        /// <summary>
        /// Returns true if QueueAggregationInfoDto instances are equal
        /// </summary>
        /// <param name="input">Instance of QueueAggregationInfoDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueAggregationInfoDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QueueId == input.QueueId ||
                    (this.QueueId != null &&
                    this.QueueId.Equals(input.QueueId))
                ) && 
                (
                    this.QueueName == input.QueueName ||
                    (this.QueueName != null &&
                    this.QueueName.Equals(input.QueueName))
                ) && 
                (
                    this.QueueType == input.QueueType ||
                    (this.QueueType != null &&
                    this.QueueType.Equals(input.QueueType))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.ExpireAt == input.ExpireAt ||
                    (this.ExpireAt != null &&
                    this.ExpireAt.Equals(input.ExpireAt))
                ) && 
                (
                    this.WorkItemCount == input.WorkItemCount ||
                    (this.WorkItemCount != null &&
                    this.WorkItemCount.Equals(input.WorkItemCount))
                ) && 
                (
                    this.StateCount == input.StateCount ||
                    (this.StateCount != null &&
                    this.StateCount.Equals(input.StateCount))
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
                if (this.QueueId != null)
                    hashCode = hashCode * 59 + this.QueueId.GetHashCode();
                if (this.QueueName != null)
                    hashCode = hashCode * 59 + this.QueueName.GetHashCode();
                if (this.QueueType != null)
                    hashCode = hashCode * 59 + this.QueueType.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ExpireAt != null)
                    hashCode = hashCode * 59 + this.ExpireAt.GetHashCode();
                if (this.WorkItemCount != null)
                    hashCode = hashCode * 59 + this.WorkItemCount.GetHashCode();
                if (this.StateCount != null)
                    hashCode = hashCode * 59 + this.StateCount.GetHashCode();
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

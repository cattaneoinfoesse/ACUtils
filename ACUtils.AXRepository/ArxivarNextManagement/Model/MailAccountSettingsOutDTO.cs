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
    /// Class for Mail OUT settings
    /// </summary>
    [DataContract]
    public partial class MailAccountSettingsOutDTO :  IEquatable<MailAccountSettingsOutDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailAccountSettingsOutDTO" /> class.
        /// </summary>
        /// <param name="mailWithInternalDestination">Possible values:  1: Always  2: Never  3: Manual .</param>
        /// <param name="mailWithExternalDestination">Possible values:  1: Always  2: Never  3: Manual .</param>
        /// <param name="documentType">Default document type.</param>
        /// <param name="outState">Default state.</param>
        /// <param name="mailOutDefault">Archive mail with default data.</param>
        /// <param name="monitoredFolder">Monitored folder path.</param>
        public MailAccountSettingsOutDTO(int? mailWithInternalDestination = default(int?), int? mailWithExternalDestination = default(int?), DocumentTypeSimpleDTO documentType = default(DocumentTypeSimpleDTO), StateSimpleDTO outState = default(StateSimpleDTO), bool? mailOutDefault = default(bool?), string monitoredFolder = default(string))
        {
            this.MailWithInternalDestination = mailWithInternalDestination;
            this.MailWithExternalDestination = mailWithExternalDestination;
            this.DocumentType = documentType;
            this.OutState = outState;
            this.MailOutDefault = mailOutDefault;
            this.MonitoredFolder = monitoredFolder;
        }
        
        /// <summary>
        /// Possible values:  1: Always  2: Never  3: Manual 
        /// </summary>
        /// <value>Possible values:  1: Always  2: Never  3: Manual </value>
        [DataMember(Name="mailWithInternalDestination", EmitDefaultValue=false)]
        public int? MailWithInternalDestination { get; set; }

        /// <summary>
        /// Possible values:  1: Always  2: Never  3: Manual 
        /// </summary>
        /// <value>Possible values:  1: Always  2: Never  3: Manual </value>
        [DataMember(Name="mailWithExternalDestination", EmitDefaultValue=false)]
        public int? MailWithExternalDestination { get; set; }

        /// <summary>
        /// Default document type
        /// </summary>
        /// <value>Default document type</value>
        [DataMember(Name="documentType", EmitDefaultValue=false)]
        public DocumentTypeSimpleDTO DocumentType { get; set; }

        /// <summary>
        /// Default state
        /// </summary>
        /// <value>Default state</value>
        [DataMember(Name="outState", EmitDefaultValue=false)]
        public StateSimpleDTO OutState { get; set; }

        /// <summary>
        /// Archive mail with default data
        /// </summary>
        /// <value>Archive mail with default data</value>
        [DataMember(Name="mailOutDefault", EmitDefaultValue=false)]
        public bool? MailOutDefault { get; set; }

        /// <summary>
        /// Monitored folder path
        /// </summary>
        /// <value>Monitored folder path</value>
        [DataMember(Name="monitoredFolder", EmitDefaultValue=false)]
        public string MonitoredFolder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MailAccountSettingsOutDTO {\n");
            sb.Append("  MailWithInternalDestination: ").Append(MailWithInternalDestination).Append("\n");
            sb.Append("  MailWithExternalDestination: ").Append(MailWithExternalDestination).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  OutState: ").Append(OutState).Append("\n");
            sb.Append("  MailOutDefault: ").Append(MailOutDefault).Append("\n");
            sb.Append("  MonitoredFolder: ").Append(MonitoredFolder).Append("\n");
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
            return this.Equals(input as MailAccountSettingsOutDTO);
        }

        /// <summary>
        /// Returns true if MailAccountSettingsOutDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MailAccountSettingsOutDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MailAccountSettingsOutDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MailWithInternalDestination == input.MailWithInternalDestination ||
                    (this.MailWithInternalDestination != null &&
                    this.MailWithInternalDestination.Equals(input.MailWithInternalDestination))
                ) && 
                (
                    this.MailWithExternalDestination == input.MailWithExternalDestination ||
                    (this.MailWithExternalDestination != null &&
                    this.MailWithExternalDestination.Equals(input.MailWithExternalDestination))
                ) && 
                (
                    this.DocumentType == input.DocumentType ||
                    (this.DocumentType != null &&
                    this.DocumentType.Equals(input.DocumentType))
                ) && 
                (
                    this.OutState == input.OutState ||
                    (this.OutState != null &&
                    this.OutState.Equals(input.OutState))
                ) && 
                (
                    this.MailOutDefault == input.MailOutDefault ||
                    (this.MailOutDefault != null &&
                    this.MailOutDefault.Equals(input.MailOutDefault))
                ) && 
                (
                    this.MonitoredFolder == input.MonitoredFolder ||
                    (this.MonitoredFolder != null &&
                    this.MonitoredFolder.Equals(input.MonitoredFolder))
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
                if (this.MailWithInternalDestination != null)
                    hashCode = hashCode * 59 + this.MailWithInternalDestination.GetHashCode();
                if (this.MailWithExternalDestination != null)
                    hashCode = hashCode * 59 + this.MailWithExternalDestination.GetHashCode();
                if (this.DocumentType != null)
                    hashCode = hashCode * 59 + this.DocumentType.GetHashCode();
                if (this.OutState != null)
                    hashCode = hashCode * 59 + this.OutState.GetHashCode();
                if (this.MailOutDefault != null)
                    hashCode = hashCode * 59 + this.MailOutDefault.GetHashCode();
                if (this.MonitoredFolder != null)
                    hashCode = hashCode * 59 + this.MonitoredFolder.GetHashCode();
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

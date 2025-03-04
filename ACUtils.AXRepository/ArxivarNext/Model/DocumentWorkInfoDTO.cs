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
    /// Class of document of workflow process
    /// </summary>
    [DataContract]
    public partial class DocumentWorkInfoDTO :  IEquatable<DocumentWorkInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentWorkInfoDTO" /> class.
        /// </summary>
        /// <param name="processDocId">Document Process Identifier.</param>
        /// <param name="docnumber">Document Identifier.</param>
        /// <param name="processDocRevision">Document Process Revision.</param>
        /// <param name="state">Possible values:  0: Secondario  1: Principale .</param>
        /// <param name="important">Important.</param>
        /// <param name="processDocDate">Creation Date of Document Process.</param>
        /// <param name="currentRevision">Document Revision.</param>
        /// <param name="userCompleteName">User Description.</param>
        /// <param name="internalProtocol">Internal Protocol Number.</param>
        /// <param name="dataDoc">Document Date.</param>
        /// <param name="subject">Document Subject.</param>
        public DocumentWorkInfoDTO(int? processDocId = default(int?), int? docnumber = default(int?), int? processDocRevision = default(int?), int? state = default(int?), bool? important = default(bool?), DateTime? processDocDate = default(DateTime?), int? currentRevision = default(int?), string userCompleteName = default(string), string internalProtocol = default(string), DateTime? dataDoc = default(DateTime?), string subject = default(string))
        {
            this.ProcessDocId = processDocId;
            this.Docnumber = docnumber;
            this.ProcessDocRevision = processDocRevision;
            this.State = state;
            this.Important = important;
            this.ProcessDocDate = processDocDate;
            this.CurrentRevision = currentRevision;
            this.UserCompleteName = userCompleteName;
            this.InternalProtocol = internalProtocol;
            this.DataDoc = dataDoc;
            this.Subject = subject;
        }
        
        /// <summary>
        /// Document Process Identifier
        /// </summary>
        /// <value>Document Process Identifier</value>
        [DataMember(Name="processDocId", EmitDefaultValue=false)]
        public int? ProcessDocId { get; set; }

        /// <summary>
        /// Document Identifier
        /// </summary>
        /// <value>Document Identifier</value>
        [DataMember(Name="docnumber", EmitDefaultValue=false)]
        public int? Docnumber { get; set; }

        /// <summary>
        /// Document Process Revision
        /// </summary>
        /// <value>Document Process Revision</value>
        [DataMember(Name="processDocRevision", EmitDefaultValue=false)]
        public int? ProcessDocRevision { get; set; }

        /// <summary>
        /// Possible values:  0: Secondario  1: Principale 
        /// </summary>
        /// <value>Possible values:  0: Secondario  1: Principale </value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public int? State { get; set; }

        /// <summary>
        /// Important
        /// </summary>
        /// <value>Important</value>
        [DataMember(Name="important", EmitDefaultValue=false)]
        public bool? Important { get; set; }

        /// <summary>
        /// Creation Date of Document Process
        /// </summary>
        /// <value>Creation Date of Document Process</value>
        [DataMember(Name="processDocDate", EmitDefaultValue=false)]
        public DateTime? ProcessDocDate { get; set; }

        /// <summary>
        /// Document Revision
        /// </summary>
        /// <value>Document Revision</value>
        [DataMember(Name="currentRevision", EmitDefaultValue=false)]
        public int? CurrentRevision { get; set; }

        /// <summary>
        /// User Description
        /// </summary>
        /// <value>User Description</value>
        [DataMember(Name="userCompleteName", EmitDefaultValue=false)]
        public string UserCompleteName { get; set; }

        /// <summary>
        /// Internal Protocol Number
        /// </summary>
        /// <value>Internal Protocol Number</value>
        [DataMember(Name="internalProtocol", EmitDefaultValue=false)]
        public string InternalProtocol { get; set; }

        /// <summary>
        /// Document Date
        /// </summary>
        /// <value>Document Date</value>
        [DataMember(Name="dataDoc", EmitDefaultValue=false)]
        public DateTime? DataDoc { get; set; }

        /// <summary>
        /// Document Subject
        /// </summary>
        /// <value>Document Subject</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentWorkInfoDTO {\n");
            sb.Append("  ProcessDocId: ").Append(ProcessDocId).Append("\n");
            sb.Append("  Docnumber: ").Append(Docnumber).Append("\n");
            sb.Append("  ProcessDocRevision: ").Append(ProcessDocRevision).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Important: ").Append(Important).Append("\n");
            sb.Append("  ProcessDocDate: ").Append(ProcessDocDate).Append("\n");
            sb.Append("  CurrentRevision: ").Append(CurrentRevision).Append("\n");
            sb.Append("  UserCompleteName: ").Append(UserCompleteName).Append("\n");
            sb.Append("  InternalProtocol: ").Append(InternalProtocol).Append("\n");
            sb.Append("  DataDoc: ").Append(DataDoc).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
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
            return this.Equals(input as DocumentWorkInfoDTO);
        }

        /// <summary>
        /// Returns true if DocumentWorkInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentWorkInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentWorkInfoDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProcessDocId == input.ProcessDocId ||
                    (this.ProcessDocId != null &&
                    this.ProcessDocId.Equals(input.ProcessDocId))
                ) && 
                (
                    this.Docnumber == input.Docnumber ||
                    (this.Docnumber != null &&
                    this.Docnumber.Equals(input.Docnumber))
                ) && 
                (
                    this.ProcessDocRevision == input.ProcessDocRevision ||
                    (this.ProcessDocRevision != null &&
                    this.ProcessDocRevision.Equals(input.ProcessDocRevision))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Important == input.Important ||
                    (this.Important != null &&
                    this.Important.Equals(input.Important))
                ) && 
                (
                    this.ProcessDocDate == input.ProcessDocDate ||
                    (this.ProcessDocDate != null &&
                    this.ProcessDocDate.Equals(input.ProcessDocDate))
                ) && 
                (
                    this.CurrentRevision == input.CurrentRevision ||
                    (this.CurrentRevision != null &&
                    this.CurrentRevision.Equals(input.CurrentRevision))
                ) && 
                (
                    this.UserCompleteName == input.UserCompleteName ||
                    (this.UserCompleteName != null &&
                    this.UserCompleteName.Equals(input.UserCompleteName))
                ) && 
                (
                    this.InternalProtocol == input.InternalProtocol ||
                    (this.InternalProtocol != null &&
                    this.InternalProtocol.Equals(input.InternalProtocol))
                ) && 
                (
                    this.DataDoc == input.DataDoc ||
                    (this.DataDoc != null &&
                    this.DataDoc.Equals(input.DataDoc))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
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
                if (this.ProcessDocId != null)
                    hashCode = hashCode * 59 + this.ProcessDocId.GetHashCode();
                if (this.Docnumber != null)
                    hashCode = hashCode * 59 + this.Docnumber.GetHashCode();
                if (this.ProcessDocRevision != null)
                    hashCode = hashCode * 59 + this.ProcessDocRevision.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Important != null)
                    hashCode = hashCode * 59 + this.Important.GetHashCode();
                if (this.ProcessDocDate != null)
                    hashCode = hashCode * 59 + this.ProcessDocDate.GetHashCode();
                if (this.CurrentRevision != null)
                    hashCode = hashCode * 59 + this.CurrentRevision.GetHashCode();
                if (this.UserCompleteName != null)
                    hashCode = hashCode * 59 + this.UserCompleteName.GetHashCode();
                if (this.InternalProtocol != null)
                    hashCode = hashCode * 59 + this.InternalProtocol.GetHashCode();
                if (this.DataDoc != null)
                    hashCode = hashCode * 59 + this.DataDoc.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
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

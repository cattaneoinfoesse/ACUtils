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
    /// Class of signature certificate to update
    /// </summary>
    [DataContract]
    public partial class SignCertUpdateDTO :  IEquatable<SignCertUpdateDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignCertUpdateDTO" /> class.
        /// </summary>
        /// <param name="certId">Certificate Identifier.</param>
        /// <param name="requestOtp">Request OTP.</param>
        /// <param name="certDescription">Certificate Description.</param>
        /// <param name="delegante">Delegating.</param>
        public SignCertUpdateDTO(string certId = default(string), bool? requestOtp = default(bool?), string certDescription = default(string), string delegante = default(string))
        {
            this.CertId = certId;
            this.RequestOtp = requestOtp;
            this.CertDescription = certDescription;
            this.Delegante = delegante;
        }
        
        /// <summary>
        /// Certificate Identifier
        /// </summary>
        /// <value>Certificate Identifier</value>
        [DataMember(Name="certId", EmitDefaultValue=false)]
        public string CertId { get; set; }

        /// <summary>
        /// Request OTP
        /// </summary>
        /// <value>Request OTP</value>
        [DataMember(Name="requestOtp", EmitDefaultValue=false)]
        public bool? RequestOtp { get; set; }

        /// <summary>
        /// Certificate Description
        /// </summary>
        /// <value>Certificate Description</value>
        [DataMember(Name="certDescription", EmitDefaultValue=false)]
        public string CertDescription { get; set; }

        /// <summary>
        /// Delegating
        /// </summary>
        /// <value>Delegating</value>
        [DataMember(Name="delegante", EmitDefaultValue=false)]
        public string Delegante { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignCertUpdateDTO {\n");
            sb.Append("  CertId: ").Append(CertId).Append("\n");
            sb.Append("  RequestOtp: ").Append(RequestOtp).Append("\n");
            sb.Append("  CertDescription: ").Append(CertDescription).Append("\n");
            sb.Append("  Delegante: ").Append(Delegante).Append("\n");
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
            return this.Equals(input as SignCertUpdateDTO);
        }

        /// <summary>
        /// Returns true if SignCertUpdateDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SignCertUpdateDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignCertUpdateDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CertId == input.CertId ||
                    (this.CertId != null &&
                    this.CertId.Equals(input.CertId))
                ) && 
                (
                    this.RequestOtp == input.RequestOtp ||
                    (this.RequestOtp != null &&
                    this.RequestOtp.Equals(input.RequestOtp))
                ) && 
                (
                    this.CertDescription == input.CertDescription ||
                    (this.CertDescription != null &&
                    this.CertDescription.Equals(input.CertDescription))
                ) && 
                (
                    this.Delegante == input.Delegante ||
                    (this.Delegante != null &&
                    this.Delegante.Equals(input.Delegante))
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
                if (this.CertId != null)
                    hashCode = hashCode * 59 + this.CertId.GetHashCode();
                if (this.RequestOtp != null)
                    hashCode = hashCode * 59 + this.RequestOtp.GetHashCode();
                if (this.CertDescription != null)
                    hashCode = hashCode * 59 + this.CertDescription.GetHashCode();
                if (this.Delegante != null)
                    hashCode = hashCode * 59 + this.Delegante.GetHashCode();
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

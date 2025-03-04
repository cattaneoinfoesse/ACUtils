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
    /// IxFeSignCredential
    /// </summary>
    [DataContract]
    public partial class IxFeSignCredential :  IEquatable<IxFeSignCredential>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IxFeSignCredential" /> class.
        /// </summary>
        /// <param name="signCertId">Identifier of signature certificate.</param>
        /// <param name="password">Password.</param>
        /// <param name="relatedCertId">Releted Cetificate Identifier.</param>
        /// <param name="otp">OPT.</param>
        public IxFeSignCredential(int? signCertId = default(int?), string password = default(string), string relatedCertId = default(string), string otp = default(string))
        {
            this.SignCertId = signCertId;
            this.Password = password;
            this.RelatedCertId = relatedCertId;
            this.Otp = otp;
        }
        
        /// <summary>
        /// Identifier of signature certificate
        /// </summary>
        /// <value>Identifier of signature certificate</value>
        [DataMember(Name="signCertId", EmitDefaultValue=false)]
        public int? SignCertId { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        /// <value>Password</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Releted Cetificate Identifier
        /// </summary>
        /// <value>Releted Cetificate Identifier</value>
        [DataMember(Name="relatedCertId", EmitDefaultValue=false)]
        public string RelatedCertId { get; set; }

        /// <summary>
        /// OPT
        /// </summary>
        /// <value>OPT</value>
        [DataMember(Name="otp", EmitDefaultValue=false)]
        public string Otp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IxFeSignCredential {\n");
            sb.Append("  SignCertId: ").Append(SignCertId).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  RelatedCertId: ").Append(RelatedCertId).Append("\n");
            sb.Append("  Otp: ").Append(Otp).Append("\n");
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
            return this.Equals(input as IxFeSignCredential);
        }

        /// <summary>
        /// Returns true if IxFeSignCredential instances are equal
        /// </summary>
        /// <param name="input">Instance of IxFeSignCredential to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IxFeSignCredential input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SignCertId == input.SignCertId ||
                    (this.SignCertId != null &&
                    this.SignCertId.Equals(input.SignCertId))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.RelatedCertId == input.RelatedCertId ||
                    (this.RelatedCertId != null &&
                    this.RelatedCertId.Equals(input.RelatedCertId))
                ) && 
                (
                    this.Otp == input.Otp ||
                    (this.Otp != null &&
                    this.Otp.Equals(input.Otp))
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
                if (this.SignCertId != null)
                    hashCode = hashCode * 59 + this.SignCertId.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.RelatedCertId != null)
                    hashCode = hashCode * 59 + this.RelatedCertId.GetHashCode();
                if (this.Otp != null)
                    hashCode = hashCode * 59 + this.Otp.GetHashCode();
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

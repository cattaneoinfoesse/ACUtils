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
    /// Class of timestamp
    /// </summary>
    [DataContract]
    public partial class TsaDTO :  IEquatable<TsaDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsaDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="description">Description.</param>
        /// <param name="url">Url Address.</param>
        /// <param name="username">Account Name.</param>
        /// <param name="passwordIsSet">Password is set.</param>
        /// <param name="enabled">Enabled.</param>
        /// <param name="port">Port Number.</param>
        /// <param name="executeRoleName">Role Name.</param>
        /// <param name="hashAlgorithm">Possible values:  0: SHA1  1: SHA256 .</param>
        /// <param name="protocolType">Timespamp Protocol.</param>
        public TsaDTO(string id = default(string), string description = default(string), string url = default(string), string username = default(string), bool? passwordIsSet = default(bool?), bool? enabled = default(bool?), int? port = default(int?), string executeRoleName = default(string), int? hashAlgorithm = default(int?), TsaProtocolDTO protocolType = default(TsaProtocolDTO))
        {
            this.Id = id;
            this.Description = description;
            this.Url = url;
            this.Username = username;
            this.PasswordIsSet = passwordIsSet;
            this.Enabled = enabled;
            this.Port = port;
            this.ExecuteRoleName = executeRoleName;
            this.HashAlgorithm = hashAlgorithm;
            this.ProtocolType = protocolType;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Url Address
        /// </summary>
        /// <value>Url Address</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Account Name
        /// </summary>
        /// <value>Account Name</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Password is set
        /// </summary>
        /// <value>Password is set</value>
        [DataMember(Name="passwordIsSet", EmitDefaultValue=false)]
        public bool? PasswordIsSet { get; set; }

        /// <summary>
        /// Enabled
        /// </summary>
        /// <value>Enabled</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Port Number
        /// </summary>
        /// <value>Port Number</value>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public int? Port { get; set; }

        /// <summary>
        /// Role Name
        /// </summary>
        /// <value>Role Name</value>
        [DataMember(Name="executeRoleName", EmitDefaultValue=false)]
        public string ExecuteRoleName { get; set; }

        /// <summary>
        /// Possible values:  0: SHA1  1: SHA256 
        /// </summary>
        /// <value>Possible values:  0: SHA1  1: SHA256 </value>
        [DataMember(Name="hashAlgorithm", EmitDefaultValue=false)]
        public int? HashAlgorithm { get; set; }

        /// <summary>
        /// Timespamp Protocol
        /// </summary>
        /// <value>Timespamp Protocol</value>
        [DataMember(Name="protocolType", EmitDefaultValue=false)]
        public TsaProtocolDTO ProtocolType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsaDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  PasswordIsSet: ").Append(PasswordIsSet).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  ExecuteRoleName: ").Append(ExecuteRoleName).Append("\n");
            sb.Append("  HashAlgorithm: ").Append(HashAlgorithm).Append("\n");
            sb.Append("  ProtocolType: ").Append(ProtocolType).Append("\n");
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
            return this.Equals(input as TsaDTO);
        }

        /// <summary>
        /// Returns true if TsaDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TsaDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsaDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.PasswordIsSet == input.PasswordIsSet ||
                    (this.PasswordIsSet != null &&
                    this.PasswordIsSet.Equals(input.PasswordIsSet))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.ExecuteRoleName == input.ExecuteRoleName ||
                    (this.ExecuteRoleName != null &&
                    this.ExecuteRoleName.Equals(input.ExecuteRoleName))
                ) && 
                (
                    this.HashAlgorithm == input.HashAlgorithm ||
                    (this.HashAlgorithm != null &&
                    this.HashAlgorithm.Equals(input.HashAlgorithm))
                ) && 
                (
                    this.ProtocolType == input.ProtocolType ||
                    (this.ProtocolType != null &&
                    this.ProtocolType.Equals(input.ProtocolType))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.PasswordIsSet != null)
                    hashCode = hashCode * 59 + this.PasswordIsSet.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.ExecuteRoleName != null)
                    hashCode = hashCode * 59 + this.ExecuteRoleName.GetHashCode();
                if (this.HashAlgorithm != null)
                    hashCode = hashCode * 59 + this.HashAlgorithm.GetHashCode();
                if (this.ProtocolType != null)
                    hashCode = hashCode * 59 + this.ProtocolType.GetHashCode();
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

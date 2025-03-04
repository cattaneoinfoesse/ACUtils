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
    /// Class of access token
    /// </summary>
    [DataContract]
    public partial class AccessTokenInfoDTO :  IEquatable<AccessTokenInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessTokenInfoDTO" /> class.
        /// </summary>
        /// <param name="accessToken">Access Token.</param>
        /// <param name="refreshTokenToken">Refresh Token.</param>
        /// <param name="tokenType">Token Type.</param>
        /// <param name="authPropertyList">Properties.</param>
        /// <param name="expiresUtc">Expires.</param>
        /// <param name="issuedUtc">Issued.</param>
        /// <param name="isPersistent">Authentication Persistent.</param>
        /// <param name="claimInfoList">Claims.</param>
        /// <param name="arxUserMustChangePassword">Passeord Change.</param>
        /// <param name="error">Error Message.</param>
        public AccessTokenInfoDTO(string accessToken = default(string), string refreshTokenToken = default(string), string tokenType = default(string), List<AuthPropertyInfoDTO> authPropertyList = default(List<AuthPropertyInfoDTO>), DateTime? expiresUtc = default(DateTime?), DateTime? issuedUtc = default(DateTime?), bool? isPersistent = default(bool?), List<ClaimInfoDTO> claimInfoList = default(List<ClaimInfoDTO>), bool? arxUserMustChangePassword = default(bool?), MessageErrorDTO error = default(MessageErrorDTO))
        {
            this.AccessToken = accessToken;
            this.RefreshTokenToken = refreshTokenToken;
            this.TokenType = tokenType;
            this.AuthPropertyList = authPropertyList;
            this.ExpiresUtc = expiresUtc;
            this.IssuedUtc = issuedUtc;
            this.IsPersistent = isPersistent;
            this.ClaimInfoList = claimInfoList;
            this.ArxUserMustChangePassword = arxUserMustChangePassword;
            this.Error = error;
        }
        
        /// <summary>
        /// Access Token
        /// </summary>
        /// <value>Access Token</value>
        [DataMember(Name="accessToken", EmitDefaultValue=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Refresh Token
        /// </summary>
        /// <value>Refresh Token</value>
        [DataMember(Name="refreshTokenToken", EmitDefaultValue=false)]
        public string RefreshTokenToken { get; set; }

        /// <summary>
        /// Token Type
        /// </summary>
        /// <value>Token Type</value>
        [DataMember(Name="tokenType", EmitDefaultValue=false)]
        public string TokenType { get; set; }

        /// <summary>
        /// Properties
        /// </summary>
        /// <value>Properties</value>
        [DataMember(Name="authPropertyList", EmitDefaultValue=false)]
        public List<AuthPropertyInfoDTO> AuthPropertyList { get; set; }

        /// <summary>
        /// Expires
        /// </summary>
        /// <value>Expires</value>
        [DataMember(Name="expiresUtc", EmitDefaultValue=false)]
        public DateTime? ExpiresUtc { get; set; }

        /// <summary>
        /// Issued
        /// </summary>
        /// <value>Issued</value>
        [DataMember(Name="issuedUtc", EmitDefaultValue=false)]
        public DateTime? IssuedUtc { get; set; }

        /// <summary>
        /// Authentication Persistent
        /// </summary>
        /// <value>Authentication Persistent</value>
        [DataMember(Name="isPersistent", EmitDefaultValue=false)]
        public bool? IsPersistent { get; set; }

        /// <summary>
        /// Claims
        /// </summary>
        /// <value>Claims</value>
        [DataMember(Name="claimInfoList", EmitDefaultValue=false)]
        public List<ClaimInfoDTO> ClaimInfoList { get; set; }

        /// <summary>
        /// Passeord Change
        /// </summary>
        /// <value>Passeord Change</value>
        [DataMember(Name="arxUserMustChangePassword", EmitDefaultValue=false)]
        public bool? ArxUserMustChangePassword { get; set; }

        /// <summary>
        /// Error Message
        /// </summary>
        /// <value>Error Message</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public MessageErrorDTO Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessTokenInfoDTO {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  RefreshTokenToken: ").Append(RefreshTokenToken).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  AuthPropertyList: ").Append(AuthPropertyList).Append("\n");
            sb.Append("  ExpiresUtc: ").Append(ExpiresUtc).Append("\n");
            sb.Append("  IssuedUtc: ").Append(IssuedUtc).Append("\n");
            sb.Append("  IsPersistent: ").Append(IsPersistent).Append("\n");
            sb.Append("  ClaimInfoList: ").Append(ClaimInfoList).Append("\n");
            sb.Append("  ArxUserMustChangePassword: ").Append(ArxUserMustChangePassword).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return this.Equals(input as AccessTokenInfoDTO);
        }

        /// <summary>
        /// Returns true if AccessTokenInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessTokenInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessTokenInfoDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    this.RefreshTokenToken == input.RefreshTokenToken ||
                    (this.RefreshTokenToken != null &&
                    this.RefreshTokenToken.Equals(input.RefreshTokenToken))
                ) && 
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))
                ) && 
                (
                    this.AuthPropertyList == input.AuthPropertyList ||
                    this.AuthPropertyList != null &&
                    this.AuthPropertyList.SequenceEqual(input.AuthPropertyList)
                ) && 
                (
                    this.ExpiresUtc == input.ExpiresUtc ||
                    (this.ExpiresUtc != null &&
                    this.ExpiresUtc.Equals(input.ExpiresUtc))
                ) && 
                (
                    this.IssuedUtc == input.IssuedUtc ||
                    (this.IssuedUtc != null &&
                    this.IssuedUtc.Equals(input.IssuedUtc))
                ) && 
                (
                    this.IsPersistent == input.IsPersistent ||
                    (this.IsPersistent != null &&
                    this.IsPersistent.Equals(input.IsPersistent))
                ) && 
                (
                    this.ClaimInfoList == input.ClaimInfoList ||
                    this.ClaimInfoList != null &&
                    this.ClaimInfoList.SequenceEqual(input.ClaimInfoList)
                ) && 
                (
                    this.ArxUserMustChangePassword == input.ArxUserMustChangePassword ||
                    (this.ArxUserMustChangePassword != null &&
                    this.ArxUserMustChangePassword.Equals(input.ArxUserMustChangePassword))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
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
                if (this.AccessToken != null)
                    hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                if (this.RefreshTokenToken != null)
                    hashCode = hashCode * 59 + this.RefreshTokenToken.GetHashCode();
                if (this.TokenType != null)
                    hashCode = hashCode * 59 + this.TokenType.GetHashCode();
                if (this.AuthPropertyList != null)
                    hashCode = hashCode * 59 + this.AuthPropertyList.GetHashCode();
                if (this.ExpiresUtc != null)
                    hashCode = hashCode * 59 + this.ExpiresUtc.GetHashCode();
                if (this.IssuedUtc != null)
                    hashCode = hashCode * 59 + this.IssuedUtc.GetHashCode();
                if (this.IsPersistent != null)
                    hashCode = hashCode * 59 + this.IsPersistent.GetHashCode();
                if (this.ClaimInfoList != null)
                    hashCode = hashCode * 59 + this.ClaimInfoList.GetHashCode();
                if (this.ArxUserMustChangePassword != null)
                    hashCode = hashCode * 59 + this.ArxUserMustChangePassword.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
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

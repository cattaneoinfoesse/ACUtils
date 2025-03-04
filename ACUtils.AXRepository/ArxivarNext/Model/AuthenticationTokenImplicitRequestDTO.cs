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
    /// Authentication token request for implicit authentication
    /// </summary>
    [DataContract]
    public partial class AuthenticationTokenImplicitRequestDTO :  IEquatable<AuthenticationTokenImplicitRequestDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationTokenImplicitRequestDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthenticationTokenImplicitRequestDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationTokenImplicitRequestDTO" /> class.
        /// </summary>
        /// <param name="clientId">Client id (required).</param>
        /// <param name="clientSecret">Client secret (required).</param>
        /// <param name="logonProviderId">Logon provider for authentication (existing association required).</param>
        /// <param name="impersonateUserId">Impersonate user id.</param>
        /// <param name="impersonateExternalId">Impersonate user by externalId.</param>
        /// <param name="clientVersion">Client version.</param>
        /// <param name="machineKey">Machine Key.</param>
        /// <param name="languageCultureName">Language.</param>
        /// <param name="successRedirectUri">Url for success redirect.</param>
        /// <param name="scopeList">Request scope list.</param>
        /// <param name="clientIpAddress">Request client Ip.</param>
        public AuthenticationTokenImplicitRequestDTO(string clientId = default(string), string clientSecret = default(string), string logonProviderId = default(string), int? impersonateUserId = default(int?), string impersonateExternalId = default(string), string clientVersion = default(string), string machineKey = default(string), string languageCultureName = default(string), string successRedirectUri = default(string), List<string> scopeList = default(List<string>), string clientIpAddress = default(string))
        {
            // to ensure "clientId" is required (not null)
            if (clientId == null)
            {
                throw new InvalidDataException("clientId is a required property for AuthenticationTokenImplicitRequestDTO and cannot be null");
            }
            else
            {
                this.ClientId = clientId;
            }
            // to ensure "clientSecret" is required (not null)
            if (clientSecret == null)
            {
                throw new InvalidDataException("clientSecret is a required property for AuthenticationTokenImplicitRequestDTO and cannot be null");
            }
            else
            {
                this.ClientSecret = clientSecret;
            }
            this.LogonProviderId = logonProviderId;
            this.ImpersonateUserId = impersonateUserId;
            this.ImpersonateExternalId = impersonateExternalId;
            this.ClientVersion = clientVersion;
            this.MachineKey = machineKey;
            this.LanguageCultureName = languageCultureName;
            this.SuccessRedirectUri = successRedirectUri;
            this.ScopeList = scopeList;
            this.ClientIpAddress = clientIpAddress;
        }
        
        /// <summary>
        /// Client id
        /// </summary>
        /// <value>Client id</value>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Client secret
        /// </summary>
        /// <value>Client secret</value>
        [DataMember(Name="clientSecret", EmitDefaultValue=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Logon provider for authentication (existing association required)
        /// </summary>
        /// <value>Logon provider for authentication (existing association required)</value>
        [DataMember(Name="logonProviderId", EmitDefaultValue=false)]
        public string LogonProviderId { get; set; }

        /// <summary>
        /// Impersonate user id
        /// </summary>
        /// <value>Impersonate user id</value>
        [DataMember(Name="impersonateUserId", EmitDefaultValue=false)]
        public int? ImpersonateUserId { get; set; }

        /// <summary>
        /// Impersonate user by externalId
        /// </summary>
        /// <value>Impersonate user by externalId</value>
        [DataMember(Name="impersonateExternalId", EmitDefaultValue=false)]
        public string ImpersonateExternalId { get; set; }

        /// <summary>
        /// Client version
        /// </summary>
        /// <value>Client version</value>
        [DataMember(Name="clientVersion", EmitDefaultValue=false)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// Machine Key
        /// </summary>
        /// <value>Machine Key</value>
        [DataMember(Name="machineKey", EmitDefaultValue=false)]
        public string MachineKey { get; set; }

        /// <summary>
        /// Language
        /// </summary>
        /// <value>Language</value>
        [DataMember(Name="languageCultureName", EmitDefaultValue=false)]
        public string LanguageCultureName { get; set; }

        /// <summary>
        /// Url for success redirect
        /// </summary>
        /// <value>Url for success redirect</value>
        [DataMember(Name="successRedirectUri", EmitDefaultValue=false)]
        public string SuccessRedirectUri { get; set; }

        /// <summary>
        /// Request scope list
        /// </summary>
        /// <value>Request scope list</value>
        [DataMember(Name="scopeList", EmitDefaultValue=false)]
        public List<string> ScopeList { get; set; }

        /// <summary>
        /// Request client Ip
        /// </summary>
        /// <value>Request client Ip</value>
        [DataMember(Name="clientIpAddress", EmitDefaultValue=false)]
        public string ClientIpAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticationTokenImplicitRequestDTO {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  LogonProviderId: ").Append(LogonProviderId).Append("\n");
            sb.Append("  ImpersonateUserId: ").Append(ImpersonateUserId).Append("\n");
            sb.Append("  ImpersonateExternalId: ").Append(ImpersonateExternalId).Append("\n");
            sb.Append("  ClientVersion: ").Append(ClientVersion).Append("\n");
            sb.Append("  MachineKey: ").Append(MachineKey).Append("\n");
            sb.Append("  LanguageCultureName: ").Append(LanguageCultureName).Append("\n");
            sb.Append("  SuccessRedirectUri: ").Append(SuccessRedirectUri).Append("\n");
            sb.Append("  ScopeList: ").Append(ScopeList).Append("\n");
            sb.Append("  ClientIpAddress: ").Append(ClientIpAddress).Append("\n");
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
            return this.Equals(input as AuthenticationTokenImplicitRequestDTO);
        }

        /// <summary>
        /// Returns true if AuthenticationTokenImplicitRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthenticationTokenImplicitRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticationTokenImplicitRequestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.ClientSecret == input.ClientSecret ||
                    (this.ClientSecret != null &&
                    this.ClientSecret.Equals(input.ClientSecret))
                ) && 
                (
                    this.LogonProviderId == input.LogonProviderId ||
                    (this.LogonProviderId != null &&
                    this.LogonProviderId.Equals(input.LogonProviderId))
                ) && 
                (
                    this.ImpersonateUserId == input.ImpersonateUserId ||
                    (this.ImpersonateUserId != null &&
                    this.ImpersonateUserId.Equals(input.ImpersonateUserId))
                ) && 
                (
                    this.ImpersonateExternalId == input.ImpersonateExternalId ||
                    (this.ImpersonateExternalId != null &&
                    this.ImpersonateExternalId.Equals(input.ImpersonateExternalId))
                ) && 
                (
                    this.ClientVersion == input.ClientVersion ||
                    (this.ClientVersion != null &&
                    this.ClientVersion.Equals(input.ClientVersion))
                ) && 
                (
                    this.MachineKey == input.MachineKey ||
                    (this.MachineKey != null &&
                    this.MachineKey.Equals(input.MachineKey))
                ) && 
                (
                    this.LanguageCultureName == input.LanguageCultureName ||
                    (this.LanguageCultureName != null &&
                    this.LanguageCultureName.Equals(input.LanguageCultureName))
                ) && 
                (
                    this.SuccessRedirectUri == input.SuccessRedirectUri ||
                    (this.SuccessRedirectUri != null &&
                    this.SuccessRedirectUri.Equals(input.SuccessRedirectUri))
                ) && 
                (
                    this.ScopeList == input.ScopeList ||
                    this.ScopeList != null &&
                    this.ScopeList.SequenceEqual(input.ScopeList)
                ) && 
                (
                    this.ClientIpAddress == input.ClientIpAddress ||
                    (this.ClientIpAddress != null &&
                    this.ClientIpAddress.Equals(input.ClientIpAddress))
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
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.ClientSecret != null)
                    hashCode = hashCode * 59 + this.ClientSecret.GetHashCode();
                if (this.LogonProviderId != null)
                    hashCode = hashCode * 59 + this.LogonProviderId.GetHashCode();
                if (this.ImpersonateUserId != null)
                    hashCode = hashCode * 59 + this.ImpersonateUserId.GetHashCode();
                if (this.ImpersonateExternalId != null)
                    hashCode = hashCode * 59 + this.ImpersonateExternalId.GetHashCode();
                if (this.ClientVersion != null)
                    hashCode = hashCode * 59 + this.ClientVersion.GetHashCode();
                if (this.MachineKey != null)
                    hashCode = hashCode * 59 + this.MachineKey.GetHashCode();
                if (this.LanguageCultureName != null)
                    hashCode = hashCode * 59 + this.LanguageCultureName.GetHashCode();
                if (this.SuccessRedirectUri != null)
                    hashCode = hashCode * 59 + this.SuccessRedirectUri.GetHashCode();
                if (this.ScopeList != null)
                    hashCode = hashCode * 59 + this.ScopeList.GetHashCode();
                if (this.ClientIpAddress != null)
                    hashCode = hashCode * 59 + this.ClientIpAddress.GetHashCode();
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

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
    /// Class for external application configuration
    /// </summary>
    [DataContract]
    public partial class ExternalAppDTO :  IEquatable<ExternalAppDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalAppDTO" /> class.
        /// </summary>
        /// <param name="id">Application identifier.</param>
        /// <param name="type">Possible values:  0: Office365 .</param>
        /// <param name="name">Application name.</param>
        /// <param name="description">Application description.</param>
        /// <param name="clientId">Client Id.</param>
        /// <param name="enabled">Enabled configuration.</param>
        /// <param name="profilationModes">Profilation modes.</param>
        public ExternalAppDTO(int? id = default(int?), int? type = default(int?), string name = default(string), string description = default(string), string clientId = default(string), bool? enabled = default(bool?), List<ExternalAppProfilationModeDTO> profilationModes = default(List<ExternalAppProfilationModeDTO>))
        {
            this.Id = id;
            this.Type = type;
            this.Name = name;
            this.Description = description;
            this.ClientId = clientId;
            this.Enabled = enabled;
            this.ProfilationModes = profilationModes;
        }
        
        /// <summary>
        /// Application identifier
        /// </summary>
        /// <value>Application identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Possible values:  0: Office365 
        /// </summary>
        /// <value>Possible values:  0: Office365 </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

        /// <summary>
        /// Application name
        /// </summary>
        /// <value>Application name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Application description
        /// </summary>
        /// <value>Application description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Client Id
        /// </summary>
        /// <value>Client Id</value>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Enabled configuration
        /// </summary>
        /// <value>Enabled configuration</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Profilation modes
        /// </summary>
        /// <value>Profilation modes</value>
        [DataMember(Name="profilationModes", EmitDefaultValue=false)]
        public List<ExternalAppProfilationModeDTO> ProfilationModes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalAppDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  ProfilationModes: ").Append(ProfilationModes).Append("\n");
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
            return this.Equals(input as ExternalAppDTO);
        }

        /// <summary>
        /// Returns true if ExternalAppDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ExternalAppDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalAppDTO input)
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.ProfilationModes == input.ProfilationModes ||
                    this.ProfilationModes != null &&
                    this.ProfilationModes.SequenceEqual(input.ProfilationModes)
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.ProfilationModes != null)
                    hashCode = hashCode * 59 + this.ProfilationModes.GetHashCode();
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

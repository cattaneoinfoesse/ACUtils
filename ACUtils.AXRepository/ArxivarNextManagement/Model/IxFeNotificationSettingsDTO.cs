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
    /// Class of IX-FE notification settings
    /// </summary>
    [DataContract]
    public partial class IxFeNotificationSettingsDTO :  IEquatable<IxFeNotificationSettingsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IxFeNotificationSettingsDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="predefinedProfile">Predefined profile.</param>
        /// <param name="mapping">Mapping.</param>
        /// <param name="context">Possible values:  0: Internal  1: Sending  2: Receiving .</param>
        /// <param name="type">Notification type.</param>
        /// <param name="state">State.</param>
        public IxFeNotificationSettingsDTO(int? id = default(int?), PredefinedProfileSimpleDTO predefinedProfile = default(PredefinedProfileSimpleDTO), List<IxFeNotificationMappingDTO> mapping = default(List<IxFeNotificationMappingDTO>), int? context = default(int?), IxFeNotificationDTO type = default(IxFeNotificationDTO), StateSimpleDTO state = default(StateSimpleDTO))
        {
            this.Id = id;
            this.PredefinedProfile = predefinedProfile;
            this.Mapping = mapping;
            this.Context = context;
            this.Type = type;
            this.State = state;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Predefined profile
        /// </summary>
        /// <value>Predefined profile</value>
        [DataMember(Name="predefinedProfile", EmitDefaultValue=false)]
        public PredefinedProfileSimpleDTO PredefinedProfile { get; set; }

        /// <summary>
        /// Mapping
        /// </summary>
        /// <value>Mapping</value>
        [DataMember(Name="mapping", EmitDefaultValue=false)]
        public List<IxFeNotificationMappingDTO> Mapping { get; set; }

        /// <summary>
        /// Possible values:  0: Internal  1: Sending  2: Receiving 
        /// </summary>
        /// <value>Possible values:  0: Internal  1: Sending  2: Receiving </value>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public int? Context { get; set; }

        /// <summary>
        /// Notification type
        /// </summary>
        /// <value>Notification type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public IxFeNotificationDTO Type { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateSimpleDTO State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IxFeNotificationSettingsDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PredefinedProfile: ").Append(PredefinedProfile).Append("\n");
            sb.Append("  Mapping: ").Append(Mapping).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as IxFeNotificationSettingsDTO);
        }

        /// <summary>
        /// Returns true if IxFeNotificationSettingsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of IxFeNotificationSettingsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IxFeNotificationSettingsDTO input)
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
                    this.PredefinedProfile == input.PredefinedProfile ||
                    (this.PredefinedProfile != null &&
                    this.PredefinedProfile.Equals(input.PredefinedProfile))
                ) && 
                (
                    this.Mapping == input.Mapping ||
                    this.Mapping != null &&
                    this.Mapping.SequenceEqual(input.Mapping)
                ) && 
                (
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.PredefinedProfile != null)
                    hashCode = hashCode * 59 + this.PredefinedProfile.GetHashCode();
                if (this.Mapping != null)
                    hashCode = hashCode * 59 + this.Mapping.GetHashCode();
                if (this.Context != null)
                    hashCode = hashCode * 59 + this.Context.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
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

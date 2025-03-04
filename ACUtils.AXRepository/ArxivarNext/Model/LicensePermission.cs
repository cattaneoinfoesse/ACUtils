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
    /// LicensePermission
    /// </summary>
    [DataContract]
    public partial class LicensePermission :  IEquatable<LicensePermission>, IValidatableObject
    {
        /// <summary>
        /// Defines Mode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeEnum
        {
            
            /// <summary>
            /// Enum Deny for value: Deny
            /// </summary>
            [EnumMember(Value = "Deny")]
            Deny = 1,
            
            /// <summary>
            /// Enum Allow for value: Allow
            /// </summary>
            [EnumMember(Value = "Allow")]
            Allow = 2
        }

        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public ModeEnum? Mode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LicensePermission" /> class.
        /// </summary>
        /// <param name="mode">mode.</param>
        /// <param name="name">name.</param>
        /// <param name="specification">specification.</param>
        /// <param name="utcDateTime">utcDateTime.</param>
        /// <param name="values">values.</param>
        /// <param name="value">value.</param>
        public LicensePermission(ModeEnum? mode = default(ModeEnum?), string name = default(string), string specification = default(string), DateTime? utcDateTime = default(DateTime?), List<string> values = default(List<string>), string value = default(string))
        {
            this.Mode = mode;
            this.Name = name;
            this.Specification = specification;
            this.UtcDateTime = utcDateTime;
            this.Values = values;
            this.Value = value;
        }
        

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Specification
        /// </summary>
        [DataMember(Name="specification", EmitDefaultValue=false)]
        public string Specification { get; set; }

        /// <summary>
        /// Gets or Sets UtcDateTime
        /// </summary>
        [DataMember(Name="utcDateTime", EmitDefaultValue=false)]
        public DateTime? UtcDateTime { get; set; }

        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LicensePermission {\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Specification: ").Append(Specification).Append("\n");
            sb.Append("  UtcDateTime: ").Append(UtcDateTime).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as LicensePermission);
        }

        /// <summary>
        /// Returns true if LicensePermission instances are equal
        /// </summary>
        /// <param name="input">Instance of LicensePermission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicensePermission input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Specification == input.Specification ||
                    (this.Specification != null &&
                    this.Specification.Equals(input.Specification))
                ) && 
                (
                    this.UtcDateTime == input.UtcDateTime ||
                    (this.UtcDateTime != null &&
                    this.UtcDateTime.Equals(input.UtcDateTime))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Specification != null)
                    hashCode = hashCode * 59 + this.Specification.GetHashCode();
                if (this.UtcDateTime != null)
                    hashCode = hashCode * 59 + this.UtcDateTime.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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

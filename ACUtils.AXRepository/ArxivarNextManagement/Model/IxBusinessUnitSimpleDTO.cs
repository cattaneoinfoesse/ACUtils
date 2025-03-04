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
    /// Class of Ix Business Unit with essential data
    /// </summary>
    [DataContract]
    public partial class IxBusinessUnitSimpleDTO :  IEquatable<IxBusinessUnitSimpleDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IxBusinessUnitSimpleDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="description">Description.</param>
        /// <param name="vatCode">Vat code.</param>
        /// <param name="fiscalCode">Fiscal code.</param>
        public IxBusinessUnitSimpleDTO(string id = default(string), string description = default(string), string vatCode = default(string), string fiscalCode = default(string))
        {
            this.Id = id;
            this.Description = description;
            this.VatCode = vatCode;
            this.FiscalCode = fiscalCode;
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
        /// Vat code
        /// </summary>
        /// <value>Vat code</value>
        [DataMember(Name="vatCode", EmitDefaultValue=false)]
        public string VatCode { get; set; }

        /// <summary>
        /// Fiscal code
        /// </summary>
        /// <value>Fiscal code</value>
        [DataMember(Name="fiscalCode", EmitDefaultValue=false)]
        public string FiscalCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IxBusinessUnitSimpleDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  VatCode: ").Append(VatCode).Append("\n");
            sb.Append("  FiscalCode: ").Append(FiscalCode).Append("\n");
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
            return this.Equals(input as IxBusinessUnitSimpleDTO);
        }

        /// <summary>
        /// Returns true if IxBusinessUnitSimpleDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of IxBusinessUnitSimpleDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IxBusinessUnitSimpleDTO input)
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
                    this.VatCode == input.VatCode ||
                    (this.VatCode != null &&
                    this.VatCode.Equals(input.VatCode))
                ) && 
                (
                    this.FiscalCode == input.FiscalCode ||
                    (this.FiscalCode != null &&
                    this.FiscalCode.Equals(input.FiscalCode))
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
                if (this.VatCode != null)
                    hashCode = hashCode * 59 + this.VatCode.GetHashCode();
                if (this.FiscalCode != null)
                    hashCode = hashCode * 59 + this.FiscalCode.GetHashCode();
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

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
    /// Class for options for insert new Massive Change of profiles job
    /// </summary>
    [DataContract]
    public partial class MassiveChangeRequestDTO :  IEquatable<MassiveChangeRequestDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MassiveChangeRequestDTO" /> class.
        /// </summary>
        /// <param name="docnumbers">Docnumber to modify.</param>
        /// <param name="sendMailAtComplete">Indicates if the user want a mail message at the end of the operation.</param>
        /// <param name="fields">Fields.</param>
        public MassiveChangeRequestDTO(List<int?> docnumbers = default(List<int?>), bool? sendMailAtComplete = default(bool?), List<FieldBaseDTO> fields = default(List<FieldBaseDTO>))
        {
            this.Docnumbers = docnumbers;
            this.SendMailAtComplete = sendMailAtComplete;
            this.Fields = fields;
        }
        
        /// <summary>
        /// Docnumber to modify
        /// </summary>
        /// <value>Docnumber to modify</value>
        [DataMember(Name="docnumbers", EmitDefaultValue=false)]
        public List<int?> Docnumbers { get; set; }

        /// <summary>
        /// Indicates if the user want a mail message at the end of the operation
        /// </summary>
        /// <value>Indicates if the user want a mail message at the end of the operation</value>
        [DataMember(Name="sendMailAtComplete", EmitDefaultValue=false)]
        public bool? SendMailAtComplete { get; set; }

        /// <summary>
        /// Fields
        /// </summary>
        /// <value>Fields</value>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<FieldBaseDTO> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MassiveChangeRequestDTO {\n");
            sb.Append("  Docnumbers: ").Append(Docnumbers).Append("\n");
            sb.Append("  SendMailAtComplete: ").Append(SendMailAtComplete).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
            return this.Equals(input as MassiveChangeRequestDTO);
        }

        /// <summary>
        /// Returns true if MassiveChangeRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MassiveChangeRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MassiveChangeRequestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Docnumbers == input.Docnumbers ||
                    this.Docnumbers != null &&
                    this.Docnumbers.SequenceEqual(input.Docnumbers)
                ) && 
                (
                    this.SendMailAtComplete == input.SendMailAtComplete ||
                    (this.SendMailAtComplete != null &&
                    this.SendMailAtComplete.Equals(input.SendMailAtComplete))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
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
                if (this.Docnumbers != null)
                    hashCode = hashCode * 59 + this.Docnumbers.GetHashCode();
                if (this.SendMailAtComplete != null)
                    hashCode = hashCode * 59 + this.SendMailAtComplete.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
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

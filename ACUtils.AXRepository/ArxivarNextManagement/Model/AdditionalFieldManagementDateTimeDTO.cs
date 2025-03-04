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
    /// Class for additional field of type DateBox
    /// </summary>
    [DataContract]
    public partial class AdditionalFieldManagementDateTimeDTO : AdditionalFieldManagementBaseDTO,  IEquatable<AdditionalFieldManagementDateTimeDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalFieldManagementDateTimeDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdditionalFieldManagementDateTimeDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalFieldManagementDateTimeDTO" /> class.
        /// </summary>
        /// <param name="autocomplete">Autocomplete.</param>
        /// <param name="autocompleteCharacter">Autocomplete character.</param>
        /// <param name="autocompleteAlign">Possible values:  0: Left  1: Right  -1: None .</param>
        /// <param name="locked">Field locked (readonly).</param>
        /// <param name="transcoding">Enable field value encryption.</param>
        /// <param name="tableName">Enable field transcoding.</param>
        /// <param name="codeFieldName">Transcoding: Field name for code.</param>
        /// <param name="descriptionFieldName">Transcoding: Field name for description.</param>
        /// <param name="validationType">Possible values:  0: None  1: Regex  2: Formula .</param>
        /// <param name="validationString">Validation string (formula/regex).</param>
        public AdditionalFieldManagementDateTimeDTO(bool? autocomplete = default(bool?), string autocompleteCharacter = default(string), int? autocompleteAlign = default(int?), bool? locked = default(bool?), bool? transcoding = default(bool?), string tableName = default(string), string codeFieldName = default(string), string descriptionFieldName = default(string), int? validationType = default(int?), string validationString = default(string), string className = "AdditionalFieldManagementDateTimeDTO", string key = default(string), string description = default(string), FieldGroupSimpleDTO fieldGroup = default(FieldGroupSimpleDTO), DocumentTypeSimpleDTO documentType = default(DocumentTypeSimpleDTO), string referenceId = default(string), int? order = default(int?), bool? required = default(bool?), bool? visible = default(bool?), string externalId = default(string), string formula = default(string), List<AdditionalFieldManagementTranslationDTO> translations = default(List<AdditionalFieldManagementTranslationDTO>)) : base(className, key, description, fieldGroup, documentType, referenceId, order, required, visible, externalId, formula, translations)
        {
            this.Autocomplete = autocomplete;
            this.AutocompleteCharacter = autocompleteCharacter;
            this.AutocompleteAlign = autocompleteAlign;
            this.Locked = locked;
            this.Transcoding = transcoding;
            this.TableName = tableName;
            this.CodeFieldName = codeFieldName;
            this.DescriptionFieldName = descriptionFieldName;
            this.ValidationType = validationType;
            this.ValidationString = validationString;
        }
        
        /// <summary>
        /// Autocomplete
        /// </summary>
        /// <value>Autocomplete</value>
        [DataMember(Name="autocomplete", EmitDefaultValue=false)]
        public bool? Autocomplete { get; set; }

        /// <summary>
        /// Autocomplete character
        /// </summary>
        /// <value>Autocomplete character</value>
        [DataMember(Name="autocompleteCharacter", EmitDefaultValue=false)]
        public string AutocompleteCharacter { get; set; }

        /// <summary>
        /// Possible values:  0: Left  1: Right  -1: None 
        /// </summary>
        /// <value>Possible values:  0: Left  1: Right  -1: None </value>
        [DataMember(Name="autocompleteAlign", EmitDefaultValue=false)]
        public int? AutocompleteAlign { get; set; }

        /// <summary>
        /// Field locked (readonly)
        /// </summary>
        /// <value>Field locked (readonly)</value>
        [DataMember(Name="locked", EmitDefaultValue=false)]
        public bool? Locked { get; set; }

        /// <summary>
        /// Enable field value encryption
        /// </summary>
        /// <value>Enable field value encryption</value>
        [DataMember(Name="transcoding", EmitDefaultValue=false)]
        public bool? Transcoding { get; set; }

        /// <summary>
        /// Enable field transcoding
        /// </summary>
        /// <value>Enable field transcoding</value>
        [DataMember(Name="tableName", EmitDefaultValue=false)]
        public string TableName { get; set; }

        /// <summary>
        /// Transcoding: Field name for code
        /// </summary>
        /// <value>Transcoding: Field name for code</value>
        [DataMember(Name="codeFieldName", EmitDefaultValue=false)]
        public string CodeFieldName { get; set; }

        /// <summary>
        /// Transcoding: Field name for description
        /// </summary>
        /// <value>Transcoding: Field name for description</value>
        [DataMember(Name="descriptionFieldName", EmitDefaultValue=false)]
        public string DescriptionFieldName { get; set; }

        /// <summary>
        /// Possible values:  0: None  1: Regex  2: Formula 
        /// </summary>
        /// <value>Possible values:  0: None  1: Regex  2: Formula </value>
        [DataMember(Name="validationType", EmitDefaultValue=false)]
        public int? ValidationType { get; set; }

        /// <summary>
        /// Validation string (formula/regex)
        /// </summary>
        /// <value>Validation string (formula/regex)</value>
        [DataMember(Name="validationString", EmitDefaultValue=false)]
        public string ValidationString { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalFieldManagementDateTimeDTO {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Autocomplete: ").Append(Autocomplete).Append("\n");
            sb.Append("  AutocompleteCharacter: ").Append(AutocompleteCharacter).Append("\n");
            sb.Append("  AutocompleteAlign: ").Append(AutocompleteAlign).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  Transcoding: ").Append(Transcoding).Append("\n");
            sb.Append("  TableName: ").Append(TableName).Append("\n");
            sb.Append("  CodeFieldName: ").Append(CodeFieldName).Append("\n");
            sb.Append("  DescriptionFieldName: ").Append(DescriptionFieldName).Append("\n");
            sb.Append("  ValidationType: ").Append(ValidationType).Append("\n");
            sb.Append("  ValidationString: ").Append(ValidationString).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as AdditionalFieldManagementDateTimeDTO);
        }

        /// <summary>
        /// Returns true if AdditionalFieldManagementDateTimeDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalFieldManagementDateTimeDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalFieldManagementDateTimeDTO input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Autocomplete == input.Autocomplete ||
                    (this.Autocomplete != null &&
                    this.Autocomplete.Equals(input.Autocomplete))
                ) && base.Equals(input) && 
                (
                    this.AutocompleteCharacter == input.AutocompleteCharacter ||
                    (this.AutocompleteCharacter != null &&
                    this.AutocompleteCharacter.Equals(input.AutocompleteCharacter))
                ) && base.Equals(input) && 
                (
                    this.AutocompleteAlign == input.AutocompleteAlign ||
                    (this.AutocompleteAlign != null &&
                    this.AutocompleteAlign.Equals(input.AutocompleteAlign))
                ) && base.Equals(input) && 
                (
                    this.Locked == input.Locked ||
                    (this.Locked != null &&
                    this.Locked.Equals(input.Locked))
                ) && base.Equals(input) && 
                (
                    this.Transcoding == input.Transcoding ||
                    (this.Transcoding != null &&
                    this.Transcoding.Equals(input.Transcoding))
                ) && base.Equals(input) && 
                (
                    this.TableName == input.TableName ||
                    (this.TableName != null &&
                    this.TableName.Equals(input.TableName))
                ) && base.Equals(input) && 
                (
                    this.CodeFieldName == input.CodeFieldName ||
                    (this.CodeFieldName != null &&
                    this.CodeFieldName.Equals(input.CodeFieldName))
                ) && base.Equals(input) && 
                (
                    this.DescriptionFieldName == input.DescriptionFieldName ||
                    (this.DescriptionFieldName != null &&
                    this.DescriptionFieldName.Equals(input.DescriptionFieldName))
                ) && base.Equals(input) && 
                (
                    this.ValidationType == input.ValidationType ||
                    (this.ValidationType != null &&
                    this.ValidationType.Equals(input.ValidationType))
                ) && base.Equals(input) && 
                (
                    this.ValidationString == input.ValidationString ||
                    (this.ValidationString != null &&
                    this.ValidationString.Equals(input.ValidationString))
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
                int hashCode = base.GetHashCode();
                if (this.Autocomplete != null)
                    hashCode = hashCode * 59 + this.Autocomplete.GetHashCode();
                if (this.AutocompleteCharacter != null)
                    hashCode = hashCode * 59 + this.AutocompleteCharacter.GetHashCode();
                if (this.AutocompleteAlign != null)
                    hashCode = hashCode * 59 + this.AutocompleteAlign.GetHashCode();
                if (this.Locked != null)
                    hashCode = hashCode * 59 + this.Locked.GetHashCode();
                if (this.Transcoding != null)
                    hashCode = hashCode * 59 + this.Transcoding.GetHashCode();
                if (this.TableName != null)
                    hashCode = hashCode * 59 + this.TableName.GetHashCode();
                if (this.CodeFieldName != null)
                    hashCode = hashCode * 59 + this.CodeFieldName.GetHashCode();
                if (this.DescriptionFieldName != null)
                    hashCode = hashCode * 59 + this.DescriptionFieldName.GetHashCode();
                if (this.ValidationType != null)
                    hashCode = hashCode * 59 + this.ValidationType.GetHashCode();
                if (this.ValidationString != null)
                    hashCode = hashCode * 59 + this.ValidationString.GetHashCode();
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}

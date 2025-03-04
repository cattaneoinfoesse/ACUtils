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
    /// Class of document type for insert operation
    /// </summary>
    [DataContract]
    public partial class DocumentTypeForInsertDTO :  IEquatable<DocumentTypeForInsertDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentTypeForInsertDTO" /> class.
        /// </summary>
        /// <param name="bufferId">Buffer id for stylesheet update.</param>
        /// <param name="code">Code.</param>
        /// <param name="idParent">Identifier of the parent document type.</param>
        /// <param name="description">Description.</param>
        /// <param name="status">Possible values:  0: Attivo  1: Sospeso  2: Nessuno .</param>
        /// <param name="pdfStampsExport">Enable timestamp on pdf.</param>
        /// <param name="docStateAos">Status Id of substitutive conservation.</param>
        /// <param name="docState">Default value of the document status.</param>
        /// <param name="inOut">Possible values:  0: Uscita  1: Entrata  2: Interno  -1: NonValorizzato .</param>
        /// <param name="isLUL">Enable \&quot;libro unico del lavoro\&quot; concatenation.</param>
        /// <param name="pa">Possible values:  0: Never  1: Always  2: Optionally .</param>
        /// <param name="requireFile">Possible values:  0: Nothing  1: FileRequired  2: FileOptional  4: NoFile .</param>
        /// <param name="pdfAConversion">Check for PDF/A conversion.</param>
        /// <param name="displayFileName">Filename rule.</param>
        /// <param name="duplicateProfileMode">Possible values:  0: Allow  1: Deny  2: ParentConfiguration .</param>
        /// <param name="duplicateProfileDataDocMode">Possible values:  0: UseDateTimeNow  1: UseExistingValue  2: ParentConfiguration .</param>
        /// <param name="paDefaultValue">Default value of the PA protocol check.</param>
        /// <param name="translations">Document Type translations.</param>
        public DocumentTypeForInsertDTO(string bufferId = default(string), string code = default(string), int? idParent = default(int?), string description = default(string), int? status = default(int?), bool? pdfStampsExport = default(bool?), int? docStateAos = default(int?), string docState = default(string), int? inOut = default(int?), bool? isLUL = default(bool?), int? pa = default(int?), int? requireFile = default(int?), bool? pdfAConversion = default(bool?), string displayFileName = default(string), int? duplicateProfileMode = default(int?), int? duplicateProfileDataDocMode = default(int?), bool? paDefaultValue = default(bool?), List<DocumentTypeTranslationsDTO> translations = default(List<DocumentTypeTranslationsDTO>))
        {
            this.BufferId = bufferId;
            this.Code = code;
            this.IdParent = idParent;
            this.Description = description;
            this.Status = status;
            this.PdfStampsExport = pdfStampsExport;
            this.DocStateAos = docStateAos;
            this.DocState = docState;
            this.InOut = inOut;
            this.IsLUL = isLUL;
            this.Pa = pa;
            this.RequireFile = requireFile;
            this.PdfAConversion = pdfAConversion;
            this.DisplayFileName = displayFileName;
            this.DuplicateProfileMode = duplicateProfileMode;
            this.DuplicateProfileDataDocMode = duplicateProfileDataDocMode;
            this.PaDefaultValue = paDefaultValue;
            this.Translations = translations;
        }
        
        /// <summary>
        /// Buffer id for stylesheet update
        /// </summary>
        /// <value>Buffer id for stylesheet update</value>
        [DataMember(Name="bufferId", EmitDefaultValue=false)]
        public string BufferId { get; set; }

        /// <summary>
        /// Code
        /// </summary>
        /// <value>Code</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Identifier of the parent document type
        /// </summary>
        /// <value>Identifier of the parent document type</value>
        [DataMember(Name="idParent", EmitDefaultValue=false)]
        public int? IdParent { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Possible values:  0: Attivo  1: Sospeso  2: Nessuno 
        /// </summary>
        /// <value>Possible values:  0: Attivo  1: Sospeso  2: Nessuno </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }

        /// <summary>
        /// Enable timestamp on pdf
        /// </summary>
        /// <value>Enable timestamp on pdf</value>
        [DataMember(Name="pdfStampsExport", EmitDefaultValue=false)]
        public bool? PdfStampsExport { get; set; }

        /// <summary>
        /// Status Id of substitutive conservation
        /// </summary>
        /// <value>Status Id of substitutive conservation</value>
        [DataMember(Name="docStateAos", EmitDefaultValue=false)]
        public int? DocStateAos { get; set; }

        /// <summary>
        /// Default value of the document status
        /// </summary>
        /// <value>Default value of the document status</value>
        [DataMember(Name="docState", EmitDefaultValue=false)]
        public string DocState { get; set; }

        /// <summary>
        /// Possible values:  0: Uscita  1: Entrata  2: Interno  -1: NonValorizzato 
        /// </summary>
        /// <value>Possible values:  0: Uscita  1: Entrata  2: Interno  -1: NonValorizzato </value>
        [DataMember(Name="inOut", EmitDefaultValue=false)]
        public int? InOut { get; set; }

        /// <summary>
        /// Enable \&quot;libro unico del lavoro\&quot; concatenation
        /// </summary>
        /// <value>Enable \&quot;libro unico del lavoro\&quot; concatenation</value>
        [DataMember(Name="isLUL", EmitDefaultValue=false)]
        public bool? IsLUL { get; set; }

        /// <summary>
        /// Possible values:  0: Never  1: Always  2: Optionally 
        /// </summary>
        /// <value>Possible values:  0: Never  1: Always  2: Optionally </value>
        [DataMember(Name="pa", EmitDefaultValue=false)]
        public int? Pa { get; set; }

        /// <summary>
        /// Possible values:  0: Nothing  1: FileRequired  2: FileOptional  4: NoFile 
        /// </summary>
        /// <value>Possible values:  0: Nothing  1: FileRequired  2: FileOptional  4: NoFile </value>
        [DataMember(Name="requireFile", EmitDefaultValue=false)]
        public int? RequireFile { get; set; }

        /// <summary>
        /// Check for PDF/A conversion
        /// </summary>
        /// <value>Check for PDF/A conversion</value>
        [DataMember(Name="pdfAConversion", EmitDefaultValue=false)]
        public bool? PdfAConversion { get; set; }

        /// <summary>
        /// Filename rule
        /// </summary>
        /// <value>Filename rule</value>
        [DataMember(Name="displayFileName", EmitDefaultValue=false)]
        public string DisplayFileName { get; set; }

        /// <summary>
        /// Possible values:  0: Allow  1: Deny  2: ParentConfiguration 
        /// </summary>
        /// <value>Possible values:  0: Allow  1: Deny  2: ParentConfiguration </value>
        [DataMember(Name="duplicateProfileMode", EmitDefaultValue=false)]
        public int? DuplicateProfileMode { get; set; }

        /// <summary>
        /// Possible values:  0: UseDateTimeNow  1: UseExistingValue  2: ParentConfiguration 
        /// </summary>
        /// <value>Possible values:  0: UseDateTimeNow  1: UseExistingValue  2: ParentConfiguration </value>
        [DataMember(Name="duplicateProfileDataDocMode", EmitDefaultValue=false)]
        public int? DuplicateProfileDataDocMode { get; set; }

        /// <summary>
        /// Default value of the PA protocol check
        /// </summary>
        /// <value>Default value of the PA protocol check</value>
        [DataMember(Name="paDefaultValue", EmitDefaultValue=false)]
        public bool? PaDefaultValue { get; set; }

        /// <summary>
        /// Document Type translations
        /// </summary>
        /// <value>Document Type translations</value>
        [DataMember(Name="translations", EmitDefaultValue=false)]
        public List<DocumentTypeTranslationsDTO> Translations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentTypeForInsertDTO {\n");
            sb.Append("  BufferId: ").Append(BufferId).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  IdParent: ").Append(IdParent).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PdfStampsExport: ").Append(PdfStampsExport).Append("\n");
            sb.Append("  DocStateAos: ").Append(DocStateAos).Append("\n");
            sb.Append("  DocState: ").Append(DocState).Append("\n");
            sb.Append("  InOut: ").Append(InOut).Append("\n");
            sb.Append("  IsLUL: ").Append(IsLUL).Append("\n");
            sb.Append("  Pa: ").Append(Pa).Append("\n");
            sb.Append("  RequireFile: ").Append(RequireFile).Append("\n");
            sb.Append("  PdfAConversion: ").Append(PdfAConversion).Append("\n");
            sb.Append("  DisplayFileName: ").Append(DisplayFileName).Append("\n");
            sb.Append("  DuplicateProfileMode: ").Append(DuplicateProfileMode).Append("\n");
            sb.Append("  DuplicateProfileDataDocMode: ").Append(DuplicateProfileDataDocMode).Append("\n");
            sb.Append("  PaDefaultValue: ").Append(PaDefaultValue).Append("\n");
            sb.Append("  Translations: ").Append(Translations).Append("\n");
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
            return this.Equals(input as DocumentTypeForInsertDTO);
        }

        /// <summary>
        /// Returns true if DocumentTypeForInsertDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentTypeForInsertDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentTypeForInsertDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BufferId == input.BufferId ||
                    (this.BufferId != null &&
                    this.BufferId.Equals(input.BufferId))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.IdParent == input.IdParent ||
                    (this.IdParent != null &&
                    this.IdParent.Equals(input.IdParent))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.PdfStampsExport == input.PdfStampsExport ||
                    (this.PdfStampsExport != null &&
                    this.PdfStampsExport.Equals(input.PdfStampsExport))
                ) && 
                (
                    this.DocStateAos == input.DocStateAos ||
                    (this.DocStateAos != null &&
                    this.DocStateAos.Equals(input.DocStateAos))
                ) && 
                (
                    this.DocState == input.DocState ||
                    (this.DocState != null &&
                    this.DocState.Equals(input.DocState))
                ) && 
                (
                    this.InOut == input.InOut ||
                    (this.InOut != null &&
                    this.InOut.Equals(input.InOut))
                ) && 
                (
                    this.IsLUL == input.IsLUL ||
                    (this.IsLUL != null &&
                    this.IsLUL.Equals(input.IsLUL))
                ) && 
                (
                    this.Pa == input.Pa ||
                    (this.Pa != null &&
                    this.Pa.Equals(input.Pa))
                ) && 
                (
                    this.RequireFile == input.RequireFile ||
                    (this.RequireFile != null &&
                    this.RequireFile.Equals(input.RequireFile))
                ) && 
                (
                    this.PdfAConversion == input.PdfAConversion ||
                    (this.PdfAConversion != null &&
                    this.PdfAConversion.Equals(input.PdfAConversion))
                ) && 
                (
                    this.DisplayFileName == input.DisplayFileName ||
                    (this.DisplayFileName != null &&
                    this.DisplayFileName.Equals(input.DisplayFileName))
                ) && 
                (
                    this.DuplicateProfileMode == input.DuplicateProfileMode ||
                    (this.DuplicateProfileMode != null &&
                    this.DuplicateProfileMode.Equals(input.DuplicateProfileMode))
                ) && 
                (
                    this.DuplicateProfileDataDocMode == input.DuplicateProfileDataDocMode ||
                    (this.DuplicateProfileDataDocMode != null &&
                    this.DuplicateProfileDataDocMode.Equals(input.DuplicateProfileDataDocMode))
                ) && 
                (
                    this.PaDefaultValue == input.PaDefaultValue ||
                    (this.PaDefaultValue != null &&
                    this.PaDefaultValue.Equals(input.PaDefaultValue))
                ) && 
                (
                    this.Translations == input.Translations ||
                    this.Translations != null &&
                    this.Translations.SequenceEqual(input.Translations)
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
                if (this.BufferId != null)
                    hashCode = hashCode * 59 + this.BufferId.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.IdParent != null)
                    hashCode = hashCode * 59 + this.IdParent.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.PdfStampsExport != null)
                    hashCode = hashCode * 59 + this.PdfStampsExport.GetHashCode();
                if (this.DocStateAos != null)
                    hashCode = hashCode * 59 + this.DocStateAos.GetHashCode();
                if (this.DocState != null)
                    hashCode = hashCode * 59 + this.DocState.GetHashCode();
                if (this.InOut != null)
                    hashCode = hashCode * 59 + this.InOut.GetHashCode();
                if (this.IsLUL != null)
                    hashCode = hashCode * 59 + this.IsLUL.GetHashCode();
                if (this.Pa != null)
                    hashCode = hashCode * 59 + this.Pa.GetHashCode();
                if (this.RequireFile != null)
                    hashCode = hashCode * 59 + this.RequireFile.GetHashCode();
                if (this.PdfAConversion != null)
                    hashCode = hashCode * 59 + this.PdfAConversion.GetHashCode();
                if (this.DisplayFileName != null)
                    hashCode = hashCode * 59 + this.DisplayFileName.GetHashCode();
                if (this.DuplicateProfileMode != null)
                    hashCode = hashCode * 59 + this.DuplicateProfileMode.GetHashCode();
                if (this.DuplicateProfileDataDocMode != null)
                    hashCode = hashCode * 59 + this.DuplicateProfileDataDocMode.GetHashCode();
                if (this.PaDefaultValue != null)
                    hashCode = hashCode * 59 + this.PaDefaultValue.GetHashCode();
                if (this.Translations != null)
                    hashCode = hashCode * 59 + this.Translations.GetHashCode();
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

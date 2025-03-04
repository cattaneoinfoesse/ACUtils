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
    /// Class for additional field of type ClasseBox
    /// </summary>
    [DataContract]
    public partial class AdditionalFieldManagementClasseDTO : AdditionalFieldManagementBaseDTO,  IEquatable<AdditionalFieldManagementClasseDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalFieldManagementClasseDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdditionalFieldManagementClasseDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalFieldManagementClasseDTO" /> class.
        /// </summary>
        /// <param name="deleteRule">Possible values:  0: Cascade  1: Owned .</param>
        /// <param name="linkedDocumentType">Linked document type.</param>
        /// <param name="maskForInsert">Mask for insert.</param>
        /// <param name="maskForView">Mask for view.</param>
        /// <param name="viewForView">View for view.</param>
        /// <param name="viewForSearch">View for search.</param>
        /// <param name="showExpanded">Show expanded.</param>
        /// <param name="singleElement">Single element.</param>
        /// <param name="showCommandAttachments">Show command attachments.</param>
        /// <param name="showCommandNote">Show command note.</param>
        /// <param name="showCommandUpdateProfile">Show command update profile.</param>
        public AdditionalFieldManagementClasseDTO(int? deleteRule = default(int?), DocumentTypeSimpleDTO linkedDocumentType = default(DocumentTypeSimpleDTO), MaskSimpleDTO maskForInsert = default(MaskSimpleDTO), MaskSimpleDTO maskForView = default(MaskSimpleDTO), ViewSimpleDTO viewForView = default(ViewSimpleDTO), ViewSimpleDTO viewForSearch = default(ViewSimpleDTO), bool? showExpanded = default(bool?), bool? singleElement = default(bool?), bool? showCommandAttachments = default(bool?), bool? showCommandNote = default(bool?), bool? showCommandUpdateProfile = default(bool?), string className = "AdditionalFieldManagementClasseDTO", string key = default(string), string description = default(string), FieldGroupSimpleDTO fieldGroup = default(FieldGroupSimpleDTO), DocumentTypeSimpleDTO documentType = default(DocumentTypeSimpleDTO), string referenceId = default(string), int? order = default(int?), bool? required = default(bool?), bool? visible = default(bool?), string externalId = default(string), string formula = default(string), List<AdditionalFieldManagementTranslationDTO> translations = default(List<AdditionalFieldManagementTranslationDTO>)) : base(className, key, description, fieldGroup, documentType, referenceId, order, required, visible, externalId, formula, translations)
        {
            this.DeleteRule = deleteRule;
            this.LinkedDocumentType = linkedDocumentType;
            this.MaskForInsert = maskForInsert;
            this.MaskForView = maskForView;
            this.ViewForView = viewForView;
            this.ViewForSearch = viewForSearch;
            this.ShowExpanded = showExpanded;
            this.SingleElement = singleElement;
            this.ShowCommandAttachments = showCommandAttachments;
            this.ShowCommandNote = showCommandNote;
            this.ShowCommandUpdateProfile = showCommandUpdateProfile;
        }
        
        /// <summary>
        /// Possible values:  0: Cascade  1: Owned 
        /// </summary>
        /// <value>Possible values:  0: Cascade  1: Owned </value>
        [DataMember(Name="deleteRule", EmitDefaultValue=false)]
        public int? DeleteRule { get; set; }

        /// <summary>
        /// Linked document type
        /// </summary>
        /// <value>Linked document type</value>
        [DataMember(Name="linkedDocumentType", EmitDefaultValue=false)]
        public DocumentTypeSimpleDTO LinkedDocumentType { get; set; }

        /// <summary>
        /// Mask for insert
        /// </summary>
        /// <value>Mask for insert</value>
        [DataMember(Name="maskForInsert", EmitDefaultValue=false)]
        public MaskSimpleDTO MaskForInsert { get; set; }

        /// <summary>
        /// Mask for view
        /// </summary>
        /// <value>Mask for view</value>
        [DataMember(Name="maskForView", EmitDefaultValue=false)]
        public MaskSimpleDTO MaskForView { get; set; }

        /// <summary>
        /// View for view
        /// </summary>
        /// <value>View for view</value>
        [DataMember(Name="viewForView", EmitDefaultValue=false)]
        public ViewSimpleDTO ViewForView { get; set; }

        /// <summary>
        /// View for search
        /// </summary>
        /// <value>View for search</value>
        [DataMember(Name="viewForSearch", EmitDefaultValue=false)]
        public ViewSimpleDTO ViewForSearch { get; set; }

        /// <summary>
        /// Show expanded
        /// </summary>
        /// <value>Show expanded</value>
        [DataMember(Name="showExpanded", EmitDefaultValue=false)]
        public bool? ShowExpanded { get; set; }

        /// <summary>
        /// Single element
        /// </summary>
        /// <value>Single element</value>
        [DataMember(Name="singleElement", EmitDefaultValue=false)]
        public bool? SingleElement { get; set; }

        /// <summary>
        /// Show command attachments
        /// </summary>
        /// <value>Show command attachments</value>
        [DataMember(Name="showCommandAttachments", EmitDefaultValue=false)]
        public bool? ShowCommandAttachments { get; set; }

        /// <summary>
        /// Show command note
        /// </summary>
        /// <value>Show command note</value>
        [DataMember(Name="showCommandNote", EmitDefaultValue=false)]
        public bool? ShowCommandNote { get; set; }

        /// <summary>
        /// Show command update profile
        /// </summary>
        /// <value>Show command update profile</value>
        [DataMember(Name="showCommandUpdateProfile", EmitDefaultValue=false)]
        public bool? ShowCommandUpdateProfile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalFieldManagementClasseDTO {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  DeleteRule: ").Append(DeleteRule).Append("\n");
            sb.Append("  LinkedDocumentType: ").Append(LinkedDocumentType).Append("\n");
            sb.Append("  MaskForInsert: ").Append(MaskForInsert).Append("\n");
            sb.Append("  MaskForView: ").Append(MaskForView).Append("\n");
            sb.Append("  ViewForView: ").Append(ViewForView).Append("\n");
            sb.Append("  ViewForSearch: ").Append(ViewForSearch).Append("\n");
            sb.Append("  ShowExpanded: ").Append(ShowExpanded).Append("\n");
            sb.Append("  SingleElement: ").Append(SingleElement).Append("\n");
            sb.Append("  ShowCommandAttachments: ").Append(ShowCommandAttachments).Append("\n");
            sb.Append("  ShowCommandNote: ").Append(ShowCommandNote).Append("\n");
            sb.Append("  ShowCommandUpdateProfile: ").Append(ShowCommandUpdateProfile).Append("\n");
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
            return this.Equals(input as AdditionalFieldManagementClasseDTO);
        }

        /// <summary>
        /// Returns true if AdditionalFieldManagementClasseDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalFieldManagementClasseDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalFieldManagementClasseDTO input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.DeleteRule == input.DeleteRule ||
                    (this.DeleteRule != null &&
                    this.DeleteRule.Equals(input.DeleteRule))
                ) && base.Equals(input) && 
                (
                    this.LinkedDocumentType == input.LinkedDocumentType ||
                    (this.LinkedDocumentType != null &&
                    this.LinkedDocumentType.Equals(input.LinkedDocumentType))
                ) && base.Equals(input) && 
                (
                    this.MaskForInsert == input.MaskForInsert ||
                    (this.MaskForInsert != null &&
                    this.MaskForInsert.Equals(input.MaskForInsert))
                ) && base.Equals(input) && 
                (
                    this.MaskForView == input.MaskForView ||
                    (this.MaskForView != null &&
                    this.MaskForView.Equals(input.MaskForView))
                ) && base.Equals(input) && 
                (
                    this.ViewForView == input.ViewForView ||
                    (this.ViewForView != null &&
                    this.ViewForView.Equals(input.ViewForView))
                ) && base.Equals(input) && 
                (
                    this.ViewForSearch == input.ViewForSearch ||
                    (this.ViewForSearch != null &&
                    this.ViewForSearch.Equals(input.ViewForSearch))
                ) && base.Equals(input) && 
                (
                    this.ShowExpanded == input.ShowExpanded ||
                    (this.ShowExpanded != null &&
                    this.ShowExpanded.Equals(input.ShowExpanded))
                ) && base.Equals(input) && 
                (
                    this.SingleElement == input.SingleElement ||
                    (this.SingleElement != null &&
                    this.SingleElement.Equals(input.SingleElement))
                ) && base.Equals(input) && 
                (
                    this.ShowCommandAttachments == input.ShowCommandAttachments ||
                    (this.ShowCommandAttachments != null &&
                    this.ShowCommandAttachments.Equals(input.ShowCommandAttachments))
                ) && base.Equals(input) && 
                (
                    this.ShowCommandNote == input.ShowCommandNote ||
                    (this.ShowCommandNote != null &&
                    this.ShowCommandNote.Equals(input.ShowCommandNote))
                ) && base.Equals(input) && 
                (
                    this.ShowCommandUpdateProfile == input.ShowCommandUpdateProfile ||
                    (this.ShowCommandUpdateProfile != null &&
                    this.ShowCommandUpdateProfile.Equals(input.ShowCommandUpdateProfile))
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
                if (this.DeleteRule != null)
                    hashCode = hashCode * 59 + this.DeleteRule.GetHashCode();
                if (this.LinkedDocumentType != null)
                    hashCode = hashCode * 59 + this.LinkedDocumentType.GetHashCode();
                if (this.MaskForInsert != null)
                    hashCode = hashCode * 59 + this.MaskForInsert.GetHashCode();
                if (this.MaskForView != null)
                    hashCode = hashCode * 59 + this.MaskForView.GetHashCode();
                if (this.ViewForView != null)
                    hashCode = hashCode * 59 + this.ViewForView.GetHashCode();
                if (this.ViewForSearch != null)
                    hashCode = hashCode * 59 + this.ViewForSearch.GetHashCode();
                if (this.ShowExpanded != null)
                    hashCode = hashCode * 59 + this.ShowExpanded.GetHashCode();
                if (this.SingleElement != null)
                    hashCode = hashCode * 59 + this.SingleElement.GetHashCode();
                if (this.ShowCommandAttachments != null)
                    hashCode = hashCode * 59 + this.ShowCommandAttachments.GetHashCode();
                if (this.ShowCommandNote != null)
                    hashCode = hashCode * 59 + this.ShowCommandNote.GetHashCode();
                if (this.ShowCommandUpdateProfile != null)
                    hashCode = hashCode * 59 + this.ShowCommandUpdateProfile.GetHashCode();
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

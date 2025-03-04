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
    /// Class of ArxCe document type field
    /// </summary>
    [DataContract]
    public partial class ArxCeFieldDTO :  IEquatable<ArxCeFieldDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArxCeFieldDTO" /> class.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="description">Description.</param>
        /// <param name="externalId">External identifier.</param>
        /// <param name="required">Required.</param>
        /// <param name="fieldType">Possible values:  0: String  1: Int  2: Date  3: DateTime  4: Double  5: Bit .</param>
        /// <param name="validation">Possible values:  0: None  1: FiscalCode  2: VatCode .</param>
        /// <param name="inputMode">Possible values:  0: Single  1: SingleSelectable .</param>
        /// <param name="values">Values.</param>
        /// <param name="metadataType">Possible values:  0: Generico  1: ModalitaDiFormazione  2: DatiDiRegistrazioneTipologiaDiFlusso  3: DatiDiRegistrazioneTipoRegistro  4: DatiDiRegistrazioneDataRegistrazione  5: DatiDiRegistrazioneNumeroDocumento  6: DatiDiRegistrazioneCodiceRegistro  7: ChiaveDescrittivaOggetto  8: ChiaveDescrittivaParoleChiave  9: ClassificazioneIndiceDiClassificazione  10: ClassificazioneDescrizione  11: ClassificazionePianoDiClassificazione  12: Riservato  13: IdentificativoDelFormatoProdottoSoftwareNomeProdotto  14: IdentificativoDelFormatoProdottoSoftwareVersioneProdotto  15: IdentificativoDelFormatoProdottoSoftwareProduttore  16: Note  17: SoggettiAutoreNome  18: SoggettiAutoreCognome  19: SoggettiAutoreCodiceFiscale  20: SoggettiAutoreRagioneSociale  21: SoggettiAutorePartitaIva  22: SoggettiAutoreCodiceIpa  23: SoggettiAutoreCodiceUnivocoUfficio  24: SoggettiMittenteNome  25: SoggettiMittenteCognome  26: SoggettiMittenteCodiceFiscale  27: SoggettiMittenteRagioneSociale  28: SoggettiMittentePartitaIva  29: SoggettiMittenteCodiceIpa  30: SoggettiMittenteCodiceUnivocoUfficio  31: SoggettiDestinatarioNome  32: SoggettiDestinatarioCognome  33: SoggettiDestinatarioCodiceFiscale  34: SoggettiDestinatarioRagioneSociale  35: SoggettiDestinatarioPartitaIva  36: SoggettiDestinatarioCodiceIpa  37: SoggettiDestinatarioCodiceUnivocoUfficio  38: SoggettiOperatoreNome  39: SoggettiOperatoreCognome  40: SoggettiOperatoreCodiceFiscale  41: SoggettiOperatoreRagioneSociale  42: SoggettiOperatorePartitaIva  43: SoggettiOperatoreCodiceIpa  44: SoggettiOperatoreCodiceUnivocoUfficio  45: TempoDiConservazione  46: SoggettiSoggettoCheEffettuaLaRegistrazioneNome  47: SoggettiSoggettoCheEffettuaLaRegistrazioneCognome  48: SoggettiSoggettoCheEffettuaLaRegistrazioneRagioneSociale  49: SoggettiSoggettoCheEffettuaLaRegistrazioneCodiceFiscale  50: SoggettiSoggettoCheEffettuaLaRegistrazionePartitaIva  51: SoggettiSoggettoCheEffettuaLaRegistrazioneCodiceUnivocoUfficio  52: SoggettiSoggettoCheEffettuaLaRegistrazioneCodiceIpa .</param>
        /// <param name="fieldMetadataAdvancedOptions">Metadata field advanced options.</param>
        public ArxCeFieldDTO(string name = default(string), string description = default(string), string externalId = default(string), bool? required = default(bool?), int? fieldType = default(int?), int? validation = default(int?), int? inputMode = default(int?), List<string> values = default(List<string>), int? metadataType = default(int?), ArxCeFieldMetadataAdvancedOptionsDTO fieldMetadataAdvancedOptions = default(ArxCeFieldMetadataAdvancedOptionsDTO))
        {
            this.Name = name;
            this.Description = description;
            this.ExternalId = externalId;
            this.Required = required;
            this.FieldType = fieldType;
            this.Validation = validation;
            this.InputMode = inputMode;
            this.Values = values;
            this.MetadataType = metadataType;
            this.FieldMetadataAdvancedOptions = fieldMetadataAdvancedOptions;
        }
        
        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// External identifier
        /// </summary>
        /// <value>External identifier</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        /// <value>Required</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// Possible values:  0: String  1: Int  2: Date  3: DateTime  4: Double  5: Bit 
        /// </summary>
        /// <value>Possible values:  0: String  1: Int  2: Date  3: DateTime  4: Double  5: Bit </value>
        [DataMember(Name="fieldType", EmitDefaultValue=false)]
        public int? FieldType { get; set; }

        /// <summary>
        /// Possible values:  0: None  1: FiscalCode  2: VatCode 
        /// </summary>
        /// <value>Possible values:  0: None  1: FiscalCode  2: VatCode </value>
        [DataMember(Name="validation", EmitDefaultValue=false)]
        public int? Validation { get; set; }

        /// <summary>
        /// Possible values:  0: Single  1: SingleSelectable 
        /// </summary>
        /// <value>Possible values:  0: Single  1: SingleSelectable </value>
        [DataMember(Name="inputMode", EmitDefaultValue=false)]
        public int? InputMode { get; set; }

        /// <summary>
        /// Values
        /// </summary>
        /// <value>Values</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }

        /// <summary>
        /// Possible values:  0: Generico  1: ModalitaDiFormazione  2: DatiDiRegistrazioneTipologiaDiFlusso  3: DatiDiRegistrazioneTipoRegistro  4: DatiDiRegistrazioneDataRegistrazione  5: DatiDiRegistrazioneNumeroDocumento  6: DatiDiRegistrazioneCodiceRegistro  7: ChiaveDescrittivaOggetto  8: ChiaveDescrittivaParoleChiave  9: ClassificazioneIndiceDiClassificazione  10: ClassificazioneDescrizione  11: ClassificazionePianoDiClassificazione  12: Riservato  13: IdentificativoDelFormatoProdottoSoftwareNomeProdotto  14: IdentificativoDelFormatoProdottoSoftwareVersioneProdotto  15: IdentificativoDelFormatoProdottoSoftwareProduttore  16: Note  17: SoggettiAutoreNome  18: SoggettiAutoreCognome  19: SoggettiAutoreCodiceFiscale  20: SoggettiAutoreRagioneSociale  21: SoggettiAutorePartitaIva  22: SoggettiAutoreCodiceIpa  23: SoggettiAutoreCodiceUnivocoUfficio  24: SoggettiMittenteNome  25: SoggettiMittenteCognome  26: SoggettiMittenteCodiceFiscale  27: SoggettiMittenteRagioneSociale  28: SoggettiMittentePartitaIva  29: SoggettiMittenteCodiceIpa  30: SoggettiMittenteCodiceUnivocoUfficio  31: SoggettiDestinatarioNome  32: SoggettiDestinatarioCognome  33: SoggettiDestinatarioCodiceFiscale  34: SoggettiDestinatarioRagioneSociale  35: SoggettiDestinatarioPartitaIva  36: SoggettiDestinatarioCodiceIpa  37: SoggettiDestinatarioCodiceUnivocoUfficio  38: SoggettiOperatoreNome  39: SoggettiOperatoreCognome  40: SoggettiOperatoreCodiceFiscale  41: SoggettiOperatoreRagioneSociale  42: SoggettiOperatorePartitaIva  43: SoggettiOperatoreCodiceIpa  44: SoggettiOperatoreCodiceUnivocoUfficio  45: TempoDiConservazione  46: SoggettiSoggettoCheEffettuaLaRegistrazioneNome  47: SoggettiSoggettoCheEffettuaLaRegistrazioneCognome  48: SoggettiSoggettoCheEffettuaLaRegistrazioneRagioneSociale  49: SoggettiSoggettoCheEffettuaLaRegistrazioneCodiceFiscale  50: SoggettiSoggettoCheEffettuaLaRegistrazionePartitaIva  51: SoggettiSoggettoCheEffettuaLaRegistrazioneCodiceUnivocoUfficio  52: SoggettiSoggettoCheEffettuaLaRegistrazioneCodiceIpa 
        /// </summary>
        /// <value>Possible values:  0: Generico  1: ModalitaDiFormazione  2: DatiDiRegistrazioneTipologiaDiFlusso  3: DatiDiRegistrazioneTipoRegistro  4: DatiDiRegistrazioneDataRegistrazione  5: DatiDiRegistrazioneNumeroDocumento  6: DatiDiRegistrazioneCodiceRegistro  7: ChiaveDescrittivaOggetto  8: ChiaveDescrittivaParoleChiave  9: ClassificazioneIndiceDiClassificazione  10: ClassificazioneDescrizione  11: ClassificazionePianoDiClassificazione  12: Riservato  13: IdentificativoDelFormatoProdottoSoftwareNomeProdotto  14: IdentificativoDelFormatoProdottoSoftwareVersioneProdotto  15: IdentificativoDelFormatoProdottoSoftwareProduttore  16: Note  17: SoggettiAutoreNome  18: SoggettiAutoreCognome  19: SoggettiAutoreCodiceFiscale  20: SoggettiAutoreRagioneSociale  21: SoggettiAutorePartitaIva  22: SoggettiAutoreCodiceIpa  23: SoggettiAutoreCodiceUnivocoUfficio  24: SoggettiMittenteNome  25: SoggettiMittenteCognome  26: SoggettiMittenteCodiceFiscale  27: SoggettiMittenteRagioneSociale  28: SoggettiMittentePartitaIva  29: SoggettiMittenteCodiceIpa  30: SoggettiMittenteCodiceUnivocoUfficio  31: SoggettiDestinatarioNome  32: SoggettiDestinatarioCognome  33: SoggettiDestinatarioCodiceFiscale  34: SoggettiDestinatarioRagioneSociale  35: SoggettiDestinatarioPartitaIva  36: SoggettiDestinatarioCodiceIpa  37: SoggettiDestinatarioCodiceUnivocoUfficio  38: SoggettiOperatoreNome  39: SoggettiOperatoreCognome  40: SoggettiOperatoreCodiceFiscale  41: SoggettiOperatoreRagioneSociale  42: SoggettiOperatorePartitaIva  43: SoggettiOperatoreCodiceIpa  44: SoggettiOperatoreCodiceUnivocoUfficio  45: TempoDiConservazione  46: SoggettiSoggettoCheEffettuaLaRegistrazioneNome  47: SoggettiSoggettoCheEffettuaLaRegistrazioneCognome  48: SoggettiSoggettoCheEffettuaLaRegistrazioneRagioneSociale  49: SoggettiSoggettoCheEffettuaLaRegistrazioneCodiceFiscale  50: SoggettiSoggettoCheEffettuaLaRegistrazionePartitaIva  51: SoggettiSoggettoCheEffettuaLaRegistrazioneCodiceUnivocoUfficio  52: SoggettiSoggettoCheEffettuaLaRegistrazioneCodiceIpa </value>
        [DataMember(Name="metadataType", EmitDefaultValue=false)]
        public int? MetadataType { get; set; }

        /// <summary>
        /// Metadata field advanced options
        /// </summary>
        /// <value>Metadata field advanced options</value>
        [DataMember(Name="fieldMetadataAdvancedOptions", EmitDefaultValue=false)]
        public ArxCeFieldMetadataAdvancedOptionsDTO FieldMetadataAdvancedOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArxCeFieldDTO {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  FieldType: ").Append(FieldType).Append("\n");
            sb.Append("  Validation: ").Append(Validation).Append("\n");
            sb.Append("  InputMode: ").Append(InputMode).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  MetadataType: ").Append(MetadataType).Append("\n");
            sb.Append("  FieldMetadataAdvancedOptions: ").Append(FieldMetadataAdvancedOptions).Append("\n");
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
            return this.Equals(input as ArxCeFieldDTO);
        }

        /// <summary>
        /// Returns true if ArxCeFieldDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ArxCeFieldDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArxCeFieldDTO input)
        {
            if (input == null)
                return false;

            return 
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
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
                ) && 
                (
                    this.FieldType == input.FieldType ||
                    (this.FieldType != null &&
                    this.FieldType.Equals(input.FieldType))
                ) && 
                (
                    this.Validation == input.Validation ||
                    (this.Validation != null &&
                    this.Validation.Equals(input.Validation))
                ) && 
                (
                    this.InputMode == input.InputMode ||
                    (this.InputMode != null &&
                    this.InputMode.Equals(input.InputMode))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && 
                (
                    this.MetadataType == input.MetadataType ||
                    (this.MetadataType != null &&
                    this.MetadataType.Equals(input.MetadataType))
                ) && 
                (
                    this.FieldMetadataAdvancedOptions == input.FieldMetadataAdvancedOptions ||
                    (this.FieldMetadataAdvancedOptions != null &&
                    this.FieldMetadataAdvancedOptions.Equals(input.FieldMetadataAdvancedOptions))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.FieldType != null)
                    hashCode = hashCode * 59 + this.FieldType.GetHashCode();
                if (this.Validation != null)
                    hashCode = hashCode * 59 + this.Validation.GetHashCode();
                if (this.InputMode != null)
                    hashCode = hashCode * 59 + this.InputMode.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.MetadataType != null)
                    hashCode = hashCode * 59 + this.MetadataType.GetHashCode();
                if (this.FieldMetadataAdvancedOptions != null)
                    hashCode = hashCode * 59 + this.FieldMetadataAdvancedOptions.GetHashCode();
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

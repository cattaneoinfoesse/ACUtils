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
    /// FieldsModuleDTO
    /// </summary>
    [DataContract]
    public partial class FieldsModuleDTO :  IEquatable<FieldsModuleDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldsModuleDTO" /> class.
        /// </summary>
        /// <param name="profileField">Nome del campo di profilo..</param>
        /// <param name="label">Etichetta dell&#39;associazione..</param>
        /// <param name="modelField">Nome del campo nel modello office..</param>
        /// <param name="type1">Classe documentale di primo livello..</param>
        /// <param name="type2">Classe documentale di secondo livello..</param>
        /// <param name="type3">Classe documentale di terso livello..</param>
        /// <param name="idModel">Identificativo del modello office di riferimento..</param>
        /// <param name="fieldsMatrixModule">fieldsMatrixModule.</param>
        public FieldsModuleDTO(string profileField = default(string), string label = default(string), string modelField = default(string), int? type1 = default(int?), int? type2 = default(int?), int? type3 = default(int?), int? idModel = default(int?), List<FieldsMatrixModuleDTO> fieldsMatrixModule = default(List<FieldsMatrixModuleDTO>))
        {
            this.ProfileField = profileField;
            this.Label = label;
            this.ModelField = modelField;
            this.Type1 = type1;
            this.Type2 = type2;
            this.Type3 = type3;
            this.IdModel = idModel;
            this.FieldsMatrixModule = fieldsMatrixModule;
        }
        
        /// <summary>
        /// Nome del campo di profilo.
        /// </summary>
        /// <value>Nome del campo di profilo.</value>
        [DataMember(Name="profileField", EmitDefaultValue=false)]
        public string ProfileField { get; set; }

        /// <summary>
        /// Etichetta dell&#39;associazione.
        /// </summary>
        /// <value>Etichetta dell&#39;associazione.</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Nome del campo nel modello office.
        /// </summary>
        /// <value>Nome del campo nel modello office.</value>
        [DataMember(Name="modelField", EmitDefaultValue=false)]
        public string ModelField { get; set; }

        /// <summary>
        /// Classe documentale di primo livello.
        /// </summary>
        /// <value>Classe documentale di primo livello.</value>
        [DataMember(Name="type1", EmitDefaultValue=false)]
        public int? Type1 { get; set; }

        /// <summary>
        /// Classe documentale di secondo livello.
        /// </summary>
        /// <value>Classe documentale di secondo livello.</value>
        [DataMember(Name="type2", EmitDefaultValue=false)]
        public int? Type2 { get; set; }

        /// <summary>
        /// Classe documentale di terso livello.
        /// </summary>
        /// <value>Classe documentale di terso livello.</value>
        [DataMember(Name="type3", EmitDefaultValue=false)]
        public int? Type3 { get; set; }

        /// <summary>
        /// Identificativo del modello office di riferimento.
        /// </summary>
        /// <value>Identificativo del modello office di riferimento.</value>
        [DataMember(Name="idModel", EmitDefaultValue=false)]
        public int? IdModel { get; set; }

        /// <summary>
        /// Gets or Sets FieldsMatrixModule
        /// </summary>
        [DataMember(Name="fieldsMatrixModule", EmitDefaultValue=false)]
        public List<FieldsMatrixModuleDTO> FieldsMatrixModule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldsModuleDTO {\n");
            sb.Append("  ProfileField: ").Append(ProfileField).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  ModelField: ").Append(ModelField).Append("\n");
            sb.Append("  Type1: ").Append(Type1).Append("\n");
            sb.Append("  Type2: ").Append(Type2).Append("\n");
            sb.Append("  Type3: ").Append(Type3).Append("\n");
            sb.Append("  IdModel: ").Append(IdModel).Append("\n");
            sb.Append("  FieldsMatrixModule: ").Append(FieldsMatrixModule).Append("\n");
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
            return this.Equals(input as FieldsModuleDTO);
        }

        /// <summary>
        /// Returns true if FieldsModuleDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldsModuleDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldsModuleDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProfileField == input.ProfileField ||
                    (this.ProfileField != null &&
                    this.ProfileField.Equals(input.ProfileField))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.ModelField == input.ModelField ||
                    (this.ModelField != null &&
                    this.ModelField.Equals(input.ModelField))
                ) && 
                (
                    this.Type1 == input.Type1 ||
                    (this.Type1 != null &&
                    this.Type1.Equals(input.Type1))
                ) && 
                (
                    this.Type2 == input.Type2 ||
                    (this.Type2 != null &&
                    this.Type2.Equals(input.Type2))
                ) && 
                (
                    this.Type3 == input.Type3 ||
                    (this.Type3 != null &&
                    this.Type3.Equals(input.Type3))
                ) && 
                (
                    this.IdModel == input.IdModel ||
                    (this.IdModel != null &&
                    this.IdModel.Equals(input.IdModel))
                ) && 
                (
                    this.FieldsMatrixModule == input.FieldsMatrixModule ||
                    this.FieldsMatrixModule != null &&
                    this.FieldsMatrixModule.SequenceEqual(input.FieldsMatrixModule)
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
                if (this.ProfileField != null)
                    hashCode = hashCode * 59 + this.ProfileField.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.ModelField != null)
                    hashCode = hashCode * 59 + this.ModelField.GetHashCode();
                if (this.Type1 != null)
                    hashCode = hashCode * 59 + this.Type1.GetHashCode();
                if (this.Type2 != null)
                    hashCode = hashCode * 59 + this.Type2.GetHashCode();
                if (this.Type3 != null)
                    hashCode = hashCode * 59 + this.Type3.GetHashCode();
                if (this.IdModel != null)
                    hashCode = hashCode * 59 + this.IdModel.GetHashCode();
                if (this.FieldsMatrixModule != null)
                    hashCode = hashCode * 59 + this.FieldsMatrixModule.GetHashCode();
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

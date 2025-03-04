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
    /// Class that represent association between Docnumber and External Id
    /// </summary>
    [DataContract]
    public partial class DocnumberIdErpAssociationDTO :  IEquatable<DocnumberIdErpAssociationDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocnumberIdErpAssociationDTO" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="docnumber">docnumber.</param>
        /// <param name="idErp">idErp.</param>
        public DocnumberIdErpAssociationDTO(int? id = default(int?), int? docnumber = default(int?), string idErp = default(string))
        {
            this.Id = id;
            this.Docnumber = docnumber;
            this.IdErp = idErp;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Docnumber
        /// </summary>
        [DataMember(Name="docnumber", EmitDefaultValue=false)]
        public int? Docnumber { get; set; }

        /// <summary>
        /// Gets or Sets IdErp
        /// </summary>
        [DataMember(Name="idErp", EmitDefaultValue=false)]
        public string IdErp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocnumberIdErpAssociationDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Docnumber: ").Append(Docnumber).Append("\n");
            sb.Append("  IdErp: ").Append(IdErp).Append("\n");
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
            return this.Equals(input as DocnumberIdErpAssociationDTO);
        }

        /// <summary>
        /// Returns true if DocnumberIdErpAssociationDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of DocnumberIdErpAssociationDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocnumberIdErpAssociationDTO input)
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
                    this.Docnumber == input.Docnumber ||
                    (this.Docnumber != null &&
                    this.Docnumber.Equals(input.Docnumber))
                ) && 
                (
                    this.IdErp == input.IdErp ||
                    (this.IdErp != null &&
                    this.IdErp.Equals(input.IdErp))
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
                if (this.Docnumber != null)
                    hashCode = hashCode * 59 + this.Docnumber.GetHashCode();
                if (this.IdErp != null)
                    hashCode = hashCode * 59 + this.IdErp.GetHashCode();
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

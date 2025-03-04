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
    /// Class of document type: automatic reference
    /// </summary>
    [DataContract]
    public partial class AutomaticReferenceDTO :  IEquatable<AutomaticReferenceDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomaticReferenceDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="documentTypeId">Codice della classe documentale.</param>
        /// <param name="businessUnitCode">Business unit.</param>
        /// <param name="state">Possible values:  0: Active  1: Suspended  2: Manual .</param>
        /// <param name="sign">Sign of protocol.</param>
        /// <param name="value">Sequential number.</param>
        /// <param name="dateFrom">Initial validity date.</param>
        /// <param name="dateTo">End date of validity.</param>
        /// <param name="field">Possible values:  0: RegistrationDate  1: DocumentDate .</param>
        /// <param name="priority">Priority.</param>
        /// <param name="_in">Field for origin in.</param>
        /// <param name="_out">Flag for origin out.</param>
        /// <param name="_internal">Flag for origin internal.</param>
        public AutomaticReferenceDTO(int? id = default(int?), int? documentTypeId = default(int?), string businessUnitCode = default(string), int? state = default(int?), string sign = default(string), int? value = default(int?), DateTime? dateFrom = default(DateTime?), DateTime? dateTo = default(DateTime?), int? field = default(int?), bool? priority = default(bool?), bool? _in = default(bool?), bool? _out = default(bool?), bool? _internal = default(bool?))
        {
            this.Id = id;
            this.DocumentTypeId = documentTypeId;
            this.BusinessUnitCode = businessUnitCode;
            this.State = state;
            this.Sign = sign;
            this.Value = value;
            this.DateFrom = dateFrom;
            this.DateTo = dateTo;
            this.Field = field;
            this.Priority = priority;
            this.In = _in;
            this.Out = _out;
            this.Internal = _internal;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Codice della classe documentale
        /// </summary>
        /// <value>Codice della classe documentale</value>
        [DataMember(Name="documentTypeId", EmitDefaultValue=false)]
        public int? DocumentTypeId { get; set; }

        /// <summary>
        /// Business unit
        /// </summary>
        /// <value>Business unit</value>
        [DataMember(Name="businessUnitCode", EmitDefaultValue=false)]
        public string BusinessUnitCode { get; set; }

        /// <summary>
        /// Possible values:  0: Active  1: Suspended  2: Manual 
        /// </summary>
        /// <value>Possible values:  0: Active  1: Suspended  2: Manual </value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public int? State { get; set; }

        /// <summary>
        /// Sign of protocol
        /// </summary>
        /// <value>Sign of protocol</value>
        [DataMember(Name="sign", EmitDefaultValue=false)]
        public string Sign { get; set; }

        /// <summary>
        /// Sequential number
        /// </summary>
        /// <value>Sequential number</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public int? Value { get; set; }

        /// <summary>
        /// Initial validity date
        /// </summary>
        /// <value>Initial validity date</value>
        [DataMember(Name="dateFrom", EmitDefaultValue=false)]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// End date of validity
        /// </summary>
        /// <value>End date of validity</value>
        [DataMember(Name="dateTo", EmitDefaultValue=false)]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Possible values:  0: RegistrationDate  1: DocumentDate 
        /// </summary>
        /// <value>Possible values:  0: RegistrationDate  1: DocumentDate </value>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public int? Field { get; set; }

        /// <summary>
        /// Priority
        /// </summary>
        /// <value>Priority</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public bool? Priority { get; set; }

        /// <summary>
        /// Field for origin in
        /// </summary>
        /// <value>Field for origin in</value>
        [DataMember(Name="in", EmitDefaultValue=false)]
        public bool? In { get; set; }

        /// <summary>
        /// Flag for origin out
        /// </summary>
        /// <value>Flag for origin out</value>
        [DataMember(Name="out", EmitDefaultValue=false)]
        public bool? Out { get; set; }

        /// <summary>
        /// Flag for origin internal
        /// </summary>
        /// <value>Flag for origin internal</value>
        [DataMember(Name="internal", EmitDefaultValue=false)]
        public bool? Internal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutomaticReferenceDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DocumentTypeId: ").Append(DocumentTypeId).Append("\n");
            sb.Append("  BusinessUnitCode: ").Append(BusinessUnitCode).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Sign: ").Append(Sign).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  DateFrom: ").Append(DateFrom).Append("\n");
            sb.Append("  DateTo: ").Append(DateTo).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  In: ").Append(In).Append("\n");
            sb.Append("  Out: ").Append(Out).Append("\n");
            sb.Append("  Internal: ").Append(Internal).Append("\n");
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
            return this.Equals(input as AutomaticReferenceDTO);
        }

        /// <summary>
        /// Returns true if AutomaticReferenceDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AutomaticReferenceDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutomaticReferenceDTO input)
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
                    this.DocumentTypeId == input.DocumentTypeId ||
                    (this.DocumentTypeId != null &&
                    this.DocumentTypeId.Equals(input.DocumentTypeId))
                ) && 
                (
                    this.BusinessUnitCode == input.BusinessUnitCode ||
                    (this.BusinessUnitCode != null &&
                    this.BusinessUnitCode.Equals(input.BusinessUnitCode))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Sign == input.Sign ||
                    (this.Sign != null &&
                    this.Sign.Equals(input.Sign))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.DateFrom == input.DateFrom ||
                    (this.DateFrom != null &&
                    this.DateFrom.Equals(input.DateFrom))
                ) && 
                (
                    this.DateTo == input.DateTo ||
                    (this.DateTo != null &&
                    this.DateTo.Equals(input.DateTo))
                ) && 
                (
                    this.Field == input.Field ||
                    (this.Field != null &&
                    this.Field.Equals(input.Field))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.In == input.In ||
                    (this.In != null &&
                    this.In.Equals(input.In))
                ) && 
                (
                    this.Out == input.Out ||
                    (this.Out != null &&
                    this.Out.Equals(input.Out))
                ) && 
                (
                    this.Internal == input.Internal ||
                    (this.Internal != null &&
                    this.Internal.Equals(input.Internal))
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
                if (this.DocumentTypeId != null)
                    hashCode = hashCode * 59 + this.DocumentTypeId.GetHashCode();
                if (this.BusinessUnitCode != null)
                    hashCode = hashCode * 59 + this.BusinessUnitCode.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Sign != null)
                    hashCode = hashCode * 59 + this.Sign.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.DateFrom != null)
                    hashCode = hashCode * 59 + this.DateFrom.GetHashCode();
                if (this.DateTo != null)
                    hashCode = hashCode * 59 + this.DateTo.GetHashCode();
                if (this.Field != null)
                    hashCode = hashCode * 59 + this.Field.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.In != null)
                    hashCode = hashCode * 59 + this.In.GetHashCode();
                if (this.Out != null)
                    hashCode = hashCode * 59 + this.Out.GetHashCode();
                if (this.Internal != null)
                    hashCode = hashCode * 59 + this.Internal.GetHashCode();
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

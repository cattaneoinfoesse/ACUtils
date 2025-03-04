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
    /// Class of sql condition for type Double
    /// </summary>
    [DataContract]
    public partial class SqlConditionDoubleDTO :  IEquatable<SqlConditionDoubleDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlConditionDoubleDTO" /> class.
        /// </summary>
        /// <param name="_operator">Possible values:  0: Non_Impostato  1: Minore  2: Minore_Uguale  3: Uguale  4: Maggiore_Uguale  5: Maggiore  6: Diverso  7: Compreso  8: Nullo  9: Non_Nullo  10: Nullo_o_Zero  11: Non_Nullo_e_Non_Zero  12: Escluso .</param>
        /// <param name="value1">First value.</param>
        /// <param name="value2">Second value.</param>
        public SqlConditionDoubleDTO(int? _operator = default(int?), double? value1 = default(double?), double? value2 = default(double?))
        {
            this.Operator = _operator;
            this.Value1 = value1;
            this.Value2 = value2;
        }
        
        /// <summary>
        /// Possible values:  0: Non_Impostato  1: Minore  2: Minore_Uguale  3: Uguale  4: Maggiore_Uguale  5: Maggiore  6: Diverso  7: Compreso  8: Nullo  9: Non_Nullo  10: Nullo_o_Zero  11: Non_Nullo_e_Non_Zero  12: Escluso 
        /// </summary>
        /// <value>Possible values:  0: Non_Impostato  1: Minore  2: Minore_Uguale  3: Uguale  4: Maggiore_Uguale  5: Maggiore  6: Diverso  7: Compreso  8: Nullo  9: Non_Nullo  10: Nullo_o_Zero  11: Non_Nullo_e_Non_Zero  12: Escluso </value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public int? Operator { get; set; }

        /// <summary>
        /// First value
        /// </summary>
        /// <value>First value</value>
        [DataMember(Name="value1", EmitDefaultValue=false)]
        public double? Value1 { get; set; }

        /// <summary>
        /// Second value
        /// </summary>
        /// <value>Second value</value>
        [DataMember(Name="value2", EmitDefaultValue=false)]
        public double? Value2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SqlConditionDoubleDTO {\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Value1: ").Append(Value1).Append("\n");
            sb.Append("  Value2: ").Append(Value2).Append("\n");
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
            return this.Equals(input as SqlConditionDoubleDTO);
        }

        /// <summary>
        /// Returns true if SqlConditionDoubleDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SqlConditionDoubleDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SqlConditionDoubleDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Operator == input.Operator ||
                    (this.Operator != null &&
                    this.Operator.Equals(input.Operator))
                ) && 
                (
                    this.Value1 == input.Value1 ||
                    (this.Value1 != null &&
                    this.Value1.Equals(input.Value1))
                ) && 
                (
                    this.Value2 == input.Value2 ||
                    (this.Value2 != null &&
                    this.Value2.Equals(input.Value2))
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
                if (this.Operator != null)
                    hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.Value1 != null)
                    hashCode = hashCode * 59 + this.Value1.GetHashCode();
                if (this.Value2 != null)
                    hashCode = hashCode * 59 + this.Value2.GetHashCode();
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

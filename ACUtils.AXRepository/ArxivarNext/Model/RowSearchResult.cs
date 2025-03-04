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
    /// Class of  search result row
    /// </summary>
    [DataContract]
    public partial class RowSearchResult :  IEquatable<RowSearchResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RowSearchResult" /> class.
        /// </summary>
        /// <param name="rowSerchResultContext">Possible values:  0: None  1: Profiles  2: InternalAttachments  3: ExternalAttachments  4: AddressBook  5: CheckInOut  6: TaskWork  7: TaskWorkAttachements  8: TaskNotes  9: TaskWorkHistory  10: SqlQuery  11: ApiCall  12: Users .</param>
        /// <param name="columns">columns.</param>
        public RowSearchResult(int? rowSerchResultContext = default(int?), List<ColumnSearchResult> columns = default(List<ColumnSearchResult>))
        {
            this.RowSerchResultContext = rowSerchResultContext;
            this.Columns = columns;
        }
        
        /// <summary>
        /// Possible values:  0: None  1: Profiles  2: InternalAttachments  3: ExternalAttachments  4: AddressBook  5: CheckInOut  6: TaskWork  7: TaskWorkAttachements  8: TaskNotes  9: TaskWorkHistory  10: SqlQuery  11: ApiCall  12: Users 
        /// </summary>
        /// <value>Possible values:  0: None  1: Profiles  2: InternalAttachments  3: ExternalAttachments  4: AddressBook  5: CheckInOut  6: TaskWork  7: TaskWorkAttachements  8: TaskNotes  9: TaskWorkHistory  10: SqlQuery  11: ApiCall  12: Users </value>
        [DataMember(Name="rowSerchResultContext", EmitDefaultValue=false)]
        public int? RowSerchResultContext { get; set; }

        /// <summary>
        /// Gets or Sets Columns
        /// </summary>
        [DataMember(Name="columns", EmitDefaultValue=false)]
        public List<ColumnSearchResult> Columns { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RowSearchResult {\n");
            sb.Append("  RowSerchResultContext: ").Append(RowSerchResultContext).Append("\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
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
            return this.Equals(input as RowSearchResult);
        }

        /// <summary>
        /// Returns true if RowSearchResult instances are equal
        /// </summary>
        /// <param name="input">Instance of RowSearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RowSearchResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RowSerchResultContext == input.RowSerchResultContext ||
                    (this.RowSerchResultContext != null &&
                    this.RowSerchResultContext.Equals(input.RowSerchResultContext))
                ) && 
                (
                    this.Columns == input.Columns ||
                    this.Columns != null &&
                    this.Columns.SequenceEqual(input.Columns)
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
                if (this.RowSerchResultContext != null)
                    hashCode = hashCode * 59 + this.RowSerchResultContext.GetHashCode();
                if (this.Columns != null)
                    hashCode = hashCode * 59 + this.Columns.GetHashCode();
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

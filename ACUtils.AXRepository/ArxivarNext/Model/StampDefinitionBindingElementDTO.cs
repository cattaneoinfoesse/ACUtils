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
    /// Object that define a binding configuration for a stamp.
    /// </summary>
    [DataContract]
    public partial class StampDefinitionBindingElementDTO :  IEquatable<StampDefinitionBindingElementDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StampDefinitionBindingElementDTO" /> class.
        /// </summary>
        /// <param name="id">Id of binding definition..</param>
        /// <param name="idElement">Element Id..</param>
        /// <param name="elementProperty">Property name..</param>
        /// <param name="bindingDescription">Description for binding..</param>
        /// <param name="fieldBinding">Binding field for association..</param>
        /// <param name="defaultValue">Default value..</param>
        public StampDefinitionBindingElementDTO(string id = default(string), string idElement = default(string), string elementProperty = default(string), string bindingDescription = default(string), string fieldBinding = default(string), Object defaultValue = default(Object))
        {
            this.Id = id;
            this.IdElement = idElement;
            this.ElementProperty = elementProperty;
            this.BindingDescription = bindingDescription;
            this.FieldBinding = fieldBinding;
            this.DefaultValue = defaultValue;
        }
        
        /// <summary>
        /// Id of binding definition.
        /// </summary>
        /// <value>Id of binding definition.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Element Id.
        /// </summary>
        /// <value>Element Id.</value>
        [DataMember(Name="idElement", EmitDefaultValue=false)]
        public string IdElement { get; set; }

        /// <summary>
        /// Property name.
        /// </summary>
        /// <value>Property name.</value>
        [DataMember(Name="elementProperty", EmitDefaultValue=false)]
        public string ElementProperty { get; set; }

        /// <summary>
        /// Description for binding.
        /// </summary>
        /// <value>Description for binding.</value>
        [DataMember(Name="bindingDescription", EmitDefaultValue=false)]
        public string BindingDescription { get; set; }

        /// <summary>
        /// Binding field for association.
        /// </summary>
        /// <value>Binding field for association.</value>
        [DataMember(Name="fieldBinding", EmitDefaultValue=false)]
        public string FieldBinding { get; set; }

        /// <summary>
        /// Default value.
        /// </summary>
        /// <value>Default value.</value>
        [DataMember(Name="defaultValue", EmitDefaultValue=false)]
        public Object DefaultValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StampDefinitionBindingElementDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdElement: ").Append(IdElement).Append("\n");
            sb.Append("  ElementProperty: ").Append(ElementProperty).Append("\n");
            sb.Append("  BindingDescription: ").Append(BindingDescription).Append("\n");
            sb.Append("  FieldBinding: ").Append(FieldBinding).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
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
            return this.Equals(input as StampDefinitionBindingElementDTO);
        }

        /// <summary>
        /// Returns true if StampDefinitionBindingElementDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of StampDefinitionBindingElementDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StampDefinitionBindingElementDTO input)
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
                    this.IdElement == input.IdElement ||
                    (this.IdElement != null &&
                    this.IdElement.Equals(input.IdElement))
                ) && 
                (
                    this.ElementProperty == input.ElementProperty ||
                    (this.ElementProperty != null &&
                    this.ElementProperty.Equals(input.ElementProperty))
                ) && 
                (
                    this.BindingDescription == input.BindingDescription ||
                    (this.BindingDescription != null &&
                    this.BindingDescription.Equals(input.BindingDescription))
                ) && 
                (
                    this.FieldBinding == input.FieldBinding ||
                    (this.FieldBinding != null &&
                    this.FieldBinding.Equals(input.FieldBinding))
                ) && 
                (
                    this.DefaultValue == input.DefaultValue ||
                    (this.DefaultValue != null &&
                    this.DefaultValue.Equals(input.DefaultValue))
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
                if (this.IdElement != null)
                    hashCode = hashCode * 59 + this.IdElement.GetHashCode();
                if (this.ElementProperty != null)
                    hashCode = hashCode * 59 + this.ElementProperty.GetHashCode();
                if (this.BindingDescription != null)
                    hashCode = hashCode * 59 + this.BindingDescription.GetHashCode();
                if (this.FieldBinding != null)
                    hashCode = hashCode * 59 + this.FieldBinding.GetHashCode();
                if (this.DefaultValue != null)
                    hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
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

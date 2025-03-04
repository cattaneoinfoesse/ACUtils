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
    /// Class of Folder
    /// </summary>
    [DataContract]
    public partial class FolderDTO :  IEquatable<FolderDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="parentId">Parent Identifier.</param>
        /// <param name="author">Author.</param>
        /// <param name="hasChilds">Has Sub-Level Folders.</param>
        /// <param name="authorCompleteName">Author Name.</param>
        /// <param name="fullPath">Full Path.</param>
        /// <param name="creationDate">Creation Date.</param>
        /// <param name="name">Name.</param>
        /// <param name="archiveMode">Possible values:  0: None  1: AutoWithDefaultProfile  2: ManualWithMask .</param>
        /// <param name="isArxdriveSynced">ArxDrive Folder.</param>
        public FolderDTO(int? id = default(int?), int? parentId = default(int?), int? author = default(int?), bool? hasChilds = default(bool?), string authorCompleteName = default(string), string fullPath = default(string), DateTime? creationDate = default(DateTime?), string name = default(string), int? archiveMode = default(int?), bool? isArxdriveSynced = default(bool?))
        {
            this.Id = id;
            this.ParentId = parentId;
            this.Author = author;
            this.HasChilds = hasChilds;
            this.AuthorCompleteName = authorCompleteName;
            this.FullPath = fullPath;
            this.CreationDate = creationDate;
            this.Name = name;
            this.ArchiveMode = archiveMode;
            this.IsArxdriveSynced = isArxdriveSynced;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Parent Identifier
        /// </summary>
        /// <value>Parent Identifier</value>
        [DataMember(Name="parentId", EmitDefaultValue=false)]
        public int? ParentId { get; set; }

        /// <summary>
        /// Author
        /// </summary>
        /// <value>Author</value>
        [DataMember(Name="author", EmitDefaultValue=false)]
        public int? Author { get; set; }

        /// <summary>
        /// Has Sub-Level Folders
        /// </summary>
        /// <value>Has Sub-Level Folders</value>
        [DataMember(Name="hasChilds", EmitDefaultValue=false)]
        public bool? HasChilds { get; set; }

        /// <summary>
        /// Author Name
        /// </summary>
        /// <value>Author Name</value>
        [DataMember(Name="authorCompleteName", EmitDefaultValue=false)]
        public string AuthorCompleteName { get; set; }

        /// <summary>
        /// Full Path
        /// </summary>
        /// <value>Full Path</value>
        [DataMember(Name="fullPath", EmitDefaultValue=false)]
        public string FullPath { get; set; }

        /// <summary>
        /// Creation Date
        /// </summary>
        /// <value>Creation Date</value>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Possible values:  0: None  1: AutoWithDefaultProfile  2: ManualWithMask 
        /// </summary>
        /// <value>Possible values:  0: None  1: AutoWithDefaultProfile  2: ManualWithMask </value>
        [DataMember(Name="archiveMode", EmitDefaultValue=false)]
        public int? ArchiveMode { get; set; }

        /// <summary>
        /// ArxDrive Folder
        /// </summary>
        /// <value>ArxDrive Folder</value>
        [DataMember(Name="isArxdriveSynced", EmitDefaultValue=false)]
        public bool? IsArxdriveSynced { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FolderDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  HasChilds: ").Append(HasChilds).Append("\n");
            sb.Append("  AuthorCompleteName: ").Append(AuthorCompleteName).Append("\n");
            sb.Append("  FullPath: ").Append(FullPath).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ArchiveMode: ").Append(ArchiveMode).Append("\n");
            sb.Append("  IsArxdriveSynced: ").Append(IsArxdriveSynced).Append("\n");
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
            return this.Equals(input as FolderDTO);
        }

        /// <summary>
        /// Returns true if FolderDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of FolderDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FolderDTO input)
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
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
                ) && 
                (
                    this.HasChilds == input.HasChilds ||
                    (this.HasChilds != null &&
                    this.HasChilds.Equals(input.HasChilds))
                ) && 
                (
                    this.AuthorCompleteName == input.AuthorCompleteName ||
                    (this.AuthorCompleteName != null &&
                    this.AuthorCompleteName.Equals(input.AuthorCompleteName))
                ) && 
                (
                    this.FullPath == input.FullPath ||
                    (this.FullPath != null &&
                    this.FullPath.Equals(input.FullPath))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ArchiveMode == input.ArchiveMode ||
                    (this.ArchiveMode != null &&
                    this.ArchiveMode.Equals(input.ArchiveMode))
                ) && 
                (
                    this.IsArxdriveSynced == input.IsArxdriveSynced ||
                    (this.IsArxdriveSynced != null &&
                    this.IsArxdriveSynced.Equals(input.IsArxdriveSynced))
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
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.HasChilds != null)
                    hashCode = hashCode * 59 + this.HasChilds.GetHashCode();
                if (this.AuthorCompleteName != null)
                    hashCode = hashCode * 59 + this.AuthorCompleteName.GetHashCode();
                if (this.FullPath != null)
                    hashCode = hashCode * 59 + this.FullPath.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ArchiveMode != null)
                    hashCode = hashCode * 59 + this.ArchiveMode.GetHashCode();
                if (this.IsArxdriveSynced != null)
                    hashCode = hashCode * 59 + this.IsArxdriveSynced.GetHashCode();
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

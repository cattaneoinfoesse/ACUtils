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
    /// Set Path database update parameters
    /// </summary>
    [DataContract]
    public partial class SetPathDatabaseForUpdateDTO :  IEquatable<SetPathDatabaseForUpdateDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetPathDatabaseForUpdateDTO" /> class.
        /// </summary>
        /// <param name="dbType">Possible values:  0: SqlServer  1: Mysql  2: Oracle  -1: Nessuno .</param>
        /// <param name="password">Database password.</param>
        /// <param name="id">identifier.</param>
        /// <param name="server">Database host.</param>
        /// <param name="port">Database port.</param>
        /// <param name="database">Database name.</param>
        /// <param name="username">Database username.</param>
        /// <param name="schema">Schema.</param>
        public SetPathDatabaseForUpdateDTO(int? dbType = default(int?), string password = default(string), string id = default(string), string server = default(string), int? port = default(int?), string database = default(string), string username = default(string), string schema = default(string))
        {
            this.DbType = dbType;
            this.Password = password;
            this.Id = id;
            this.Server = server;
            this.Port = port;
            this.Database = database;
            this.Username = username;
            this.Schema = schema;
        }
        
        /// <summary>
        /// Possible values:  0: SqlServer  1: Mysql  2: Oracle  -1: Nessuno 
        /// </summary>
        /// <value>Possible values:  0: SqlServer  1: Mysql  2: Oracle  -1: Nessuno </value>
        [DataMember(Name="dbType", EmitDefaultValue=false)]
        public int? DbType { get; set; }

        /// <summary>
        /// Database password
        /// </summary>
        /// <value>Database password</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// identifier
        /// </summary>
        /// <value>identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Database host
        /// </summary>
        /// <value>Database host</value>
        [DataMember(Name="server", EmitDefaultValue=false)]
        public string Server { get; set; }

        /// <summary>
        /// Database port
        /// </summary>
        /// <value>Database port</value>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public int? Port { get; set; }

        /// <summary>
        /// Database name
        /// </summary>
        /// <value>Database name</value>
        [DataMember(Name="database", EmitDefaultValue=false)]
        public string Database { get; set; }

        /// <summary>
        /// Database username
        /// </summary>
        /// <value>Database username</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Schema
        /// </summary>
        /// <value>Schema</value>
        [DataMember(Name="schema", EmitDefaultValue=false)]
        public string Schema { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetPathDatabaseForUpdateDTO {\n");
            sb.Append("  DbType: ").Append(DbType).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Server: ").Append(Server).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  Database: ").Append(Database).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
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
            return this.Equals(input as SetPathDatabaseForUpdateDTO);
        }

        /// <summary>
        /// Returns true if SetPathDatabaseForUpdateDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SetPathDatabaseForUpdateDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetPathDatabaseForUpdateDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DbType == input.DbType ||
                    (this.DbType != null &&
                    this.DbType.Equals(input.DbType))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Server == input.Server ||
                    (this.Server != null &&
                    this.Server.Equals(input.Server))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.Database == input.Database ||
                    (this.Database != null &&
                    this.Database.Equals(input.Database))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Schema == input.Schema ||
                    (this.Schema != null &&
                    this.Schema.Equals(input.Schema))
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
                if (this.DbType != null)
                    hashCode = hashCode * 59 + this.DbType.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Server != null)
                    hashCode = hashCode * 59 + this.Server.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Database != null)
                    hashCode = hashCode * 59 + this.Database.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Schema != null)
                    hashCode = hashCode * 59 + this.Schema.GetHashCode();
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

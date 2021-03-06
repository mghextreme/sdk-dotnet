/* 
 * directus.io
 *
 * API for directus.io
 *
 * OpenAPI spec version: 1.1
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
using SwaggerDateConverter = IO.Directus.Client.SwaggerDateConverter;

namespace IO.Directus.Model
{
    /// <summary>
    /// GetTableRowsMeta
    /// </summary>
    [DataContract]
    public partial class GetTableRowsMeta :  IEquatable<GetTableRowsMeta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableRowsMeta" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="Table">Table.</param>
        /// <param name="Total">Total.</param>
        /// <param name="Active">Active.</param>
        /// <param name="Delete">Delete.</param>
        /// <param name="Draft">Draft.</param>
        /// <param name="TotalEntries">TotalEntries.</param>
        public GetTableRowsMeta(string Type = default(string), string Table = default(string), int? Total = default(int?), int? Active = default(int?), int? Delete = default(int?), int? Draft = default(int?), int? TotalEntries = default(int?))
        {
            this.Type = Type;
            this.Table = Table;
            this.Total = Total;
            this.Active = Active;
            this.Delete = Delete;
            this.Draft = Draft;
            this.TotalEntries = TotalEntries;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Table
        /// </summary>
        [DataMember(Name="table", EmitDefaultValue=false)]
        public string Table { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="Active", EmitDefaultValue=false)]
        public int? Active { get; set; }

        /// <summary>
        /// Gets or Sets Delete
        /// </summary>
        [DataMember(Name="Delete", EmitDefaultValue=false)]
        public int? Delete { get; set; }

        /// <summary>
        /// Gets or Sets Draft
        /// </summary>
        [DataMember(Name="Draft", EmitDefaultValue=false)]
        public int? Draft { get; set; }

        /// <summary>
        /// Gets or Sets TotalEntries
        /// </summary>
        [DataMember(Name="total_entries", EmitDefaultValue=false)]
        public int? TotalEntries { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTableRowsMeta {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Table: ").Append(Table).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Delete: ").Append(Delete).Append("\n");
            sb.Append("  Draft: ").Append(Draft).Append("\n");
            sb.Append("  TotalEntries: ").Append(TotalEntries).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as GetTableRowsMeta);
        }

        /// <summary>
        /// Returns true if GetTableRowsMeta instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTableRowsMeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTableRowsMeta input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Table == input.Table ||
                    (this.Table != null &&
                    this.Table.Equals(input.Table))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.Delete == input.Delete ||
                    (this.Delete != null &&
                    this.Delete.Equals(input.Delete))
                ) && 
                (
                    this.Draft == input.Draft ||
                    (this.Draft != null &&
                    this.Draft.Equals(input.Draft))
                ) && 
                (
                    this.TotalEntries == input.TotalEntries ||
                    (this.TotalEntries != null &&
                    this.TotalEntries.Equals(input.TotalEntries))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Table != null)
                    hashCode = hashCode * 59 + this.Table.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Delete != null)
                    hashCode = hashCode * 59 + this.Delete.GetHashCode();
                if (this.Draft != null)
                    hashCode = hashCode * 59 + this.Draft.GetHashCode();
                if (this.TotalEntries != null)
                    hashCode = hashCode * 59 + this.TotalEntries.GetHashCode();
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

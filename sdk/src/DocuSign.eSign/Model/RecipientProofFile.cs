/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
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
using SwaggerDateConverter = DocuSign.eSign.Client.SwaggerDateConverter;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// RecipientProofFile
    /// </summary>
    [DataContract]
    public partial class RecipientProofFile :  IEquatable<RecipientProofFile>, IValidatableObject
    {
        public RecipientProofFile()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientProofFile" /> class.
        /// </summary>
        /// <param name="IsInProofFile">IsInProofFile.</param>
        public RecipientProofFile(string IsInProofFile = default(string))
        {
            this.IsInProofFile = IsInProofFile;
        }
        
        /// <summary>
        /// Gets or Sets IsInProofFile
        /// </summary>
        [DataMember(Name="isInProofFile", EmitDefaultValue=false)]
        public string IsInProofFile { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientProofFile {\n");
            sb.Append("  IsInProofFile: ").Append(IsInProofFile).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as RecipientProofFile);
        }

        /// <summary>
        /// Returns true if RecipientProofFile instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientProofFile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientProofFile other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IsInProofFile == other.IsInProofFile ||
                    this.IsInProofFile != null &&
                    this.IsInProofFile.Equals(other.IsInProofFile)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.IsInProofFile != null)
                    hash = hash * 59 + this.IsInProofFile.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}

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

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// DocumentHtmlDisplayAnchor
    /// </summary>
    [DataContract]
    public partial class DocumentHtmlDisplayAnchor :  IEquatable<DocumentHtmlDisplayAnchor>, IValidatableObject
    {
        public DocumentHtmlDisplayAnchor()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentHtmlDisplayAnchor" /> class.
        /// </summary>
        /// <param name="CaseSensitive">.</param>
        /// <param name="DisplaySettings">DisplaySettings.</param>
        /// <param name="EndAnchor">.</param>
        /// <param name="RemoveEndAnchor">.</param>
        /// <param name="RemoveStartAnchor">.</param>
        /// <param name="StartAnchor">.</param>
        public DocumentHtmlDisplayAnchor(bool? CaseSensitive = default(bool?), DocumentHtmlDisplaySettings DisplaySettings = default(DocumentHtmlDisplaySettings), string EndAnchor = default(string), bool? RemoveEndAnchor = default(bool?), bool? RemoveStartAnchor = default(bool?), string StartAnchor = default(string))
        {
            this.CaseSensitive = CaseSensitive;
            this.DisplaySettings = DisplaySettings;
            this.EndAnchor = EndAnchor;
            this.RemoveEndAnchor = RemoveEndAnchor;
            this.RemoveStartAnchor = RemoveStartAnchor;
            this.StartAnchor = StartAnchor;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="caseSensitive", EmitDefaultValue=false)]
        public bool? CaseSensitive { get; set; }
        /// <summary>
        /// Gets or Sets DisplaySettings
        /// </summary>
        [DataMember(Name="displaySettings", EmitDefaultValue=false)]
        public DocumentHtmlDisplaySettings DisplaySettings { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="endAnchor", EmitDefaultValue=false)]
        public string EndAnchor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="removeEndAnchor", EmitDefaultValue=false)]
        public bool? RemoveEndAnchor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="removeStartAnchor", EmitDefaultValue=false)]
        public bool? RemoveStartAnchor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="startAnchor", EmitDefaultValue=false)]
        public string StartAnchor { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentHtmlDisplayAnchor {\n");
            sb.Append("  CaseSensitive: ").Append(CaseSensitive).Append("\n");
            sb.Append("  DisplaySettings: ").Append(DisplaySettings).Append("\n");
            sb.Append("  EndAnchor: ").Append(EndAnchor).Append("\n");
            sb.Append("  RemoveEndAnchor: ").Append(RemoveEndAnchor).Append("\n");
            sb.Append("  RemoveStartAnchor: ").Append(RemoveStartAnchor).Append("\n");
            sb.Append("  StartAnchor: ").Append(StartAnchor).Append("\n");
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
            return this.Equals(obj as DocumentHtmlDisplayAnchor);
        }

        /// <summary>
        /// Returns true if DocumentHtmlDisplayAnchor instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentHtmlDisplayAnchor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentHtmlDisplayAnchor other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CaseSensitive == other.CaseSensitive ||
                    this.CaseSensitive != null &&
                    this.CaseSensitive.Equals(other.CaseSensitive)
                ) && 
                (
                    this.DisplaySettings == other.DisplaySettings ||
                    this.DisplaySettings != null &&
                    this.DisplaySettings.Equals(other.DisplaySettings)
                ) && 
                (
                    this.EndAnchor == other.EndAnchor ||
                    this.EndAnchor != null &&
                    this.EndAnchor.Equals(other.EndAnchor)
                ) && 
                (
                    this.RemoveEndAnchor == other.RemoveEndAnchor ||
                    this.RemoveEndAnchor != null &&
                    this.RemoveEndAnchor.Equals(other.RemoveEndAnchor)
                ) && 
                (
                    this.RemoveStartAnchor == other.RemoveStartAnchor ||
                    this.RemoveStartAnchor != null &&
                    this.RemoveStartAnchor.Equals(other.RemoveStartAnchor)
                ) && 
                (
                    this.StartAnchor == other.StartAnchor ||
                    this.StartAnchor != null &&
                    this.StartAnchor.Equals(other.StartAnchor)
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
                if (this.CaseSensitive != null)
                    hash = hash * 59 + this.CaseSensitive.GetHashCode();
                if (this.DisplaySettings != null)
                    hash = hash * 59 + this.DisplaySettings.GetHashCode();
                if (this.EndAnchor != null)
                    hash = hash * 59 + this.EndAnchor.GetHashCode();
                if (this.RemoveEndAnchor != null)
                    hash = hash * 59 + this.RemoveEndAnchor.GetHashCode();
                if (this.RemoveStartAnchor != null)
                    hash = hash * 59 + this.RemoveStartAnchor.GetHashCode();
                if (this.StartAnchor != null)
                    hash = hash * 59 + this.StartAnchor.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}

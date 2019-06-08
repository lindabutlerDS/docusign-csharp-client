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
    /// AccountIdentityVerificationWorkflow
    /// </summary>
    [DataContract]
    public partial class AccountIdentityVerificationWorkflow :  IEquatable<AccountIdentityVerificationWorkflow>, IValidatableObject
    {
        public AccountIdentityVerificationWorkflow()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountIdentityVerificationWorkflow" /> class.
        /// </summary>
        /// <param name="DefaultDescription">.</param>
        /// <param name="DefaultName">.</param>
        /// <param name="SignatureProvider">SignatureProvider.</param>
        /// <param name="Steps">.</param>
        /// <param name="WorkflowId">.</param>
        /// <param name="WorkflowResourceKey">.</param>
        public AccountIdentityVerificationWorkflow(string DefaultDescription = default(string), string DefaultName = default(string), AccountSignatureProvider SignatureProvider = default(AccountSignatureProvider), List<AccountIdentityVerificationStep> Steps = default(List<AccountIdentityVerificationStep>), string WorkflowId = default(string), string WorkflowResourceKey = default(string))
        {
            this.DefaultDescription = DefaultDescription;
            this.DefaultName = DefaultName;
            this.SignatureProvider = SignatureProvider;
            this.Steps = Steps;
            this.WorkflowId = WorkflowId;
            this.WorkflowResourceKey = WorkflowResourceKey;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="defaultDescription", EmitDefaultValue=false)]
        public string DefaultDescription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="defaultName", EmitDefaultValue=false)]
        public string DefaultName { get; set; }
        /// <summary>
        /// Gets or Sets SignatureProvider
        /// </summary>
        [DataMember(Name="signatureProvider", EmitDefaultValue=false)]
        public AccountSignatureProvider SignatureProvider { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="steps", EmitDefaultValue=false)]
        public List<AccountIdentityVerificationStep> Steps { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="workflowId", EmitDefaultValue=false)]
        public string WorkflowId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="workflowResourceKey", EmitDefaultValue=false)]
        public string WorkflowResourceKey { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountIdentityVerificationWorkflow {\n");
            sb.Append("  DefaultDescription: ").Append(DefaultDescription).Append("\n");
            sb.Append("  DefaultName: ").Append(DefaultName).Append("\n");
            sb.Append("  SignatureProvider: ").Append(SignatureProvider).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("  WorkflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  WorkflowResourceKey: ").Append(WorkflowResourceKey).Append("\n");
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
            return this.Equals(obj as AccountIdentityVerificationWorkflow);
        }

        /// <summary>
        /// Returns true if AccountIdentityVerificationWorkflow instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountIdentityVerificationWorkflow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountIdentityVerificationWorkflow other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DefaultDescription == other.DefaultDescription ||
                    this.DefaultDescription != null &&
                    this.DefaultDescription.Equals(other.DefaultDescription)
                ) && 
                (
                    this.DefaultName == other.DefaultName ||
                    this.DefaultName != null &&
                    this.DefaultName.Equals(other.DefaultName)
                ) && 
                (
                    this.SignatureProvider == other.SignatureProvider ||
                    this.SignatureProvider != null &&
                    this.SignatureProvider.Equals(other.SignatureProvider)
                ) && 
                (
                    this.Steps == other.Steps ||
                    this.Steps != null &&
                    this.Steps.SequenceEqual(other.Steps)
                ) && 
                (
                    this.WorkflowId == other.WorkflowId ||
                    this.WorkflowId != null &&
                    this.WorkflowId.Equals(other.WorkflowId)
                ) && 
                (
                    this.WorkflowResourceKey == other.WorkflowResourceKey ||
                    this.WorkflowResourceKey != null &&
                    this.WorkflowResourceKey.Equals(other.WorkflowResourceKey)
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
                if (this.DefaultDescription != null)
                    hash = hash * 59 + this.DefaultDescription.GetHashCode();
                if (this.DefaultName != null)
                    hash = hash * 59 + this.DefaultName.GetHashCode();
                if (this.SignatureProvider != null)
                    hash = hash * 59 + this.SignatureProvider.GetHashCode();
                if (this.Steps != null)
                    hash = hash * 59 + this.Steps.GetHashCode();
                if (this.WorkflowId != null)
                    hash = hash * 59 + this.WorkflowId.GetHashCode();
                if (this.WorkflowResourceKey != null)
                    hash = hash * 59 + this.WorkflowResourceKey.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}

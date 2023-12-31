/*
 * Agent API
 *
 * The Neuron® publishes an Agent API that can be used by agents that do not wish to, or are able to, connect to the Neuron® via any of the XMPP bindings available, such as standard binary  socket, websocket or Synchronous HTTP (BOSH). Via the Agent API, the agent is permitted to do  basic tasks, such as send messages, create Agent IDs, and sign contracts with such Agent IDs.  The Full API is 
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Neuron.Agent.Client.OpenAPIDateConverter;

namespace Neuron.Agent.Model
{
    /// <summary>
    /// AddIdAttachmentBody
    /// </summary>
    [DataContract(Name = "AddIdAttachmentBody")]
    public partial class AddIdAttachmentBody : IEquatable<AddIdAttachmentBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddIdAttachmentBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddIdAttachmentBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddIdAttachmentBody" /> class.
        /// </summary>
        /// <param name="keyId">Identity of key to use for signing the Identity application. (required).</param>
        /// <param name="legalId">Identity of the Legal Identity Application. (required).</param>
        /// <param name="nonce">A unique random string, at least 32 characters long, with sufficient entropy to not be reused again. If reused, an error will be returned. (required).</param>
        /// <param name="keySignature">Cryptographic signature of the key ID, using the key password.  (required).</param>
        /// <param name="requestSignature">Cryptographic signature of the request, using the account password.  (required).</param>
        /// <param name="attachmentBase64">Base-64-encoding of attachment to add to the Identity application. (required).</param>
        /// <param name="attachmentFileName">File name of attachment. (required).</param>
        /// <param name="attachmentContentType">Content type of attachment. (required).</param>
        public AddIdAttachmentBody(string keyId = default(string), string legalId = default(string), string nonce = default(string), string keySignature = default(string), string requestSignature = default(string), string attachmentBase64 = default(string), string attachmentFileName = default(string), string attachmentContentType = default(string))
        {
            // to ensure "keyId" is required (not null)
            if (keyId == null)
            {
                throw new ArgumentNullException("keyId is a required property for AddIdAttachmentBody and cannot be null");
            }
            this.KeyId = keyId;
            // to ensure "legalId" is required (not null)
            if (legalId == null)
            {
                throw new ArgumentNullException("legalId is a required property for AddIdAttachmentBody and cannot be null");
            }
            this.LegalId = legalId;
            // to ensure "nonce" is required (not null)
            if (nonce == null)
            {
                throw new ArgumentNullException("nonce is a required property for AddIdAttachmentBody and cannot be null");
            }
            this.Nonce = nonce;
            // to ensure "keySignature" is required (not null)
            if (keySignature == null)
            {
                throw new ArgumentNullException("keySignature is a required property for AddIdAttachmentBody and cannot be null");
            }
            this.KeySignature = keySignature;
            // to ensure "requestSignature" is required (not null)
            if (requestSignature == null)
            {
                throw new ArgumentNullException("requestSignature is a required property for AddIdAttachmentBody and cannot be null");
            }
            this.RequestSignature = requestSignature;
            // to ensure "attachmentBase64" is required (not null)
            if (attachmentBase64 == null)
            {
                throw new ArgumentNullException("attachmentBase64 is a required property for AddIdAttachmentBody and cannot be null");
            }
            this.AttachmentBase64 = attachmentBase64;
            // to ensure "attachmentFileName" is required (not null)
            if (attachmentFileName == null)
            {
                throw new ArgumentNullException("attachmentFileName is a required property for AddIdAttachmentBody and cannot be null");
            }
            this.AttachmentFileName = attachmentFileName;
            // to ensure "attachmentContentType" is required (not null)
            if (attachmentContentType == null)
            {
                throw new ArgumentNullException("attachmentContentType is a required property for AddIdAttachmentBody and cannot be null");
            }
            this.AttachmentContentType = attachmentContentType;
        }

        /// <summary>
        /// Identity of key to use for signing the Identity application.
        /// </summary>
        /// <value>Identity of key to use for signing the Identity application.</value>
        [DataMember(Name = "keyId", IsRequired = true, EmitDefaultValue = true)]
        public string KeyId { get; set; }

        /// <summary>
        /// Identity of the Legal Identity Application.
        /// </summary>
        /// <value>Identity of the Legal Identity Application.</value>
        [DataMember(Name = "legalId", IsRequired = true, EmitDefaultValue = true)]
        public string LegalId { get; set; }

        /// <summary>
        /// A unique random string, at least 32 characters long, with sufficient entropy to not be reused again. If reused, an error will be returned.
        /// </summary>
        /// <value>A unique random string, at least 32 characters long, with sufficient entropy to not be reused again. If reused, an error will be returned.</value>
        [DataMember(Name = "nonce", IsRequired = true, EmitDefaultValue = true)]
        public string Nonce { get; set; }

        /// <summary>
        /// Cryptographic signature of the key ID, using the key password. 
        /// </summary>
        /// <value>Cryptographic signature of the key ID, using the key password. </value>
        [DataMember(Name = "keySignature", IsRequired = true, EmitDefaultValue = true)]
        public string KeySignature { get; set; }

        /// <summary>
        /// Cryptographic signature of the request, using the account password. 
        /// </summary>
        /// <value>Cryptographic signature of the request, using the account password. </value>
        [DataMember(Name = "requestSignature", IsRequired = true, EmitDefaultValue = true)]
        public string RequestSignature { get; set; }

        /// <summary>
        /// Base-64-encoding of attachment to add to the Identity application.
        /// </summary>
        /// <value>Base-64-encoding of attachment to add to the Identity application.</value>
        [DataMember(Name = "attachmentBase64", IsRequired = true, EmitDefaultValue = true)]
        public string AttachmentBase64 { get; set; }

        /// <summary>
        /// File name of attachment.
        /// </summary>
        /// <value>File name of attachment.</value>
        [DataMember(Name = "attachmentFileName", IsRequired = true, EmitDefaultValue = true)]
        public string AttachmentFileName { get; set; }

        /// <summary>
        /// Content type of attachment.
        /// </summary>
        /// <value>Content type of attachment.</value>
        [DataMember(Name = "attachmentContentType", IsRequired = true, EmitDefaultValue = true)]
        public string AttachmentContentType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddIdAttachmentBody {\n");
            sb.Append("  KeyId: ").Append(KeyId).Append("\n");
            sb.Append("  LegalId: ").Append(LegalId).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  KeySignature: ").Append(KeySignature).Append("\n");
            sb.Append("  RequestSignature: ").Append(RequestSignature).Append("\n");
            sb.Append("  AttachmentBase64: ").Append(AttachmentBase64).Append("\n");
            sb.Append("  AttachmentFileName: ").Append(AttachmentFileName).Append("\n");
            sb.Append("  AttachmentContentType: ").Append(AttachmentContentType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddIdAttachmentBody);
        }

        /// <summary>
        /// Returns true if AddIdAttachmentBody instances are equal
        /// </summary>
        /// <param name="input">Instance of AddIdAttachmentBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddIdAttachmentBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.KeyId == input.KeyId ||
                    (this.KeyId != null &&
                    this.KeyId.Equals(input.KeyId))
                ) && 
                (
                    this.LegalId == input.LegalId ||
                    (this.LegalId != null &&
                    this.LegalId.Equals(input.LegalId))
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    (this.Nonce != null &&
                    this.Nonce.Equals(input.Nonce))
                ) && 
                (
                    this.KeySignature == input.KeySignature ||
                    (this.KeySignature != null &&
                    this.KeySignature.Equals(input.KeySignature))
                ) && 
                (
                    this.RequestSignature == input.RequestSignature ||
                    (this.RequestSignature != null &&
                    this.RequestSignature.Equals(input.RequestSignature))
                ) && 
                (
                    this.AttachmentBase64 == input.AttachmentBase64 ||
                    (this.AttachmentBase64 != null &&
                    this.AttachmentBase64.Equals(input.AttachmentBase64))
                ) && 
                (
                    this.AttachmentFileName == input.AttachmentFileName ||
                    (this.AttachmentFileName != null &&
                    this.AttachmentFileName.Equals(input.AttachmentFileName))
                ) && 
                (
                    this.AttachmentContentType == input.AttachmentContentType ||
                    (this.AttachmentContentType != null &&
                    this.AttachmentContentType.Equals(input.AttachmentContentType))
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
                if (this.KeyId != null)
                {
                    hashCode = (hashCode * 59) + this.KeyId.GetHashCode();
                }
                if (this.LegalId != null)
                {
                    hashCode = (hashCode * 59) + this.LegalId.GetHashCode();
                }
                if (this.Nonce != null)
                {
                    hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
                }
                if (this.KeySignature != null)
                {
                    hashCode = (hashCode * 59) + this.KeySignature.GetHashCode();
                }
                if (this.RequestSignature != null)
                {
                    hashCode = (hashCode * 59) + this.RequestSignature.GetHashCode();
                }
                if (this.AttachmentBase64 != null)
                {
                    hashCode = (hashCode * 59) + this.AttachmentBase64.GetHashCode();
                }
                if (this.AttachmentFileName != null)
                {
                    hashCode = (hashCode * 59) + this.AttachmentFileName.GetHashCode();
                }
                if (this.AttachmentContentType != null)
                {
                    hashCode = (hashCode * 59) + this.AttachmentContentType.GetHashCode();
                }
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

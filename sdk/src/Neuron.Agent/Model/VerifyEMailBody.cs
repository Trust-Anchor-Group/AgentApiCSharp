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
    /// VerifyEMailBody
    /// </summary>
    [DataContract(Name = "VerifyEMailBody")]
    public partial class VerifyEMailBody : IEquatable<VerifyEMailBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyEMailBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VerifyEMailBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyEMailBody" /> class.
        /// </summary>
        /// <param name="eMail">The e-mail address to verify. (required).</param>
        /// <param name="code">The verification code. (required).</param>
        public VerifyEMailBody(string eMail = default(string), string code = default(string))
        {
            // to ensure "eMail" is required (not null)
            if (eMail == null)
            {
                throw new ArgumentNullException("eMail is a required property for VerifyEMailBody and cannot be null");
            }
            this.EMail = eMail;
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for VerifyEMailBody and cannot be null");
            }
            this.Code = code;
        }

        /// <summary>
        /// The e-mail address to verify.
        /// </summary>
        /// <value>The e-mail address to verify.</value>
        [DataMember(Name = "eMail", IsRequired = true, EmitDefaultValue = true)]
        public string EMail { get; set; }

        /// <summary>
        /// The verification code.
        /// </summary>
        /// <value>The verification code.</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VerifyEMailBody {\n");
            sb.Append("  EMail: ").Append(EMail).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return this.Equals(input as VerifyEMailBody);
        }

        /// <summary>
        /// Returns true if VerifyEMailBody instances are equal
        /// </summary>
        /// <param name="input">Instance of VerifyEMailBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerifyEMailBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EMail == input.EMail ||
                    (this.EMail != null &&
                    this.EMail.Equals(input.EMail))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
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
                if (this.EMail != null)
                {
                    hashCode = (hashCode * 59) + this.EMail.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
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

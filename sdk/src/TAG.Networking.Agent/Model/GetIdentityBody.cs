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
using OpenAPIDateConverter = TAG.Networking.Agent.Client.OpenAPIDateConverter;

namespace TAG.Networking.Agent.Model
{
    /// <summary>
    /// GetIdentityBody
    /// </summary>
    [DataContract(Name = "GetIdentityBody")]
    public partial class GetIdentityBody : IEquatable<GetIdentityBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetIdentityBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetIdentityBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetIdentityBody" /> class.
        /// </summary>
        /// <param name="legalId">Identity of the Legal Identity to get. (required).</param>
        public GetIdentityBody(string legalId = default(string))
        {
            // to ensure "legalId" is required (not null)
            if (legalId == null)
            {
                throw new ArgumentNullException("legalId is a required property for GetIdentityBody and cannot be null");
            }
            this.LegalId = legalId;
        }

        /// <summary>
        /// Identity of the Legal Identity to get.
        /// </summary>
        /// <value>Identity of the Legal Identity to get.</value>
        [DataMember(Name = "legalId", IsRequired = true, EmitDefaultValue = true)]
        public string LegalId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetIdentityBody {\n");
            sb.Append("  LegalId: ").Append(LegalId).Append("\n");
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
            return this.Equals(input as GetIdentityBody);
        }

        /// <summary>
        /// Returns true if GetIdentityBody instances are equal
        /// </summary>
        /// <param name="input">Instance of GetIdentityBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetIdentityBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LegalId == input.LegalId ||
                    (this.LegalId != null &&
                    this.LegalId.Equals(input.LegalId))
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
                if (this.LegalId != null)
                {
                    hashCode = (hashCode * 59) + this.LegalId.GetHashCode();
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

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
    /// StanzaResult
    /// </summary>
    [DataContract(Name = "StanzaResult")]
    public partial class StanzaResult : IEquatable<StanzaResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StanzaResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StanzaResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StanzaResult" /> class.
        /// </summary>
        /// <param name="sent">Whether the XMPP stanza was sent or not. (required).</param>
        /// <param name="id">ID of stanza sent. Can be used to update message. If no ID was provided in the call, a message ID will be generated. (required).</param>
        public StanzaResult(bool sent = default(bool), string id = default(string))
        {
            this.Sent = sent;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for StanzaResult and cannot be null");
            }
            this.Id = id;
        }

        /// <summary>
        /// Whether the XMPP stanza was sent or not.
        /// </summary>
        /// <value>Whether the XMPP stanza was sent or not.</value>
        [DataMember(Name = "sent", IsRequired = true, EmitDefaultValue = true)]
        public bool Sent { get; set; }

        /// <summary>
        /// ID of stanza sent. Can be used to update message. If no ID was provided in the call, a message ID will be generated.
        /// </summary>
        /// <value>ID of stanza sent. Can be used to update message. If no ID was provided in the call, a message ID will be generated.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StanzaResult {\n");
            sb.Append("  Sent: ").Append(Sent).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as StanzaResult);
        }

        /// <summary>
        /// Returns true if StanzaResult instances are equal
        /// </summary>
        /// <param name="input">Instance of StanzaResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StanzaResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Sent == input.Sent ||
                    this.Sent.Equals(input.Sent)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                hashCode = (hashCode * 59) + this.Sent.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
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

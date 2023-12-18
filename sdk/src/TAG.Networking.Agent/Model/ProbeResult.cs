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
    /// ProbeResult
    /// </summary>
    [DataContract(Name = "ProbeResult")]
    public partial class ProbeResult : IEquatable<ProbeResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProbeResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProbeResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProbeResult" /> class.
        /// </summary>
        /// <param name="jid">Bare JID of contact to whom the presence probe is directed. (required).</param>
        /// <param name="type">Type of presence sent. Can be the empty string (meaning available) or unavailable. (required).</param>
        /// <param name="recieved">When presence was received by the server of the contact. (required).</param>
        /// <param name="stanza">The XML stanza that was sent. (required).</param>
        public ProbeResult(string jid = default(string), string type = default(string), int recieved = default(int), string stanza = default(string))
        {
            // to ensure "jid" is required (not null)
            if (jid == null)
            {
                throw new ArgumentNullException("jid is a required property for ProbeResult and cannot be null");
            }
            this.Jid = jid;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for ProbeResult and cannot be null");
            }
            this.Type = type;
            this.Recieved = recieved;
            // to ensure "stanza" is required (not null)
            if (stanza == null)
            {
                throw new ArgumentNullException("stanza is a required property for ProbeResult and cannot be null");
            }
            this.Stanza = stanza;
        }

        /// <summary>
        /// Bare JID of contact to whom the presence probe is directed.
        /// </summary>
        /// <value>Bare JID of contact to whom the presence probe is directed.</value>
        [DataMember(Name = "jid", IsRequired = true, EmitDefaultValue = true)]
        public string Jid { get; set; }

        /// <summary>
        /// Type of presence sent. Can be the empty string (meaning available) or unavailable.
        /// </summary>
        /// <value>Type of presence sent. Can be the empty string (meaning available) or unavailable.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// When presence was received by the server of the contact.
        /// </summary>
        /// <value>When presence was received by the server of the contact.</value>
        [DataMember(Name = "recieved", IsRequired = true, EmitDefaultValue = true)]
        public int Recieved { get; set; }

        /// <summary>
        /// The XML stanza that was sent.
        /// </summary>
        /// <value>The XML stanza that was sent.</value>
        [DataMember(Name = "Stanza", IsRequired = true, EmitDefaultValue = true)]
        public string Stanza { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProbeResult {\n");
            sb.Append("  Jid: ").Append(Jid).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Recieved: ").Append(Recieved).Append("\n");
            sb.Append("  Stanza: ").Append(Stanza).Append("\n");
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
            return this.Equals(input as ProbeResult);
        }

        /// <summary>
        /// Returns true if ProbeResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ProbeResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProbeResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Jid == input.Jid ||
                    (this.Jid != null &&
                    this.Jid.Equals(input.Jid))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Recieved == input.Recieved ||
                    this.Recieved.Equals(input.Recieved)
                ) && 
                (
                    this.Stanza == input.Stanza ||
                    (this.Stanza != null &&
                    this.Stanza.Equals(input.Stanza))
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
                if (this.Jid != null)
                {
                    hashCode = (hashCode * 59) + this.Jid.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Recieved.GetHashCode();
                if (this.Stanza != null)
                {
                    hashCode = (hashCode * 59) + this.Stanza.GetHashCode();
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

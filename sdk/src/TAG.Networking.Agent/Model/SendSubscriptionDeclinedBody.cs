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
    /// SendSubscriptionDeclinedBody
    /// </summary>
    [DataContract(Name = "SendSubscriptionDeclinedBody")]
    public partial class SendSubscriptionDeclinedBody : IEquatable<SendSubscriptionDeclinedBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendSubscriptionDeclinedBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SendSubscriptionDeclinedBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SendSubscriptionDeclinedBody" /> class.
        /// </summary>
        /// <param name="to">A Bare or Full JID (XMPP network address). (required).</param>
        /// <param name="id">Optional Message ID..</param>
        public SendSubscriptionDeclinedBody(string to = default(string), string id = default(string))
        {
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new ArgumentNullException("to is a required property for SendSubscriptionDeclinedBody and cannot be null");
            }
            this.To = to;
            this.Id = id;
        }

        /// <summary>
        /// A Bare or Full JID (XMPP network address).
        /// </summary>
        /// <value>A Bare or Full JID (XMPP network address).</value>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = true)]
        public string To { get; set; }

        /// <summary>
        /// Optional Message ID.
        /// </summary>
        /// <value>Optional Message ID.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SendSubscriptionDeclinedBody {\n");
            sb.Append("  To: ").Append(To).Append("\n");
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
            return this.Equals(input as SendSubscriptionDeclinedBody);
        }

        /// <summary>
        /// Returns true if SendSubscriptionDeclinedBody instances are equal
        /// </summary>
        /// <param name="input">Instance of SendSubscriptionDeclinedBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendSubscriptionDeclinedBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
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
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
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

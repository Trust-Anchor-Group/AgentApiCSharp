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
    /// SendPresenceSubscriptionBody
    /// </summary>
    [DataContract(Name = "SendPresenceSubscriptionBody")]
    public partial class SendPresenceSubscriptionBody : IEquatable<SendPresenceSubscriptionBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendPresenceSubscriptionBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SendPresenceSubscriptionBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SendPresenceSubscriptionBody" /> class.
        /// </summary>
        /// <param name="to">A Bare or Full JID (XMPP network address). (required).</param>
        /// <param name="customXml">Optional Custom XML that can be added to the presence subscription request..</param>
        /// <param name="language">Optional ISO 639-1 language code..</param>
        /// <param name="id">Optional Message ID..</param>
        public SendPresenceSubscriptionBody(string to = default(string), string customXml = default(string), string language = default(string), string id = default(string))
        {
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new ArgumentNullException("to is a required property for SendPresenceSubscriptionBody and cannot be null");
            }
            this.To = to;
            this.CustomXml = customXml;
            this.Language = language;
            this.Id = id;
        }

        /// <summary>
        /// A Bare or Full JID (XMPP network address).
        /// </summary>
        /// <value>A Bare or Full JID (XMPP network address).</value>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = true)]
        public string To { get; set; }

        /// <summary>
        /// Optional Custom XML that can be added to the presence subscription request.
        /// </summary>
        /// <value>Optional Custom XML that can be added to the presence subscription request.</value>
        [DataMember(Name = "customXml", EmitDefaultValue = false)]
        public string CustomXml { get; set; }

        /// <summary>
        /// Optional ISO 639-1 language code.
        /// </summary>
        /// <value>Optional ISO 639-1 language code.</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; set; }

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
            sb.Append("class SendPresenceSubscriptionBody {\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  CustomXml: ").Append(CustomXml).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
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
            return this.Equals(input as SendPresenceSubscriptionBody);
        }

        /// <summary>
        /// Returns true if SendPresenceSubscriptionBody instances are equal
        /// </summary>
        /// <param name="input">Instance of SendPresenceSubscriptionBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendPresenceSubscriptionBody input)
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
                    this.CustomXml == input.CustomXml ||
                    (this.CustomXml != null &&
                    this.CustomXml.Equals(input.CustomXml))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
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
                if (this.CustomXml != null)
                {
                    hashCode = (hashCode * 59) + this.CustomXml.GetHashCode();
                }
                if (this.Language != null)
                {
                    hashCode = (hashCode * 59) + this.Language.GetHashCode();
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

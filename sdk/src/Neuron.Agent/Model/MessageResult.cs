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
    /// MessageResult
    /// </summary>
    [DataContract(Name = "MessageResult")]
    public partial class MessageResult : IEquatable<MessageResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessageResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageResult" /> class.
        /// </summary>
        /// <param name="messages">messages (required).</param>
        public MessageResult(List<Message> messages = default(List<Message>))
        {
            // to ensure "messages" is required (not null)
            if (messages == null)
            {
                throw new ArgumentNullException("messages is a required property for MessageResult and cannot be null");
            }
            this.Messages = messages;
        }

        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name = "messages", IsRequired = true, EmitDefaultValue = true)]
        public List<Message> Messages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MessageResult {\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
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
            return this.Equals(input as MessageResult);
        }

        /// <summary>
        /// Returns true if MessageResult instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Messages == input.Messages ||
                    this.Messages != null &&
                    input.Messages != null &&
                    this.Messages.SequenceEqual(input.Messages)
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
                if (this.Messages != null)
                {
                    hashCode = (hashCode * 59) + this.Messages.GetHashCode();
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

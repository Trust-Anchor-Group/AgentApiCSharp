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
    /// PopMessagesBody
    /// </summary>
    [DataContract(Name = "PopMessagesBody")]
    public partial class PopMessagesBody : IEquatable<PopMessagesBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PopMessagesBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PopMessagesBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PopMessagesBody" /> class.
        /// </summary>
        /// <param name="maxCount">Maximum number of messages to return. (required).</param>
        public PopMessagesBody(int maxCount = default(int))
        {
            this.MaxCount = maxCount;
        }

        /// <summary>
        /// Maximum number of messages to return.
        /// </summary>
        /// <value>Maximum number of messages to return.</value>
        [DataMember(Name = "maxCount", IsRequired = true, EmitDefaultValue = true)]
        public int MaxCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PopMessagesBody {\n");
            sb.Append("  MaxCount: ").Append(MaxCount).Append("\n");
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
            return this.Equals(input as PopMessagesBody);
        }

        /// <summary>
        /// Returns true if PopMessagesBody instances are equal
        /// </summary>
        /// <param name="input">Instance of PopMessagesBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PopMessagesBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MaxCount == input.MaxCount ||
                    this.MaxCount.Equals(input.MaxCount)
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
                hashCode = (hashCode * 59) + this.MaxCount.GetHashCode();
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

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
    /// GetRosterBody
    /// </summary>
    [DataContract(Name = "GetRosterBody")]
    public partial class GetRosterBody : IEquatable<GetRosterBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetRosterBody" /> class.
        /// </summary>
        /// <param name="offset">Offset into the roster where response begins..</param>
        /// <param name="maxCount">Maximum number of roster items to return..</param>
        public GetRosterBody(int offset = default(int), int maxCount = default(int))
        {
            this.Offset = offset;
            this.MaxCount = maxCount;
        }

        /// <summary>
        /// Offset into the roster where response begins.
        /// </summary>
        /// <value>Offset into the roster where response begins.</value>
        [DataMember(Name = "offset", EmitDefaultValue = false)]
        public int Offset { get; set; }

        /// <summary>
        /// Maximum number of roster items to return.
        /// </summary>
        /// <value>Maximum number of roster items to return.</value>
        [DataMember(Name = "maxCount", EmitDefaultValue = false)]
        public int MaxCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetRosterBody {\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
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
            return this.Equals(input as GetRosterBody);
        }

        /// <summary>
        /// Returns true if GetRosterBody instances are equal
        /// </summary>
        /// <param name="input">Instance of GetRosterBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetRosterBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Offset == input.Offset ||
                    this.Offset.Equals(input.Offset)
                ) && 
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
                hashCode = (hashCode * 59) + this.Offset.GetHashCode();
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

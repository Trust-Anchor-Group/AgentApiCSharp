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
    /// RefreshBody
    /// </summary>
    [DataContract(Name = "RefreshBody")]
    public partial class RefreshBody : IEquatable<RefreshBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefreshBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RefreshBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RefreshBody" /> class.
        /// </summary>
        /// <param name="seconds">The number of seconds until the request expires. (required).</param>
        public RefreshBody(int seconds = default(int))
        {
            this.Seconds = seconds;
        }

        /// <summary>
        /// The number of seconds until the request expires.
        /// </summary>
        /// <value>The number of seconds until the request expires.</value>
        [DataMember(Name = "seconds", IsRequired = true, EmitDefaultValue = true)]
        public int Seconds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RefreshBody {\n");
            sb.Append("  Seconds: ").Append(Seconds).Append("\n");
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
            return this.Equals(input as RefreshBody);
        }

        /// <summary>
        /// Returns true if RefreshBody instances are equal
        /// </summary>
        /// <param name="input">Instance of RefreshBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefreshBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Seconds == input.Seconds ||
                    this.Seconds.Equals(input.Seconds)
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
                hashCode = (hashCode * 59) + this.Seconds.GetHashCode();
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
            // Seconds (int) maximum
            if (this.Seconds > (int)3600)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Seconds, must be a value less than or equal to 3600.", new [] { "Seconds" });
            }

            // Seconds (int) minimum
            if (this.Seconds < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Seconds, must be a value greater than or equal to 0.", new [] { "Seconds" });
            }

            yield break;
        }
    }

}

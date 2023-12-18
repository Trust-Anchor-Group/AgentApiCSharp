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
    /// GetBalanceResponse
    /// </summary>
    [DataContract(Name = "GetBalanceResponse")]
    public partial class GetBalanceResponse : IEquatable<GetBalanceResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetBalanceResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetBalanceResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetBalanceResponse" /> class.
        /// </summary>
        /// <param name="amount">Current amount of eDaler that can be used. (required).</param>
        /// <param name="reserved">Current amount of eDaler that has been reserved. (required).</param>
        /// <param name="currency">Currency of wallet. (required).</param>
        /// <param name="timestamp">Timestamp of balance statement. (required).</param>
        public GetBalanceResponse(decimal amount = default(decimal), decimal reserved = default(decimal), string currency = default(string), int timestamp = default(int))
        {
            this.Amount = amount;
            this.Reserved = reserved;
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for GetBalanceResponse and cannot be null");
            }
            this.Currency = currency;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Current amount of eDaler that can be used.
        /// </summary>
        /// <value>Current amount of eDaler that can be used.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Current amount of eDaler that has been reserved.
        /// </summary>
        /// <value>Current amount of eDaler that has been reserved.</value>
        [DataMember(Name = "reserved", IsRequired = true, EmitDefaultValue = true)]
        public decimal Reserved { get; set; }

        /// <summary>
        /// Currency of wallet.
        /// </summary>
        /// <value>Currency of wallet.</value>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Timestamp of balance statement.
        /// </summary>
        /// <value>Timestamp of balance statement.</value>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = true)]
        public int Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetBalanceResponse {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Reserved: ").Append(Reserved).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(input as GetBalanceResponse);
        }

        /// <summary>
        /// Returns true if GetBalanceResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetBalanceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetBalanceResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.Reserved == input.Reserved ||
                    this.Reserved.Equals(input.Reserved)
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    this.Timestamp.Equals(input.Timestamp)
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
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                hashCode = (hashCode * 59) + this.Reserved.GetHashCode();
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
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

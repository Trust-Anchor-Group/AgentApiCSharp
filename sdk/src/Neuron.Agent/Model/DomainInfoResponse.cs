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
    /// DomainInfoResponse
    /// </summary>
    [DataContract(Name = "DomainInfoResponse")]
    public partial class DomainInfoResponse : IEquatable<DomainInfoResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainInfoResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DomainInfoResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainInfoResponse" /> class.
        /// </summary>
        /// <param name="domain">The domain of the server.</param>
        /// <param name="useEncryption">Indicates whether the server requires encryption (required).</param>
        /// <param name="humanReadableName">Human-readable name of the server.</param>
        /// <param name="humanReadableNameDescription">Human-readable description of the server.</param>
        public DomainInfoResponse(string domain = default(string), bool useEncryption = default(bool), string humanReadableName = default(string), string humanReadableNameDescription = default(string))
        {
            this.UseEncryption = useEncryption;
            this.Domain = domain;
            this.HumanReadableName = humanReadableName;
            this.HumanReadableNameDescription = humanReadableNameDescription;
        }

        /// <summary>
        /// The domain of the server
        /// </summary>
        /// <value>The domain of the server</value>
        [DataMember(Name = "domain", EmitDefaultValue = false)]
        public string Domain { get; set; }

        /// <summary>
        /// Indicates whether the server requires encryption
        /// </summary>
        /// <value>Indicates whether the server requires encryption</value>
        [DataMember(Name = "useEncryption", IsRequired = true, EmitDefaultValue = true)]
        public bool UseEncryption { get; set; }

        /// <summary>
        /// Human-readable name of the server
        /// </summary>
        /// <value>Human-readable name of the server</value>
        [DataMember(Name = "humanReadableName", EmitDefaultValue = false)]
        public string HumanReadableName { get; set; }

        /// <summary>
        /// Human-readable description of the server
        /// </summary>
        /// <value>Human-readable description of the server</value>
        [DataMember(Name = "humanReadableNameDescription", EmitDefaultValue = false)]
        public string HumanReadableNameDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DomainInfoResponse {\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  UseEncryption: ").Append(UseEncryption).Append("\n");
            sb.Append("  HumanReadableName: ").Append(HumanReadableName).Append("\n");
            sb.Append("  HumanReadableNameDescription: ").Append(HumanReadableNameDescription).Append("\n");
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
            return this.Equals(input as DomainInfoResponse);
        }

        /// <summary>
        /// Returns true if DomainInfoResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainInfoResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.UseEncryption == input.UseEncryption ||
                    this.UseEncryption.Equals(input.UseEncryption)
                ) && 
                (
                    this.HumanReadableName == input.HumanReadableName ||
                    (this.HumanReadableName != null &&
                    this.HumanReadableName.Equals(input.HumanReadableName))
                ) && 
                (
                    this.HumanReadableNameDescription == input.HumanReadableNameDescription ||
                    (this.HumanReadableNameDescription != null &&
                    this.HumanReadableNameDescription.Equals(input.HumanReadableNameDescription))
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
                if (this.Domain != null)
                {
                    hashCode = (hashCode * 59) + this.Domain.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UseEncryption.GetHashCode();
                if (this.HumanReadableName != null)
                {
                    hashCode = (hashCode * 59) + this.HumanReadableName.GetHashCode();
                }
                if (this.HumanReadableNameDescription != null)
                {
                    hashCode = (hashCode * 59) + this.HumanReadableNameDescription.GetHashCode();
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

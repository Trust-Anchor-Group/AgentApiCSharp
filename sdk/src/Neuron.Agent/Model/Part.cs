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
    /// Part
    /// </summary>
    [DataContract(Name = "Part")]
    public partial class Part : IEquatable<Part>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Part" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Part() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Part" /> class.
        /// </summary>
        /// <param name="role">Role of a predefined part to the contract. (required).</param>
        /// <param name="legalId">Identity of part. (required).</param>
        public Part(string role = default(string), string legalId = default(string))
        {
            // to ensure "role" is required (not null)
            if (role == null)
            {
                throw new ArgumentNullException("role is a required property for Part and cannot be null");
            }
            this.Role = role;
            // to ensure "legalId" is required (not null)
            if (legalId == null)
            {
                throw new ArgumentNullException("legalId is a required property for Part and cannot be null");
            }
            this.LegalId = legalId;
        }

        /// <summary>
        /// Role of a predefined part to the contract.
        /// </summary>
        /// <value>Role of a predefined part to the contract.</value>
        [DataMember(Name = "role", IsRequired = true, EmitDefaultValue = true)]
        public string Role { get; set; }

        /// <summary>
        /// Identity of part.
        /// </summary>
        /// <value>Identity of part.</value>
        [DataMember(Name = "legalId", IsRequired = true, EmitDefaultValue = true)]
        public string LegalId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Part {\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  LegalId: ").Append(LegalId).Append("\n");
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
            return this.Equals(input as Part);
        }

        /// <summary>
        /// Returns true if Part instances are equal
        /// </summary>
        /// <param name="input">Instance of Part to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Part input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.LegalId == input.LegalId ||
                    (this.LegalId != null &&
                    this.LegalId.Equals(input.LegalId))
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
                if (this.Role != null)
                {
                    hashCode = (hashCode * 59) + this.Role.GetHashCode();
                }
                if (this.LegalId != null)
                {
                    hashCode = (hashCode * 59) + this.LegalId.GetHashCode();
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

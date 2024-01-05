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
    /// IdentityResponseJSON
    /// </summary>
    [DataContract(Name = "IdentityResponseJSON")]
    public partial class IdentityResponseJSON : IEquatable<IdentityResponseJSON>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityResponseJSON" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IdentityResponseJSON() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityResponseJSON" /> class.
        /// </summary>
        /// <param name="identity">identity (required).</param>
        public IdentityResponseJSON(IdentityJson identity = default(IdentityJson))
        {
            // to ensure "identity" is required (not null)
            if (identity == null)
            {
                throw new ArgumentNullException("identity is a required property for IdentityResponseJSON and cannot be null");
            }
            this.Identity = identity;
        }

        /// <summary>
        /// Gets or Sets Identity
        /// </summary>
        [DataMember(Name = "Identity", IsRequired = true, EmitDefaultValue = true)]
        public IdentityJson Identity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IdentityResponseJSON {\n");
            sb.Append("  Identity: ").Append(Identity).Append("\n");
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
            return this.Equals(input as IdentityResponseJSON);
        }

        /// <summary>
        /// Returns true if IdentityResponseJSON instances are equal
        /// </summary>
        /// <param name="input">Instance of IdentityResponseJSON to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdentityResponseJSON input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Identity == input.Identity ||
                    (this.Identity != null &&
                    this.Identity.Equals(input.Identity))
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
                if (this.Identity != null)
                {
                    hashCode = (hashCode * 59) + this.Identity.GetHashCode();
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

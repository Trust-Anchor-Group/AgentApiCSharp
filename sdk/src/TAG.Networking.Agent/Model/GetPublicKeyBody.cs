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
    /// GetPublicKeyBody
    /// </summary>
    [DataContract(Name = "GetPublicKeyBody")]
    public partial class GetPublicKeyBody : IEquatable<GetPublicKeyBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPublicKeyBody" /> class.
        /// </summary>
        /// <param name="keyId">Optional Key ID. If not provided, the server public key is returned. If provided, the public key of the corresponding cryptographic key of the client is returned..</param>
        public GetPublicKeyBody(string keyId = default(string))
        {
            this.KeyId = keyId;
        }

        /// <summary>
        /// Optional Key ID. If not provided, the server public key is returned. If provided, the public key of the corresponding cryptographic key of the client is returned.
        /// </summary>
        /// <value>Optional Key ID. If not provided, the server public key is returned. If provided, the public key of the corresponding cryptographic key of the client is returned.</value>
        [DataMember(Name = "keyId", EmitDefaultValue = false)]
        public string KeyId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetPublicKeyBody {\n");
            sb.Append("  KeyId: ").Append(KeyId).Append("\n");
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
            return this.Equals(input as GetPublicKeyBody);
        }

        /// <summary>
        /// Returns true if GetPublicKeyBody instances are equal
        /// </summary>
        /// <param name="input">Instance of GetPublicKeyBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetPublicKeyBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.KeyId == input.KeyId ||
                    (this.KeyId != null &&
                    this.KeyId.Equals(input.KeyId))
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
                if (this.KeyId != null)
                {
                    hashCode = (hashCode * 59) + this.KeyId.GetHashCode();
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

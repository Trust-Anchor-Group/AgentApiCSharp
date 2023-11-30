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
    /// Algorithm
    /// </summary>
    [DataContract(Name = "Algorithm")]
    public partial class Algorithm : IEquatable<Algorithm>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Algorithm" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Algorithm() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Algorithm" /> class.
        /// </summary>
        /// <param name="localName">The local name of the algorithm. (required).</param>
        /// <param name="varNamespace">The namespace of the algorithm. (required).</param>
        /// <param name="secuirtyStrength">The security strength of the algorithm. (required).</param>
        /// <param name="safe">Whether the algorithm is considered safe or not. (required).</param>
        /// <param name="slow">Whether the algorithm is considered slow or not. (required).</param>
        /// <param name="score">The score of the algorithm. (required).</param>
        public Algorithm(string localName = default(string), string varNamespace = default(string), int secuirtyStrength = default(int), bool safe = default(bool), bool slow = default(bool), int score = default(int))
        {
            // to ensure "localName" is required (not null)
            if (localName == null)
            {
                throw new ArgumentNullException("localName is a required property for Algorithm and cannot be null");
            }
            this.LocalName = localName;
            // to ensure "varNamespace" is required (not null)
            if (varNamespace == null)
            {
                throw new ArgumentNullException("varNamespace is a required property for Algorithm and cannot be null");
            }
            this.VarNamespace = varNamespace;
            this.SecuirtyStrength = secuirtyStrength;
            this.Safe = safe;
            this.Slow = slow;
            this.Score = score;
        }

        /// <summary>
        /// The local name of the algorithm.
        /// </summary>
        /// <value>The local name of the algorithm.</value>
        [DataMember(Name = "localName", IsRequired = true, EmitDefaultValue = true)]
        public string LocalName { get; set; }

        /// <summary>
        /// The namespace of the algorithm.
        /// </summary>
        /// <value>The namespace of the algorithm.</value>
        [DataMember(Name = "namespace", IsRequired = true, EmitDefaultValue = true)]
        public string VarNamespace { get; set; }

        /// <summary>
        /// The security strength of the algorithm.
        /// </summary>
        /// <value>The security strength of the algorithm.</value>
        [DataMember(Name = "secuirtyStrength", IsRequired = true, EmitDefaultValue = true)]
        public int SecuirtyStrength { get; set; }

        /// <summary>
        /// Whether the algorithm is considered safe or not.
        /// </summary>
        /// <value>Whether the algorithm is considered safe or not.</value>
        [DataMember(Name = "safe", IsRequired = true, EmitDefaultValue = true)]
        public bool Safe { get; set; }

        /// <summary>
        /// Whether the algorithm is considered slow or not.
        /// </summary>
        /// <value>Whether the algorithm is considered slow or not.</value>
        [DataMember(Name = "slow", IsRequired = true, EmitDefaultValue = true)]
        public bool Slow { get; set; }

        /// <summary>
        /// The score of the algorithm.
        /// </summary>
        /// <value>The score of the algorithm.</value>
        [DataMember(Name = "score", IsRequired = true, EmitDefaultValue = true)]
        public int Score { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Algorithm {\n");
            sb.Append("  LocalName: ").Append(LocalName).Append("\n");
            sb.Append("  VarNamespace: ").Append(VarNamespace).Append("\n");
            sb.Append("  SecuirtyStrength: ").Append(SecuirtyStrength).Append("\n");
            sb.Append("  Safe: ").Append(Safe).Append("\n");
            sb.Append("  Slow: ").Append(Slow).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
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
            return this.Equals(input as Algorithm);
        }

        /// <summary>
        /// Returns true if Algorithm instances are equal
        /// </summary>
        /// <param name="input">Instance of Algorithm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Algorithm input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LocalName == input.LocalName ||
                    (this.LocalName != null &&
                    this.LocalName.Equals(input.LocalName))
                ) && 
                (
                    this.VarNamespace == input.VarNamespace ||
                    (this.VarNamespace != null &&
                    this.VarNamespace.Equals(input.VarNamespace))
                ) && 
                (
                    this.SecuirtyStrength == input.SecuirtyStrength ||
                    this.SecuirtyStrength.Equals(input.SecuirtyStrength)
                ) && 
                (
                    this.Safe == input.Safe ||
                    this.Safe.Equals(input.Safe)
                ) && 
                (
                    this.Slow == input.Slow ||
                    this.Slow.Equals(input.Slow)
                ) && 
                (
                    this.Score == input.Score ||
                    this.Score.Equals(input.Score)
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
                if (this.LocalName != null)
                {
                    hashCode = (hashCode * 59) + this.LocalName.GetHashCode();
                }
                if (this.VarNamespace != null)
                {
                    hashCode = (hashCode * 59) + this.VarNamespace.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SecuirtyStrength.GetHashCode();
                hashCode = (hashCode * 59) + this.Safe.GetHashCode();
                hashCode = (hashCode * 59) + this.Slow.GetHashCode();
                hashCode = (hashCode * 59) + this.Score.GetHashCode();
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

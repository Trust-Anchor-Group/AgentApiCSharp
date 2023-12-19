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
    /// LoginBody
    /// </summary>
    [DataContract(Name = "LoginBody")]
    public partial class LoginBody : IEquatable<LoginBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LoginBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginBody" /> class.
        /// </summary>
        /// <param name="userName">The user name of the account. (required).</param>
        /// <param name="nonce">A unique random string, at least 32 characters long, with sufficient entropy to not be reused again. (required).</param>
        /// <param name="signature">The HMAC-SHA256 signature of the request. See the endpoint description for how to calculate the signature.  (required).</param>
        /// <param name="seconds">The number of seconds until the request expires. (required).</param>
        public LoginBody(string userName = default(string), string nonce = default(string), string signature = default(string), int seconds = default(int))
        {
            // to ensure "userName" is required (not null)
            if (userName == null)
            {
                throw new ArgumentNullException("userName is a required property for LoginBody and cannot be null");
            }
            this.UserName = userName;
            // to ensure "nonce" is required (not null)
            if (nonce == null)
            {
                throw new ArgumentNullException("nonce is a required property for LoginBody and cannot be null");
            }
            this.Nonce = nonce;
            // to ensure "signature" is required (not null)
            if (signature == null)
            {
                throw new ArgumentNullException("signature is a required property for LoginBody and cannot be null");
            }
            this.Signature = signature;
            this.Seconds = seconds;
        }

        /// <summary>
        /// The user name of the account.
        /// </summary>
        /// <value>The user name of the account.</value>
        [DataMember(Name = "userName", IsRequired = true, EmitDefaultValue = true)]
        public string UserName { get; set; }

        /// <summary>
        /// A unique random string, at least 32 characters long, with sufficient entropy to not be reused again.
        /// </summary>
        /// <value>A unique random string, at least 32 characters long, with sufficient entropy to not be reused again.</value>
        [DataMember(Name = "nonce", IsRequired = true, EmitDefaultValue = true)]
        public string Nonce { get; set; }

        /// <summary>
        /// The HMAC-SHA256 signature of the request. See the endpoint description for how to calculate the signature. 
        /// </summary>
        /// <value>The HMAC-SHA256 signature of the request. See the endpoint description for how to calculate the signature. </value>
        [DataMember(Name = "signature", IsRequired = true, EmitDefaultValue = true)]
        public string Signature { get; set; }

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
            sb.Append("class LoginBody {\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
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
            return this.Equals(input as LoginBody);
        }

        /// <summary>
        /// Returns true if LoginBody instances are equal
        /// </summary>
        /// <param name="input">Instance of LoginBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoginBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    (this.Nonce != null &&
                    this.Nonce.Equals(input.Nonce))
                ) && 
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
                ) && 
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
                if (this.UserName != null)
                {
                    hashCode = (hashCode * 59) + this.UserName.GetHashCode();
                }
                if (this.Nonce != null)
                {
                    hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
                }
                if (this.Signature != null)
                {
                    hashCode = (hashCode * 59) + this.Signature.GetHashCode();
                }
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
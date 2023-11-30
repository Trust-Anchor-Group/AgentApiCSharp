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
    /// SelectReviewServiceBody
    /// </summary>
    [DataContract(Name = "SelectReviewServiceBody")]
    public partial class SelectReviewServiceBody : IEquatable<SelectReviewServiceBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectReviewServiceBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SelectReviewServiceBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectReviewServiceBody" /> class.
        /// </summary>
        /// <param name="serviceId">ID of internal peer review service. (required).</param>
        /// <param name="serviceProvider">Type (class name) of service provider. (required).</param>
        public SelectReviewServiceBody(string serviceId = default(string), string serviceProvider = default(string))
        {
            // to ensure "serviceId" is required (not null)
            if (serviceId == null)
            {
                throw new ArgumentNullException("serviceId is a required property for SelectReviewServiceBody and cannot be null");
            }
            this.ServiceId = serviceId;
            // to ensure "serviceProvider" is required (not null)
            if (serviceProvider == null)
            {
                throw new ArgumentNullException("serviceProvider is a required property for SelectReviewServiceBody and cannot be null");
            }
            this.ServiceProvider = serviceProvider;
        }

        /// <summary>
        /// ID of internal peer review service.
        /// </summary>
        /// <value>ID of internal peer review service.</value>
        [DataMember(Name = "serviceId", IsRequired = true, EmitDefaultValue = true)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Type (class name) of service provider.
        /// </summary>
        /// <value>Type (class name) of service provider.</value>
        [DataMember(Name = "serviceProvider", IsRequired = true, EmitDefaultValue = true)]
        public string ServiceProvider { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SelectReviewServiceBody {\n");
            sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
            sb.Append("  ServiceProvider: ").Append(ServiceProvider).Append("\n");
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
            return this.Equals(input as SelectReviewServiceBody);
        }

        /// <summary>
        /// Returns true if SelectReviewServiceBody instances are equal
        /// </summary>
        /// <param name="input">Instance of SelectReviewServiceBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelectReviewServiceBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ServiceId == input.ServiceId ||
                    (this.ServiceId != null &&
                    this.ServiceId.Equals(input.ServiceId))
                ) && 
                (
                    this.ServiceProvider == input.ServiceProvider ||
                    (this.ServiceProvider != null &&
                    this.ServiceProvider.Equals(input.ServiceProvider))
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
                if (this.ServiceId != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceId.GetHashCode();
                }
                if (this.ServiceProvider != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceProvider.GetHashCode();
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
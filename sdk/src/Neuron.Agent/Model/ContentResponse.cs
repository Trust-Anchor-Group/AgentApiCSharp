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
    /// ContentResponse
    /// </summary>
    [DataContract(Name = "ContentResponse")]
    public partial class ContentResponse : IEquatable<ContentResponse>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Visibility
        /// </summary>
        [DataMember(Name = "visibility", IsRequired = true, EmitDefaultValue = true)]
        public Visibility Visibility { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContentResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentResponse" /> class.
        /// </summary>
        /// <param name="uploaded">uploaded (required).</param>
        /// <param name="visibility">visibility (required).</param>
        /// <param name="etag">etag (required).</param>
        /// <param name="url">url (required).</param>
        public ContentResponse(DateTime uploaded = default(DateTime), Visibility visibility = default(Visibility), string etag = default(string), string url = default(string))
        {
            this.Uploaded = uploaded;
            this.Visibility = visibility;
            // to ensure "etag" is required (not null)
            if (etag == null)
            {
                throw new ArgumentNullException("etag is a required property for ContentResponse and cannot be null");
            }
            this.Etag = etag;
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for ContentResponse and cannot be null");
            }
            this.Url = url;
        }

        /// <summary>
        /// Gets or Sets Uploaded
        /// </summary>
        [DataMember(Name = "uploaded", IsRequired = true, EmitDefaultValue = true)]
        public DateTime Uploaded { get; set; }

        /// <summary>
        /// Gets or Sets Etag
        /// </summary>
        [DataMember(Name = "etag", IsRequired = true, EmitDefaultValue = true)]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContentResponse {\n");
            sb.Append("  Uploaded: ").Append(Uploaded).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as ContentResponse);
        }

        /// <summary>
        /// Returns true if ContentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ContentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Uploaded == input.Uploaded ||
                    (this.Uploaded != null &&
                    this.Uploaded.Equals(input.Uploaded))
                ) && 
                (
                    this.Visibility == input.Visibility ||
                    this.Visibility.Equals(input.Visibility)
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Uploaded != null)
                {
                    hashCode = (hashCode * 59) + this.Uploaded.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Visibility.GetHashCode();
                if (this.Etag != null)
                {
                    hashCode = (hashCode * 59) + this.Etag.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
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
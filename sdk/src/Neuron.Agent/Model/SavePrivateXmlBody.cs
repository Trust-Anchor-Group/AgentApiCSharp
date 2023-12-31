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
    /// SavePrivateXmlBody
    /// </summary>
    [DataContract(Name = "SavePrivateXmlBody")]
    public partial class SavePrivateXmlBody : IEquatable<SavePrivateXmlBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SavePrivateXmlBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SavePrivateXmlBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SavePrivateXmlBody" /> class.
        /// </summary>
        /// <param name="xml">The XML to save. (required).</param>
        public SavePrivateXmlBody(string xml = default(string))
        {
            // to ensure "xml" is required (not null)
            if (xml == null)
            {
                throw new ArgumentNullException("xml is a required property for SavePrivateXmlBody and cannot be null");
            }
            this.Xml = xml;
        }

        /// <summary>
        /// The XML to save.
        /// </summary>
        /// <value>The XML to save.</value>
        [DataMember(Name = "xml", IsRequired = true, EmitDefaultValue = true)]
        public string Xml { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SavePrivateXmlBody {\n");
            sb.Append("  Xml: ").Append(Xml).Append("\n");
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
            return this.Equals(input as SavePrivateXmlBody);
        }

        /// <summary>
        /// Returns true if SavePrivateXmlBody instances are equal
        /// </summary>
        /// <param name="input">Instance of SavePrivateXmlBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SavePrivateXmlBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Xml == input.Xml ||
                    (this.Xml != null &&
                    this.Xml.Equals(input.Xml))
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
                if (this.Xml != null)
                {
                    hashCode = (hashCode * 59) + this.Xml.GetHashCode();
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

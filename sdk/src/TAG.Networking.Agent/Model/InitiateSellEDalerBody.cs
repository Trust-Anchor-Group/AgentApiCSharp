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
    /// InitiateSellEDalerBody
    /// </summary>
    [DataContract(Name = "InitiateSellEDalerBody")]
    public partial class InitiateSellEDalerBody : IEquatable<InitiateSellEDalerBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InitiateSellEDalerBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InitiateSellEDalerBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InitiateSellEDalerBody" /> class.
        /// </summary>
        /// <param name="serviceId">ID of internal eDaler service. (required).</param>
        /// <param name="serviceProvider">Type (class name) of service provider. (required).</param>
        /// <param name="amount">Amount of eDaler to buy. (required).</param>
        /// <param name="currency">Currency to buy. (required).</param>
        /// <param name="successUrl">URL to redirect to if the operation is successful..</param>
        /// <param name="failureUrl">URL to redirect to if the operation fails..</param>
        /// <param name="cancelUrl">URL to redirect to if the operation is cancelled..</param>
        /// <param name="transactionId">Transaction ID..</param>
        /// <param name="tabId">Tab ID..</param>
        public InitiateSellEDalerBody(string serviceId = default(string), string serviceProvider = default(string), double amount = default(double), string currency = default(string), string successUrl = default(string), string failureUrl = default(string), string cancelUrl = default(string), string transactionId = default(string), string tabId = default(string))
        {
            // to ensure "serviceId" is required (not null)
            if (serviceId == null)
            {
                throw new ArgumentNullException("serviceId is a required property for InitiateSellEDalerBody and cannot be null");
            }
            this.ServiceId = serviceId;
            // to ensure "serviceProvider" is required (not null)
            if (serviceProvider == null)
            {
                throw new ArgumentNullException("serviceProvider is a required property for InitiateSellEDalerBody and cannot be null");
            }
            this.ServiceProvider = serviceProvider;
            this.Amount = amount;
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for InitiateSellEDalerBody and cannot be null");
            }
            this.Currency = currency;
            this.SuccessUrl = successUrl;
            this.FailureUrl = failureUrl;
            this.CancelUrl = cancelUrl;
            this.TransactionId = transactionId;
            this.TabId = tabId;
        }

        /// <summary>
        /// ID of internal eDaler service.
        /// </summary>
        /// <value>ID of internal eDaler service.</value>
        [DataMember(Name = "serviceId", IsRequired = true, EmitDefaultValue = true)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Type (class name) of service provider.
        /// </summary>
        /// <value>Type (class name) of service provider.</value>
        [DataMember(Name = "serviceProvider", IsRequired = true, EmitDefaultValue = true)]
        public string ServiceProvider { get; set; }

        /// <summary>
        /// Amount of eDaler to buy.
        /// </summary>
        /// <value>Amount of eDaler to buy.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public double Amount { get; set; }

        /// <summary>
        /// Currency to buy.
        /// </summary>
        /// <value>Currency to buy.</value>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// URL to redirect to if the operation is successful.
        /// </summary>
        /// <value>URL to redirect to if the operation is successful.</value>
        [DataMember(Name = "successUrl", EmitDefaultValue = false)]
        public string SuccessUrl { get; set; }

        /// <summary>
        /// URL to redirect to if the operation fails.
        /// </summary>
        /// <value>URL to redirect to if the operation fails.</value>
        [DataMember(Name = "failureUrl", EmitDefaultValue = false)]
        public string FailureUrl { get; set; }

        /// <summary>
        /// URL to redirect to if the operation is cancelled.
        /// </summary>
        /// <value>URL to redirect to if the operation is cancelled.</value>
        [DataMember(Name = "cancelUrl", EmitDefaultValue = false)]
        public string CancelUrl { get; set; }

        /// <summary>
        /// Transaction ID.
        /// </summary>
        /// <value>Transaction ID.</value>
        [DataMember(Name = "transactionId", EmitDefaultValue = false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Tab ID.
        /// </summary>
        /// <value>Tab ID.</value>
        [DataMember(Name = "tabId", EmitDefaultValue = false)]
        public string TabId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InitiateSellEDalerBody {\n");
            sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
            sb.Append("  ServiceProvider: ").Append(ServiceProvider).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  SuccessUrl: ").Append(SuccessUrl).Append("\n");
            sb.Append("  FailureUrl: ").Append(FailureUrl).Append("\n");
            sb.Append("  CancelUrl: ").Append(CancelUrl).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  TabId: ").Append(TabId).Append("\n");
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
            return this.Equals(input as InitiateSellEDalerBody);
        }

        /// <summary>
        /// Returns true if InitiateSellEDalerBody instances are equal
        /// </summary>
        /// <param name="input">Instance of InitiateSellEDalerBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InitiateSellEDalerBody input)
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
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.SuccessUrl == input.SuccessUrl ||
                    (this.SuccessUrl != null &&
                    this.SuccessUrl.Equals(input.SuccessUrl))
                ) && 
                (
                    this.FailureUrl == input.FailureUrl ||
                    (this.FailureUrl != null &&
                    this.FailureUrl.Equals(input.FailureUrl))
                ) && 
                (
                    this.CancelUrl == input.CancelUrl ||
                    (this.CancelUrl != null &&
                    this.CancelUrl.Equals(input.CancelUrl))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.TabId == input.TabId ||
                    (this.TabId != null &&
                    this.TabId.Equals(input.TabId))
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
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.SuccessUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SuccessUrl.GetHashCode();
                }
                if (this.FailureUrl != null)
                {
                    hashCode = (hashCode * 59) + this.FailureUrl.GetHashCode();
                }
                if (this.CancelUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CancelUrl.GetHashCode();
                }
                if (this.TransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionId.GetHashCode();
                }
                if (this.TabId != null)
                {
                    hashCode = (hashCode * 59) + this.TabId.GetHashCode();
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

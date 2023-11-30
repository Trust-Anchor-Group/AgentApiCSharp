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
    /// Defines Visibility
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Visibility
    {
        /// <summary>
        /// Enum Public for value: Public
        /// </summary>
        [EnumMember(Value = "Public")]
        Public = 1,

        /// <summary>
        /// Enum Presence for value: Presence
        /// </summary>
        [EnumMember(Value = "Presence")]
        Presence = 2,

        /// <summary>
        /// Enum Private for value: Private
        /// </summary>
        [EnumMember(Value = "Private")]
        Private = 3
    }

}

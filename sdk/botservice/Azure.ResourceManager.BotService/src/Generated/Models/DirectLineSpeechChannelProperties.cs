// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> The parameters to provide for the DirectLine Speech channel. </summary>
    public partial class DirectLineSpeechChannelProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DirectLineSpeechChannelProperties"/>. </summary>
        public DirectLineSpeechChannelProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DirectLineSpeechChannelProperties"/>. </summary>
        /// <param name="cognitiveServiceResourceId"> The cognitive service id with this channel registration. </param>
        /// <param name="cognitiveServiceRegion"> The cognitive service region with this channel registration. </param>
        /// <param name="cognitiveServiceSubscriptionKey"> The cognitive service subscription key to use with this channel registration. </param>
        /// <param name="isEnabled"> Whether this channel is enabled or not. </param>
        /// <param name="customVoiceDeploymentId"> Custom speech model id (optional). </param>
        /// <param name="customSpeechModelId"> Custom voice deployment id (optional). </param>
        /// <param name="isDefaultBotForCogSvcAccount"> Make this a default bot for chosen cognitive service account. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DirectLineSpeechChannelProperties(ResourceIdentifier cognitiveServiceResourceId, string cognitiveServiceRegion, string cognitiveServiceSubscriptionKey, bool? isEnabled, string customVoiceDeploymentId, string customSpeechModelId, bool? isDefaultBotForCogSvcAccount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CognitiveServiceResourceId = cognitiveServiceResourceId;
            CognitiveServiceRegion = cognitiveServiceRegion;
            CognitiveServiceSubscriptionKey = cognitiveServiceSubscriptionKey;
            IsEnabled = isEnabled;
            CustomVoiceDeploymentId = customVoiceDeploymentId;
            CustomSpeechModelId = customSpeechModelId;
            IsDefaultBotForCogSvcAccount = isDefaultBotForCogSvcAccount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The cognitive service id with this channel registration. </summary>
        public ResourceIdentifier CognitiveServiceResourceId { get; set; }
        /// <summary> The cognitive service region with this channel registration. </summary>
        public string CognitiveServiceRegion { get; set; }
        /// <summary> The cognitive service subscription key to use with this channel registration. </summary>
        public string CognitiveServiceSubscriptionKey { get; set; }
        /// <summary> Whether this channel is enabled or not. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> Custom speech model id (optional). </summary>
        public string CustomVoiceDeploymentId { get; set; }
        /// <summary> Custom voice deployment id (optional). </summary>
        public string CustomSpeechModelId { get; set; }
        /// <summary> Make this a default bot for chosen cognitive service account. </summary>
        public bool? IsDefaultBotForCogSvcAccount { get; set; }
    }
}

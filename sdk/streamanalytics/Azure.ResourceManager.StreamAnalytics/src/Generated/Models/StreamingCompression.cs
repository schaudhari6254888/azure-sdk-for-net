// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Describes how input data is compressed. </summary>
    internal partial class StreamingCompression
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

        /// <summary> Initializes a new instance of <see cref="StreamingCompression"/>. </summary>
        /// <param name="compressionType"> Indicates the type of compression that the input uses. Required on PUT (CreateOrReplace) requests. </param>
        public StreamingCompression(StreamingCompressionType compressionType)
        {
            CompressionType = compressionType;
        }

        /// <summary> Initializes a new instance of <see cref="StreamingCompression"/>. </summary>
        /// <param name="compressionType"> Indicates the type of compression that the input uses. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamingCompression(StreamingCompressionType compressionType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CompressionType = compressionType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StreamingCompression"/> for deserialization. </summary>
        internal StreamingCompression()
        {
        }

        /// <summary> Indicates the type of compression that the input uses. Required on PUT (CreateOrReplace) requests. </summary>
        public StreamingCompressionType CompressionType { get; set; }
    }
}

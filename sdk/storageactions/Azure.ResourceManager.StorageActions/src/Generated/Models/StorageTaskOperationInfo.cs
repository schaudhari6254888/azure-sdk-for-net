// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageActions.Models
{
    /// <summary> Represents an operation to be performed on the object. </summary>
    public partial class StorageTaskOperationInfo
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

        /// <summary> Initializes a new instance of <see cref="StorageTaskOperationInfo"/>. </summary>
        /// <param name="name"> The operation to be performed on the object. </param>
        public StorageTaskOperationInfo(StorageTaskOperationName name)
        {
            Name = name;
            Parameters = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="StorageTaskOperationInfo"/>. </summary>
        /// <param name="name"> The operation to be performed on the object. </param>
        /// <param name="parameters"> Key-value parameters for the operation. </param>
        /// <param name="onSuccess"> Action to be taken when the operation is successful for a object. </param>
        /// <param name="onFailure"> Action to be taken when the operation fails for a object. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageTaskOperationInfo(StorageTaskOperationName name, IDictionary<string, string> parameters, OnSuccessAction? onSuccess, OnFailureAction? onFailure, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Parameters = parameters;
            OnSuccess = onSuccess;
            OnFailure = onFailure;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StorageTaskOperationInfo"/> for deserialization. </summary>
        internal StorageTaskOperationInfo()
        {
        }

        /// <summary> The operation to be performed on the object. </summary>
        public StorageTaskOperationName Name { get; set; }
        /// <summary> Key-value parameters for the operation. </summary>
        public IDictionary<string, string> Parameters { get; }
        /// <summary> Action to be taken when the operation is successful for a object. </summary>
        public OnSuccessAction? OnSuccess { get; set; }
        /// <summary> Action to be taken when the operation fails for a object. </summary>
        public OnFailureAction? OnFailure { get; set; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class SnapshotUpdate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(OsType))
            {
                writer.WritePropertyName("osType");
                writer.WriteStringValue(OsType.Value.ToSerialString());
            }
            if (Optional.IsDefined(DiskSizeGB))
            {
                writer.WritePropertyName("diskSizeGB");
                writer.WriteNumberValue(DiskSizeGB.Value);
            }
            if (Optional.IsDefined(EncryptionSettingsCollection))
            {
                writer.WritePropertyName("encryptionSettingsCollection");
                writer.WriteObjectValue(EncryptionSettingsCollection);
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption");
                writer.WriteObjectValue(Encryption);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
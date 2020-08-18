// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class BGPCommunity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceSupportedRegion))
            {
                writer.WritePropertyName("serviceSupportedRegion");
                writer.WriteStringValue(ServiceSupportedRegion);
            }
            if (Optional.IsDefined(CommunityName))
            {
                writer.WritePropertyName("communityName");
                writer.WriteStringValue(CommunityName);
            }
            if (Optional.IsDefined(CommunityValue))
            {
                writer.WritePropertyName("communityValue");
                writer.WriteStringValue(CommunityValue);
            }
            if (Optional.IsCollectionDefined(CommunityPrefixes))
            {
                writer.WritePropertyName("communityPrefixes");
                writer.WriteStartArray();
                foreach (var item in CommunityPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsAuthorizedToUse))
            {
                writer.WritePropertyName("isAuthorizedToUse");
                writer.WriteBooleanValue(IsAuthorizedToUse.Value);
            }
            if (Optional.IsDefined(ServiceGroup))
            {
                writer.WritePropertyName("serviceGroup");
                writer.WriteStringValue(ServiceGroup);
            }
            writer.WriteEndObject();
        }

        internal static BGPCommunity DeserializeBGPCommunity(JsonElement element)
        {
            Optional<string> serviceSupportedRegion = default;
            Optional<string> communityName = default;
            Optional<string> communityValue = default;
            Optional<IList<string>> communityPrefixes = default;
            Optional<bool> isAuthorizedToUse = default;
            Optional<string> serviceGroup = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceSupportedRegion"))
                {
                    serviceSupportedRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("communityName"))
                {
                    communityName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("communityValue"))
                {
                    communityValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("communityPrefixes"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    communityPrefixes = array;
                    continue;
                }
                if (property.NameEquals("isAuthorizedToUse"))
                {
                    isAuthorizedToUse = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("serviceGroup"))
                {
                    serviceGroup = property.Value.GetString();
                    continue;
                }
            }
            return new BGPCommunity(serviceSupportedRegion.Value, communityName.Value, communityValue.Value, Optional.ToList(communityPrefixes), Optional.ToNullable(isAuthorizedToUse), serviceGroup.Value);
        }
    }
}
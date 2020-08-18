// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class Ipv6ExpressRouteCircuitPeeringConfig : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PrimaryPeerAddressPrefix))
            {
                writer.WritePropertyName("primaryPeerAddressPrefix");
                writer.WriteStringValue(PrimaryPeerAddressPrefix);
            }
            if (Optional.IsDefined(SecondaryPeerAddressPrefix))
            {
                writer.WritePropertyName("secondaryPeerAddressPrefix");
                writer.WriteStringValue(SecondaryPeerAddressPrefix);
            }
            if (Optional.IsDefined(MicrosoftPeeringConfig))
            {
                writer.WritePropertyName("microsoftPeeringConfig");
                writer.WriteObjectValue(MicrosoftPeeringConfig);
            }
            if (Optional.IsDefined(RouteFilter))
            {
                writer.WritePropertyName("routeFilter");
                writer.WriteObjectValue(RouteFilter);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state");
                writer.WriteStringValue(State.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static Ipv6ExpressRouteCircuitPeeringConfig DeserializeIpv6ExpressRouteCircuitPeeringConfig(JsonElement element)
        {
            Optional<string> primaryPeerAddressPrefix = default;
            Optional<string> secondaryPeerAddressPrefix = default;
            Optional<ExpressRouteCircuitPeeringConfig> microsoftPeeringConfig = default;
            Optional<SubResource> routeFilter = default;
            Optional<ExpressRouteCircuitPeeringState> state = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryPeerAddressPrefix"))
                {
                    primaryPeerAddressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryPeerAddressPrefix"))
                {
                    secondaryPeerAddressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("microsoftPeeringConfig"))
                {
                    microsoftPeeringConfig = ExpressRouteCircuitPeeringConfig.DeserializeExpressRouteCircuitPeeringConfig(property.Value);
                    continue;
                }
                if (property.NameEquals("routeFilter"))
                {
                    routeFilter = SubResource.DeserializeSubResource(property.Value);
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    state = new ExpressRouteCircuitPeeringState(property.Value.GetString());
                    continue;
                }
            }
            return new Ipv6ExpressRouteCircuitPeeringConfig(primaryPeerAddressPrefix.Value, secondaryPeerAddressPrefix.Value, microsoftPeeringConfig.Value, routeFilter.Value, Optional.ToNullable(state));
        }
    }
}
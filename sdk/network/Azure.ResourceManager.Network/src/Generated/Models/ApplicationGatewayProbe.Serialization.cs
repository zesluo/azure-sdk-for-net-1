// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayProbe : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol");
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Optional.IsDefined(Host))
            {
                writer.WritePropertyName("host");
                writer.WriteStringValue(Host);
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path");
                writer.WriteStringValue(Path);
            }
            if (Optional.IsDefined(Interval))
            {
                writer.WritePropertyName("interval");
                writer.WriteNumberValue(Interval.Value);
            }
            if (Optional.IsDefined(Timeout))
            {
                writer.WritePropertyName("timeout");
                writer.WriteNumberValue(Timeout.Value);
            }
            if (Optional.IsDefined(UnhealthyThreshold))
            {
                writer.WritePropertyName("unhealthyThreshold");
                writer.WriteNumberValue(UnhealthyThreshold.Value);
            }
            if (Optional.IsDefined(PickHostNameFromBackendHttpSettings))
            {
                writer.WritePropertyName("pickHostNameFromBackendHttpSettings");
                writer.WriteBooleanValue(PickHostNameFromBackendHttpSettings.Value);
            }
            if (Optional.IsDefined(MinServers))
            {
                writer.WritePropertyName("minServers");
                writer.WriteNumberValue(MinServers.Value);
            }
            if (Optional.IsDefined(Match))
            {
                writer.WritePropertyName("match");
                writer.WriteObjectValue(Match);
            }
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port");
                writer.WriteNumberValue(Port.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApplicationGatewayProbe DeserializeApplicationGatewayProbe(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> type = default;
            Optional<string> id = default;
            Optional<ApplicationGatewayProtocol> protocol = default;
            Optional<string> host = default;
            Optional<string> path = default;
            Optional<int> interval = default;
            Optional<int> timeout = default;
            Optional<int> unhealthyThreshold = default;
            Optional<bool> pickHostNameFromBackendHttpSettings = default;
            Optional<int> minServers = default;
            Optional<ApplicationGatewayProbeHealthResponseMatch> match = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<int> port = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("protocol"))
                        {
                            protocol = new ApplicationGatewayProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("host"))
                        {
                            host = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("path"))
                        {
                            path = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("interval"))
                        {
                            interval = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("timeout"))
                        {
                            timeout = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("unhealthyThreshold"))
                        {
                            unhealthyThreshold = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("pickHostNameFromBackendHttpSettings"))
                        {
                            pickHostNameFromBackendHttpSettings = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("minServers"))
                        {
                            minServers = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("match"))
                        {
                            match = ApplicationGatewayProbeHealthResponseMatch.DeserializeApplicationGatewayProbeHealthResponseMatch(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("port"))
                        {
                            port = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApplicationGatewayProbe(id.Value, name.Value, etag.Value, type.Value, Optional.ToNullable(protocol), host.Value, path.Value, Optional.ToNullable(interval), Optional.ToNullable(timeout), Optional.ToNullable(unhealthyThreshold), Optional.ToNullable(pickHostNameFromBackendHttpSettings), Optional.ToNullable(minServers), match.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(port));
        }
    }
}
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class WebApplicationFirewallPolicyListResult
    {
        internal static WebApplicationFirewallPolicyListResult DeserializeWebApplicationFirewallPolicyListResult(JsonElement element)
        {
            Optional<IReadOnlyList<WebApplicationFirewallPolicy>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<WebApplicationFirewallPolicy> array = new List<WebApplicationFirewallPolicy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WebApplicationFirewallPolicy.DeserializeWebApplicationFirewallPolicy(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new WebApplicationFirewallPolicyListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    /// <summary> Response for the ListVirtualNetworkGateways API service call. </summary>
    public partial class VirtualNetworkGatewayListResult
    {
        /// <summary> Initializes a new instance of VirtualNetworkGatewayListResult. </summary>
        internal VirtualNetworkGatewayListResult()
        {
            Value = new ChangeTrackingList<VirtualNetworkGateway>();
        }

        /// <summary> Initializes a new instance of VirtualNetworkGatewayListResult. </summary>
        /// <param name="value"> A list of VirtualNetworkGateway resources that exists in a resource group. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal VirtualNetworkGatewayListResult(IReadOnlyList<VirtualNetworkGateway> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of VirtualNetworkGateway resources that exists in a resource group. </summary>
        public IReadOnlyList<VirtualNetworkGateway> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
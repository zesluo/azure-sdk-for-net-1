// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListPeeredConnections API service call retrieves all global reach peer circuit connections that belongs to a Private Peering for an ExpressRouteCircuit. </summary>
    public partial class PeerExpressRouteCircuitConnectionListResult
    {
        /// <summary> Initializes a new instance of PeerExpressRouteCircuitConnectionListResult. </summary>
        internal PeerExpressRouteCircuitConnectionListResult()
        {
            Value = new ChangeTrackingList<PeerExpressRouteCircuitConnection>();
        }

        /// <summary> Initializes a new instance of PeerExpressRouteCircuitConnectionListResult. </summary>
        /// <param name="value"> The global reach peer circuit connection associated with Private Peering in an ExpressRoute Circuit. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal PeerExpressRouteCircuitConnectionListResult(IReadOnlyList<PeerExpressRouteCircuitConnection> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The global reach peer circuit connection associated with Private Peering in an ExpressRoute Circuit. </summary>
        public IReadOnlyList<PeerExpressRouteCircuitConnection> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
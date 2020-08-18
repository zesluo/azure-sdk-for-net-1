// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Route table resource. </summary>
    public partial class RouteTable : Resource
    {
        /// <summary> Initializes a new instance of RouteTable. </summary>
        public RouteTable()
        {
            Routes = new ChangeTrackingList<Route>();
            Subnets = new ChangeTrackingList<Subnet>();
        }

        /// <summary> Initializes a new instance of RouteTable. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="routes"> Collection of routes contained within a route table. </param>
        /// <param name="subnets"> A collection of references to subnets. </param>
        /// <param name="disableBgpRoutePropagation"> Whether to disable the routes learned by BGP on that route table. True means disable. </param>
        /// <param name="provisioningState"> The provisioning state of the route table resource. </param>
        internal RouteTable(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, IList<Route> routes, IReadOnlyList<Subnet> subnets, bool? disableBgpRoutePropagation, ProvisioningState? provisioningState) : base(id, name, type, location, tags)
        {
            Etag = etag;
            Routes = routes;
            Subnets = subnets;
            DisableBgpRoutePropagation = disableBgpRoutePropagation;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Collection of routes contained within a route table. </summary>
        public IList<Route> Routes { get; }
        /// <summary> A collection of references to subnets. </summary>
        public IReadOnlyList<Subnet> Subnets { get; }
        /// <summary> Whether to disable the routes learned by BGP on that route table. True means disable. </summary>
        public bool? DisableBgpRoutePropagation { get; set; }
        /// <summary> The provisioning state of the route table resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
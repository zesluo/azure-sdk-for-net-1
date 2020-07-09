// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// IpConfigurations.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class HubIpConfiguration : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the HubIpConfiguration class.
        /// </summary>
        public HubIpConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HubIpConfiguration class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="privateIPAddress">The private IP address of the IP
        /// configuration.</param>
        /// <param name="privateIPAllocationMethod">The private IP address
        /// allocation method. Possible values include: 'Static',
        /// 'Dynamic'</param>
        /// <param name="subnet">The reference to the subnet resource.</param>
        /// <param name="publicIPAddress">The reference to the public IP
        /// resource.</param>
        /// <param name="provisioningState">The provisioning state of the IP
        /// configuration resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="name">Name of the Ip Configuration.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="type">Ipconfiguration type.</param>
        public HubIpConfiguration(string id = default(string), string privateIPAddress = default(string), string privateIPAllocationMethod = default(string), Subnet subnet = default(Subnet), PublicIPAddress publicIPAddress = default(PublicIPAddress), string provisioningState = default(string), string name = default(string), string etag = default(string), string type = default(string))
            : base(id)
        {
            PrivateIPAddress = privateIPAddress;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            Subnet = subnet;
            PublicIPAddress = publicIPAddress;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the private IP address of the IP configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateIPAddress")]
        public string PrivateIPAddress { get; set; }

        /// <summary>
        /// Gets or sets the private IP address allocation method. Possible
        /// values include: 'Static', 'Dynamic'
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateIPAllocationMethod")]
        public string PrivateIPAllocationMethod { get; set; }

        /// <summary>
        /// Gets or sets the reference to the subnet resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnet")]
        public Subnet Subnet { get; set; }

        /// <summary>
        /// Gets or sets the reference to the public IP resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPAddress")]
        public PublicIPAddress PublicIPAddress { get; set; }

        /// <summary>
        /// Gets the provisioning state of the IP configuration resource.
        /// Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets name of the Ip Configuration.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets ipconfiguration type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}
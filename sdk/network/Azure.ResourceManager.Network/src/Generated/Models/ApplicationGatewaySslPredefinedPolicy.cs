// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> An Ssl predefined policy. </summary>
    public partial class ApplicationGatewaySslPredefinedPolicy : SubResource
    {
        /// <summary> Initializes a new instance of ApplicationGatewaySslPredefinedPolicy. </summary>
        public ApplicationGatewaySslPredefinedPolicy()
        {
            CipherSuites = new ChangeTrackingList<ApplicationGatewaySslCipherSuite>();
        }

        /// <summary> Initializes a new instance of ApplicationGatewaySslPredefinedPolicy. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Name of the Ssl predefined policy. </param>
        /// <param name="cipherSuites"> Ssl cipher suites to be enabled in the specified order for application gateway. </param>
        /// <param name="minProtocolVersion"> Minimum version of Ssl protocol to be supported on application gateway. </param>
        internal ApplicationGatewaySslPredefinedPolicy(string id, string name, IList<ApplicationGatewaySslCipherSuite> cipherSuites, ApplicationGatewaySslProtocol? minProtocolVersion) : base(id)
        {
            Name = name;
            CipherSuites = cipherSuites;
            MinProtocolVersion = minProtocolVersion;
        }

        /// <summary> Name of the Ssl predefined policy. </summary>
        public string Name { get; set; }
        /// <summary> Ssl cipher suites to be enabled in the specified order for application gateway. </summary>
        public IList<ApplicationGatewaySslCipherSuite> CipherSuites { get; }
        /// <summary> Minimum version of Ssl protocol to be supported on application gateway. </summary>
        public ApplicationGatewaySslProtocol? MinProtocolVersion { get; set; }
    }
}
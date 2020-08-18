// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Deployment operation parameters. </summary>
    public partial class ScopedDeployment
    {
        /// <summary> Initializes a new instance of ScopedDeployment. </summary>
        /// <param name="location"> The location to store the deployment data. </param>
        /// <param name="properties"> The deployment properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="properties"/> is null. </exception>
        public ScopedDeployment(string location, DeploymentProperties properties)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Location = location;
            Properties = properties;
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The location to store the deployment data. </summary>
        public string Location { get; }
        /// <summary> The deployment properties. </summary>
        public DeploymentProperties Properties { get; }
        /// <summary> Deployment tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
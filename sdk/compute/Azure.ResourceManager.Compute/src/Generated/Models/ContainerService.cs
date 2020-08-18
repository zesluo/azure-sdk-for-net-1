// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Container service. </summary>
    public partial class ContainerService : Resource
    {
        /// <summary> Initializes a new instance of ContainerService. </summary>
        /// <param name="location"> Resource location. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public ContainerService(string location) : base(location)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            AgentPoolProfiles = new ChangeTrackingList<ContainerServiceAgentPoolProfile>();
        }

        /// <summary> Initializes a new instance of ContainerService. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="provisioningState"> the current deployment or provisioning state, which only appears in the response. </param>
        /// <param name="orchestratorProfile"> Properties of the orchestrator. </param>
        /// <param name="customProfile"> Properties for custom clusters. </param>
        /// <param name="servicePrincipalProfile"> Properties for cluster service principals. </param>
        /// <param name="masterProfile"> Properties of master agents. </param>
        /// <param name="agentPoolProfiles"> Properties of the agent pool. </param>
        /// <param name="windowsProfile"> Properties of Windows VMs. </param>
        /// <param name="linuxProfile"> Properties of Linux VMs. </param>
        /// <param name="diagnosticsProfile"> Properties of the diagnostic agent. </param>
        internal ContainerService(string id, string name, string type, string location, IDictionary<string, string> tags, string provisioningState, ContainerServiceOrchestratorProfile orchestratorProfile, ContainerServiceCustomProfile customProfile, ContainerServicePrincipalProfile servicePrincipalProfile, ContainerServiceMasterProfile masterProfile, IList<ContainerServiceAgentPoolProfile> agentPoolProfiles, ContainerServiceWindowsProfile windowsProfile, ContainerServiceLinuxProfile linuxProfile, ContainerServiceDiagnosticsProfile diagnosticsProfile) : base(id, name, type, location, tags)
        {
            ProvisioningState = provisioningState;
            OrchestratorProfile = orchestratorProfile;
            CustomProfile = customProfile;
            ServicePrincipalProfile = servicePrincipalProfile;
            MasterProfile = masterProfile;
            AgentPoolProfiles = agentPoolProfiles;
            WindowsProfile = windowsProfile;
            LinuxProfile = linuxProfile;
            DiagnosticsProfile = diagnosticsProfile;
        }

        /// <summary> the current deployment or provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> Properties of the orchestrator. </summary>
        public ContainerServiceOrchestratorProfile OrchestratorProfile { get; set; }
        /// <summary> Properties for custom clusters. </summary>
        public ContainerServiceCustomProfile CustomProfile { get; set; }
        /// <summary> Properties for cluster service principals. </summary>
        public ContainerServicePrincipalProfile ServicePrincipalProfile { get; set; }
        /// <summary> Properties of master agents. </summary>
        public ContainerServiceMasterProfile MasterProfile { get; set; }
        /// <summary> Properties of the agent pool. </summary>
        public IList<ContainerServiceAgentPoolProfile> AgentPoolProfiles { get; }
        /// <summary> Properties of Windows VMs. </summary>
        public ContainerServiceWindowsProfile WindowsProfile { get; set; }
        /// <summary> Properties of Linux VMs. </summary>
        public ContainerServiceLinuxProfile LinuxProfile { get; set; }
        /// <summary> Properties of the diagnostic agent. </summary>
        public ContainerServiceDiagnosticsProfile DiagnosticsProfile { get; set; }
    }
}
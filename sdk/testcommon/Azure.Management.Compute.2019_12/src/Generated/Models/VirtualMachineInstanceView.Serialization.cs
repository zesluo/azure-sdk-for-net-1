// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class VirtualMachineInstanceView
    {
        internal static VirtualMachineInstanceView DeserializeVirtualMachineInstanceView(JsonElement element)
        {
            Optional<int> platformUpdateDomain = default;
            Optional<int> platformFaultDomain = default;
            Optional<string> computerName = default;
            Optional<string> osName = default;
            Optional<string> osVersion = default;
            Optional<HyperVGenerationType> hyperVGeneration = default;
            Optional<string> rdpThumbPrint = default;
            Optional<VirtualMachineAgentInstanceView> vmAgent = default;
            Optional<MaintenanceRedeployStatus> maintenanceRedeployStatus = default;
            Optional<IReadOnlyList<DiskInstanceView>> disks = default;
            Optional<IReadOnlyList<VirtualMachineExtensionInstanceView>> extensions = default;
            Optional<BootDiagnosticsInstanceView> bootDiagnostics = default;
            Optional<IReadOnlyList<InstanceViewStatus>> statuses = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("platformUpdateDomain"))
                {
                    platformUpdateDomain = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("platformFaultDomain"))
                {
                    platformFaultDomain = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("computerName"))
                {
                    computerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osName"))
                {
                    osName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osVersion"))
                {
                    osVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hyperVGeneration"))
                {
                    hyperVGeneration = new HyperVGenerationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rdpThumbPrint"))
                {
                    rdpThumbPrint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmAgent"))
                {
                    vmAgent = VirtualMachineAgentInstanceView.DeserializeVirtualMachineAgentInstanceView(property.Value);
                    continue;
                }
                if (property.NameEquals("maintenanceRedeployStatus"))
                {
                    maintenanceRedeployStatus = MaintenanceRedeployStatus.DeserializeMaintenanceRedeployStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("disks"))
                {
                    List<DiskInstanceView> array = new List<DiskInstanceView>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiskInstanceView.DeserializeDiskInstanceView(item));
                    }
                    disks = array;
                    continue;
                }
                if (property.NameEquals("extensions"))
                {
                    List<VirtualMachineExtensionInstanceView> array = new List<VirtualMachineExtensionInstanceView>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualMachineExtensionInstanceView.DeserializeVirtualMachineExtensionInstanceView(item));
                    }
                    extensions = array;
                    continue;
                }
                if (property.NameEquals("bootDiagnostics"))
                {
                    bootDiagnostics = BootDiagnosticsInstanceView.DeserializeBootDiagnosticsInstanceView(property.Value);
                    continue;
                }
                if (property.NameEquals("statuses"))
                {
                    List<InstanceViewStatus> array = new List<InstanceViewStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InstanceViewStatus.DeserializeInstanceViewStatus(item));
                    }
                    statuses = array;
                    continue;
                }
            }
            return new VirtualMachineInstanceView(Optional.ToNullable(platformUpdateDomain), Optional.ToNullable(platformFaultDomain), computerName.Value, osName.Value, osVersion.Value, Optional.ToNullable(hyperVGeneration), rdpThumbPrint.Value, vmAgent.Value, maintenanceRedeployStatus.Value, Optional.ToList(disks), Optional.ToList(extensions), bootDiagnostics.Value, Optional.ToList(statuses));
        }
    }
}
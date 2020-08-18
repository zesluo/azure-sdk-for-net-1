// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Management.Network.Models
{
    /// <summary> Parameters that define the source and destination endpoint. </summary>
    public partial class NextHopParameters
    {
        /// <summary> Initializes a new instance of NextHopParameters. </summary>
        /// <param name="targetResourceId"> The resource identifier of the target resource against which the action is to be performed. </param>
        /// <param name="sourceIPAddress"> The source IP address. </param>
        /// <param name="destinationIPAddress"> The destination IP address. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetResourceId"/>, <paramref name="sourceIPAddress"/>, or <paramref name="destinationIPAddress"/> is null. </exception>
        public NextHopParameters(string targetResourceId, string sourceIPAddress, string destinationIPAddress)
        {
            if (targetResourceId == null)
            {
                throw new ArgumentNullException(nameof(targetResourceId));
            }
            if (sourceIPAddress == null)
            {
                throw new ArgumentNullException(nameof(sourceIPAddress));
            }
            if (destinationIPAddress == null)
            {
                throw new ArgumentNullException(nameof(destinationIPAddress));
            }

            TargetResourceId = targetResourceId;
            SourceIPAddress = sourceIPAddress;
            DestinationIPAddress = destinationIPAddress;
        }

        /// <summary> The resource identifier of the target resource against which the action is to be performed. </summary>
        public string TargetResourceId { get; }
        /// <summary> The source IP address. </summary>
        public string SourceIPAddress { get; }
        /// <summary> The destination IP address. </summary>
        public string DestinationIPAddress { get; }
        /// <summary> The NIC ID. (If VM has multiple NICs and IP forwarding is enabled on any of the nics, then this parameter must be specified. Otherwise optional). </summary>
        public string TargetNicResourceId { get; set; }
    }
}
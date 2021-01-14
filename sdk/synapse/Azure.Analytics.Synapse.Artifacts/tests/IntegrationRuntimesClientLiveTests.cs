// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Azure.Analytics.Synapse.Artifacts;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.Analytics.Synapse.Tests
{
    /// <summary>
    /// The suite of tests for the <see cref="IntegrationRuntimesClient"/> class.
    /// </summary>
    /// <remarks>
    /// These tests have a dependency on live Azure services and may incur costs for the associated
    /// Azure subscription.
    /// </remarks>
    public class IntegrationRuntimesClientLiveTests : RecordedTestBase<SynapseTestEnvironment>
    {
        public IntegrationRuntimesClientLiveTests(bool isAsync) : base(isAsync)
        {
        }

        private IntegrationRuntimesClient CreateClient()
        {
            return InstrumentClient(new IntegrationRuntimesClient(
                new Uri(TestEnvironment.EndpointUrl),
                TestEnvironment.Credential,
                InstrumentClientOptions(new ArtifactsClientOptions())
            ));
        }
    }
}

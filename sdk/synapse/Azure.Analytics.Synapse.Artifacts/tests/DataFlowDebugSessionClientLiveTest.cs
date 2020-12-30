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
    public class DataFlowDebugSessionClientLiveTest: RecordedTestBase<SynapseTestEnvironment>
    {
        public DataFlowDebugSessionClientLiveTest(bool isAsync) : base(isAsync)
        {
        }

        private DataFlowDebugSessionClient CreateClient()
        {
            return InstrumentClient(new DataFlowDebugSessionClient(
                new Uri(TestEnvironment.EndpointUrl),
                TestEnvironment.Credential,
                InstrumentClientOptions(new ArtifactsClientOptions())
            ));
        }

        // [Test]
        // public async Task Foo()
        // {
        // }
    }
}

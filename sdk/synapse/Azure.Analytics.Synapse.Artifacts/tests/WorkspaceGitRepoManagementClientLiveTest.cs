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
    public class WorkspaceGitRepoManagementClientLiveTest: RecordedTestBase<SynapseTestEnvironment>
    {
        public WorkspaceGitRepoManagementClientLiveTest(bool isAsync) : base(isAsync)
        {
        }

        private WorkspaceGitRepoManagementClient TriggerRunClient()
        {
            return InstrumentClient(new WorkspaceGitRepoManagementClient(
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

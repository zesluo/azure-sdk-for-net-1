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
    public class DatasetClientLiveTest: RecordedTestBase<SynapseTestEnvironment>
    {
        public DatasetClientLiveTest(bool isAsync) : base(isAsync)
        {
        }

        private DatasetClient CreateClient()
        {
            return InstrumentClient(new DatasetClient(
                new Uri(TestEnvironment.EndpointUrl),
                TestEnvironment.Credential,
                InstrumentClientOptions(new ArtifactsClientOptions())
            ));
        }

        [Test]
        public async Task TestGetDataset()
        {
            DatasetClient client = CreateClient ();
            await foreach (var expectedDataset in client.GetDatasetsByWorkspaceAsync())
            {
                DatasetResource actualDataset = await client.GetDatasetAsync(expectedDataset.Name);
                Assert.AreEqual(expectedDataset.Name, actualDataset.Name);
                Assert.AreEqual(expectedDataset.Id, actualDataset.Id);
            }
        }

        [Test]
        public async Task TestCreateDataset()
        {
            DatasetClient client = CreateClient ();

            string datasetName = Recording.GenerateName("Dataset");
            DatasetCreateOrUpdateDatasetOperation operation = await client.StartCreateOrUpdateDatasetAsync(datasetName, new DatasetResource(new Dataset(new LinkedServiceReference(LinkedServiceReferenceType.LinkedServiceReference, TestEnvironment.WorkspaceName + "-WorkspaceDefaultStorage"))));
            DatasetResource dataset = await operation.WaitForCompletionAsync();
            Assert.AreEqual(datasetName, dataset.Name);
        }

        [Test]
        public async Task TestDeleteDataset()
        {
            DatasetClient client = CreateClient ();
            string datasetName = Recording.GenerateName("Dataset");

            DatasetCreateOrUpdateDatasetOperation createOperation = await client.StartCreateOrUpdateDatasetAsync(datasetName, new DatasetResource(new Dataset(new LinkedServiceReference(LinkedServiceReferenceType.LinkedServiceReference, TestEnvironment.WorkspaceName + "-WorkspaceDefaultStorage"))));
            await createOperation.WaitForCompletionAsync();

            DatasetDeleteDatasetOperation deleteOperation = await client.StartDeleteDatasetAsync(datasetName);
            Response response = await deleteOperation.WaitForCompletionAsync();
            Assert.AreEqual(200, response.Status);
        }
    }
}

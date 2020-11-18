// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;

namespace Azure.Learn.AppConfig
{
    [CodeGenModel("KeyValue")]
    public partial class ConfigurationSetting
    {
        [CodeGenMember("Etag")]
        public ETag ETag { get; }
    }
}
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class HiveJobStatementInfo
    {
        /// <summary>
        /// Initializes a new instance of the HiveJobStatementInfo class.
        /// </summary>
        public HiveJobStatementInfo() { }

        /// <summary>
        /// Initializes a new instance of the HiveJobStatementInfo class.
        /// </summary>
        public HiveJobStatementInfo(string logLocation = default(string), string resultPreviewLocation = default(string), string resultLocation = default(string), string errorMessage = default(string))
        {
            LogLocation = logLocation;
            ResultPreviewLocation = resultPreviewLocation;
            ResultLocation = resultLocation;
            ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Gets or sets the log location for this statement.
        /// </summary>
        [JsonProperty(PropertyName = "logLocation")]
        public string LogLocation { get; set; }

        /// <summary>
        /// Gets or sets the result preview location for this statement.
        /// </summary>
        [JsonProperty(PropertyName = "resultPreviewLocation")]
        public string ResultPreviewLocation { get; set; }

        /// <summary>
        /// Gets or sets the result location for this statement.
        /// </summary>
        [JsonProperty(PropertyName = "resultLocation")]
        public string ResultLocation { get; set; }

        /// <summary>
        /// Gets or sets the error message for this statement.
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }

    }
}

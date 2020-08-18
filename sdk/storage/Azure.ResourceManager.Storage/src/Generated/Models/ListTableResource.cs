// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Response schema. Contains list of tables returned. </summary>
    public partial class ListTableResource
    {
        /// <summary> Initializes a new instance of ListTableResource. </summary>
        internal ListTableResource()
        {
            Value = new ChangeTrackingList<Table>();
        }

        /// <summary> Initializes a new instance of ListTableResource. </summary>
        /// <param name="value"> List of tables returned. </param>
        /// <param name="nextLink"> Request URL that can be used to query next page of tables. </param>
        internal ListTableResource(IReadOnlyList<Table> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of tables returned. </summary>
        public IReadOnlyList<Table> Value { get; }
        /// <summary> Request URL that can be used to query next page of tables. </summary>
        public string NextLink { get; }
    }
}
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class ListTableResource
    {
        internal static ListTableResource DeserializeListTableResource(JsonElement element)
        {
            Optional<IReadOnlyList<Table>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<Table> array = new List<Table>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Table.DeserializeTable(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ListTableResource(Optional.ToList(value), nextLink.Value);
        }
    }
}
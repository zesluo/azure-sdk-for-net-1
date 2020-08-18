// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class GalleryApplicationList
    {
        internal static GalleryApplicationList DeserializeGalleryApplicationList(JsonElement element)
        {
            IReadOnlyList<GalleryApplication> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<GalleryApplication> array = new List<GalleryApplication>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GalleryApplication.DeserializeGalleryApplication(item));
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
            return new GalleryApplicationList(value, nextLink.Value);
        }
    }
}
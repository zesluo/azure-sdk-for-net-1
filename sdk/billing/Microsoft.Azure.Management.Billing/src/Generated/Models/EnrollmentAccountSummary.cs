// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An enrollment account resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class EnrollmentAccountSummary : Resource
    {
        /// <summary>
        /// Initializes a new instance of the EnrollmentAccountSummary class.
        /// </summary>
        public EnrollmentAccountSummary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EnrollmentAccountSummary class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="principalName">The account owner's principal
        /// name.</param>
        public EnrollmentAccountSummary(string id = default(string), string name = default(string), string type = default(string), string principalName = default(string))
            : base(id, name, type)
        {
            PrincipalName = principalName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the account owner's principal name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.principalName")]
        public string PrincipalName { get; private set; }

    }
}
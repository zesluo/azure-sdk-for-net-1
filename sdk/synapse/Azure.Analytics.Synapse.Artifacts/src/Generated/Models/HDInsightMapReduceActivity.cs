// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> HDInsight MapReduce activity type. </summary>
    public partial class HDInsightMapReduceActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of HDInsightMapReduceActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="className"> Class name. Type: string (or Expression with resultType string). </param>
        /// <param name="jarFilePath"> Jar path. Type: string (or Expression with resultType string). </param>
        public HDInsightMapReduceActivity(string name, object className, object jarFilePath) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (className == null)
            {
                throw new ArgumentNullException(nameof(className));
            }
            if (jarFilePath == null)
            {
                throw new ArgumentNullException(nameof(jarFilePath));
            }

            ClassName = className;
            JarFilePath = jarFilePath;
            Type = "HDInsightMapReduce";
        }

        /// <summary> Initializes a new instance of HDInsightMapReduceActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="storageLinkedServices"> Storage linked service references. </param>
        /// <param name="arguments"> User specified arguments to HDInsightActivity. </param>
        /// <param name="getDebugInfo"> Debug info option. </param>
        /// <param name="className"> Class name. Type: string (or Expression with resultType string). </param>
        /// <param name="jarFilePath"> Jar path. Type: string (or Expression with resultType string). </param>
        /// <param name="jarLinkedService"> Jar linked service reference. </param>
        /// <param name="jarLibs"> Jar libs. </param>
        /// <param name="defines"> Allows user to specify defines for the MapReduce job request. </param>
        internal HDInsightMapReduceActivity(string name, string type, string description, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, LinkedServiceReference linkedServiceName, ActivityPolicy policy, IList<LinkedServiceReference> storageLinkedServices, IList<object> arguments, HDInsightActivityDebugInfoOption? getDebugInfo, object className, object jarFilePath, LinkedServiceReference jarLinkedService, IList<object> jarLibs, IDictionary<string, object> defines) : base(name, type, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            StorageLinkedServices = storageLinkedServices;
            Arguments = arguments;
            GetDebugInfo = getDebugInfo;
            ClassName = className;
            JarFilePath = jarFilePath;
            JarLinkedService = jarLinkedService;
            JarLibs = jarLibs;
            Defines = defines;
            Type = type ?? "HDInsightMapReduce";
        }

        /// <summary> Storage linked service references. </summary>
        public IList<LinkedServiceReference> StorageLinkedServices { get; set; }
        /// <summary> User specified arguments to HDInsightActivity. </summary>
        public IList<object> Arguments { get; set; }
        /// <summary> Debug info option. </summary>
        public HDInsightActivityDebugInfoOption? GetDebugInfo { get; set; }
        /// <summary> Class name. Type: string (or Expression with resultType string). </summary>
        public object ClassName { get; set; }
        /// <summary> Jar path. Type: string (or Expression with resultType string). </summary>
        public object JarFilePath { get; set; }
        /// <summary> Jar linked service reference. </summary>
        public LinkedServiceReference JarLinkedService { get; set; }
        /// <summary> Jar libs. </summary>
        public IList<object> JarLibs { get; set; }
        /// <summary> Allows user to specify defines for the MapReduce job request. </summary>
        public IDictionary<string, object> Defines { get; set; }
    }
}
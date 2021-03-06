/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.OpsWorks
{

    /// <summary>
    /// Constants used for properties of type AppAttributesKeys.
    /// </summary>
    public class AppAttributesKeys : ConstantClass
    {

        /// <summary>
        /// Constant AutoBundleOnDeploy for AppAttributesKeys
        /// </summary>
        public static readonly AppAttributesKeys AutoBundleOnDeploy = new AppAttributesKeys("AutoBundleOnDeploy");
        /// <summary>
        /// Constant AwsFlowRubySettings for AppAttributesKeys
        /// </summary>
        public static readonly AppAttributesKeys AwsFlowRubySettings = new AppAttributesKeys("AwsFlowRubySettings");
        /// <summary>
        /// Constant DocumentRoot for AppAttributesKeys
        /// </summary>
        public static readonly AppAttributesKeys DocumentRoot = new AppAttributesKeys("DocumentRoot");
        /// <summary>
        /// Constant RailsEnv for AppAttributesKeys
        /// </summary>
        public static readonly AppAttributesKeys RailsEnv = new AppAttributesKeys("RailsEnv");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppAttributesKeys(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppAttributesKeys FindValue(string value)
        {
            return FindValue<AppAttributesKeys>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppAttributesKeys(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AppType.
    /// </summary>
    public class AppType : ConstantClass
    {

        /// <summary>
        /// Constant AwsFlowRuby for AppType
        /// </summary>
        public static readonly AppType AwsFlowRuby = new AppType("aws-flow-ruby");
        /// <summary>
        /// Constant Java for AppType
        /// </summary>
        public static readonly AppType Java = new AppType("java");
        /// <summary>
        /// Constant Nodejs for AppType
        /// </summary>
        public static readonly AppType Nodejs = new AppType("nodejs");
        /// <summary>
        /// Constant Other for AppType
        /// </summary>
        public static readonly AppType Other = new AppType("other");
        /// <summary>
        /// Constant Php for AppType
        /// </summary>
        public static readonly AppType Php = new AppType("php");
        /// <summary>
        /// Constant Rails for AppType
        /// </summary>
        public static readonly AppType Rails = new AppType("rails");
        /// <summary>
        /// Constant Static for AppType
        /// </summary>
        public static readonly AppType Static = new AppType("static");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppType FindValue(string value)
        {
            return FindValue<AppType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Architecture.
    /// </summary>
    public class Architecture : ConstantClass
    {

        /// <summary>
        /// Constant I386 for Architecture
        /// </summary>
        public static readonly Architecture I386 = new Architecture("i386");
        /// <summary>
        /// Constant X86_64 for Architecture
        /// </summary>
        public static readonly Architecture X86_64 = new Architecture("x86_64");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Architecture(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Architecture FindValue(string value)
        {
            return FindValue<Architecture>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Architecture(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoScalingType.
    /// </summary>
    public class AutoScalingType : ConstantClass
    {

        /// <summary>
        /// Constant Load for AutoScalingType
        /// </summary>
        public static readonly AutoScalingType Load = new AutoScalingType("load");
        /// <summary>
        /// Constant Timer for AutoScalingType
        /// </summary>
        public static readonly AutoScalingType Timer = new AutoScalingType("timer");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoScalingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoScalingType FindValue(string value)
        {
            return FindValue<AutoScalingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoScalingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentCommandName.
    /// </summary>
    public class DeploymentCommandName : ConstantClass
    {

        /// <summary>
        /// Constant Configure for DeploymentCommandName
        /// </summary>
        public static readonly DeploymentCommandName Configure = new DeploymentCommandName("configure");
        /// <summary>
        /// Constant Deploy for DeploymentCommandName
        /// </summary>
        public static readonly DeploymentCommandName Deploy = new DeploymentCommandName("deploy");
        /// <summary>
        /// Constant Execute_recipes for DeploymentCommandName
        /// </summary>
        public static readonly DeploymentCommandName Execute_recipes = new DeploymentCommandName("execute_recipes");
        /// <summary>
        /// Constant Install_dependencies for DeploymentCommandName
        /// </summary>
        public static readonly DeploymentCommandName Install_dependencies = new DeploymentCommandName("install_dependencies");
        /// <summary>
        /// Constant Restart for DeploymentCommandName
        /// </summary>
        public static readonly DeploymentCommandName Restart = new DeploymentCommandName("restart");
        /// <summary>
        /// Constant Rollback for DeploymentCommandName
        /// </summary>
        public static readonly DeploymentCommandName Rollback = new DeploymentCommandName("rollback");
        /// <summary>
        /// Constant Setup for DeploymentCommandName
        /// </summary>
        public static readonly DeploymentCommandName Setup = new DeploymentCommandName("setup");
        /// <summary>
        /// Constant Start for DeploymentCommandName
        /// </summary>
        public static readonly DeploymentCommandName Start = new DeploymentCommandName("start");
        /// <summary>
        /// Constant Stop for DeploymentCommandName
        /// </summary>
        public static readonly DeploymentCommandName Stop = new DeploymentCommandName("stop");
        /// <summary>
        /// Constant Undeploy for DeploymentCommandName
        /// </summary>
        public static readonly DeploymentCommandName Undeploy = new DeploymentCommandName("undeploy");
        /// <summary>
        /// Constant Update_custom_cookbooks for DeploymentCommandName
        /// </summary>
        public static readonly DeploymentCommandName Update_custom_cookbooks = new DeploymentCommandName("update_custom_cookbooks");
        /// <summary>
        /// Constant Update_dependencies for DeploymentCommandName
        /// </summary>
        public static readonly DeploymentCommandName Update_dependencies = new DeploymentCommandName("update_dependencies");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentCommandName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentCommandName FindValue(string value)
        {
            return FindValue<DeploymentCommandName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentCommandName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LayerAttributesKeys.
    /// </summary>
    public class LayerAttributesKeys : ConstantClass
    {

        /// <summary>
        /// Constant BundlerVersion for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys BundlerVersion = new LayerAttributesKeys("BundlerVersion");
        /// <summary>
        /// Constant EcsClusterArn for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys EcsClusterArn = new LayerAttributesKeys("EcsClusterArn");
        /// <summary>
        /// Constant EnableHaproxyStats for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys EnableHaproxyStats = new LayerAttributesKeys("EnableHaproxyStats");
        /// <summary>
        /// Constant GangliaPassword for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys GangliaPassword = new LayerAttributesKeys("GangliaPassword");
        /// <summary>
        /// Constant GangliaUrl for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys GangliaUrl = new LayerAttributesKeys("GangliaUrl");
        /// <summary>
        /// Constant GangliaUser for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys GangliaUser = new LayerAttributesKeys("GangliaUser");
        /// <summary>
        /// Constant HaproxyHealthCheckMethod for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys HaproxyHealthCheckMethod = new LayerAttributesKeys("HaproxyHealthCheckMethod");
        /// <summary>
        /// Constant HaproxyHealthCheckUrl for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys HaproxyHealthCheckUrl = new LayerAttributesKeys("HaproxyHealthCheckUrl");
        /// <summary>
        /// Constant HaproxyStatsPassword for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys HaproxyStatsPassword = new LayerAttributesKeys("HaproxyStatsPassword");
        /// <summary>
        /// Constant HaproxyStatsUrl for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys HaproxyStatsUrl = new LayerAttributesKeys("HaproxyStatsUrl");
        /// <summary>
        /// Constant HaproxyStatsUser for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys HaproxyStatsUser = new LayerAttributesKeys("HaproxyStatsUser");
        /// <summary>
        /// Constant JavaAppServer for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys JavaAppServer = new LayerAttributesKeys("JavaAppServer");
        /// <summary>
        /// Constant JavaAppServerVersion for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys JavaAppServerVersion = new LayerAttributesKeys("JavaAppServerVersion");
        /// <summary>
        /// Constant Jvm for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys Jvm = new LayerAttributesKeys("Jvm");
        /// <summary>
        /// Constant JvmOptions for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys JvmOptions = new LayerAttributesKeys("JvmOptions");
        /// <summary>
        /// Constant JvmVersion for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys JvmVersion = new LayerAttributesKeys("JvmVersion");
        /// <summary>
        /// Constant ManageBundler for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys ManageBundler = new LayerAttributesKeys("ManageBundler");
        /// <summary>
        /// Constant MemcachedMemory for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys MemcachedMemory = new LayerAttributesKeys("MemcachedMemory");
        /// <summary>
        /// Constant MysqlRootPassword for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys MysqlRootPassword = new LayerAttributesKeys("MysqlRootPassword");
        /// <summary>
        /// Constant MysqlRootPasswordUbiquitous for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys MysqlRootPasswordUbiquitous = new LayerAttributesKeys("MysqlRootPasswordUbiquitous");
        /// <summary>
        /// Constant NodejsVersion for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys NodejsVersion = new LayerAttributesKeys("NodejsVersion");
        /// <summary>
        /// Constant PassengerVersion for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys PassengerVersion = new LayerAttributesKeys("PassengerVersion");
        /// <summary>
        /// Constant RailsStack for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys RailsStack = new LayerAttributesKeys("RailsStack");
        /// <summary>
        /// Constant RubygemsVersion for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys RubygemsVersion = new LayerAttributesKeys("RubygemsVersion");
        /// <summary>
        /// Constant RubyVersion for LayerAttributesKeys
        /// </summary>
        public static readonly LayerAttributesKeys RubyVersion = new LayerAttributesKeys("RubyVersion");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LayerAttributesKeys(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LayerAttributesKeys FindValue(string value)
        {
            return FindValue<LayerAttributesKeys>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LayerAttributesKeys(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LayerType.
    /// </summary>
    public class LayerType : ConstantClass
    {

        /// <summary>
        /// Constant AwsFlowRuby for LayerType
        /// </summary>
        public static readonly LayerType AwsFlowRuby = new LayerType("aws-flow-ruby");
        /// <summary>
        /// Constant Custom for LayerType
        /// </summary>
        public static readonly LayerType Custom = new LayerType("custom");
        /// <summary>
        /// Constant DbMaster for LayerType
        /// </summary>
        public static readonly LayerType DbMaster = new LayerType("db-master");
        /// <summary>
        /// Constant EcsCluster for LayerType
        /// </summary>
        public static readonly LayerType EcsCluster = new LayerType("ecs-cluster");
        /// <summary>
        /// Constant JavaApp for LayerType
        /// </summary>
        public static readonly LayerType JavaApp = new LayerType("java-app");
        /// <summary>
        /// Constant Lb for LayerType
        /// </summary>
        public static readonly LayerType Lb = new LayerType("lb");
        /// <summary>
        /// Constant Memcached for LayerType
        /// </summary>
        public static readonly LayerType Memcached = new LayerType("memcached");
        /// <summary>
        /// Constant MonitoringMaster for LayerType
        /// </summary>
        public static readonly LayerType MonitoringMaster = new LayerType("monitoring-master");
        /// <summary>
        /// Constant NodejsApp for LayerType
        /// </summary>
        public static readonly LayerType NodejsApp = new LayerType("nodejs-app");
        /// <summary>
        /// Constant PhpApp for LayerType
        /// </summary>
        public static readonly LayerType PhpApp = new LayerType("php-app");
        /// <summary>
        /// Constant RailsApp for LayerType
        /// </summary>
        public static readonly LayerType RailsApp = new LayerType("rails-app");
        /// <summary>
        /// Constant Web for LayerType
        /// </summary>
        public static readonly LayerType Web = new LayerType("web");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LayerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LayerType FindValue(string value)
        {
            return FindValue<LayerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LayerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RootDeviceType.
    /// </summary>
    public class RootDeviceType : ConstantClass
    {

        /// <summary>
        /// Constant Ebs for RootDeviceType
        /// </summary>
        public static readonly RootDeviceType Ebs = new RootDeviceType("ebs");
        /// <summary>
        /// Constant InstanceStore for RootDeviceType
        /// </summary>
        public static readonly RootDeviceType InstanceStore = new RootDeviceType("instance-store");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RootDeviceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RootDeviceType FindValue(string value)
        {
            return FindValue<RootDeviceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RootDeviceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceType.
    /// </summary>
    public class SourceType : ConstantClass
    {

        /// <summary>
        /// Constant Archive for SourceType
        /// </summary>
        public static readonly SourceType Archive = new SourceType("archive");
        /// <summary>
        /// Constant Git for SourceType
        /// </summary>
        public static readonly SourceType Git = new SourceType("git");
        /// <summary>
        /// Constant S3 for SourceType
        /// </summary>
        public static readonly SourceType S3 = new SourceType("s3");
        /// <summary>
        /// Constant Svn for SourceType
        /// </summary>
        public static readonly SourceType Svn = new SourceType("svn");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceType FindValue(string value)
        {
            return FindValue<SourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StackAttributesKeys.
    /// </summary>
    public class StackAttributesKeys : ConstantClass
    {

        /// <summary>
        /// Constant Color for StackAttributesKeys
        /// </summary>
        public static readonly StackAttributesKeys Color = new StackAttributesKeys("Color");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StackAttributesKeys(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StackAttributesKeys FindValue(string value)
        {
            return FindValue<StackAttributesKeys>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StackAttributesKeys(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VirtualizationType.
    /// </summary>
    public class VirtualizationType : ConstantClass
    {

        /// <summary>
        /// Constant Hvm for VirtualizationType
        /// </summary>
        public static readonly VirtualizationType Hvm = new VirtualizationType("hvm");
        /// <summary>
        /// Constant Paravirtual for VirtualizationType
        /// </summary>
        public static readonly VirtualizationType Paravirtual = new VirtualizationType("paravirtual");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VirtualizationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VirtualizationType FindValue(string value)
        {
            return FindValue<VirtualizationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VirtualizationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VolumeType.
    /// </summary>
    public class VolumeType : ConstantClass
    {

        /// <summary>
        /// Constant Gp2 for VolumeType
        /// </summary>
        public static readonly VolumeType Gp2 = new VolumeType("gp2");
        /// <summary>
        /// Constant Io1 for VolumeType
        /// </summary>
        public static readonly VolumeType Io1 = new VolumeType("io1");
        /// <summary>
        /// Constant Standard for VolumeType
        /// </summary>
        public static readonly VolumeType Standard = new VolumeType("standard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VolumeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VolumeType FindValue(string value)
        {
            return FindValue<VolumeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VolumeType(string value)
        {
            return FindValue(value);
        }
    }

}
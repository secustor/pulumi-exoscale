// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Exoscale
{
    /// <summary>
    /// Provides an Exoscale [Elastic IP address][eip-doc] resource. This can be used to create, update and delete Elastic IPs.
    /// 
    /// See [`exoscale.SecondaryIPAddress`][r-secondary_ipaddress] for usage with Compute instances.
    /// 
    /// !&gt; **WARNING:** This resource is deprecated and will be removed in the next major version.
    /// 
    /// ## Import
    /// 
    /// An existing Elastic IP can be imported as a resource by address or IDconsole # By address
    /// 
    /// ```sh
    ///  $ pulumi import exoscale:index/iPAddress:IPAddress myip 159.100.251.224
    /// ```
    /// 
    /// # By ID
    /// 
    /// ```sh
    ///  $ pulumi import exoscale:index/iPAddress:IPAddress myip eb556678-ec59-4be6-8c54-0406ae0f6da6
    /// ```
    /// 
    ///  [eip-doc]https://community.exoscale.com/documentation/compute/eip/ [r-secondary_ipaddress]secondary_ipaddress.html [zone]https://www.exoscale.com/datacenters/
    /// </summary>
    [ExoscaleResourceType("exoscale:index/iPAddress:IPAddress")]
    public partial class IPAddress : Pulumi.CustomResource
    {
        /// <summary>
        /// The description of the Elastic IP.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The healthcheck probing interval in seconds (must be between `5` and `300`).
        /// </summary>
        [Output("healthcheckInterval")]
        public Output<int?> HealthcheckInterval { get; private set; } = null!;

        /// <summary>
        /// The healthcheck probing mode (must be `tcp`, `http` or `https`).
        /// </summary>
        [Output("healthcheckMode")]
        public Output<string?> HealthcheckMode { get; private set; } = null!;

        /// <summary>
        /// The healthcheck probe HTTP request path (must be specified in `http`/`https` modes).
        /// </summary>
        [Output("healthcheckPath")]
        public Output<string?> HealthcheckPath { get; private set; } = null!;

        /// <summary>
        /// The healthcheck service port to probe (must be between `1` and `65535`).
        /// </summary>
        [Output("healthcheckPort")]
        public Output<int?> HealthcheckPort { get; private set; } = null!;

        /// <summary>
        /// The number of unsuccessful healthcheck probes before considering the target unhealthy (must be between `1` and `20`).
        /// </summary>
        [Output("healthcheckStrikesFail")]
        public Output<int?> HealthcheckStrikesFail { get; private set; } = null!;

        /// <summary>
        /// The number of successful healthcheck probes before considering the target healthy (must be between `1` and `20`).
        /// </summary>
        [Output("healthcheckStrikesOk")]
        public Output<int?> HealthcheckStrikesOk { get; private set; } = null!;

        /// <summary>
        /// The time in seconds before considering a healthcheck probing failed (must be between `2` and `60`).
        /// </summary>
        [Output("healthcheckTimeout")]
        public Output<int?> HealthcheckTimeout { get; private set; } = null!;

        /// <summary>
        /// Disable TLS certificate validation in `https` mode. Note: this parameter can only be changed to `true`, it cannot be reset to `false` later on (requires a resource re-creation).
        /// </summary>
        [Output("healthcheckTlsSkipVerify")]
        public Output<bool?> HealthcheckTlsSkipVerify { get; private set; } = null!;

        /// <summary>
        /// The healthcheck TLS server name to specify in `https` mode. Note: this parameter can only be changed to a non-empty value, it cannot be reset to its default empty value later on (requires a resource re-creation).
        /// </summary>
        [Output("healthcheckTlsSni")]
        public Output<string?> HealthcheckTlsSni { get; private set; } = null!;

        /// <summary>
        /// The Elastic IP address.
        /// </summary>
        [Output("ipAddress")]
        public Output<string> IpAddress { get; private set; } = null!;

        /// <summary>
        /// A reverse DNS record to set for the Elastic IP.
        /// </summary>
        [Output("reverseDns")]
        public Output<string?> ReverseDns { get; private set; } = null!;

        /// <summary>
        /// A dictionary of tags (key/value). To remove all tags, set `tags = {}`.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>> Tags { get; private set; } = null!;

        /// <summary>
        /// The name of the [zone][zone] to create the Elastic IP into.
        /// </summary>
        [Output("zone")]
        public Output<string> Zone { get; private set; } = null!;


        /// <summary>
        /// Create a IPAddress resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public IPAddress(string name, IPAddressArgs args, CustomResourceOptions? options = null)
            : base("exoscale:index/iPAddress:IPAddress", name, args ?? new IPAddressArgs(), MakeResourceOptions(options, ""))
        {
        }

        private IPAddress(string name, Input<string> id, IPAddressState? state = null, CustomResourceOptions? options = null)
            : base("exoscale:index/iPAddress:IPAddress", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing IPAddress resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static IPAddress Get(string name, Input<string> id, IPAddressState? state = null, CustomResourceOptions? options = null)
        {
            return new IPAddress(name, id, state, options);
        }
    }

    public sealed class IPAddressArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The description of the Elastic IP.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The healthcheck probing interval in seconds (must be between `5` and `300`).
        /// </summary>
        [Input("healthcheckInterval")]
        public Input<int>? HealthcheckInterval { get; set; }

        /// <summary>
        /// The healthcheck probing mode (must be `tcp`, `http` or `https`).
        /// </summary>
        [Input("healthcheckMode")]
        public Input<string>? HealthcheckMode { get; set; }

        /// <summary>
        /// The healthcheck probe HTTP request path (must be specified in `http`/`https` modes).
        /// </summary>
        [Input("healthcheckPath")]
        public Input<string>? HealthcheckPath { get; set; }

        /// <summary>
        /// The healthcheck service port to probe (must be between `1` and `65535`).
        /// </summary>
        [Input("healthcheckPort")]
        public Input<int>? HealthcheckPort { get; set; }

        /// <summary>
        /// The number of unsuccessful healthcheck probes before considering the target unhealthy (must be between `1` and `20`).
        /// </summary>
        [Input("healthcheckStrikesFail")]
        public Input<int>? HealthcheckStrikesFail { get; set; }

        /// <summary>
        /// The number of successful healthcheck probes before considering the target healthy (must be between `1` and `20`).
        /// </summary>
        [Input("healthcheckStrikesOk")]
        public Input<int>? HealthcheckStrikesOk { get; set; }

        /// <summary>
        /// The time in seconds before considering a healthcheck probing failed (must be between `2` and `60`).
        /// </summary>
        [Input("healthcheckTimeout")]
        public Input<int>? HealthcheckTimeout { get; set; }

        /// <summary>
        /// Disable TLS certificate validation in `https` mode. Note: this parameter can only be changed to `true`, it cannot be reset to `false` later on (requires a resource re-creation).
        /// </summary>
        [Input("healthcheckTlsSkipVerify")]
        public Input<bool>? HealthcheckTlsSkipVerify { get; set; }

        /// <summary>
        /// The healthcheck TLS server name to specify in `https` mode. Note: this parameter can only be changed to a non-empty value, it cannot be reset to its default empty value later on (requires a resource re-creation).
        /// </summary>
        [Input("healthcheckTlsSni")]
        public Input<string>? HealthcheckTlsSni { get; set; }

        /// <summary>
        /// A reverse DNS record to set for the Elastic IP.
        /// </summary>
        [Input("reverseDns")]
        public Input<string>? ReverseDns { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// A dictionary of tags (key/value). To remove all tags, set `tags = {}`.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The name of the [zone][zone] to create the Elastic IP into.
        /// </summary>
        [Input("zone", required: true)]
        public Input<string> Zone { get; set; } = null!;

        public IPAddressArgs()
        {
        }
    }

    public sealed class IPAddressState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The description of the Elastic IP.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The healthcheck probing interval in seconds (must be between `5` and `300`).
        /// </summary>
        [Input("healthcheckInterval")]
        public Input<int>? HealthcheckInterval { get; set; }

        /// <summary>
        /// The healthcheck probing mode (must be `tcp`, `http` or `https`).
        /// </summary>
        [Input("healthcheckMode")]
        public Input<string>? HealthcheckMode { get; set; }

        /// <summary>
        /// The healthcheck probe HTTP request path (must be specified in `http`/`https` modes).
        /// </summary>
        [Input("healthcheckPath")]
        public Input<string>? HealthcheckPath { get; set; }

        /// <summary>
        /// The healthcheck service port to probe (must be between `1` and `65535`).
        /// </summary>
        [Input("healthcheckPort")]
        public Input<int>? HealthcheckPort { get; set; }

        /// <summary>
        /// The number of unsuccessful healthcheck probes before considering the target unhealthy (must be between `1` and `20`).
        /// </summary>
        [Input("healthcheckStrikesFail")]
        public Input<int>? HealthcheckStrikesFail { get; set; }

        /// <summary>
        /// The number of successful healthcheck probes before considering the target healthy (must be between `1` and `20`).
        /// </summary>
        [Input("healthcheckStrikesOk")]
        public Input<int>? HealthcheckStrikesOk { get; set; }

        /// <summary>
        /// The time in seconds before considering a healthcheck probing failed (must be between `2` and `60`).
        /// </summary>
        [Input("healthcheckTimeout")]
        public Input<int>? HealthcheckTimeout { get; set; }

        /// <summary>
        /// Disable TLS certificate validation in `https` mode. Note: this parameter can only be changed to `true`, it cannot be reset to `false` later on (requires a resource re-creation).
        /// </summary>
        [Input("healthcheckTlsSkipVerify")]
        public Input<bool>? HealthcheckTlsSkipVerify { get; set; }

        /// <summary>
        /// The healthcheck TLS server name to specify in `https` mode. Note: this parameter can only be changed to a non-empty value, it cannot be reset to its default empty value later on (requires a resource re-creation).
        /// </summary>
        [Input("healthcheckTlsSni")]
        public Input<string>? HealthcheckTlsSni { get; set; }

        /// <summary>
        /// The Elastic IP address.
        /// </summary>
        [Input("ipAddress")]
        public Input<string>? IpAddress { get; set; }

        /// <summary>
        /// A reverse DNS record to set for the Elastic IP.
        /// </summary>
        [Input("reverseDns")]
        public Input<string>? ReverseDns { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// A dictionary of tags (key/value). To remove all tags, set `tags = {}`.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The name of the [zone][zone] to create the Elastic IP into.
        /// </summary>
        [Input("zone")]
        public Input<string>? Zone { get; set; }

        public IPAddressState()
        {
        }
    }
}

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
    /// Provides an Exoscale [Compute instance][compute-doc] resource. This can be used to create, modify, and delete Compute instances.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Exoscale = Pulumi.Exoscale;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var zone = "ch-gva-2";
    ///         var ubuntu = Output.Create(Exoscale.GetComputeTemplate.InvokeAsync(new Exoscale.GetComputeTemplateArgs
    ///         {
    ///             Zone = zone,
    ///             Name = "Linux Ubuntu 20.04 LTS 64-bit",
    ///         }));
    ///         var web = new Exoscale.SecurityGroup("web", new Exoscale.SecurityGroupArgs
    ///         {
    ///         });
    ///         var @default = Output.Create(Exoscale.GetSecurityGroup.InvokeAsync(new Exoscale.GetSecurityGroupArgs
    ///         {
    ///             Name = "default",
    ///         }));
    ///         var example = new Exoscale.ComputeInstance("example", new Exoscale.ComputeInstanceArgs
    ///         {
    ///             Zone = zone,
    ///             Type = "standard.medium",
    ///             TemplateId = ubuntu.Apply(ubuntu =&gt; ubuntu.Id),
    ///             DiskSize = 10,
    ///             SecurityGroupIds = 
    ///             {
    ///                 @default.Apply(@default =&gt; @default.Id),
    ///                 web.Id,
    ///             },
    ///             SshKey = "my-key",
    ///             UserData = @"#cloud-config
    /// manage_etc_hosts: localhost
    /// ",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// An existing Compute instance can be imported as a resource by `&lt;ID&gt;@&lt;ZONE&gt;`console
    /// 
    /// ```sh
    ///  $ pulumi import exoscale:index/computeInstance:ComputeInstance my-instance eb556678-ec59-4be6-8c54-0406ae0f6da6@ch-gva-2
    /// ```
    /// 
    ///  [cloudinit]http://cloudinit.readthedocs.io/en/latest/ [compute-doc]https://community.exoscale.com/documentation/compute/ [d-anti_affinity_group]../d/anti_affinity_group.html [d-compute_template]../d/compute_template.html [d-elastic_ip]../d/elastic_ip.html [d-private_network]../d/private_network.html [d-security_group]../d/security_group.html [r-anti_affinity_group]anti_affinity_group.html [r-elastic_ip]../r/elastic_ip.html [r-private_network]../r/private_network.html [r-security_group]security_group.html [remote-exec]https://www.terraform.io/docs/provisioners/remote-exec.html [sshkeypair-doc]https://community.exoscale.com/documentation/compute/ssh-keypairs/ [template]https://www.exoscale.com/templates/ [type]https://www.exoscale.com/pricing/#/compute/ [zone]https://www.exoscale.com/datacenters/
    /// </summary>
    [ExoscaleResourceType("exoscale:index/computeInstance:ComputeInstance")]
    public partial class ComputeInstance : Pulumi.CustomResource
    {
        /// <summary>
        /// A list of [Anti-Affinity Group][r-anti_affinity_group] IDs (at creation time only) to assign the Compute instance. Usage of the [`exoscale.AntiAffinityGroup`][d-anti_affinity_group] data source is recommended.
        /// </summary>
        [Output("antiAffinityGroupIds")]
        public Output<ImmutableArray<string>> AntiAffinityGroupIds { get; private set; } = null!;

        /// <summary>
        /// The creation date of the Compute instance.
        /// </summary>
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        /// <summary>
        /// A Deploy Target ID.
        /// </summary>
        [Output("deployTargetId")]
        public Output<string?> DeployTargetId { get; private set; } = null!;

        /// <summary>
        /// The Compute instance disk size in GiB (at least `10`). **WARNING**: updating this attribute stops/restarts the Compute instance.
        /// </summary>
        [Output("diskSize")]
        public Output<int> DiskSize { get; private set; } = null!;

        /// <summary>
        /// A list of [Elastic IP][r-elastic_ip] IDs to attach to the Compute instance. Usage of the [`exoscale.ElasticIP`][d-elastic_ip] data source is recommended.
        /// </summary>
        [Output("elasticIpIds")]
        public Output<ImmutableArray<string>> ElasticIpIds { get; private set; } = null!;

        /// <summary>
        /// Enable IPv6 on the Compute instance (default: `false`).
        /// </summary>
        [Output("ipv6")]
        public Output<bool?> Ipv6 { get; private set; } = null!;

        /// <summary>
        /// The IPv6 address of the Compute instance main network interface.
        /// </summary>
        [Output("ipv6Address")]
        public Output<string> Ipv6Address { get; private set; } = null!;

        /// <summary>
        /// A map of key/value labels.
        /// </summary>
        [Output("labels")]
        public Output<ImmutableDictionary<string, string>?> Labels { get; private set; } = null!;

        /// <summary>
        /// The name of the Compute instance.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// A list of [Private Network][r-private_network] IDs to attach to the Compute instance. Usage of the [`exoscale.PrivateNetwork`][d-private_network] data source is recommended.
        /// </summary>
        [Output("privateNetworkIds")]
        public Output<ImmutableArray<string>> PrivateNetworkIds { get; private set; } = null!;

        /// <summary>
        /// The IPv4 address of the Compute instance's main network interface.
        /// </summary>
        [Output("publicIpAddress")]
        public Output<string> PublicIpAddress { get; private set; } = null!;

        /// <summary>
        /// A list of [Security Group][r-security_group] IDs to attach to the Compute instance. Usage of the [`exoscale.SecurityGroup`][d-security_group] data source is recommended.
        /// </summary>
        [Output("securityGroupIds")]
        public Output<ImmutableArray<string>> SecurityGroupIds { get; private set; } = null!;

        /// <summary>
        /// The name of the [SSH key pair][sshkeypair] to install to the Compute instance's user account during creation.
        /// </summary>
        [Output("sshKey")]
        public Output<string?> SshKey { get; private set; } = null!;

        /// <summary>
        /// The state of the Compute instance (supported values: `started`, `stopped`).
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;

        /// <summary>
        /// The ID of the instance [template][template] to use when creating the Compute instance. Usage of the [`exoscale.getComputeTemplate`][d-compute_template] data source is recommended.
        /// </summary>
        [Output("templateId")]
        public Output<string> TemplateId { get; private set; } = null!;

        /// <summary>
        /// The Compute instance [type][type] (format: `FAMILY.SIZE`, e.g. `standard.medium`, `memory.huge`).  **WARNING**: updating this attribute stops/restarts the Compute instance.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// A [cloud-init][cloudinit] configuration.
        /// </summary>
        [Output("userData")]
        public Output<string?> UserData { get; private set; } = null!;

        /// <summary>
        /// The name of the [zone][zone] to deploy the Compute instance into.
        /// </summary>
        [Output("zone")]
        public Output<string> Zone { get; private set; } = null!;


        /// <summary>
        /// Create a ComputeInstance resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ComputeInstance(string name, ComputeInstanceArgs args, CustomResourceOptions? options = null)
            : base("exoscale:index/computeInstance:ComputeInstance", name, args ?? new ComputeInstanceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ComputeInstance(string name, Input<string> id, ComputeInstanceState? state = null, CustomResourceOptions? options = null)
            : base("exoscale:index/computeInstance:ComputeInstance", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ComputeInstance resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ComputeInstance Get(string name, Input<string> id, ComputeInstanceState? state = null, CustomResourceOptions? options = null)
        {
            return new ComputeInstance(name, id, state, options);
        }
    }

    public sealed class ComputeInstanceArgs : Pulumi.ResourceArgs
    {
        [Input("antiAffinityGroupIds")]
        private InputList<string>? _antiAffinityGroupIds;

        /// <summary>
        /// A list of [Anti-Affinity Group][r-anti_affinity_group] IDs (at creation time only) to assign the Compute instance. Usage of the [`exoscale.AntiAffinityGroup`][d-anti_affinity_group] data source is recommended.
        /// </summary>
        public InputList<string> AntiAffinityGroupIds
        {
            get => _antiAffinityGroupIds ?? (_antiAffinityGroupIds = new InputList<string>());
            set => _antiAffinityGroupIds = value;
        }

        /// <summary>
        /// A Deploy Target ID.
        /// </summary>
        [Input("deployTargetId")]
        public Input<string>? DeployTargetId { get; set; }

        /// <summary>
        /// The Compute instance disk size in GiB (at least `10`). **WARNING**: updating this attribute stops/restarts the Compute instance.
        /// </summary>
        [Input("diskSize")]
        public Input<int>? DiskSize { get; set; }

        [Input("elasticIpIds")]
        private InputList<string>? _elasticIpIds;

        /// <summary>
        /// A list of [Elastic IP][r-elastic_ip] IDs to attach to the Compute instance. Usage of the [`exoscale.ElasticIP`][d-elastic_ip] data source is recommended.
        /// </summary>
        public InputList<string> ElasticIpIds
        {
            get => _elasticIpIds ?? (_elasticIpIds = new InputList<string>());
            set => _elasticIpIds = value;
        }

        /// <summary>
        /// Enable IPv6 on the Compute instance (default: `false`).
        /// </summary>
        [Input("ipv6")]
        public Input<bool>? Ipv6 { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A map of key/value labels.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// The name of the Compute instance.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("privateNetworkIds")]
        private InputList<string>? _privateNetworkIds;

        /// <summary>
        /// A list of [Private Network][r-private_network] IDs to attach to the Compute instance. Usage of the [`exoscale.PrivateNetwork`][d-private_network] data source is recommended.
        /// </summary>
        public InputList<string> PrivateNetworkIds
        {
            get => _privateNetworkIds ?? (_privateNetworkIds = new InputList<string>());
            set => _privateNetworkIds = value;
        }

        [Input("securityGroupIds")]
        private InputList<string>? _securityGroupIds;

        /// <summary>
        /// A list of [Security Group][r-security_group] IDs to attach to the Compute instance. Usage of the [`exoscale.SecurityGroup`][d-security_group] data source is recommended.
        /// </summary>
        public InputList<string> SecurityGroupIds
        {
            get => _securityGroupIds ?? (_securityGroupIds = new InputList<string>());
            set => _securityGroupIds = value;
        }

        /// <summary>
        /// The name of the [SSH key pair][sshkeypair] to install to the Compute instance's user account during creation.
        /// </summary>
        [Input("sshKey")]
        public Input<string>? SshKey { get; set; }

        /// <summary>
        /// The state of the Compute instance (supported values: `started`, `stopped`).
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// The ID of the instance [template][template] to use when creating the Compute instance. Usage of the [`exoscale.getComputeTemplate`][d-compute_template] data source is recommended.
        /// </summary>
        [Input("templateId", required: true)]
        public Input<string> TemplateId { get; set; } = null!;

        /// <summary>
        /// The Compute instance [type][type] (format: `FAMILY.SIZE`, e.g. `standard.medium`, `memory.huge`).  **WARNING**: updating this attribute stops/restarts the Compute instance.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// A [cloud-init][cloudinit] configuration.
        /// </summary>
        [Input("userData")]
        public Input<string>? UserData { get; set; }

        /// <summary>
        /// The name of the [zone][zone] to deploy the Compute instance into.
        /// </summary>
        [Input("zone", required: true)]
        public Input<string> Zone { get; set; } = null!;

        public ComputeInstanceArgs()
        {
        }
    }

    public sealed class ComputeInstanceState : Pulumi.ResourceArgs
    {
        [Input("antiAffinityGroupIds")]
        private InputList<string>? _antiAffinityGroupIds;

        /// <summary>
        /// A list of [Anti-Affinity Group][r-anti_affinity_group] IDs (at creation time only) to assign the Compute instance. Usage of the [`exoscale.AntiAffinityGroup`][d-anti_affinity_group] data source is recommended.
        /// </summary>
        public InputList<string> AntiAffinityGroupIds
        {
            get => _antiAffinityGroupIds ?? (_antiAffinityGroupIds = new InputList<string>());
            set => _antiAffinityGroupIds = value;
        }

        /// <summary>
        /// The creation date of the Compute instance.
        /// </summary>
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        /// <summary>
        /// A Deploy Target ID.
        /// </summary>
        [Input("deployTargetId")]
        public Input<string>? DeployTargetId { get; set; }

        /// <summary>
        /// The Compute instance disk size in GiB (at least `10`). **WARNING**: updating this attribute stops/restarts the Compute instance.
        /// </summary>
        [Input("diskSize")]
        public Input<int>? DiskSize { get; set; }

        [Input("elasticIpIds")]
        private InputList<string>? _elasticIpIds;

        /// <summary>
        /// A list of [Elastic IP][r-elastic_ip] IDs to attach to the Compute instance. Usage of the [`exoscale.ElasticIP`][d-elastic_ip] data source is recommended.
        /// </summary>
        public InputList<string> ElasticIpIds
        {
            get => _elasticIpIds ?? (_elasticIpIds = new InputList<string>());
            set => _elasticIpIds = value;
        }

        /// <summary>
        /// Enable IPv6 on the Compute instance (default: `false`).
        /// </summary>
        [Input("ipv6")]
        public Input<bool>? Ipv6 { get; set; }

        /// <summary>
        /// The IPv6 address of the Compute instance main network interface.
        /// </summary>
        [Input("ipv6Address")]
        public Input<string>? Ipv6Address { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A map of key/value labels.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// The name of the Compute instance.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("privateNetworkIds")]
        private InputList<string>? _privateNetworkIds;

        /// <summary>
        /// A list of [Private Network][r-private_network] IDs to attach to the Compute instance. Usage of the [`exoscale.PrivateNetwork`][d-private_network] data source is recommended.
        /// </summary>
        public InputList<string> PrivateNetworkIds
        {
            get => _privateNetworkIds ?? (_privateNetworkIds = new InputList<string>());
            set => _privateNetworkIds = value;
        }

        /// <summary>
        /// The IPv4 address of the Compute instance's main network interface.
        /// </summary>
        [Input("publicIpAddress")]
        public Input<string>? PublicIpAddress { get; set; }

        [Input("securityGroupIds")]
        private InputList<string>? _securityGroupIds;

        /// <summary>
        /// A list of [Security Group][r-security_group] IDs to attach to the Compute instance. Usage of the [`exoscale.SecurityGroup`][d-security_group] data source is recommended.
        /// </summary>
        public InputList<string> SecurityGroupIds
        {
            get => _securityGroupIds ?? (_securityGroupIds = new InputList<string>());
            set => _securityGroupIds = value;
        }

        /// <summary>
        /// The name of the [SSH key pair][sshkeypair] to install to the Compute instance's user account during creation.
        /// </summary>
        [Input("sshKey")]
        public Input<string>? SshKey { get; set; }

        /// <summary>
        /// The state of the Compute instance (supported values: `started`, `stopped`).
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// The ID of the instance [template][template] to use when creating the Compute instance. Usage of the [`exoscale.getComputeTemplate`][d-compute_template] data source is recommended.
        /// </summary>
        [Input("templateId")]
        public Input<string>? TemplateId { get; set; }

        /// <summary>
        /// The Compute instance [type][type] (format: `FAMILY.SIZE`, e.g. `standard.medium`, `memory.huge`).  **WARNING**: updating this attribute stops/restarts the Compute instance.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// A [cloud-init][cloudinit] configuration.
        /// </summary>
        [Input("userData")]
        public Input<string>? UserData { get; set; }

        /// <summary>
        /// The name of the [zone][zone] to deploy the Compute instance into.
        /// </summary>
        [Input("zone")]
        public Input<string>? Zone { get; set; }

        public ComputeInstanceState()
        {
        }
    }
}

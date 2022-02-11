// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi.Utilities;

namespace Pulumi.Exoscale
{
    public static class GetComputeInstance
    {
        /// <summary>
        /// Provides information on an [Exoscale Compute instance][compute-doc].
        /// 
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Exoscale = Pulumi.Exoscale;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var example = Output.Create(Exoscale.GetComputeInstance.InvokeAsync(new Exoscale.GetComputeInstanceArgs
        ///         {
        ///             Name = "my-instance",
        ///             Zone = "ch-gva-2",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetComputeInstanceResult> InvokeAsync(GetComputeInstanceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetComputeInstanceResult>("exoscale:index/getComputeInstance:getComputeInstance", args ?? new GetComputeInstanceArgs(), options.WithVersion());

        /// <summary>
        /// Provides information on an [Exoscale Compute instance][compute-doc].
        /// 
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Exoscale = Pulumi.Exoscale;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var example = Output.Create(Exoscale.GetComputeInstance.InvokeAsync(new Exoscale.GetComputeInstanceArgs
        ///         {
        ///             Name = "my-instance",
        ///             Zone = "ch-gva-2",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetComputeInstanceResult> Invoke(GetComputeInstanceInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetComputeInstanceResult>("exoscale:index/getComputeInstance:getComputeInstance", args ?? new GetComputeInstanceInvokeArgs(), options.WithVersion());
    }


    public sealed class GetComputeInstanceArgs : Pulumi.InvokeArgs
    {
        [Input("antiAffinityGroupIds")]
        private List<string>? _antiAffinityGroupIds;

        /// <summary>
        /// A list of [Anti-Affinity Group][r-anti_affinity_group] IDs.
        /// </summary>
        public List<string> AntiAffinityGroupIds
        {
            get => _antiAffinityGroupIds ?? (_antiAffinityGroupIds = new List<string>());
            set => _antiAffinityGroupIds = value;
        }

        /// <summary>
        /// The ID of the Compute instance.
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        [Input("labels")]
        private Dictionary<string, string>? _labels;

        /// <summary>
        /// A map of key/value labels.
        /// </summary>
        public Dictionary<string, string> Labels
        {
            get => _labels ?? (_labels = new Dictionary<string, string>());
            set => _labels = value;
        }

        /// <summary>
        /// The name of the Compute instance.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The [zone][zone] of the Compute instance.
        /// </summary>
        [Input("zone", required: true)]
        public string Zone { get; set; } = null!;

        public GetComputeInstanceArgs()
        {
        }
    }

    public sealed class GetComputeInstanceInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("antiAffinityGroupIds")]
        private InputList<string>? _antiAffinityGroupIds;

        /// <summary>
        /// A list of [Anti-Affinity Group][r-anti_affinity_group] IDs.
        /// </summary>
        public InputList<string> AntiAffinityGroupIds
        {
            get => _antiAffinityGroupIds ?? (_antiAffinityGroupIds = new InputList<string>());
            set => _antiAffinityGroupIds = value;
        }

        /// <summary>
        /// The ID of the Compute instance.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

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

        /// <summary>
        /// The [zone][zone] of the Compute instance.
        /// </summary>
        [Input("zone", required: true)]
        public Input<string> Zone { get; set; } = null!;

        public GetComputeInstanceInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetComputeInstanceResult
    {
        /// <summary>
        /// A list of [Anti-Affinity Group][r-anti_affinity_group] IDs.
        /// </summary>
        public readonly ImmutableArray<string> AntiAffinityGroupIds;
        /// <summary>
        /// The creation date of the Compute instance.
        /// </summary>
        public readonly string CreatedAt;
        /// <summary>
        /// A Deploy Target ID.
        /// </summary>
        public readonly string DeployTargetId;
        /// <summary>
        /// The Compute instance disk size in GiB.
        /// </summary>
        public readonly int DiskSize;
        /// <summary>
        /// A list of [Elastic IP][r-elastic_ip] IDs attached to the Compute instance.
        /// </summary>
        public readonly ImmutableArray<string> ElasticIpIds;
        public readonly string? Id;
        /// <summary>
        /// Whether IPv6 is enabled on the Compute instance.
        /// </summary>
        public readonly bool Ipv6;
        /// <summary>
        /// The IPv6 address of the Compute instance main network interface.
        /// </summary>
        public readonly string Ipv6Address;
        /// <summary>
        /// A map of key/value labels.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Labels;
        /// <summary>
        /// The ID of the Compute instance manager, if any.
        /// </summary>
        public readonly string ManagerId;
        public readonly string? Name;
        /// <summary>
        /// A list of [Private Network][r-private_network] IDs attached to the Compute instance.
        /// </summary>
        public readonly ImmutableArray<string> PrivateNetworkIds;
        /// <summary>
        /// The IPv4 address of the Compute instance's main network interface.
        /// </summary>
        public readonly string PublicIpAddress;
        /// <summary>
        /// A list of [Security Group][r-security_group] IDs attached to the Compute instance.
        /// </summary>
        public readonly ImmutableArray<string> SecurityGroupIds;
        /// <summary>
        /// The name of the [SSH key pair][sshkeypair] installed to the Compute instance's user account during creation.
        /// </summary>
        public readonly string SshKey;
        /// <summary>
        /// The state of the Compute instance.
        /// </summary>
        public readonly string State;
        /// <summary>
        /// The ID of the instance [template][template] used when creating the Compute instance.
        /// </summary>
        public readonly string TemplateId;
        /// <summary>
        /// The Compute instance [type][type].
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// A [cloud-init][cloudinit] configuration.
        /// </summary>
        public readonly string UserData;
        public readonly string Zone;

        [OutputConstructor]
        private GetComputeInstanceResult(
            ImmutableArray<string> antiAffinityGroupIds,

            string createdAt,

            string deployTargetId,

            int diskSize,

            ImmutableArray<string> elasticIpIds,

            string? id,

            bool ipv6,

            string ipv6Address,

            ImmutableDictionary<string, string>? labels,

            string managerId,

            string? name,

            ImmutableArray<string> privateNetworkIds,

            string publicIpAddress,

            ImmutableArray<string> securityGroupIds,

            string sshKey,

            string state,

            string templateId,

            string type,

            string userData,

            string zone)
        {
            AntiAffinityGroupIds = antiAffinityGroupIds;
            CreatedAt = createdAt;
            DeployTargetId = deployTargetId;
            DiskSize = diskSize;
            ElasticIpIds = elasticIpIds;
            Id = id;
            Ipv6 = ipv6;
            Ipv6Address = ipv6Address;
            Labels = labels;
            ManagerId = managerId;
            Name = name;
            PrivateNetworkIds = privateNetworkIds;
            PublicIpAddress = publicIpAddress;
            SecurityGroupIds = securityGroupIds;
            SshKey = sshKey;
            State = state;
            TemplateId = templateId;
            Type = type;
            UserData = userData;
            Zone = zone;
        }
    }
}
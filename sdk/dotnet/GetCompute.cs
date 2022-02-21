// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Exoscale
{
    public static class GetCompute
    {
        /// <summary>
        /// Provides information on an [Exoscale Compute instance][compute-doc].
        /// 
        /// !&gt; **WARNING:** This data source is deprecated and will be removed in the next major version.
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
        ///         var myServer = Output.Create(Exoscale.GetCompute.InvokeAsync(new Exoscale.GetComputeArgs
        ///         {
        ///             Hostname = "my server",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetComputeResult> InvokeAsync(GetComputeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetComputeResult>("exoscale:index/getCompute:getCompute", args ?? new GetComputeArgs(), options.WithDefaults());

        /// <summary>
        /// Provides information on an [Exoscale Compute instance][compute-doc].
        /// 
        /// !&gt; **WARNING:** This data source is deprecated and will be removed in the next major version.
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
        ///         var myServer = Output.Create(Exoscale.GetCompute.InvokeAsync(new Exoscale.GetComputeArgs
        ///         {
        ///             Hostname = "my server",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetComputeResult> Invoke(GetComputeInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetComputeResult>("exoscale:index/getCompute:getCompute", args ?? new GetComputeInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetComputeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The hostname of the Compute instance.
        /// </summary>
        [Input("hostname")]
        public string? Hostname { get; set; }

        /// <summary>
        /// The ID of the Compute instance.
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        [Input("tags")]
        private Dictionary<string, string>? _tags;

        /// <summary>
        /// The tags to find the Compute instance (key: value).
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get => _tags ?? (_tags = new Dictionary<string, string>());
            set => _tags = value;
        }

        public GetComputeArgs()
        {
        }
    }

    public sealed class GetComputeInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The hostname of the Compute instance.
        /// </summary>
        [Input("hostname")]
        public Input<string>? Hostname { get; set; }

        /// <summary>
        /// The ID of the Compute instance.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// The tags to find the Compute instance (key: value).
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public GetComputeInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetComputeResult
    {
        /// <summary>
        /// Number of cpu the Compute instance is running with.
        /// </summary>
        public readonly int Cpu;
        /// <summary>
        /// Creation date of the Compute instance.
        /// </summary>
        public readonly string Created;
        /// <summary>
        /// Size of the Compute instance disk.
        /// </summary>
        public readonly int DiskSize;
        public readonly string? Hostname;
        public readonly string? Id;
        /// <summary>
        /// Public IPv6 address of the Compute instance (if IPv6 is enabled).
        /// </summary>
        public readonly string Ip6Address;
        /// <summary>
        /// Public IPv4 address of the Compute instance.
        /// </summary>
        public readonly string IpAddress;
        /// <summary>
        /// Memory allocated for the Compute instance.
        /// </summary>
        public readonly int Memory;
        /// <summary>
        /// List of Compute private IP addresses (in managed Private Networks only).
        /// </summary>
        public readonly ImmutableArray<string> PrivateNetworkIpAddresses;
        /// <summary>
        /// Current size of the Compute instance.
        /// </summary>
        public readonly string Size;
        /// <summary>
        /// State of the Compute instance.
        /// </summary>
        public readonly string State;
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Name of the template.
        /// </summary>
        public readonly string Template;
        /// <summary>
        /// Name of the zone.
        /// </summary>
        public readonly string Zone;

        [OutputConstructor]
        private GetComputeResult(
            int cpu,

            string created,

            int diskSize,

            string? hostname,

            string? id,

            string ip6Address,

            string ipAddress,

            int memory,

            ImmutableArray<string> privateNetworkIpAddresses,

            string size,

            string state,

            ImmutableDictionary<string, string>? tags,

            string template,

            string zone)
        {
            Cpu = cpu;
            Created = created;
            DiskSize = diskSize;
            Hostname = hostname;
            Id = id;
            Ip6Address = ip6Address;
            IpAddress = ipAddress;
            Memory = memory;
            PrivateNetworkIpAddresses = privateNetworkIpAddresses;
            Size = size;
            State = state;
            Tags = tags;
            Template = template;
            Zone = zone;
        }
    }
}

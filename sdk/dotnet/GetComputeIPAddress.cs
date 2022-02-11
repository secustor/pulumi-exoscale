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
    public static class GetComputeIPAddress
    {
        /// <summary>
        /// Provides information on a Compute [Elastic IP address][eip-doc].
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
        ///         var zone = "ch-gva-2";
        ///         var eip = Output.Create(Exoscale.GetComputeIPAddress.InvokeAsync(new Exoscale.GetComputeIPAddressArgs
        ///         {
        ///             Zone = zone,
        ///             IpAddress = "159.162.3.4",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetComputeIPAddressResult> InvokeAsync(GetComputeIPAddressArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetComputeIPAddressResult>("exoscale:index/getComputeIPAddress:getComputeIPAddress", args ?? new GetComputeIPAddressArgs(), options.WithVersion());

        /// <summary>
        /// Provides information on a Compute [Elastic IP address][eip-doc].
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
        ///         var zone = "ch-gva-2";
        ///         var eip = Output.Create(Exoscale.GetComputeIPAddress.InvokeAsync(new Exoscale.GetComputeIPAddressArgs
        ///         {
        ///             Zone = zone,
        ///             IpAddress = "159.162.3.4",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetComputeIPAddressResult> Invoke(GetComputeIPAddressInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetComputeIPAddressResult>("exoscale:index/getComputeIPAddress:getComputeIPAddress", args ?? new GetComputeIPAddressInvokeArgs(), options.WithVersion());
    }


    public sealed class GetComputeIPAddressArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The Description to find the IP Address.
        /// </summary>
        [Input("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The ID of the IP Address.
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The IP Address of the EIP.
        /// </summary>
        [Input("ipAddress")]
        public string? IpAddress { get; set; }

        [Input("tags")]
        private Dictionary<string, string>? _tags;

        /// <summary>
        /// The tags to find the IP Address.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get => _tags ?? (_tags = new Dictionary<string, string>());
            set => _tags = value;
        }

        /// <summary>
        /// The name of the [zone][zone] where to look for the IP Address.
        /// </summary>
        [Input("zone", required: true)]
        public string Zone { get; set; } = null!;

        public GetComputeIPAddressArgs()
        {
        }
    }

    public sealed class GetComputeIPAddressInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The Description to find the IP Address.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The ID of the IP Address.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// The IP Address of the EIP.
        /// </summary>
        [Input("ipAddress")]
        public Input<string>? IpAddress { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// The tags to find the IP Address.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The name of the [zone][zone] where to look for the IP Address.
        /// </summary>
        [Input("zone", required: true)]
        public Input<string> Zone { get; set; } = null!;

        public GetComputeIPAddressInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetComputeIPAddressResult
    {
        public readonly string? Description;
        public readonly string? Id;
        public readonly string? IpAddress;
        public readonly ImmutableDictionary<string, string>? Tags;
        public readonly string Zone;

        [OutputConstructor]
        private GetComputeIPAddressResult(
            string? description,

            string? id,

            string? ipAddress,

            ImmutableDictionary<string, string>? tags,

            string zone)
        {
            Description = description;
            Id = id;
            IpAddress = ipAddress;
            Tags = tags;
            Zone = zone;
        }
    }
}
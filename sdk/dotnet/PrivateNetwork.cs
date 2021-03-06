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
    /// Provides an Exoscale [Private Network][privnet-doc] resource. This can be used to create, update and delete Private Networks.
    /// 
    /// ## Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Exoscale = Pulumi.Exoscale;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var example = new Exoscale.PrivateNetwork("example", new Exoscale.PrivateNetworkArgs
    ///         {
    ///             Description = "Out-of-band network",
    ///             Zone = "ch-gva-2",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// *Managed* Private Network:
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Exoscale = Pulumi.Exoscale;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var example_managed = new Exoscale.PrivateNetwork("example-managed", new Exoscale.PrivateNetworkArgs
    ///         {
    ///             Description = "Out-of-band network with DHCP",
    ///             EndIp = "10.0.0.253",
    ///             Netmask = "255.255.255.0",
    ///             StartIp = "10.0.0.20",
    ///             Zone = "ch-gva-2",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// An existing Private Network can be imported as a resource by specifying `ID@ZONE`console
    /// 
    /// ```sh
    ///  $ pulumi import exoscale:index/privateNetwork:PrivateNetwork net 04fb76a2-6d22-49be-8da7-f2a5a0b902e1@ch-gva-2
    /// ```
    /// 
    ///  [privnet-doc]https://community.exoscale.com/documentation/compute/private-networks/ [zone]https://www.exoscale.com/datacenters/
    /// </summary>
    [ExoscaleResourceType("exoscale:index/privateNetwork:PrivateNetwork")]
    public partial class PrivateNetwork : Pulumi.CustomResource
    {
        /// <summary>
        /// A description for the Private Network.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The last address of the IP range used by the DHCP service. Required for *managed* Private Networks.
        /// </summary>
        [Output("endIp")]
        public Output<string?> EndIp { get; private set; } = null!;

        /// <summary>
        /// The name of the Private Network.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The netmask defining the IP network allowed for the static lease. Required for *managed* Private Networks.
        /// </summary>
        [Output("netmask")]
        public Output<string?> Netmask { get; private set; } = null!;

        /// <summary>
        /// The first address of IP range used by the DHCP service to automatically assign. Required for *managed* Private Networks.
        /// </summary>
        [Output("startIp")]
        public Output<string?> StartIp { get; private set; } = null!;

        /// <summary>
        /// The name of the [zone][zone] to create the Private Network into.
        /// </summary>
        [Output("zone")]
        public Output<string> Zone { get; private set; } = null!;


        /// <summary>
        /// Create a PrivateNetwork resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public PrivateNetwork(string name, PrivateNetworkArgs args, CustomResourceOptions? options = null)
            : base("exoscale:index/privateNetwork:PrivateNetwork", name, args ?? new PrivateNetworkArgs(), MakeResourceOptions(options, ""))
        {
        }

        private PrivateNetwork(string name, Input<string> id, PrivateNetworkState? state = null, CustomResourceOptions? options = null)
            : base("exoscale:index/privateNetwork:PrivateNetwork", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing PrivateNetwork resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static PrivateNetwork Get(string name, Input<string> id, PrivateNetworkState? state = null, CustomResourceOptions? options = null)
        {
            return new PrivateNetwork(name, id, state, options);
        }
    }

    public sealed class PrivateNetworkArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A description for the Private Network.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The last address of the IP range used by the DHCP service. Required for *managed* Private Networks.
        /// </summary>
        [Input("endIp")]
        public Input<string>? EndIp { get; set; }

        /// <summary>
        /// The name of the Private Network.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The netmask defining the IP network allowed for the static lease. Required for *managed* Private Networks.
        /// </summary>
        [Input("netmask")]
        public Input<string>? Netmask { get; set; }

        /// <summary>
        /// The first address of IP range used by the DHCP service to automatically assign. Required for *managed* Private Networks.
        /// </summary>
        [Input("startIp")]
        public Input<string>? StartIp { get; set; }

        /// <summary>
        /// The name of the [zone][zone] to create the Private Network into.
        /// </summary>
        [Input("zone", required: true)]
        public Input<string> Zone { get; set; } = null!;

        public PrivateNetworkArgs()
        {
        }
    }

    public sealed class PrivateNetworkState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A description for the Private Network.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The last address of the IP range used by the DHCP service. Required for *managed* Private Networks.
        /// </summary>
        [Input("endIp")]
        public Input<string>? EndIp { get; set; }

        /// <summary>
        /// The name of the Private Network.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The netmask defining the IP network allowed for the static lease. Required for *managed* Private Networks.
        /// </summary>
        [Input("netmask")]
        public Input<string>? Netmask { get; set; }

        /// <summary>
        /// The first address of IP range used by the DHCP service to automatically assign. Required for *managed* Private Networks.
        /// </summary>
        [Input("startIp")]
        public Input<string>? StartIp { get; set; }

        /// <summary>
        /// The name of the [zone][zone] to create the Private Network into.
        /// </summary>
        [Input("zone")]
        public Input<string>? Zone { get; set; }

        public PrivateNetworkState()
        {
        }
    }
}

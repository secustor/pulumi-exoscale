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
    /// Provides an Exoscale [DNS][dns-doc] Domain resource. This can be used to create and delete DNS Domains.
    /// 
    /// ## Usage example
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Exoscale = Pulumi.Exoscale;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var example = new Exoscale.Domain("example", new Exoscale.DomainArgs
    ///         {
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// An existing DNS Domain can be imported as a resource by nameconsole
    /// 
    /// ```sh
    ///  $ pulumi import exoscale:index/domain:Domain example example.net
    /// ```
    /// 
    ///  [dns-doc]https://community.exoscale.com/documentation/dns/ [r-domain_record]domain_record.html
    /// </summary>
    [ExoscaleResourceType("exoscale:index/domain:Domain")]
    public partial class Domain : Pulumi.CustomResource
    {
        /// <summary>
        /// Boolean indicating that the DNS Domain has automatic renewal enabled.
        /// </summary>
        [Output("autoRenew")]
        public Output<bool> AutoRenew { get; private set; } = null!;

        /// <summary>
        /// The date of expiration of the DNS Domain, if known.
        /// </summary>
        [Output("expiresOn")]
        public Output<string> ExpiresOn { get; private set; } = null!;

        /// <summary>
        /// The name of the DNS Domain.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The state of the DNS Domain.
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;

        /// <summary>
        /// A security token that can be used as an alternative way to manage DNS Domains via the Exoscale API.
        /// </summary>
        [Output("token")]
        public Output<string> Token { get; private set; } = null!;


        /// <summary>
        /// Create a Domain resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Domain(string name, DomainArgs? args = null, CustomResourceOptions? options = null)
            : base("exoscale:index/domain:Domain", name, args ?? new DomainArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Domain(string name, Input<string> id, DomainState? state = null, CustomResourceOptions? options = null)
            : base("exoscale:index/domain:Domain", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Domain resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Domain Get(string name, Input<string> id, DomainState? state = null, CustomResourceOptions? options = null)
        {
            return new Domain(name, id, state, options);
        }
    }

    public sealed class DomainArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the DNS Domain.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public DomainArgs()
        {
        }
    }

    public sealed class DomainState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Boolean indicating that the DNS Domain has automatic renewal enabled.
        /// </summary>
        [Input("autoRenew")]
        public Input<bool>? AutoRenew { get; set; }

        /// <summary>
        /// The date of expiration of the DNS Domain, if known.
        /// </summary>
        [Input("expiresOn")]
        public Input<string>? ExpiresOn { get; set; }

        /// <summary>
        /// The name of the DNS Domain.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The state of the DNS Domain.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// A security token that can be used as an alternative way to manage DNS Domains via the Exoscale API.
        /// </summary>
        [Input("token")]
        public Input<string>? Token { get; set; }

        public DomainState()
        {
        }
    }
}

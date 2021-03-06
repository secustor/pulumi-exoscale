// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Exoscale
{
    public static class GetAffinity
    {
        /// <summary>
        /// Provides information on an [Anti-Affinity Group][aag-doc] for use in other resources such as a [`exoscale.Compute`][r-compute] resource.
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
        ///         var web = Output.Create(Exoscale.GetAffinity.InvokeAsync(new Exoscale.GetAffinityArgs
        ///         {
        ///             Name = "web",
        ///         }));
        ///         var ubuntu = Output.Create(Exoscale.GetComputeTemplate.InvokeAsync(new Exoscale.GetComputeTemplateArgs
        ///         {
        ///             Zone = zone,
        ///             Name = "Linux Ubuntu 20.04 LTS 64-bit",
        ///         }));
        ///         var myServer = new Exoscale.Compute("myServer", new Exoscale.ComputeArgs
        ///         {
        ///             Zone = zone,
        ///             TemplateId = ubuntu.Apply(ubuntu =&gt; ubuntu.Id),
        ///             DiskSize = 20,
        ///             AffinityGroupIds = 
        ///             {
        ///                 web.Apply(web =&gt; web.Id),
        ///             },
        ///         });
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetAffinityResult> InvokeAsync(GetAffinityArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetAffinityResult>("exoscale:index/getAffinity:getAffinity", args ?? new GetAffinityArgs(), options.WithDefaults());

        /// <summary>
        /// Provides information on an [Anti-Affinity Group][aag-doc] for use in other resources such as a [`exoscale.Compute`][r-compute] resource.
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
        ///         var web = Output.Create(Exoscale.GetAffinity.InvokeAsync(new Exoscale.GetAffinityArgs
        ///         {
        ///             Name = "web",
        ///         }));
        ///         var ubuntu = Output.Create(Exoscale.GetComputeTemplate.InvokeAsync(new Exoscale.GetComputeTemplateArgs
        ///         {
        ///             Zone = zone,
        ///             Name = "Linux Ubuntu 20.04 LTS 64-bit",
        ///         }));
        ///         var myServer = new Exoscale.Compute("myServer", new Exoscale.ComputeArgs
        ///         {
        ///             Zone = zone,
        ///             TemplateId = ubuntu.Apply(ubuntu =&gt; ubuntu.Id),
        ///             DiskSize = 20,
        ///             AffinityGroupIds = 
        ///             {
        ///                 web.Apply(web =&gt; web.Id),
        ///             },
        ///         });
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetAffinityResult> Invoke(GetAffinityInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetAffinityResult>("exoscale:index/getAffinity:getAffinity", args ?? new GetAffinityInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetAffinityArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The ID of the Anti-Affinity Group (conflicts with `name`)
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the Anti-Affinity Group (conflicts with `id`)
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        public GetAffinityArgs()
        {
        }
    }

    public sealed class GetAffinityInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The ID of the Anti-Affinity Group (conflicts with `name`)
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// The name of the Anti-Affinity Group (conflicts with `id`)
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public GetAffinityInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetAffinityResult
    {
        public readonly string? Id;
        public readonly string? Name;

        [OutputConstructor]
        private GetAffinityResult(
            string? id,

            string? name)
        {
            Id = id;
            Name = name;
        }
    }
}

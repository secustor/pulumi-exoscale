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
    public static class GetDomain
    {
        /// <summary>
        /// Provides information on a domain name hosted on [Exoscale DNS][exo-dns].
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
        ///         var my_company_com = Output.Create(Exoscale.GetDomain.InvokeAsync(new Exoscale.GetDomainArgs
        ///         {
        ///             Name = "my-company.com",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetDomainResult> InvokeAsync(GetDomainArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDomainResult>("exoscale:index/getDomain:getDomain", args ?? new GetDomainArgs(), options.WithVersion());

        /// <summary>
        /// Provides information on a domain name hosted on [Exoscale DNS][exo-dns].
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
        ///         var my_company_com = Output.Create(Exoscale.GetDomain.InvokeAsync(new Exoscale.GetDomainArgs
        ///         {
        ///             Name = "my-company.com",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetDomainResult> Invoke(GetDomainInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetDomainResult>("exoscale:index/getDomain:getDomain", args ?? new GetDomainInvokeArgs(), options.WithVersion());
    }


    public sealed class GetDomainArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the domain.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        public GetDomainArgs()
        {
        }
    }

    public sealed class GetDomainInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the domain.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public GetDomainInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDomainResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string Name;

        [OutputConstructor]
        private GetDomainResult(
            string id,

            string name)
        {
            Id = id;
            Name = name;
        }
    }
}
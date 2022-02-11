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
    public static class GetPrivateNetwork
    {
        /// <summary>
        /// Provides information on a [Private Network][privnet-doc] for use in other resources such as a [`exoscale.InstancePool`][r-instance_pool] resource.
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
        ///         var db = Output.Create(Exoscale.GetPrivateNetwork.InvokeAsync(new Exoscale.GetPrivateNetworkArgs
        ///         {
        ///             Zone = zone,
        ///             Name = "db",
        ///         }));
        ///         var ubuntu = Output.Create(Exoscale.GetComputeTemplate.InvokeAsync(new Exoscale.GetComputeTemplateArgs
        ///         {
        ///             Zone = zone,
        ///             Name = "Linux Ubuntu 20.04 LTS 64-bit",
        ///         }));
        ///         var webservers = new Exoscale.InstancePool("webservers", new Exoscale.InstancePoolArgs
        ///         {
        ///             Zone = zone,
        ///             TemplateId = ubuntu.Apply(ubuntu =&gt; ubuntu.Id),
        ///             Size = 5,
        ///             ServiceOffering = "standard.medium",
        ///             NetworkIds = 
        ///             {
        ///                 db.Apply(db =&gt; db.Id),
        ///             },
        ///         });
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetPrivateNetworkResult> InvokeAsync(GetPrivateNetworkArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPrivateNetworkResult>("exoscale:index/getPrivateNetwork:getPrivateNetwork", args ?? new GetPrivateNetworkArgs(), options.WithVersion());

        /// <summary>
        /// Provides information on a [Private Network][privnet-doc] for use in other resources such as a [`exoscale.InstancePool`][r-instance_pool] resource.
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
        ///         var db = Output.Create(Exoscale.GetPrivateNetwork.InvokeAsync(new Exoscale.GetPrivateNetworkArgs
        ///         {
        ///             Zone = zone,
        ///             Name = "db",
        ///         }));
        ///         var ubuntu = Output.Create(Exoscale.GetComputeTemplate.InvokeAsync(new Exoscale.GetComputeTemplateArgs
        ///         {
        ///             Zone = zone,
        ///             Name = "Linux Ubuntu 20.04 LTS 64-bit",
        ///         }));
        ///         var webservers = new Exoscale.InstancePool("webservers", new Exoscale.InstancePoolArgs
        ///         {
        ///             Zone = zone,
        ///             TemplateId = ubuntu.Apply(ubuntu =&gt; ubuntu.Id),
        ///             Size = 5,
        ///             ServiceOffering = "standard.medium",
        ///             NetworkIds = 
        ///             {
        ///                 db.Apply(db =&gt; db.Id),
        ///             },
        ///         });
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetPrivateNetworkResult> Invoke(GetPrivateNetworkInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetPrivateNetworkResult>("exoscale:index/getPrivateNetwork:getPrivateNetwork", args ?? new GetPrivateNetworkInvokeArgs(), options.WithVersion());
    }


    public sealed class GetPrivateNetworkArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The description of the Private Network.
        /// </summary>
        [Input("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The ID of the Private Network (conflicts with `name`).
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the Private Network (conflicts with `id`).
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The [zone][zone] of the Private Network.
        /// </summary>
        [Input("zone", required: true)]
        public string Zone { get; set; } = null!;

        public GetPrivateNetworkArgs()
        {
        }
    }

    public sealed class GetPrivateNetworkInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The description of the Private Network.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The ID of the Private Network (conflicts with `name`).
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// The name of the Private Network (conflicts with `id`).
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The [zone][zone] of the Private Network.
        /// </summary>
        [Input("zone", required: true)]
        public Input<string> Zone { get; set; } = null!;

        public GetPrivateNetworkInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetPrivateNetworkResult
    {
        /// <summary>
        /// The description of the Private Network.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The last address of the IP range used by the DHCP service (for *managed* Private Networks).
        /// </summary>
        public readonly string EndIp;
        public readonly string? Id;
        public readonly string? Name;
        /// <summary>
        /// The netmask defining the IP network allowed for the static lease (for *managed* Private Networks).
        /// </summary>
        public readonly string Netmask;
        /// <summary>
        /// The first address of IP range used by the DHCP service to automatically assign (for *managed* Private Networks).
        /// </summary>
        public readonly string StartIp;
        public readonly string Zone;

        [OutputConstructor]
        private GetPrivateNetworkResult(
            string? description,

            string endIp,

            string? id,

            string? name,

            string netmask,

            string startIp,

            string zone)
        {
            Description = description;
            EndIp = endIp;
            Id = id;
            Name = name;
            Netmask = netmask;
            StartIp = startIp;
            Zone = zone;
        }
    }
}
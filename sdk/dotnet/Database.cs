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
    /// Provides an Exoscale [DBaaS][dbaas-doc] service resource. This can be used to create, modify, and delete database services.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Text.Json;
    /// using Pulumi;
    /// using Exoscale = Pulumi.Exoscale;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var zone = "ch-dk-2";
    ///         var pgProd = new Exoscale.Database("pgProd", new Exoscale.DatabaseArgs
    ///         {
    ///             Zone = zone,
    ///             Type = "pg",
    ///             Plan = "startup-4",
    ///             MaintenanceDow = "sunday",
    ///             MaintenanceTime = "23:00:00",
    ///             TerminationProtection = true,
    ///             Pg = new Exoscale.Inputs.DatabasePgArgs
    ///             {
    ///                 Version = "13",
    ///                 BackupSchedule = "04:00",
    ///                 IpFilters = 
    ///                 {
    ///                     "1.2.3.4/32",
    ///                     "5.6.7.8/32",
    ///                 },
    ///                 PgSettings = JsonSerializer.Serialize(new Dictionary&lt;string, object?&gt;
    ///                 {
    ///                     { "timezone", "Europe/Zurich" },
    ///                 }),
    ///             },
    ///         });
    ///         this.DatabaseUri = pgProd.Uri;
    ///     }
    /// 
    ///     [Output("databaseUri")]
    ///     public Output&lt;string&gt; DatabaseUri { get; set; }
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// An existing database service can be imported as a resource by specifying `NAME@ZONE`console
    /// 
    /// ```sh
    ///  $ pulumi import exoscale:index/database:Database example my-database@de-fra-1
    /// ```
    /// 
    ///  [dbaas-doc]https://community.exoscale.com/documentation/dbaas/ [zone]https://www.exoscale.com/datacenters/
    /// </summary>
    [ExoscaleResourceType("exoscale:index/database:Database")]
    public partial class Database : Pulumi.CustomResource
    {
        /// <summary>
        /// The creation date of the database service.
        /// </summary>
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        /// <summary>
        /// The disk size of the database service.
        /// </summary>
        [Output("diskSize")]
        public Output<int> DiskSize { get; private set; } = null!;

        /// <summary>
        /// *kafka* database service type specific arguments. Structure is documented below.
        /// </summary>
        [Output("kafka")]
        public Output<Outputs.DatabaseKafka?> Kafka { get; private set; } = null!;

        /// <summary>
        /// The day of week to perform the automated database service maintenance (accepted values: `never`, `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`).
        /// </summary>
        [Output("maintenanceDow")]
        public Output<string> MaintenanceDow { get; private set; } = null!;

        /// <summary>
        /// The time of day to perform the automated database service maintenance (format: `HH:MM:SS`)
        /// </summary>
        [Output("maintenanceTime")]
        public Output<string> MaintenanceTime { get; private set; } = null!;

        /// <summary>
        /// *mysql* database service type specific arguments. Structure is documented below.
        /// </summary>
        [Output("mysql")]
        public Output<Outputs.DatabaseMysql?> Mysql { get; private set; } = null!;

        /// <summary>
        /// The name of the database service.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The number of CPUs of the database service.
        /// </summary>
        [Output("nodeCpus")]
        public Output<int> NodeCpus { get; private set; } = null!;

        /// <summary>
        /// The amount of memory of the database service.
        /// </summary>
        [Output("nodeMemory")]
        public Output<int> NodeMemory { get; private set; } = null!;

        /// <summary>
        /// The number of nodes of the database service.
        /// </summary>
        [Output("nodes")]
        public Output<int> Nodes { get; private set; } = null!;

        /// <summary>
        /// *pg* database service type specific arguments. Structure is documented below.
        /// </summary>
        [Output("pg")]
        public Output<Outputs.DatabasePg?> Pg { get; private set; } = null!;

        /// <summary>
        /// The plan of the database service (`exo dbaas type show &lt;TYPE&gt;` for reference).
        /// </summary>
        [Output("plan")]
        public Output<string> Plan { get; private set; } = null!;

        /// <summary>
        /// *redis* database service type specific arguments.Structure is documented below.
        /// </summary>
        [Output("redis")]
        public Output<Outputs.DatabaseRedis?> Redis { get; private set; } = null!;

        /// <summary>
        /// The current state of the database service.
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;

        /// <summary>
        /// The database service protection boolean flag against termination/power-off.
        /// </summary>
        [Output("terminationProtection")]
        public Output<bool?> TerminationProtection { get; private set; } = null!;

        /// <summary>
        /// The type of the database service (accepted values: `kafka`, `mysql`, `pg`, `redis`).
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// The date of the latest database service update.
        /// </summary>
        [Output("updatedAt")]
        public Output<string> UpdatedAt { get; private set; } = null!;

        /// <summary>
        /// The database service connection URI.
        /// </summary>
        [Output("uri")]
        public Output<string> Uri { get; private set; } = null!;

        /// <summary>
        /// The name of the [zone][zone] to deploy the database service into.
        /// </summary>
        [Output("zone")]
        public Output<string> Zone { get; private set; } = null!;


        /// <summary>
        /// Create a Database resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Database(string name, DatabaseArgs args, CustomResourceOptions? options = null)
            : base("exoscale:index/database:Database", name, args ?? new DatabaseArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Database(string name, Input<string> id, DatabaseState? state = null, CustomResourceOptions? options = null)
            : base("exoscale:index/database:Database", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Database resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Database Get(string name, Input<string> id, DatabaseState? state = null, CustomResourceOptions? options = null)
        {
            return new Database(name, id, state, options);
        }
    }

    public sealed class DatabaseArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// *kafka* database service type specific arguments. Structure is documented below.
        /// </summary>
        [Input("kafka")]
        public Input<Inputs.DatabaseKafkaArgs>? Kafka { get; set; }

        /// <summary>
        /// The day of week to perform the automated database service maintenance (accepted values: `never`, `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`).
        /// </summary>
        [Input("maintenanceDow")]
        public Input<string>? MaintenanceDow { get; set; }

        /// <summary>
        /// The time of day to perform the automated database service maintenance (format: `HH:MM:SS`)
        /// </summary>
        [Input("maintenanceTime")]
        public Input<string>? MaintenanceTime { get; set; }

        /// <summary>
        /// *mysql* database service type specific arguments. Structure is documented below.
        /// </summary>
        [Input("mysql")]
        public Input<Inputs.DatabaseMysqlArgs>? Mysql { get; set; }

        /// <summary>
        /// The name of the database service.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// *pg* database service type specific arguments. Structure is documented below.
        /// </summary>
        [Input("pg")]
        public Input<Inputs.DatabasePgArgs>? Pg { get; set; }

        /// <summary>
        /// The plan of the database service (`exo dbaas type show &lt;TYPE&gt;` for reference).
        /// </summary>
        [Input("plan", required: true)]
        public Input<string> Plan { get; set; } = null!;

        /// <summary>
        /// *redis* database service type specific arguments.Structure is documented below.
        /// </summary>
        [Input("redis")]
        public Input<Inputs.DatabaseRedisArgs>? Redis { get; set; }

        /// <summary>
        /// The database service protection boolean flag against termination/power-off.
        /// </summary>
        [Input("terminationProtection")]
        public Input<bool>? TerminationProtection { get; set; }

        /// <summary>
        /// The type of the database service (accepted values: `kafka`, `mysql`, `pg`, `redis`).
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// The name of the [zone][zone] to deploy the database service into.
        /// </summary>
        [Input("zone", required: true)]
        public Input<string> Zone { get; set; } = null!;

        public DatabaseArgs()
        {
        }
    }

    public sealed class DatabaseState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The creation date of the database service.
        /// </summary>
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        /// <summary>
        /// The disk size of the database service.
        /// </summary>
        [Input("diskSize")]
        public Input<int>? DiskSize { get; set; }

        /// <summary>
        /// *kafka* database service type specific arguments. Structure is documented below.
        /// </summary>
        [Input("kafka")]
        public Input<Inputs.DatabaseKafkaGetArgs>? Kafka { get; set; }

        /// <summary>
        /// The day of week to perform the automated database service maintenance (accepted values: `never`, `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`).
        /// </summary>
        [Input("maintenanceDow")]
        public Input<string>? MaintenanceDow { get; set; }

        /// <summary>
        /// The time of day to perform the automated database service maintenance (format: `HH:MM:SS`)
        /// </summary>
        [Input("maintenanceTime")]
        public Input<string>? MaintenanceTime { get; set; }

        /// <summary>
        /// *mysql* database service type specific arguments. Structure is documented below.
        /// </summary>
        [Input("mysql")]
        public Input<Inputs.DatabaseMysqlGetArgs>? Mysql { get; set; }

        /// <summary>
        /// The name of the database service.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The number of CPUs of the database service.
        /// </summary>
        [Input("nodeCpus")]
        public Input<int>? NodeCpus { get; set; }

        /// <summary>
        /// The amount of memory of the database service.
        /// </summary>
        [Input("nodeMemory")]
        public Input<int>? NodeMemory { get; set; }

        /// <summary>
        /// The number of nodes of the database service.
        /// </summary>
        [Input("nodes")]
        public Input<int>? Nodes { get; set; }

        /// <summary>
        /// *pg* database service type specific arguments. Structure is documented below.
        /// </summary>
        [Input("pg")]
        public Input<Inputs.DatabasePgGetArgs>? Pg { get; set; }

        /// <summary>
        /// The plan of the database service (`exo dbaas type show &lt;TYPE&gt;` for reference).
        /// </summary>
        [Input("plan")]
        public Input<string>? Plan { get; set; }

        /// <summary>
        /// *redis* database service type specific arguments.Structure is documented below.
        /// </summary>
        [Input("redis")]
        public Input<Inputs.DatabaseRedisGetArgs>? Redis { get; set; }

        /// <summary>
        /// The current state of the database service.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// The database service protection boolean flag against termination/power-off.
        /// </summary>
        [Input("terminationProtection")]
        public Input<bool>? TerminationProtection { get; set; }

        /// <summary>
        /// The type of the database service (accepted values: `kafka`, `mysql`, `pg`, `redis`).
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// The date of the latest database service update.
        /// </summary>
        [Input("updatedAt")]
        public Input<string>? UpdatedAt { get; set; }

        /// <summary>
        /// The database service connection URI.
        /// </summary>
        [Input("uri")]
        public Input<string>? Uri { get; set; }

        /// <summary>
        /// The name of the [zone][zone] to deploy the database service into.
        /// </summary>
        [Input("zone")]
        public Input<string>? Zone { get; set; }

        public DatabaseState()
        {
        }
    }
}

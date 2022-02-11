// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Exoscale.Inputs
{

    public sealed class DatabaseKafkaArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Enable certificate-based authentication method.
        /// </summary>
        [Input("enableCertAuth")]
        public Input<bool>? EnableCertAuth { get; set; }

        /// <summary>
        /// Enable Kafka Connect.
        /// </summary>
        [Input("enableKafkaConnect")]
        public Input<bool>? EnableKafkaConnect { get; set; }

        /// <summary>
        /// Enable Kafka REST.
        /// </summary>
        [Input("enableKafkaRest")]
        public Input<bool>? EnableKafkaRest { get; set; }

        /// <summary>
        /// Enable SASL-based authentication method.
        /// </summary>
        [Input("enableSaslAuth")]
        public Input<bool>? EnableSaslAuth { get; set; }

        /// <summary>
        /// Enable Schema Registry.
        /// </summary>
        [Input("enableSchemaRegistry")]
        public Input<bool>? EnableSchemaRegistry { get; set; }

        [Input("ipFilters")]
        private InputList<string>? _ipFilters;

        /// <summary>
        /// A list of CIDR blocks to allow incoming connections from.
        /// </summary>
        public InputList<string> IpFilters
        {
            get => _ipFilters ?? (_ipFilters = new InputList<string>());
            set => _ipFilters = value;
        }

        /// <summary>
        /// Kafka Connect configuration settings in JSON format (`exo dbaas type show kafka --settings=kafka-connect` for reference).
        /// </summary>
        [Input("kafkaConnectSettings")]
        public Input<string>? KafkaConnectSettings { get; set; }

        /// <summary>
        /// Kafka REST configuration settings in JSON format (`exo dbaas type show kafka --settings=kafka-rest` for reference).
        /// </summary>
        [Input("kafkaRestSettings")]
        public Input<string>? KafkaRestSettings { get; set; }

        /// <summary>
        /// Kafka configuration settings in JSON format (`exo dbaas type show kafka --settings=kafka` for reference).
        /// </summary>
        [Input("kafkaSettings")]
        public Input<string>? KafkaSettings { get; set; }

        /// <summary>
        /// Schema Registry configuration settings in JSON format (`exo dbaas type show kafka --settings=schema-registry` for reference)
        /// </summary>
        [Input("schemaRegistrySettings")]
        public Input<string>? SchemaRegistrySettings { get; set; }

        /// <summary>
        /// PostgreSQL major version (`exo dbaas type show pg` for reference). Can only be set during creation.
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        public DatabaseKafkaArgs()
        {
        }
    }
}
// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Exoscale.Inputs
{

    public sealed class ElasticIPHealthcheckArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The health checking interval in seconds (must be between `5` and `300`; default: `10`).
        /// </summary>
        [Input("interval")]
        public Input<int>? Interval { get; set; }

        /// <summary>
        /// The health checking mode (`supported values: `tcp`, `http`, `https`).
        /// </summary>
        [Input("mode", required: true)]
        public Input<string> Mode { get; set; } = null!;

        /// <summary>
        /// The health checking port (must be between `1` and `65535`).
        /// </summary>
        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        /// <summary>
        /// The number of failed attempts before considering a managed Elastic IP target unhealthy (must be between `1` and `20`).
        /// </summary>
        [Input("strikesFail")]
        public Input<int>? StrikesFail { get; set; }

        /// <summary>
        /// The number of successful attempts before considering a managed Elastic IP target healthy (must be between `1` and `20`).
        /// </summary>
        [Input("strikesOk")]
        public Input<int>? StrikesOk { get; set; }

        /// <summary>
        /// The time in seconds before considering a healthcheck probing failed (must be between `2` and `60`; default: `3`).
        /// </summary>
        [Input("timeout")]
        public Input<int>? Timeout { get; set; }

        /// <summary>
        /// Disable TLS certificate verification for health checking in `https` mode.
        /// </summary>
        [Input("tlsSkipVerify")]
        public Input<bool>? TlsSkipVerify { get; set; }

        /// <summary>
        /// The health checking server name to present with SNI in `https` mode.
        /// </summary>
        [Input("tlsSni")]
        public Input<string>? TlsSni { get; set; }

        /// <summary>
        /// The health checking URI (required in `http(s)` modes).
        /// </summary>
        [Input("uri")]
        public Input<string>? Uri { get; set; }

        public ElasticIPHealthcheckArgs()
        {
        }
    }
}

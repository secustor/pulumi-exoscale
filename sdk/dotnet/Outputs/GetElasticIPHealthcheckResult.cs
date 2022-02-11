// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Exoscale.Outputs
{

    [OutputType]
    public sealed class GetElasticIPHealthcheckResult
    {
        /// <summary>
        /// The health checking interval in seconds.
        /// </summary>
        public readonly int Interval;
        /// <summary>
        /// (Required) The health checking mode.
        /// </summary>
        public readonly string Mode;
        /// <summary>
        /// (Required) The health checking port.
        /// </summary>
        public readonly int Port;
        /// <summary>
        /// The number of failed attempts before considering a managed Elastic IP target unhealthy.
        /// </summary>
        public readonly int StrikesFail;
        /// <summary>
        /// The number of successful attempts before considering a managed Elastic IP target healthy.
        /// </summary>
        public readonly int StrikesOk;
        /// <summary>
        /// The time in seconds before considering a healthcheck probing failed.
        /// </summary>
        public readonly int Timeout;
        /// <summary>
        /// Disable TLS certificate verification for health checking in `https` mode.
        /// </summary>
        public readonly bool TlsSkipVerify;
        /// <summary>
        /// The health checking server name to present with SNI in `https` mode.
        /// </summary>
        public readonly string TlsSni;
        /// <summary>
        /// The health checking URI.
        /// </summary>
        public readonly string Uri;

        [OutputConstructor]
        private GetElasticIPHealthcheckResult(
            int interval,

            string mode,

            int port,

            int strikesFail,

            int strikesOk,

            int timeout,

            bool tlsSkipVerify,

            string tlsSni,

            string uri)
        {
            Interval = interval;
            Mode = mode;
            Port = port;
            StrikesFail = strikesFail;
            StrikesOk = strikesOk;
            Timeout = timeout;
            TlsSkipVerify = tlsSkipVerify;
            TlsSni = tlsSni;
            Uri = uri;
        }
    }
}

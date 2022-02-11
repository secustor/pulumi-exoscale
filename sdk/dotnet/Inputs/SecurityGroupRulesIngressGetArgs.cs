// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Exoscale.Inputs
{

    public sealed class SecurityGroupRulesIngressGetArgs : Pulumi.ResourceArgs
    {
        [Input("cidrLists")]
        private InputList<string>? _cidrLists;

        /// <summary>
        /// A list of source (for ingress)/destination (for egress) IP subnet (in [CIDR notation][cidr]) to match.
        /// </summary>
        public InputList<string> CidrLists
        {
            get => _cidrLists ?? (_cidrLists = new InputList<string>());
            set => _cidrLists = value;
        }

        /// <summary>
        /// A free-form text describing the Security Group rule purpose.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("icmpCode")]
        public Input<int>? IcmpCode { get; set; }

        [Input("icmpType")]
        public Input<int>? IcmpType { get; set; }

        [Input("ids")]
        private InputList<string>? _ids;
        public InputList<string> Ids
        {
            get => _ids ?? (_ids = new InputList<string>());
            set => _ids = value;
        }

        [Input("ports")]
        private InputList<string>? _ports;

        /// <summary>
        /// A list of ports or port ranges (`start_port-end_port`).
        /// * `icmp_type`/`icmp_code` - An ICMP/ICMPv6 [type/code][icmp] to match.
        /// </summary>
        public InputList<string> Ports
        {
            get => _ports ?? (_ports = new InputList<string>());
            set => _ports = value;
        }

        /// <summary>
        /// The network protocol to match. Supported values are: `TCP`, `UDP`, `ICMP`, `ICMPv6`, `AH`, `ESP`, `GRE`, `IPIP` and `ALL`.
        /// </summary>
        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        [Input("userSecurityGroupLists")]
        private InputList<string>? _userSecurityGroupLists;

        /// <summary>
        /// A source (for ingress)/destination (for egress) of the traffic identified by a Security Group.
        /// </summary>
        public InputList<string> UserSecurityGroupLists
        {
            get => _userSecurityGroupLists ?? (_userSecurityGroupLists = new InputList<string>());
            set => _userSecurityGroupLists = value;
        }

        public SecurityGroupRulesIngressGetArgs()
        {
        }
    }
}

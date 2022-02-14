// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Exoscale.Inputs
{

    public sealed class SKSClusterOidcArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The OpenID client ID.
        /// </summary>
        [Input("clientId", required: true)]
        public Input<string> ClientId { get; set; } = null!;

        /// <summary>
        /// An OpenID JWT claim to use as the user's group.
        /// </summary>
        [Input("groupsClaim")]
        public Input<string>? GroupsClaim { get; set; }

        /// <summary>
        /// An OpenID prefix prepended to group claims.
        /// </summary>
        [Input("groupsPrefix")]
        public Input<string>? GroupsPrefix { get; set; }

        /// <summary>
        /// The OpenID provider URL.
        /// </summary>
        [Input("issuerUrl", required: true)]
        public Input<string> IssuerUrl { get; set; } = null!;

        [Input("requiredClaim")]
        private InputMap<string>? _requiredClaim;

        /// <summary>
        /// A map of key/value pairs that describes a required claim in the OpenID Token.
        /// </summary>
        public InputMap<string> RequiredClaim
        {
            get => _requiredClaim ?? (_requiredClaim = new InputMap<string>());
            set => _requiredClaim = value;
        }

        /// <summary>
        /// An OpenID JWT claim to use as the user name.
        /// </summary>
        [Input("usernameClaim")]
        public Input<string>? UsernameClaim { get; set; }

        /// <summary>
        /// An OpenID prefix prepended to username claims.
        /// </summary>
        [Input("usernamePrefix")]
        public Input<string>? UsernamePrefix { get; set; }

        public SKSClusterOidcArgs()
        {
        }
    }
}

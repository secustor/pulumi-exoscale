// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Provides an Exoscale [Elastic IP address][eip-doc] resource. This can be used to create, update and delete Elastic IPs.
 *
 * See [`exoscale.SecondaryIPAddress`][r-secondary_ipaddress] for usage with Compute instances.
 *
 * !> **WARNING:** This resource is deprecated and will be removed in the next major version.
 *
 * ## Import
 *
 * An existing Elastic IP can be imported as a resource by address or IDconsole # By address
 *
 * ```sh
 *  $ pulumi import exoscale:index/iPAddress:IPAddress myip 159.100.251.224
 * ```
 *
 * # By ID
 *
 * ```sh
 *  $ pulumi import exoscale:index/iPAddress:IPAddress myip eb556678-ec59-4be6-8c54-0406ae0f6da6
 * ```
 *
 *  [eip-doc]https://community.exoscale.com/documentation/compute/eip/ [r-secondary_ipaddress]secondary_ipaddress.html [zone]https://www.exoscale.com/datacenters/
 */
export class IPAddress extends pulumi.CustomResource {
    /**
     * Get an existing IPAddress resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: IPAddressState, opts?: pulumi.CustomResourceOptions): IPAddress {
        return new IPAddress(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'exoscale:index/iPAddress:IPAddress';

    /**
     * Returns true if the given object is an instance of IPAddress.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is IPAddress {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === IPAddress.__pulumiType;
    }

    /**
     * The description of the Elastic IP.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * The healthcheck probing interval in seconds (must be between `5` and `300`).
     */
    public readonly healthcheckInterval!: pulumi.Output<number | undefined>;
    /**
     * The healthcheck probing mode (must be `tcp`, `http` or `https`).
     */
    public readonly healthcheckMode!: pulumi.Output<string | undefined>;
    /**
     * The healthcheck probe HTTP request path (must be specified in `http`/`https` modes).
     */
    public readonly healthcheckPath!: pulumi.Output<string | undefined>;
    /**
     * The healthcheck service port to probe (must be between `1` and `65535`).
     */
    public readonly healthcheckPort!: pulumi.Output<number | undefined>;
    /**
     * The number of unsuccessful healthcheck probes before considering the target unhealthy (must be between `1` and `20`).
     */
    public readonly healthcheckStrikesFail!: pulumi.Output<number | undefined>;
    /**
     * The number of successful healthcheck probes before considering the target healthy (must be between `1` and `20`).
     */
    public readonly healthcheckStrikesOk!: pulumi.Output<number | undefined>;
    /**
     * The time in seconds before considering a healthcheck probing failed (must be between `2` and `60`).
     */
    public readonly healthcheckTimeout!: pulumi.Output<number | undefined>;
    /**
     * Disable TLS certificate validation in `https` mode. Note: this parameter can only be changed to `true`, it cannot be reset to `false` later on (requires a resource re-creation).
     */
    public readonly healthcheckTlsSkipVerify!: pulumi.Output<boolean | undefined>;
    /**
     * The healthcheck TLS server name to specify in `https` mode. Note: this parameter can only be changed to a non-empty value, it cannot be reset to its default empty value later on (requires a resource re-creation).
     */
    public readonly healthcheckTlsSni!: pulumi.Output<string | undefined>;
    /**
     * The Elastic IP address.
     */
    public /*out*/ readonly ipAddress!: pulumi.Output<string>;
    /**
     * A reverse DNS record to set for the Elastic IP.
     */
    public readonly reverseDns!: pulumi.Output<string | undefined>;
    /**
     * A dictionary of tags (key/value). To remove all tags, set `tags = {}`.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string}>;
    /**
     * The name of the [zone][zone] to create the Elastic IP into.
     */
    public readonly zone!: pulumi.Output<string>;

    /**
     * Create a IPAddress resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: IPAddressArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: IPAddressArgs | IPAddressState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as IPAddressState | undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["healthcheckInterval"] = state ? state.healthcheckInterval : undefined;
            resourceInputs["healthcheckMode"] = state ? state.healthcheckMode : undefined;
            resourceInputs["healthcheckPath"] = state ? state.healthcheckPath : undefined;
            resourceInputs["healthcheckPort"] = state ? state.healthcheckPort : undefined;
            resourceInputs["healthcheckStrikesFail"] = state ? state.healthcheckStrikesFail : undefined;
            resourceInputs["healthcheckStrikesOk"] = state ? state.healthcheckStrikesOk : undefined;
            resourceInputs["healthcheckTimeout"] = state ? state.healthcheckTimeout : undefined;
            resourceInputs["healthcheckTlsSkipVerify"] = state ? state.healthcheckTlsSkipVerify : undefined;
            resourceInputs["healthcheckTlsSni"] = state ? state.healthcheckTlsSni : undefined;
            resourceInputs["ipAddress"] = state ? state.ipAddress : undefined;
            resourceInputs["reverseDns"] = state ? state.reverseDns : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
            resourceInputs["zone"] = state ? state.zone : undefined;
        } else {
            const args = argsOrState as IPAddressArgs | undefined;
            if ((!args || args.zone === undefined) && !opts.urn) {
                throw new Error("Missing required property 'zone'");
            }
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["healthcheckInterval"] = args ? args.healthcheckInterval : undefined;
            resourceInputs["healthcheckMode"] = args ? args.healthcheckMode : undefined;
            resourceInputs["healthcheckPath"] = args ? args.healthcheckPath : undefined;
            resourceInputs["healthcheckPort"] = args ? args.healthcheckPort : undefined;
            resourceInputs["healthcheckStrikesFail"] = args ? args.healthcheckStrikesFail : undefined;
            resourceInputs["healthcheckStrikesOk"] = args ? args.healthcheckStrikesOk : undefined;
            resourceInputs["healthcheckTimeout"] = args ? args.healthcheckTimeout : undefined;
            resourceInputs["healthcheckTlsSkipVerify"] = args ? args.healthcheckTlsSkipVerify : undefined;
            resourceInputs["healthcheckTlsSni"] = args ? args.healthcheckTlsSni : undefined;
            resourceInputs["reverseDns"] = args ? args.reverseDns : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["zone"] = args ? args.zone : undefined;
            resourceInputs["ipAddress"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(IPAddress.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering IPAddress resources.
 */
export interface IPAddressState {
    /**
     * The description of the Elastic IP.
     */
    description?: pulumi.Input<string>;
    /**
     * The healthcheck probing interval in seconds (must be between `5` and `300`).
     */
    healthcheckInterval?: pulumi.Input<number>;
    /**
     * The healthcheck probing mode (must be `tcp`, `http` or `https`).
     */
    healthcheckMode?: pulumi.Input<string>;
    /**
     * The healthcheck probe HTTP request path (must be specified in `http`/`https` modes).
     */
    healthcheckPath?: pulumi.Input<string>;
    /**
     * The healthcheck service port to probe (must be between `1` and `65535`).
     */
    healthcheckPort?: pulumi.Input<number>;
    /**
     * The number of unsuccessful healthcheck probes before considering the target unhealthy (must be between `1` and `20`).
     */
    healthcheckStrikesFail?: pulumi.Input<number>;
    /**
     * The number of successful healthcheck probes before considering the target healthy (must be between `1` and `20`).
     */
    healthcheckStrikesOk?: pulumi.Input<number>;
    /**
     * The time in seconds before considering a healthcheck probing failed (must be between `2` and `60`).
     */
    healthcheckTimeout?: pulumi.Input<number>;
    /**
     * Disable TLS certificate validation in `https` mode. Note: this parameter can only be changed to `true`, it cannot be reset to `false` later on (requires a resource re-creation).
     */
    healthcheckTlsSkipVerify?: pulumi.Input<boolean>;
    /**
     * The healthcheck TLS server name to specify in `https` mode. Note: this parameter can only be changed to a non-empty value, it cannot be reset to its default empty value later on (requires a resource re-creation).
     */
    healthcheckTlsSni?: pulumi.Input<string>;
    /**
     * The Elastic IP address.
     */
    ipAddress?: pulumi.Input<string>;
    /**
     * A reverse DNS record to set for the Elastic IP.
     */
    reverseDns?: pulumi.Input<string>;
    /**
     * A dictionary of tags (key/value). To remove all tags, set `tags = {}`.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name of the [zone][zone] to create the Elastic IP into.
     */
    zone?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a IPAddress resource.
 */
export interface IPAddressArgs {
    /**
     * The description of the Elastic IP.
     */
    description?: pulumi.Input<string>;
    /**
     * The healthcheck probing interval in seconds (must be between `5` and `300`).
     */
    healthcheckInterval?: pulumi.Input<number>;
    /**
     * The healthcheck probing mode (must be `tcp`, `http` or `https`).
     */
    healthcheckMode?: pulumi.Input<string>;
    /**
     * The healthcheck probe HTTP request path (must be specified in `http`/`https` modes).
     */
    healthcheckPath?: pulumi.Input<string>;
    /**
     * The healthcheck service port to probe (must be between `1` and `65535`).
     */
    healthcheckPort?: pulumi.Input<number>;
    /**
     * The number of unsuccessful healthcheck probes before considering the target unhealthy (must be between `1` and `20`).
     */
    healthcheckStrikesFail?: pulumi.Input<number>;
    /**
     * The number of successful healthcheck probes before considering the target healthy (must be between `1` and `20`).
     */
    healthcheckStrikesOk?: pulumi.Input<number>;
    /**
     * The time in seconds before considering a healthcheck probing failed (must be between `2` and `60`).
     */
    healthcheckTimeout?: pulumi.Input<number>;
    /**
     * Disable TLS certificate validation in `https` mode. Note: this parameter can only be changed to `true`, it cannot be reset to `false` later on (requires a resource re-creation).
     */
    healthcheckTlsSkipVerify?: pulumi.Input<boolean>;
    /**
     * The healthcheck TLS server name to specify in `https` mode. Note: this parameter can only be changed to a non-empty value, it cannot be reset to its default empty value later on (requires a resource re-creation).
     */
    healthcheckTlsSni?: pulumi.Input<string>;
    /**
     * A reverse DNS record to set for the Elastic IP.
     */
    reverseDns?: pulumi.Input<string>;
    /**
     * A dictionary of tags (key/value). To remove all tags, set `tags = {}`.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name of the [zone][zone] to create the Elastic IP into.
     */
    zone: pulumi.Input<string>;
}

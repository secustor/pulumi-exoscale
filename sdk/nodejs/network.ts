// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Provides an Exoscale [Private Network][privnet-doc] resource. This can be used to create, update and delete Private Networks.
 *
 * See [`exoscale.NIC`][r-nic] for usage with Compute instances.
 *
 * !> **WARNING:** This resource is deprecated and will be removed in the next major version.
 *
 * ## Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as exoscale from "@pulumi/exoscale";
 *
 * const unmanaged = new exoscale.Network("unmanaged", {
 *     displayText: "Out-of-band network",
 *     tags: {},
 *     zone: "ch-gva-2",
 * });
 * ```
 *
 * *Managed* Private Network:
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as exoscale from "@pulumi/exoscale";
 *
 * const managed = new exoscale.Network("managed", {
 *     displayText: "Out-of-band network with DHCP",
 *     endIp: "10.0.0.253",
 *     netmask: "255.255.255.0",
 *     startIp: "10.0.0.20",
 *     zone: "ch-gva-2",
 * });
 * ```
 *
 * ## Import
 *
 * An existing Private Network can be imported as a resource by name or IDconsole # By name
 *
 * ```sh
 *  $ pulumi import exoscale:index/network:Network net myprivnet
 * ```
 *
 * # By ID
 *
 * ```sh
 *  $ pulumi import exoscale:index/network:Network net 04fb76a2-6d22-49be-8da7-f2a5a0b902e1
 * ```
 *
 *  [r-nic]nic.html [privnet-doc]https://community.exoscale.com/documentation/compute/private-networks/ [zone]https://www.exoscale.com/datacenters/
 */
export class Network extends pulumi.CustomResource {
    /**
     * Get an existing Network resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: NetworkState, opts?: pulumi.CustomResourceOptions): Network {
        return new Network(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'exoscale:index/network:Network';

    /**
     * Returns true if the given object is an instance of Network.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Network {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Network.__pulumiType;
    }

    /**
     * A free-form text describing the Private Network purpose.
     */
    public readonly displayText!: pulumi.Output<string>;
    /**
     * The last address of the IP range used by the DHCP service. Required for *managed* Private Networks.
     */
    public readonly endIp!: pulumi.Output<string | undefined>;
    /**
     * The name of the Private Network.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The netmask defining the IP network allowed for the static lease (see `exoscale.NIC` resource). Required for *managed* Private Networks.
     */
    public readonly netmask!: pulumi.Output<string | undefined>;
    /**
     * @deprecated This attribute is deprecated, please remove it from your configuration.
     */
    public readonly networkOffering!: pulumi.Output<string | undefined>;
    /**
     * The first address of IP range used by the DHCP service to automatically assign. Required for *managed* Private Networks.
     */
    public readonly startIp!: pulumi.Output<string | undefined>;
    /**
     * A dictionary of tags (key/value). To remove all tags, set `tags = {}`.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string}>;
    /**
     * The name of the [zone][zone] to create the Private Network into.
     */
    public readonly zone!: pulumi.Output<string>;

    /**
     * Create a Network resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: NetworkArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: NetworkArgs | NetworkState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as NetworkState | undefined;
            resourceInputs["displayText"] = state ? state.displayText : undefined;
            resourceInputs["endIp"] = state ? state.endIp : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["netmask"] = state ? state.netmask : undefined;
            resourceInputs["networkOffering"] = state ? state.networkOffering : undefined;
            resourceInputs["startIp"] = state ? state.startIp : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
            resourceInputs["zone"] = state ? state.zone : undefined;
        } else {
            const args = argsOrState as NetworkArgs | undefined;
            if ((!args || args.zone === undefined) && !opts.urn) {
                throw new Error("Missing required property 'zone'");
            }
            resourceInputs["displayText"] = args ? args.displayText : undefined;
            resourceInputs["endIp"] = args ? args.endIp : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["netmask"] = args ? args.netmask : undefined;
            resourceInputs["networkOffering"] = args ? args.networkOffering : undefined;
            resourceInputs["startIp"] = args ? args.startIp : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["zone"] = args ? args.zone : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Network.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Network resources.
 */
export interface NetworkState {
    /**
     * A free-form text describing the Private Network purpose.
     */
    displayText?: pulumi.Input<string>;
    /**
     * The last address of the IP range used by the DHCP service. Required for *managed* Private Networks.
     */
    endIp?: pulumi.Input<string>;
    /**
     * The name of the Private Network.
     */
    name?: pulumi.Input<string>;
    /**
     * The netmask defining the IP network allowed for the static lease (see `exoscale.NIC` resource). Required for *managed* Private Networks.
     */
    netmask?: pulumi.Input<string>;
    /**
     * @deprecated This attribute is deprecated, please remove it from your configuration.
     */
    networkOffering?: pulumi.Input<string>;
    /**
     * The first address of IP range used by the DHCP service to automatically assign. Required for *managed* Private Networks.
     */
    startIp?: pulumi.Input<string>;
    /**
     * A dictionary of tags (key/value). To remove all tags, set `tags = {}`.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name of the [zone][zone] to create the Private Network into.
     */
    zone?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Network resource.
 */
export interface NetworkArgs {
    /**
     * A free-form text describing the Private Network purpose.
     */
    displayText?: pulumi.Input<string>;
    /**
     * The last address of the IP range used by the DHCP service. Required for *managed* Private Networks.
     */
    endIp?: pulumi.Input<string>;
    /**
     * The name of the Private Network.
     */
    name?: pulumi.Input<string>;
    /**
     * The netmask defining the IP network allowed for the static lease (see `exoscale.NIC` resource). Required for *managed* Private Networks.
     */
    netmask?: pulumi.Input<string>;
    /**
     * @deprecated This attribute is deprecated, please remove it from your configuration.
     */
    networkOffering?: pulumi.Input<string>;
    /**
     * The first address of IP range used by the DHCP service to automatically assign. Required for *managed* Private Networks.
     */
    startIp?: pulumi.Input<string>;
    /**
     * A dictionary of tags (key/value). To remove all tags, set `tags = {}`.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name of the [zone][zone] to create the Private Network into.
     */
    zone: pulumi.Input<string>;
}

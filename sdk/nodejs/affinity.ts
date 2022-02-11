// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Provides an Exoscale [Anti-Affinity Group][aag-doc] resource. This can be used to create and delete Anti-Affinity Groups.
 *
 * !> **WARNING:** This resource is deprecated and will be removed in the next major version.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as exoscale from "@pulumi/exoscale";
 *
 * const cluster = new exoscale.Affinity("cluster", {
 *     description: "HA Cluster",
 *     type: "host anti-affinity",
 * });
 * ```
 *
 * ## Import
 *
 * An existing Anti-Affinity Group can be imported as a resource by name or IDconsole # By name
 *
 * ```sh
 *  $ pulumi import exoscale:index/affinity:Affinity mygroup mygroup
 * ```
 *
 * # By ID
 *
 * ```sh
 *  $ pulumi import exoscale:index/affinity:Affinity mygroup eb556678-ec59-4be6-8c54-0406ae0f6da6
 * ```
 *
 *  [aag-doc]https://community.exoscale.com/documentation/compute/anti-affinity-groups/
 */
export class Affinity extends pulumi.CustomResource {
    /**
     * Get an existing Affinity resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AffinityState, opts?: pulumi.CustomResourceOptions): Affinity {
        return new Affinity(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'exoscale:index/affinity:Affinity';

    /**
     * Returns true if the given object is an instance of Affinity.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Affinity {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Affinity.__pulumiType;
    }

    /**
     * A free-form text describing the Anti-Affinity Group purpose.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * The name of the Anti-Affinity Group.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The type of the Anti-Affinity Group (`host anti-affinity` is the only supported value).
     */
    public readonly type!: pulumi.Output<string | undefined>;
    /**
     * The IDs of the Compute instance resources member of the Anti-Affinity Group.
     */
    public /*out*/ readonly virtualMachineIds!: pulumi.Output<string[]>;

    /**
     * Create a Affinity resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: AffinityArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AffinityArgs | AffinityState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as AffinityState | undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["type"] = state ? state.type : undefined;
            resourceInputs["virtualMachineIds"] = state ? state.virtualMachineIds : undefined;
        } else {
            const args = argsOrState as AffinityArgs | undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["type"] = args ? args.type : undefined;
            resourceInputs["virtualMachineIds"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Affinity.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Affinity resources.
 */
export interface AffinityState {
    /**
     * A free-form text describing the Anti-Affinity Group purpose.
     */
    description?: pulumi.Input<string>;
    /**
     * The name of the Anti-Affinity Group.
     */
    name?: pulumi.Input<string>;
    /**
     * The type of the Anti-Affinity Group (`host anti-affinity` is the only supported value).
     */
    type?: pulumi.Input<string>;
    /**
     * The IDs of the Compute instance resources member of the Anti-Affinity Group.
     */
    virtualMachineIds?: pulumi.Input<pulumi.Input<string>[]>;
}

/**
 * The set of arguments for constructing a Affinity resource.
 */
export interface AffinityArgs {
    /**
     * A free-form text describing the Anti-Affinity Group purpose.
     */
    description?: pulumi.Input<string>;
    /**
     * The name of the Anti-Affinity Group.
     */
    name?: pulumi.Input<string>;
    /**
     * The type of the Anti-Affinity Group (`host anti-affinity` is the only supported value).
     */
    type?: pulumi.Input<string>;
}
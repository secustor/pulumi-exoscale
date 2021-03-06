// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

/**
 * Provides an Exoscale [Elastic IP address][eip-doc] resource. This can be used to create, update and delete Elastic IPs.
 *
 * ## Import
 *
 * An existing Elastic IP can be imported as a resource by specifying `ID@ZONE`console
 *
 * ```sh
 *  $ pulumi import exoscale:index/elasticIP:ElasticIP web eb556678-ec59-4be6-8c54-0406ae0f6da6@ch-dk-2
 * ```
 *
 *  [eip-doc]https://community.exoscale.com/documentation/compute/eip/ [zone]https://www.exoscale.com/datacenters/
 */
export class ElasticIP extends pulumi.CustomResource {
    /**
     * Get an existing ElasticIP resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ElasticIPState, opts?: pulumi.CustomResourceOptions): ElasticIP {
        return new ElasticIP(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'exoscale:index/elasticIP:ElasticIP';

    /**
     * Returns true if the given object is an instance of ElasticIP.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ElasticIP {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ElasticIP.__pulumiType;
    }

    /**
     * The description of the Elastic IP.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * A health checking configuration for managed Elastic IPs. Structure is documented below.
     */
    public readonly healthcheck!: pulumi.Output<outputs.ElasticIPHealthcheck>;
    /**
     * The Elastic IP address.
     */
    public /*out*/ readonly ipAddress!: pulumi.Output<string>;
    /**
     * The name of the [zone][zone] to create the Elastic IP into.
     */
    public readonly zone!: pulumi.Output<string>;

    /**
     * Create a ElasticIP resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ElasticIPArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ElasticIPArgs | ElasticIPState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ElasticIPState | undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["healthcheck"] = state ? state.healthcheck : undefined;
            resourceInputs["ipAddress"] = state ? state.ipAddress : undefined;
            resourceInputs["zone"] = state ? state.zone : undefined;
        } else {
            const args = argsOrState as ElasticIPArgs | undefined;
            if ((!args || args.zone === undefined) && !opts.urn) {
                throw new Error("Missing required property 'zone'");
            }
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["healthcheck"] = args ? args.healthcheck : undefined;
            resourceInputs["zone"] = args ? args.zone : undefined;
            resourceInputs["ipAddress"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ElasticIP.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ElasticIP resources.
 */
export interface ElasticIPState {
    /**
     * The description of the Elastic IP.
     */
    description?: pulumi.Input<string>;
    /**
     * A health checking configuration for managed Elastic IPs. Structure is documented below.
     */
    healthcheck?: pulumi.Input<inputs.ElasticIPHealthcheck>;
    /**
     * The Elastic IP address.
     */
    ipAddress?: pulumi.Input<string>;
    /**
     * The name of the [zone][zone] to create the Elastic IP into.
     */
    zone?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ElasticIP resource.
 */
export interface ElasticIPArgs {
    /**
     * The description of the Elastic IP.
     */
    description?: pulumi.Input<string>;
    /**
     * A health checking configuration for managed Elastic IPs. Structure is documented below.
     */
    healthcheck?: pulumi.Input<inputs.ElasticIPHealthcheck>;
    /**
     * The name of the [zone][zone] to create the Elastic IP into.
     */
    zone: pulumi.Input<string>;
}

// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Provides information on an [Anti-Affinity Group][aag-doc] for use in other resources such as a [`exoscale.Compute`][r-compute] resource.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as exoscale from "@pulumi/exoscale";
 *
 * const zone = "ch-gva-2";
 * const web = exoscale.getAntiAffinityGroup({
 *     name: "web",
 * });
 * const ubuntu = exoscale.getComputeTemplate({
 *     zone: zone,
 *     name: "Linux Ubuntu 20.04 LTS 64-bit",
 * });
 * const my_server = new exoscale.ComputeInstance("my-server", {
 *     zone: zone,
 *     type: "standard.medium",
 *     templateId: ubuntu.then(ubuntu => ubuntu.id),
 *     diskSize: 20,
 *     antiAffinityGroupIds: [web.then(web => web.id)],
 * });
 * ```
 */
export function getAntiAffinityGroup(args?: GetAntiAffinityGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetAntiAffinityGroupResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("exoscale:index/getAntiAffinityGroup:getAntiAffinityGroup", {
        "id": args.id,
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getAntiAffinityGroup.
 */
export interface GetAntiAffinityGroupArgs {
    /**
     * The ID of the Anti-Affinity Group (conflicts with `name`).
     */
    id?: string;
    /**
     * The name of the Anti-Affinity Group (conflicts with `id`).
     */
    name?: string;
}

/**
 * A collection of values returned by getAntiAffinityGroup.
 */
export interface GetAntiAffinityGroupResult {
    readonly id?: string;
    /**
     * A list of Compute instance IDs belonging to the Anti-Affinity Group.
     */
    readonly instances: string[];
    readonly name?: string;
}

export function getAntiAffinityGroupOutput(args?: GetAntiAffinityGroupOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAntiAffinityGroupResult> {
    return pulumi.output(args).apply(a => getAntiAffinityGroup(a, opts))
}

/**
 * A collection of arguments for invoking getAntiAffinityGroup.
 */
export interface GetAntiAffinityGroupOutputArgs {
    /**
     * The ID of the Anti-Affinity Group (conflicts with `name`).
     */
    id?: pulumi.Input<string>;
    /**
     * The name of the Anti-Affinity Group (conflicts with `id`).
     */
    name?: pulumi.Input<string>;
}

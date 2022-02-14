// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Provides information on an [Anti-Affinity Group][aag-doc] for use in other resources such as a [`exoscale.Compute`][r-compute] resource.
 *
 * !> **WARNING:** This data source is deprecated and will be removed in the next major version.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as exoscale from "@pulumi/exoscale";
 *
 * const zone = "ch-gva-2";
 * const web = exoscale.getAffinity({
 *     name: "web",
 * });
 * const ubuntu = exoscale.getComputeTemplate({
 *     zone: zone,
 *     name: "Linux Ubuntu 20.04 LTS 64-bit",
 * });
 * const myServer = new exoscale.Compute("myServer", {
 *     zone: zone,
 *     templateId: ubuntu.then(ubuntu => ubuntu.id),
 *     diskSize: 20,
 *     affinityGroupIds: [web.then(web => web.id)],
 * });
 * ```
 */
export function getAffinity(args?: GetAffinityArgs, opts?: pulumi.InvokeOptions): Promise<GetAffinityResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("exoscale:index/getAffinity:getAffinity", {
        "id": args.id,
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getAffinity.
 */
export interface GetAffinityArgs {
    /**
     * The ID of the Anti-Affinity Group (conflicts with `name`)
     */
    id?: string;
    /**
     * The name of the Anti-Affinity Group (conflicts with `id`)
     */
    name?: string;
}

/**
 * A collection of values returned by getAffinity.
 */
export interface GetAffinityResult {
    readonly id?: string;
    readonly name?: string;
}

export function getAffinityOutput(args?: GetAffinityOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAffinityResult> {
    return pulumi.output(args).apply(a => getAffinity(a, opts))
}

/**
 * A collection of arguments for invoking getAffinity.
 */
export interface GetAffinityOutputArgs {
    /**
     * The ID of the Anti-Affinity Group (conflicts with `name`)
     */
    id?: pulumi.Input<string>;
    /**
     * The name of the Anti-Affinity Group (conflicts with `id`)
     */
    name?: pulumi.Input<string>;
}

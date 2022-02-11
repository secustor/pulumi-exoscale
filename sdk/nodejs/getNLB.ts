// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Provides information on a [Network Load Balancer][nlb-doc] (NLB) instance for use in other resources such as a [`exoscale.NLBService`][r-nlb_service] resource.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as exoscale from "@pulumi/exoscale";
 *
 * const prod = exoscale.getNLB({
 *     zone: "ch-gva-2",
 *     name: "prod",
 * });
 * export const nlbProdIpAddress = prod.then(prod => prod.ipAddress);
 * ```
 */
export function getNLB(args: GetNLBArgs, opts?: pulumi.InvokeOptions): Promise<GetNLBResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("exoscale:index/getNLB:getNLB", {
        "id": args.id,
        "name": args.name,
        "zone": args.zone,
    }, opts);
}

/**
 * A collection of arguments for invoking getNLB.
 */
export interface GetNLBArgs {
    /**
     * The ID of the NLB (conflicts with `name`).
     */
    id?: string;
    /**
     * The name of NLB (conflicts with `id`).
     */
    name?: string;
    /**
     * The [zone][zone] of the NLB.
     */
    zone: string;
}

/**
 * A collection of values returned by getNLB.
 */
export interface GetNLBResult {
    /**
     * The creation date of the NLB.
     */
    readonly createdAt: string;
    /**
     * The description of the NLB.
     */
    readonly description: string;
    readonly id?: string;
    /**
     * The public IP address of the NLB.
     */
    readonly ipAddress: string;
    readonly name?: string;
    /**
     * The current state of the NLB.
     */
    readonly state: string;
    readonly zone: string;
}

export function getNLBOutput(args: GetNLBOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetNLBResult> {
    return pulumi.output(args).apply(a => getNLB(a, opts))
}

/**
 * A collection of arguments for invoking getNLB.
 */
export interface GetNLBOutputArgs {
    /**
     * The ID of the NLB (conflicts with `name`).
     */
    id?: pulumi.Input<string>;
    /**
     * The name of NLB (conflicts with `id`).
     */
    name?: pulumi.Input<string>;
    /**
     * The [zone][zone] of the NLB.
     */
    zone: pulumi.Input<string>;
}
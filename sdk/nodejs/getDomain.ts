// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Provides information on a domain name hosted on [Exoscale DNS][exo-dns].
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as exoscale from "@pulumi/exoscale";
 *
 * const my_company_com = pulumi.output(exoscale.getDomain({
 *     name: "my-company.com",
 * }));
 * ```
 */
export function getDomain(args: GetDomainArgs, opts?: pulumi.InvokeOptions): Promise<GetDomainResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("exoscale:index/getDomain:getDomain", {
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getDomain.
 */
export interface GetDomainArgs {
    /**
     * The name of the domain.
     */
    name: string;
}

/**
 * A collection of values returned by getDomain.
 */
export interface GetDomainResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly name: string;
}

export function getDomainOutput(args: GetDomainOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDomainResult> {
    return pulumi.output(args).apply(a => getDomain(a, opts))
}

/**
 * A collection of arguments for invoking getDomain.
 */
export interface GetDomainOutputArgs {
    /**
     * The name of the domain.
     */
    name: pulumi.Input<string>;
}
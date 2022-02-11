// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Provides an Exoscale [Compute instance][compute-doc] resource. This can be used to create, modify, and delete Compute instances.
 *
 * !> **WARNING:** This resource is deprecated and will be removed in the next major version.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as exoscale from "@pulumi/exoscale";
 *
 * const ubuntu = exoscale.getComputeTemplate({
 *     zone: "ch-gva-2",
 *     name: "Linux Ubuntu 18.04 LTS 64-bit",
 * });
 * const mymachine = new exoscale.Compute("mymachine", {
 *     zone: "ch-gva-2",
 *     displayName: "mymachine",
 *     templateId: ubuntu.then(ubuntu => ubuntu.id),
 *     size: "Medium",
 *     diskSize: 10,
 *     keyPair: "me@mymachine",
 *     state: "Running",
 *     reverseDns: "mymachine.com.",
 *     affinityGroups: [],
 *     securityGroups: ["default"],
 *     ip6: false,
 *     userData: `#cloud-config
 * manage_etc_hosts: localhost
 * `,
 *     tags: {
 *         production: "true",
 *     },
 *     timeouts: [{
 *         create: "60m",
 *         "delete": "2h",
 *     }],
 * });
 * ```
 *
 * ## Import
 *
 * An existing Compute instance can be imported as a resource by name or IDconsole # By name
 *
 * ```sh
 *  $ pulumi import exoscale:index/compute:Compute vm1 vm1
 * ```
 *
 * # By ID
 *
 * ```sh
 *  $ pulumi import exoscale:index/compute:Compute vm1 eb556678-ec59-4be6-8c54-0406ae0f6da6
 * ```
 *
 *  [cloudinit]http://cloudinit.readthedocs.io/en/latest/ [compute-doc]https://community.exoscale.com/documentation/compute/ [d-compute_template]../d/compute_template.html [r-affinity]affinity.html [r-nic]nic.html [r-secondary_ipaddress]secondary_ipaddress.html [r-security_group]security_group.html [remote-exec]https://www.terraform.io/docs/provisioners/remote-exec.html [size]https://www.exoscale.com/pricing/#/compute/ [sshkeypair-doc]https://community.exoscale.com/documentation/compute/ssh-keypairs/ [template]https://www.exoscale.com/templates/ [zone]https://www.exoscale.com/datacenters/
 */
export class Compute extends pulumi.CustomResource {
    /**
     * Get an existing Compute resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ComputeState, opts?: pulumi.CustomResourceOptions): Compute {
        return new Compute(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'exoscale:index/compute:Compute';

    /**
     * Returns true if the given object is an instance of Compute.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Compute {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Compute.__pulumiType;
    }

    /**
     * A list of [Anti-Affinity Group][r-affinity] IDs (at creation time only; conflicts with `affinityGroups`).
     */
    public readonly affinityGroupIds!: pulumi.Output<string[]>;
    /**
     * A list of [Anti-Affinity Group][r-affinity] names (at creation time only; conflicts with `affinityGroupIds`).
     */
    public readonly affinityGroups!: pulumi.Output<string[]>;
    /**
     * The Compute instance root disk size in GiB (at least `10`).
     */
    public readonly diskSize!: pulumi.Output<number>;
    /**
     * The displayed name of the Compute instance. Note: if the `hostname` attribute is not set, this attribute is also used to set the OS' *hostname* during creation, so the value must contain only alphanumeric and hyphen ("-") characters; it can be changed to any character during a later update. If neither `displayName` or `hostname` attributes are set, a random value will be generated automatically server-side.
     */
    public readonly displayName!: pulumi.Output<string>;
    public /*out*/ readonly gateway!: pulumi.Output<string>;
    /**
     * The Compute instance hostname, must contain only alphanumeric and hyphen ("-") characters. If neither `displayName` or `hostname` attributes are set, a random value will be generated automatically server-side. Note: updating this attribute's value requires to reboot the instance.
     */
    public readonly hostname!: pulumi.Output<string>;
    /**
     * Boolean controlling if IPv4 is enabled (only supported value is `true`).
     */
    public readonly ip4!: pulumi.Output<boolean | undefined>;
    /**
     * Boolean controlling if IPv6 is enabled.
     */
    public readonly ip6!: pulumi.Output<boolean | undefined>;
    /**
     * The IPv6 address of the Compute instance main network interface.
     */
    public /*out*/ readonly ip6Address!: pulumi.Output<string>;
    public /*out*/ readonly ip6Cidr!: pulumi.Output<string>;
    /**
     * The IP address of the Compute instance main network interface.
     */
    public /*out*/ readonly ipAddress!: pulumi.Output<string>;
    /**
     * The name of the [SSH key pair][sshkeypair-doc] to be installed.
     */
    public readonly keyPair!: pulumi.Output<string | undefined>;
    /**
     * The keyboard layout configuration (at creation time only). Supported values are: `de`, `de-ch`, `es`, `fi`, `fr`, `fr-be`, `fr-ch`, `is`, `it`, `jp`, `nl-be`, `no`, `pt`, `uk`, `us`.
     */
    public readonly keyboard!: pulumi.Output<string | undefined>;
    /**
     * **Deprecated** The Compute instance *hostname*. Use the `hostname` attribute instead.
     *
     * @deprecated use `hostname` attribute instead
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The initial Compute instance password and/or encrypted password.
     */
    public /*out*/ readonly password!: pulumi.Output<string>;
    /**
     * The reverse DNS record of the Compute instance (must end with a `.`, e.g: `my-server.example.net.`).
     */
    public readonly reverseDns!: pulumi.Output<string | undefined>;
    /**
     * A list of [Security Group][r-security_group] IDs (conflicts with `securityGroups`).
     */
    public readonly securityGroupIds!: pulumi.Output<string[]>;
    /**
     * A list of [Security Group][r-security_group] names (conflicts with `securityGroupIds`).
     */
    public readonly securityGroups!: pulumi.Output<string[]>;
    /**
     * The Compute instance [size][size], e.g. `Tiny`, `Small`, `Medium`, `Large` etc.
     */
    public readonly size!: pulumi.Output<string | undefined>;
    /**
     * The state of the Compute instance, e.g. `Running` or `Stopped`
     */
    public readonly state!: pulumi.Output<string>;
    /**
     * A dictionary of tags (key/value). To remove all tags, set `tags = {}`.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string}>;
    /**
     * The name of the Compute instance [template][template]. Only *featured* templates are available, if you want to reference *custom templates* use the `templateId` attribute instead.
     */
    public readonly template!: pulumi.Output<string>;
    /**
     * The ID of the Compute instance [template][template]. Usage of the [`computeTemplate`][d-compute_template] data source is recommended.
     */
    public readonly templateId!: pulumi.Output<string>;
    /**
     * A [cloud-init][cloudinit] configuration. Whenever possible don't base64-encode neither gzip it yourself, as this will be automatically taken care of on your behalf by the provider.
     */
    public readonly userData!: pulumi.Output<string | undefined>;
    /**
     * was the cloud-init configuration base64 encoded
     */
    public /*out*/ readonly userDataBase64!: pulumi.Output<boolean>;
    /**
     * The user to use to connect to the Compute instance with SSH. If you've referenced a *custom template* in the resource, use the [`computeTemplate`][d-compute_template] data source `username` attribute instead.
     *
     * @deprecated broken, use `compute_template` data source `username` attribute
     */
    public /*out*/ readonly username!: pulumi.Output<string>;
    /**
     * The name of the [zone][zone] to deploy the Compute instance into.
     */
    public readonly zone!: pulumi.Output<string>;

    /**
     * Create a Compute resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ComputeArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ComputeArgs | ComputeState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ComputeState | undefined;
            resourceInputs["affinityGroupIds"] = state ? state.affinityGroupIds : undefined;
            resourceInputs["affinityGroups"] = state ? state.affinityGroups : undefined;
            resourceInputs["diskSize"] = state ? state.diskSize : undefined;
            resourceInputs["displayName"] = state ? state.displayName : undefined;
            resourceInputs["gateway"] = state ? state.gateway : undefined;
            resourceInputs["hostname"] = state ? state.hostname : undefined;
            resourceInputs["ip4"] = state ? state.ip4 : undefined;
            resourceInputs["ip6"] = state ? state.ip6 : undefined;
            resourceInputs["ip6Address"] = state ? state.ip6Address : undefined;
            resourceInputs["ip6Cidr"] = state ? state.ip6Cidr : undefined;
            resourceInputs["ipAddress"] = state ? state.ipAddress : undefined;
            resourceInputs["keyPair"] = state ? state.keyPair : undefined;
            resourceInputs["keyboard"] = state ? state.keyboard : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["password"] = state ? state.password : undefined;
            resourceInputs["reverseDns"] = state ? state.reverseDns : undefined;
            resourceInputs["securityGroupIds"] = state ? state.securityGroupIds : undefined;
            resourceInputs["securityGroups"] = state ? state.securityGroups : undefined;
            resourceInputs["size"] = state ? state.size : undefined;
            resourceInputs["state"] = state ? state.state : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
            resourceInputs["template"] = state ? state.template : undefined;
            resourceInputs["templateId"] = state ? state.templateId : undefined;
            resourceInputs["userData"] = state ? state.userData : undefined;
            resourceInputs["userDataBase64"] = state ? state.userDataBase64 : undefined;
            resourceInputs["username"] = state ? state.username : undefined;
            resourceInputs["zone"] = state ? state.zone : undefined;
        } else {
            const args = argsOrState as ComputeArgs | undefined;
            if ((!args || args.diskSize === undefined) && !opts.urn) {
                throw new Error("Missing required property 'diskSize'");
            }
            if ((!args || args.zone === undefined) && !opts.urn) {
                throw new Error("Missing required property 'zone'");
            }
            resourceInputs["affinityGroupIds"] = args ? args.affinityGroupIds : undefined;
            resourceInputs["affinityGroups"] = args ? args.affinityGroups : undefined;
            resourceInputs["diskSize"] = args ? args.diskSize : undefined;
            resourceInputs["displayName"] = args ? args.displayName : undefined;
            resourceInputs["hostname"] = args ? args.hostname : undefined;
            resourceInputs["ip4"] = args ? args.ip4 : undefined;
            resourceInputs["ip6"] = args ? args.ip6 : undefined;
            resourceInputs["keyPair"] = args ? args.keyPair : undefined;
            resourceInputs["keyboard"] = args ? args.keyboard : undefined;
            resourceInputs["reverseDns"] = args ? args.reverseDns : undefined;
            resourceInputs["securityGroupIds"] = args ? args.securityGroupIds : undefined;
            resourceInputs["securityGroups"] = args ? args.securityGroups : undefined;
            resourceInputs["size"] = args ? args.size : undefined;
            resourceInputs["state"] = args ? args.state : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["template"] = args ? args.template : undefined;
            resourceInputs["templateId"] = args ? args.templateId : undefined;
            resourceInputs["userData"] = args ? args.userData : undefined;
            resourceInputs["zone"] = args ? args.zone : undefined;
            resourceInputs["gateway"] = undefined /*out*/;
            resourceInputs["ip6Address"] = undefined /*out*/;
            resourceInputs["ip6Cidr"] = undefined /*out*/;
            resourceInputs["ipAddress"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["password"] = undefined /*out*/;
            resourceInputs["userDataBase64"] = undefined /*out*/;
            resourceInputs["username"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Compute.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Compute resources.
 */
export interface ComputeState {
    /**
     * A list of [Anti-Affinity Group][r-affinity] IDs (at creation time only; conflicts with `affinityGroups`).
     */
    affinityGroupIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A list of [Anti-Affinity Group][r-affinity] names (at creation time only; conflicts with `affinityGroupIds`).
     */
    affinityGroups?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The Compute instance root disk size in GiB (at least `10`).
     */
    diskSize?: pulumi.Input<number>;
    /**
     * The displayed name of the Compute instance. Note: if the `hostname` attribute is not set, this attribute is also used to set the OS' *hostname* during creation, so the value must contain only alphanumeric and hyphen ("-") characters; it can be changed to any character during a later update. If neither `displayName` or `hostname` attributes are set, a random value will be generated automatically server-side.
     */
    displayName?: pulumi.Input<string>;
    gateway?: pulumi.Input<string>;
    /**
     * The Compute instance hostname, must contain only alphanumeric and hyphen ("-") characters. If neither `displayName` or `hostname` attributes are set, a random value will be generated automatically server-side. Note: updating this attribute's value requires to reboot the instance.
     */
    hostname?: pulumi.Input<string>;
    /**
     * Boolean controlling if IPv4 is enabled (only supported value is `true`).
     */
    ip4?: pulumi.Input<boolean>;
    /**
     * Boolean controlling if IPv6 is enabled.
     */
    ip6?: pulumi.Input<boolean>;
    /**
     * The IPv6 address of the Compute instance main network interface.
     */
    ip6Address?: pulumi.Input<string>;
    ip6Cidr?: pulumi.Input<string>;
    /**
     * The IP address of the Compute instance main network interface.
     */
    ipAddress?: pulumi.Input<string>;
    /**
     * The name of the [SSH key pair][sshkeypair-doc] to be installed.
     */
    keyPair?: pulumi.Input<string>;
    /**
     * The keyboard layout configuration (at creation time only). Supported values are: `de`, `de-ch`, `es`, `fi`, `fr`, `fr-be`, `fr-ch`, `is`, `it`, `jp`, `nl-be`, `no`, `pt`, `uk`, `us`.
     */
    keyboard?: pulumi.Input<string>;
    /**
     * **Deprecated** The Compute instance *hostname*. Use the `hostname` attribute instead.
     *
     * @deprecated use `hostname` attribute instead
     */
    name?: pulumi.Input<string>;
    /**
     * The initial Compute instance password and/or encrypted password.
     */
    password?: pulumi.Input<string>;
    /**
     * The reverse DNS record of the Compute instance (must end with a `.`, e.g: `my-server.example.net.`).
     */
    reverseDns?: pulumi.Input<string>;
    /**
     * A list of [Security Group][r-security_group] IDs (conflicts with `securityGroups`).
     */
    securityGroupIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A list of [Security Group][r-security_group] names (conflicts with `securityGroupIds`).
     */
    securityGroups?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The Compute instance [size][size], e.g. `Tiny`, `Small`, `Medium`, `Large` etc.
     */
    size?: pulumi.Input<string>;
    /**
     * The state of the Compute instance, e.g. `Running` or `Stopped`
     */
    state?: pulumi.Input<string>;
    /**
     * A dictionary of tags (key/value). To remove all tags, set `tags = {}`.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name of the Compute instance [template][template]. Only *featured* templates are available, if you want to reference *custom templates* use the `templateId` attribute instead.
     */
    template?: pulumi.Input<string>;
    /**
     * The ID of the Compute instance [template][template]. Usage of the [`computeTemplate`][d-compute_template] data source is recommended.
     */
    templateId?: pulumi.Input<string>;
    /**
     * A [cloud-init][cloudinit] configuration. Whenever possible don't base64-encode neither gzip it yourself, as this will be automatically taken care of on your behalf by the provider.
     */
    userData?: pulumi.Input<string>;
    /**
     * was the cloud-init configuration base64 encoded
     */
    userDataBase64?: pulumi.Input<boolean>;
    /**
     * The user to use to connect to the Compute instance with SSH. If you've referenced a *custom template* in the resource, use the [`computeTemplate`][d-compute_template] data source `username` attribute instead.
     *
     * @deprecated broken, use `compute_template` data source `username` attribute
     */
    username?: pulumi.Input<string>;
    /**
     * The name of the [zone][zone] to deploy the Compute instance into.
     */
    zone?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Compute resource.
 */
export interface ComputeArgs {
    /**
     * A list of [Anti-Affinity Group][r-affinity] IDs (at creation time only; conflicts with `affinityGroups`).
     */
    affinityGroupIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A list of [Anti-Affinity Group][r-affinity] names (at creation time only; conflicts with `affinityGroupIds`).
     */
    affinityGroups?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The Compute instance root disk size in GiB (at least `10`).
     */
    diskSize: pulumi.Input<number>;
    /**
     * The displayed name of the Compute instance. Note: if the `hostname` attribute is not set, this attribute is also used to set the OS' *hostname* during creation, so the value must contain only alphanumeric and hyphen ("-") characters; it can be changed to any character during a later update. If neither `displayName` or `hostname` attributes are set, a random value will be generated automatically server-side.
     */
    displayName?: pulumi.Input<string>;
    /**
     * The Compute instance hostname, must contain only alphanumeric and hyphen ("-") characters. If neither `displayName` or `hostname` attributes are set, a random value will be generated automatically server-side. Note: updating this attribute's value requires to reboot the instance.
     */
    hostname?: pulumi.Input<string>;
    /**
     * Boolean controlling if IPv4 is enabled (only supported value is `true`).
     */
    ip4?: pulumi.Input<boolean>;
    /**
     * Boolean controlling if IPv6 is enabled.
     */
    ip6?: pulumi.Input<boolean>;
    /**
     * The name of the [SSH key pair][sshkeypair-doc] to be installed.
     */
    keyPair?: pulumi.Input<string>;
    /**
     * The keyboard layout configuration (at creation time only). Supported values are: `de`, `de-ch`, `es`, `fi`, `fr`, `fr-be`, `fr-ch`, `is`, `it`, `jp`, `nl-be`, `no`, `pt`, `uk`, `us`.
     */
    keyboard?: pulumi.Input<string>;
    /**
     * The reverse DNS record of the Compute instance (must end with a `.`, e.g: `my-server.example.net.`).
     */
    reverseDns?: pulumi.Input<string>;
    /**
     * A list of [Security Group][r-security_group] IDs (conflicts with `securityGroups`).
     */
    securityGroupIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A list of [Security Group][r-security_group] names (conflicts with `securityGroupIds`).
     */
    securityGroups?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The Compute instance [size][size], e.g. `Tiny`, `Small`, `Medium`, `Large` etc.
     */
    size?: pulumi.Input<string>;
    /**
     * The state of the Compute instance, e.g. `Running` or `Stopped`
     */
    state?: pulumi.Input<string>;
    /**
     * A dictionary of tags (key/value). To remove all tags, set `tags = {}`.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name of the Compute instance [template][template]. Only *featured* templates are available, if you want to reference *custom templates* use the `templateId` attribute instead.
     */
    template?: pulumi.Input<string>;
    /**
     * The ID of the Compute instance [template][template]. Usage of the [`computeTemplate`][d-compute_template] data source is recommended.
     */
    templateId?: pulumi.Input<string>;
    /**
     * A [cloud-init][cloudinit] configuration. Whenever possible don't base64-encode neither gzip it yourself, as this will be automatically taken care of on your behalf by the provider.
     */
    userData?: pulumi.Input<string>;
    /**
     * The name of the [zone][zone] to deploy the Compute instance into.
     */
    zone: pulumi.Input<string>;
}
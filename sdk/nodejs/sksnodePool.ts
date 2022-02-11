// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Provides an Exoscale [SKS][sks-doc] Nodepool resource. This can be used to create, modify, and delete SKS Nodepools.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as exoscale from "@pulumi/exoscale";
 *
 * const zone = "de-fra-1";
 * const sksSecurityGroup = new exoscale.SecurityGroup("sksSecurityGroup", {});
 * const sksSecurityGroupRules = new exoscale.SecurityGroupRules("sksSecurityGroupRules", {
 *     securityGroup: sksSecurityGroup.name,
 *     ingresses: [
 *         {
 *             description: "Calico traffic",
 *             protocol: "UDP",
 *             ports: ["4789"],
 *             userSecurityGroupLists: [sksSecurityGroup.name],
 *         },
 *         {
 *             description: "Nodes logs/exec",
 *             protocol: "TCP",
 *             ports: ["10250"],
 *             cidrLists: [
 *                 "0.0.0.0/0",
 *                 "::/0",
 *             ],
 *         },
 *         {
 *             description: "NodePort services",
 *             protocol: "TCP",
 *             cidrLists: [
 *                 "0.0.0.0/0",
 *                 "::/0",
 *             ],
 *             ports: ["30000-32767"],
 *         },
 *     ],
 * });
 * const prod = new exoscale.SKSCluster("prod", {
 *     zone: zone,
 *     version: "1.20.3",
 * });
 * const ci_builders = new exoscale.SKSNodePool("ci-builders", {
 *     zone: zone,
 *     clusterId: prod.id,
 *     instanceType: "standard.medium",
 *     size: 3,
 *     securityGroupIds: [sksSecurityGroup.id],
 *     labels: {
 *         role: "ci-builders",
 *     },
 *     taints: {
 *         ci: "ci:NoSchedule",
 *     },
 * });
 * ```
 *
 * ## Import
 *
 * An existing SKS Nodepool can be imported as a resource by `<CLUSTER-ID>/<NODEPOOL-ID>@<ZONE>`console
 *
 * ```sh
 *  $ pulumi import exoscale:index/sKSNodePool:SKSNodePool ci-builders eb556678-ec59-4be6-8c54-0406ae0f6da6/8c08b92a-e673-47c7-866e-dc009f620a82@de-fra-1
 * ```
 *
 *  [k8s-taints]https://kubernetes.io/docs/concepts/scheduling-eviction/taint-and-toleration/ [r-sks_cluster]sks_cluster.html [sks-doc]https://community.exoscale.com/documentation/sks/ [type]https://www.exoscale.com/pricing/#/compute/ [zone]https://www.exoscale.com/datacenters/
 */
export class SKSNodePool extends pulumi.CustomResource {
    /**
     * Get an existing SKSNodePool resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SKSNodePoolState, opts?: pulumi.CustomResourceOptions): SKSNodePool {
        return new SKSNodePool(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'exoscale:index/sKSNodePool:SKSNodePool';

    /**
     * Returns true if the given object is an instance of SKSNodePool.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SKSNodePool {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SKSNodePool.__pulumiType;
    }

    /**
     * The list of Anti-Affinity Groups (IDs) the Compute instances managed by the SKS Nodepool are member of.
     */
    public readonly antiAffinityGroupIds!: pulumi.Output<string[] | undefined>;
    /**
     * The ID of the parent SKS cluster.
     */
    public readonly clusterId!: pulumi.Output<string>;
    /**
     * The creation date of the SKS Nodepool.
     */
    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    /**
     * A Deploy Target ID to deploy managed Compute instances to.
     */
    public readonly deployTargetId!: pulumi.Output<string | undefined>;
    /**
     * The description of the SKS Nodepool.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * The disk size of the Compute instances managed by the SKS Nodepool (default: `50`).
     */
    public readonly diskSize!: pulumi.Output<number | undefined>;
    /**
     * The ID of the Instance Pool managed by the SKS Nodepool.
     */
    public /*out*/ readonly instancePoolId!: pulumi.Output<string>;
    /**
     * The string to add as prefix to managed Compute instances name (default `pool`).
     */
    public readonly instancePrefix!: pulumi.Output<string | undefined>;
    /**
     * The [type][type] of Compute instances managed by the SKS Nodepool (format: `FAMILY.SIZE`, e.g. `standard.medium`, `memory.huge`).
     */
    public readonly instanceType!: pulumi.Output<string>;
    /**
     * A map of key/value labels.
     */
    public readonly labels!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The name of the SKS Nodepool.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The list of Private Networks (IDs) to be attached to the Compute instances managed by the SKS Nodepool.
     */
    public readonly privateNetworkIds!: pulumi.Output<string[] | undefined>;
    /**
     * The list of Security Groups (IDs) the Compute instances managed by the SKS Nodepool are member of.
     */
    public readonly securityGroupIds!: pulumi.Output<string[] | undefined>;
    /**
     * The number of Compute instances the SKS Nodepool manages.
     */
    public readonly size!: pulumi.Output<number>;
    /**
     * The current state of the SKS Nodepool.
     */
    public /*out*/ readonly state!: pulumi.Output<string>;
    /**
     * A map of key/value [Kubernetes taints][k8s-taints] (value format: `VALUE:EFFECT`).
     */
    public readonly taints!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The ID of the Compute instance template used by the SKS Nodepool members.
     */
    public /*out*/ readonly templateId!: pulumi.Output<string>;
    /**
     * The Kubernetes version of the SKS Nodepool members.
     */
    public /*out*/ readonly version!: pulumi.Output<string>;
    /**
     * The name of the [zone][zone] to deploy the SKS Nodepool into.
     */
    public readonly zone!: pulumi.Output<string>;

    /**
     * Create a SKSNodePool resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SKSNodePoolArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SKSNodePoolArgs | SKSNodePoolState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as SKSNodePoolState | undefined;
            resourceInputs["antiAffinityGroupIds"] = state ? state.antiAffinityGroupIds : undefined;
            resourceInputs["clusterId"] = state ? state.clusterId : undefined;
            resourceInputs["createdAt"] = state ? state.createdAt : undefined;
            resourceInputs["deployTargetId"] = state ? state.deployTargetId : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["diskSize"] = state ? state.diskSize : undefined;
            resourceInputs["instancePoolId"] = state ? state.instancePoolId : undefined;
            resourceInputs["instancePrefix"] = state ? state.instancePrefix : undefined;
            resourceInputs["instanceType"] = state ? state.instanceType : undefined;
            resourceInputs["labels"] = state ? state.labels : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["privateNetworkIds"] = state ? state.privateNetworkIds : undefined;
            resourceInputs["securityGroupIds"] = state ? state.securityGroupIds : undefined;
            resourceInputs["size"] = state ? state.size : undefined;
            resourceInputs["state"] = state ? state.state : undefined;
            resourceInputs["taints"] = state ? state.taints : undefined;
            resourceInputs["templateId"] = state ? state.templateId : undefined;
            resourceInputs["version"] = state ? state.version : undefined;
            resourceInputs["zone"] = state ? state.zone : undefined;
        } else {
            const args = argsOrState as SKSNodePoolArgs | undefined;
            if ((!args || args.clusterId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'clusterId'");
            }
            if ((!args || args.instanceType === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceType'");
            }
            if ((!args || args.size === undefined) && !opts.urn) {
                throw new Error("Missing required property 'size'");
            }
            if ((!args || args.zone === undefined) && !opts.urn) {
                throw new Error("Missing required property 'zone'");
            }
            resourceInputs["antiAffinityGroupIds"] = args ? args.antiAffinityGroupIds : undefined;
            resourceInputs["clusterId"] = args ? args.clusterId : undefined;
            resourceInputs["deployTargetId"] = args ? args.deployTargetId : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["diskSize"] = args ? args.diskSize : undefined;
            resourceInputs["instancePrefix"] = args ? args.instancePrefix : undefined;
            resourceInputs["instanceType"] = args ? args.instanceType : undefined;
            resourceInputs["labels"] = args ? args.labels : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["privateNetworkIds"] = args ? args.privateNetworkIds : undefined;
            resourceInputs["securityGroupIds"] = args ? args.securityGroupIds : undefined;
            resourceInputs["size"] = args ? args.size : undefined;
            resourceInputs["taints"] = args ? args.taints : undefined;
            resourceInputs["zone"] = args ? args.zone : undefined;
            resourceInputs["createdAt"] = undefined /*out*/;
            resourceInputs["instancePoolId"] = undefined /*out*/;
            resourceInputs["state"] = undefined /*out*/;
            resourceInputs["templateId"] = undefined /*out*/;
            resourceInputs["version"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(SKSNodePool.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering SKSNodePool resources.
 */
export interface SKSNodePoolState {
    /**
     * The list of Anti-Affinity Groups (IDs) the Compute instances managed by the SKS Nodepool are member of.
     */
    antiAffinityGroupIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The ID of the parent SKS cluster.
     */
    clusterId?: pulumi.Input<string>;
    /**
     * The creation date of the SKS Nodepool.
     */
    createdAt?: pulumi.Input<string>;
    /**
     * A Deploy Target ID to deploy managed Compute instances to.
     */
    deployTargetId?: pulumi.Input<string>;
    /**
     * The description of the SKS Nodepool.
     */
    description?: pulumi.Input<string>;
    /**
     * The disk size of the Compute instances managed by the SKS Nodepool (default: `50`).
     */
    diskSize?: pulumi.Input<number>;
    /**
     * The ID of the Instance Pool managed by the SKS Nodepool.
     */
    instancePoolId?: pulumi.Input<string>;
    /**
     * The string to add as prefix to managed Compute instances name (default `pool`).
     */
    instancePrefix?: pulumi.Input<string>;
    /**
     * The [type][type] of Compute instances managed by the SKS Nodepool (format: `FAMILY.SIZE`, e.g. `standard.medium`, `memory.huge`).
     */
    instanceType?: pulumi.Input<string>;
    /**
     * A map of key/value labels.
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name of the SKS Nodepool.
     */
    name?: pulumi.Input<string>;
    /**
     * The list of Private Networks (IDs) to be attached to the Compute instances managed by the SKS Nodepool.
     */
    privateNetworkIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The list of Security Groups (IDs) the Compute instances managed by the SKS Nodepool are member of.
     */
    securityGroupIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The number of Compute instances the SKS Nodepool manages.
     */
    size?: pulumi.Input<number>;
    /**
     * The current state of the SKS Nodepool.
     */
    state?: pulumi.Input<string>;
    /**
     * A map of key/value [Kubernetes taints][k8s-taints] (value format: `VALUE:EFFECT`).
     */
    taints?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The ID of the Compute instance template used by the SKS Nodepool members.
     */
    templateId?: pulumi.Input<string>;
    /**
     * The Kubernetes version of the SKS Nodepool members.
     */
    version?: pulumi.Input<string>;
    /**
     * The name of the [zone][zone] to deploy the SKS Nodepool into.
     */
    zone?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a SKSNodePool resource.
 */
export interface SKSNodePoolArgs {
    /**
     * The list of Anti-Affinity Groups (IDs) the Compute instances managed by the SKS Nodepool are member of.
     */
    antiAffinityGroupIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The ID of the parent SKS cluster.
     */
    clusterId: pulumi.Input<string>;
    /**
     * A Deploy Target ID to deploy managed Compute instances to.
     */
    deployTargetId?: pulumi.Input<string>;
    /**
     * The description of the SKS Nodepool.
     */
    description?: pulumi.Input<string>;
    /**
     * The disk size of the Compute instances managed by the SKS Nodepool (default: `50`).
     */
    diskSize?: pulumi.Input<number>;
    /**
     * The string to add as prefix to managed Compute instances name (default `pool`).
     */
    instancePrefix?: pulumi.Input<string>;
    /**
     * The [type][type] of Compute instances managed by the SKS Nodepool (format: `FAMILY.SIZE`, e.g. `standard.medium`, `memory.huge`).
     */
    instanceType: pulumi.Input<string>;
    /**
     * A map of key/value labels.
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name of the SKS Nodepool.
     */
    name?: pulumi.Input<string>;
    /**
     * The list of Private Networks (IDs) to be attached to the Compute instances managed by the SKS Nodepool.
     */
    privateNetworkIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The list of Security Groups (IDs) the Compute instances managed by the SKS Nodepool are member of.
     */
    securityGroupIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The number of Compute instances the SKS Nodepool manages.
     */
    size: pulumi.Input<number>;
    /**
     * A map of key/value [Kubernetes taints][k8s-taints] (value format: `VALUE:EFFECT`).
     */
    taints?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name of the [zone][zone] to deploy the SKS Nodepool into.
     */
    zone: pulumi.Input<string>;
}

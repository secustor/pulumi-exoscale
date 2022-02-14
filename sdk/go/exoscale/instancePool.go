// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package exoscale

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides an Exoscale Instance Pool resource. This can be used to create, modify, and delete Instance Pools.
//
// ## Import
//
// An existing Instance Pool can be imported as a resource by `<ID>@<ZONE>`console
//
// ```sh
//  $ pulumi import exoscale:index/instancePool:InstancePool example eb556678-ec59-4be6-8c54-0406ae0f6da6@de-fra-1
// ```
//
//  [cloudinit]http://cloudinit.readthedocs.io/en/latest/ [d-compute_template]../d/compute_template.html [eip-doc]https://community.exoscale.com/documentation/compute/eip/ [privnet-doc]https://community.exoscale.com/documentation/compute/private-networks/ [r-affinity]affinity.html [r-security_group]security_group.html [sshkeypair]https://community.exoscale.com/documentation/compute/ssh-keypairs/ [template]https://www.exoscale.com/templates/ [type]https://www.exoscale.com/pricing/#/compute/ [zone]https://www.exoscale.com/datacenters/
type InstancePool struct {
	pulumi.CustomResourceState

	// A list of [Anti-Affinity Group][r-affinity] IDs (at creation time only).
	AffinityGroupIds pulumi.StringArrayOutput `pulumi:"affinityGroupIds"`
	// A Deploy Target ID.
	DeployTargetId pulumi.StringPtrOutput `pulumi:"deployTargetId"`
	// The description of the Instance Pool.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The managed Compute instances disk size.
	DiskSize pulumi.IntOutput `pulumi:"diskSize"`
	// A list of [Elastic IP][eip-doc] IDs.
	ElasticIpIds pulumi.StringArrayOutput `pulumi:"elasticIpIds"`
	// The string to add as prefix to managed Compute instances name (default: `pool`).
	InstancePrefix pulumi.StringPtrOutput `pulumi:"instancePrefix"`
	// The managed Compute instances [type][type] (format: `FAMILY.SIZE`, e.g. `standard.medium`, `memory.huge`).
	InstanceType pulumi.StringOutput `pulumi:"instanceType"`
	// Enable IPv6 on managed Compute instances (default: `false`).
	Ipv6 pulumi.BoolPtrOutput `pulumi:"ipv6"`
	// The name of the [SSH key pair][sshkeypair] to install when creating Compute instances.
	KeyPair pulumi.StringPtrOutput `pulumi:"keyPair"`
	// A map of key/value labels.
	Labels pulumi.StringMapOutput `pulumi:"labels"`
	// The name of the Instance Pool.
	Name pulumi.StringOutput `pulumi:"name"`
	// A list of [Private Network][privnet-doc] IDs.
	NetworkIds pulumi.StringArrayOutput `pulumi:"networkIds"`
	// A list of [Security Group][r-security_group] IDs (at creation time only).
	SecurityGroupIds pulumi.StringArrayOutput `pulumi:"securityGroupIds"`
	// **Deprecated** The managed Compute instances size. Replaced by `instanceType`.
	//
	// Deprecated: This attribute has been replaced by "instance_type".
	ServiceOffering pulumi.StringOutput `pulumi:"serviceOffering"`
	// The number of Compute instance members the Instance Pool manages.
	Size  pulumi.IntOutput    `pulumi:"size"`
	State pulumi.StringOutput `pulumi:"state"`
	// The ID of the instance [template][template] to use when creating Compute instances. Usage of the [`computeTemplate`][d-compute_template] data source is recommended.
	TemplateId pulumi.StringOutput `pulumi:"templateId"`
	// A [cloud-init][cloudinit] configuration to apply when creating Compute instances. Whenever possible don't base64-encode neither gzip it yourself, as this will be automatically taken care of on your behalf by the provider.
	UserData pulumi.StringPtrOutput `pulumi:"userData"`
	// The list of Instance Pool members (Compute instance IDs).
	VirtualMachines pulumi.StringArrayOutput `pulumi:"virtualMachines"`
	// The name of the [zone][zone] to deploy the Instance Pool into.
	Zone pulumi.StringOutput `pulumi:"zone"`
}

// NewInstancePool registers a new resource with the given unique name, arguments, and options.
func NewInstancePool(ctx *pulumi.Context,
	name string, args *InstancePoolArgs, opts ...pulumi.ResourceOption) (*InstancePool, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Size == nil {
		return nil, errors.New("invalid value for required argument 'Size'")
	}
	if args.TemplateId == nil {
		return nil, errors.New("invalid value for required argument 'TemplateId'")
	}
	if args.Zone == nil {
		return nil, errors.New("invalid value for required argument 'Zone'")
	}
	var resource InstancePool
	err := ctx.RegisterResource("exoscale:index/instancePool:InstancePool", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetInstancePool gets an existing InstancePool resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetInstancePool(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *InstancePoolState, opts ...pulumi.ResourceOption) (*InstancePool, error) {
	var resource InstancePool
	err := ctx.ReadResource("exoscale:index/instancePool:InstancePool", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering InstancePool resources.
type instancePoolState struct {
	// A list of [Anti-Affinity Group][r-affinity] IDs (at creation time only).
	AffinityGroupIds []string `pulumi:"affinityGroupIds"`
	// A Deploy Target ID.
	DeployTargetId *string `pulumi:"deployTargetId"`
	// The description of the Instance Pool.
	Description *string `pulumi:"description"`
	// The managed Compute instances disk size.
	DiskSize *int `pulumi:"diskSize"`
	// A list of [Elastic IP][eip-doc] IDs.
	ElasticIpIds []string `pulumi:"elasticIpIds"`
	// The string to add as prefix to managed Compute instances name (default: `pool`).
	InstancePrefix *string `pulumi:"instancePrefix"`
	// The managed Compute instances [type][type] (format: `FAMILY.SIZE`, e.g. `standard.medium`, `memory.huge`).
	InstanceType *string `pulumi:"instanceType"`
	// Enable IPv6 on managed Compute instances (default: `false`).
	Ipv6 *bool `pulumi:"ipv6"`
	// The name of the [SSH key pair][sshkeypair] to install when creating Compute instances.
	KeyPair *string `pulumi:"keyPair"`
	// A map of key/value labels.
	Labels map[string]string `pulumi:"labels"`
	// The name of the Instance Pool.
	Name *string `pulumi:"name"`
	// A list of [Private Network][privnet-doc] IDs.
	NetworkIds []string `pulumi:"networkIds"`
	// A list of [Security Group][r-security_group] IDs (at creation time only).
	SecurityGroupIds []string `pulumi:"securityGroupIds"`
	// **Deprecated** The managed Compute instances size. Replaced by `instanceType`.
	//
	// Deprecated: This attribute has been replaced by "instance_type".
	ServiceOffering *string `pulumi:"serviceOffering"`
	// The number of Compute instance members the Instance Pool manages.
	Size  *int    `pulumi:"size"`
	State *string `pulumi:"state"`
	// The ID of the instance [template][template] to use when creating Compute instances. Usage of the [`computeTemplate`][d-compute_template] data source is recommended.
	TemplateId *string `pulumi:"templateId"`
	// A [cloud-init][cloudinit] configuration to apply when creating Compute instances. Whenever possible don't base64-encode neither gzip it yourself, as this will be automatically taken care of on your behalf by the provider.
	UserData *string `pulumi:"userData"`
	// The list of Instance Pool members (Compute instance IDs).
	VirtualMachines []string `pulumi:"virtualMachines"`
	// The name of the [zone][zone] to deploy the Instance Pool into.
	Zone *string `pulumi:"zone"`
}

type InstancePoolState struct {
	// A list of [Anti-Affinity Group][r-affinity] IDs (at creation time only).
	AffinityGroupIds pulumi.StringArrayInput
	// A Deploy Target ID.
	DeployTargetId pulumi.StringPtrInput
	// The description of the Instance Pool.
	Description pulumi.StringPtrInput
	// The managed Compute instances disk size.
	DiskSize pulumi.IntPtrInput
	// A list of [Elastic IP][eip-doc] IDs.
	ElasticIpIds pulumi.StringArrayInput
	// The string to add as prefix to managed Compute instances name (default: `pool`).
	InstancePrefix pulumi.StringPtrInput
	// The managed Compute instances [type][type] (format: `FAMILY.SIZE`, e.g. `standard.medium`, `memory.huge`).
	InstanceType pulumi.StringPtrInput
	// Enable IPv6 on managed Compute instances (default: `false`).
	Ipv6 pulumi.BoolPtrInput
	// The name of the [SSH key pair][sshkeypair] to install when creating Compute instances.
	KeyPair pulumi.StringPtrInput
	// A map of key/value labels.
	Labels pulumi.StringMapInput
	// The name of the Instance Pool.
	Name pulumi.StringPtrInput
	// A list of [Private Network][privnet-doc] IDs.
	NetworkIds pulumi.StringArrayInput
	// A list of [Security Group][r-security_group] IDs (at creation time only).
	SecurityGroupIds pulumi.StringArrayInput
	// **Deprecated** The managed Compute instances size. Replaced by `instanceType`.
	//
	// Deprecated: This attribute has been replaced by "instance_type".
	ServiceOffering pulumi.StringPtrInput
	// The number of Compute instance members the Instance Pool manages.
	Size  pulumi.IntPtrInput
	State pulumi.StringPtrInput
	// The ID of the instance [template][template] to use when creating Compute instances. Usage of the [`computeTemplate`][d-compute_template] data source is recommended.
	TemplateId pulumi.StringPtrInput
	// A [cloud-init][cloudinit] configuration to apply when creating Compute instances. Whenever possible don't base64-encode neither gzip it yourself, as this will be automatically taken care of on your behalf by the provider.
	UserData pulumi.StringPtrInput
	// The list of Instance Pool members (Compute instance IDs).
	VirtualMachines pulumi.StringArrayInput
	// The name of the [zone][zone] to deploy the Instance Pool into.
	Zone pulumi.StringPtrInput
}

func (InstancePoolState) ElementType() reflect.Type {
	return reflect.TypeOf((*instancePoolState)(nil)).Elem()
}

type instancePoolArgs struct {
	// A list of [Anti-Affinity Group][r-affinity] IDs (at creation time only).
	AffinityGroupIds []string `pulumi:"affinityGroupIds"`
	// A Deploy Target ID.
	DeployTargetId *string `pulumi:"deployTargetId"`
	// The description of the Instance Pool.
	Description *string `pulumi:"description"`
	// The managed Compute instances disk size.
	DiskSize *int `pulumi:"diskSize"`
	// A list of [Elastic IP][eip-doc] IDs.
	ElasticIpIds []string `pulumi:"elasticIpIds"`
	// The string to add as prefix to managed Compute instances name (default: `pool`).
	InstancePrefix *string `pulumi:"instancePrefix"`
	// The managed Compute instances [type][type] (format: `FAMILY.SIZE`, e.g. `standard.medium`, `memory.huge`).
	InstanceType *string `pulumi:"instanceType"`
	// Enable IPv6 on managed Compute instances (default: `false`).
	Ipv6 *bool `pulumi:"ipv6"`
	// The name of the [SSH key pair][sshkeypair] to install when creating Compute instances.
	KeyPair *string `pulumi:"keyPair"`
	// A map of key/value labels.
	Labels map[string]string `pulumi:"labels"`
	// The name of the Instance Pool.
	Name *string `pulumi:"name"`
	// A list of [Private Network][privnet-doc] IDs.
	NetworkIds []string `pulumi:"networkIds"`
	// A list of [Security Group][r-security_group] IDs (at creation time only).
	SecurityGroupIds []string `pulumi:"securityGroupIds"`
	// **Deprecated** The managed Compute instances size. Replaced by `instanceType`.
	//
	// Deprecated: This attribute has been replaced by "instance_type".
	ServiceOffering *string `pulumi:"serviceOffering"`
	// The number of Compute instance members the Instance Pool manages.
	Size  int     `pulumi:"size"`
	State *string `pulumi:"state"`
	// The ID of the instance [template][template] to use when creating Compute instances. Usage of the [`computeTemplate`][d-compute_template] data source is recommended.
	TemplateId string `pulumi:"templateId"`
	// A [cloud-init][cloudinit] configuration to apply when creating Compute instances. Whenever possible don't base64-encode neither gzip it yourself, as this will be automatically taken care of on your behalf by the provider.
	UserData *string `pulumi:"userData"`
	// The list of Instance Pool members (Compute instance IDs).
	VirtualMachines []string `pulumi:"virtualMachines"`
	// The name of the [zone][zone] to deploy the Instance Pool into.
	Zone string `pulumi:"zone"`
}

// The set of arguments for constructing a InstancePool resource.
type InstancePoolArgs struct {
	// A list of [Anti-Affinity Group][r-affinity] IDs (at creation time only).
	AffinityGroupIds pulumi.StringArrayInput
	// A Deploy Target ID.
	DeployTargetId pulumi.StringPtrInput
	// The description of the Instance Pool.
	Description pulumi.StringPtrInput
	// The managed Compute instances disk size.
	DiskSize pulumi.IntPtrInput
	// A list of [Elastic IP][eip-doc] IDs.
	ElasticIpIds pulumi.StringArrayInput
	// The string to add as prefix to managed Compute instances name (default: `pool`).
	InstancePrefix pulumi.StringPtrInput
	// The managed Compute instances [type][type] (format: `FAMILY.SIZE`, e.g. `standard.medium`, `memory.huge`).
	InstanceType pulumi.StringPtrInput
	// Enable IPv6 on managed Compute instances (default: `false`).
	Ipv6 pulumi.BoolPtrInput
	// The name of the [SSH key pair][sshkeypair] to install when creating Compute instances.
	KeyPair pulumi.StringPtrInput
	// A map of key/value labels.
	Labels pulumi.StringMapInput
	// The name of the Instance Pool.
	Name pulumi.StringPtrInput
	// A list of [Private Network][privnet-doc] IDs.
	NetworkIds pulumi.StringArrayInput
	// A list of [Security Group][r-security_group] IDs (at creation time only).
	SecurityGroupIds pulumi.StringArrayInput
	// **Deprecated** The managed Compute instances size. Replaced by `instanceType`.
	//
	// Deprecated: This attribute has been replaced by "instance_type".
	ServiceOffering pulumi.StringPtrInput
	// The number of Compute instance members the Instance Pool manages.
	Size  pulumi.IntInput
	State pulumi.StringPtrInput
	// The ID of the instance [template][template] to use when creating Compute instances. Usage of the [`computeTemplate`][d-compute_template] data source is recommended.
	TemplateId pulumi.StringInput
	// A [cloud-init][cloudinit] configuration to apply when creating Compute instances. Whenever possible don't base64-encode neither gzip it yourself, as this will be automatically taken care of on your behalf by the provider.
	UserData pulumi.StringPtrInput
	// The list of Instance Pool members (Compute instance IDs).
	VirtualMachines pulumi.StringArrayInput
	// The name of the [zone][zone] to deploy the Instance Pool into.
	Zone pulumi.StringInput
}

func (InstancePoolArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*instancePoolArgs)(nil)).Elem()
}

type InstancePoolInput interface {
	pulumi.Input

	ToInstancePoolOutput() InstancePoolOutput
	ToInstancePoolOutputWithContext(ctx context.Context) InstancePoolOutput
}

func (*InstancePool) ElementType() reflect.Type {
	return reflect.TypeOf((**InstancePool)(nil)).Elem()
}

func (i *InstancePool) ToInstancePoolOutput() InstancePoolOutput {
	return i.ToInstancePoolOutputWithContext(context.Background())
}

func (i *InstancePool) ToInstancePoolOutputWithContext(ctx context.Context) InstancePoolOutput {
	return pulumi.ToOutputWithContext(ctx, i).(InstancePoolOutput)
}

// InstancePoolArrayInput is an input type that accepts InstancePoolArray and InstancePoolArrayOutput values.
// You can construct a concrete instance of `InstancePoolArrayInput` via:
//
//          InstancePoolArray{ InstancePoolArgs{...} }
type InstancePoolArrayInput interface {
	pulumi.Input

	ToInstancePoolArrayOutput() InstancePoolArrayOutput
	ToInstancePoolArrayOutputWithContext(context.Context) InstancePoolArrayOutput
}

type InstancePoolArray []InstancePoolInput

func (InstancePoolArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*InstancePool)(nil)).Elem()
}

func (i InstancePoolArray) ToInstancePoolArrayOutput() InstancePoolArrayOutput {
	return i.ToInstancePoolArrayOutputWithContext(context.Background())
}

func (i InstancePoolArray) ToInstancePoolArrayOutputWithContext(ctx context.Context) InstancePoolArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(InstancePoolArrayOutput)
}

// InstancePoolMapInput is an input type that accepts InstancePoolMap and InstancePoolMapOutput values.
// You can construct a concrete instance of `InstancePoolMapInput` via:
//
//          InstancePoolMap{ "key": InstancePoolArgs{...} }
type InstancePoolMapInput interface {
	pulumi.Input

	ToInstancePoolMapOutput() InstancePoolMapOutput
	ToInstancePoolMapOutputWithContext(context.Context) InstancePoolMapOutput
}

type InstancePoolMap map[string]InstancePoolInput

func (InstancePoolMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*InstancePool)(nil)).Elem()
}

func (i InstancePoolMap) ToInstancePoolMapOutput() InstancePoolMapOutput {
	return i.ToInstancePoolMapOutputWithContext(context.Background())
}

func (i InstancePoolMap) ToInstancePoolMapOutputWithContext(ctx context.Context) InstancePoolMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(InstancePoolMapOutput)
}

type InstancePoolOutput struct{ *pulumi.OutputState }

func (InstancePoolOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**InstancePool)(nil)).Elem()
}

func (o InstancePoolOutput) ToInstancePoolOutput() InstancePoolOutput {
	return o
}

func (o InstancePoolOutput) ToInstancePoolOutputWithContext(ctx context.Context) InstancePoolOutput {
	return o
}

type InstancePoolArrayOutput struct{ *pulumi.OutputState }

func (InstancePoolArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*InstancePool)(nil)).Elem()
}

func (o InstancePoolArrayOutput) ToInstancePoolArrayOutput() InstancePoolArrayOutput {
	return o
}

func (o InstancePoolArrayOutput) ToInstancePoolArrayOutputWithContext(ctx context.Context) InstancePoolArrayOutput {
	return o
}

func (o InstancePoolArrayOutput) Index(i pulumi.IntInput) InstancePoolOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *InstancePool {
		return vs[0].([]*InstancePool)[vs[1].(int)]
	}).(InstancePoolOutput)
}

type InstancePoolMapOutput struct{ *pulumi.OutputState }

func (InstancePoolMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*InstancePool)(nil)).Elem()
}

func (o InstancePoolMapOutput) ToInstancePoolMapOutput() InstancePoolMapOutput {
	return o
}

func (o InstancePoolMapOutput) ToInstancePoolMapOutputWithContext(ctx context.Context) InstancePoolMapOutput {
	return o
}

func (o InstancePoolMapOutput) MapIndex(k pulumi.StringInput) InstancePoolOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *InstancePool {
		return vs[0].(map[string]*InstancePool)[vs[1].(string)]
	}).(InstancePoolOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*InstancePoolInput)(nil)).Elem(), &InstancePool{})
	pulumi.RegisterInputType(reflect.TypeOf((*InstancePoolArrayInput)(nil)).Elem(), InstancePoolArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*InstancePoolMapInput)(nil)).Elem(), InstancePoolMap{})
	pulumi.RegisterOutputType(InstancePoolOutput{})
	pulumi.RegisterOutputType(InstancePoolArrayOutput{})
	pulumi.RegisterOutputType(InstancePoolMapOutput{})
}

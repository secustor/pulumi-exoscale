// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package exoscale

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides an Exoscale [Network Load Balancer][nlb-doc] (NLB) resource. This can be used to create, modify, and delete NLBs.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-exoscale/sdk/go/exoscale"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi/config"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		cfg := config.New(ctx, "")
// 		zone := "de-fra-1"
// 		if param := cfg.Get("zone"); param != "" {
// 			zone = param
// 		}
// 		_, err := exoscale.NewNLB(ctx, "website", &exoscale.NLBArgs{
// 			Zone:        pulumi.String(zone),
// 			Description: pulumi.String("This is the Network Load Balancer for my website"),
// 			Labels: pulumi.StringMap{
// 				"env": pulumi.String("prod"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
//
// ## Import
//
// An existing NLB can be imported as a resource by `<ID>@<ZONE>`console
//
// ```sh
//  $ pulumi import exoscale:index/nLB:NLB example eb556678-ec59-4be6-8c54-0406ae0f6da6@de-fra-1
// ```
//
//  [nlb-doc]https://community.exoscale.com/documentation/compute/network-load-balancer/ [r-nlb_service]nlb_service.html [zone]https://www.exoscale.com/datacenters/
type NLB struct {
	pulumi.CustomResourceState

	// The creation date of the NLB.
	CreatedAt pulumi.StringOutput `pulumi:"createdAt"`
	// The description of the NLB.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The public IP address of the NLB.
	IpAddress pulumi.StringOutput `pulumi:"ipAddress"`
	// A map of key/value labels.
	Labels pulumi.StringMapOutput `pulumi:"labels"`
	// The name of the NLB.
	Name pulumi.StringOutput `pulumi:"name"`
	// The list of the NLB service names.
	Services pulumi.StringArrayOutput `pulumi:"services"`
	// The current state of the NLB.
	State pulumi.StringOutput `pulumi:"state"`
	// The name of the [zone][zone] to deploy the NLB into.
	Zone pulumi.StringOutput `pulumi:"zone"`
}

// NewNLB registers a new resource with the given unique name, arguments, and options.
func NewNLB(ctx *pulumi.Context,
	name string, args *NLBArgs, opts ...pulumi.ResourceOption) (*NLB, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Zone == nil {
		return nil, errors.New("invalid value for required argument 'Zone'")
	}
	var resource NLB
	err := ctx.RegisterResource("exoscale:index/nLB:NLB", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNLB gets an existing NLB resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNLB(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NLBState, opts ...pulumi.ResourceOption) (*NLB, error) {
	var resource NLB
	err := ctx.ReadResource("exoscale:index/nLB:NLB", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering NLB resources.
type nlbState struct {
	// The creation date of the NLB.
	CreatedAt *string `pulumi:"createdAt"`
	// The description of the NLB.
	Description *string `pulumi:"description"`
	// The public IP address of the NLB.
	IpAddress *string `pulumi:"ipAddress"`
	// A map of key/value labels.
	Labels map[string]string `pulumi:"labels"`
	// The name of the NLB.
	Name *string `pulumi:"name"`
	// The list of the NLB service names.
	Services []string `pulumi:"services"`
	// The current state of the NLB.
	State *string `pulumi:"state"`
	// The name of the [zone][zone] to deploy the NLB into.
	Zone *string `pulumi:"zone"`
}

type NLBState struct {
	// The creation date of the NLB.
	CreatedAt pulumi.StringPtrInput
	// The description of the NLB.
	Description pulumi.StringPtrInput
	// The public IP address of the NLB.
	IpAddress pulumi.StringPtrInput
	// A map of key/value labels.
	Labels pulumi.StringMapInput
	// The name of the NLB.
	Name pulumi.StringPtrInput
	// The list of the NLB service names.
	Services pulumi.StringArrayInput
	// The current state of the NLB.
	State pulumi.StringPtrInput
	// The name of the [zone][zone] to deploy the NLB into.
	Zone pulumi.StringPtrInput
}

func (NLBState) ElementType() reflect.Type {
	return reflect.TypeOf((*nlbState)(nil)).Elem()
}

type nlbArgs struct {
	// The description of the NLB.
	Description *string `pulumi:"description"`
	// A map of key/value labels.
	Labels map[string]string `pulumi:"labels"`
	// The name of the NLB.
	Name *string `pulumi:"name"`
	// The name of the [zone][zone] to deploy the NLB into.
	Zone string `pulumi:"zone"`
}

// The set of arguments for constructing a NLB resource.
type NLBArgs struct {
	// The description of the NLB.
	Description pulumi.StringPtrInput
	// A map of key/value labels.
	Labels pulumi.StringMapInput
	// The name of the NLB.
	Name pulumi.StringPtrInput
	// The name of the [zone][zone] to deploy the NLB into.
	Zone pulumi.StringInput
}

func (NLBArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*nlbArgs)(nil)).Elem()
}

type NLBInput interface {
	pulumi.Input

	ToNLBOutput() NLBOutput
	ToNLBOutputWithContext(ctx context.Context) NLBOutput
}

func (*NLB) ElementType() reflect.Type {
	return reflect.TypeOf((**NLB)(nil)).Elem()
}

func (i *NLB) ToNLBOutput() NLBOutput {
	return i.ToNLBOutputWithContext(context.Background())
}

func (i *NLB) ToNLBOutputWithContext(ctx context.Context) NLBOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NLBOutput)
}

// NLBArrayInput is an input type that accepts NLBArray and NLBArrayOutput values.
// You can construct a concrete instance of `NLBArrayInput` via:
//
//          NLBArray{ NLBArgs{...} }
type NLBArrayInput interface {
	pulumi.Input

	ToNLBArrayOutput() NLBArrayOutput
	ToNLBArrayOutputWithContext(context.Context) NLBArrayOutput
}

type NLBArray []NLBInput

func (NLBArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*NLB)(nil)).Elem()
}

func (i NLBArray) ToNLBArrayOutput() NLBArrayOutput {
	return i.ToNLBArrayOutputWithContext(context.Background())
}

func (i NLBArray) ToNLBArrayOutputWithContext(ctx context.Context) NLBArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NLBArrayOutput)
}

// NLBMapInput is an input type that accepts NLBMap and NLBMapOutput values.
// You can construct a concrete instance of `NLBMapInput` via:
//
//          NLBMap{ "key": NLBArgs{...} }
type NLBMapInput interface {
	pulumi.Input

	ToNLBMapOutput() NLBMapOutput
	ToNLBMapOutputWithContext(context.Context) NLBMapOutput
}

type NLBMap map[string]NLBInput

func (NLBMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*NLB)(nil)).Elem()
}

func (i NLBMap) ToNLBMapOutput() NLBMapOutput {
	return i.ToNLBMapOutputWithContext(context.Background())
}

func (i NLBMap) ToNLBMapOutputWithContext(ctx context.Context) NLBMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NLBMapOutput)
}

type NLBOutput struct{ *pulumi.OutputState }

func (NLBOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**NLB)(nil)).Elem()
}

func (o NLBOutput) ToNLBOutput() NLBOutput {
	return o
}

func (o NLBOutput) ToNLBOutputWithContext(ctx context.Context) NLBOutput {
	return o
}

type NLBArrayOutput struct{ *pulumi.OutputState }

func (NLBArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*NLB)(nil)).Elem()
}

func (o NLBArrayOutput) ToNLBArrayOutput() NLBArrayOutput {
	return o
}

func (o NLBArrayOutput) ToNLBArrayOutputWithContext(ctx context.Context) NLBArrayOutput {
	return o
}

func (o NLBArrayOutput) Index(i pulumi.IntInput) NLBOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *NLB {
		return vs[0].([]*NLB)[vs[1].(int)]
	}).(NLBOutput)
}

type NLBMapOutput struct{ *pulumi.OutputState }

func (NLBMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*NLB)(nil)).Elem()
}

func (o NLBMapOutput) ToNLBMapOutput() NLBMapOutput {
	return o
}

func (o NLBMapOutput) ToNLBMapOutputWithContext(ctx context.Context) NLBMapOutput {
	return o
}

func (o NLBMapOutput) MapIndex(k pulumi.StringInput) NLBOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *NLB {
		return vs[0].(map[string]*NLB)[vs[1].(string)]
	}).(NLBOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*NLBInput)(nil)).Elem(), &NLB{})
	pulumi.RegisterInputType(reflect.TypeOf((*NLBArrayInput)(nil)).Elem(), NLBArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*NLBMapInput)(nil)).Elem(), NLBMap{})
	pulumi.RegisterOutputType(NLBOutput{})
	pulumi.RegisterOutputType(NLBArrayOutput{})
	pulumi.RegisterOutputType(NLBMapOutput{})
}

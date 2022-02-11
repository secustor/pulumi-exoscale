// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package exoscale

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides an Exoscale Network Load Balancer ([NLB][r-nlb]) service resource. This can be used to create, modify, and delete NLB services.
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
// 		template := "Linux Ubuntu 20.04 LTS 64-bit"
// 		if param := cfg.Get("template"); param != "" {
// 			template = param
// 		}
// 		opt0 := template
// 		websiteComputeTemplate, err := exoscale.GetComputeTemplate(ctx, &GetComputeTemplateArgs{
// 			Zone: zone,
// 			Name: &opt0,
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		websiteInstancePool, err := exoscale.NewInstancePool(ctx, "websiteInstancePool", &exoscale.InstancePoolArgs{
// 			Description:     pulumi.String("Instance Pool Website nodes"),
// 			TemplateId:      pulumi.String(websiteComputeTemplate.Id),
// 			ServiceOffering: pulumi.String("medium"),
// 			Size:            pulumi.Int(3),
// 			Zone:            pulumi.String(zone),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		websiteNLB, err := exoscale.NewNLB(ctx, "websiteNLB", &exoscale.NLBArgs{
// 			Description: pulumi.String("This is the Network Load Balancer for my website"),
// 			Zone:        pulumi.String(zone),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = exoscale.NewNLBService(ctx, "websiteNLBService", &exoscale.NLBServiceArgs{
// 			Zone:           websiteNLB.Zone,
// 			Description:    pulumi.String("Website over HTTPS"),
// 			NlbId:          websiteNLB.ID(),
// 			InstancePoolId: websiteInstancePool.ID(),
// 			Protocol:       pulumi.String("tcp"),
// 			Port:           pulumi.Int(443),
// 			TargetPort:     pulumi.Int(8443),
// 			Strategy:       pulumi.String("round-robin"),
// 			Healthchecks: NLBServiceHealthcheckArray{
// 				&NLBServiceHealthcheckArgs{
// 					Mode:     pulumi.String("https"),
// 					Port:     pulumi.Int(8443),
// 					Uri:      pulumi.String("/healthz"),
// 					TlsSni:   pulumi.String("example.net"),
// 					Interval: pulumi.Int(5),
// 					Timeout:  pulumi.Int(3),
// 					Retries:  pulumi.Int(1),
// 				},
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
// An existing NLB service can be imported as a resource by `<NLB-ID>/<SERVICE-ID>@<ZONE>`console
//
// ```sh
//  $ pulumi import exoscale:index/nLBService:NLBService example eb556678-ec59-4be6-8c54-0406ae0f6da6/9ecc6b8b-73d4-4211-8ced-f7f29bb79524@de-fra-1
// ```
//
//  [r-nlb]nlb.html [zone]https://www.exoscale.com/datacenters/
type NLBService struct {
	pulumi.CustomResourceState

	// The description of the NLB service.
	Description  pulumi.StringPtrOutput           `pulumi:"description"`
	Healthchecks NLBServiceHealthcheckArrayOutput `pulumi:"healthchecks"`
	// The ID of the Instance Pool to forward network traffic to.
	InstancePoolId pulumi.StringOutput `pulumi:"instancePoolId"`
	// The name of the NLB service.
	Name pulumi.StringOutput `pulumi:"name"`
	// The ID of the NLB to attach the service.
	NlbId pulumi.StringOutput `pulumi:"nlbId"`
	// The healthcheck port.
	Port pulumi.IntOutput `pulumi:"port"`
	// The protocol (tcp/udp).
	Protocol pulumi.StringPtrOutput `pulumi:"protocol"`
	State    pulumi.StringOutput    `pulumi:"state"`
	// The strategy (round-robin/source-hash).
	Strategy pulumi.StringPtrOutput `pulumi:"strategy"`
	// The port to forward network traffic to on target instances.
	TargetPort pulumi.IntOutput `pulumi:"targetPort"`
	// The name of the [zone][zone] used by the NLB.
	Zone pulumi.StringOutput `pulumi:"zone"`
}

// NewNLBService registers a new resource with the given unique name, arguments, and options.
func NewNLBService(ctx *pulumi.Context,
	name string, args *NLBServiceArgs, opts ...pulumi.ResourceOption) (*NLBService, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Healthchecks == nil {
		return nil, errors.New("invalid value for required argument 'Healthchecks'")
	}
	if args.InstancePoolId == nil {
		return nil, errors.New("invalid value for required argument 'InstancePoolId'")
	}
	if args.NlbId == nil {
		return nil, errors.New("invalid value for required argument 'NlbId'")
	}
	if args.Port == nil {
		return nil, errors.New("invalid value for required argument 'Port'")
	}
	if args.TargetPort == nil {
		return nil, errors.New("invalid value for required argument 'TargetPort'")
	}
	if args.Zone == nil {
		return nil, errors.New("invalid value for required argument 'Zone'")
	}
	var resource NLBService
	err := ctx.RegisterResource("exoscale:index/nLBService:NLBService", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNLBService gets an existing NLBService resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNLBService(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NLBServiceState, opts ...pulumi.ResourceOption) (*NLBService, error) {
	var resource NLBService
	err := ctx.ReadResource("exoscale:index/nLBService:NLBService", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering NLBService resources.
type nlbserviceState struct {
	// The description of the NLB service.
	Description  *string                 `pulumi:"description"`
	Healthchecks []NLBServiceHealthcheck `pulumi:"healthchecks"`
	// The ID of the Instance Pool to forward network traffic to.
	InstancePoolId *string `pulumi:"instancePoolId"`
	// The name of the NLB service.
	Name *string `pulumi:"name"`
	// The ID of the NLB to attach the service.
	NlbId *string `pulumi:"nlbId"`
	// The healthcheck port.
	Port *int `pulumi:"port"`
	// The protocol (tcp/udp).
	Protocol *string `pulumi:"protocol"`
	State    *string `pulumi:"state"`
	// The strategy (round-robin/source-hash).
	Strategy *string `pulumi:"strategy"`
	// The port to forward network traffic to on target instances.
	TargetPort *int `pulumi:"targetPort"`
	// The name of the [zone][zone] used by the NLB.
	Zone *string `pulumi:"zone"`
}

type NLBServiceState struct {
	// The description of the NLB service.
	Description  pulumi.StringPtrInput
	Healthchecks NLBServiceHealthcheckArrayInput
	// The ID of the Instance Pool to forward network traffic to.
	InstancePoolId pulumi.StringPtrInput
	// The name of the NLB service.
	Name pulumi.StringPtrInput
	// The ID of the NLB to attach the service.
	NlbId pulumi.StringPtrInput
	// The healthcheck port.
	Port pulumi.IntPtrInput
	// The protocol (tcp/udp).
	Protocol pulumi.StringPtrInput
	State    pulumi.StringPtrInput
	// The strategy (round-robin/source-hash).
	Strategy pulumi.StringPtrInput
	// The port to forward network traffic to on target instances.
	TargetPort pulumi.IntPtrInput
	// The name of the [zone][zone] used by the NLB.
	Zone pulumi.StringPtrInput
}

func (NLBServiceState) ElementType() reflect.Type {
	return reflect.TypeOf((*nlbserviceState)(nil)).Elem()
}

type nlbserviceArgs struct {
	// The description of the NLB service.
	Description  *string                 `pulumi:"description"`
	Healthchecks []NLBServiceHealthcheck `pulumi:"healthchecks"`
	// The ID of the Instance Pool to forward network traffic to.
	InstancePoolId string `pulumi:"instancePoolId"`
	// The name of the NLB service.
	Name *string `pulumi:"name"`
	// The ID of the NLB to attach the service.
	NlbId string `pulumi:"nlbId"`
	// The healthcheck port.
	Port int `pulumi:"port"`
	// The protocol (tcp/udp).
	Protocol *string `pulumi:"protocol"`
	// The strategy (round-robin/source-hash).
	Strategy *string `pulumi:"strategy"`
	// The port to forward network traffic to on target instances.
	TargetPort int `pulumi:"targetPort"`
	// The name of the [zone][zone] used by the NLB.
	Zone string `pulumi:"zone"`
}

// The set of arguments for constructing a NLBService resource.
type NLBServiceArgs struct {
	// The description of the NLB service.
	Description  pulumi.StringPtrInput
	Healthchecks NLBServiceHealthcheckArrayInput
	// The ID of the Instance Pool to forward network traffic to.
	InstancePoolId pulumi.StringInput
	// The name of the NLB service.
	Name pulumi.StringPtrInput
	// The ID of the NLB to attach the service.
	NlbId pulumi.StringInput
	// The healthcheck port.
	Port pulumi.IntInput
	// The protocol (tcp/udp).
	Protocol pulumi.StringPtrInput
	// The strategy (round-robin/source-hash).
	Strategy pulumi.StringPtrInput
	// The port to forward network traffic to on target instances.
	TargetPort pulumi.IntInput
	// The name of the [zone][zone] used by the NLB.
	Zone pulumi.StringInput
}

func (NLBServiceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*nlbserviceArgs)(nil)).Elem()
}

type NLBServiceInput interface {
	pulumi.Input

	ToNLBServiceOutput() NLBServiceOutput
	ToNLBServiceOutputWithContext(ctx context.Context) NLBServiceOutput
}

func (*NLBService) ElementType() reflect.Type {
	return reflect.TypeOf((**NLBService)(nil)).Elem()
}

func (i *NLBService) ToNLBServiceOutput() NLBServiceOutput {
	return i.ToNLBServiceOutputWithContext(context.Background())
}

func (i *NLBService) ToNLBServiceOutputWithContext(ctx context.Context) NLBServiceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NLBServiceOutput)
}

// NLBServiceArrayInput is an input type that accepts NLBServiceArray and NLBServiceArrayOutput values.
// You can construct a concrete instance of `NLBServiceArrayInput` via:
//
//          NLBServiceArray{ NLBServiceArgs{...} }
type NLBServiceArrayInput interface {
	pulumi.Input

	ToNLBServiceArrayOutput() NLBServiceArrayOutput
	ToNLBServiceArrayOutputWithContext(context.Context) NLBServiceArrayOutput
}

type NLBServiceArray []NLBServiceInput

func (NLBServiceArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*NLBService)(nil)).Elem()
}

func (i NLBServiceArray) ToNLBServiceArrayOutput() NLBServiceArrayOutput {
	return i.ToNLBServiceArrayOutputWithContext(context.Background())
}

func (i NLBServiceArray) ToNLBServiceArrayOutputWithContext(ctx context.Context) NLBServiceArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NLBServiceArrayOutput)
}

// NLBServiceMapInput is an input type that accepts NLBServiceMap and NLBServiceMapOutput values.
// You can construct a concrete instance of `NLBServiceMapInput` via:
//
//          NLBServiceMap{ "key": NLBServiceArgs{...} }
type NLBServiceMapInput interface {
	pulumi.Input

	ToNLBServiceMapOutput() NLBServiceMapOutput
	ToNLBServiceMapOutputWithContext(context.Context) NLBServiceMapOutput
}

type NLBServiceMap map[string]NLBServiceInput

func (NLBServiceMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*NLBService)(nil)).Elem()
}

func (i NLBServiceMap) ToNLBServiceMapOutput() NLBServiceMapOutput {
	return i.ToNLBServiceMapOutputWithContext(context.Background())
}

func (i NLBServiceMap) ToNLBServiceMapOutputWithContext(ctx context.Context) NLBServiceMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NLBServiceMapOutput)
}

type NLBServiceOutput struct{ *pulumi.OutputState }

func (NLBServiceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**NLBService)(nil)).Elem()
}

func (o NLBServiceOutput) ToNLBServiceOutput() NLBServiceOutput {
	return o
}

func (o NLBServiceOutput) ToNLBServiceOutputWithContext(ctx context.Context) NLBServiceOutput {
	return o
}

type NLBServiceArrayOutput struct{ *pulumi.OutputState }

func (NLBServiceArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*NLBService)(nil)).Elem()
}

func (o NLBServiceArrayOutput) ToNLBServiceArrayOutput() NLBServiceArrayOutput {
	return o
}

func (o NLBServiceArrayOutput) ToNLBServiceArrayOutputWithContext(ctx context.Context) NLBServiceArrayOutput {
	return o
}

func (o NLBServiceArrayOutput) Index(i pulumi.IntInput) NLBServiceOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *NLBService {
		return vs[0].([]*NLBService)[vs[1].(int)]
	}).(NLBServiceOutput)
}

type NLBServiceMapOutput struct{ *pulumi.OutputState }

func (NLBServiceMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*NLBService)(nil)).Elem()
}

func (o NLBServiceMapOutput) ToNLBServiceMapOutput() NLBServiceMapOutput {
	return o
}

func (o NLBServiceMapOutput) ToNLBServiceMapOutputWithContext(ctx context.Context) NLBServiceMapOutput {
	return o
}

func (o NLBServiceMapOutput) MapIndex(k pulumi.StringInput) NLBServiceOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *NLBService {
		return vs[0].(map[string]*NLBService)[vs[1].(string)]
	}).(NLBServiceOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*NLBServiceInput)(nil)).Elem(), &NLBService{})
	pulumi.RegisterInputType(reflect.TypeOf((*NLBServiceArrayInput)(nil)).Elem(), NLBServiceArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*NLBServiceMapInput)(nil)).Elem(), NLBServiceMap{})
	pulumi.RegisterOutputType(NLBServiceOutput{})
	pulumi.RegisterOutputType(NLBServiceArrayOutput{})
	pulumi.RegisterOutputType(NLBServiceMapOutput{})
}
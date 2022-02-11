// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package exoscale

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides information on an [Anti-Affinity Group][aag-doc] for use in other resources such as a [`Compute`][r-compute] resource.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-exoscale/sdk/go/exoscale"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		zone := "ch-gva-2"
// 		opt0 := "web"
// 		web, err := exoscale.LookupAntiAffinityGroup(ctx, &GetAntiAffinityGroupArgs{
// 			Name: &opt0,
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		opt1 := "Linux Ubuntu 20.04 LTS 64-bit"
// 		ubuntu, err := exoscale.GetComputeTemplate(ctx, &GetComputeTemplateArgs{
// 			Zone: zone,
// 			Name: &opt1,
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		_, err = exoscale.NewComputeInstance(ctx, "my-server", &exoscale.ComputeInstanceArgs{
// 			Zone:       pulumi.String(zone),
// 			Type:       pulumi.String("standard.medium"),
// 			TemplateId: pulumi.String(ubuntu.Id),
// 			DiskSize:   pulumi.Int(20),
// 			AntiAffinityGroupIds: pulumi.StringArray{
// 				pulumi.String(web.Id),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func LookupAntiAffinityGroup(ctx *pulumi.Context, args *LookupAntiAffinityGroupArgs, opts ...pulumi.InvokeOption) (*LookupAntiAffinityGroupResult, error) {
	var rv LookupAntiAffinityGroupResult
	err := ctx.Invoke("exoscale:index/getAntiAffinityGroup:getAntiAffinityGroup", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getAntiAffinityGroup.
type LookupAntiAffinityGroupArgs struct {
	// The ID of the Anti-Affinity Group (conflicts with `name`).
	Id *string `pulumi:"id"`
	// The name of the Anti-Affinity Group (conflicts with `id`).
	Name *string `pulumi:"name"`
}

// A collection of values returned by getAntiAffinityGroup.
type LookupAntiAffinityGroupResult struct {
	Id *string `pulumi:"id"`
	// A list of Compute instance IDs belonging to the Anti-Affinity Group.
	Instances []string `pulumi:"instances"`
	Name      *string  `pulumi:"name"`
}

func LookupAntiAffinityGroupOutput(ctx *pulumi.Context, args LookupAntiAffinityGroupOutputArgs, opts ...pulumi.InvokeOption) LookupAntiAffinityGroupResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupAntiAffinityGroupResult, error) {
			args := v.(LookupAntiAffinityGroupArgs)
			r, err := LookupAntiAffinityGroup(ctx, &args, opts...)
			return *r, err
		}).(LookupAntiAffinityGroupResultOutput)
}

// A collection of arguments for invoking getAntiAffinityGroup.
type LookupAntiAffinityGroupOutputArgs struct {
	// The ID of the Anti-Affinity Group (conflicts with `name`).
	Id pulumi.StringPtrInput `pulumi:"id"`
	// The name of the Anti-Affinity Group (conflicts with `id`).
	Name pulumi.StringPtrInput `pulumi:"name"`
}

func (LookupAntiAffinityGroupOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupAntiAffinityGroupArgs)(nil)).Elem()
}

// A collection of values returned by getAntiAffinityGroup.
type LookupAntiAffinityGroupResultOutput struct{ *pulumi.OutputState }

func (LookupAntiAffinityGroupResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupAntiAffinityGroupResult)(nil)).Elem()
}

func (o LookupAntiAffinityGroupResultOutput) ToLookupAntiAffinityGroupResultOutput() LookupAntiAffinityGroupResultOutput {
	return o
}

func (o LookupAntiAffinityGroupResultOutput) ToLookupAntiAffinityGroupResultOutputWithContext(ctx context.Context) LookupAntiAffinityGroupResultOutput {
	return o
}

func (o LookupAntiAffinityGroupResultOutput) Id() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupAntiAffinityGroupResult) *string { return v.Id }).(pulumi.StringPtrOutput)
}

// A list of Compute instance IDs belonging to the Anti-Affinity Group.
func (o LookupAntiAffinityGroupResultOutput) Instances() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupAntiAffinityGroupResult) []string { return v.Instances }).(pulumi.StringArrayOutput)
}

func (o LookupAntiAffinityGroupResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupAntiAffinityGroupResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupAntiAffinityGroupResultOutput{})
}
// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package exoscale

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides information on a [Security Group][sg-doc] for use in other resources such as a [`InstancePool`][r-instance_pool] resource.
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
// 		web, err := exoscale.LookupSecurityGroup(ctx, &GetSecurityGroupArgs{
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
// 		_, err = exoscale.NewInstancePool(ctx, "webservers", &exoscale.InstancePoolArgs{
// 			Zone:            pulumi.String(zone),
// 			TemplateId:      pulumi.String(ubuntu.Id),
// 			Size:            pulumi.Int(5),
// 			ServiceOffering: pulumi.String("medium"),
// 			SecurityGroupIds: pulumi.StringArray{
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
func LookupSecurityGroup(ctx *pulumi.Context, args *LookupSecurityGroupArgs, opts ...pulumi.InvokeOption) (*LookupSecurityGroupResult, error) {
	var rv LookupSecurityGroupResult
	err := ctx.Invoke("exoscale:index/getSecurityGroup:getSecurityGroup", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getSecurityGroup.
type LookupSecurityGroupArgs struct {
	// The ID of the Security Group (conflicts with `name`)
	Id *string `pulumi:"id"`
	// The name of the Security Group (conflicts with `id`)
	Name *string `pulumi:"name"`
}

// A collection of values returned by getSecurityGroup.
type LookupSecurityGroupResult struct {
	Id   *string `pulumi:"id"`
	Name *string `pulumi:"name"`
}

func LookupSecurityGroupOutput(ctx *pulumi.Context, args LookupSecurityGroupOutputArgs, opts ...pulumi.InvokeOption) LookupSecurityGroupResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupSecurityGroupResult, error) {
			args := v.(LookupSecurityGroupArgs)
			r, err := LookupSecurityGroup(ctx, &args, opts...)
			return *r, err
		}).(LookupSecurityGroupResultOutput)
}

// A collection of arguments for invoking getSecurityGroup.
type LookupSecurityGroupOutputArgs struct {
	// The ID of the Security Group (conflicts with `name`)
	Id pulumi.StringPtrInput `pulumi:"id"`
	// The name of the Security Group (conflicts with `id`)
	Name pulumi.StringPtrInput `pulumi:"name"`
}

func (LookupSecurityGroupOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupSecurityGroupArgs)(nil)).Elem()
}

// A collection of values returned by getSecurityGroup.
type LookupSecurityGroupResultOutput struct{ *pulumi.OutputState }

func (LookupSecurityGroupResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupSecurityGroupResult)(nil)).Elem()
}

func (o LookupSecurityGroupResultOutput) ToLookupSecurityGroupResultOutput() LookupSecurityGroupResultOutput {
	return o
}

func (o LookupSecurityGroupResultOutput) ToLookupSecurityGroupResultOutputWithContext(ctx context.Context) LookupSecurityGroupResultOutput {
	return o
}

func (o LookupSecurityGroupResultOutput) Id() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupSecurityGroupResult) *string { return v.Id }).(pulumi.StringPtrOutput)
}

func (o LookupSecurityGroupResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupSecurityGroupResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupSecurityGroupResultOutput{})
}
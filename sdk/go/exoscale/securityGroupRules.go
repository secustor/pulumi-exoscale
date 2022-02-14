// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package exoscale

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a resource for assigning multiple rules to an existing Exoscale [Security Group][r-security_group].
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
// 		webservers, err := exoscale.NewSecurityGroup(ctx, "webservers", nil)
// 		if err != nil {
// 			return err
// 		}
// 		_, err = exoscale.NewSecurityGroupRules(ctx, "admin", &exoscale.SecurityGroupRulesArgs{
// 			SecurityGroup: webservers.Name,
// 			Ingresses: SecurityGroupRulesIngressArray{
// 				&SecurityGroupRulesIngressArgs{
// 					Protocol: pulumi.String("ICMP"),
// 					IcmpType: pulumi.Int(8),
// 					UserSecurityGroupLists: pulumi.StringArray{
// 						pulumi.String("bastion"),
// 					},
// 				},
// 				&SecurityGroupRulesIngressArgs{
// 					Protocol: pulumi.String("TCP"),
// 					Ports: pulumi.StringArray{
// 						pulumi.String("22"),
// 					},
// 					UserSecurityGroupLists: pulumi.StringArray{
// 						pulumi.String("bastion"),
// 					},
// 				},
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = exoscale.NewSecurityGroupRules(ctx, "web", &exoscale.SecurityGroupRulesArgs{
// 			SecurityGroupId: webservers.ID(),
// 			Ingresses: SecurityGroupRulesIngressArray{
// 				&SecurityGroupRulesIngressArgs{
// 					Protocol: pulumi.String("TCP"),
// 					Ports: pulumi.StringArray{
// 						pulumi.String("80"),
// 						pulumi.String("443"),
// 					},
// 					CidrLists: pulumi.StringArray{
// 						pulumi.String("0.0.0.0/0"),
// 						pulumi.String("::/0"),
// 					},
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
type SecurityGroupRules struct {
	pulumi.CustomResourceState

	Egresses  SecurityGroupRulesEgressArrayOutput  `pulumi:"egresses"`
	Ingresses SecurityGroupRulesIngressArrayOutput `pulumi:"ingresses"`
	// The Security Group name the rules apply to (conflicts with `securityGroupId`).
	SecurityGroup pulumi.StringOutput `pulumi:"securityGroup"`
	// The Security Group ID the rules apply to (conficts with `security_group)`.
	// * `ingress`/`egress` - A Security Group rule definition.
	SecurityGroupId pulumi.StringOutput `pulumi:"securityGroupId"`
}

// NewSecurityGroupRules registers a new resource with the given unique name, arguments, and options.
func NewSecurityGroupRules(ctx *pulumi.Context,
	name string, args *SecurityGroupRulesArgs, opts ...pulumi.ResourceOption) (*SecurityGroupRules, error) {
	if args == nil {
		args = &SecurityGroupRulesArgs{}
	}

	var resource SecurityGroupRules
	err := ctx.RegisterResource("exoscale:index/securityGroupRules:SecurityGroupRules", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSecurityGroupRules gets an existing SecurityGroupRules resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSecurityGroupRules(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SecurityGroupRulesState, opts ...pulumi.ResourceOption) (*SecurityGroupRules, error) {
	var resource SecurityGroupRules
	err := ctx.ReadResource("exoscale:index/securityGroupRules:SecurityGroupRules", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SecurityGroupRules resources.
type securityGroupRulesState struct {
	Egresses  []SecurityGroupRulesEgress  `pulumi:"egresses"`
	Ingresses []SecurityGroupRulesIngress `pulumi:"ingresses"`
	// The Security Group name the rules apply to (conflicts with `securityGroupId`).
	SecurityGroup *string `pulumi:"securityGroup"`
	// The Security Group ID the rules apply to (conficts with `security_group)`.
	// * `ingress`/`egress` - A Security Group rule definition.
	SecurityGroupId *string `pulumi:"securityGroupId"`
}

type SecurityGroupRulesState struct {
	Egresses  SecurityGroupRulesEgressArrayInput
	Ingresses SecurityGroupRulesIngressArrayInput
	// The Security Group name the rules apply to (conflicts with `securityGroupId`).
	SecurityGroup pulumi.StringPtrInput
	// The Security Group ID the rules apply to (conficts with `security_group)`.
	// * `ingress`/`egress` - A Security Group rule definition.
	SecurityGroupId pulumi.StringPtrInput
}

func (SecurityGroupRulesState) ElementType() reflect.Type {
	return reflect.TypeOf((*securityGroupRulesState)(nil)).Elem()
}

type securityGroupRulesArgs struct {
	Egresses  []SecurityGroupRulesEgress  `pulumi:"egresses"`
	Ingresses []SecurityGroupRulesIngress `pulumi:"ingresses"`
	// The Security Group name the rules apply to (conflicts with `securityGroupId`).
	SecurityGroup *string `pulumi:"securityGroup"`
	// The Security Group ID the rules apply to (conficts with `security_group)`.
	// * `ingress`/`egress` - A Security Group rule definition.
	SecurityGroupId *string `pulumi:"securityGroupId"`
}

// The set of arguments for constructing a SecurityGroupRules resource.
type SecurityGroupRulesArgs struct {
	Egresses  SecurityGroupRulesEgressArrayInput
	Ingresses SecurityGroupRulesIngressArrayInput
	// The Security Group name the rules apply to (conflicts with `securityGroupId`).
	SecurityGroup pulumi.StringPtrInput
	// The Security Group ID the rules apply to (conficts with `security_group)`.
	// * `ingress`/`egress` - A Security Group rule definition.
	SecurityGroupId pulumi.StringPtrInput
}

func (SecurityGroupRulesArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*securityGroupRulesArgs)(nil)).Elem()
}

type SecurityGroupRulesInput interface {
	pulumi.Input

	ToSecurityGroupRulesOutput() SecurityGroupRulesOutput
	ToSecurityGroupRulesOutputWithContext(ctx context.Context) SecurityGroupRulesOutput
}

func (*SecurityGroupRules) ElementType() reflect.Type {
	return reflect.TypeOf((**SecurityGroupRules)(nil)).Elem()
}

func (i *SecurityGroupRules) ToSecurityGroupRulesOutput() SecurityGroupRulesOutput {
	return i.ToSecurityGroupRulesOutputWithContext(context.Background())
}

func (i *SecurityGroupRules) ToSecurityGroupRulesOutputWithContext(ctx context.Context) SecurityGroupRulesOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SecurityGroupRulesOutput)
}

// SecurityGroupRulesArrayInput is an input type that accepts SecurityGroupRulesArray and SecurityGroupRulesArrayOutput values.
// You can construct a concrete instance of `SecurityGroupRulesArrayInput` via:
//
//          SecurityGroupRulesArray{ SecurityGroupRulesArgs{...} }
type SecurityGroupRulesArrayInput interface {
	pulumi.Input

	ToSecurityGroupRulesArrayOutput() SecurityGroupRulesArrayOutput
	ToSecurityGroupRulesArrayOutputWithContext(context.Context) SecurityGroupRulesArrayOutput
}

type SecurityGroupRulesArray []SecurityGroupRulesInput

func (SecurityGroupRulesArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*SecurityGroupRules)(nil)).Elem()
}

func (i SecurityGroupRulesArray) ToSecurityGroupRulesArrayOutput() SecurityGroupRulesArrayOutput {
	return i.ToSecurityGroupRulesArrayOutputWithContext(context.Background())
}

func (i SecurityGroupRulesArray) ToSecurityGroupRulesArrayOutputWithContext(ctx context.Context) SecurityGroupRulesArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SecurityGroupRulesArrayOutput)
}

// SecurityGroupRulesMapInput is an input type that accepts SecurityGroupRulesMap and SecurityGroupRulesMapOutput values.
// You can construct a concrete instance of `SecurityGroupRulesMapInput` via:
//
//          SecurityGroupRulesMap{ "key": SecurityGroupRulesArgs{...} }
type SecurityGroupRulesMapInput interface {
	pulumi.Input

	ToSecurityGroupRulesMapOutput() SecurityGroupRulesMapOutput
	ToSecurityGroupRulesMapOutputWithContext(context.Context) SecurityGroupRulesMapOutput
}

type SecurityGroupRulesMap map[string]SecurityGroupRulesInput

func (SecurityGroupRulesMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*SecurityGroupRules)(nil)).Elem()
}

func (i SecurityGroupRulesMap) ToSecurityGroupRulesMapOutput() SecurityGroupRulesMapOutput {
	return i.ToSecurityGroupRulesMapOutputWithContext(context.Background())
}

func (i SecurityGroupRulesMap) ToSecurityGroupRulesMapOutputWithContext(ctx context.Context) SecurityGroupRulesMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SecurityGroupRulesMapOutput)
}

type SecurityGroupRulesOutput struct{ *pulumi.OutputState }

func (SecurityGroupRulesOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SecurityGroupRules)(nil)).Elem()
}

func (o SecurityGroupRulesOutput) ToSecurityGroupRulesOutput() SecurityGroupRulesOutput {
	return o
}

func (o SecurityGroupRulesOutput) ToSecurityGroupRulesOutputWithContext(ctx context.Context) SecurityGroupRulesOutput {
	return o
}

type SecurityGroupRulesArrayOutput struct{ *pulumi.OutputState }

func (SecurityGroupRulesArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*SecurityGroupRules)(nil)).Elem()
}

func (o SecurityGroupRulesArrayOutput) ToSecurityGroupRulesArrayOutput() SecurityGroupRulesArrayOutput {
	return o
}

func (o SecurityGroupRulesArrayOutput) ToSecurityGroupRulesArrayOutputWithContext(ctx context.Context) SecurityGroupRulesArrayOutput {
	return o
}

func (o SecurityGroupRulesArrayOutput) Index(i pulumi.IntInput) SecurityGroupRulesOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *SecurityGroupRules {
		return vs[0].([]*SecurityGroupRules)[vs[1].(int)]
	}).(SecurityGroupRulesOutput)
}

type SecurityGroupRulesMapOutput struct{ *pulumi.OutputState }

func (SecurityGroupRulesMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*SecurityGroupRules)(nil)).Elem()
}

func (o SecurityGroupRulesMapOutput) ToSecurityGroupRulesMapOutput() SecurityGroupRulesMapOutput {
	return o
}

func (o SecurityGroupRulesMapOutput) ToSecurityGroupRulesMapOutputWithContext(ctx context.Context) SecurityGroupRulesMapOutput {
	return o
}

func (o SecurityGroupRulesMapOutput) MapIndex(k pulumi.StringInput) SecurityGroupRulesOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *SecurityGroupRules {
		return vs[0].(map[string]*SecurityGroupRules)[vs[1].(string)]
	}).(SecurityGroupRulesOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*SecurityGroupRulesInput)(nil)).Elem(), &SecurityGroupRules{})
	pulumi.RegisterInputType(reflect.TypeOf((*SecurityGroupRulesArrayInput)(nil)).Elem(), SecurityGroupRulesArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*SecurityGroupRulesMapInput)(nil)).Elem(), SecurityGroupRulesMap{})
	pulumi.RegisterOutputType(SecurityGroupRulesOutput{})
	pulumi.RegisterOutputType(SecurityGroupRulesArrayOutput{})
	pulumi.RegisterOutputType(SecurityGroupRulesMapOutput{})
}

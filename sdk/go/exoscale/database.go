// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package exoscale

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides an Exoscale [DBaaS][dbaas-doc] service resource. This can be used to create, modify, and delete database services.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"encoding/json"
//
// 	"github.com/pulumi/pulumi-exoscale/sdk/go/exoscale"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		zone := "ch-dk-2"
// 		tmpJSON0, err := json.Marshal(map[string]interface{}{
// 			"timezone": "Europe/Zurich",
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		json0 := string(tmpJSON0)
// 		pgProd, err := exoscale.NewDatabase(ctx, "pgProd", &exoscale.DatabaseArgs{
// 			Zone:                  pulumi.String(zone),
// 			Type:                  pulumi.String("pg"),
// 			Plan:                  pulumi.String("startup-4"),
// 			MaintenanceDow:        pulumi.String("sunday"),
// 			MaintenanceTime:       pulumi.String("23:00:00"),
// 			TerminationProtection: pulumi.Bool(true),
// 			Pg: &DatabasePgArgs{
// 				Version:        pulumi.String("13"),
// 				BackupSchedule: pulumi.String("04:00"),
// 				IpFilters: pulumi.StringArray{
// 					pulumi.String("1.2.3.4/32"),
// 					pulumi.String("5.6.7.8/32"),
// 				},
// 				PgSettings: pulumi.String(json0),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		ctx.Export("databaseUri", pgProd.Uri)
// 		return nil
// 	})
// }
// ```
//
// ## Import
//
// An existing database service can be imported as a resource by specifying `NAME@ZONE`console
//
// ```sh
//  $ pulumi import exoscale:index/database:Database example my-database@de-fra-1
// ```
//
//  [dbaas-doc]https://community.exoscale.com/documentation/dbaas/ [zone]https://www.exoscale.com/datacenters/
type Database struct {
	pulumi.CustomResourceState

	// The creation date of the database service.
	CreatedAt pulumi.StringOutput `pulumi:"createdAt"`
	// The disk size of the database service.
	DiskSize pulumi.IntOutput `pulumi:"diskSize"`
	// *kafka* database service type specific arguments. Structure is documented below.
	Kafka DatabaseKafkaPtrOutput `pulumi:"kafka"`
	// The day of week to perform the automated database service maintenance (accepted values: `never`, `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`).
	MaintenanceDow pulumi.StringOutput `pulumi:"maintenanceDow"`
	// The time of day to perform the automated database service maintenance (format: `HH:MM:SS`)
	MaintenanceTime pulumi.StringOutput `pulumi:"maintenanceTime"`
	// *mysql* database service type specific arguments. Structure is documented below.
	Mysql DatabaseMysqlPtrOutput `pulumi:"mysql"`
	// The name of the database service.
	Name pulumi.StringOutput `pulumi:"name"`
	// The number of CPUs of the database service.
	NodeCpus pulumi.IntOutput `pulumi:"nodeCpus"`
	// The amount of memory of the database service.
	NodeMemory pulumi.IntOutput `pulumi:"nodeMemory"`
	// The number of nodes of the database service.
	Nodes pulumi.IntOutput `pulumi:"nodes"`
	// *pg* database service type specific arguments. Structure is documented below.
	Pg DatabasePgPtrOutput `pulumi:"pg"`
	// The plan of the database service (`exo dbaas type show <TYPE>` for reference).
	Plan pulumi.StringOutput `pulumi:"plan"`
	// *redis* database service type specific arguments.Structure is documented below.
	Redis DatabaseRedisPtrOutput `pulumi:"redis"`
	// The current state of the database service.
	State pulumi.StringOutput `pulumi:"state"`
	// The database service protection boolean flag against termination/power-off.
	TerminationProtection pulumi.BoolPtrOutput `pulumi:"terminationProtection"`
	// The type of the database service (accepted values: `kafka`, `mysql`, `pg`, `redis`).
	Type pulumi.StringOutput `pulumi:"type"`
	// The date of the latest database service update.
	UpdatedAt pulumi.StringOutput `pulumi:"updatedAt"`
	// The database service connection URI.
	Uri pulumi.StringOutput `pulumi:"uri"`
	// The name of the [zone][zone] to deploy the database service into.
	Zone pulumi.StringOutput `pulumi:"zone"`
}

// NewDatabase registers a new resource with the given unique name, arguments, and options.
func NewDatabase(ctx *pulumi.Context,
	name string, args *DatabaseArgs, opts ...pulumi.ResourceOption) (*Database, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Plan == nil {
		return nil, errors.New("invalid value for required argument 'Plan'")
	}
	if args.Type == nil {
		return nil, errors.New("invalid value for required argument 'Type'")
	}
	if args.Zone == nil {
		return nil, errors.New("invalid value for required argument 'Zone'")
	}
	var resource Database
	err := ctx.RegisterResource("exoscale:index/database:Database", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDatabase gets an existing Database resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDatabase(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DatabaseState, opts ...pulumi.ResourceOption) (*Database, error) {
	var resource Database
	err := ctx.ReadResource("exoscale:index/database:Database", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Database resources.
type databaseState struct {
	// The creation date of the database service.
	CreatedAt *string `pulumi:"createdAt"`
	// The disk size of the database service.
	DiskSize *int `pulumi:"diskSize"`
	// *kafka* database service type specific arguments. Structure is documented below.
	Kafka *DatabaseKafka `pulumi:"kafka"`
	// The day of week to perform the automated database service maintenance (accepted values: `never`, `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`).
	MaintenanceDow *string `pulumi:"maintenanceDow"`
	// The time of day to perform the automated database service maintenance (format: `HH:MM:SS`)
	MaintenanceTime *string `pulumi:"maintenanceTime"`
	// *mysql* database service type specific arguments. Structure is documented below.
	Mysql *DatabaseMysql `pulumi:"mysql"`
	// The name of the database service.
	Name *string `pulumi:"name"`
	// The number of CPUs of the database service.
	NodeCpus *int `pulumi:"nodeCpus"`
	// The amount of memory of the database service.
	NodeMemory *int `pulumi:"nodeMemory"`
	// The number of nodes of the database service.
	Nodes *int `pulumi:"nodes"`
	// *pg* database service type specific arguments. Structure is documented below.
	Pg *DatabasePg `pulumi:"pg"`
	// The plan of the database service (`exo dbaas type show <TYPE>` for reference).
	Plan *string `pulumi:"plan"`
	// *redis* database service type specific arguments.Structure is documented below.
	Redis *DatabaseRedis `pulumi:"redis"`
	// The current state of the database service.
	State *string `pulumi:"state"`
	// The database service protection boolean flag against termination/power-off.
	TerminationProtection *bool `pulumi:"terminationProtection"`
	// The type of the database service (accepted values: `kafka`, `mysql`, `pg`, `redis`).
	Type *string `pulumi:"type"`
	// The date of the latest database service update.
	UpdatedAt *string `pulumi:"updatedAt"`
	// The database service connection URI.
	Uri *string `pulumi:"uri"`
	// The name of the [zone][zone] to deploy the database service into.
	Zone *string `pulumi:"zone"`
}

type DatabaseState struct {
	// The creation date of the database service.
	CreatedAt pulumi.StringPtrInput
	// The disk size of the database service.
	DiskSize pulumi.IntPtrInput
	// *kafka* database service type specific arguments. Structure is documented below.
	Kafka DatabaseKafkaPtrInput
	// The day of week to perform the automated database service maintenance (accepted values: `never`, `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`).
	MaintenanceDow pulumi.StringPtrInput
	// The time of day to perform the automated database service maintenance (format: `HH:MM:SS`)
	MaintenanceTime pulumi.StringPtrInput
	// *mysql* database service type specific arguments. Structure is documented below.
	Mysql DatabaseMysqlPtrInput
	// The name of the database service.
	Name pulumi.StringPtrInput
	// The number of CPUs of the database service.
	NodeCpus pulumi.IntPtrInput
	// The amount of memory of the database service.
	NodeMemory pulumi.IntPtrInput
	// The number of nodes of the database service.
	Nodes pulumi.IntPtrInput
	// *pg* database service type specific arguments. Structure is documented below.
	Pg DatabasePgPtrInput
	// The plan of the database service (`exo dbaas type show <TYPE>` for reference).
	Plan pulumi.StringPtrInput
	// *redis* database service type specific arguments.Structure is documented below.
	Redis DatabaseRedisPtrInput
	// The current state of the database service.
	State pulumi.StringPtrInput
	// The database service protection boolean flag against termination/power-off.
	TerminationProtection pulumi.BoolPtrInput
	// The type of the database service (accepted values: `kafka`, `mysql`, `pg`, `redis`).
	Type pulumi.StringPtrInput
	// The date of the latest database service update.
	UpdatedAt pulumi.StringPtrInput
	// The database service connection URI.
	Uri pulumi.StringPtrInput
	// The name of the [zone][zone] to deploy the database service into.
	Zone pulumi.StringPtrInput
}

func (DatabaseState) ElementType() reflect.Type {
	return reflect.TypeOf((*databaseState)(nil)).Elem()
}

type databaseArgs struct {
	// *kafka* database service type specific arguments. Structure is documented below.
	Kafka *DatabaseKafka `pulumi:"kafka"`
	// The day of week to perform the automated database service maintenance (accepted values: `never`, `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`).
	MaintenanceDow *string `pulumi:"maintenanceDow"`
	// The time of day to perform the automated database service maintenance (format: `HH:MM:SS`)
	MaintenanceTime *string `pulumi:"maintenanceTime"`
	// *mysql* database service type specific arguments. Structure is documented below.
	Mysql *DatabaseMysql `pulumi:"mysql"`
	// The name of the database service.
	Name *string `pulumi:"name"`
	// *pg* database service type specific arguments. Structure is documented below.
	Pg *DatabasePg `pulumi:"pg"`
	// The plan of the database service (`exo dbaas type show <TYPE>` for reference).
	Plan string `pulumi:"plan"`
	// *redis* database service type specific arguments.Structure is documented below.
	Redis *DatabaseRedis `pulumi:"redis"`
	// The database service protection boolean flag against termination/power-off.
	TerminationProtection *bool `pulumi:"terminationProtection"`
	// The type of the database service (accepted values: `kafka`, `mysql`, `pg`, `redis`).
	Type string `pulumi:"type"`
	// The name of the [zone][zone] to deploy the database service into.
	Zone string `pulumi:"zone"`
}

// The set of arguments for constructing a Database resource.
type DatabaseArgs struct {
	// *kafka* database service type specific arguments. Structure is documented below.
	Kafka DatabaseKafkaPtrInput
	// The day of week to perform the automated database service maintenance (accepted values: `never`, `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`).
	MaintenanceDow pulumi.StringPtrInput
	// The time of day to perform the automated database service maintenance (format: `HH:MM:SS`)
	MaintenanceTime pulumi.StringPtrInput
	// *mysql* database service type specific arguments. Structure is documented below.
	Mysql DatabaseMysqlPtrInput
	// The name of the database service.
	Name pulumi.StringPtrInput
	// *pg* database service type specific arguments. Structure is documented below.
	Pg DatabasePgPtrInput
	// The plan of the database service (`exo dbaas type show <TYPE>` for reference).
	Plan pulumi.StringInput
	// *redis* database service type specific arguments.Structure is documented below.
	Redis DatabaseRedisPtrInput
	// The database service protection boolean flag against termination/power-off.
	TerminationProtection pulumi.BoolPtrInput
	// The type of the database service (accepted values: `kafka`, `mysql`, `pg`, `redis`).
	Type pulumi.StringInput
	// The name of the [zone][zone] to deploy the database service into.
	Zone pulumi.StringInput
}

func (DatabaseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*databaseArgs)(nil)).Elem()
}

type DatabaseInput interface {
	pulumi.Input

	ToDatabaseOutput() DatabaseOutput
	ToDatabaseOutputWithContext(ctx context.Context) DatabaseOutput
}

func (*Database) ElementType() reflect.Type {
	return reflect.TypeOf((**Database)(nil)).Elem()
}

func (i *Database) ToDatabaseOutput() DatabaseOutput {
	return i.ToDatabaseOutputWithContext(context.Background())
}

func (i *Database) ToDatabaseOutputWithContext(ctx context.Context) DatabaseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DatabaseOutput)
}

// DatabaseArrayInput is an input type that accepts DatabaseArray and DatabaseArrayOutput values.
// You can construct a concrete instance of `DatabaseArrayInput` via:
//
//          DatabaseArray{ DatabaseArgs{...} }
type DatabaseArrayInput interface {
	pulumi.Input

	ToDatabaseArrayOutput() DatabaseArrayOutput
	ToDatabaseArrayOutputWithContext(context.Context) DatabaseArrayOutput
}

type DatabaseArray []DatabaseInput

func (DatabaseArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Database)(nil)).Elem()
}

func (i DatabaseArray) ToDatabaseArrayOutput() DatabaseArrayOutput {
	return i.ToDatabaseArrayOutputWithContext(context.Background())
}

func (i DatabaseArray) ToDatabaseArrayOutputWithContext(ctx context.Context) DatabaseArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DatabaseArrayOutput)
}

// DatabaseMapInput is an input type that accepts DatabaseMap and DatabaseMapOutput values.
// You can construct a concrete instance of `DatabaseMapInput` via:
//
//          DatabaseMap{ "key": DatabaseArgs{...} }
type DatabaseMapInput interface {
	pulumi.Input

	ToDatabaseMapOutput() DatabaseMapOutput
	ToDatabaseMapOutputWithContext(context.Context) DatabaseMapOutput
}

type DatabaseMap map[string]DatabaseInput

func (DatabaseMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Database)(nil)).Elem()
}

func (i DatabaseMap) ToDatabaseMapOutput() DatabaseMapOutput {
	return i.ToDatabaseMapOutputWithContext(context.Background())
}

func (i DatabaseMap) ToDatabaseMapOutputWithContext(ctx context.Context) DatabaseMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DatabaseMapOutput)
}

type DatabaseOutput struct{ *pulumi.OutputState }

func (DatabaseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Database)(nil)).Elem()
}

func (o DatabaseOutput) ToDatabaseOutput() DatabaseOutput {
	return o
}

func (o DatabaseOutput) ToDatabaseOutputWithContext(ctx context.Context) DatabaseOutput {
	return o
}

type DatabaseArrayOutput struct{ *pulumi.OutputState }

func (DatabaseArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Database)(nil)).Elem()
}

func (o DatabaseArrayOutput) ToDatabaseArrayOutput() DatabaseArrayOutput {
	return o
}

func (o DatabaseArrayOutput) ToDatabaseArrayOutputWithContext(ctx context.Context) DatabaseArrayOutput {
	return o
}

func (o DatabaseArrayOutput) Index(i pulumi.IntInput) DatabaseOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Database {
		return vs[0].([]*Database)[vs[1].(int)]
	}).(DatabaseOutput)
}

type DatabaseMapOutput struct{ *pulumi.OutputState }

func (DatabaseMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Database)(nil)).Elem()
}

func (o DatabaseMapOutput) ToDatabaseMapOutput() DatabaseMapOutput {
	return o
}

func (o DatabaseMapOutput) ToDatabaseMapOutputWithContext(ctx context.Context) DatabaseMapOutput {
	return o
}

func (o DatabaseMapOutput) MapIndex(k pulumi.StringInput) DatabaseOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Database {
		return vs[0].(map[string]*Database)[vs[1].(string)]
	}).(DatabaseOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DatabaseInput)(nil)).Elem(), &Database{})
	pulumi.RegisterInputType(reflect.TypeOf((*DatabaseArrayInput)(nil)).Elem(), DatabaseArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*DatabaseMapInput)(nil)).Elem(), DatabaseMap{})
	pulumi.RegisterOutputType(DatabaseOutput{})
	pulumi.RegisterOutputType(DatabaseArrayOutput{})
	pulumi.RegisterOutputType(DatabaseMapOutput{})
}

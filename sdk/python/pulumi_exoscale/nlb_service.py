# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities
from . import outputs
from ._inputs import *

__all__ = ['NLBServiceArgs', 'NLBService']

@pulumi.input_type
class NLBServiceArgs:
    def __init__(__self__, *,
                 healthchecks: pulumi.Input[Sequence[pulumi.Input['NLBServiceHealthcheckArgs']]],
                 instance_pool_id: pulumi.Input[str],
                 nlb_id: pulumi.Input[str],
                 port: pulumi.Input[int],
                 target_port: pulumi.Input[int],
                 zone: pulumi.Input[str],
                 description: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 protocol: Optional[pulumi.Input[str]] = None,
                 strategy: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a NLBService resource.
        :param pulumi.Input[str] instance_pool_id: The ID of the Instance Pool to forward network traffic to.
        :param pulumi.Input[str] nlb_id: The ID of the NLB to attach the service.
        :param pulumi.Input[int] port: The healthcheck port.
        :param pulumi.Input[int] target_port: The port to forward network traffic to on target instances.
        :param pulumi.Input[str] zone: The name of the [zone][zone] used by the NLB.
        :param pulumi.Input[str] description: The description of the NLB service.
        :param pulumi.Input[str] name: The name of the NLB service.
        :param pulumi.Input[str] protocol: The protocol (tcp/udp).
        :param pulumi.Input[str] strategy: The strategy (round-robin/source-hash).
        """
        pulumi.set(__self__, "healthchecks", healthchecks)
        pulumi.set(__self__, "instance_pool_id", instance_pool_id)
        pulumi.set(__self__, "nlb_id", nlb_id)
        pulumi.set(__self__, "port", port)
        pulumi.set(__self__, "target_port", target_port)
        pulumi.set(__self__, "zone", zone)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if protocol is not None:
            pulumi.set(__self__, "protocol", protocol)
        if strategy is not None:
            pulumi.set(__self__, "strategy", strategy)

    @property
    @pulumi.getter
    def healthchecks(self) -> pulumi.Input[Sequence[pulumi.Input['NLBServiceHealthcheckArgs']]]:
        return pulumi.get(self, "healthchecks")

    @healthchecks.setter
    def healthchecks(self, value: pulumi.Input[Sequence[pulumi.Input['NLBServiceHealthcheckArgs']]]):
        pulumi.set(self, "healthchecks", value)

    @property
    @pulumi.getter(name="instancePoolId")
    def instance_pool_id(self) -> pulumi.Input[str]:
        """
        The ID of the Instance Pool to forward network traffic to.
        """
        return pulumi.get(self, "instance_pool_id")

    @instance_pool_id.setter
    def instance_pool_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "instance_pool_id", value)

    @property
    @pulumi.getter(name="nlbId")
    def nlb_id(self) -> pulumi.Input[str]:
        """
        The ID of the NLB to attach the service.
        """
        return pulumi.get(self, "nlb_id")

    @nlb_id.setter
    def nlb_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "nlb_id", value)

    @property
    @pulumi.getter
    def port(self) -> pulumi.Input[int]:
        """
        The healthcheck port.
        """
        return pulumi.get(self, "port")

    @port.setter
    def port(self, value: pulumi.Input[int]):
        pulumi.set(self, "port", value)

    @property
    @pulumi.getter(name="targetPort")
    def target_port(self) -> pulumi.Input[int]:
        """
        The port to forward network traffic to on target instances.
        """
        return pulumi.get(self, "target_port")

    @target_port.setter
    def target_port(self, value: pulumi.Input[int]):
        pulumi.set(self, "target_port", value)

    @property
    @pulumi.getter
    def zone(self) -> pulumi.Input[str]:
        """
        The name of the [zone][zone] used by the NLB.
        """
        return pulumi.get(self, "zone")

    @zone.setter
    def zone(self, value: pulumi.Input[str]):
        pulumi.set(self, "zone", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        The description of the NLB service.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the NLB service.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def protocol(self) -> Optional[pulumi.Input[str]]:
        """
        The protocol (tcp/udp).
        """
        return pulumi.get(self, "protocol")

    @protocol.setter
    def protocol(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "protocol", value)

    @property
    @pulumi.getter
    def strategy(self) -> Optional[pulumi.Input[str]]:
        """
        The strategy (round-robin/source-hash).
        """
        return pulumi.get(self, "strategy")

    @strategy.setter
    def strategy(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "strategy", value)


@pulumi.input_type
class _NLBServiceState:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None,
                 healthchecks: Optional[pulumi.Input[Sequence[pulumi.Input['NLBServiceHealthcheckArgs']]]] = None,
                 instance_pool_id: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 nlb_id: Optional[pulumi.Input[str]] = None,
                 port: Optional[pulumi.Input[int]] = None,
                 protocol: Optional[pulumi.Input[str]] = None,
                 state: Optional[pulumi.Input[str]] = None,
                 strategy: Optional[pulumi.Input[str]] = None,
                 target_port: Optional[pulumi.Input[int]] = None,
                 zone: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering NLBService resources.
        :param pulumi.Input[str] description: The description of the NLB service.
        :param pulumi.Input[str] instance_pool_id: The ID of the Instance Pool to forward network traffic to.
        :param pulumi.Input[str] name: The name of the NLB service.
        :param pulumi.Input[str] nlb_id: The ID of the NLB to attach the service.
        :param pulumi.Input[int] port: The healthcheck port.
        :param pulumi.Input[str] protocol: The protocol (tcp/udp).
        :param pulumi.Input[str] strategy: The strategy (round-robin/source-hash).
        :param pulumi.Input[int] target_port: The port to forward network traffic to on target instances.
        :param pulumi.Input[str] zone: The name of the [zone][zone] used by the NLB.
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if healthchecks is not None:
            pulumi.set(__self__, "healthchecks", healthchecks)
        if instance_pool_id is not None:
            pulumi.set(__self__, "instance_pool_id", instance_pool_id)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if nlb_id is not None:
            pulumi.set(__self__, "nlb_id", nlb_id)
        if port is not None:
            pulumi.set(__self__, "port", port)
        if protocol is not None:
            pulumi.set(__self__, "protocol", protocol)
        if state is not None:
            pulumi.set(__self__, "state", state)
        if strategy is not None:
            pulumi.set(__self__, "strategy", strategy)
        if target_port is not None:
            pulumi.set(__self__, "target_port", target_port)
        if zone is not None:
            pulumi.set(__self__, "zone", zone)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        The description of the NLB service.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def healthchecks(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NLBServiceHealthcheckArgs']]]]:
        return pulumi.get(self, "healthchecks")

    @healthchecks.setter
    def healthchecks(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NLBServiceHealthcheckArgs']]]]):
        pulumi.set(self, "healthchecks", value)

    @property
    @pulumi.getter(name="instancePoolId")
    def instance_pool_id(self) -> Optional[pulumi.Input[str]]:
        """
        The ID of the Instance Pool to forward network traffic to.
        """
        return pulumi.get(self, "instance_pool_id")

    @instance_pool_id.setter
    def instance_pool_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_pool_id", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the NLB service.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="nlbId")
    def nlb_id(self) -> Optional[pulumi.Input[str]]:
        """
        The ID of the NLB to attach the service.
        """
        return pulumi.get(self, "nlb_id")

    @nlb_id.setter
    def nlb_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "nlb_id", value)

    @property
    @pulumi.getter
    def port(self) -> Optional[pulumi.Input[int]]:
        """
        The healthcheck port.
        """
        return pulumi.get(self, "port")

    @port.setter
    def port(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "port", value)

    @property
    @pulumi.getter
    def protocol(self) -> Optional[pulumi.Input[str]]:
        """
        The protocol (tcp/udp).
        """
        return pulumi.get(self, "protocol")

    @protocol.setter
    def protocol(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "protocol", value)

    @property
    @pulumi.getter
    def state(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "state")

    @state.setter
    def state(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "state", value)

    @property
    @pulumi.getter
    def strategy(self) -> Optional[pulumi.Input[str]]:
        """
        The strategy (round-robin/source-hash).
        """
        return pulumi.get(self, "strategy")

    @strategy.setter
    def strategy(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "strategy", value)

    @property
    @pulumi.getter(name="targetPort")
    def target_port(self) -> Optional[pulumi.Input[int]]:
        """
        The port to forward network traffic to on target instances.
        """
        return pulumi.get(self, "target_port")

    @target_port.setter
    def target_port(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "target_port", value)

    @property
    @pulumi.getter
    def zone(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the [zone][zone] used by the NLB.
        """
        return pulumi.get(self, "zone")

    @zone.setter
    def zone(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "zone", value)


class NLBService(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 healthchecks: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NLBServiceHealthcheckArgs']]]]] = None,
                 instance_pool_id: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 nlb_id: Optional[pulumi.Input[str]] = None,
                 port: Optional[pulumi.Input[int]] = None,
                 protocol: Optional[pulumi.Input[str]] = None,
                 strategy: Optional[pulumi.Input[str]] = None,
                 target_port: Optional[pulumi.Input[int]] = None,
                 zone: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides an Exoscale Network Load Balancer ([NLB][r-nlb]) service resource. This can be used to create, modify, and delete NLB services.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_exoscale as exoscale

        config = pulumi.Config()
        zone = config.get("zone")
        if zone is None:
            zone = "de-fra-1"
        template = config.get("template")
        if template is None:
            template = "Linux Ubuntu 20.04 LTS 64-bit"
        website_compute_template = exoscale.get_compute_template(zone=zone,
            name=template)
        website_instance_pool = exoscale.InstancePool("websiteInstancePool",
            description="Instance Pool Website nodes",
            template_id=website_compute_template.id,
            service_offering="medium",
            size=3,
            zone=zone)
        website_nlb = exoscale.NLB("websiteNLB",
            description="This is the Network Load Balancer for my website",
            zone=zone)
        website_nlb_service = exoscale.NLBService("websiteNLBService",
            zone=website_nlb.zone,
            description="Website over HTTPS",
            nlb_id=website_nlb.id,
            instance_pool_id=website_instance_pool.id,
            protocol="tcp",
            port=443,
            target_port=8443,
            strategy="round-robin",
            healthchecks=[exoscale.NLBServiceHealthcheckArgs(
                mode="https",
                port=8443,
                uri="/healthz",
                tls_sni="example.net",
                interval=5,
                timeout=3,
                retries=1,
            )])
        ```

        ## Import

        An existing NLB service can be imported as a resource by `<NLB-ID>/<SERVICE-ID>@<ZONE>`console

        ```sh
         $ pulumi import exoscale:index/nLBService:NLBService example eb556678-ec59-4be6-8c54-0406ae0f6da6/9ecc6b8b-73d4-4211-8ced-f7f29bb79524@de-fra-1
        ```

         [r-nlb]nlb.html [zone]https://www.exoscale.com/datacenters/

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: The description of the NLB service.
        :param pulumi.Input[str] instance_pool_id: The ID of the Instance Pool to forward network traffic to.
        :param pulumi.Input[str] name: The name of the NLB service.
        :param pulumi.Input[str] nlb_id: The ID of the NLB to attach the service.
        :param pulumi.Input[int] port: The healthcheck port.
        :param pulumi.Input[str] protocol: The protocol (tcp/udp).
        :param pulumi.Input[str] strategy: The strategy (round-robin/source-hash).
        :param pulumi.Input[int] target_port: The port to forward network traffic to on target instances.
        :param pulumi.Input[str] zone: The name of the [zone][zone] used by the NLB.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: NLBServiceArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides an Exoscale Network Load Balancer ([NLB][r-nlb]) service resource. This can be used to create, modify, and delete NLB services.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_exoscale as exoscale

        config = pulumi.Config()
        zone = config.get("zone")
        if zone is None:
            zone = "de-fra-1"
        template = config.get("template")
        if template is None:
            template = "Linux Ubuntu 20.04 LTS 64-bit"
        website_compute_template = exoscale.get_compute_template(zone=zone,
            name=template)
        website_instance_pool = exoscale.InstancePool("websiteInstancePool",
            description="Instance Pool Website nodes",
            template_id=website_compute_template.id,
            service_offering="medium",
            size=3,
            zone=zone)
        website_nlb = exoscale.NLB("websiteNLB",
            description="This is the Network Load Balancer for my website",
            zone=zone)
        website_nlb_service = exoscale.NLBService("websiteNLBService",
            zone=website_nlb.zone,
            description="Website over HTTPS",
            nlb_id=website_nlb.id,
            instance_pool_id=website_instance_pool.id,
            protocol="tcp",
            port=443,
            target_port=8443,
            strategy="round-robin",
            healthchecks=[exoscale.NLBServiceHealthcheckArgs(
                mode="https",
                port=8443,
                uri="/healthz",
                tls_sni="example.net",
                interval=5,
                timeout=3,
                retries=1,
            )])
        ```

        ## Import

        An existing NLB service can be imported as a resource by `<NLB-ID>/<SERVICE-ID>@<ZONE>`console

        ```sh
         $ pulumi import exoscale:index/nLBService:NLBService example eb556678-ec59-4be6-8c54-0406ae0f6da6/9ecc6b8b-73d4-4211-8ced-f7f29bb79524@de-fra-1
        ```

         [r-nlb]nlb.html [zone]https://www.exoscale.com/datacenters/

        :param str resource_name: The name of the resource.
        :param NLBServiceArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(NLBServiceArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 healthchecks: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NLBServiceHealthcheckArgs']]]]] = None,
                 instance_pool_id: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 nlb_id: Optional[pulumi.Input[str]] = None,
                 port: Optional[pulumi.Input[int]] = None,
                 protocol: Optional[pulumi.Input[str]] = None,
                 strategy: Optional[pulumi.Input[str]] = None,
                 target_port: Optional[pulumi.Input[int]] = None,
                 zone: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = NLBServiceArgs.__new__(NLBServiceArgs)

            __props__.__dict__["description"] = description
            if healthchecks is None and not opts.urn:
                raise TypeError("Missing required property 'healthchecks'")
            __props__.__dict__["healthchecks"] = healthchecks
            if instance_pool_id is None and not opts.urn:
                raise TypeError("Missing required property 'instance_pool_id'")
            __props__.__dict__["instance_pool_id"] = instance_pool_id
            __props__.__dict__["name"] = name
            if nlb_id is None and not opts.urn:
                raise TypeError("Missing required property 'nlb_id'")
            __props__.__dict__["nlb_id"] = nlb_id
            if port is None and not opts.urn:
                raise TypeError("Missing required property 'port'")
            __props__.__dict__["port"] = port
            __props__.__dict__["protocol"] = protocol
            __props__.__dict__["strategy"] = strategy
            if target_port is None and not opts.urn:
                raise TypeError("Missing required property 'target_port'")
            __props__.__dict__["target_port"] = target_port
            if zone is None and not opts.urn:
                raise TypeError("Missing required property 'zone'")
            __props__.__dict__["zone"] = zone
            __props__.__dict__["state"] = None
        super(NLBService, __self__).__init__(
            'exoscale:index/nLBService:NLBService',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            description: Optional[pulumi.Input[str]] = None,
            healthchecks: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NLBServiceHealthcheckArgs']]]]] = None,
            instance_pool_id: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            nlb_id: Optional[pulumi.Input[str]] = None,
            port: Optional[pulumi.Input[int]] = None,
            protocol: Optional[pulumi.Input[str]] = None,
            state: Optional[pulumi.Input[str]] = None,
            strategy: Optional[pulumi.Input[str]] = None,
            target_port: Optional[pulumi.Input[int]] = None,
            zone: Optional[pulumi.Input[str]] = None) -> 'NLBService':
        """
        Get an existing NLBService resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: The description of the NLB service.
        :param pulumi.Input[str] instance_pool_id: The ID of the Instance Pool to forward network traffic to.
        :param pulumi.Input[str] name: The name of the NLB service.
        :param pulumi.Input[str] nlb_id: The ID of the NLB to attach the service.
        :param pulumi.Input[int] port: The healthcheck port.
        :param pulumi.Input[str] protocol: The protocol (tcp/udp).
        :param pulumi.Input[str] strategy: The strategy (round-robin/source-hash).
        :param pulumi.Input[int] target_port: The port to forward network traffic to on target instances.
        :param pulumi.Input[str] zone: The name of the [zone][zone] used by the NLB.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _NLBServiceState.__new__(_NLBServiceState)

        __props__.__dict__["description"] = description
        __props__.__dict__["healthchecks"] = healthchecks
        __props__.__dict__["instance_pool_id"] = instance_pool_id
        __props__.__dict__["name"] = name
        __props__.__dict__["nlb_id"] = nlb_id
        __props__.__dict__["port"] = port
        __props__.__dict__["protocol"] = protocol
        __props__.__dict__["state"] = state
        __props__.__dict__["strategy"] = strategy
        __props__.__dict__["target_port"] = target_port
        __props__.__dict__["zone"] = zone
        return NLBService(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        The description of the NLB service.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def healthchecks(self) -> pulumi.Output[Sequence['outputs.NLBServiceHealthcheck']]:
        return pulumi.get(self, "healthchecks")

    @property
    @pulumi.getter(name="instancePoolId")
    def instance_pool_id(self) -> pulumi.Output[str]:
        """
        The ID of the Instance Pool to forward network traffic to.
        """
        return pulumi.get(self, "instance_pool_id")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the NLB service.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="nlbId")
    def nlb_id(self) -> pulumi.Output[str]:
        """
        The ID of the NLB to attach the service.
        """
        return pulumi.get(self, "nlb_id")

    @property
    @pulumi.getter
    def port(self) -> pulumi.Output[int]:
        """
        The healthcheck port.
        """
        return pulumi.get(self, "port")

    @property
    @pulumi.getter
    def protocol(self) -> pulumi.Output[Optional[str]]:
        """
        The protocol (tcp/udp).
        """
        return pulumi.get(self, "protocol")

    @property
    @pulumi.getter
    def state(self) -> pulumi.Output[str]:
        return pulumi.get(self, "state")

    @property
    @pulumi.getter
    def strategy(self) -> pulumi.Output[Optional[str]]:
        """
        The strategy (round-robin/source-hash).
        """
        return pulumi.get(self, "strategy")

    @property
    @pulumi.getter(name="targetPort")
    def target_port(self) -> pulumi.Output[int]:
        """
        The port to forward network traffic to on target instances.
        """
        return pulumi.get(self, "target_port")

    @property
    @pulumi.getter
    def zone(self) -> pulumi.Output[str]:
        """
        The name of the [zone][zone] used by the NLB.
        """
        return pulumi.get(self, "zone")


# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = [
    'GetComputeResult',
    'AwaitableGetComputeResult',
    'get_compute',
    'get_compute_output',
]

@pulumi.output_type
class GetComputeResult:
    """
    A collection of values returned by getCompute.
    """
    def __init__(__self__, cpu=None, created=None, disk_size=None, hostname=None, id=None, ip6_address=None, ip_address=None, memory=None, private_network_ip_addresses=None, size=None, state=None, tags=None, template=None, zone=None):
        if cpu and not isinstance(cpu, int):
            raise TypeError("Expected argument 'cpu' to be a int")
        pulumi.set(__self__, "cpu", cpu)
        if created and not isinstance(created, str):
            raise TypeError("Expected argument 'created' to be a str")
        pulumi.set(__self__, "created", created)
        if disk_size and not isinstance(disk_size, int):
            raise TypeError("Expected argument 'disk_size' to be a int")
        pulumi.set(__self__, "disk_size", disk_size)
        if hostname and not isinstance(hostname, str):
            raise TypeError("Expected argument 'hostname' to be a str")
        pulumi.set(__self__, "hostname", hostname)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if ip6_address and not isinstance(ip6_address, str):
            raise TypeError("Expected argument 'ip6_address' to be a str")
        pulumi.set(__self__, "ip6_address", ip6_address)
        if ip_address and not isinstance(ip_address, str):
            raise TypeError("Expected argument 'ip_address' to be a str")
        pulumi.set(__self__, "ip_address", ip_address)
        if memory and not isinstance(memory, int):
            raise TypeError("Expected argument 'memory' to be a int")
        pulumi.set(__self__, "memory", memory)
        if private_network_ip_addresses and not isinstance(private_network_ip_addresses, list):
            raise TypeError("Expected argument 'private_network_ip_addresses' to be a list")
        pulumi.set(__self__, "private_network_ip_addresses", private_network_ip_addresses)
        if size and not isinstance(size, str):
            raise TypeError("Expected argument 'size' to be a str")
        pulumi.set(__self__, "size", size)
        if state and not isinstance(state, str):
            raise TypeError("Expected argument 'state' to be a str")
        pulumi.set(__self__, "state", state)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)
        if template and not isinstance(template, str):
            raise TypeError("Expected argument 'template' to be a str")
        pulumi.set(__self__, "template", template)
        if zone and not isinstance(zone, str):
            raise TypeError("Expected argument 'zone' to be a str")
        pulumi.set(__self__, "zone", zone)

    @property
    @pulumi.getter
    def cpu(self) -> int:
        """
        Number of cpu the Compute instance is running with.
        """
        return pulumi.get(self, "cpu")

    @property
    @pulumi.getter
    def created(self) -> str:
        """
        Creation date of the Compute instance.
        """
        return pulumi.get(self, "created")

    @property
    @pulumi.getter(name="diskSize")
    def disk_size(self) -> int:
        """
        Size of the Compute instance disk.
        """
        return pulumi.get(self, "disk_size")

    @property
    @pulumi.getter
    def hostname(self) -> Optional[str]:
        return pulumi.get(self, "hostname")

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="ip6Address")
    def ip6_address(self) -> str:
        """
        Public IPv6 address of the Compute instance (if IPv6 is enabled).
        """
        return pulumi.get(self, "ip6_address")

    @property
    @pulumi.getter(name="ipAddress")
    def ip_address(self) -> str:
        """
        Public IPv4 address of the Compute instance.
        """
        return pulumi.get(self, "ip_address")

    @property
    @pulumi.getter
    def memory(self) -> int:
        """
        Memory allocated for the Compute instance.
        """
        return pulumi.get(self, "memory")

    @property
    @pulumi.getter(name="privateNetworkIpAddresses")
    def private_network_ip_addresses(self) -> Sequence[str]:
        """
        List of Compute private IP addresses (in managed Private Networks only).
        """
        return pulumi.get(self, "private_network_ip_addresses")

    @property
    @pulumi.getter
    def size(self) -> str:
        """
        Current size of the Compute instance.
        """
        return pulumi.get(self, "size")

    @property
    @pulumi.getter
    def state(self) -> str:
        """
        State of the Compute instance.
        """
        return pulumi.get(self, "state")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Mapping[str, str]]:
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def template(self) -> str:
        """
        Name of the template.
        """
        return pulumi.get(self, "template")

    @property
    @pulumi.getter
    def zone(self) -> str:
        """
        Name of the zone.
        """
        return pulumi.get(self, "zone")


class AwaitableGetComputeResult(GetComputeResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetComputeResult(
            cpu=self.cpu,
            created=self.created,
            disk_size=self.disk_size,
            hostname=self.hostname,
            id=self.id,
            ip6_address=self.ip6_address,
            ip_address=self.ip_address,
            memory=self.memory,
            private_network_ip_addresses=self.private_network_ip_addresses,
            size=self.size,
            state=self.state,
            tags=self.tags,
            template=self.template,
            zone=self.zone)


def get_compute(hostname: Optional[str] = None,
                id: Optional[str] = None,
                tags: Optional[Mapping[str, str]] = None,
                opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetComputeResult:
    """
    Provides information on an [Exoscale Compute instance][compute-doc].

    !> **WARNING:** This data source is deprecated and will be removed in the next major version.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_exoscale as exoscale

    my_server = exoscale.get_compute(hostname="my server")
    ```


    :param str hostname: The hostname of the Compute instance.
    :param str id: The ID of the Compute instance.
    :param Mapping[str, str] tags: The tags to find the Compute instance (key: value).
    """
    __args__ = dict()
    __args__['hostname'] = hostname
    __args__['id'] = id
    __args__['tags'] = tags
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('exoscale:index/getCompute:getCompute', __args__, opts=opts, typ=GetComputeResult).value

    return AwaitableGetComputeResult(
        cpu=__ret__.cpu,
        created=__ret__.created,
        disk_size=__ret__.disk_size,
        hostname=__ret__.hostname,
        id=__ret__.id,
        ip6_address=__ret__.ip6_address,
        ip_address=__ret__.ip_address,
        memory=__ret__.memory,
        private_network_ip_addresses=__ret__.private_network_ip_addresses,
        size=__ret__.size,
        state=__ret__.state,
        tags=__ret__.tags,
        template=__ret__.template,
        zone=__ret__.zone)


@_utilities.lift_output_func(get_compute)
def get_compute_output(hostname: Optional[pulumi.Input[Optional[str]]] = None,
                       id: Optional[pulumi.Input[Optional[str]]] = None,
                       tags: Optional[pulumi.Input[Optional[Mapping[str, str]]]] = None,
                       opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetComputeResult]:
    """
    Provides information on an [Exoscale Compute instance][compute-doc].

    !> **WARNING:** This data source is deprecated and will be removed in the next major version.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_exoscale as exoscale

    my_server = exoscale.get_compute(hostname="my server")
    ```


    :param str hostname: The hostname of the Compute instance.
    :param str id: The ID of the Compute instance.
    :param Mapping[str, str] tags: The tags to find the Compute instance (key: value).
    """
    ...
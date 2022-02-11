# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['ProviderArgs', 'Provider']

@pulumi.input_type
class ProviderArgs:
    def __init__(__self__, *,
                 dns_endpoint: pulumi.Input[str],
                 timeout: pulumi.Input[float],
                 compute_endpoint: Optional[pulumi.Input[str]] = None,
                 config: Optional[pulumi.Input[str]] = None,
                 delay: Optional[pulumi.Input[int]] = None,
                 environment: Optional[pulumi.Input[str]] = None,
                 gzip_user_data: Optional[pulumi.Input[bool]] = None,
                 key: Optional[pulumi.Input[str]] = None,
                 profile: Optional[pulumi.Input[str]] = None,
                 region: Optional[pulumi.Input[str]] = None,
                 secret: Optional[pulumi.Input[str]] = None,
                 token: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a Provider resource.
        :param pulumi.Input[str] dns_endpoint: Exoscale DNS API endpoint (by default: https://api.exoscale.com/dns)
        :param pulumi.Input[float] timeout: Timeout in seconds for waiting on compute resources to become available (by default: 300)
        :param pulumi.Input[str] compute_endpoint: Exoscale CloudStack API endpoint (by default: https://api.exoscale.com/v1)
        :param pulumi.Input[str] config: CloudStack ini configuration filename (by default: cloudstack.ini)
        :param pulumi.Input[bool] gzip_user_data: Defines if the user-data of compute instances should be gzipped (by default: true)
        :param pulumi.Input[str] key: Exoscale API key
        :param pulumi.Input[str] region: CloudStack ini configuration section name (by default: cloudstack)
        :param pulumi.Input[str] secret: Exoscale API secret
        """
        pulumi.set(__self__, "dns_endpoint", dns_endpoint)
        pulumi.set(__self__, "timeout", timeout)
        if compute_endpoint is not None:
            pulumi.set(__self__, "compute_endpoint", compute_endpoint)
        if config is not None:
            pulumi.set(__self__, "config", config)
        if delay is not None:
            warnings.warn("""Does nothing""", DeprecationWarning)
            pulumi.log.warn("""delay is deprecated: Does nothing""")
        if delay is not None:
            pulumi.set(__self__, "delay", delay)
        if environment is not None:
            pulumi.set(__self__, "environment", environment)
        if gzip_user_data is not None:
            pulumi.set(__self__, "gzip_user_data", gzip_user_data)
        if key is not None:
            pulumi.set(__self__, "key", key)
        if profile is not None:
            warnings.warn("""Use region instead""", DeprecationWarning)
            pulumi.log.warn("""profile is deprecated: Use region instead""")
        if profile is not None:
            pulumi.set(__self__, "profile", profile)
        if region is not None:
            pulumi.set(__self__, "region", region)
        if secret is not None:
            pulumi.set(__self__, "secret", secret)
        if token is not None:
            warnings.warn("""Use key instead""", DeprecationWarning)
            pulumi.log.warn("""token is deprecated: Use key instead""")
        if token is not None:
            pulumi.set(__self__, "token", token)

    @property
    @pulumi.getter(name="dnsEndpoint")
    def dns_endpoint(self) -> pulumi.Input[str]:
        """
        Exoscale DNS API endpoint (by default: https://api.exoscale.com/dns)
        """
        return pulumi.get(self, "dns_endpoint")

    @dns_endpoint.setter
    def dns_endpoint(self, value: pulumi.Input[str]):
        pulumi.set(self, "dns_endpoint", value)

    @property
    @pulumi.getter
    def timeout(self) -> pulumi.Input[float]:
        """
        Timeout in seconds for waiting on compute resources to become available (by default: 300)
        """
        return pulumi.get(self, "timeout")

    @timeout.setter
    def timeout(self, value: pulumi.Input[float]):
        pulumi.set(self, "timeout", value)

    @property
    @pulumi.getter(name="computeEndpoint")
    def compute_endpoint(self) -> Optional[pulumi.Input[str]]:
        """
        Exoscale CloudStack API endpoint (by default: https://api.exoscale.com/v1)
        """
        return pulumi.get(self, "compute_endpoint")

    @compute_endpoint.setter
    def compute_endpoint(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "compute_endpoint", value)

    @property
    @pulumi.getter
    def config(self) -> Optional[pulumi.Input[str]]:
        """
        CloudStack ini configuration filename (by default: cloudstack.ini)
        """
        return pulumi.get(self, "config")

    @config.setter
    def config(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "config", value)

    @property
    @pulumi.getter
    def delay(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "delay")

    @delay.setter
    def delay(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "delay", value)

    @property
    @pulumi.getter
    def environment(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "environment")

    @environment.setter
    def environment(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "environment", value)

    @property
    @pulumi.getter(name="gzipUserData")
    def gzip_user_data(self) -> Optional[pulumi.Input[bool]]:
        """
        Defines if the user-data of compute instances should be gzipped (by default: true)
        """
        return pulumi.get(self, "gzip_user_data")

    @gzip_user_data.setter
    def gzip_user_data(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "gzip_user_data", value)

    @property
    @pulumi.getter
    def key(self) -> Optional[pulumi.Input[str]]:
        """
        Exoscale API key
        """
        return pulumi.get(self, "key")

    @key.setter
    def key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key", value)

    @property
    @pulumi.getter
    def profile(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "profile")

    @profile.setter
    def profile(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "profile", value)

    @property
    @pulumi.getter
    def region(self) -> Optional[pulumi.Input[str]]:
        """
        CloudStack ini configuration section name (by default: cloudstack)
        """
        return pulumi.get(self, "region")

    @region.setter
    def region(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "region", value)

    @property
    @pulumi.getter
    def secret(self) -> Optional[pulumi.Input[str]]:
        """
        Exoscale API secret
        """
        return pulumi.get(self, "secret")

    @secret.setter
    def secret(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "secret", value)

    @property
    @pulumi.getter
    def token(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "token")

    @token.setter
    def token(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "token", value)


class Provider(pulumi.ProviderResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 compute_endpoint: Optional[pulumi.Input[str]] = None,
                 config: Optional[pulumi.Input[str]] = None,
                 delay: Optional[pulumi.Input[int]] = None,
                 dns_endpoint: Optional[pulumi.Input[str]] = None,
                 environment: Optional[pulumi.Input[str]] = None,
                 gzip_user_data: Optional[pulumi.Input[bool]] = None,
                 key: Optional[pulumi.Input[str]] = None,
                 profile: Optional[pulumi.Input[str]] = None,
                 region: Optional[pulumi.Input[str]] = None,
                 secret: Optional[pulumi.Input[str]] = None,
                 timeout: Optional[pulumi.Input[float]] = None,
                 token: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        The provider type for the exoscale package. By default, resources use package-wide configuration
        settings, however an explicit `Provider` instance may be created and passed during resource
        construction to achieve fine-grained programmatic control over provider settings. See the
        [documentation](https://www.pulumi.com/docs/reference/programming-model/#providers) for more information.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] compute_endpoint: Exoscale CloudStack API endpoint (by default: https://api.exoscale.com/v1)
        :param pulumi.Input[str] config: CloudStack ini configuration filename (by default: cloudstack.ini)
        :param pulumi.Input[str] dns_endpoint: Exoscale DNS API endpoint (by default: https://api.exoscale.com/dns)
        :param pulumi.Input[bool] gzip_user_data: Defines if the user-data of compute instances should be gzipped (by default: true)
        :param pulumi.Input[str] key: Exoscale API key
        :param pulumi.Input[str] region: CloudStack ini configuration section name (by default: cloudstack)
        :param pulumi.Input[str] secret: Exoscale API secret
        :param pulumi.Input[float] timeout: Timeout in seconds for waiting on compute resources to become available (by default: 300)
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ProviderArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        The provider type for the exoscale package. By default, resources use package-wide configuration
        settings, however an explicit `Provider` instance may be created and passed during resource
        construction to achieve fine-grained programmatic control over provider settings. See the
        [documentation](https://www.pulumi.com/docs/reference/programming-model/#providers) for more information.

        :param str resource_name: The name of the resource.
        :param ProviderArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ProviderArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 compute_endpoint: Optional[pulumi.Input[str]] = None,
                 config: Optional[pulumi.Input[str]] = None,
                 delay: Optional[pulumi.Input[int]] = None,
                 dns_endpoint: Optional[pulumi.Input[str]] = None,
                 environment: Optional[pulumi.Input[str]] = None,
                 gzip_user_data: Optional[pulumi.Input[bool]] = None,
                 key: Optional[pulumi.Input[str]] = None,
                 profile: Optional[pulumi.Input[str]] = None,
                 region: Optional[pulumi.Input[str]] = None,
                 secret: Optional[pulumi.Input[str]] = None,
                 timeout: Optional[pulumi.Input[float]] = None,
                 token: Optional[pulumi.Input[str]] = None,
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
            __props__ = ProviderArgs.__new__(ProviderArgs)

            __props__.__dict__["compute_endpoint"] = compute_endpoint
            __props__.__dict__["config"] = config
            if delay is not None and not opts.urn:
                warnings.warn("""Does nothing""", DeprecationWarning)
                pulumi.log.warn("""delay is deprecated: Does nothing""")
            __props__.__dict__["delay"] = pulumi.Output.from_input(delay).apply(pulumi.runtime.to_json) if delay is not None else None
            if dns_endpoint is None and not opts.urn:
                raise TypeError("Missing required property 'dns_endpoint'")
            __props__.__dict__["dns_endpoint"] = dns_endpoint
            __props__.__dict__["environment"] = environment
            __props__.__dict__["gzip_user_data"] = pulumi.Output.from_input(gzip_user_data).apply(pulumi.runtime.to_json) if gzip_user_data is not None else None
            __props__.__dict__["key"] = key
            if profile is not None and not opts.urn:
                warnings.warn("""Use region instead""", DeprecationWarning)
                pulumi.log.warn("""profile is deprecated: Use region instead""")
            __props__.__dict__["profile"] = profile
            __props__.__dict__["region"] = region
            __props__.__dict__["secret"] = secret
            if timeout is None and not opts.urn:
                raise TypeError("Missing required property 'timeout'")
            __props__.__dict__["timeout"] = pulumi.Output.from_input(timeout).apply(pulumi.runtime.to_json) if timeout is not None else None
            if token is not None and not opts.urn:
                warnings.warn("""Use key instead""", DeprecationWarning)
                pulumi.log.warn("""token is deprecated: Use key instead""")
            __props__.__dict__["token"] = token
        super(Provider, __self__).__init__(
            'exoscale',
            resource_name,
            __props__,
            opts)

    @property
    @pulumi.getter(name="computeEndpoint")
    def compute_endpoint(self) -> pulumi.Output[Optional[str]]:
        """
        Exoscale CloudStack API endpoint (by default: https://api.exoscale.com/v1)
        """
        return pulumi.get(self, "compute_endpoint")

    @property
    @pulumi.getter
    def config(self) -> pulumi.Output[Optional[str]]:
        """
        CloudStack ini configuration filename (by default: cloudstack.ini)
        """
        return pulumi.get(self, "config")

    @property
    @pulumi.getter(name="dnsEndpoint")
    def dns_endpoint(self) -> pulumi.Output[str]:
        """
        Exoscale DNS API endpoint (by default: https://api.exoscale.com/dns)
        """
        return pulumi.get(self, "dns_endpoint")

    @property
    @pulumi.getter
    def environment(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "environment")

    @property
    @pulumi.getter
    def key(self) -> pulumi.Output[Optional[str]]:
        """
        Exoscale API key
        """
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def profile(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "profile")

    @property
    @pulumi.getter
    def region(self) -> pulumi.Output[Optional[str]]:
        """
        CloudStack ini configuration section name (by default: cloudstack)
        """
        return pulumi.get(self, "region")

    @property
    @pulumi.getter
    def secret(self) -> pulumi.Output[Optional[str]]:
        """
        Exoscale API secret
        """
        return pulumi.get(self, "secret")

    @property
    @pulumi.getter
    def token(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "token")
